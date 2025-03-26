using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using SpaceReserve.AppService.Contracts;
using SpaceReserve.AppService.DTOs;

namespace SpaceReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BookingController : ControllerBase
{
    public readonly IBookingService _service;
    public readonly ILogger<BookingController> _logger;
    public BookingController(IBookingService service,ILogger<BookingController> logger)
    {
        _service=service;
        _logger=logger;
    }
    [HttpGet("{id}")]
    public async Task<ActionResult> GetBookingByIdAsync(int id)
    {
        try
        {
            var booking = await _service.GetBookingByIdAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return Ok(booking);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
        }
    }
    [HttpPost]
    public async Task<ActionResult> AddBookingDTOAsync(BookingDto bookingDTO)
    {
        try
        {
            var booking=await _service.AddBookingDTOAsync(bookingDTO);
            if(booking==null)
            {
                _logger.LogError("Booking not added");
                return BadRequest();
            }
            return Ok(new {message="Booking Added Successfully",booking});
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,"Error Accured in data Insertion"+ex.Message);
        }
    }
}
