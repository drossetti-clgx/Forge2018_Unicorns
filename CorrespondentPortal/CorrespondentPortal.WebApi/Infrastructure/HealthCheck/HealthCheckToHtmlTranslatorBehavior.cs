using System.Dynamic;
using System.Threading.Tasks;
using RazorLight;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.HealthCheck
{
    public class HealthCheckToHtmlTranslatorBehavior : IHealthCheckTranslationBehavior
    {
        private readonly IConfigurationService _configurationService;
        public HealthCheckToHtmlTranslatorBehavior(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        public async Task<string> Translate(HealthCheckUtilityResult healthCheckUtilityResult)
        {
            var healthCheckUtilityDto = healthCheckUtilityResult.ToDto();

            var engine = new RazorLightEngineBuilder().UseEmbeddedResourcesProject(typeof(Program)).UseMemoryCachingProvider().Build();

            dynamic viewBag = new ExpandoObject();
            viewBag.SiteURL = _configurationService.ConfigurationSettings.SiteURL;
            viewBag.Environment = _configurationService.ConfigurationSettings.Environment;

            var result = await engine.CompileRenderAsync("Views.Email.NotificationEmail", healthCheckUtilityDto, viewBag).ConfigureAwait(false);

            return result;
        }
    }
}
