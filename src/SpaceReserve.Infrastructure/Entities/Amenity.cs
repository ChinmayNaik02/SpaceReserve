using System.ComponentModel.DataAnnotations;

namespace SpaceReserve.Infrastructure.Entities;

public class Amenity
{
    [Key]
    public int AmenityID { get; set; }

    [Required, MaxLength(255)]
    public string AmenityName { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    // Navigation Property
    public virtual ICollection<WorkspaceAmenity>? WorkspaceAmenities { get; set; }
}
