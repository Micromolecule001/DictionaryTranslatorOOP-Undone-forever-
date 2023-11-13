using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Додайте DbSet для вашого класу моделі
    // public DbSet<YourEntity> YourEntities { get; set; }
}
