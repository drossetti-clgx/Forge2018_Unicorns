using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using CorrespondentPortal.WebApi.Domain.Services.Configurations;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Security.User;

namespace CorrespondentPortal.WebApi.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAppUserUtility _appUserUtility;
        private readonly string _releaseName;

        public AccountController(IAppUserUtility appUserUtility, IConfigurationService configurationSettings)
        {
            _appUserUtility = appUserUtility;
            _releaseName = configurationSettings.ConfigurationSettings.ReleaseName;
        }

        [Route("Account/SignIn")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult SignIn()
        {
            ViewBag.PageTitle = "Sign In";
            ViewBag.ReleaseName = _releaseName;
            return View("SignIn");
        }

        [Route("Account/Unauthorized")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public IActionResult UnauthorizedRequest()
        {
            ViewBag.ReleaseName = _releaseName;
            return View("Unauthorized");
        }

        [Route("Account/SignOut")]
        [HttpGet]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> SignOut()
        {
            ViewBag.ReleaseName = _releaseName;
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn");
        }

        [Route("Account/SignIn")]
        [HttpPost]
        [ApiExplorerSettings(IgnoreApi = true)]
        public async Task<IActionResult> SignIn(string username, string password, string returnUrl)
        {

            var pathBase = Request.PathBase.ToString();

            var appUser = _appUserUtility.GetAppUser(username, password);

            if (!appUser.IsAuthenticated) return Unauthorized();

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(new ClaimsIdentity(appUser.Claims, CookieAuthenticationDefaults.AuthenticationScheme)),
                new AuthenticationProperties());

            return Ok(string.IsNullOrEmpty(returnUrl) ? $"{pathBase}/" : returnUrl);
        }
    }
}