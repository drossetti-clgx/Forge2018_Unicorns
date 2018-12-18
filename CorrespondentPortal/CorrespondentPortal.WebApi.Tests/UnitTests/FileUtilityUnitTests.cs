using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using CorrespondentPortal.WebApi.Infrastructure.File.FileUtility;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault;
using CorrespondentPortal.WebApi.Infrastructure.File.FileVault.DTO;
using CorrespondentPortal.WebApi.Infrastructure.HealthCheck;
using CorrespondentPortal.WebApi.Infrastructure.Http;
using CorrespondentPortal.WebApi.Infrastructure.Security.JwtUtility;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class FileUtilityUnitTests
    {
        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileUtility_StoreFile_ReturnsStoreFileBehaviorResult()
        {
            //Arrange
            const string resultIdentifier = "123456";
            var storeFileResult = new StoreFileResult(resultIdentifier);

            var storeFileResultBehaviorMock = new Mock<IStoreFileBehavior>();
            storeFileResultBehaviorMock.Setup(x => x.StoreFileAsync(It.IsAny<byte[]>(), It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<StoreFileResult>.CreateSuccessfulResult(storeFileResult, HttpStatusCode.OK, "")));

            //Act
            var result = await storeFileResultBehaviorMock.Object.StoreFileAsync(new byte[] { }, "blah.txt").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(resultIdentifier, result.Result.Identifier);
            Assert.AreEqual(Status.Success, result.Status);
            Assert.AreEqual(0, result.ErrorMessages.Count());
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileUtility_GetFile_ReturnsStoreFileBehaviorResult()
        {
            //Arrange
            const string fileContents = "<helloworld/>";
            var fileBytes = Encoding.ASCII.GetBytes(fileContents);
            const string fileName = "helloworld.txt";
            var getFileResult = new GetFileResult(fileBytes, fileName);

            var getFileResultBehaviorMock = new Mock<IGetFileBehavior>();
            getFileResultBehaviorMock.Setup(x => x.GetFileAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<GetFileResult>.CreateSuccessfulResult(getFileResult, HttpStatusCode.OK, "")));

            //Act
            var result = await getFileResultBehaviorMock.Object.GetFileAsync("anything").ConfigureAwait(false);

            //Assert
            Assert.IsTrue(fileBytes.SequenceEqual(result.Result.Bytes));
            Assert.AreEqual(fileName, result.Result.FileName);
            Assert.AreEqual(Status.Success, result.Status);
            Assert.AreEqual(0, result.ErrorMessages.Count());
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileUtility_GetHealth_ReturnsActiveHeathCheckResult_WhenAllGood()
        {
            //Arrange
            const string fileContents = "<helloworld/>";
            var fileBytes = Encoding.ASCII.GetBytes(fileContents);
            const string fileName = "helloworld.txt";
            var getFileResult = new GetFileResult(fileBytes, fileName);

            var getFileResultBehaviorMock = new Mock<IGetFileBehavior>();
            getFileResultBehaviorMock.Setup(x => x.GetFileAsync(It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<GetFileResult>.CreateSuccessfulResult(getFileResult, HttpStatusCode.OK, "")));

            const string resultIdentifier = "123456";
            var storeFileResult = new StoreFileResult(resultIdentifier);

            var storeFileResultBehaviorMock = new Mock<IStoreFileBehavior>();
            storeFileResultBehaviorMock.Setup(x => x.StoreFileAsync(It.IsAny<byte[]>(), It.IsAny<string>())).Returns(Task.FromResult(HttpFragileOperationResult<StoreFileResult>.CreateSuccessfulResult(storeFileResult, HttpStatusCode.OK, "")));

            var getPublicUrlResult = new GetPublicUrlResult("SomeUrl");
            var getPublicUrlBehaviorMock = new Mock<IGetPublicUrlBehavior>();
            getPublicUrlBehaviorMock.Setup(x => x.GetPublicUrlAsync(It.IsAny<string>(), It.IsAny<int>())).Returns(Task.FromResult(HttpFragileOperationResult<GetPublicUrlResult>.CreateSuccessfulResult(getPublicUrlResult, HttpStatusCode.OK, "")));

            var fileUtility = new FileUtility(getFileResultBehaviorMock.Object, storeFileResultBehaviorMock.Object, getPublicUrlBehaviorMock.Object);

            var result = await fileUtility.GetHealthAsync().ConfigureAwait(false);

            Assert.AreEqual(HealthStatus.Active, result.Status);
            Assert.AreEqual("Files", result.Description);
            Assert.AreEqual(3, result.Vitals.Count);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileUtility_FileVaultGetPublicUrlAsync_ReturnsFailedResult_WhenJwtGenerationFails()
        {
            //Arrange
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateFailedResult(HttpStatusCode.BadRequest, "", "ErrorMessage")));

            var fileUtility = new FileUtility(new Mock<IGetFileBehavior>().Object, new Mock<IStoreFileBehavior>().Object, new FileVaultGetPublicUrlBehavior(new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object), TestHelper.GetConfigurationSettings()));

            //Act
            var result = await fileUtility.GetPublicUrlAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Failed, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileUtility_FileVaultGetPublicUrlAsync_ReturnsErrorResult_WhenJwtGenerationErrors()
        {
            //Arrange
            var jwtValidateBehavior = new Mock<IValidateJwtBehavior>();
            var jwtGenerateBehaviorMock = new Mock<IGenerateJwtBehavior>();
            jwtGenerateBehaviorMock.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>())).Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateErrorResult(HttpStatusCode.InternalServerError, "", "ErrorMessage")));

            var jwtUtility = new JwtUtility(jwtValidateBehavior.Object, jwtGenerateBehaviorMock.Object);

            var fileUtility = new FileUtility(new Mock<IGetFileBehavior>().Object, new Mock<IStoreFileBehavior>().Object, new FileVaultGetPublicUrlBehavior(jwtUtility, TestHelper.GetConfigurationSettings()));

            //Act
            var result = await fileUtility.GetPublicUrlAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Error, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileVaultGetFileBehavior_ReturnsFailedResult_WhenHttpUtilityFailsGet()
        {
            //Arrange
            var jwtUtility = TestHelper.GetFakeJwtUtility();

            var httpUtility = new Mock<IHttpUtility>();
            httpUtility.Setup(x => x.HttpGetAsync<FileVaultFile>(It.IsAny<string>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>(), It.IsAny<JsonSerializerSettings>()))
                .Returns(Task.FromResult(HttpFragileOperationResult<FileVaultFile>.CreateFailedResult(HttpStatusCode.BadRequest, "", "ErrorMessage")));

            var getFileBehavior = new FileVaultGetFileBehavior(jwtUtility, httpUtility.Object, TestHelper.GetConfigurationSettings());
            //Act
            var result = await getFileBehavior.GetFileAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Failed, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileVaultGetFileBehavior_ReturnsErrorResult_WhenHttpUtilityErrorsGet()
        {
            //Arrange
            var jwtUtility = TestHelper.GetFakeJwtUtility();

            var httpUtility = new Mock<IHttpUtility>();
            httpUtility.Setup(x => x.HttpGetAsync<FileVaultFile>(It.IsAny<string>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>(), It.IsAny<JsonSerializerSettings>()))
                .Returns(Task.FromResult(HttpFragileOperationResult<FileVaultFile>.CreateErrorResult(HttpStatusCode.BadRequest, "", "ErrorMessage")));

            var getFileBehavior = new FileVaultGetFileBehavior(jwtUtility, httpUtility.Object, TestHelper.GetConfigurationSettings());
            //Act
            var result = await getFileBehavior.GetFileAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Error, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileVaultGetFileBehavior_ReturnsFailedResult_WhenJwtUtilityFailsToGenerateJwt()
        {
            //Arrange
            var jwtUtility = new Mock<IJwtUtility>();
            jwtUtility.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>()))
                .Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateFailedResult(HttpStatusCode.BadRequest, "", "ErrorMessage")));

            var httpUtility = new Mock<IHttpUtility>();

            var getFileBehavior = new FileVaultGetFileBehavior(jwtUtility.Object, httpUtility.Object, TestHelper.GetConfigurationSettings());
            //Act
            var result = await getFileBehavior.GetFileAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Failed, result.Status);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task FileVaultGetFileBehavior_ReturnsErrorResult_WhenJwtUtilityErrorsToGenerateJwt()
        {
            //Arrange
            var jwtUtility = new Mock<IJwtUtility>();
            jwtUtility.Setup(x => x.GenerateJwtAsync(It.IsAny<int>(), It.IsAny<IEnumerable<KeyValuePair<string, string>>>()))
                .Returns(Task.FromResult(HttpFragileOperationResult<GenerateJwtResult>.CreateErrorResult(HttpStatusCode.InternalServerError, "", "ErrorMessage")));

            var httpUtility = new Mock<IHttpUtility>();

            var getFileBehavior = new FileVaultGetFileBehavior(jwtUtility.Object, httpUtility.Object, TestHelper.GetConfigurationSettings());
            //Act
            var result = await getFileBehavior.GetFileAsync(Guid.NewGuid().ToString()).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(Status.Error, result.Status);
        }
    }
}
