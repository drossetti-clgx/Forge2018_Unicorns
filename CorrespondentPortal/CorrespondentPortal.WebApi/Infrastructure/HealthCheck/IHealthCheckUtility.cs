using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public interface IHealthCheckUtility
    {
        Task<HealthCheckUtilityResult> GetHealthCheckResultAsync();
        Task CheckHealthStatusAndNotifyAsync();
    }
}