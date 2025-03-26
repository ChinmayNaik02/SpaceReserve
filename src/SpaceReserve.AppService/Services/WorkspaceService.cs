using AutoMapper;
using SpaceReserve.AppService.Contracts;
using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Services;

public class WorkspaceService : IWorkspaceService
{
    private readonly IWorkspaceRepository _workspaceRepository;
    private readonly IMapper _mapper;
    public WorkspaceService(IWorkspaceRepository workspaceRepository, IMapper mapper)
    {
        _workspaceRepository = workspaceRepository;
        _mapper=mapper;
    }
    public async Task<WorkspaceDto> GetWorkspaceByIdAsync(int id)
    {
        var workspace=await _workspaceRepository.GetWorkspaceByIdAsync(id);
        if(workspace==null){
            throw new Exception("Workspace not found");
        }
        // return new WorkspaceDto{
        //     WorkspaceID=workspace.WorkspaceID,
        //     WorkspaceTypeID=workspace.WorkspaceTypeID,
        //     Name=workspace.Name,
        //     Capacity=workspace.Capacity,
        //     AvailabilityStatus=workspace.AvailabilityStatus,
        //     Bookings=workspace.Bookings?.Select(b=>new BookingDto{

        //         BookingID=b.BookingID,
        //         UserID=b.UserID,
        //         StartDate=b.StartDate,
        //         EndDate=b.EndDate,
        //     }).ToList(),
        //     WorkspaceAmenities=workspace.WorkspaceAmenities?.Select(a=>new WorkspaceAmenityDto{
                
        //         AmenityID=a.AmenityID,
        //         Name=a.Amenity?.AmenityName,
              
        //     }).ToList()



        // };
        return _mapper.Map<WorkspaceDto>(workspace);
    }

}
