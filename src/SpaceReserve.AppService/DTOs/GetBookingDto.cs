namespace SpaceReserve.AppService.DTOs;

public class GetBookingDto
{
    public int WorkspaceID { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
}
