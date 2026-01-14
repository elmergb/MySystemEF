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

namespace MySystem.Forms
{
  
    public partial class CourseDB : Form
    {
        public int? userID;
        private int? _courseId;
        public CourseDB()
        {
            InitializeComponent();
        }

        public CourseDB(int course) : this()
        {
            _courseId = course;
        }
        private void CourseLoad()
        {
            using var db = new TaskDBContext();
          
                var course = db.courses.Find(_courseId);

                if (course == null)
                    MessageBox.Show("Course not found");
                Close();
                    return;

            txtCode.Text = course.courseCode;
            txtDescription.Text = course.courseDescription;
        } 
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (userID > 0)
            {
                using var db = new TaskDBContext();

                var course = db.courses
                    .Where(course => course.CourseID == 2)
                    .FirstOrDefault();


                if (course is Course)
                {
                    course.courseCode = txtCode.Text;
                    course.courseDescription = txtDescription.Text;
                }

                db.SaveChanges();
                MessageBox.Show("Success");
            } 

            
            //string code = txtCode.Text;
            //string courseName = txtDescription.Text;
            //using var db = new TaskDBContext();

            //Course course;

            //if (_courseId.HasValue)
            //{
            //    course = db.courses.Find(_courseId);
            //    if (course == null) return;
            //} else
            //{
            //    course = new Course();
            //    db.Add(course);
            //}

            //course.courseCode = code;
            //course.courseDescription = courseName;

            //db.SaveChanges();
            //MessageBox.Show("Course saved successfully");
            //Close();
        }

        private void CourseDB_Load(object sender, EventArgs e)
        {
            if (_courseId.HasValue)
                CourseLoad();
        }
    }
}
