using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySystem.Database;
namespace MySystem.Forms
{
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            LoadCourse();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var course = new CourseDB();
            course.ShowDialog();
            this.Hide();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            var select = new CourseDB();
            dgvCourse.Tag = select.userID;
            select.ShowDialog();
   //         if (dgvCourse.SelectedRows.Count == 0)
   //         {
   //             MessageBox.Show($"Please select a record");
   //             return;
   //         }

   //         var result = MessageBox.Show(
   //        "Are you sure you want to edit this course?",
   //        "Confirm Edit",
   //        MessageBoxButtons.YesNo,
   //        MessageBoxIcon.Question
   //);

   //         if (result != DialogResult.Yes)
   //             return;

   //         int courseId = (int)dgvCourse.SelectedRows[0].Cells["CourseID"].Value;

   //         var form = new CourseDB();
   //         form.Show();

   //         LoadCourse();
        }
        public void LoadCourse()
        {
            var db = new TaskDBContext();

            dgvCourse.DataSource = db.courses
                                .Select(c => new
                                {
                                    c.CourseID,
                                    c.courseCode,
                                    c.courseDescription
                                }).ToList();
        }
    }
}
