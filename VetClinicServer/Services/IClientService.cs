using Microsoft.EntityFrameworkCore;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IClientService
    {
        public Task<IEnumerable<Client>> GetAllClients();

        public Task<Client?> GetClientById(int clientId);

        public Task<Client?> CreateClient(Client client);

        public Task<Client?> UpdateClient(Client client);

        public Task<bool> RemoveClient(int clientId);
    }
}
