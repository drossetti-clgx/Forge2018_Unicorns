using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Domain.Services.Client
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EventCallbackUrl { get; set; }
        public DateTime CreatedDate { get; set; }

        public Client(int id, string name, string eventCallbackUrl, DateTime createdDate)
        {
            Id = id;
            Name = name;
            EventCallbackUrl = eventCallbackUrl;
            CreatedDate = createdDate;
        }
    }
}
