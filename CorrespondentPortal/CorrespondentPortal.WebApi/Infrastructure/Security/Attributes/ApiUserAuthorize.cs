using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Attributes
{
    public class ApiUserAuthorize : Attribute, IAsyncAuthorizationFilter
    {
        private readonly string _policy;
        public ApiUserAuthorize(string policy)
        {
            _policy = policy;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;
            var authorizeService = context.HttpContext.RequestServices.GetService<IAuthorizationService>();

            var isAllowed = await authorizeService.AuthorizeAsync(user, _policy);

            if (!isAllowed.Succeeded)
            {
                context.Result = new UnauthorizedResult();
            }
        }
    }
}
