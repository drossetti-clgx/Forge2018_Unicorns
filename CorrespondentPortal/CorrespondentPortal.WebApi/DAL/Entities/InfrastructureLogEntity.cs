using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using CorrespondentPortal.WebApi.Domain.Services.InfrastructureLog;
using CorrespondentPortal.WebApi.Infrastructure.Shared;



namespace CorrespondentPortal.WebApi.DAL.Entities
{
    public class InfrastructureLogEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }
        [Column("LogLevel")]
        public LogLevel LogLevel { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        [Column("Content")]
        public string Content { get; set; }
        public string MachineName { get; set; }

        public InfrastructureLogEntity()
        {
        }

        public InfrastructureLogEntity(DateTime createdDate, LogLevel logLevel, string categroy, string content, string machineName)
        {
            CreatedDate = createdDate;
            LogLevel = logLevel;
            Category = categroy;
            Content = content;
            MachineName = machineName;
        }

        public InfrastructureLog ToInfrastructureLog()
        {
            return new InfrastructureLog(CreatedDate, LogLevel, Category, Content, MachineName);
        }
    }
}
