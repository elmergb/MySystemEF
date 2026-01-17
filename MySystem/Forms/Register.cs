using Microsoft.EntityFrameworkCore;
using MySystem.Database;
using MySystem.Models;
using MySystem.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MySystem.Models.User.Roles;

namespace MySystem.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public bool status { get; set; }
        private void Register_Load(object sender, EventArgs e)
        {
            string[] roles = new string[] {"Admin", "Student", "Teacher" };
            cbRole.Items.AddRange(roles);

          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.Text;
            DateTime now = DateTime.Now;
            status = cbStatus.Checked;

            var user = new User()
            {
                Username = txtUsername.Text,
                PasswordHash = txtPassword.Text,
                UserType = role,
                IsActive = status,
                CreatedDate = now
            };

            try
            {
                using (var db = new TaskDBContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                }

                MessageBox.Show("User added successfully!");
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show("Error: " + ex.InnerException?.Message);
            }
        }
    }
}
