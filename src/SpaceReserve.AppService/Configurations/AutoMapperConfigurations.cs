using AutoMapper;
using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Configurations;

public class AutoMapperConfigurations : Profile
{
    public AutoMapperConfigurations()
    {
        CreateMap<User, GetUserDto>().ReverseMap();
    }
}
