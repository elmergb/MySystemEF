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
    public partial class TeacherList : Form
    {
        public TeacherList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new TeacherDE();
            form.Show();
            TeacherLoad();
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {
            TeacherLoad();
        }
        public void TeacherLoad()
        {
            using var db = new TaskDBContext();

            //var fullname = db.Teachers.Select(t => t.FirstName + t.MiddleName + t.LastName).ToString(); 
            dgvTeachers.AutoGenerateColumns = true;

            dgvTeachers.DataSource = db.Teachers
                                    .Where(t => t.Status == "Active")
                                    .Select(t => new
                                    {
                                        ID = t.TeacherID,
                                        Fullname = $"{t.FirstName} {t.MiddleName} {t.LastName}",
                                        //First_Name = t.FirstName,
                                        //Middle_Name = t.MiddleName,
                                        //Last_Name = t.LastName,
                                        Qualification = t.Qualification,
                                        Specialization = t.Specialization
                                    }).ToList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTeachers.CurrentRow == null)
            {
                MessageBox.Show($"Select a record");
                return;
            }

            using var db = new TaskDBContext();
            var teacherID = Convert.ToInt32(dgvTeachers.CurrentRow.Cells["ID"].Value);
            var selectedID = db.Teachers.Find(teacherID);

            if (selectedID == null)
            {
                MessageBox.Show($"Teacher not found!");
                return;
            }

            var teacherForm = new TeacherDE(selectedID.TeacherID);
            teacherForm.Show();
            TeacherLoad();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
