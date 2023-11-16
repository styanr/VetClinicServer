using VetClinicServer.DTOs;

namespace VetClinicServer.Services
{
    public interface IAppointmentService : IService<AppointmentDTO>
    {
        Task<IEnumerable<AppointmentDTO>> GetForDoctorAsync(int doctorId);
        Task<IEnumerable<AppointmentDTO>> GetForPatientAsync(int patientId);
        
    }
}
