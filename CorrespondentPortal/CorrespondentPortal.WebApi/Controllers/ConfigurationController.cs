using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Security.Attributes;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly IConfigurationService _configurationService;
        public ConfigurationController(IConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet]
        [ApiUserAuthorize("AdminLimitedAccessGroups")]
        [Route("[controller]/Configurations")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public KeyValuePair<string, string>[] GetConfigurations()
        {
            return _configurationService.GetConfigurations();
        }

        [HttpPost]
        [ApiUserAuthorize("AdminLimitedAccessGroups")]
        [Route("[controller]/Configurations")]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<KeyValuePair<string, string>[]> UpdateConfigurations(KeyValuePair<string, string>[] configurations)
        {
            return await _configurationService.AddOrUpdateConfigurationsAsync(configurations);
        }
    }
}
