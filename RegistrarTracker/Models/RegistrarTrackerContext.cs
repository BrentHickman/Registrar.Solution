using Microsoft.EntityFrameworkCore;

namespace RegistrarTracker.Models
{
  public class RegistrarTrackerContext : DbContext
  {
    public DbSet<Student> Students { get; set; }

    public RegistrarTrackerContext(DbContextOptions options) : base(options) { }
  }
}
