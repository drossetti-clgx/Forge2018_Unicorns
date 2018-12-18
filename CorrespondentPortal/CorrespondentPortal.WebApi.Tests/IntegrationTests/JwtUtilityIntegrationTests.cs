using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.FncConnect;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.IntegrationTests
{
    [TestClass]
    public class JwtUtilityIntegrationTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task JwtUtility_GenerateJwt_FncConnectGenerateJwtBehavior()
        {
            //Arrange
            var fncConnectGenerateJwtBehavior = new FncConnectGenerateJwtBehavior(new HttpUtility(), TestHelper.GetConfigurationSettings());
            var jwtUtility = new JwtUtility(null, fncConnectGenerateJwtBehavior);

            //Act
            var generateJwtResult = await jwtUtility.GenerateJwtAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Success, generateJwtResult.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(generateJwtResult.Result.Jwt));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task JwtUtility_GenerateJwt_FncConnectValidateJwtBehavior()
        {
            //Arrange
            var fncConnectGenerateJwtBehavior = new FncConnectGenerateJwtBehavior(new HttpUtility(), TestHelper.GetConfigurationSettings());
            var fncConnectValidateJwtBehavior = new FncConnectValidateJwtBehavior(new HttpUtility(), TestHelper.GetConfigurationSettings());
            var jwtUtility = new JwtUtility(fncConnectValidateJwtBehavior, fncConnectGenerateJwtBehavior);

            //Act
            var generateJwtResult = await jwtUtility.GenerateJwtAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Success, generateJwtResult.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(generateJwtResult.Result.Jwt));

            var validateJwtResult = await jwtUtility.ValidateJwtAsync(generateJwtResult.Result.Jwt).ConfigureAwait(false);

            Assert.AreEqual(Status.Success, validateJwtResult.Status);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task JwtUtility_HealthCheck_FncConnectBehaviors()
        {
            //Arrange
            var fncConnectGenerateJwtBehavior = new FncConnectGenerateJwtBehavior(new HttpUtility(), TestHelper.GetConfigurationSettings());
            var fncConnectValidateJwtBehavior = new FncConnectValidateJwtBehavior(new HttpUtility(), TestHelper.GetConfigurationSettings());
            var jwtUtility = new JwtUtility(fncConnectValidateJwtBehavior, fncConnectGenerateJwtBehavior);
            var healthcheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();

            //Act
            var healthCheckUtility = new HealthCheckUtility(new List<IHealthCheckable>()
            {
                jwtUtility
            }, healthcheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Assert
            Assert.AreEqual(HealthStatus.Active, (await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false)).Status);
        }
    }
}
