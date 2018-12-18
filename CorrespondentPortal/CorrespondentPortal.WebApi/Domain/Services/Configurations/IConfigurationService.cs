using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.Configurations
{
    public interface IConfigurationService
    {
        KeyValuePair<string, string>[] GetConfigurations();
        Task<KeyValuePair<string, string>[]> AddOrUpdateConfigurationAsync(string key, string value);
        Task<KeyValuePair<string, string>[]> AddOrUpdateConfigurationsAsync(KeyValuePair<string, string>[] configurations);
        IConfigurationSettings ConfigurationSettings { get; }
    }
}
