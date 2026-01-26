using MySystem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class Class
    {
        
  
        public int ClassID { get; set; }

        public string ClassName { get; set; }
        public string Section { get; set; }
        public string AcademicYear { get; set; }

        [ForeignKey("TeacherID")]
        public int ClassTeacherID { get; set; }
        public int Capacity { get; set; }
        public int? RoomNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        // 🔹 Navigation Property
        public Teachers ClassTeacher { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
