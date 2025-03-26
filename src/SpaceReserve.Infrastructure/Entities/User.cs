using System.ComponentModel.DataAnnotations;

namespace SpaceReserve.Infrastructure.Entities;

public class User
{

    [Key]
    public int UserID { get; set; }

    [Required, MaxLength(255)]
    public string FirstName { get; set; } = string.Empty;

    [Required, MaxLength(255)]
    public string LastName { get; set; } = string.Empty;

    [Required, MaxLength(15)]
    public string Phone { get; set; } = string.Empty;

    [Required, MaxLength(100), EmailAddress]
    public string Email { get; set; } = string.Empty;

    [Required, MaxLength(255)]
    public string HashPassword { get; set; } = string.Empty;

    // Navigation Property
    public virtual ICollection<Booking>? Bookings { get; set; }

}