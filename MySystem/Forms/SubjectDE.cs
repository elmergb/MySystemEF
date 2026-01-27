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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using sub = MySystem.Models;

namespace MySystem.Forms
{
    public partial class SubjectDE : Form
    {
        public SubjectDE()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) || string.IsNullOrWhiteSpace(cbSubjects.Text))
            {
                MessageBox.Show("Subject Code and Name are required.");
                return;
            }

            using var context = new TaskDBContext();

            // Optional: Check for duplicate subject code
            bool exists = context.Subjects.Any(s => s.SubjectCode == txtSubjectCode.Text);
            if (exists)
            {
                MessageBox.Show("Subject code already exists.");
                return;
            }

            // gumamit ng alias kasi hindi makita ang class na Subject
            var subject = new sub.Subject
            {
                SubjectCode = txtSubjectCode.Text,
                SubjectName = cbSubjects.Text,
                Description = txtDescription.Text,
                Credits = Convert.ToInt32(txtCredits.Text),
                CreatedDate = DateTime.Now
            };

            context.Subjects.Add(subject);
            context.SaveChanges();

            MessageBox.Show("Subject added successfully.");

            var ui = new FrmSubject();
            ui.LoadSubjectsCards();
        }
        private void subLoad(ComboBox cb)
        {
            using var db = new TaskDBContext();
            var subjects = db.Teachers
                           .Where(s => s.Status == "Active")
                           .Select(s => new
                           {
                               s.TeacherID,
                               Subject = s.Specialization
                           }).ToList(); 

           
            cbSubjects.DataSource = subjects;
            cbSubjects.DisplayMember = "Subject";
            cbSubjects.ValueMember = "TeacherID";
        }
        private void SubjectDE_Load(object sender, EventArgs e)
        {
            subLoad(cbSubjects);
        }
        public Panel CreateSubjectCard(Subject subject)
        {
            Panel card = new Panel
            {
                Width = 300,
                Height = 210,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(12),
                BackColor = Color.White
            };

            // ===== TITLE (Subject Code) =====
            Label lblCode = new Label
            {
                Text = subject.SubjectCode,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(12, 10),
                AutoSize = true
            };

            // ===== SUBJECT NAME =====
            Label lblName = new Label
            {
                Text = subject.SubjectName,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Location = new Point(12, 35),
                AutoSize = true
            };

            // ===== DETAILS =====
            int y = 60;
            int lineGap = 20;

            Label lblCredits = new Label
            {
                Text = $"Credits: {subject.Credits}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            int teacherCount = subject.ClassSubjects?
                .Where(cs => cs.Teacher != null)
                .Select(cs => cs.Teacher.TeacherID)
                .Distinct()
                .Count() ?? 0;

            Label lblTeachers = new Label
            {
                Text = $"Teachers: {teacherCount}",
                Location = new Point(12, y),
                AutoSize = true
            };

            y += lineGap;

            int classCount = subject.ClassSubjects?
                .Select(cs => cs.ClassID)
                .Distinct()
                .Count() ?? 0;

            Label lblClasses = new Label
            {
                Text = $"Classes: {classCount}",
                Location = new Point(12, y),
                AutoSize = true,
                ForeColor = Color.DarkBlue
            };

            // ===== DESCRIPTION (wrapped) =====
            Label lblDescription = new Label
            {
                Text = subject.Description ?? "No description",
                Location = new Point(12, y + lineGap),
                MaximumSize = new Size(260, 0),
                AutoSize = true,
                ForeColor = Color.DimGray
            };

            // ===== BUTTON BAR =====
            Panel buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            Button btnView = new Button
            {
                Text = "View",
                Width = 60,
                Location = new Point(10, 7),
                Tag = subject
            };
            btnView.Click += btnViewSubject_Click;

            Button btnEdit = new Button
            {
                Text = "Edit",
                Width = 60,
                Location = new Point(80, 7),
                Tag = subject
            };
            btnEdit.Click += btnEditSubject_Click;

            Button btnDelete = new Button
            {
                Text = "Delete",
                Width = 60,
                Location = new Point(150, 7),
                ForeColor = Color.DarkRed,
                Tag = subject
            };
            btnDelete.Click += btnDeleteSubject_Click;

            Button btnAssign = new Button
            {
                Text = "Assign",
                Width = 60,
                Location = new Point(220, 7),
                Tag = subject
            };
            btnAssign.Click += btnAssignSubject_Click;

            buttonPanel.Controls.Add(btnView);
            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnAssign);

            // ===== ADD CONTROLS =====
            card.Controls.Add(lblCode);
            card.Controls.Add(lblName);
            card.Controls.Add(lblCredits);
            card.Controls.Add(lblTeachers);
            card.Controls.Add(lblClasses);
            card.Controls.Add(lblDescription);
            card.Controls.Add(buttonPanel);

            return card;
        }
        private void btnViewSubject_Click(object sender, EventArgs e)
        {
            var subject = (sender as Button)?.Tag as Subject;
            if (subject == null) return;

            MessageBox.Show(subject.SubjectName, "Subject Details");
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            var subject = (sender as Button)?.Tag as Subject;
            if (subject == null) return;

            // open EditSubjectForm(subject.SubjectID)
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            var subject = (sender as Button)?.Tag as Subject;
            if (subject == null) return;

            if (MessageBox.Show("Delete this subject?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using var db = new TaskDBContext();
                var entity = db.Subjects.Find(subject.SubjectID);
                if (entity != null)
                {
                    db.Subjects.Remove(entity);
                    db.SaveChanges();
                }
            }
        }

        private void btnAssignSubject_Click(object sender, EventArgs e)
        {
            var subject = (sender as Button)?.Tag as Subject;
            if (subject == null) return;

            // open AssignSubjectToClassForm(subject.SubjectID)
        }


    }
}
