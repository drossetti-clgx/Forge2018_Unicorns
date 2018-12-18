using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.DTO.DataTables
{
    public class DataTablesResponseDto
    {
        [DataMember(Name = "draw")]
        public int Draw { get; set; }
        [DataMember(Name = "recordsTotal")]
        public int RecordsTotal { get; set; }
        [DataMember(Name = "recordsFiltered")]
        public int RecordsFiltered { get; set; }
        [DataMember(Name = "data")]
        public string[][] Data { get; set; }
    }
}
