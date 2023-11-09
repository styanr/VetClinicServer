using AutoMapper;
using VetClinicServer.DTOs;
using VetClinicServer.Models;

namespace VetClinicServer.Profiles
{
    public class ClientProfile : Profile
    {
        public ClientProfile()
        {
            CreateMap<Client, ClientDTO>().ReverseMap();
        }
    }
}
