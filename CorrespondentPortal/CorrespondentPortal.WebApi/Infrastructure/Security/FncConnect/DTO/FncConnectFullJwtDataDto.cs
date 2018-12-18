using System.Collections.Generic;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect.DTO
{
    public class FncConnectFullJwtDataDto
    {
        public FncConnectApplicationDto AppInfo { get; set; }
        public Dictionary<string, string> Payload { get; set; } //This would be the AdditionalData from above
    }
}
