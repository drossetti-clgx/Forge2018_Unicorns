using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public interface IGenerateJwtBehavior
    {
        Task<HttpFragileOperationResult<GenerateJwtResult>> GenerateJwtAsync(int expireTime = 60, IEnumerable<KeyValuePair<string, string>> additionalData = null);
    }
}
