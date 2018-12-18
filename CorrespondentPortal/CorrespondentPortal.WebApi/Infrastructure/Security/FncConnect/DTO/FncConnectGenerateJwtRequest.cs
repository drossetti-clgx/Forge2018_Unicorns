using System.Collections.Generic;

namespace ThirdPartyOrigination.WebApi.Infrastructure.Security.FncConnect.DTO
{
    public class GenerateJwtRequest
    {
        public int ExpireTimeInMinutes { get; set; }
        public string AppKey { get; set; }
        public string AppSecret { get; set; }
        public IEnumerable<KeyValuePair<string, string>> AdditionalData { get; set; } //Not required, but available if you want to require extra signed info in your flow
    }
}
