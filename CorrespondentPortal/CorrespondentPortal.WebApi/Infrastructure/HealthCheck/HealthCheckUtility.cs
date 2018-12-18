using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class HealthCheckUtility : IHealthCheckUtility
    {
        private readonly List<IHealthCheckable> _healthChecks;
        private readonly IHealthCheckNotifierUtility _healthCheckNotifierUtility;
        private readonly IConfigurationService _configurationService;
        public HealthCheckUtility(List<IHealthCheckable> healthChecks, IHealthCheckNotifierUtility healthCheckNotifierUtility, IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _healthChecks = healthChecks;
            _healthCheckNotifierUtility = healthCheckNotifierUtility;
        }

        public async Task<HealthCheckUtilityResult> GetHealthCheckResultAsync()
        {
            var healthCheckResult = new HealthCheckUtilityResult();

            foreach (var healthCheck in _healthChecks)
            {
                healthCheckResult.HealthChecks.Add(await healthCheck.GetHealthAsync().ConfigureAwait(false));
            }
            return healthCheckResult;
        }

        public async Task CheckHealthStatusAndNotifyAsync()
        {
            if (_configurationService.ConfigurationSettings.UseHealthCheckNotification)
            {
                var healthCheckResult = await GetHealthCheckResultAsync().ConfigureAwait(false);               
                if (healthCheckResult.Status == HealthStatus.Critical)
                {
                    await _healthCheckNotifierUtility.SendNotification(healthCheckResult).ConfigureAwait(false);
                }
            }
        }
    }
}
