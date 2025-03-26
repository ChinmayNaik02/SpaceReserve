

namespace SpaceReserve.AppService.DTOs;

public class WorkspaceDto
{
  
    public int WorkspaceID { get; set; }
     public int WorkspaceTypeID { get; set; }
      public string? Name { get; set; }
      public int Capacity { get; set; }
      public string? AvailabilityStatus { get; set; }
      public ICollection<BookingDto>? Bookings { get; set; }
      public ICollection<WorkspaceAmenityDto>? WorkspaceAmenities { get; set; }
}
