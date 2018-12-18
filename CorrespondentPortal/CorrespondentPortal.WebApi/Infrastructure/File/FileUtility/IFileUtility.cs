using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public interface IFileUtility: IGetFileBehavior, IGetPublicUrlBehavior, IStoreFileBehavior, IHealthCheckable
    {

    }
}