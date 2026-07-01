using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class Business
{
    [Key]
    public Guid BusinessId { get; init; } = Guid.NewGuid();
    
    [Required, MaxLength(50)]
    public required string Name { get; set; }
    
    [Required]
    public required string Address { get; set; }
    
    [Required, MaxLength(50)]
    public required string City { get; set; }
    
    [Required, MaxLength(50)]
    public required string Region { get; set; }
    
    [Required, MaxLength(50)]
    public required string PostalCode { get; set; }
    
    [Required, MaxLength(50)]
    public required string Country { get; set; }
    
    [Required, MaxLength(12)]
    public required string PhoneNumber { get; set; }

    public List<User> Users { get; } = [];

}