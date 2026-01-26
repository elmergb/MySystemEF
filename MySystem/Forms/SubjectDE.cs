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
            if (string.IsNullOrWhiteSpace(txtSubjectCode.Text) || string.IsNullOrWhiteSpace(txtSubjectName.Text))
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
                SubjectName = txtSubjectName.Text,
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

        private void SubjectDE_Load(object sender, EventArgs e)
        {

        }
        public Panel CreateSubjectCard(Subject subject)
        {
            Panel card = new Panel
            {
                Width = 260,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.White
            };

            // Subject Code
            Label lblCode = new Label
            {
                Text = subject.SubjectCode,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            // Subject Name
            Label lblName = new Label
            {
                Text = subject.SubjectName,
                Location = new Point(10, 35),
                AutoSize = true
            };

            // Description
            Label lblDescription = new Label
            {
                Text = "Desc: " + subject.Description,
                Location = new Point(10, 60),
                AutoSize = true
            };

            // Credits
            Label lblCredits = new Label
            {
                Text = "Credits: " + subject.Credits,
                Location = new Point(10, 85),
                AutoSize = true
            };

            // Teachers assigned (optional)
            var teachersAssigned = subject.ClassSubjects?
                .Select(cs => cs.Teacher)
                .Distinct()
                .ToList();

            Label lblTeachers = new Label
            {
                Text = teachersAssigned != null && teachersAssigned.Count > 0
                       ? "Teachers: " + string.Join(", ", teachersAssigned.Select(t => t.FirstName + " " + t.LastName))
                       : "Teachers: Not assigned yet",
                Location = new Point(10, 110),
                AutoSize = true
            };

            card.Controls.Add(lblCode);
            card.Controls.Add(lblName);
            card.Controls.Add(lblDescription);
            card.Controls.Add(lblCredits);
            card.Controls.Add(lblTeachers);

            return card;
        }


    }
}
