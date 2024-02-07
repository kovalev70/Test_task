using AutoMapper;
using Task10.Backend.Models.Domain;
using Task10.Backend.Models.DTO.DepositDTO;

namespace Task10.Backend.Mapper;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Deposit, CreateDepositDto>().ReverseMap(); 
    }
}
