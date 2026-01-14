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

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var course = new CourseDB();
            course.Show();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            var course = new Courses();
            course.ShowDialog();
        }
    }
}
