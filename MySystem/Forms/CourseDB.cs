using MySystem.Database;
using MySystem.Models;
using MySystem.Models.Collection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MySystem.Forms
{

    public partial class CourseDB : Form
    {
        private readonly int? _CourseID;
        public CourseDB()
        {
            InitializeComponent();
            _CourseID = null;
        }
        public CourseDB(int CourseID)
        {
            InitializeComponent();
            _CourseID = CourseID;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string description = txtDescription.Text;
            using var context = new TaskDBContext();
            var c = context.courses.FirstOrDefault(s => s.CourseID == _CourseID);
            if (c != null)
            {

                c.courseCode = code;
                c.courseDescription = description;

                context.SaveChanges();

            } else
            {
                var course = new Course
                {
                    courseCode = code,
                    courseDescription = description
                };
                context.Add(course);
                context.SaveChanges();
            }

            //string code = txtCode.Text.Trim();
            //string description = txtDescription.Text.Trim();

            //if (string.IsNullOrWhiteSpace(code))
            //{
            //    MessageBox.Show("Course code is required.");
            //    return;
            //}

            //using var context = new TaskDBContext();
            //var c = context.courses.FirstOrDefault(s => s.CourseID == _CourseID);
            //if (c == null)
            //{
            //    MessageBox.Show("Record not found.");
            //    return;
            //}

            //// Update the tracked entity, not create a new one
            //c.courseCode = code;
            //c.courseDescription = description;

            //try
            //{
            //    context.SaveChanges();
            //    MessageBox.Show("Course updated successfully.");
            //    Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error saving changes: " + ex.Message);
            //}
        }

        private void CourseDB_Load(object sender, EventArgs e)
        {
            
            if (_CourseID == null)
            {
                txtCode.Clear();
                txtDescription.Clear();
                return;
            }

            using var context = new TaskDBContext();
            var c = context.courses.FirstOrDefault(s => s.CourseID == _CourseID);

            if (c == null )
            {
                MessageBox.Show("Record not found.");
               Close();
                return;
            }

            txtCode.Text = c.courseCode;
            txtDescription.Text = c.courseDescription;

            

        }
    }
}
