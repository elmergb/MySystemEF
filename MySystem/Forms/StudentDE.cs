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
        private string? selectedPhotoPath;
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
        private void LoadImage(string? path)
        {
            if (!string.IsNullOrWhiteSpace(path) && File.Exists(path))
            {
                using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                using var tempImg = Image.FromStream(fs);
                picture.Image = new Bitmap(tempImg);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                picture.Image = null;
            }
        }
        public string[] section7 = { "Rizal", "Bonifacio ", "Mabini", "Del Pilar", "Luna" };
        public string[] section8 = { "Zeus", "Athena", "Apollo", "Hera", "Poseidon" };
        public string[] section9 = { "Integrity", "Perseverance", "Excellence", "Respect", "Discipline" };
        public string[] section10 = { "Madela", "Gadhi", "Lincoln", "Churchill", "Roosevelt" };
        private void StudentDE_Shown(object sender, EventArgs e)
        {
            // var gradeSections = new Dictionary<string, string[]>
            //  {
            //      { "G-7", section7 },
            //      { "G-8", section8 },
            //      { "G-9", section9 },
            //     { "G-10", section10 }
            // };
            // cbSection.Items.Clear();
            //  cbSection.Text = "";

            //if (gradeSections.TryGetValue(cbGrade.Text, out var sections))
            //{
            //     cbSection.Items.AddRange(sections);
            //  }
            // wrong i think cause the section not displaying in combo box
        }
        private void StudentDE_Load(object sender, EventArgs e)
        {
            string[] gender = { "Male", "Female" };
            string[] status = { "Active", "Inactive" };
            string[] grades = { "G-7", "G-8", "G-9", "G-10" };
            cbGender.Items.AddRange(gender);
            cbStatus.Items.AddRange(status);
            cbGrade.Items.AddRange(grades);
            string section = cbSection.Text;
            string SelectedGrades = cbGrade.Text;
            cbSection.Items.Clear();
            cbSection.Text = "";

            #region -- if else
            //if (SelectedGrades.Contains("7"))
            //{
            //    cbSection.Items.AddRange(section7);
            //} else if (SelectedGrades.Contains("8"))
            //{
            //    cbSection.Items.AddRange(section8);
            //} else if (SelectedGrades.Contains("9"))
            //{
            //    cbSection.Items.AddRange(section9);
            //} else if (SelectedGrades.Contains("10"))
            //{
            //    cbSection.Items.AddRange(section10);
            //} else
            //{
            //    cbSection.Items.Clear();
            //}
            #endregion
            #region --switch 
            //switch (SelectedGrades)
            //{
            //    case "G-7":
            //        cbSection.Items.AddRange(section7);
            //        break;
            //    case "G-8":
            //        cbSection.Items.AddRange(section8);
            //        break;
            //    case "G-9":
            //        cbSection.Items.AddRange(section9);
            //        break;
            //    case "G-10":
            //        cbSection.Items.AddRange(section10);
            //        break;
            //    default:
            //        cbSection.Text = "";
            //        break;
            //}
            #endregion
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
                cbSection.Text = "";
                cbGrade.Text = "";
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
            cbSection.Text = student.Section;
            cbGrade.Text = student.GradeLevel;
            selectedPhotoPath = student.PhotoPath; // keep existing
            LoadImage(selectedPhotoPath);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;
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
                student.Status = cbStatus.Text;
                student.EnrollmentDate = dtpEnrollmentDate.Value;
                student.Section = cbSection.Text;
                student.GradeLevel = cbGrade.Text;
                if (!string.IsNullOrWhiteSpace(selectedPhotoPath))
                    student.PhotoPath = selectedPhotoPath;
                db.SaveChanges();
                MessageBox.Show($"Successfully updated");
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
                    Status = cbStatus.Text,
                    EnrollmentDate = dtpEnrollmentDate.Value,
                    PhotoPath = selectedPhotoPath,
                    Section = cbSection.Text,
                    GradeLevel = cbGrade.Text
                };
                db.Add(studentNew);
                db.SaveChanges();
                MessageBox.Show($"Successfully added");
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure to cancel this record?", "Conformation to cancel this record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
        private void btnPhoto_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string imagesDir = Path.Combine(
                    Application.StartupPath, "Images", "Students");

                Directory.CreateDirectory(imagesDir);

                string newFileName = Guid.NewGuid() + Path.GetExtension(ofd.FileName);
                string destPath = Path.Combine(imagesDir, newFileName);

                File.Copy(ofd.FileName, destPath, true);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                selectedPhotoPath = destPath;
                LoadImage(selectedPhotoPath);
            }
        }

        private bool validation()
        {
            DateTime now = DateTime.Now;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Middle Name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbGender.Text))
            {
                MessageBox.Show("Gender is required");
                return false;
            }

            if (dtpDateOfBirth.Value > now)
            {
                MessageBox.Show("Invalid Date of Birth");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Phone Number is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtGuardianName.Text))
            {
                MessageBox.Show("Guardian Name is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Status is required");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address is required");
                return false;
            }

            if (dtpEnrollmentDate.Value > now)
            {
                MessageBox.Show("Invalid Enrollment Date");
                return false;
            }

            if (picture.Image == null)
            {
                MessageBox.Show("Photo is required");
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show($@"Are you sure to clear all information?", "Confirmation to Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
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

            }
        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSection.Items.Clear();
            switch (cbGrade.Text)
            {
                case "G-7":
                    cbSection.Items.AddRange(section7);
                    break;
                case "G-8":
                    cbSection.Items.AddRange(section8);
                    break;
                case "G-9":
                    cbSection.Items.AddRange(section9);
                    break;
                case "G-10":
                    cbSection.Items.AddRange(section10);
                    break;
            }
        }
    }
}
