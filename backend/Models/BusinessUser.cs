using System.ComponentModel.DataAnnotations;

namespace backend.Models;

public class BusinessUser
{
    public Guid BusinessId { get; init; }
    public Guid UserId { get; init; }
    
    public UserRoleEnum Role { get; set; }

    public bool IsRevoked { get; set; } = false;
    
    public DateTime CreatedAt { get; init; }
    public DateTime UpdatedAt { get; set; }
    public DateTime RevokedAt { get; set; }
    public DateTime DeletedAt { get; set; }
}