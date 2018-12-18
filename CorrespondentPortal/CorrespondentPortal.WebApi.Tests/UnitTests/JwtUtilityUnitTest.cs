using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class JwtUtilityUnitTest
    {

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlity_GenerateJwt_ReturnsGenerateJwtBehaviorResult()
        {
            //Arrange
            var generateJwtBehaviorResult = new GenerateJwtResult("jwt");

            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>()))
                .Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(generateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtUtility = new JwtUtility(null, jwtGenerateBehaviorMock.Object);

            //Act
            var result = await jwtUtility.GenerateJwtAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(generateJwtBehaviorResult.Jwt, result.Result.Jwt);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlity_GenerateJwt_ReturnsValidateJwtBehaviorResult()
        {
            //Arrange
            var validateJwtBehaviorResult = new ValidateJwtResult(true, "123");
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            jwtValidateBehavior.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateSuccessfulResult(validateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, null);

            //Act
            var result = await jwtUtility.ValidateJwtAsync("AnyJwt").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(validateJwtBehaviorResult.ClientId, "123");
            Assert.IsTrue(validateJwtBehaviorResult.IsValid);
            Assert.AreEqual(0, result.ErrorMessages.Count());
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlityHealthCheck_GetHealth_ReturnsActiveHealthCheckResult_WhenAllGood()
        {
            //Arrange
            var validateJwtBehaviorResult = new ValidateJwtResult(true, "123");
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            jwtValidateBehavior.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateSuccessfulResult(validateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var generateJwtBehaviorResult = new GenerateJwtResult("jwt");
            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(generateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object);

            //Act
            var result = await jwtUtility.GetHealthAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Active, result.Status);
            Assert.AreEqual("JWT Generate/Validate", result.Description);
            Assert.AreEqual(2, result.Vitals.Count);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlityHealthCheck_GetHealth_ReturnsWarningHealthCheckResult_WhenGenerateBehaviorResultsInError()
        {
            //Arrange
            var validateJwtBehaviorResult = new ValidateJwtResult(true, "123");
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            jwtValidateBehavior.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateSuccessfulResult(validateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateErrorResult(HttpStatusCode.InternalServerError, "", "TestMessage")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object);

            //Act
            var result = await jwtUtility.GetHealthAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Warning, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlityHealthCheck_GetHealth_ReturnsWarningHealthCheckResult_WhenValidateBehaviorResultIsError()
        {
            //Arrange
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            jwtValidateBehavior.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateErrorResult(HttpStatusCode.InternalServerError, "", "TestMessage")));

            var generateJwtBehaviorResult = new GenerateJwtResult("jwt");

            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(generateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object);

            //Act
            var result = await jwtUtility.GetHealthAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Warning, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task JwtUtlityHealthCheck_GetHealth_ReturnsCriticalHealthCheckResult_WhenValidateBehaviorResultIsFailed()
        {
            //Arrange
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            jwtValidateBehavior.Setup(x => x.ValidateJwtAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<ValidateJwtResult>.CreateFailedResult(HttpStatusCode.BadRequest, "", "TestMessage")));

            var generateJwtBehaviorResult = new GenerateJwtResult("jwt");
            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateSuccessfulResult(generateJwtBehaviorResult, HttpStatusCode.OK, "")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object);

            //Act
            var result = await jwtUtility.GetHealthAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Critical, result.Status);
        }
    }
}
