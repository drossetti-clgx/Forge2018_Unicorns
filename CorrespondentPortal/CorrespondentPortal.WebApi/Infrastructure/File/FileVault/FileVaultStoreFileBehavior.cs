using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileVault
{
    public class FileVaultStoreFileBehavior : IStoreFileBehavior
    {
        private readonly IJwtUtility _jwtUtility;
        private readonly IHttpUtility _httpUtility;
        private readonly IConfigurationService _configurationService;

        public FileVaultStoreFileBehavior(IJwtUtility jwtUtility, IHttpUtility httpUtility, IConfigurationService configurationSettings)
        {
            _jwtUtility = jwtUtility;
            _httpUtility = httpUtility;
            _configurationService = configurationSettings;
        }

        public async Task<HttpFragileOperationResult<StoreFileResult>> StoreFileAsync(byte[] bytes, string fileName)
        {
            var fileVaultUrl = _configurationService.ConfigurationSettings.FncFileVaultUrl + "/api/file/upload";

            var uploadParameters = new UploadFileParametersDto()
            {
                ExpirationInDays = 10,
                Filename = fileName,
                Mode = FileVaultFile.FileVaultFileMode.ReadOnly,
                Attributes = new FileAttributeSet()
            };

            var form = new MultipartFormDataContent
            {
                {new ByteArrayContent(bytes), "file", fileName},
                {new StringContent(JsonConvert.SerializeObject(uploadParameters)), "uploadParametersJson" }
            };

            var jwtResult = await _jwtUtility.GenerateJwtAsync().ConfigureAwait(false);

            if (jwtResult.Status != Status.Success)
            {
                return jwtResult.ToHttpFragileOperationResult<StoreFileResult>($"{jwtResult.Status} while storing file with filename {fileName}.");
            }

            var result = await _httpUtility.HttpPostContentAsync<string>(fileVaultUrl, form, new[] { new KeyValuePair<string, string>("Authorization", $"Bearer {jwtResult.Result.Jwt}"), }).ConfigureAwait(false);

            if (result.Status != Status.Success)
            {
                return result.ToHttpFragileOperationResult<StoreFileResult>($"{result.Status} while storing file with filename {fileName}.");
            }

            var identifier = result.Result.Replace("\"", "");
            return HttpFragileOperationResult<StoreFileResult>.CreateSuccessfulResult(new StoreFileResult(identifier), result.StatusCode, result.ResponseStringContent);
        }
    }
}
