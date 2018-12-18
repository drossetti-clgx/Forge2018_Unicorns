using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public class LdapUtility : ILdapUtility
    {
        private readonly IConnectToGroupLdapBehavior _connectToGroupLdapBehavior;
        private readonly IConnectToAuthLdapBehavior _connectToAuthLdapBehavior;
        private readonly IGetLdapGroupsBehavior _getLdapGroupsBehavior;

        public LdapUtility(IConnectToAuthLdapBehavior connectToAuthLdapBehavior, IConnectToGroupLdapBehavior connectToGroupLdapBehavior, IGetLdapGroupsBehavior getLdapGroupsBehavior)
        {
            _connectToGroupLdapBehavior = connectToGroupLdapBehavior;
            _connectToAuthLdapBehavior = connectToAuthLdapBehavior;
            _getLdapGroupsBehavior = getLdapGroupsBehavior;
        }

        public IEnumerable<string> GetGroups(string username, string password)
        {
            using (var groupLdapConnection = _connectToGroupLdapBehavior.Connect())
            {
                using (var authLdapConnection = _connectToAuthLdapBehavior.Connect(username, password))
                {
                    return _getLdapGroupsBehavior.GetGroups(authLdapConnection, groupLdapConnection, username);
                }
            }
        }

        public Task<HealthCheck.HealthCheck> GetHealthAsync()
        {
            var userName = "ISC-SA-FNCAutomation";
            var password = "Core@123";

            var healthCheck = new HealthCheck.HealthCheck("LDAP Connections");

            var authConnectionVital = new Vital(HealthStatus.Active, "Authorization Connection");
            try
            {
                _connectToAuthLdapBehavior.Connect(userName, password);
            }
            catch (LdapException e)
            {
                authConnectionVital.Status = HealthStatus.Warning;
                authConnectionVital.Message = e.Message;
            }

            healthCheck.AddVital(authConnectionVital);

            var groupConnectionVital = new Vital(HealthStatus.Active, "Group Connection");
            try
            {
                _connectToGroupLdapBehavior.Connect();
            }
            catch (LdapException e)
            {
                groupConnectionVital.Status = HealthStatus.Warning;
                groupConnectionVital.Message = e.Message;
            }

            healthCheck.AddVital(groupConnectionVital);

            var getGroupsVital = new Vital(HealthStatus.Active, "Get Groups");
            
            try
            {
                _getLdapGroupsBehavior.GetGroups(_connectToAuthLdapBehavior.Connect(userName, password), _connectToGroupLdapBehavior.Connect(), userName);
            }
            catch (LdapException e)
            {
                getGroupsVital.Status = HealthStatus.Warning;
                getGroupsVital.Message = e.Message;
            }

            healthCheck.AddVital(getGroupsVital);

            return Task.FromResult(healthCheck);
        }
    }
}
