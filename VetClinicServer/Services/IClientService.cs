using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IClientService : IService<ClientDTO>
    {
    }
}
