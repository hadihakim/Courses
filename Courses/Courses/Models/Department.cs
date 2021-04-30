using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        [StringLength(60)]
        public String DepartmentName { get; set; }

    }
}