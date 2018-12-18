using System.Threading.Tasks;
using CorrespondentPortal.WebApi.Infrastructure.Shared;

namespace CorrespondentPortal.WebApi.Domain.Services.Client
{
    public interface IClientService
    {
        Task<bool> ClientExistsAsync(int clientId);
        Task<OperationResult<Client>> GetClientAsync(int clientId);
        Task<OperationResult<Client>> AddClientAsync(int id, string name, string eventCallbackUrl);
    }
}