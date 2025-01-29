using Microsoft.EntityFrameworkCore;

public class WineDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public WineDbContext(DbContextOptions<WineDbContext> options)
        : base(options) { }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseNpgsql("Host=localhost;Database=WineDb;Username=admin;Password=th1825");

}
public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
}