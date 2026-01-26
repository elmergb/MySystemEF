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

            int subjectCount = cls.ClassSubjects != null ? cls.ClassSubjects.Count : 0;

            Label lblSubject = new Label
            {
                Text = $"Subjects: {subjectCount}",
                Location = new Point(50, 120),
                AutoSize = true,
                ForeColor = Color.DarkBlue
            };

            Button btnAssign = new Button
            {
                Text = $"Assign",
                Location = new Point (30, 140),
                AutoSize = true,
                Tag = cls
            };
            btnAssign.Click += btnAssign_Click;
            card.Controls.Add(lblClass);
            card.Controls.Add(lblSubject);
            card.Controls.Add(lblTeacher);
            card.Controls.Add(lblSection);
            card.Controls.Add(lblCapacity);
            card.Controls.Add(lblRoomNumber);
            card.Controls.Add(btnAssign);
            return card;
        }
        #endregion
        private Class selectedClass;
        AssignSubjectAndTeacher selected = new AssignSubjectAndTeacher();
        private void btnAssign_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            Class cls = btn.Tag as Class;
            if (cls == null) return;

            selectedClass = cls;
            // Populate Room TextBox or any other controls
            using var db = new TaskDBContext();
        
            var select = selected.txtRoomNumberSelected.Text = cls.RoomNumber.ToString().Trim();
            int classID = selectedClass.ClassID;
            var selectedSection = selected.txtSection.Text = cls.Section.ToString().Trim(); 
            var frm = new AssignSubjectAndTeacher(select, selectedSection, classID);
            frm.Show();
        }

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
    }
}