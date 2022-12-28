using Microsoft.EntityFrameworkCore;
using OrganizationManager.Models;

namespace OrganizationManager.Models;

public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=p;User Id=postgres;Password=youcantlearnthis;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<CompanyOwner> CompanyOwners { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Worker> Workers { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<OrganizationManager.Models.Mission> Mission { get; set; }
}