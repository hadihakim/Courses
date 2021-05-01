using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Student
    {
        [Key]
        
        public byte Id { get; set; }

        [StringLength(60)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60)]
        [Required]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Major Major { get; set; }
        public byte MajorId { get; set; }

        public Admission Admission { get; set; }
        [StringLength(9)]
        public string AdmissionTermCode { get; set; }
    }
}