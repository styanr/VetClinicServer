using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly VetClinicContext _context;
        private readonly IMapper _mapper;

        public DoctorService(VetClinicContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<IEnumerable<DoctorDTO>> GetAllAsync()
        {
            return await _mapper.ProjectTo<DoctorDTO>(_context.Doctors).ToListAsync();
        }

        public async Task<DoctorDTO> GetByIdAsync(int doctorId)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(doctorId));
            }

            var doctor = await _context.Doctors.FindAsync(doctorId);
            if (doctor == null)
            {
                throw new DoctorNotFoundException(doctorId);
            }

            return _mapper.Map<Doctor, DoctorDTO>(doctor);
        }

        public async Task<DoctorDTO> CreateAsync(DoctorDTO doctorDto)
        {
            var doctor = _mapper.Map<DoctorDTO, Doctor>(doctorDto);
            _context.Doctors.Add(doctor);

            await _context.SaveChangesAsync();

            doctorDto.DoctorId = doctor.DoctorId;
            return doctorDto;
        }

        public async Task<DoctorDTO> UpdateAsync(DoctorDTO doctorDto)
        {
            var dc = await _context.Doctors.FindAsync(doctorDto.DoctorId);
            if (dc == null)
            {
                throw new DoctorNotFoundException(doctorDto.DoctorId);

            }
            _context.Entry(dc).CurrentValues.SetValues(_mapper.Map<DoctorDTO, Doctor>(doctorDto));
            await _context.SaveChangesAsync();

            return doctorDto;
        }

        public async Task RemoveAsync(int doctorId)
        {
            var doctor = await _context.Doctors.FindAsync(doctorId);

            if (doctor == null)
            {
                throw new DoctorNotFoundException(doctorId);
            }

            _context.Doctors.Remove(doctor);
            await _context.SaveChangesAsync();
        }
    }
}
