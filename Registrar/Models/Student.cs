using System;
using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public DateTime DateOfEnrollment { get; set; }
    public virtual ICollection<CourseStudent> Courses { get; }
  }
}