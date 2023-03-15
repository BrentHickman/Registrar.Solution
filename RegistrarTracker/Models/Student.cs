using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace RegistrarTracker.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime Enrollment { get; set; }
    public Department Department { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}