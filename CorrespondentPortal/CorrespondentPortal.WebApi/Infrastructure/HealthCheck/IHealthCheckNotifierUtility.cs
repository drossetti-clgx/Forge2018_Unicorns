using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public interface IHealthCheckNotifierUtility
    {
        Task<Operation> SendNotification(HealthCheckUtilityResult healthCheckUtilityResult);
    }
}
