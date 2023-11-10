using AutoMapper;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientDTO>().ReverseMap();
        }
    }
}
