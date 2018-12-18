using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CorrespondentPortal.WebApi.DAL.Repositories.Client;
using CorrespondentPortal.WebApi.Domain.Services.Client;

namespace CorrespondentPortal.WebApi.Tests.UnitTests
{
    [TestClass]
    public class ClientServiceUnitTests
    {
        private static IClientService _clientService;
        private static EFClientRepository _clientRepository;

        [TestInitialize]
        public async Task InitAsync()
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFClientRepository>();
            optionsBuilder.UseSqlite("DataSource=:memory:");
            _clientRepository = new EFClientRepository(optionsBuilder.Options);
            await _clientRepository.Database.OpenConnectionAsync().ConfigureAwait(false);
            await _clientRepository.Database.EnsureCreatedAsync().ConfigureAwait(false);
            _clientService = new ClientService(_clientRepository);
        }

        [TestCleanup]
        public async Task CleanUpAsync()
        {
            await _clientRepository.Database.EnsureDeletedAsync().ConfigureAwait(false);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ClientService_ClientExists_ReturnsFalse_WhenClientDoesNotExist()
        {
            //Act
            var clientExists = await _clientService.ClientExistsAsync(1).ConfigureAwait(false);

            //Assert
            Assert.IsFalse(clientExists);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ClientService_ClientExists_ReturnsTrue_WhenClientDoesExist()
        {
            //Arrange
            const int clientId = 1;
            const string clientName = "Test Client";
            const string clientEventCallbackUrl = "http://someurl.com";

            var addClientResult = await _clientService.AddClientAsync(clientId, clientName, clientEventCallbackUrl).ConfigureAwait(false);

            //Act
            var clientExists = await _clientService.ClientExistsAsync(clientId).ConfigureAwait(false);

            //Assert
            Assert.IsTrue(addClientResult.OperationSuccessful);
            Assert.IsTrue(clientExists);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ClientService_GetClient_ReturnsClient_WhenClientDoesExist()
        {
            //Arrange
            const int clientId = 1;
            const string clientName = "Test Client";
            const string clientEventCallbackUrl = "http://someurl.com";

            var addClientResult = await _clientService.AddClientAsync(clientId, clientName, clientEventCallbackUrl).ConfigureAwait(false);

            //Act
            var getClientResult = await _clientService.GetClientAsync(clientId).ConfigureAwait(false);

            //Assert
            Assert.IsTrue(addClientResult.OperationSuccessful);
            Assert.IsTrue(getClientResult.OperationSuccessful);
            Assert.IsNotNull(getClientResult.Result);
            Assert.AreEqual(getClientResult.Result.Name, clientName);
            Assert.AreEqual(getClientResult.Result.EventCallbackUrl, clientEventCallbackUrl);
            Assert.AreEqual(getClientResult.Result.Id, clientId);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ClientService_GetClient_ReturnsNullClient_WhenClientDoesNotExist()
        {
            //Arrange
            const int clientId = 1;

            //Act
            var getClientResult = await _clientService.GetClientAsync(clientId).ConfigureAwait(false);

            //Assert
            Assert.IsFalse(getClientResult.OperationSuccessful);
            Assert.IsNull(getClientResult.Result);
        }

        [TestMethod]
        [TestCategory("Unit")]
        public async Task ClientService_AddClient_ReturnsError_WhenClientAlreadyExists()
        {
            //Arrange
            const int clientId = 1;
            const string clientName = "Test Client";
            const string clientEventCallbackUrl = "http://someurl.com";

            var addClientResult = await _clientService.AddClientAsync(clientId, clientName, clientEventCallbackUrl).ConfigureAwait(false);

            //Act
            var getClientResult = await _clientService.GetClientAsync(clientId).ConfigureAwait(false);

            //Assert
            Assert.IsTrue(addClientResult.OperationSuccessful);
            Assert.IsTrue(getClientResult.OperationSuccessful);

            //Add Another
            addClientResult = await _clientService.AddClientAsync(clientId, clientName, clientEventCallbackUrl).ConfigureAwait(false);

            //Assert
            Assert.IsFalse(addClientResult.OperationSuccessful);
            Assert.IsTrue(addClientResult.ErrorMessages.Any(x => x == $"Client with id {clientId} already exists."));
        }
    }
}
