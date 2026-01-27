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

        public string _classID;
        public ClassDE()
        {
            InitializeComponent();
        }
        public ClassDE(string ClassID)
        {
            InitializeComponent();
            _classID = ClassID;
        }
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
                Width = 300,
                Height = 220,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(12),
                BackColor = Color.White
            };

            // ===== TITLE =====
            Label lblClass = new Label
            {
                Text = cls.ClassName,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(12, 10),
                AutoSize = true
            };

            // ===== DETAILS =====
            int y = 40;
            int lineGap = 22;

            Label lblTeacher = new Label
            {
                Text = $"Adviser: {cls.ClassTeacher?.FirstName} {cls.ClassTeacher?.LastName}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            Label lblSection = new Label
            {
                Text = $"Section: {cls.Section}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            Label lblRoom = new Label
            {
                Text = $"Room: {cls.RoomNumber}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            Label lblCapacity = new Label
            {
                Text = $"Capacity: {cls.Capacity}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            int subjectCount = cls.ClassSubjects?.Count ?? 0;

            Label lblSubjects = new Label
            {
                Text = $"Subjects: {subjectCount}",
                Location = new Point(12, y),
                AutoSize = true,
                ForeColor = Color.DarkBlue
            };

            // ===== BUTTON BAR =====
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            Button btnAssign = new Button
            {
                Text = "Assign",
                Width = 60,
                Location = new Point(10, 7),
                Tag = cls
            };
            btnAssign.Click += btnAssign_Click;

            Button btnView = new Button
            {
                Text = "View",
                Width = 60,
                Location = new Point(80, 7),
                Tag = cls
            };
            btnView.Click += btnView_Click;

            Button btnEdit = new Button
            {
                Text = "Edit",
                Width = 60,
                Location = new Point(150, 7),
                Tag = cls
            };
            btnEdit.Click += btnEdit_Click;

            Button btnDelete = new Button
            {
                Text = "Delete",
                Width = 60,
                Location = new Point(220, 7),
                Tag = cls,
                ForeColor = Color.DarkRed
            };
            btnDelete.Click += btnDelete_Click;

            buttonPanel.Controls.Add(btnAssign);
            buttonPanel.Controls.Add(btnView);
            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);

            // ===== ADD CONTROLS =====
            card.Controls.Add(lblClass);
            card.Controls.Add(lblTeacher);
            card.Controls.Add(lblSection);
            card.Controls.Add(lblRoom);
            card.Controls.Add(lblCapacity);
            card.Controls.Add(lblSubjects);
            card.Controls.Add(buttonPanel);

            return card;
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            var cls = (sender as Button)?.Tag as Class;
            if (cls == null) return;

            MessageBox.Show($"Viewing {cls.ClassName}");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var cls = (sender as Button)?.Tag as Class;
            if (cls == null) return;

            // open edit form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var cls = (sender as Button)?.Tag as Class;
            if (cls == null) return;

            if (MessageBox.Show("Delete this class?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var db = new TaskDBContext();
                var entity = db.Classes.Find(cls.ClassID);
                if (entity != null)
                {
                    db.Classes.Remove(entity);
                    db.SaveChanges();
                }
            }
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