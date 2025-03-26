using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.Infrastructure.Contracts;

public interface IBookingInfrastructure
{
    public Task<Booking?> AddBookingAsync(Booking booking);
    public Task<Booking?> GetBookingByIdAsync(int id);
     Task<IEnumerable<Booking>> GetAllBookingsAsync(); 
}
