using AutoMapper;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Profiles
{
    public class MedicationProfile : Profile
    {
        public MedicationProfile()
        {
            CreateMap<Medication, MedicationDTO>().ReverseMap();
        }
    }
}
