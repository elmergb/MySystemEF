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
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            label1 = new Label();
            panel1 = new Panel();
            btnStudent = new Button();
            button1 = new Button();
            PanelContent = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(76, 131, 158);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bitstream Vera Sans Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1167, 52);
            label1.TabIndex = 0;
            label1.Text = "    SCHOOL MANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 495);
            panel1.TabIndex = 1;
            // 
            // btnStudent
            // 
            btnStudent.FlatStyle = FlatStyle.Popup;
            btnStudent.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(0, 56);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(200, 59);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Sans Serif Collection", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(200, 52);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(967, 495);
            PanelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 547);
            Controls.Add(PanelContent);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Label label1;
        private Panel panel1;
        private Button btnStudent;
        private Button button1;
        private Panel PanelContent;
    }
}