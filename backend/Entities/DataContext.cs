namespace backend.Entities;

using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to sql server with connection string from app settings
        var connectionString = Configuration.GetConnectionString("WebApiDatabase");
        
        options.UseNpgsql(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }

    public DbSet<User> Users { get; set; } = default!;
}