using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Hangfire
{
    public class HangfireHealthCheck : IHealthCheckable
    {
        public Task<HealthCheck.HealthCheck> GetHealthAsync()
        {
            var healthCheck = new HealthCheck.HealthCheck("Hangfire");

            try
            {
                var api = JobStorage.Current.GetMonitoringApi().GetStatistics();
                healthCheck.AddVital("API", HealthStatus.Active);
                var serversHealthStatus = api.Servers > 0 ? HealthStatus.Active : HealthStatus.Critical;
                healthCheck.AddVital("Servers", serversHealthStatus,
                    serversHealthStatus != HealthStatus.Active ? "No active servers detected" : "");

                var jobStatusHealthStatus = api.Failed == 0 ? HealthStatus.Active : HealthStatus.Critical;
                healthCheck.AddVital("Jobs", jobStatusHealthStatus,
                    jobStatusHealthStatus != HealthStatus.Active ? "One or more jobs are in the failed queue" : "");
            }
            catch (Exception e)
            {
                healthCheck.AddVital("API", HealthStatus.Critical, e.Message);
            }

            return Task.FromResult(healthCheck);
        }
    }
}
