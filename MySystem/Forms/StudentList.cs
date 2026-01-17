using MySystem.Database;
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
    public partial class StudentList : Form
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        public void LoadStudent()
        {
            using var db = new TaskDBContext();

            dgvStudents.DataSource = db.student.ToList();
            
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
