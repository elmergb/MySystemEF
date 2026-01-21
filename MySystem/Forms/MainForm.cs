using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySystem.Models;
namespace MySystem.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Panel panelContent = new Panel();
            panelContent.Dock = DockStyle.Fill;
            panelContent.AutoScroll = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var course = new Courses();
            course.ShowDialog();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {

            PanelContent.Controls.Clear();
            StudentList student = new StudentList();
            student.TopLevel = false;
            student.FormBorderStyle = FormBorderStyle.None;
            student.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(student);
            student.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var teacher = new TeacherList();
            PanelContent.Controls.Clear();
            teacher.TopLevel = false;
            teacher.FormBorderStyle = FormBorderStyle.None;
            teacher.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(teacher);
            teacher.Show();
        }
    }
}
