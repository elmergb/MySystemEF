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
using static System.Collections.Specialized.BitVector32;

namespace MySystem.Forms
{
    public partial class TeacherDE : Form
    {
        public int? _teacherID;
        private string? selectedPhotoPath;
        public TeacherDE()
        {
            InitializeComponent();
        }
        public TeacherDE(int TeacherID)
        {
            InitializeComponent();
            this._teacherID = TeacherID;
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
        private void TeacherDE_Load(object sender, EventArgs e)
        {
            string[] gender = { "Male", "Female", "Others" };
            string[] status = { "Active", "Inactive" };
            cbGender.Items.AddRange(gender);
            cbStatus.Items.AddRange(status);

            if (_teacherID == null)
            {
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                dtpDateOfBirth.Value = DateTime.Now;
                cbGender.Text = "";
                txtAddress.Clear();
                txtPhoneNumber.Clear();
                txtEmail.Clear();
                cbStatus.Text = "";
                txtQualification.Clear();
                txtSpecialization.Clear();
                dtpHireDate.Value = DateTime.Now;
                picture.Image = null;
            }

            using var db = new TaskDBContext();
            var teacher = db.Teachers.SingleOrDefault(t => t.TeacherID == _teacherID);
            if (teacher != null)
            {
                txtFirstName.Text = teacher.FirstName;
                txtMiddleName.Text = teacher.MiddleName;
                txtLastName.Text = teacher.LastName;
                dtpDateOfBirth.Value = teacher.DateOfBirth;
                cbGender.Text = teacher.Gender;
                txtAddress.Text = teacher.Address;
                txtPhoneNumber.Text = teacher.PhoneNumber;
                txtEmail.Text = teacher.Email;
                txtQualification.Text = teacher.Qualification;
                dtpHireDate.Value = teacher.HireDate ;
                txtSpecialization.Text = teacher.Specialization;
                cbStatus.Text = teacher.Status;
                selectedPhotoPath = teacher.PhotoPath; // keep existing
                LoadImage(selectedPhotoPath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            using var db = new TaskDBContext();
            var teacher = db.Teachers.SingleOrDefault(t => t.TeacherID == _teacherID);
            if (teacher != null)
            {
                teacher.FirstName = txtFirstName.Text;
                teacher.MiddleName = txtMiddleName.Text;
                teacher.LastName = txtLastName.Text;
                teacher.DateOfBirth = dtpDateOfBirth.Value;
                teacher.Gender = cbGender.Text;
                teacher.Address = txtAddress.Text;
                teacher.PhoneNumber = txtPhoneNumber.Text;
                teacher.Email = txtEmail.Text;
                teacher.Qualification = txtQualification.Text;
                teacher.HireDate = dtpHireDate.Value;
                teacher.Specialization = txtSpecialization.Text;
                teacher.Status = cbStatus.Text;
                if (!string.IsNullOrWhiteSpace(selectedPhotoPath))
                    teacher.PhotoPath = selectedPhotoPath;
                db.SaveChanges();
                MessageBox.Show($"Successfully updated");
            }
            else
            {
                var teacherNew = new Teachers{
                    FirstName = txtFirstName.Text,
                    MiddleName = txtMiddleName.Text,
                    LastName = txtLastName.Text,
                    DateOfBirth = dtpDateOfBirth.Value,
                    Gender = cbGender.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Email = txtEmail.Text,
                    Qualification = txtQualification.Text,
                    HireDate = dtpHireDate.Value,
                    Specialization = txtSpecialization.Text,
                    PhotoPath = selectedPhotoPath,
                    Status = cbStatus.Text,
                    CreatedDate = DateTime.Now
                };
                MessageBox.Show($"Successfully Added");
                db.Add(teacherNew);
                db.SaveChanges();
            }
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
    }
}
