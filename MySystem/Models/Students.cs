using MySystem.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using TaskStatus = MySystem.Models.Enums.TaskStatus;

namespace MySystem.Models
{

        public class students
        {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Section { get; set;}
        public string GradeLevel { get; set; }
        public string PhoneNumber { get; set; }
        public string GuardianName { get; set; }
        public string GuardianPhone { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string? PhotoPath { get; set; }
        public string Status { get; set; }

        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
