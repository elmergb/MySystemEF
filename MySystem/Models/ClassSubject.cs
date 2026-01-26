using MySystem.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class ClassSubject
    {
        public int ClassSubjectID { get; set; }

        public int ClassID { get; set; }
        public int SubjectID { get; set; }
        public int TeacherID { get; set; }

        public string Schedule { get; set; }

        // Navigation
        public Class Class { get; set; }
        public Subject Subject { get; set; }
        public Teachers Teacher { get; set; }
    }
}
