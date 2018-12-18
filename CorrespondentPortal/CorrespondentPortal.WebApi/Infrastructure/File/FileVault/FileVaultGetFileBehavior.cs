using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault
{
    public class FileVaultGetFileBehavior : IGetFileBehavior
    {
        private readonly IJwtUtility _jwtUtility;
        private readonly IHttpUtility _httpUtility;
        private readonly IConfigurationService _configurationService;

        public FileVaultGetFileBehavior(IJwtUtility jwtUtility, IHttpUtility httpUtility, IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _jwtUtility = jwtUtility;
            _httpUtility = httpUtility;
        }

        public async Task<HttpFragileOperationResult<GetFileResult>> GetFileAsync(string identifier)
        {
            var fileVaultUrl = _configurationService.ConfigurationSettings.FncFileVaultUrl + $"api/file/{identifier}/false";
            var generateJwtResult = await _jwtUtility.GenerateJwtAsync().ConfigureAwait(false);

            if (generateJwtResult.Status != Status.Success)
            {
                return generateJwtResult.ToHttpFragileOperationResult<GetFileResult>($"{generateJwtResult.StatusCode} while getting file with identifier {identifier}.");
            }

            var result = await _httpUtility.HttpGetAsync<FileVaultFile>(fileVaultUrl, new[] { new KeyValuePair<string, string>("Authorization", $"Bearer {generateJwtResult.Result.Jwt}"), }).ConfigureAwait(false);

            if (result.Status != Status.Success)
            {
                return result.ToHttpFragileOperationResult<GetFileResult>($"{result.StatusCode} while getting file with identifier {identifier}.");
            }
            return HttpFragileOperationResult<GetFileResult>.CreateSuccessfulResult(new GetFileResult(result.Result.FileAsByteArray, result.Result.Filename), result.StatusCode, result.ResponseStringContent);
        }
    }
}
