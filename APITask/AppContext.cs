using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace APITask;

public class AppContext : DbContext
{
    public DbSet<Groups> Groups { get; set; }
    public DbSet<Departments> Departments { get; set; }
    public DbSet<Faculties> Faculties { get; set; }
    public DbSet<Teachers> Teachers { get; set; }

    public AppContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-7HUNHTF;Integrated Security=True;ApplicationIntent=ReadWrite; Initial Catalog=AcademyDb;");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Groups>().HasIndex(g => g.Name).IsUnique();
        modelBuilder.Entity<Groups>()
            .HasCheckConstraint("Year", "Year >=1 and Year <=5")
            .HasCheckConstraint("Rating", "Rating > 0 and Rating <= 5")
            .HasIndex(r => r.Id);
        modelBuilder.Entity<Departments>().HasIndex(x => x.Id);
        modelBuilder.Entity<Departments>().Property(x => x.Financing).HasDefaultValue(0);
        modelBuilder.Entity<Departments>().HasIndex(d => d.Name).IsUnique();

        modelBuilder.Entity<Faculties>().HasIndex(x => x.Id);
        modelBuilder.Entity<Faculties>().HasIndex(d => d.Name).IsUnique();

        modelBuilder.Entity<Teachers>().HasIndex(x => x.Id);
        modelBuilder.Entity<Teachers>().Property(x => x.Premium).HasDefaultValue(0);
        modelBuilder.Entity<Teachers>()
            .HasCheckConstraint("Salary", "Salary >= 0")
            .HasCheckConstraint("Premium", "Premium > 0")
            .HasCheckConstraint("EmploymentDate", "EmploymentDate >= '01.01.1990'");
    }
}
