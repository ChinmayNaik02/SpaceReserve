using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Contracts;

public interface IWorkspaceRepository
{
    Task<Workspace?> GetWorkspaceByIdAsync(int id);
}
