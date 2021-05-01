using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Courses.Models;

namespace Courses.ViewModels
{
    public class EmpStudViewModel
    {
       public Enrollment Enrollment { get; set; }
        public Student Student { get; set; }
        public IEnumerable<Course> course { get; set; }

    }
}