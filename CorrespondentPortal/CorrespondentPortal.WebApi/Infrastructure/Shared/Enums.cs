using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.Shared
{
    public enum HealthStatus
    {
        Active = 0,
        Warning = 1,
        Critical = 2
    }

    public enum Status
    {
        Success,
        Failed,
        Error
    }

    public enum LogSeverity
    {
        Verbose = 0,
        Warning = 1,
        Error = 2
    }

    public enum SortDirection
    {
        Ascending = 0,
        Descending = 1
    }

    public enum InfrastructureLogSortColumnName
    {
        CreatedDate,
        Severity,
        Source,
        Content,
        MachineName
    }
}
