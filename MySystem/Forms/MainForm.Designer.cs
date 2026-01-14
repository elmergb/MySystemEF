namespace MySystem.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            toolStrip1 = new ToolStrip();
            tslblAdd = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            tslblEdit = new ToolStripLabel();
            toolStripSeparator2 = new ToolStripSeparator();
            tslblDelete = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            allToolStripMenuItem = new ToolStripMenuItem();
            pendingToolStripMenuItem = new ToolStripMenuItem();
            doneToolStripMenuItem = new ToolStripMenuItem();
            highToolStripMenuItem = new ToolStripMenuItem();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            dgvStudents = new DataGridView();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tslblAdd, toolStripSeparator1, tslblEdit, toolStripSeparator2, tslblDelete, toolStripButton1, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1045, 53);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tslblAdd
            // 
            tslblAdd.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tslblAdd.Name = "tslblAdd";
            tslblAdd.Size = new Size(41, 50);
            tslblAdd.Text = "Add";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 53);
            // 
            // tslblEdit
            // 
            tslblEdit.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tslblEdit.Name = "tslblEdit";
            tslblEdit.Size = new Size(41, 50);
            tslblEdit.Text = "Edit";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 53);
            // 
            // tslblDelete
            // 
            tslblDelete.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tslblDelete.Name = "tslblDelete";
            tslblDelete.Size = new Size(63, 50);
            tslblDelete.Text = "Delete";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 50);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.AutoSize = false;
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripDropDownButton1 });
            statusStrip1.Location = new Point(0, 53);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1045, 47);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(70, 42);
            toolStripStatusLabel1.Text = "  Filter:";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { allToolStripMenuItem, pendingToolStripMenuItem, doneToolStripMenuItem, highToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(29, 45);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // allToolStripMenuItem
            // 
            allToolStripMenuItem.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allToolStripMenuItem.Name = "allToolStripMenuItem";
            allToolStripMenuItem.Size = new Size(122, 22);
            allToolStripMenuItem.Text = "All";
            // 
            // pendingToolStripMenuItem
            // 
            pendingToolStripMenuItem.Font = new Font("Tahoma", 9.75F);
            pendingToolStripMenuItem.Name = "pendingToolStripMenuItem";
            pendingToolStripMenuItem.Size = new Size(122, 22);
            pendingToolStripMenuItem.Text = "Pending";
            // 
            // doneToolStripMenuItem
            // 
            doneToolStripMenuItem.Font = new Font("Tahoma", 9.75F);
            doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            doneToolStripMenuItem.Size = new Size(122, 22);
            doneToolStripMenuItem.Text = "Done";
            // 
            // highToolStripMenuItem
            // 
            highToolStripMenuItem.Font = new Font("Tahoma", 9.75F);
            highToolStripMenuItem.Name = "highToolStripMenuItem";
            highToolStripMenuItem.Size = new Size(122, 22);
            highToolStripMenuItem.Text = "High";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeColumns = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 103);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.Size = new Size(1021, 412);
            dgvStudents.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(60, 50);
            toolStripLabel1.Text = "Course";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 527);
            Controls.Add(dgvStudents);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripLabel tslblAdd;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel tslblEdit;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel tslblDelete;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem pendingToolStripMenuItem;
        private ToolStripMenuItem doneToolStripMenuItem;
        private ToolStripMenuItem highToolStripMenuItem;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private DataGridView dgvStudents;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
    }
}