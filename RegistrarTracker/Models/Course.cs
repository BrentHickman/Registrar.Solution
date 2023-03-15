using System.Collections.Generic;
namespace RegistrarTracker.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string CourseName { get; set; }
    public string CourseCode { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}