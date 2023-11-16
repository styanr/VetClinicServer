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

        public PatientService(VetClinicContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PatientDTO>> GetAllAsync()
        {
            return await _mapper.ProjectTo<PatientDTO>(_context.Patients).ToListAsync();
        }

        public async Task<PatientDTO> GetByIdAsync(int patientId)
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

        public async Task<PatientDTO> CreateAsync(PatientDTO patientDto)
        {
            var patient = _mapper.Map<PatientDTO, Patient>(patientDto);
            _context.Patients.Add(patient);

            await _context.SaveChangesAsync();

            patientDto.PatientId = patient.PatientId;
            return patientDto;
        }

        public async Task<PatientDTO> UpdateAsync(PatientDTO patientDto)
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

        public async Task RemoveAsync(int patientId)
        {
            var patient = await _context.Patients.FindAsync(patientId);

            if (patient == null)
            {
                throw new PatientNotFoundException(patientId);
            }

            _context.Remove(patient);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PatientDTO>> GetForClientAsync(int clientId)
        {
            if (clientId < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(clientId));
            }

            var patients = _context.Patients.Where(p => p.ClientId == clientId);
            return await _mapper.ProjectTo<PatientDTO>(patients).ToListAsync();
        }
    }
}
