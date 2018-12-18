using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Notification
{
    public interface INotificationBehavior
    {
        Task<Operation> Send(string body);
    }
}
