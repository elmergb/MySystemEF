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
                .Where(s => s.Status == "Active")   
                .Select(s => new
                {
                    ID = s.StudentID,
                    First_Name = s.FirstName,
                    Middle_Name = s.MiddleName,
                    Last_Name = s.LastName,
                    Gender = s.Gender,
                    Phone_Number = s.PhoneNumber,
                    Section = s.Section,
                    g = s.GradeLevel
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

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text == "Search by PhoneNo, First Name, Last Name")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            string text = txtSearch.Text;
            if (text == "")
            {
                text = "Search by PhoneNo, First Name, Last Name";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _StudentID;
            if (dgvStudents.CurrentRow == null)
            {
                MessageBox.Show("Select a record to delete");
                return;
            }

            var selectedID = dgvStudents.CurrentRow.DataBoundItem as students;
            if (selectedID != null)
            {
                _StudentID = selectedID.StudentID;
            }
            else
            {
                var idCell = dgvStudents.CurrentRow.Cells["ID"];
                if (idCell?.Value == null || !int.TryParse(idCell.Value.ToString(), out _StudentID))
                {
                    MessageBox.Show("Student not founds");
                    return;
                }
            }

            var confirmation = MessageBox.Show("@Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation != DialogResult.Yes)
                return;


            var db = new TaskDBContext();
            var findStudent = db.student.Find(_StudentID);

            if (findStudent == null)
            {
                MessageBox.Show($"Student Not Found");
                return;
            }
            else
            {
                var select = db.student.FirstOrDefault(s => s.StudentID == _StudentID);
                select.Status = "Inactive";
            }
            //db.Remove(findStudent);
            db.SaveChanges();
            LoadStudent();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
