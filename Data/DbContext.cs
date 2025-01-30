using Microsoft.EntityFrameworkCore;

public class WineDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    //when create a db context get the configutation as a parameter
    public WineDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
    public DbSet<User> Users { get; set; }

}
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
}