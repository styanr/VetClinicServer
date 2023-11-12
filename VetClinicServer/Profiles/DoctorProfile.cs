using AutoMapper;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Profiles
{
    public class DoctorProfile : Profile
    {
        public DoctorProfile()
        {
            CreateMap<Doctor, DoctorDTO>().ReverseMap();
        }
    }
}
