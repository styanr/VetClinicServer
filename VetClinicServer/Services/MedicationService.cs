using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class MedicationService : IMedicationService
    {
        private readonly VetClinicContext _context;
        private readonly IMapper _mapper;

        public MedicationService(VetClinicContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MedicationDTO>> GetAllAsync()
        {
            return await _mapper.ProjectTo<MedicationDTO>(_context.Medications).ToListAsync();
        }

        public async Task<MedicationDTO> GetByIdAsync(int medicationId)
        {
            if (medicationId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(medicationId));
            }

            var medication = await _context.Medications.FindAsync(medicationId);
            if (medication == null)
            {
                throw new MedicationNotFoundException(medicationId);
            }

            return _mapper.Map<Medication, MedicationDTO>(medication);
        }

        public async Task<MedicationDTO> CreateAsync(MedicationDTO medicationDto)
        {
            var medication = _mapper.Map<MedicationDTO, Medication>(medicationDto);
            _context.Medications.Add(medication);

            await _context.SaveChangesAsync();

            medicationDto.MedicationId = medication.MedicationId;
            return medicationDto;
        }

        public async Task<MedicationDTO> UpdateAsync(MedicationDTO medicationDto)
        {
            var med = await _context.Medications.FindAsync(medicationDto.MedicationId);
            if (med == null)
            {
                throw new MedicationNotFoundException(medicationDto.MedicationId);
            }

            _context.Entry(med).CurrentValues.SetValues(_mapper.Map<MedicationDTO, Medication>(medicationDto));
            await _context.SaveChangesAsync();

            return medicationDto;
        }

        public async Task RemoveAsync(int medicationId)
        {
            var medication = await _context.Medications.FindAsync(medicationId);

            if (medication == null)
            {
                throw new MedicationNotFoundException(medicationId);
            }

            _context.Medications.Remove(medication);
            await _context.SaveChangesAsync();
        }
    }
}
