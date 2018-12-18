using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect.DTO;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect
{
    public class FncConnectValidateJwtBehavior : IValidateJwtBehavior
    {
        private readonly IHttpUtility _httpUtility;
        private readonly IConfigurationService _configurationService;
        public FncConnectValidateJwtBehavior(IHttpUtility httpUtility, IConfigurationService configurationService)
        {
            _httpUtility = httpUtility;
            _configurationService = configurationService;
        }

        public async Task<HttpFragileOperationResult<ValidateJwtResult>> ValidateJwtAsync(string jwt)
        {
            var result = await _httpUtility
                .HttpPostJsonAsync<FncConnectValidateJwtResponse>(
                    _configurationService.ConfigurationSettings.FncConnectUrl + "externalapi/jwt/validate/true", jwt)
                .ConfigureAwait(false);

            if (result.Status != Status.Success)
            {
                return result.ToHttpFragileOperationResult<ValidateJwtResult>($"{result.Status} while validating Jwt.");
            }

            return HttpFragileOperationResult<ValidateJwtResult>.CreateSuccessfulResult(new ValidateJwtResult(result.Result.Success, result.Result.JwtData.AppInfo.ImmutableAppID.ToString()), result.StatusCode, result.ResponseStringContent);
        }
    }
}
