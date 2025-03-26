using AutoMapper;
using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Configurations;

public class AutoMapperConfiguration : Profile
{
    public AutoMapperConfiguration()
    {
        CreateMap<User, GetUserDto>().ReverseMap();
        CreateMap<Workspace, WorkspaceDto>().ReverseMap();
        CreateMap<Booking,BookingDto>().ReverseMap();
        CreateMap<WorkspaceAmenity,WorkspaceAmenityDto>() .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Amenity.AmenityName)).ReverseMap();
    }
}
