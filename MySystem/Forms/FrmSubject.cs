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
    public partial class FrmSubject : Form
    {
        public FrmSubject()
        {
            InitializeComponent();
        }

        private void FrmSubject_Load(object sender, EventArgs e)
        {
            LoadSubjectsCards();
        }
        public void LoadSubjectsCards()
        {
            var ui = new SubjectDE();
            flowLayoutPanelSubjetcs.Controls.Clear();

            using var context = new TaskDBContext();

            var subjects = context.Subjects
                .Include(s => s.ClassSubjects)
                    .ThenInclude(cs => cs.Teacher) // teachers may still be empty
                .ToList();

            foreach (var subj in subjects)
            {
                var card = ui.CreateSubjectCard(subj);
                flowLayoutPanelSubjetcs.Controls.Add(card);
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new SubjectDE();
            frm.Show();
        }
    }
}
