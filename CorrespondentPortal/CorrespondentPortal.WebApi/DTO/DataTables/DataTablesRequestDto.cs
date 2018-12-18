using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.DTO.DataTables
{
    public class DataTablesRequestDto
    {
        public int Draw { get; set; }
        public int RecordsFiltered { get; set; }
        public int RecordsTotal { get; set; }
        public string SearchValue { get; set; }
        public InfrastructureLogSortColumnName SortColumnName { get; set; }
        public SortDirection SortDirection { get; set; }
        public int Length { get; set; }
        public int Start { get; set; }
        public int ResultsTotal { get; set; }
        public LogLevel[] LogLevels { get; set; }

        private readonly Dictionary<string, InfrastructureLogSortColumnName> _infrastructureLogColumnNameMappingLookup =
            new Dictionary<string, InfrastructureLogSortColumnName>()
            {
                {"createdDate", InfrastructureLogSortColumnName.CreatedDate},
                {"severity", InfrastructureLogSortColumnName.Severity},
                {"source", InfrastructureLogSortColumnName.Source},
                {"content", InfrastructureLogSortColumnName.Content},
                {"machineName", InfrastructureLogSortColumnName.MachineName }
            };

        public DataTablesRequestDto(IQueryCollection request)
        {
            Draw = Convert.ToInt32(request["draw"]);
            RecordsTotal = Convert.ToInt32(request["recordsTotal"]);
            SearchValue = Convert.ToString(request["search[value]"]) ?? "";
            SortColumnName = _infrastructureLogColumnNameMappingLookup[Convert.ToString(request["columns[" + request["order[0][column]"] + "][name]"]) ?? "createdDate"];
            SortDirection = request["order[0][dir]"] == "asc" ? SortDirection.Ascending : SortDirection.Descending;
            Length = Convert.ToInt32(request["length"]) == 0 ? 10 : Convert.ToInt32(request["length"]);
            Start = Convert.ToInt32(request["start"]);

            //Log Levels
            LogLevels = Convert.ToString(request["logLevels"]).Split('|').Select(x =>
            {
                switch (x.ToLower())
                {
                    case "information":
                        return LogLevel.Information;
                    case "debug":
                        return LogLevel.Debug;
                    case "error":
                        return LogLevel.Error;
                    case "warning":
                        return LogLevel.Warning;
                    case "critical":
                        return LogLevel.Critical;
                    default:
                        return LogLevel.None;
                }
            }).ToArray();
        }
    }
}
