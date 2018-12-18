using System;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog
{

    public class InfrastructureLog
    {
        public DateTime CreatedDate { get; }
        public LogLevel LogLevel { get; }
        public string Category { get; }
        public string Content { get; }
        public string MachineName { get; }

        public InfrastructureLog()
        {

        }

        public InfrastructureLog(DateTime createdDate, LogLevel logLevel, string category, string content, string machineName)
        {
            CreatedDate = createdDate;
            LogLevel = logLevel;
            Category = category;
            Content = content;
            MachineName = machineName;
        }

        public string[] ToDataTablesDto()
        {
            return new[] { CreatedDate.ToString("s"), MachineName, LogLevel.ToString(), Category, Content };
        }
    }
}
