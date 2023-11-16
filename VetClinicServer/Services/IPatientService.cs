using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IPatientService : IService<PatientDTO>
    {
        Task<IEnumerable<PatientDTO>> GetForClientAsync(int clientId);
    }
}
