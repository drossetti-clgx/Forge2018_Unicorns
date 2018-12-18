using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault
{
    public class FileVaultGetPublicUrlBehavior : IGetPublicUrlBehavior
    {
        private readonly IJwtUtility _jwtUtility;
        private readonly IConfigurationService _configurationService;

        public FileVaultGetPublicUrlBehavior(IJwtUtility jwtUtility, IConfigurationService configurationService)
        {
            _jwtUtility = jwtUtility;
            _configurationService = configurationService;
        }

        public async Task<HttpFragileOperationResult<GetPublicUrlResult>> GetPublicUrlAsync(string identifier, int timeToLive = 60)
        {
            var generateJwtResult = await _jwtUtility.GenerateJwtAsync(timeToLive, new[] { new KeyValuePair<string, string>("fileId", identifier), }).ConfigureAwait(false);

            if (generateJwtResult.Status != Status.Success)
            {
                return generateJwtResult.ToHttpFragileOperationResult<GetPublicUrlResult>($"{generateJwtResult.Status} while getting public url with identifier {identifier}.");
            }
            var publicUrl = _configurationService.ConfigurationSettings.FncFileVaultUrl + $"file/public?jwt={generateJwtResult.Result.Jwt}";
            return HttpFragileOperationResult<GetPublicUrlResult>.CreateSuccessfulResult(new GetPublicUrlResult(publicUrl), generateJwtResult.StatusCode, generateJwtResult.ResponseStringContent );
        }
    }
}
