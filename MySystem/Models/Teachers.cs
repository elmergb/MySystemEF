using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models
{
    public class Teachers
    {
        [Key]
       public int TeacherID {get;set;}

       public string FirstName { get; set; }
       public string MiddleName { get; set; }
       public string LastName { get; set; }
       public DateTime DateOfBirth { get; set; }
       public string Gender { get; set; }
       public string Address { get; set; }
       public string PhoneNumber { get; set; }
       public string Email { get; set;}
       public string Qualification { get; set;}
       public string Specialization { get; set; }
       public DateTime HireDate { get; set; }
       public double Salary { get; set; }
       public string Status { get; set; }
       public string PhotoPath { get; set; }
       public DateTime? CreatedDate { get; set; }

        public ICollection<Class> ClassesHandled { get; set; }
        public ICollection<ClassSubject> ClassSubjects { get; set; }
    }
}
