using MySystem.Database;
using MySystem.Models;
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

            dgvStudents.AutoGenerateColumns = true;

            dgvStudents.DataSource = db.student
                .Select(s => new
                {
                    ID = s.StudentID,
                    First_Name = s.FirstName,
                    Middle_Name = s.MiddleName,
                    Last_Name = s.LastName,
                    Gender = s.Gender,
                    Phone_Number = s.PhoneNumber
                })
                .ToList();

            //dgvStudents.DataSource = db.student.ToList();

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new StudentDE();
            form.ShowDialog();
            LoadStudent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show($"Please select a record to edit");
                return;
            }
            var db = new TaskDBContext();
            int studentId = Convert.ToInt32(dgvStudents.CurrentRow.Cells["ID"].Value);
            var selectedStudent = db.student.Find(studentId);

            if (selectedStudent == null)
            {
                MessageBox.Show($"Student not found");
                return;
            }

            var form = new StudentDE(selectedStudent.StudentID);
            form.ShowDialog();
            LoadStudent();
        }
    }
}
