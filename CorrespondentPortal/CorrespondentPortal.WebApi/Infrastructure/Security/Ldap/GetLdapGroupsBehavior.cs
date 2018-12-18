using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public class GetLdapGroupsBehavior : IGetLdapGroupsBehavior
    {
        public IEnumerable<string> GetGroups(LdapConnection authConnection, LdapConnection groupConnection, string username)
        {
            var searchBase = GetSearchBase(authConnection);
            var userSid = GetUserSid(authConnection, searchBase, username);

            searchBase = GetSearchBase(groupConnection);
            var foreignSecurityPrincipalDistinguishedName = GetForeignSecurityPrincipalDistinguishedName(groupConnection, searchBase, userSid);
            return GetGroups(groupConnection, searchBase, foreignSecurityPrincipalDistinguishedName);
        }

        private static string GetSearchBase(DirectoryConnection ldapConnection)
        {
            var result = (SearchResponse)ldapConnection.SendRequest(new SearchRequest("", "objectClass=*", SearchScope.Base, "defaultnamingcontext"));
            return result != null && result.Entries.Count > 0 ? result.Entries[0].Attributes["defaultnamingcontext"][0].ToString() : "";
        }

        private static string GetForeignSecurityPrincipalDistinguishedName(DirectoryConnection ldapConnection, string searchBase, string userSid)
        {
            var result = (SearchResponse)ldapConnection.SendRequest(new SearchRequest(searchBase, "(&(objectClass=foreignSecurityPrincipal)(objectSid=" + userSid + "))", SearchScope.Subtree));
            return result != null && result.Entries.Count > 0 ? result.Entries[0].DistinguishedName : "";
        }

        private static string GetUserSid(DirectoryConnection ldapConnection, string searchBase, string username)
        {
            var result = (SearchResponse)ldapConnection.SendRequest(new SearchRequest(searchBase, "(sAMAccountName=" + username + ")", SearchScope.Subtree, "objectSid"));
            return result != null && result.Entries.Count > 0 ? ToLdapQueryableValue((byte[])result.Entries[0].Attributes["objectSid"][0]) : "";
        }

        private static IEnumerable<string> GetGroups(DirectoryConnection ldapConnection, string searchBase, string foreignSecurityPrincipalDistinguishedName)
        {
            var groups = new List<string>();

            var result = (SearchResponse)ldapConnection.SendRequest(new SearchRequest(searchBase, "(&(objectClass=group)(member=" + foreignSecurityPrincipalDistinguishedName + "))", SearchScope.Subtree, "cn"));

            if (result == null || result.Entries.Count <= 0) return groups.ToArray();

            for (var x = 0; x < result.Entries.Count; x++)
            {
                groups.Add(result.Entries[x].Attributes["cn"][0].ToString());
            }

            return groups.ToArray();
        }

        private static string ToLdapQueryableValue(IEnumerable<byte> source)
        {
            return source.Select(b => "\\" + b.ToString("X2")).Aggregate((a, b) => a + b);
        }
    }
}
