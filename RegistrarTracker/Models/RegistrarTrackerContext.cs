using Microsoft.EntityFrameworkCore;

namespace RegistrarTracker.Models
{
  public class RegistrarTrackerContext : DbContext
  {
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }

    public RegistrarTrackerContext(DbContextOptions options) : base(options) { }
  }
}
