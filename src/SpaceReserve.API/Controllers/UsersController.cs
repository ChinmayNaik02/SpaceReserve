using Microsoft.AspNetCore.Mvc;
using SpaceReserve.AppService.Contracts;

namespace SpaceReserve.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly ILogger<UsersController> _logger;

    public UsersController(IUserService userService, ILogger<UsersController> logger)
    {
        _userService = userService;
        _logger = logger;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUserById(int id)
    {
        try
        {
            var user = await _userService.GetByIdAsync(id);
            return Ok(user);
        }
        catch (KeyNotFoundException ex)
        {
            _logger.LogError(ex, "User not found");
            return NotFound(ex.Message);
        }
        catch (ArgumentException ex)
        {
            _logger.LogError(ex, "Invalid user id");
            return BadRequest(ex.Message);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting user");
            return StatusCode(500, "An error occurred while getting user");
        }
    }
}
