using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using CorrespondentPortal.WebApi.Infrastructure.Security.Extensions;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.AuthorizationRequirements
{
    public class UserInAtLeastOneGroupAuthorizationRequirement : AuthorizationHandler<UserInAtLeastOneGroupAuthorizationRequirement>, IAuthorizationRequirement
    {
        public string[] AllowedGroups;
        public UserInAtLeastOneGroupAuthorizationRequirement(string[] allowedGroups)
        {
            AllowedGroups = allowedGroups;
        }
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserInAtLeastOneGroupAuthorizationRequirement requirement)
        {
            if (context.User.Identity.IsAuthenticated && context.User.IsInAtLeastOneGroup(requirement.AllowedGroups))
            {
                context.Succeed(requirement);
            }
            return Task.CompletedTask;
        }
    }
}
