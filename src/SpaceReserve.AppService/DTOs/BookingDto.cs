namespace SpaceReserve.AppService.DTOs;

public class BookingDto
{
    public int BookingID { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
     public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public int UserID { get; set; }
}
