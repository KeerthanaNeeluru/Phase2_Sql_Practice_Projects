using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Subject")]
    public class Subject
    {
        [Key]
        public int SId { get; set; }
        [Required]
        public string SubjectName {  get; set; }
        [Required]
        public int Score { get; set; }

        public int StudentName { get; set; }
        public virtual Student Student { get; set; }
        
    }
}