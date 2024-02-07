using EfcDataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfcDataAccess;

public class Context : DbContext
{
    public DbSet<Show> Show { get; set; }
    public DbSet<Episode> Episode { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source= Shows.db");
        optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Show>()
            .HasKey(p => p.Title);

    }
}