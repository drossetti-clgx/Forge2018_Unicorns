using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public interface IJwtUtility : IValidateJwtBehavior, IGenerateJwtBehavior, IHealthCheckable
    {
    }
}