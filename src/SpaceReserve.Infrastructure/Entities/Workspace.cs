using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceReserve.Infrastructure.Entities;

public class Workspace
{
    [Key]
    public int WorkspaceID { get; set; }

    [ForeignKey("WorkspaceType")]
    public int WorkspaceTypeID { get; set; }
    public WorkspaceType? WorkspaceType { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Capacity { get; set; }

    [Required, MaxLength(255)]
    public string AvailabilityStatus { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; } = DateTime.Now;
    // Navigation Properties
    public virtual ICollection<Booking>? Bookings { get; set; }
    public virtual ICollection<WorkspaceAmenity>? WorkspaceAmenities { get; set; }
}
