using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.DAL.Repositories;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using Microsoft.Extensions.Configuration;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class ConfigurationSettingsUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public void ConfigurationSettings_ReturnsCorrectValueForConfiguration()
        {
            //Arrange
            const string configKey = "KeyStoreLocation";
            const string configValue = "SomeLocation";

            var configurationMock = new Mock<IConfiguration>();
            var configurationRepositoryMock = new Mock<IConfigurationRepository>();
            configurationRepositoryMock.Setup(x => x.GetValueByKey(It.IsAny<string>())).Returns<string>(x => x == configKey ? configValue : "");

            var configurationSettings = new ConfigurationSettings();

            //Act
            configurationSettings.Load(configurationRepositoryMock.Object, configurationMock.Object);

            //Assert
            Assert.AreEqual(configurationSettings.KeyStoreLocation, configValue);
        }
    }
}
