using Microsoft.EntityFrameworkCore;

public class DataBaseContext : DbContext
{
  public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
  public DbSet<People> Peoples { get; set; }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost:5432;Database=peoples;Username=postgres;Password=dbpassword");
}