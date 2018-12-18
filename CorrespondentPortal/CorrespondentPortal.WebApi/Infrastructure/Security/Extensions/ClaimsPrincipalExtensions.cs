using System.Linq;
using System.Security.Claims;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsInAtLeastOneGroup(this ClaimsPrincipal claimsPrincipal, string[] groups)
        {
            var claim = claimsPrincipal.Claims.AsQueryable().SingleOrDefault(x => x.Type == "Groups");
            var memberOfGroups = (claim != null) ? claim.Value.Split('|') : new string[0];
            return memberOfGroups.Intersect(groups).Any();
        }
    }
}
