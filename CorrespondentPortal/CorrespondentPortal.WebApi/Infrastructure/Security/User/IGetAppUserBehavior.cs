namespace CorrespondentPortal.WebApi.Infrastructure.Security.User
{
    public interface IGetAppUserBehavior { 
        AppUser GetAppUser(string username, string password);
    }
}
