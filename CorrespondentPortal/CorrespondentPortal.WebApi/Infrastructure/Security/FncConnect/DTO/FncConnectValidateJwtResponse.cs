namespace CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect.DTO
{
    public class FncConnectValidateJwtResponse
    {
        public FncConnectFullJwtDataDto JwtData { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
