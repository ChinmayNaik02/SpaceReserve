using Microsoft.AspNetCore.Mvc;
using SpaceReserve.AppService.Contracts;

namespace SpaceReserve.API.Controllers;

[Route("api/[controller]")]
[ApiController]

public class WorkspaceController: ControllerBase
{
    private readonly IWorkspaceService _workspaceService;
    private readonly ILogger<WorkspaceController> _logger;
    public WorkspaceController(IWorkspaceService workspaceService, ILogger<WorkspaceController> logger)
    {
        _workspaceService = workspaceService;
        _logger = logger;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetWorkspaceById(int id)
    {
        try
        {
            var workspace = await _workspaceService.GetWorkspaceByIdAsync(id);
            if (workspace == null)
            {
                return NotFound();
            }
            return Ok(workspace);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while getting workspace by id");
            return BadRequest(ex.Message);
        }
    }
    
}
