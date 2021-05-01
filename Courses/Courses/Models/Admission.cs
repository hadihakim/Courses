using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Admission
    {
        [Key]
        [StringLength(9)]
        [Required]

        public string AdmissionTermCode { get; set; }
        [StringLength(9)]
        [Required]
        public string Semester { get; set; }
        public int Year { get; set; }
    }
}