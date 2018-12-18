using System;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.DAL.Repositories.Client;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<bool> ClientExistsAsync(int clientId)
        {
            return await _clientRepository.ClientExistsAsync(clientId).ConfigureAwait(false);
        }

        public async Task<OperationResult<Client>> GetClientAsync(int clientId)
        {
            var client = await _clientRepository.GetClientAsync(clientId).ConfigureAwait(false);

            if (client != null)
            {
                return OperationResult<Client>.CreateSuccessfulResult(new Client(client.Id, client.Name, client.EventCallbackUrl, client.CreatedDate));
            }
            return OperationResult<Client>.CreateErrorResult("Client does not exist.");
        }

        public async Task<OperationResult<Client>> AddClientAsync(int id, string name, string eventCallbackUrl)
        {
            if (await ClientExistsAsync(id))
            {
                return OperationResult<Client>.CreateErrorResult($"Client with id {id} already exists.");
            }

            var client = _clientRepository.AddClient(id, DateTime.Now, name, eventCallbackUrl);
            await _clientRepository.SaveChangesAsync().ConfigureAwait(false);
            return OperationResult<Client>.CreateSuccessfulResult(new Client(client.Id, client.Name, client.EventCallbackUrl, client.CreatedDate));
        }

    }
}
