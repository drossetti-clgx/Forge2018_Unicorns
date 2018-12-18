using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public interface IStoreFileBehavior
    {
        Task<HttpFragileOperationResult<StoreFileResult>> StoreFileAsync(byte[] bytes, string filename);
    }
}