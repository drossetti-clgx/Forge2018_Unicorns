using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public interface IGetFileBehavior
    {
        Task<HttpFragileOperationResult<GetFileResult>> GetFileAsync(string identifier);
    }
}