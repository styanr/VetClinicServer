﻿using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IClientService
    {
        public Task<IEnumerable<ClientDTO>> GetAllClients();

        public Task<ClientDTO> GetClientById(int clientId);

        public Task<ClientDTO> CreateClient(ClientDTO clientDto);

        public Task<ClientDTO> UpdateClient(ClientDTO clientDto);

        public Task<bool> RemoveClient(int clientId);
    }
}
