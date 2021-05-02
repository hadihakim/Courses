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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(60)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public Major Major { get; set; }
        public byte MajorId { get; set; }

        public Admission Admission { get; set; }
        [StringLength(9)]
        [Display(Name = "Admission Term Code")]
        public string AdmissionTermCode { get; set; }
    }
}