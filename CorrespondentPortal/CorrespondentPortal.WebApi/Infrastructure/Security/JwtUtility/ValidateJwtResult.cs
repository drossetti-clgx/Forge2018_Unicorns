namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public class ValidateJwtResult
    {
        public bool IsValid;
        public string ClientId;
        public ValidateJwtResult(bool isValid, string clientId)
        {
            IsValid = isValid;
            ClientId = clientId;
        }
    }
}
