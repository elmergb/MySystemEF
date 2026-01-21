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
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
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
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnStudent);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 670);
            panel1.TabIndex = 1;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button10.Location = new Point(3, 451);
            button10.Name = "button10";
            button10.Size = new Size(197, 39);
            button10.TabIndex = 6;
            button10.Text = "Settings";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button9.Location = new Point(3, 406);
            button9.Name = "button9";
            button9.Size = new Size(197, 39);
            button9.TabIndex = 5;
            button9.Text = "Reports";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button8.Location = new Point(3, 361);
            button8.Name = "button8";
            button8.Size = new Size(197, 39);
            button8.TabIndex = 5;
            button8.Text = "Fees";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button7.Location = new Point(3, 316);
            button7.Name = "button7";
            button7.Size = new Size(197, 39);
            button7.TabIndex = 5;
            button7.Text = "Timetable";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button6.Location = new Point(3, 271);
            button6.Name = "button6";
            button6.Size = new Size(197, 39);
            button6.TabIndex = 5;
            button6.Text = "Attendance";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button5.Location = new Point(3, 226);
            button5.Name = "button5";
            button5.Size = new Size(197, 39);
            button5.TabIndex = 5;
            button5.Text = "Grades";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button4.Location = new Point(3, 181);
            button4.Name = "button4";
            button4.Size = new Size(197, 39);
            button4.TabIndex = 5;
            button4.Text = "Subjects";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button3.Location = new Point(3, 136);
            button3.Name = "button3";
            button3.Size = new Size(197, 39);
            button3.TabIndex = 5;
            button3.Text = "Classes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button2.Location = new Point(3, 91);
            button2.Name = "button2";
            button2.Size = new Size(197, 39);
            button2.TabIndex = 4;
            button2.Text = "Teachers";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnStudent
            // 
            btnStudent.FlatAppearance.BorderSize = 0;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            btnStudent.Location = new Point(3, 46);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(197, 39);
            btnStudent.TabIndex = 3;
            btnStudent.Text = "Students";
            btnStudent.UseVisualStyleBackColor = true;
            btnStudent.Click += btnStudent_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            button1.Location = new Point(3, 1);
            button1.Name = "button1";
            button1.Size = new Size(197, 39);
            button1.TabIndex = 2;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PanelContent
            // 
            PanelContent.Dock = DockStyle.Fill;
            PanelContent.Location = new Point(200, 52);
            PanelContent.Name = "PanelContent";
            PanelContent.Size = new Size(967, 670);
            PanelContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 722);
            Controls.Add(PanelContent);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
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
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}