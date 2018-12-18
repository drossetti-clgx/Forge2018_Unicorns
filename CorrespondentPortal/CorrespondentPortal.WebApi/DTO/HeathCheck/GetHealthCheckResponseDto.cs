using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DTO.HeathCheck
{
    public class GetHealthCheckResponseDto
    {
        public HealthStatus Status { get; set; }
        public string Message { get; set; }
        public List<HealthCheck> HealthChecks { get; set; }

        public GetHealthCheckResponseDto(HealthStatus status, List<HealthCheck> healthChecks, string message)
        {
            Status = status;
            HealthChecks = healthChecks;
            Message = message;
        }
    }
}
