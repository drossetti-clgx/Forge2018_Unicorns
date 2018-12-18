using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Ldap
{
    public class FncConnectToGroupLdapBehavior : IConnectToGroupLdapBehavior
    {
        private readonly IConfigurationService _configurationService;

        public FncConnectToGroupLdapBehavior(IConfigurationService configurationSettings)
        {
            _configurationService = configurationSettings;
        }

        public LdapConnection Connect()
        {
            var fncLdapServer = new LdapConnection(new LdapDirectoryIdentifier(_configurationService.ConfigurationSettings.FncLdapServer, 389));
            fncLdapServer.Bind();
            return fncLdapServer;
        }
    }
}
