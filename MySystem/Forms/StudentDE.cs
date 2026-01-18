using MySystem.Database;
using MySystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySystem.Forms
{
    public partial class StudentDE : Form
    {
        private int? _studentId;
        public StudentDE()
        {
            InitializeComponent();
        }

        public StudentDE(int StudentId)
        {
            InitializeComponent();
            _studentId = StudentId;
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void StudentDE_Load(object sender, EventArgs e)
        {
            if (_studentId == null)
            {
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                cbGender.Text = "";
                dtpDateOfBirth.Value = DateTime.Now;
                txtPhoneNumber.Clear();
                txtGuardianName.Clear();
                txtAddress.Clear();
                txtGuardianPhone.Clear();
                dtpEnrollmentDate.Value = DateTime.Now;
                cbStatus.Text = "";
                picture.Image = null;
                return;
            }

            using var db = new TaskDBContext();
            var student = db.student
                .FirstOrDefault(s => s.StudentID == _studentId);

            if (student == null)
            {
                MessageBox.Show("Record not found");
                return;
            }
            txtFirstName.Text = student.FirstName;
            txtMiddleName.Text = student.MiddleName;
            txtLastName.Text = student.LastName;
            cbGender.Text = student.Gender;
            dtpDateOfBirth.Value = student.DateOfBirth;
            txtPhoneNumber.Text = student.PhoneNumber;
            txtGuardianName.Text = student.GuardianName;
            txtAddress.Text = student.Address;
            txtGuardianPhone.Text = student.GuardianPhone;
            dtpEnrollmentDate.Value = student.EnrollmentDate;
            cbStatus.Text = student.Status;
            using var ms = new MemoryStream(student.PhotoPath);
            picture.Image = Image.FromStream(ms);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using var db = new TaskDBContext();
            var student = db.student.FirstOrDefault(s => s.StudentID == _studentId);
            if (student != null)
            {
                student.FirstName = txtFirstName.Text;
                student.MiddleName = txtMiddleName.Text;
                student.LastName = txtLastName.Text;
                student.Gender = cbGender.Text;
                student.DateOfBirth = dtpDateOfBirth.Value;
                student.PhoneNumber = txtPhoneNumber.Text;
                student.GuardianName = txtGuardianName.Text;
                student.Address = txtAddress.Text;
                student.GuardianPhone = txtGuardianPhone.Text;
                student.EnrollmentDate = dtpEnrollmentDate.Value;
                student.PhotoPath = selectedPhoto;
                db.SaveChanges();
            }
            else
            {
                var studentNew = new students
                {
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    Gender = cbGender.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    PhoneNumber = txtPhoneNumber.Text,
                    GuardianName = txtGuardianName.Text,
                    Address = txtAddress.Text,
                    GuardianPhone = txtGuardianPhone.Text,
                    EnrollmentDate = dtpEnrollmentDate.Value,
                    PhotoPath = selectedPhoto
                };
                db.Add(studentNew);
                db.SaveChanges();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {

        }
        public byte[]? selectedPhoto = null;
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                selectedPhoto = File.ReadAllBytes(ofd.FileName);

                using var ms = new MemoryStream(selectedPhoto);
                picture.Image = Image.FromStream(ms);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
