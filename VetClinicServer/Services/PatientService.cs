using Microsoft.EntityFrameworkCore;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class PatientService : IPatientService
    {
        private readonly VetClinicContext _context;

        public PatientService(VetClinicContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patient?> GetPatientById(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(patientId));
            }

            return await _context.Patients.FindAsync(patientId);
        }

        public async Task<Patient?> CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);

            await _context.SaveChangesAsync();
            return await _context.Patients.FindAsync(patient.PatientId);
        }

        public async Task<Patient?> UpdatePatient(Patient patient)
        {
            var pt = await _context.Patients.FindAsync(patient.PatientId);
            if (pt == null)
            {
                return null;
            }

            _context.Entry(pt).CurrentValues.SetValues(patient);
            await _context.SaveChangesAsync();

            return patient;
        }

        public async Task<bool> RemovePatient(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);
            if (patient == null)
            {
                return false;
            }

            _context.Remove(patient);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
