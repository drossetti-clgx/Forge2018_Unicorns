namespace CorrespondentPortal.WebApi.Infrastructure.Security.User
{
    public interface IAppUserUtility: IGetAppUserBehavior
    {
        AppUser GetAppUser(string username, string password);
    }
}