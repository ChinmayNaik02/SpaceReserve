using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceReserve.Infrastructure.Entities;

public class Booking
{
    [Key]
    public int BookingID { get; set; }

    [ForeignKey("User")]
    public int UserID { get; set; }
    public virtual User? User { get; set; }

    [ForeignKey("Workspace")]
    public int WorkspaceID { get; set; }
    public virtual Workspace? Workspace { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    [Required]
    public DateOnly EndDate { get; set; }

    [Required]
    public TimeOnly StartTime { get; set; }

    [Required]
    public TimeOnly EndTime { get; set; }

    [Required, MaxLength(30)]
    public bool IsCancelled { get; set; } = false;

    public DateTime CreatedDate { get; set; } = DateTime.Now;
}
