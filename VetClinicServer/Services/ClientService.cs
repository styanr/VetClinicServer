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
                throw new ResourceNotFoundException(
                    $"Client with ID {clientId} not found.");
            }

            return _mapper.Map<Client, ClientDTO>(client);
        }

        public async Task<ClientDTO> CreateClient(ClientDTO clientDto)
        {
            var client = _mapper.Map<ClientDTO, Client>(clientDto);
            _context.Clients.Add(client);

            await _context.SaveChangesAsync();

            clientDto.ClientId = client.ClientId;
            return clientDto;
        }

        public async Task<ClientDTO> UpdateClient(ClientDTO clientDto)
        {
            var cl = await _context.Clients.FindAsync(clientDto.ClientId);
            if (cl == null)
            {
                throw new ResourceNotFoundException(
                    $"Client with ID {clientDto.ClientId} not found.");
            }

            _context.Entry(cl).CurrentValues.SetValues(_mapper.Map<ClientDTO, Client>(clientDto));
            await _context.SaveChangesAsync();

            return clientDto;
        }

        public async Task<bool> RemoveClient(int clientId)
        {
            var client = await _context.Clients.FindAsync(clientId);

            if (client == null)
            {
                throw new ResourceNotFoundException(
                    $"Client with ID {clientId} not found.");
            }

            _context.Clients.Remove(client);
            int rowsAffected = await _context.SaveChangesAsync();

            return rowsAffected > 0;
        }
    }
}
