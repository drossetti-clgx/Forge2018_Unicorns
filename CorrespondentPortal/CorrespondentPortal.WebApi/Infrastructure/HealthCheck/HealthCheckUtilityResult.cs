using System.Collections.Generic;
using System.Linq;
using CorrespondentPortal.WebApi.DTO.HeathCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class HealthCheckUtilityResult
    {
        public HealthStatus Status
        {
            get
            {
                if (HealthChecks.Any(x => x.Status == HealthStatus.Critical))
                {
                    return HealthStatus.Critical;
                }

                return HealthChecks.Any(x => x.Status == HealthStatus.Warning) ? HealthStatus.Warning : HealthStatus.Active;
            }
        }

        public string Message
        {
            get
            {
                if (Status == HealthStatus.Critical || Status == HealthStatus.Warning)
                {
                    return $"One or more system components have a status of {Status}.";
                }

                return $"All system components are {Status}.";
            }
        }

        private List<HealthCheck> _healthChecks = new List<HealthCheck>();

        public List<HealthCheck> HealthChecks
        {
            get
            {
                _healthChecks = _healthChecks.Any() ? _healthChecks.OrderByDescending(x => x.Status).ToList() : _healthChecks;
                return _healthChecks;
            }
            set => _healthChecks = value;
        }

        public GetHealthCheckResponseDto ToDto()
        {
            return new GetHealthCheckResponseDto(Status, HealthChecks, Message);
        }
    }
}
