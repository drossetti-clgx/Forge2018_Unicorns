using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog
{
    public class InfrastructureLogService : IInfrastructureLogService
    {
        private readonly IInfrastructureLogRepository _infrastructureLogRepository;
        public InfrastructureLogService(IInfrastructureLogRepository infrastructureLogRepository)
        {
            _infrastructureLogRepository = infrastructureLogRepository;
        }

        public async Task<InfrastructureLogServiceSearchResult> SearchLogsAsync(int start, int length, string searchValue, SortDirection sortDirection, InfrastructureLogSortColumnName sortColumnName, LogLevel[] logLevels)
        {
            var repositorySearchResult = await _infrastructureLogRepository.SearchLogsAsync(start, length, searchValue, sortDirection, sortColumnName, logLevels).ConfigureAwait(false);

            var infrastructureLogs = repositorySearchResult.FilteredLogs.Select(x => x.ToInfrastructureLog());

            return new InfrastructureLogServiceSearchResult(repositorySearchResult.TotalLogCount, repositorySearchResult.RecordsFiltered, infrastructureLogs);
        }

        public async Task SaveChangesAsync()
        {
            await _infrastructureLogRepository.SaveChangesAsync();
        }

        public void AddLog(InfrastructureLog infrastructureLog)
        {
            _infrastructureLogRepository.AddLog(infrastructureLog);
        }

        public void AddLog(LogLevel logLevel, string category, string content)
        {
            AddLog(new InfrastructureLog(DateTime.UtcNow, logLevel, category, content, Environment.MachineName));
        }

        public void AddDebugLog(string category, string content)
        {
            AddLog(LogLevel.Debug, category, content);
        }

        public void AddWarningLog(string category, string content)
        {
            AddLog(LogLevel.Warning, category, content);
        }

        public void AddErrorLog(string category, string content)
        {
            AddLog(LogLevel.Error, category, content);
        }

        public void AddTraceLog(string category, string content)
        {
            AddLog(LogLevel.Trace, category, content);
        }

        public void AddCriticalLog(string category, string content)
        {
            AddLog(LogLevel.Critical, category, content);
        }

        public void AddInformationLog(string category, string content)
        {
            AddLog(LogLevel.Information, category, content);
        }
    }
}
