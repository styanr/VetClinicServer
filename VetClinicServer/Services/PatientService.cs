using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class PatientService : IPatientService
    {
        private readonly VetClinicContext _context;
        private readonly IMapper _mapper;
        private readonly IClientService _clientService;

        public PatientService(VetClinicContext context, IMapper mapper, IClientService clientService)
        {
            _context = context;
            _mapper = mapper;
            _clientService = clientService;
        }

        public async Task<IEnumerable<PatientDTO>> GetAllPatients()
        {
            return await _mapper.ProjectTo<PatientDTO>(_context.Patients).ToListAsync();
        }

        public async Task<PatientDTO> GetPatientById(int patientId)
        {
            if (patientId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(patientId));
            }

            var patient = await _context.Patients.FindAsync(patientId);
            if (patient == null)
            {
                throw new PatientNotFoundException(patientId);
            }

            return _mapper.Map<Patient, PatientDTO>(patient);
        }

        public async Task<PatientDTO> CreatePatient(PatientDTO patientDto)
        {
            var patient = _mapper.Map<PatientDTO, Patient>(patientDto);
            _context.Patients.Add(patient);

            await _context.SaveChangesAsync();

            patientDto.PatientId = patient.PatientId;
            return patientDto;
        }

        public async Task<PatientDTO> UpdatePatient(PatientDTO patientDto)
        {
            var pt = await _context.Patients.FindAsync(patientDto.PatientId);
            if (pt == null)
            {
                throw new PatientNotFoundException(patientDto.PatientId);
            }

            _context.Entry(pt).CurrentValues.SetValues(patientDto);
            await _context.SaveChangesAsync();

            return patientDto;
        }

        public async Task<bool> RemovePatient(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);

            if (patient == null)
            {
                throw new PatientNotFoundException(patientId);
            }

            _context.Remove(patient);
            int rowsAffected = await _context.SaveChangesAsync();

            return rowsAffected > 0;
        }
    }
}
