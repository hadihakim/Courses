using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Courses.Models;

namespace Courses.ViewModels
{
    public class NewEnrollmentViewModel
    {
        internal DbSet<Enrollment> enrollments;

        public IEnumerable<Admission> admissions{ get; set; }

        public IEnumerable<Student> students { get; set; }

        public IEnumerable<Course> courses { get; set; }

        public IEnumerable<Major> majors { get; set; }

        public Enrollment Enrollment { get; set; }
    }
}