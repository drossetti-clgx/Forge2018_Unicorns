using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog
{
    public class InfrastructureLogServiceSearchResult
    {
        public int TotalLogCount { get; set; }
        public int RecordsFiltered { get; set; }
        public IEnumerable<InfrastructureLog> FilteredLogs { get; set; }

        public InfrastructureLogServiceSearchResult(int totalLogCount, int recordsFiltered, IEnumerable<InfrastructureLog> filteredLogs)
        {
            TotalLogCount = totalLogCount;
            FilteredLogs = filteredLogs;
            RecordsFiltered = recordsFiltered;
        }
    }
}
