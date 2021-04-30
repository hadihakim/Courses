using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Major
    {
        [Key, Column(Order = 0)]
        public byte MajorId { get; set; }
        [Required]
        public string MajorName { get; set; }

        
        public Department Department { get; set; }
        [Key, Column(Order = 2)]
        public int DepartmentId { get; set; }
        

    }
}