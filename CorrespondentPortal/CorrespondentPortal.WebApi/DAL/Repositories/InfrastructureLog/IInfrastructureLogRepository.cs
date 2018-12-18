using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog
{
    public interface IInfrastructureLogRepository : IDisposable
    {
        Task<InfrastructureLogRepositorySearchResult> SearchLogsAsync(int start, int length, string searchValue, SortDirection sortDirection, InfrastructureLogSortColumnName sortColumnName, LogLevel[] logLevels);
        void AddLog(Domain.Services.InfrastructureLog.InfrastructureLog infrastructureLog);
        Task SaveChangesAsync();
    }
}
