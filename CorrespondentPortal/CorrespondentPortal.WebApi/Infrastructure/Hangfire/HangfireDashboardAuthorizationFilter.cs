using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire.Dashboard;
using CorrespondentPortal.WebApi.Infrastructure.Security.Extensions;

namespace CorrespondentPortal.WebApi.Infrastructure.Hangfire
{
    public class HangfireDashboardAuthorizationFilter : IDashboardAuthorizationFilter
    {
        private readonly string[] _allowedGroups;
        public HangfireDashboardAuthorizationFilter(string[] allowedGroups)
        {
            _allowedGroups = allowedGroups;
        }

        public bool Authorize(DashboardContext context)
        {
            var currentUser = context.GetHttpContext().User;
            return currentUser.Identity.IsAuthenticated && currentUser.IsInAtLeastOneGroup(_allowedGroups);
        }
    }
}
