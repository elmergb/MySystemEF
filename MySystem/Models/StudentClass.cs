using MySystem.Forms;
using MySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class StudentClass
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int StudentID { get; set; }
        public int ClassID { get; set; }

        public DateTime EnrollmentDate { get; set; }
        public string Status { get; set; }

        // Navigation
        public students Student { get; set; }
        public Class Class { get; set; }
    }
}
