using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.User
{
    public class AppUserUtility : IAppUserUtility
    {
        private readonly IGetAppUserBehavior _getAppUserBehavior;
        public AppUserUtility(IGetAppUserBehavior getAppUserBehavior)
        {
            _getAppUserBehavior = getAppUserBehavior;
        }

        public AppUser GetAppUser(string username, string password)
        {
            return _getAppUserBehavior.GetAppUser(username, password);
        }
    }
}
