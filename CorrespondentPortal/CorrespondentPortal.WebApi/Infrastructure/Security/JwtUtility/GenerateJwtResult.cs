namespace CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility
{
    public class GenerateJwtResult
    {
        public string Jwt { get; }

        public GenerateJwtResult(string jwt)
        {
            Jwt = jwt;
        }
    }
}
