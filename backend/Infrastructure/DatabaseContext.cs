using backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure;

public class DatabaseContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    public DbSet<Business> Businesses { get; set; }
    public DbSet<BusinessUser> BusinessUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Business>()
            .HasMany(e => e.Users)
            .WithMany(e => e.Businesses)
            .UsingEntity<BusinessUser>();
    }
    
}