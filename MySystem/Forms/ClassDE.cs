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
    public partial class ClassDE : Form
    {

        public ClassDE()
        {
            InitializeComponent();
        }
        //public void loadsectionsef(Combox cb)
        //{
        //    using (var context = new schoolcontext())
        //    {
        //        var sections = context.sections
        //                              .select(s => new
        //                              {
        //                                  s.sectionid,
        //                                  s.sectionname
        //                              })
        //                              .tolist();

        //        cb.datasource = sections;
        //        cb.displaymember = "sectionname";
        //        cb.valuemember = "sectionid";
        //    }
        //}
        private void btnSave_Click(object sender, EventArgs e)
        {
            var ui = new Classess();
            using var db = new TaskDBContext();

            var newClass = new Class
            {
                ClassName = txtClassName.Text,
                Section = cbSection.Text,
                AcademicYear = txtAcademicYear.Text,
                Capacity = Convert.ToInt32(txtCapacity.Text),
                ClassTeacherID = (int)cbTeachers.SelectedValue,
                RoomNumber = Convert.ToInt32(txtRoomNumber.Text),
                CreatedDate = DateTime.Now
            };

            db.Add(newClass);
            db.SaveChanges();
            db.Entry(newClass).Reference(c => c.ClassTeacher).Load();

            Panel card = CreateClassCard(newClass);
            ui.flowLayoutPanelClasses.Controls.Add(card);

            ClearInputs();
        }
        private void ClearInputs()
        {
            txtClassName.Clear();
            cbSection.Text = "";
            txtAcademicYear.Clear();
            txtCapacity.Clear();
            cbTeachers.SelectedIndex = 0;
        }
        #region CreateClassCard Auto Generate
        public Panel CreateClassCard(Class cls)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 180,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            Label lblClass = new Label
            {
                Text = cls.ClassName,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblTeacher = new Label
            {
                Text = "Teacher: " +
                       $"{cls.ClassTeacher.FirstName} {cls.ClassTeacher.LastName}",
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblSection = new Label
            {
                Text = $"Section: {cls.Section}",
                Location = new Point(10, 65),
                AutoSize = true
            };

            Label lblCapacity = new Label
            {
                Text = $"Capacity: {cls.Capacity}",
                Location = new Point(10, 90),
                AutoSize = true
            };

            Label lblRoomNumber = new Label
            {
                Text = $"Room No: {cls.RoomNumber}",
                Location = new Point(10, 105),
                AutoSize = true
            };

            card.Controls.Add(lblClass);
            card.Controls.Add(lblTeacher);
            card.Controls.Add(lblSection);
            card.Controls.Add(lblCapacity);
            card.Controls.Add(lblRoomNumber);

            return card;
        }
        #endregion
        private void ClassDE_Load(object sender, EventArgs e)
        {
            #region combo box datasource
            cbTeachers.SelectedIndex = -1;
            using var db = new TaskDBContext();
            var teachers = db.Teachers
                        .Select(t => new
                        {
                            t.TeacherID,
                            FullName = t.FirstName + " " + t.MiddleName + " " + t.LastName
                        }).ToList();

            cbTeachers.DataSource = teachers;
            cbTeachers.DisplayMember = "FullName";
            cbTeachers.ValueMember = "TeacherID";
            #endregion
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblFullClassName_Click(object sender, EventArgs e)
        {
            lblFullClassName.Text = txtClassName.Text;
        }

        private void lblClassTeacher_Click(object sender, EventArgs e)
        {
            lblClassTeacher.Text = cbTeachers.SelectedText;
        }

        private void lblAcademicYear_Click(object sender, EventArgs e)
        {
            lblAcademicYear.Text = txtAcademicYear.Text;
        }

        private void lblCapacity_TextChanged(object sender, EventArgs e)
        {
            lblCapacity.Text = txtCapacity.Text;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
