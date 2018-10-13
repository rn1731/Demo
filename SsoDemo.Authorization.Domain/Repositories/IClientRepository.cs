using SsoDemo.Authorization.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SsoDemo.Authorization.Domain.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Clients>> GetClientsAsync();
        Task<Clients> GetClientAsync(int id);
        Task<Clients> GetClientAsync(string key);
        Task<Clients> GetClientAsync(string key, string secret);
    }
}
