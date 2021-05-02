using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Course
    {
        [Required]
        [Key]
        public byte CourseId { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        public int Credits { get; set; }

        
        public Department Department { get; set; }
        public int DepartmentId { get; set; }

       
    }
}