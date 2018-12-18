using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class ConfigurationRepositoryUnitTests
    {
        private ConfigurationRepository _configurationRepository;

        [TestInitialize]
        public async Task InitAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ConfigurationRepository>();
            optionsBuilder.UseSqlite("DataSource=:memory:");
            _configurationRepository = new ConfigurationRepository(optionsBuilder.Options);
            await _configurationRepository.Database.OpenConnectionAsync().ConfigureAwait(false);
            await _configurationRepository.Database.EnsureCreatedAsync().ConfigureAwait(false);
        }

        [TestCleanup]
        public async Task CleanUpAsync()
        {
            await _configurationRepository.Database.EnsureDeletedAsync().ConfigureAwait(false);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public void ConfigurationRepository_GetValueByKeyReturnsEmptyStringAsDefault()
        {
            //Act
            var resultingValue = _configurationRepository.GetValueByKey("SomeRandomKey");

            //Assert
            Assert.AreEqual(string.Empty, resultingValue);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ConfigurationRepository_GetValueByKeyReturnsPropertValueWhenExistsInDbContext()
        {
            //Arrange
            var configurationKey = "configurationKey";
            var configurationValue = "configurationValue";

            _configurationRepository.Configurations.Add(new ConfigurationEntity() { Key = configurationKey, Value = configurationValue });
            await _configurationRepository.SaveChangesAsync().ConfigureAwait(false);

            //Act
            var resultingValue = _configurationRepository.GetValueByKey(configurationKey);

            //Assert
            Assert.AreEqual(configurationValue, resultingValue);
        }
    }
}
