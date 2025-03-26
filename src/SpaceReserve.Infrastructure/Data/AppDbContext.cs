using Microsoft.EntityFrameworkCore;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    { }

    public DbSet<Amenity> Amenities {get; set;} 
    public DbSet<Booking> Bookings {get; set;} 
    public DbSet<User> Users {get; set;} 
    public DbSet<Workspace> Workspaces {get; set;}
    public DbSet<WorkspaceAmenity> WorkspaceAmenities {get; set;}
    public DbSet<WorkspaceType> WorkspaceTypes {get; set;}
}
