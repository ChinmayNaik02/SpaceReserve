using Microsoft.EntityFrameworkCore;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Data;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Repositories;

public class BookingInfrastructureImplement : IBookingInfrastructure
{
    public readonly AppDbContext _context;
    public BookingInfrastructureImplement(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Booking?> AddBookingAsync(Booking booking)
    {
        var result = await _context.Bookings.AddAsync(booking);
        await _context.SaveChangesAsync();
        return result.Entity;
    }

    public async Task<Booking?> GetBookingByIdAsync(int id)
    {
        var result = await _context.Bookings.
        Include(b => b.User).
        Include(b => b.Workspace).
        Include(b => b.Workspace.WorkspaceType).
        FirstOrDefaultAsync(b => b.BookingID == id);
        return result;
    }

}
