using MySystem.Database;
using MySystem.Services;
using System;
using System.Windows.Forms;

namespace MySystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using ( var context = new TaskDBContext())
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                var user = context.Users
                    .FirstOrDefault(u =>
                                     u.Username == username &&
                                     u.Password == password);

                var mainForm = new MainForm();
                if (user != null) { 
                     mainForm.ShowDialog();
                     this.Close();
                } else
                {
                    MessageBox.Show($"Account not found");
                }


            }
        }

      

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
        }
    }
}
