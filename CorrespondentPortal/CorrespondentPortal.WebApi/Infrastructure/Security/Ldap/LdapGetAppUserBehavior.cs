using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using CorrespondentPortal.WebApi.Infrastructure.Security.User;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public class LdapGetAppUserBehavior : IGetAppUserBehavior
    {
        private readonly ILdapUtility _ldapUtility;

        public LdapGetAppUserBehavior(ILdapUtility ldapUtility)
        {
            _ldapUtility = ldapUtility;
        }

        public AppUser GetAppUser(string username, string password)
        {
            try
            {
                var groups = _ldapUtility.GetGroups(username, password);

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username),
                    new Claim("Groups", groups.Aggregate((x, y) => x + "|" + y))
                };

                return new AppUser()
                {
                    Name = username,
                    IsAuthenticated = true,
                    Claims = claims
                };
            }
            catch (Exception e)
            {
                return new AppUser()
                {
                    Name = username,
                    IsAuthenticated = false,
                    ErrorMessage = e.Message
                };
            }
        }
    }
}
