using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public interface IGetLdapGroupsBehavior
    {
        IEnumerable<string> GetGroups(LdapConnection authConnection, LdapConnection groupConnection, string username);
    }
}
