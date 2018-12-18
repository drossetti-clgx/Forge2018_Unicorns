using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Infrastructure.Security.Attributes
{
    public class JwtAuthenticationServiceFilterAttribute : ServiceFilterAttribute
    {
        public JwtAuthenticationServiceFilterAttribute() : base(typeof(JwtAuthenticationAttribute))
        {

        }
    }

    public class JwtAuthenticationAttribute : Attribute, IAsyncAuthorizationFilter
    {
        private readonly IJwtUtility _jwtUtility;

        public JwtAuthenticationAttribute(IJwtUtility jwtUtility)
        {
            _jwtUtility = jwtUtility;
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var httpContext = context.HttpContext;
            var authorizeHeaders = httpContext.Request.Headers.Where(e => e.Key == "Authorization").ToArray();
            if (authorizeHeaders.Any())
            {
                string headerValue = authorizeHeaders.FirstOrDefault().Value;
                var validateJwtResult = await _jwtUtility.ValidateJwtAsync(headerValue);
                if (validateJwtResult.Status == Status.Success && validateJwtResult.Result.IsValid)
                {
                    httpContext.Items["ClientId"] = validateJwtResult.Result.ClientId;
                    return;
                }
            }
            context.Result = new UnauthorizedResult();
        }
    }
}
