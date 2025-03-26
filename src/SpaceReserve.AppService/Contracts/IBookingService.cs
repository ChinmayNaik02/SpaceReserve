using SpaceReserve.AppService.DTOs;

namespace SpaceReserve.AppService.Contracts;

public interface IBookingService
{
    public Task<BookingDto> AddBookingDTOAsync(BookingDto bookingDTO);
    public Task<BookingDto> GetBookingByIdAsync(int id);
    Task<IEnumerable<BookingDto>> GetAllBookingsAsync();

}
