using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySystem.Models.User
{
    public class User
    {
        public int UserID { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
        public string? UserType { get; set; }
        public int ReferenceID { get; set; } = 0;
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
