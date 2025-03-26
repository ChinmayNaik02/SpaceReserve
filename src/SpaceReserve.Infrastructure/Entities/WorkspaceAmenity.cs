using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpaceReserve.Infrastructure.Entities;

public class WorkspaceAmenity
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Workspace")]
    public int WorkspaceID { get; set; }
    public virtual Workspace? Workspace { get; set; }

    [ForeignKey("Amenity")]
    public int AmenityID { get; set; }
    public virtual Amenity? Amenity { get; set; }

    public DateTime CreatedDate { get; set; } = DateTime.Now;

}
