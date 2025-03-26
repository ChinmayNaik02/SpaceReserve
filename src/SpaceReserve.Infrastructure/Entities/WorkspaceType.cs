using System.ComponentModel.DataAnnotations;

namespace SpaceReserve.Infrastructure.Entities;

public class WorkspaceType
{
    [Key]
    public int WorkspaceTypeID { get; set; }

    [Required, MaxLength(255)]
    public string TypeName { get; set; } = string.Empty;

    public DateTime CreatedDate { get; set; } = DateTime.Now;
    // Navigation Property
    public ICollection<Workspace>? Workspaces { get; set; }
}
