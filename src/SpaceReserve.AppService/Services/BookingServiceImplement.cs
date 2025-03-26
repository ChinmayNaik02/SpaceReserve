using AutoMapper;
using SpaceReserve.AppService.Contracts;
using SpaceReserve.AppService.DTOs;
using SpaceReserve.Infrastructure.Contracts;
using SpaceReserve.Infrastructure.Entities;

namespace SpaceReserve.AppService.Services;

public class BookingServiceImplement : IBookingService
{
    public readonly IBookingInfrastructure _repository;
    public readonly IMapper _mapper;
    public BookingServiceImplement(IBookingInfrastructure repository,IMapper mapper)
    {
        _repository=repository;
        _mapper=mapper;
    }
    public async Task<BookingDto> AddBookingDTOAsync(BookingDto bookingDTO)
    {
        var result= _mapper.Map<Booking>(bookingDTO);
        var booking=await _repository.AddBookingAsync(result);
        var addBookingDTO = _mapper.Map<BookingDto>(booking);
        return addBookingDTO;
    }

    public async Task<BookingDto> GetBookingByIdAsync(int id)
    {
        var booking=await _repository.GetBookingByIdAsync(id);
        if(booking==null)
        {
            throw new ArgumentException("Booking not found");
        }
        var result= _mapper.Map<BookingDto>(booking);
        return result;
    }

}
