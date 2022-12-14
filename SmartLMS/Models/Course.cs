using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SmartLMS.Models
{
    public class Course
    {
        [Key]
        [Display(Name = "Course")]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(20)]
        //[RegularExpression(@"^\S\,*$", ErrorMessage = "No white space allowed")]
        [Display(Name = "Course Code")]
        public string CourseCode { get; set; }

        [Required]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "The module must have a description!")]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [ForeignKey("Category")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [ScaffoldColumn(false)]
        public int Rating { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual ICollection<StudentCourse> Enrollments { get; set; }
        public virtual ICollection<Lecture> Lectures { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }
    }
}