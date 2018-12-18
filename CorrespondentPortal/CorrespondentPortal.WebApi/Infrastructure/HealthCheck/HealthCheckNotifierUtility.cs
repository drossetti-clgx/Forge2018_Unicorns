using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Notification;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class HealthCheckNotifierUtility : IHealthCheckNotifierUtility
    {
        private readonly INotificationBehavior _notificationBehavior;
        private readonly IHealthCheckTranslationBehavior _healthCheckTranslationBehavior;
        public HealthCheckNotifierUtility(INotificationBehavior notificationBehavior, IHealthCheckTranslationBehavior healthCheckTranslationBehavior)
        {
            _notificationBehavior = notificationBehavior;
            _healthCheckTranslationBehavior = healthCheckTranslationBehavior;
        }
        public async Task<Operation> SendNotification(HealthCheckUtilityResult healthCheckUtilityResult)
        {
            var body = await _healthCheckTranslationBehavior.Translate(healthCheckUtilityResult);
            return await _notificationBehavior.Send(body);
        }
    }
}
