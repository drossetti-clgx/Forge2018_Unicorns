using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.Configurations
{
    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfigurationRepository _configurationRepository;

        public IConfigurationSettings ConfigurationSettings => Lazy.Value;

        private static readonly Lazy<ConfigurationSettings> Lazy = new Lazy<ConfigurationSettings>(() => new ConfigurationSettings());

        private const int CacheRefreshMinutes = 5;
        private static DateTime _lastCache = DateTime.MinValue;

        public ConfigurationService(IConfigurationRepository configurationRepository, IConfiguration configuration)
        {
            _configurationRepository = configurationRepository;
            if (DateTime.UtcNow > _lastCache.AddMinutes(CacheRefreshMinutes))
            {
                ConfigurationSettings.Load(configurationRepository, configuration);
                _lastCache = DateTime.UtcNow;
            }
        }

        public async Task<KeyValuePair<string, string>[]> AddOrUpdateConfigurationAsync(string key, string value)
        {
            _configurationRepository.AddOrUpdateConfiguration(key, value);
            await _configurationRepository.SaveChangesAsync().ConfigureAwait(false);
            return GetConfigurations();
        }

        public KeyValuePair<string, string>[] GetConfigurations()
        {
            return _configurationRepository.GetConfigurations();
        }

        public async Task<KeyValuePair<string, string>[]> AddOrUpdateConfigurationsAsync(KeyValuePair<string, string>[] configurations)
        {
            foreach (var configuration in configurations)
            {
                _configurationRepository.AddOrUpdateConfiguration(configuration.Key, configuration.Value);
            }
            await _configurationRepository.SaveChangesAsync().ConfigureAwait(false);
            return GetConfigurations();
        }
    }
}
