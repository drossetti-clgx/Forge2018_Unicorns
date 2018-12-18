using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public interface IHealthCheckable
    {
        Task<HealthCheck> GetHealthAsync();
    }
}
