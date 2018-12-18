using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using CorrespondentPortal.WebApi.DAL.Repositories;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Configuration
{
    public sealed class ConfigurationSettings : IConfigurationSettings
    {
        public string ReleaseName { get; private set; }
        public string KeyStoreLocation { get; private set; }
        public string Environment { get; private set; }
        public string FncConnectKey { get; private set; }
        public string FncConnectSecret { get; private set; }
        public string FncLdapServer { get; private set; } = "fncinc.com";
        public string CoreLogicLdapServer { get; private set; } = "infosolco.net";
        public string FncConnectUrl { get; private set; }
        public string FncFileVaultUrl { get; private set; }
        public string SmtpServer { get; private set; }
        public string HealthCheckNotificationTo { get; private set; }
        public string HealthCheckNotificationFrom { get; private set; }
        public string HealthCheckNotificationCheckInterval { get; private set; }
        public bool UseHealthCheckNotification { get; private set; }
        public string SiteURL { get; private set; }

        public string[] AdminLimitedAccessGroups { get; private set; }
        public string[] AdminAllAccessGroups { get; private set; }
        public LogLevel[] InfrastructureLogLevels { get; private set; }

        public void Load(IConfigurationRepository configurationRepository, IConfiguration configuration)
        {
            Environment = configuration["environment"];
            ReleaseName = configuration["releaseName"];

            KeyStoreLocation = configurationRepository.GetValueByKey("KeyStoreLocation");
            FncConnectKey = configurationRepository.GetValueByKey("FncConnectKey");
            FncConnectSecret = configurationRepository.GetValueByKey("FncConnectSecret");
            FncConnectUrl = configurationRepository.GetValueByKey("FncConnectUrl");
            FncFileVaultUrl = configurationRepository.GetValueByKey("FncFileVaultUrl");
            AdminAllAccessGroups = string.IsNullOrEmpty(configurationRepository.GetValueByKey("AdminAllAccessGroups")) ? new string[] { } : configurationRepository.GetValueByKey("AdminAllAccessGroups").Split('|').Distinct().ToArray();
            AdminLimitedAccessGroups = (string.IsNullOrEmpty(configurationRepository.GetValueByKey("AdminLimitedAccessGroups")) ? new string[] { } : configurationRepository.GetValueByKey("AdminLimitedAccessGroups").Split('|')).Distinct().Union(AdminAllAccessGroups).ToArray();
            SmtpServer = configurationRepository.GetValueByKey("SmtpServer");
            HealthCheckNotificationTo = configurationRepository.GetValueByKey("HealthCheckNotificationTo");
            HealthCheckNotificationFrom = configurationRepository.GetValueByKey("HealthCheckNotificationFrom");
            HealthCheckNotificationCheckInterval = configurationRepository.GetValueByKey("HealthCheckNotificationCheckInterval");
            UseHealthCheckNotification = configurationRepository.GetValueByKey("UseHealthCheckNotification").ToLower() == "true";
            SiteURL = configurationRepository.GetValueByKey("SiteURL");

            //Log Levels
            var infrastructureLogLevels = configurationRepository.GetValueByKey("InfrastructureLogLevels").Split("|");

            InfrastructureLogLevels = infrastructureLogLevels.Select(x =>
            {
                switch (x.ToLower())
                {
                    case "debug":
                        return LogLevel.Debug;
                    case "information":
                        return LogLevel.Information;
                    case "warning":
                        return LogLevel.Warning;
                    case "trace":
                        return LogLevel.Trace;
                    case "error":
                        return LogLevel.Error;
                    case "critical":
                        return LogLevel.Critical;
                    default:
                        return LogLevel.None;
                }
            }).Distinct().ToArray();
        }
    }
}
