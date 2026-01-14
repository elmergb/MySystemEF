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

        public class Students
        {
       
        public int stuID { get; set; }
        public int StudentID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string mi { get; set; }
        public int yearID { get; set; }
        public int courseID { get; set; }

    }
    
}
