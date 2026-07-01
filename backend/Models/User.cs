using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace backend.Models;

public class User : IdentityUser<Guid>
{
    
    [Required, MaxLength(50)]
    public required string FirstName { get; init; }
    
    [Required, MaxLength(50)]
    public required string LastName { get; init; }
    
    public List<Business> Businesses { get; } = [];
}