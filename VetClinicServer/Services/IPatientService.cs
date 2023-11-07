using Microsoft.EntityFrameworkCore;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public interface IPatientService
    {
        public Task<IEnumerable<Patient>> GetAllPatients();
        public Task<Patient?> GetPatientById(int patientId);
        public Task<Patient?> CreatePatient(Patient patient);
        public Task<Patient?> UpdatePatient(Patient patient);
        public Task<bool> RemovePatient(int patientId);
    }
}
