using SpaceReserve.AppService.DTOs;


namespace SpaceReserve.AppService.Contracts;

public interface IWorkspaceService
{
    Task<WorkspaceDto> GetWorkspaceByIdAsync(int id);
}
