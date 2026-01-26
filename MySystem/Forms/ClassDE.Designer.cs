namespace MySystem.Forms
{
    partial class ClassDE
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
            label2 = new Label();
            label1 = new Label();
            cbSection = new ComboBox();
            label6 = new Label();
            label3 = new Label();
            txtClassName = new TextBox();
            label4 = new Label();
            txtAcademicYear = new TextBox();
            label5 = new Label();
            txtRoomNumber = new TextBox();
            label7 = new Label();
            cbTeachers = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtCapacity = new TextBox();
            panel1 = new Panel();
            lblCapacity = new Label();
            label16 = new Label();
            lblAcademicYear = new Label();
            label13 = new Label();
            lblClassTeacher = new Label();
            label14 = new Label();
            lblFullClassName = new Label();
            label12 = new Label();
            label11 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 73);
            label2.Name = "label2";
            label2.Size = new Size(546, 23);
            label2.TabIndex = 7;
            label2.Text = "      Basic Information";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(562, 52);
            label1.TabIndex = 6;
            label1.Text = "    CLASS INFORMATION FORM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbSection
            // 
            cbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSection.Font = new Font("Microsoft New Tai Lue", 13F);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(310, 129);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(223, 30);
            cbSection.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(310, 108);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 16;
            label6.Text = "Section";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 105);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 15;
            label3.Text = "Class Name";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtClassName
            // 
            txtClassName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtClassName.Location = new Point(34, 129);
            txtClassName.Multiline = true;
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(223, 33);
            txtClassName.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 187);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 19;
            label4.Text = "Academic Year";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAcademicYear
            // 
            txtAcademicYear.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAcademicYear.Location = new Point(34, 211);
            txtAcademicYear.Multiline = true;
            txtAcademicYear.Name = "txtAcademicYear";
            txtAcademicYear.Size = new Size(223, 33);
            txtAcademicYear.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 187);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 21;
            label5.Text = "Room Number";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumber.Location = new Point(310, 211);
            txtRoomNumber.Multiline = true;
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(223, 33);
            txtRoomNumber.TabIndex = 20;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(4, 279);
            label7.Name = "label7";
            label7.Size = new Size(546, 23);
            label7.TabIndex = 22;
            label7.Text = "      Class Teacher Assignment";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // cbTeachers
            // 
            cbTeachers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeachers.Font = new Font("Microsoft New Tai Lue", 13F);
            cbTeachers.FormattingEnabled = true;
            cbTeachers.Location = new Point(31, 339);
            cbTeachers.Name = "cbTeachers";
            cbTeachers.Size = new Size(502, 30);
            cbTeachers.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 315);
            label8.Name = "label8";
            label8.Size = new Size(110, 21);
            label8.TabIndex = 23;
            label8.Text = "Class Tearcher";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(4, 389);
            label9.Name = "label9";
            label9.Size = new Size(546, 23);
            label9.TabIndex = 25;
            label9.Text = "      Class Capacity";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(28, 425);
            label10.Name = "label10";
            label10.Size = new Size(143, 21);
            label10.TabIndex = 27;
            label10.Text = "Maximum Capacity";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCapacity
            // 
            txtCapacity.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCapacity.Location = new Point(31, 449);
            txtCapacity.Multiline = true;
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(223, 33);
            txtCapacity.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCapacity);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lblAcademicYear);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(lblClassTeacher);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lblFullClassName);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Location = new Point(31, 513);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 126);
            panel1.TabIndex = 28;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCapacity.Location = new Point(282, 93);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(15, 20);
            lblCapacity.TabIndex = 36;
            lblCapacity.Text = "-";
            lblCapacity.TextChanged += lblCapacity_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(282, 73);
            label16.Name = "label16";
            label16.Size = new Size(66, 20);
            label16.TabIndex = 35;
            label16.Text = "Capacity";
            // 
            // lblAcademicYear
            // 
            lblAcademicYear.AutoSize = true;
            lblAcademicYear.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAcademicYear.Location = new Point(282, 53);
            lblAcademicYear.Name = "lblAcademicYear";
            lblAcademicYear.Size = new Size(15, 20);
            lblAcademicYear.TabIndex = 34;
            lblAcademicYear.Text = "-";
            lblAcademicYear.Click += lblAcademicYear_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(282, 33);
            label13.Name = "label13";
            label13.Size = new Size(108, 20);
            label13.TabIndex = 33;
            label13.Text = "Academic Year";
            // 
            // lblClassTeacher
            // 
            lblClassTeacher.AutoSize = true;
            lblClassTeacher.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClassTeacher.Location = new Point(19, 93);
            lblClassTeacher.Name = "lblClassTeacher";
            lblClassTeacher.Size = new Size(15, 20);
            lblClassTeacher.TabIndex = 32;
            lblClassTeacher.Text = "-";
            lblClassTeacher.Click += lblClassTeacher_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(19, 73);
            label14.Name = "label14";
            label14.Size = new Size(98, 20);
            label14.TabIndex = 31;
            label14.Text = "Class Teacher";
            // 
            // lblFullClassName
            // 
            lblFullClassName.AutoSize = true;
            lblFullClassName.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullClassName.Location = new Point(19, 53);
            lblFullClassName.Name = "lblFullClassName";
            lblFullClassName.Size = new Size(15, 20);
            lblFullClassName.TabIndex = 30;
            lblFullClassName.Text = "-";
            lblFullClassName.Click += lblFullClassName_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(19, 33);
            label12.Name = "label12";
            label12.Size = new Size(136, 20);
            label12.TabIndex = 1;
            label12.Text = "FULL CLASS NAME ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(19, 13);
            label11.Name = "label11";
            label11.Size = new Size(97, 20);
            label11.TabIndex = 0;
            label11.Text = "Class Preview";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(455, 676);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 32);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ClassDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 720);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(txtCapacity);
            Controls.Add(label9);
            Controls.Add(cbTeachers);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtRoomNumber);
            Controls.Add(label4);
            Controls.Add(txtAcademicYear);
            Controls.Add(cbSection);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(txtClassName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClassDE";
            Text = "ClassDE";
            Load += ClassDE_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private ComboBox cbSection;
        private Label label6;
        private Label label3;
        private TextBox txtClassName;
        private Label label4;
        private TextBox txtAcademicYear;
        private Label label5;
        private TextBox txtRoomNumber;
        private Label label7;
        private ComboBox cbTeachers;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtCapacity;
        private Panel panel1;
        private Button btnSave;
        private Label lblClassTeacher;
        private Label label14;
        private Label lblFullClassName;
        private Label label12;
        private Label label11;
        private Label lblCapacity;
        private Label label16;
        private Label lblAcademicYear;
        private Label label13;
    }
}