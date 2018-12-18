using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public class CoreLogicConnectToAuthLdapBehavior : IConnectToAuthLdapBehavior
    {
        private readonly IConfigurationService _configurationService;
        public CoreLogicConnectToAuthLdapBehavior(IConfigurationService configurationSettings)
        {
            _configurationService = configurationSettings;
        }

        public LdapConnection Connect(string username, string password)
        {
            var coreLogicLdapConnection = new LdapConnection(new LdapDirectoryIdentifier(_configurationService.ConfigurationSettings.CoreLogicLdapServer, 389));
            coreLogicLdapConnection.Bind(new NetworkCredential(username, password));
            return coreLogicLdapConnection;
        }
    }
}
