using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorrespondentPortal.WebApi.Infrastructure.Shared;
using CorrespondentPortal.WebApi.Tests.Shared;

namespace CorrespondentPortal.WebApi.Tests.IntegrationTests
{
    [TestClass]
    public class HttpUtilityIntegrationTests
    {
        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpGetJson_DeserializesObjectWhen200()
        {
            //Arrange
            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpGetAsync<dynamic>("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(0, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Success, result.Status);
            Assert.IsNotNull(result.Result);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpGetJson_FailedResultWhen400()
        {
            //Arrange
            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpGetAsync<dynamic>("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/400").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Failed, result.Status);
            Assert.IsNull(result.Result);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpGetJson_ErrorResultWhen500()
        {
            //Arrnage
            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpGetAsync<dynamic>("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/500").ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsNull(result.Result);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_SuccessResultObjectWhen200()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(0, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Success, result.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_FailedResultObjectWhen400()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/400", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Failed, result.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_ErrorResultWhen500()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/500", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_SuccessDeserializeResultWhen200()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync<dynamic>("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(0, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Success, result.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
            Assert.IsNotNull(result.ResponseStringContent);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_ErrorWhenCannotDeserializeResult()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync<int>("https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(!string.IsNullOrEmpty(result.ResponseStringContent));
            Assert.AreEqual(result.Result, default(int));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJsonSerializeResult_ErrorWhenBadServer()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync<int>("https://devbravoz.fncinc.com/statuscodeendpoint/api/statuscode/200", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(string.IsNullOrEmpty(result.ResponseStringContent));
            Assert.AreEqual(result.Result, default(int));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJsonSerializeResult_ErrorWhenBadUrl()
        {
            //Arramge
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync<int>("", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(string.IsNullOrEmpty(result.ResponseStringContent));
            Assert.AreEqual(result.Result, default(int));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_ErrorWhenBadServer()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync("https://devbravoz.fncinc.com/statuscodeendpoint/api/statuscode/200", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(string.IsNullOrEmpty(result.ResponseStringContent));
        }

        [TestMethod]
        [TestCategory("Integration")]
        public async Task HttpUtility_HttpPostJson_ErrorWhenBadUrl()
        {
            //Arrange
            var objectToPost = new
            {
                test = ""
            };

            var httpUtility = TestHelper.GetHttpUtility();

            //Act
            var result = await httpUtility.HttpPostJsonAsync("", objectToPost).ConfigureAwait(false);

            //Assert
            Assert.AreEqual(1, result.ErrorMessages.Count());
            Assert.AreEqual(Status.Error, result.Status);
            Assert.IsTrue(string.IsNullOrEmpty(result.ResponseStringContent));
        }
    }
}
