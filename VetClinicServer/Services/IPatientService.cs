using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IPatientService
    {
        public Task<IEnumerable<PatientDTO>> GetAllPatients();
        public Task<PatientDTO> GetPatientById(int patientId);
        public Task<PatientDTO> CreatePatient(PatientDTO patientDto);
        public Task<PatientDTO> UpdatePatient(PatientDTO patientDto);
        public Task<bool> RemovePatient(int patientId);
    }
}
