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
    public partial class AssignSubjectAndTeacher : Form
    {
        public string? _section;
        public string? _SelectedRoom;
        public int _selectedID;
        public AssignSubjectAndTeacher()
        {
            InitializeComponent();
        }
        public AssignSubjectAndTeacher(string SelectedRoom, string Section, int SelectedID)
        {
            InitializeComponent();
            _SelectedRoom = SelectedRoom;
            _section = Section;
            _selectedID = SelectedID;
        }
        private void AssignSubjectAndTeacher_Load(object sender, EventArgs e)
        {
            txtRoomNumberSelected.Text = _SelectedRoom.ToString();
            txtSection.Text = _section.ToString();
            txtRoomID.Text = _selectedID.ToString();

            using var db = new TaskDBContext();
            var teacher = db.Teachers
                            .Where(t => t.Status == "Active")
                            .Select(t => new
                            {
                                t.TeacherID,
                                FullName = t.FirstName + " " + t.MiddleName + " " + t.LastName
                            }).ToList();

            cbTeacher.DataSource = teacher;
            cbTeacher.DisplayMember = "FullName";
            cbTeacher.ValueMember = "TeacherID";

            var Subject = db.Subjects
                                .Select(s => new
                                {
                                    s.SubjectID,
                                   SubjectName = s.SubjectCode + " | " + s.SubjectName
                                }).ToList();

            cbSubject.DataSource = Subject;
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectID";
        }
      
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbTeacher.SelectedValue == null || cbSubject.SelectedValue == null)
            {
                MessageBox.Show("Please Select");
                return;
            }

            int teacher = (int)cbTeacher.SelectedValue;
            int subject = (int)cbSubject.SelectedValue;
            string schedule = txtSchedule.Text;

            using var db = new TaskDBContext();

            bool exists = db.ClassSubjects.Any(cs =>
               cs.ClassID == _selectedID &&
               cs.SubjectID == subject
                );

            if (exists)
            {
                MessageBox.Show("This subject is already assigned to this class.");
                return;
            }


            var assignment = new ClassSubject
            {
                ClassID = _selectedID,
                SubjectID = subject,
                TeacherID = teacher,
                Schedule = schedule
            };

            db.ClassSubjects.Add(assignment);
            db.SaveChanges();

            MessageBox.Show("Teacher assigned successfully.");

            // Optional refresh
            //LoadAssignedSubjects(selectedClass.ClassID);
        }
    }
}
