using AutoMapper;
using Microsoft.EntityFrameworkCore;
using VetClinicServer.DTOs;
using VetClinicServer.Exceptions;
using VetClinicServer.Models;

namespace VetClinicServer.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly VetClinicContext _context;
        private readonly IMapper _mapper;

        public AppointmentService(VetClinicContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<AppointmentDTO>> GetAllAsync()
        {
            return await _mapper.ProjectTo<AppointmentDTO>(_context.Appointments).ToListAsync();
        }

        public async Task<AppointmentDTO> GetByIdAsync(int appointmentId)
        {
            if (appointmentId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(appointmentId));
            }

            var appointment = await _context.Appointments.FindAsync(appointmentId);
            if (appointment == null)
            {
                throw new AppointmentNotFoundException(appointmentId);
            }

            return _mapper.Map<Appointment, AppointmentDTO>(appointment);
        }

        public async Task<AppointmentDTO> CreateAsync(AppointmentDTO appointmentDto)
        {
            var appointment = _mapper.Map<AppointmentDTO, Appointment>(appointmentDto);
            _context.Appointments.Add(appointment);

            await _context.SaveChangesAsync();

            appointmentDto.AppointmentId = appointment.AppointmentId;
            return appointmentDto;
        }

        public async Task<AppointmentDTO> UpdateAsync(AppointmentDTO appointmentDto)
        {
            var appointment = await _context.Appointments.FindAsync(appointmentDto.AppointmentId);
            if (appointment == null)
            {
                throw new AppointmentNotFoundException(appointmentDto.AppointmentId);
            }

            _context.Entry(appointment).CurrentValues.SetValues(_mapper.Map<AppointmentDTO, Appointment>(appointmentDto));
            await _context.SaveChangesAsync();

            return appointmentDto;
        }

        public async Task RemoveAsync(int appointmentId)
        {
            var appointment = await _context.Appointments.FindAsync(appointmentId);

            if (appointment == null)
            {
                throw new AppointmentNotFoundException(appointmentId);
            }

            _context.Appointments.Remove(appointment);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AppointmentDTO>> GetForDoctorAsync(int doctorId)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(doctorId));
            }

            var appointments = _context.Appointments.Where(a => a.DoctorId == doctorId);
            return await _mapper.ProjectTo<AppointmentDTO>(appointments).ToListAsync();
        }

        public async Task<IEnumerable<AppointmentDTO>> GetForPatientAsync(int patientId)
        {
            if (patientId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(patientId));
            }
            var appointments = _context.Appointments.Where(a => a.PatientId == patientId);
            return await _mapper.ProjectTo<AppointmentDTO>(appointments).ToListAsync();
        }
    }

}
