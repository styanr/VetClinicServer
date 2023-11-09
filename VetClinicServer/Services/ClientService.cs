using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class ClientService : IClientService
    {
        private readonly VetClinicContext _context;
        private readonly IMapper _mapper;

        public ClientService(VetClinicContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientDTO>> GetAllClients()
        {
            return await _mapper.ProjectTo<ClientDTO>(_context.Clients).ToListAsync();
        }

        public async Task<ClientDTO> GetClientById(int clientId)
        {
            if (clientId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(clientId));
            }

            var client = await _context.Clients.FindAsync(clientId);
            if (client == null)
            {
                throw new ResourceNotFoundException($"Client with ID {clientId} not found.");
            }

            return _mapper.Map<Client, ClientDTO>(client);
        }

        public async Task<ClientDTO> CreateClient(ClientDTO client)
        {
            _context.Clients.Add(_mapper.Map<ClientDTO, Client>(client));

            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<ClientDTO> UpdateClient(ClientDTO client)
        {
            var cl = await _context.Clients.FindAsync(client.ClientId);
            if (cl == null)
            {
                throw new ResourceNotFoundException($"Client with ID {client.ClientId} not found.");
            }

            _context.Entry(cl).CurrentValues.SetValues(_mapper.Map<ClientDTO, Client>(client));
            await _context.SaveChangesAsync();

            await _context.SaveChangesAsync();
            return client;
        }

        public async Task<bool> RemoveClient(int clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);

            if (client == null)
            {
                throw new ResourceNotFoundException($"Client with ID {clientId} not found.");
            }

            _context.Clients.Remove(client);
            int rowsAffected = await _context.SaveChangesAsync();

            return rowsAffected > 0;
        }
    }
}
