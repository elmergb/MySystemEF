using Microsoft.EntityFrameworkCore;
using MySystem.Database;
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
    public partial class Classess : Form
    {
        public Classess()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new ClassDE();
            frm.Show();
        }

        private void Classess_Load(object sender, EventArgs e)
        {
            LoadClasses();
        }
        private void LoadClasses()
        {
            var ui = new ClassDE();
            flowLayoutPanelClasses.Controls.Clear();

            using var context = new TaskDBContext();

            var classes = context.Classes
                .Include(c => c.ClassTeacher)
                .ToList();

            foreach (var cls in classes)
            {
                Panel card = ui.CreateClassCard(cls);
                flowLayoutPanelClasses.Controls.Add(card);
            }
        }

    }
}
