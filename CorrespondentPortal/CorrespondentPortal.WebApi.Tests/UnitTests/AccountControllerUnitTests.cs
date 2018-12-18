using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Controllers;
using CorrespondentPortal.WebApi.Infrastructure.Security.User;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class AccountControllerUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public async Task AccountController_SignIn_Returns200_WhenAppUserUtilityReturnsAuthenticatedUser()
        {
            //Arrange
            const string username = "testuser";
            const string password = "somePassword";
            const string returnUrl = "/test/";

            var appUserUtilityGetAppUserResult = new AppUser()
            {
                IsAuthenticated = true
            };

            var appUserUtilityMock = new Mock<IAppUserUtility>();
            appUserUtilityMock.Setup(x => x.GetAppUser(username, password))
                .Returns(appUserUtilityGetAppUserResult);

            var accountController = CreateAccountController(appUserUtilityMock.Object);

            //Act
            var result = (OkObjectResult) await accountController.SignIn(username, password, returnUrl);

            //Assert
            Assert.AreEqual((int)HttpStatusCode.OK, result.StatusCode);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task AccountController_SignIn_Returns401_WhenAppUserUtilityReturnsUnAuthenticatedUser()
        {
            //Arrange
            const string username = "testuser";
            const string password = "somePassword";
            const string returnUrl = "/test/";

            var appUserUtilityGetAppUserResult = new AppUser()
            {
                IsAuthenticated = false
            };

            var appUserUtilityMock = new Mock<IAppUserUtility>();
            appUserUtilityMock.Setup(x => x.GetAppUser(username, password))
                .Returns(appUserUtilityGetAppUserResult);

            var accountController = CreateAccountController(appUserUtilityMock.Object);

            //Act
            var result = (UnauthorizedResult)await accountController.SignIn(username, password, returnUrl);

            //Assert
            Assert.AreEqual((int)HttpStatusCode.Unauthorized, result.StatusCode);
        }

        private static AccountController CreateAccountController(IAppUserUtility appUserUtility)
        {
            return new AccountController(appUserUtility, TestHelper.GetConfigurationSettings())
            {
                ControllerContext = new ControllerContext()
                {
                    HttpContext = new DefaultHttpContext()
                    {
                        Request =
                        {
                            PathBase = ""
                        },
                        RequestServices = GetCookieAuthServiceProvider()
                    }
                }
            };
        }

        private static ServiceProvider GetCookieAuthServiceProvider()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
            serviceCollection.AddLogging();
            return serviceCollection.BuildServiceProvider();
        }
    }
}
