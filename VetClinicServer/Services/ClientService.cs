using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class ClientService : IClientService
    {
        VetClinicContext _context;

        public ClientService(VetClinicContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Client>> GetAllClients()
        {
            return await _context.Clients.ToListAsync();
        }

        public async Task<Client?> GetClientByIdAsync(int clientId)
        {
            if (clientId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(clientId));
            }

            return await _context.Clients.FindAsync(clientId);

        }

        public async Task<Client?> CreateClient(Client client)
        {
            _context.Add(client);

            await _context.SaveChangesAsync();

            return await _context.Clients.FindAsync(client.ClientId);
        }

        public async Task<Client?> UpdateClient(Client client)
        {
            var cl = await _context.Clients.FindAsync(client.ClientId);
            if (cl == null)
            {
                return null;
            }
            _context.Entry(cl).CurrentValues.SetValues(client);

            await _context.SaveChangesAsync();

            return client;
        }

        public async Task<bool> RemoveClient(int clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);

            if (client == null)
            {
                return false;
            }

            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
