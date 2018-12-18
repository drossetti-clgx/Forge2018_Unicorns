using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CorrespondentPortal.WebApi.DAL.Entities;

namespace CorrespondentPortal.WebApi.DAL.Repositories.Client
{
    public class EFClientRepository : DbContext, IClientRepository
    {
        public DbSet<ClientEntity> Clients { get; set; }

        public EFClientRepository(DbContextOptions<EFClientRepository> options) : base(options)
        {

        }

        public async Task<bool> ClientExistsAsync(int id)
        {
            return await Clients.AnyAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public async Task<ClientEntity> GetClientAsync(int id)
        {
            return await Clients.SingleOrDefaultAsync(x => x.Id == id).ConfigureAwait(false);
        }

        public ClientEntity AddClient(int id, DateTime createdDate, string name, string eventCallbackUrl)
        {
            var entityToAdd = new ClientEntity()
            {
                Id = id,
                Name = name,
                EventCallbackUrl = eventCallbackUrl,
                CreatedDate = createdDate
            };

            return Clients.Add(entityToAdd).Entity;
        }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
