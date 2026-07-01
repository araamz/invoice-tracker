using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Infrastructure;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}

    public DbSet<User> Users { get; set; }
    public DbSet<Business> Businesses { get; set; }
    public DbSet<BusinessUser> BusinessUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Business>().HasMany(e => e.Users).WithMany(e => e.Businesses).UsingEntity<BusinessUser>();
    }
    
}