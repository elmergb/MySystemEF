using MySystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class Section
    {
        [Key] 
        public int SectionID { get; set; }
        public int GradeLevel { get; set; }
        public string SectionName { get; set; } // "Grade 10 - A"
        public int Capacity { get; set; }
        public ICollection<Class> Classes { get; set; }
    }
}
