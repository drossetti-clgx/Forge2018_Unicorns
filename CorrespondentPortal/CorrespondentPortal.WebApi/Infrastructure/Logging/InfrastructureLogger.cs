using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Logging
{
    public class InfrastructureLogger : ILogger, IDisposable
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly string _categoryName;
        private readonly int _batch = 10;
        private static readonly ConcurrentBag<InfrastructureLog> InfrastructureLogs = new ConcurrentBag<InfrastructureLog>();


        public InfrastructureLogger(IServiceProvider serviceProvider, string categroyName)
        {
            _categoryName = categroyName;
            _serviceProvider = serviceProvider;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            var configurationService = _serviceProvider.GetService<IConfigurationService>();
            return !configurationService.ConfigurationSettings.InfrastructureLogLevels.Contains(LogLevel.None) && configurationService.ConfigurationSettings.InfrastructureLogLevels.Contains(logLevel);
        }

        public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (IsEnabled(logLevel))
            {
                var result = formatter(state, exception);

                if (exception != null)
                {
                    result += $" \nException: {exception}";
                }

                InfrastructureLogs.Add(new InfrastructureLog(DateTime.UtcNow, logLevel, _categoryName, $"{result}", Environment.MachineName));
                if (InfrastructureLogs.Count == _batch || logLevel == LogLevel.Error || logLevel == LogLevel.Critical || logLevel == LogLevel.Warning)
                {
                    await FlushLogs();
                    InfrastructureLogs.Clear();
                }
            }
        }

        private async Task FlushLogs()
        {
            var infrastructureLogRepository = _serviceProvider.GetService<IInfrastructureLogRepository>();
            foreach (var log in InfrastructureLogs)
            {
                infrastructureLogRepository.AddLog(log);
                await infrastructureLogRepository.SaveChangesAsync();
                InfrastructureLogs.Clear();
            }
        }

        public async void Dispose()
        {
            await FlushLogs();
        }
    }
}
