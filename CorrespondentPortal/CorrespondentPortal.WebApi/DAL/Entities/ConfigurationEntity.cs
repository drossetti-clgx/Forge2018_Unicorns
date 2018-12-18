using System.ComponentModel.DataAnnotations;

namespace CorrespondentPortal.WebApi.DAL.Entities
{
    public class ConfigurationEntity
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
