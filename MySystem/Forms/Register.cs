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

namespace MySystem.Forms
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Email = txtEmail.Text
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
