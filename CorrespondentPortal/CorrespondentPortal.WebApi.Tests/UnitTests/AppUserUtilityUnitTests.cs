using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Infrastructure.Security.User;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class AppUserUtilityUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void AppUserUtility_GetAppUser_ReturnsGetAppUserBehaviorResult()
        {
            //Arrange
            var getAppUserBehaviorResult = new AppUser()
            {
                Name = "testUser",
                IsAuthenticated = true,
                Claims = new List<Claim>(),
                ErrorMessage = "ErrorMessage"
            };

            var mockGetAppUserBehavior = new Mock<IGetAppUserBehavior>();
            mockGetAppUserBehavior.Setup(x => x.GetAppUser(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(getAppUserBehaviorResult);

            var appUserUtility = new AppUserUtility(mockGetAppUserBehavior.Object);

            //Act
            var result = appUserUtility.GetAppUser("", "");

            //Assert
            Assert.AreEqual(getAppUserBehaviorResult.IsAuthenticated, result.IsAuthenticated);
            Assert.AreEqual(getAppUserBehaviorResult.Claims, result.Claims);
            Assert.AreEqual(getAppUserBehaviorResult.Name, result.Name);
            Assert.AreEqual(getAppUserBehaviorResult.ErrorMessage, result.ErrorMessage);
        }
    }
}
