using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public interface IHealthCheckTranslationBehavior
    {
        Task<string> Translate(HealthCheckUtilityResult healthCheckUtilityResult);
    }
}
