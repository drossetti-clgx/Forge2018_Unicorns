using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DAL.Repositories.Configuration
{
    public interface IConfigurationRepository : IDisposable
    {
        KeyValuePair<string, string>[] GetConfigurations();
        void AddOrUpdateConfiguration(string key, string value);
        string GetValueByKey(string id);
        Task SaveChangesAsync();
    }
}
