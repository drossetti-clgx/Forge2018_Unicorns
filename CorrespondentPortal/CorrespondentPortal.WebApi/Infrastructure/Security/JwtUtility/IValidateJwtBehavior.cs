using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public interface IValidateJwtBehavior
    {
        Task<HttpFragileOperationResult<ValidateJwtResult>> ValidateJwtAsync(string jwt);
    }
}
