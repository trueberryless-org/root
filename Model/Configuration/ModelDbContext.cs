using Model.Entities;

namespace Model.Configuration;

public class ModelDbContext : DbContext
{
    public DbSet<Site> Sites { get; set; }

    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Site>()
            .Property(s => s.Color)
            .HasConversion<string>();
    }
}