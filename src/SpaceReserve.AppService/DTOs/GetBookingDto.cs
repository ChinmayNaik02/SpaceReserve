namespace SpaceReserve.AppService.DTOs;

public class GetBookingDto
{
     public int BookingID { get; set; }
    public int UserID { get; set; }
    public GetUserDto User { get; set; }
    public int WorkspaceID { get; set; }
    public WorkspaceDto Workspace { get; set; }

    public DateTime StartDate { get; set; }


    public DateTime EndDate { get; set; }


    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public string Status { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
