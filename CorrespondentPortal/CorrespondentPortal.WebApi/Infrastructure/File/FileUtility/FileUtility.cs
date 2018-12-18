using System.Text;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.File.FileUtility
{
    public class FileUtility : IFileUtility
    {
        private readonly IGetFileBehavior _getFileBehavior;
        private readonly IStoreFileBehavior _storeFileBehavior;
        private readonly IGetPublicUrlBehavior _getPublicUrlBehavior;

        public FileUtility(IGetFileBehavior getFileBehavior, IStoreFileBehavior storeFileBehavior, IGetPublicUrlBehavior getPublicUrlBehavior)
        {
            _getFileBehavior = getFileBehavior;
            _storeFileBehavior = storeFileBehavior;
            _getPublicUrlBehavior = getPublicUrlBehavior;
        }

        public async Task<HttpFragileOperationResult<GetFileResult>> GetFileAsync(string identifier)
        {
            return await _getFileBehavior.GetFileAsync(identifier).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperationResult<StoreFileResult>> StoreFileAsync(byte[] bytes, string filename)
        {
            return await _storeFileBehavior.StoreFileAsync(bytes, filename).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperationResult<GetPublicUrlResult>> GetPublicUrlAsync(string identifier, int timeToLive = 60)
        {
            return await _getPublicUrlBehavior.GetPublicUrlAsync(identifier, timeToLive);
        }

        public async Task<HealthCheck.HealthCheck> GetHealthAsync()
        {
            var healthCheck = new HealthCheck.HealthCheck("Files");
            var fileStorageVital = new Vital(HealthStatus.Active, "File Storage");
            var fileRetrievalVital = new Vital(HealthStatus.Active, "File Retrieval");
            var publicUrlGenerationVital = new Vital(HealthStatus.Active, "Public Url Generation");

            var storeFileResult = await StoreFileAsync(Encoding.ASCII.GetBytes("<helloWorld/>"), "HelloWorld.txt").ConfigureAwait(false);

            if (storeFileResult.Status != Status.Success)
            {
                fileStorageVital.Status = storeFileResult.Status == Status.Failed ? HealthStatus.Critical : HealthStatus.Warning;
                fileStorageVital.Message = storeFileResult.AggregateErrorMessages();

                fileRetrievalVital.Status = HealthStatus.Warning;
                fileRetrievalVital.Message = "Storage failed, retrieval defaults to warning";

                publicUrlGenerationVital.Status = HealthStatus.Warning;
                publicUrlGenerationVital.Message = "Storage failed, public url generation defaults to warning";
            }
            else
            {
                var getFileResult = await GetFileAsync(storeFileResult.Result.Identifier).ConfigureAwait(false);

                if (getFileResult.Status != Status.Success)
                {
                    fileRetrievalVital.Status = getFileResult.Status == Status.Failed ? HealthStatus.Critical : HealthStatus.Warning;
                    fileRetrievalVital.Message = getFileResult.AggregateErrorMessages();
                }

                var getPublicUrlResult = await GetPublicUrlAsync(storeFileResult.Result.Identifier);

                if (getPublicUrlResult.Status != Status.Success)
                {
                    publicUrlGenerationVital.Status = getPublicUrlResult.Status == Status.Failed ? HealthStatus.Critical : HealthStatus.Warning;
                    publicUrlGenerationVital.Message = getPublicUrlResult.AggregateErrorMessages();
                }
            }

            healthCheck.AddVital(fileStorageVital);
            healthCheck.AddVital(fileRetrievalVital);
            healthCheck.AddVital(publicUrlGenerationVital);

            return healthCheck;
        }
    }
}
