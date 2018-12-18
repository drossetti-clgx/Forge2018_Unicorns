using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class HealthCheckUtilityUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public async Task HealthCheckUtilityResult_ToDto_ConvertsProperly()
        {
            //Arrange
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();
            var healthCheckUtility = new HealthCheckUtility(TestHelper.CreateHealthCheck(), healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Act
            var healthCheckUtilityResult = await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false);
            var getHealthCheckResponseDto = healthCheckUtilityResult.ToDto();

            //Assert
            Assert.AreEqual(getHealthCheckResponseDto.Status, HealthStatus.Active);
            Assert.AreEqual(HealthStatus.Active, getHealthCheckResponseDto.Status);
            Assert.AreEqual(getHealthCheckResponseDto.HealthChecks.Count, 3);

            var resultHealthCheck1 = getHealthCheckResponseDto.HealthChecks.SingleOrDefault(x => x.Description == "Test Health Check 1");

            Assert.IsNotNull(resultHealthCheck1);
            Assert.AreEqual(HealthStatus.Active, resultHealthCheck1.Status);
            Assert.AreEqual(resultHealthCheck1.Vitals.Count, 2);

            var resultHealthCheck1Vital1 = resultHealthCheck1.Vitals.SingleOrDefault(x => x.Description == "Health Check 1 Vital 1");

            Assert.IsNotNull(resultHealthCheck1Vital1);
            Assert.AreEqual(HealthStatus.Active, resultHealthCheck1Vital1.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task HealthCheckUtility_GetHealthCheckResult_ReturnsActiveReport_WhenAllVitalsAreActive()
        {
            //Arrange
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();
            var healthCheckUtility = new HealthCheckUtility(TestHelper.CreateHealthCheck(), healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Act
            var healthCheckResult = await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Active, healthCheckResult.Status);
            Assert.AreEqual(3, healthCheckResult.HealthChecks.Count);

            var resultHealthCheck1 = healthCheckResult.HealthChecks.SingleOrDefault(x => x.Description == "Test Health Check 1");

            Assert.IsNotNull(resultHealthCheck1);
            Assert.AreEqual(HealthStatus.Active, resultHealthCheck1.Status);
            Assert.AreEqual(2, resultHealthCheck1.Vitals.Count);

            var resultHealthCheck1Vital1 = resultHealthCheck1.Vitals.SingleOrDefault(x => x.Description == "Health Check 1 Vital 1");

            Assert.IsNotNull(resultHealthCheck1Vital1);
            Assert.AreEqual(HealthStatus.Active, resultHealthCheck1Vital1.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task HealthCheckUtility_GetHealthCheckResult_ReturnsWarningReport_WhenAtLeastOneVitalIsWarning()
        {
            //Arrange
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();
            var healthCheckUtility = new HealthCheckUtility(TestHelper.CreateHealthCheck(HealthStatus.Warning), healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Act
            var healthCheckResult = await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Warning, healthCheckResult.Status);
            Assert.AreEqual(healthCheckResult.Message, $"One or more system components have a status of {HealthStatus.Warning}.");
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task HealthCheckUtility_GetHealthCheckResult_ReturnsCriticalReport_WhenAtLeastOneVitalIsCritical()
        {
            //Arrange
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();
            var healthCheckUtility = new HealthCheckUtility(TestHelper.CreateHealthCheck(HealthStatus.Critical), healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Act
            var healthCheckResult = await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false);

            //Assert
            Assert.AreEqual(HealthStatus.Critical, healthCheckResult.Status);
            Assert.AreEqual(healthCheckResult.Message, $"One or more system components have a status of {HealthStatus.Critical}.");
        }
    }
}
