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



        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            // Best practice: get the entity from DataBoundItem
            var selectedStudent = dgvCourse.CurrentRow.DataBoundItem as Course;

            if (selectedStudent == null)
                return;

            using var editForm = new CourseDB(selectedStudent.CourseID);
            editForm.ShowDialog();

            LoadCourse(); // refresh grid after edit
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            var addForm = new CourseDB();
            addForm.ShowDialog();
            LoadCourse();
        }
        public void LoadCourse()
        {
            //var db = new TaskDBContext();

            //dgvCourse.DataSource = db.courses
            //                    .Select(c => new
            //                    {
            //                        c.CourseID,
            //                        c.courseCode,
            //                        c.courseDescription
            //                    }).ToList();
            using var db = new TaskDBContext();

            // Bind the actual Course entities so DataBoundItem is a Course instance
            dgvCourse.AutoGenerateColumns = true;
            dgvCourse.DataSource = db.courses.ToList();
            if (dgvCourse.Columns.Contains("CourseID"))
                dgvCourse.Columns["CourseID"].Visible = false;
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            int courseId;
            var courseBound = dgvCourse.CurrentRow.DataBoundItem as Course;

            if (courseBound != null)
            {
                courseId = courseBound.CourseID;
            }
            else
            {
                // Fallback: read CourseID from the cell (if you use projection)
                var idCell = dgvCourse.CurrentRow.Cells["CourseID"];
                if (idCell?.Value == null || !int.TryParse(idCell.Value.ToString(), out courseId))
                {
                    MessageBox.Show("Unable to determine Course ID for the selected row.");
                    return;
                }
            }
                var confirm = MessageBox.Show("Are you sure you want to delete the selected course?", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm != DialogResult.Yes)
                    return;

                using var db = new TaskDBContext();
                var c = db.courses.Find(courseId);
                if (c == null)
                {
                    MessageBox.Show("Record not found.");
                    return;
                }

                db.Remove(c);
                db.SaveChanges();

                LoadCourse();
        }
    }
}
