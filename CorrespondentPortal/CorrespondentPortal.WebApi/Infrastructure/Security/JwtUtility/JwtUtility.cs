using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public class JwtUtility : IJwtUtility
    {
        private readonly IValidateJwtBehavior _validateJwtBehavior;
        private readonly IGenerateJwtBehavior _generateJwtBehavior;

        public JwtUtility(IValidateJwtBehavior validateJwtBehavior, IGenerateJwtBehavior generateJwtBehavior)
        {
            _validateJwtBehavior = validateJwtBehavior;
            _generateJwtBehavior = generateJwtBehavior;
        }

        public async Task<HttpFragileOperationResult<ValidateJwtResult>> ValidateJwtAsync(string jwt)
        {
            return await _validateJwtBehavior.ValidateJwtAsync(jwt).ConfigureAwait(false);
        }

        public async Task<HttpFragileOperationResult<GenerateJwtResult>> GenerateJwtAsync(int expireTimeInMinutes = 60, IEnumerable<KeyValuePair<string, string>> additionalData = null)
        {
            return await _generateJwtBehavior.GenerateJwtAsync(expireTimeInMinutes, additionalData).ConfigureAwait(false);
        }

        public async Task<HealthCheck.HealthCheck> GetHealthAsync()
        {
            var healthCheck = new HealthCheck.HealthCheck("JWT Generate/Validate");
            var generateJwtVital = new Vital(HealthStatus.Active, "JWT Generation");
            var validateJwtVital = new Vital(HealthStatus.Active, "JWT Validation");

            //Generate Jwt Vital
            var generateJwtResult = await GenerateJwtAsync().ConfigureAwait(false);

            if (generateJwtResult.Status != Status.Success)
            {
                generateJwtVital.Status = generateJwtResult.Status == Status.Failed ? HealthStatus.Critical : HealthStatus.Warning;
                generateJwtVital.Message = generateJwtResult.AggregateErrorMessages();

                validateJwtVital.Status = HealthStatus.Warning;
                validateJwtVital.Message = "Generation failed, validation defaults to warning";
            }
            else
            {
                var jwt = generateJwtResult.Result.Jwt;
                var result = await ValidateJwtAsync(jwt).ConfigureAwait(false);
                if (result.Status != Status.Success)
                {
                    validateJwtVital.Status = result.Status == Status.Failed
                        ? HealthStatus.Critical
                        : HealthStatus.Warning;
                    validateJwtVital.Message = result.AggregateErrorMessages();
                }
                else if (!result.Result.IsValid)
                {
                    validateJwtVital.Status = HealthStatus.Critical;
                    validateJwtVital.Message = "Successful request, but invalid jwt.";
                }
            }

            healthCheck.AddVital(generateJwtVital);
            healthCheck.AddVital(validateJwtVital);

            return healthCheck;
        }
    }
}
