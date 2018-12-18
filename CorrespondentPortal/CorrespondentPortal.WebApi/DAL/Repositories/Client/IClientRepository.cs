using System;
using System.Threading.Tasks;
using CorrespondentPortal.WebApi.DAL.Entities;

namespace CorrespondentPortal.WebApi.DAL.Repositories.Client
{
    public interface IClientRepository
    {
        Task<bool> ClientExistsAsync(int id);
        Task<ClientEntity> GetClientAsync(int id);
        ClientEntity AddClient(int id, DateTime createdDateTime, string name, string eventCallbackUrl);
        Task SaveChangesAsync();
    }
}