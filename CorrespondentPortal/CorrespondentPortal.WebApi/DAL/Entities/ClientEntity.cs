using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.DAL.Entities
{
    public class ClientEntity
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("EventCallbackUrl")]
        public string EventCallbackUrl { get; set; }
        [Column("CreatedDate")]
        public DateTime CreatedDate { get; set; }

        public ClientEntity()
        {

        }
    }
}
