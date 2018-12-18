using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.AzureAppServices.Internal;
using Microsoft.Extensions.Options;
using CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using Microsoft.Extensions.DependencyInjection;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Infrastructure.Logging
{
    public class InfrastructureLoggerProvider : ILoggerProvider
    {
        private InfrastructureLogger _infrastructureLogger;
        private readonly IServiceProvider _serviceProvider;

        public InfrastructureLoggerProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public ILogger CreateLogger(string categoryName)
        {
            _infrastructureLogger = new InfrastructureLogger(_serviceProvider, categoryName);
            return _infrastructureLogger;
        }

        public void Dispose()
        {
            _infrastructureLogger.Dispose();
        }
    }
}
