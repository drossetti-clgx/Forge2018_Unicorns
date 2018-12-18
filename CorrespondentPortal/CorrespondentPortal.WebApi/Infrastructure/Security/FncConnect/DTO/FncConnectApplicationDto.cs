namespace CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect.DTO
{
    public class FncConnectApplicationDto
    {
        public long ImmutableAppID { get; set; }
        public string AppID { get; set; }
        public string AppName { get; set; }
        public string MainUrl { get; set; } //Probably not set
        public bool IsThirdParty { get; set; }
    }
}
