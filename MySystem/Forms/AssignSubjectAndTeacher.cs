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
        public AssignSubjectAndTeacher()
        {
            InitializeComponent();
        }
        public AssignSubjectAndTeacher(string SelectedRoom, string Section)
        {
            InitializeComponent();
            _SelectedRoom = SelectedRoom;
            _section = Section;
        }
        private void AssignSubjectAndTeacher_Load(object sender, EventArgs e)
        {
            txtRoomNumberSelected.Text = _SelectedRoom.ToString();
            txtSection.Text = _section.ToString();
        }
    }
}
