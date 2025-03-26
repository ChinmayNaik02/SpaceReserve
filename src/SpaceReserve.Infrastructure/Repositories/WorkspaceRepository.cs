using Microsoft.EntityFrameworkCore;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Data;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Repositories;

public class WorkspaceRepository : IWorkspaceRepository
{
    private readonly AppDbContext _context;
    public WorkspaceRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Workspace?> GetWorkspaceByIdAsync(int id)
    {
        var workspace= await _context.Workspaces
        .Include(b => b.Bookings)
        .Include(a => a.WorkspaceAmenities!)
        .ThenInclude(a => a.Amenity)
        .FirstOrDefaultAsync(x => x.WorkspaceID == id);
        return workspace;
    }

}
