using Microsoft.EntityFrameworkCore;

using SsoDemo.Authorization.Domain.Model;
using SsoDemo.Authorization.Domain.Repositories;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SsoDemo.Authorization.Data.Repositories
{
    public class ClientRepository: IClientRepository
    {
        private readonly AuthorizationContext _authorizationContext;

        public ClientRepository(AuthorizationContext authorizationContext)
        {
            _authorizationContext = authorizationContext;
        }

        public async Task<IEnumerable<Clients>> GetClientsAsync()
        {
            return await _authorizationContext.Clients.ToListAsync();
        }

        public async Task<Clients> GetClientAsync(int id)
        {
            var clients = await GetClientsAsync();
            return clients.FirstOrDefault(c => c.ClientId.Equals(id));
        }

        public async Task<Clients> GetClientAsync(string key)
        {
            var clients = await GetClientsAsync();
            return clients.FirstOrDefault(c => c.Key.Equals(key));
        }

        public async Task<Clients> GetClientAsync(string key, string secret)
        {
            var clients = await GetClientsAsync();
            return clients.FirstOrDefault(c => c.Key.Equals(key)
             && c.Secret.Equals(secret));
        }

    }
}
