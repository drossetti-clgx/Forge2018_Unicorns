using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DAL.Repositories.Configuration
{
    public class ConfigurationRepository : DbContext, IConfigurationRepository
    {
        public DbSet<ConfigurationEntity> Configurations { get; set; }

        public ConfigurationRepository(DbContextOptions<ConfigurationRepository> options) : base(options)
        {

        }

        public string GetValueByKey(string id)
        {
            var config = Configurations.SingleOrDefault(x => x.Key == id);
            return config != null ? config.Value : "";
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync().ConfigureAwait(false);
        }

        public void AddOrUpdateConfiguration(string key, string value)
        {
            var configuration = Configurations.FirstOrDefault(x => x.Key == key);
            if (configuration == null)
            {
                Configurations.Add(new ConfigurationEntity(){Key = key, Value = value});
            }
            else
            {
                configuration.Value = value ?? "";
            }
        }

        public KeyValuePair<string, string>[] GetConfigurations()
        {
            return Configurations.Select(x => new KeyValuePair<string, string>(x.Key, x.Value)).ToArray();
        }
    }
}
