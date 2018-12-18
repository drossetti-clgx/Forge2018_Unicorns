using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect.DTO;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using ThirdPartyOrigination.WebApi.Infrastructure.Security.FncConnect.DTO;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect
{
    public class FncConnectGenerateJwtBehavior : IGenerateJwtBehavior
    {
        private readonly IHttpUtility _httpUtility;
        private readonly IConfigurationService _configurationService;
        public FncConnectGenerateJwtBehavior(IHttpUtility httpUtility, IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _httpUtility = httpUtility;
        }

        public async Task<HttpFragileOperationResult<GenerateJwtResult>> GenerateJwtAsync(int expireTimeInMinutes = 60, IEnumerable<KeyValuePair<string, string>> additionalData = null)
        {
            var generateJwtRequest = new GenerateJwtRequest()
            {
                AppKey = _configurationService.ConfigurationSettings.FncConnectKey,
                AppSecret = _configurationService.ConfigurationSettings.FncConnectSecret,
                ExpireTimeInMinutes = expireTimeInMinutes,
                AdditionalData = additionalData
            };

            var result = await _httpUtility
                .HttpPostJsonAsync<string>(_configurationService.ConfigurationSettings.FncConnectUrl + "externalapi/jwt",
                    generateJwtRequest).ConfigureAwait(false);

            if (result.Status != Status.Success)
            {
                return result.ToHttpFragileOperationResult<GenerateJwtResult>($"{result.Status} while generating Jwt.");
            }

            return HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(new GenerateJwtResult(result.Result), result.StatusCode, result.ResponseStringContent);
        }
    }
}
