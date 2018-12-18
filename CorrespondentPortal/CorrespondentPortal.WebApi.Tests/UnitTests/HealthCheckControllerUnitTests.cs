using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.Controllers;
using CorrespondentPortal.WebApi.DTO.HeathCheck;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class HealthCheckControllerUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public async Task HealthCheckController_GetHealthCheck_ReturnsActiveReport()
        {
            //Arrange
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();
            var healthCheckUtility = new HealthCheckUtility(TestHelper.CreateHealthCheck(), healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());
            var healthCheckController = new HealthCheckController(healthCheckUtility);

            //Act
            var result = await healthCheckController.Get().ConfigureAwait(false);

            //Assert
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));

            var okObjectResult = (OkObjectResult)result;

            Assert.IsInstanceOfType(okObjectResult.Value, typeof(GetHealthCheckResponseDto));

            var healthCheckResponseDto = (GetHealthCheckResponseDto)okObjectResult.Value;

            Assert.AreEqual(healthCheckResponseDto.Status, HealthStatus.Active);
        }
    }
}
