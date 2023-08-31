using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("Table")]
    public class Classes
    {
        [Key]
        public int CId { get; set; }
        [Required]
        public string Class { get; set; }
        [Required]
        public string Section { get; set; }
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }

    }
}