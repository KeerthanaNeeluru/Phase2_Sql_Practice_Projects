using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppStuMarks.Models
{
    [Table("Mark")]
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        public string SubName { get; set; }
        public double Marks { get; set; }
        public int SId { get; set; }
        public virtual Student Student { get; set; }
    }
}