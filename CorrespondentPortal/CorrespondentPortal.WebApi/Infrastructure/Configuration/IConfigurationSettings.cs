using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Configuration
{
    public interface IConfigurationSettings
    {
        string ReleaseName { get; }
        string KeyStoreLocation { get; }
        string Environment { get; }
        string FncConnectKey { get; }
        string FncConnectSecret { get; }
        string FncLdapServer { get; }
        string FncConnectUrl { get; }
        string CoreLogicLdapServer { get; }
        string FncFileVaultUrl { get; }
        string SmtpServer { get; }
        string HealthCheckNotificationTo { get; }
        string HealthCheckNotificationFrom { get; }
        string HealthCheckNotificationCheckInterval { get; }
        bool UseHealthCheckNotification { get; }
        string SiteURL { get; }
        string[] AdminLimitedAccessGroups { get; }
        string[] AdminAllAccessGroups { get; }
        LogLevel[] InfrastructureLogLevels { get; }

        void Load(IConfigurationRepository configurationRepository, IConfiguration configuration);
    }
}
