using System.Collections.Generic;
using CorrespondentPortal.WebApi.DAL.Entities;

namespace CorrespondentPortal.WebApi.DAL.Repositories.InfrastructureLog
{
    public class InfrastructureLogRepositorySearchResult
    {
        public int TotalLogCount { get; set; }
        public int RecordsFiltered { get; set; }
        public List<InfrastructureLogEntity> FilteredLogs { get; set; }

        public InfrastructureLogRepositorySearchResult(int totalLogCount, int recordsFiltered, List<InfrastructureLogEntity> filteredLogs)
        {
            TotalLogCount = totalLogCount;
            FilteredLogs = filteredLogs;
            RecordsFiltered = recordsFiltered;
        }
    }
}
