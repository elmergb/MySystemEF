namespace MySystem.Forms
{
    partial class StudentDE
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
            label1 = new Label();
            btnPhoto = new Button();
            groupBox1 = new GroupBox();
            picture = new PictureBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtLastName = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            cbGender = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            label11 = new Label();
            txtGuardianName = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtGuardianPhone = new TextBox();
            label14 = new Label();
            dtpEnrollmentDate = new DateTimePicker();
            label16 = new Label();
            label15 = new Label();
            btnCancel = new Button();
            btnClear = new Button();
            btnSave = new Button();
            label17 = new Label();
            txtMiddleName = new TextBox();
            cbStatus = new ComboBox();
            cbSection = new ComboBox();
            Section = new Label();
            cbGrade = new ComboBox();
            label18 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(546, 52);
            label1.TabIndex = 2;
            label1.Text = "    STUDENT FORM";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPhoto
            // 
            btnPhoto.Location = new Point(40, 155);
            btnPhoto.Name = "btnPhoto";
            btnPhoto.Size = new Size(108, 35);
            btnPhoto.TabIndex = 3;
            btnPhoto.Text = "Browse Photo";
            btnPhoto.UseVisualStyleBackColor = true;
            btnPhoto.Click += btnPhoto_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picture);
            groupBox1.Controls.Add(btnPhoto);
            groupBox1.Location = new Point(347, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(187, 201);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Photo";
            // 
            // picture
            // 
            picture.Location = new Point(27, 32);
            picture.Name = "picture";
            picture.Size = new Size(139, 112);
            picture.TabIndex = 5;
            picture.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 259);
            label2.Name = "label2";
            label2.Size = new Size(546, 23);
            label2.TabIndex = 5;
            label2.Text = "      Personal Information";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.Location = new Point(15, 322);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(153, 33);
            txtFirstName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 298);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 7;
            label3.Text = "First Name:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(364, 298);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 8;
            label4.Text = "Last Name:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.Location = new Point(364, 322);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(158, 33);
            txtLastName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 371);
            label5.Name = "label5";
            label5.Size = new Size(100, 21);
            label5.TabIndex = 10;
            label5.Text = "Date of Birth:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(282, 371);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 11;
            label6.Text = "Gender:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "MM/dd/yyyy";
            dtpDateOfBirth.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(15, 395);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(233, 28);
            dtpDateOfBirth.TabIndex = 12;
            dtpDateOfBirth.Value = new DateTime(2026, 1, 17, 21, 5, 0, 0);
            // 
            // cbGender
            // 
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGender.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(287, 396);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(235, 29);
            cbGender.TabIndex = 13;
            // 
            // label7
            // 
            label7.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(-3, 436);
            label7.Name = "label7";
            label7.Size = new Size(522, 23);
            label7.TabIndex = 14;
            label7.Text = "      Contact Information";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 461);
            label8.Name = "label8";
            label8.Size = new Size(116, 21);
            label8.TabIndex = 15;
            label8.Text = "Phone Number";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(9, 528);
            label10.Name = "label10";
            label10.Size = new Size(137, 21);
            label10.TabIndex = 17;
            label10.Text = "Complete Address";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(12, 485);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(233, 33);
            txtPhoneNumber.TabIndex = 18;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(9, 552);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(505, 88);
            txtAddress.TabIndex = 20;
            // 
            // label11
            // 
            label11.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(-3, 653);
            label11.Name = "label11";
            label11.Size = new Size(515, 23);
            label11.TabIndex = 21;
            label11.Text = "      Guardian Information";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGuardianName
            // 
            txtGuardianName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianName.Location = new Point(15, 708);
            txtGuardianName.Multiline = true;
            txtGuardianName.Name = "txtGuardianName";
            txtGuardianName.Size = new Size(233, 33);
            txtGuardianName.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(15, 684);
            label12.Name = "label12";
            label12.Size = new Size(120, 21);
            label12.TabIndex = 23;
            label12.Text = "Guardian Name";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(275, 684);
            label13.Name = "label13";
            label13.Size = new Size(150, 21);
            label13.TabIndex = 24;
            label13.Text = "Guardian Phone No.";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtGuardianPhone
            // 
            txtGuardianPhone.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuardianPhone.Location = new Point(282, 708);
            txtGuardianPhone.Multiline = true;
            txtGuardianPhone.Name = "txtGuardianPhone";
            txtGuardianPhone.Size = new Size(233, 33);
            txtGuardianPhone.TabIndex = 25;
            // 
            // label14
            // 
            label14.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(0, 754);
            label14.Name = "label14";
            label14.Size = new Size(515, 23);
            label14.TabIndex = 26;
            label14.Text = "      Academic Information";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpEnrollmentDate
            // 
            dtpEnrollmentDate.CustomFormat = "MM/dd/yyyy";
            dtpEnrollmentDate.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEnrollmentDate.Format = DateTimePickerFormat.Custom;
            dtpEnrollmentDate.Location = new Point(15, 810);
            dtpEnrollmentDate.Name = "dtpEnrollmentDate";
            dtpEnrollmentDate.Size = new Size(233, 28);
            dtpEnrollmentDate.TabIndex = 29;
            dtpEnrollmentDate.Value = new DateTime(2026, 1, 17, 21, 5, 0, 0);
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 786);
            label16.Name = "label16";
            label16.Size = new Size(122, 21);
            label16.TabIndex = 28;
            label16.Text = "Enrollment Date";
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(10, 846);
            label15.Name = "label15";
            label15.Size = new Size(53, 21);
            label15.TabIndex = 30;
            label15.Text = "Status";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(15, 941);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 32);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(287, 941);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 32);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(399, 941);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 32);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(188, 298);
            label17.Name = "label17";
            label17.Size = new Size(107, 21);
            label17.TabIndex = 34;
            label17.Text = "Middle Name:";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMiddleName.Location = new Point(188, 322);
            txtMiddleName.Multiline = true;
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(158, 33);
            txtMiddleName.TabIndex = 35;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(15, 873);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(235, 29);
            cbStatus.TabIndex = 31;
            // 
            // cbSection
            // 
            cbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSection.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(277, 809);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(235, 29);
            cbSection.TabIndex = 37;
            // 
            // Section
            // 
            Section.AutoSize = true;
            Section.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Section.Location = new Point(272, 782);
            Section.Name = "Section";
            Section.Size = new Size(61, 21);
            Section.TabIndex = 36;
            Section.Text = "Section";
            Section.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbGrade
            // 
            cbGrade.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGrade.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGrade.FormattingEnabled = true;
            cbGrade.Location = new Point(282, 873);
            cbGrade.Name = "cbGrade";
            cbGrade.Size = new Size(235, 29);
            cbGrade.TabIndex = 39;
            cbGrade.SelectedIndexChanged += cbGrade_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.Location = new Point(277, 846);
            label18.Name = "label18";
            label18.Size = new Size(52, 21);
            label18.TabIndex = 38;
            label18.Text = "Grade";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StudentDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(555, 846);
            Controls.Add(cbGrade);
            Controls.Add(label18);
            Controls.Add(cbSection);
            Controls.Add(Section);
            Controls.Add(txtMiddleName);
            Controls.Add(label17);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnCancel);
            Controls.Add(cbStatus);
            Controls.Add(label15);
            Controls.Add(dtpEnrollmentDate);
            Controls.Add(label16);
            Controls.Add(label14);
            Controls.Add(txtGuardianPhone);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(txtGuardianName);
            Controls.Add(label11);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cbGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtLastName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "StudentDE";
            Text = "StudentDE";
            Load += StudentDE_Load;
            Shown += StudentDE_Shown;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPhoto;
        private GroupBox groupBox1;
        private PictureBox picture;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private Label label4;
        private TextBox txtLastName;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbGender;
        private Label label7;
        private Label label8;
        private Label label10;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private Label label11;
        private TextBox txtGuardianName;
        private Label label12;
        private Label label13;
        private TextBox txtGuardianPhone;
        private Label label14;
        private DateTimePicker dtpEnrollmentDate;
        private Label label16;
        private Label label15;
        private Button btnCancel;
        private Button btnClear;
        private Button btnSave;
        private Label label17;
        private TextBox txtMiddleName;
        private ComboBox cbStatus;
        private ComboBox cbSection;
        private Label Section;
        private ComboBox cbGrade;
        private Label label18;
    }
}