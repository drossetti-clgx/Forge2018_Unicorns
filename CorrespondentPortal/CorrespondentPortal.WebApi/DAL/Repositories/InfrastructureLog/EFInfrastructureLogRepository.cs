using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog
{
    public class EFInfrastructureLogRepository : DbContext, IInfrastructureLogRepository

    {
        public DbSet<InfrastructureLogEntity> InfrastructureLogs { get; set; }

        public EFInfrastructureLogRepository(DbContextOptions<EFInfrastructureLogRepository> options) : base(options)
        {
        }

        public async Task<InfrastructureLogRepositorySearchResult> SearchLogsAsync(int start, int length, string searchValue, SortDirection sortDirection, InfrastructureLogSortColumnName sortColumnName, LogLevel[] logLevels)
        {
            if (logLevels == null)
            {
                logLevels = new[] { LogLevel.Information, LogLevel.Debug, LogLevel.Trace, LogLevel.Warning, LogLevel.Error, LogLevel.Critical };
            }

            var recordsTotal = await InfrastructureLogs.CountAsync().ConfigureAwait(false);
            var filterQuery = InfrastructureLogs.Where(x => (x.Category.ToLower().Contains(searchValue.ToLower()) || x.Content.ToLower().Contains(searchValue.ToLower())) && logLevels.Contains(x.LogLevel));
            var recordsFiltered = await filterQuery.CountAsync().ConfigureAwait(false);


            switch (sortColumnName)
            {
                case InfrastructureLogSortColumnName.CreatedDate:
                    filterQuery = sortDirection == SortDirection.Ascending ? filterQuery.OrderBy(x => x.CreatedDate) : filterQuery.OrderByDescending(x => x.CreatedDate);
                    break;
                case InfrastructureLogSortColumnName.Severity:
                    filterQuery = sortDirection == SortDirection.Ascending ? filterQuery.OrderBy(x => x.LogLevel) : filterQuery.OrderByDescending(x => x.LogLevel);
                    break;
                case InfrastructureLogSortColumnName.Source:
                    filterQuery = sortDirection == SortDirection.Ascending ? filterQuery.OrderBy(x => x.Category) : filterQuery.OrderByDescending(x => x.LogLevel);
                    break;
                case InfrastructureLogSortColumnName.Content:
                    filterQuery = sortDirection == SortDirection.Ascending ? filterQuery.OrderBy(x => x.Content) : filterQuery.OrderByDescending(x => x.Content);
                    break;
                case InfrastructureLogSortColumnName.MachineName:
                    filterQuery = sortDirection == SortDirection.Ascending ? filterQuery.OrderBy(x => x.Content) : filterQuery.OrderByDescending(x => x.MachineName);
                    break;
            }

            filterQuery = filterQuery.Skip(start).Take(length);

            var filteredResult = await filterQuery.ToListAsync().ConfigureAwait(false);

            var searchResult = new InfrastructureLogRepositorySearchResult(recordsTotal, recordsFiltered, filteredResult);
            return searchResult;
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync().ConfigureAwait(false);
        }

        public void AddLog(Domain.Services.InfrastructureLog.InfrastructureLog infrastructureLog)
        {
            InfrastructureLogs.Add(new InfrastructureLogEntity(infrastructureLog.CreatedDate, infrastructureLog.LogLevel, infrastructureLog.Category, infrastructureLog.Content, infrastructureLog.MachineName));
        }
    }
}
