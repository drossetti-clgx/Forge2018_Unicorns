using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public interface IGetPublicUrlBehavior
    {
        Task<HttpFragileOperationResult<GetPublicUrlResult>> GetPublicUrlAsync(string identifier, int timeToLive = 60);
    }
}
