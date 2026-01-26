using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }

        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string Description { get; set; }

        public int Credits { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
