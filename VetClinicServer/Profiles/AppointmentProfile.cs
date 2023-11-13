using AutoMapper;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Profiles
{
    public class AppointmentProfile : Profile
    {
        public AppointmentProfile()
        {
            CreateMap<Appointment, AppointmentDTO>().ReverseMap();
        }
    }
}
