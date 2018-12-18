using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using CorrespondentPortal.WebApi.DAL.Entities;
using CorrespondentPortal.WebApi.DAL.Repositories.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.Configuration;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.IntegrationTests
{
    [TestClass]
    public class FileUtilityIntegrationTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task FileUtility_FileVaultStoreFileBehavior_StoreFile()
        {
            //Arrange
            const string fileContents = "<helloWorld/>";
            var fileBytes = Encoding.ASCII.GetBytes(fileContents);

            var fileUtility = TestHelper.GetFileVaultFileUtility();

            //Act
            var storeFileResult = await fileUtility.StoreFileAsync(fileBytes, "test.txt").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Success, storeFileResult.Status);
            Assert.AreEqual(0, storeFileResult.ErrorMessages.Count());
            Assert.IsTrue(!string.IsNullOrEmpty(storeFileResult.Result.Identifier));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task FileUtility_FileVaultGetFileBehavior_GetFile()
        {
            //Arrange
            const string fileContents = "<helloWorld/>";
            const string fileName = "hello.txt";
            var fileBytes = Encoding.ASCII.GetBytes(fileContents);

            var fileUtility = TestHelper.GetFileVaultFileUtility();

            //Act
            var storeFileResult = await fileUtility.StoreFileAsync(fileBytes, fileName).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Success, storeFileResult.Status);
            Assert.AreEqual(0, storeFileResult.ErrorMessages.Count());
            Assert.IsTrue(!string.IsNullOrEmpty(storeFileResult.Result.Identifier));

            //Act
            var getFileResult = await fileUtility.GetFileAsync(storeFileResult.Result.Identifier).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(0, getFileResult.ErrorMessages.Count());
            Assert.AreEqual(Status.Success, getFileResult.Status);
            Assert.IsTrue(fileBytes.SequenceEqual(getFileResult.Result.Bytes));
            Assert.AreEqual(fileName, getFileResult.Result.FileName);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task FileUtility_HealthCheck_FileVaultBehaviors()
        {
            //Arrange
            var fileUtility = TestHelper.GetFileVaultFileUtility();
            var healthCheckNotifierUtility = new Mock<IHealthCheckNotifierUtility>();

            //Act
            var healthCheckUtility = new HealthCheckUtility(new List<IHealthCheckable>()
            {
                fileUtility
            }, healthCheckNotifierUtility.Object, TestHelper.GetConfigurationSettings());

            //Assert
            Assert.AreEqual(HealthStatus.Active, (await healthCheckUtility.GetHealthCheckResultAsync().ConfigureAwait(false)).Status);
        }
    }
}
