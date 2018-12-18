using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog
{
    public interface IInfrastructureLogService
    {
        void AddTraceLog(string category, string content);
        void AddInformationLog(string category, string content);
        void AddErrorLog(string category, string content);
        void AddWarningLog(string category, string content);
        void AddCriticalLog(string category, string content);
        void AddLog(LogLevel logLevel, string category, string content);
        void AddLog(InfrastructureLog infrastructureLog);
        Task<InfrastructureLogServiceSearchResult> SearchLogsAsync(int start, int length, string searchValue, SortDirection sortDirection, InfrastructureLogSortColumnName sortColumnName, LogLevel[] logLevels);
        Task SaveChangesAsync();
    }
}