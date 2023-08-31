using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        
        public DateTime BirthDate { get; set; }
        public string FatherName { get; set; }
        [Required]
        public double MobileNumber { get; set;}
        public virtual ICollection<Classes> classes { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }

    }
}