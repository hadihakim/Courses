using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Courses.Models
{
    public class Enrollment
    {
        public Admission Admission { get; set; }
        [StringLength(9)]
        [Required]
        public string TermCode { get; set; }

        public Student Student { get; set; }
        [Key, Column(Order = 1)]
        [Display(Name = "Student")]
        public byte StudentId { get; set; }

        public Course Course { get; set; }
        [Required]
        [Key, Column(Order = 2)]
        [Display(Name = "Course")]
        public byte CourseId { get; set; }

        public Major Major { get; set; }
        [Display(Name = "Major")]
        public byte MajorId { get; set; }


        [Required]
        [Range(1,100)]
        public int Grade { get; set; }

        [Required]
        public Boolean EnrolledIndicator { get; set; }


        [Required]
        public Boolean PaymentIndicator { get; set; }

    }
}