namespace MySystem.Forms
{
    partial class AssignSubjectAndTeacher
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
            txtRoomNumberSelected = new TextBox();
            label17 = new Label();
            txtSection = new TextBox();
            label1 = new Label();
            cbSubject = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbTeacher = new ComboBox();
            label4 = new Label();
            txtSchedule = new TextBox();
            btnSave = new Button();
            txtRoomID = new TextBox();
            SuspendLayout();
            // 
            // txtRoomNumberSelected
            // 
            txtRoomNumberSelected.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomNumberSelected.Location = new Point(238, 98);
            txtRoomNumberSelected.Multiline = true;
            txtRoomNumberSelected.Name = "txtRoomNumberSelected";
            txtRoomNumberSelected.Size = new Size(158, 33);
            txtRoomNumberSelected.TabIndex = 37;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.Location = new Point(43, 74);
            label17.Name = "label17";
            label17.Size = new Size(61, 21);
            label17.TabIndex = 36;
            label17.Text = "Section";
            label17.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSection
            // 
            txtSection.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSection.Location = new Point(43, 98);
            txtSection.Multiline = true;
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(158, 33);
            txtSection.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 74);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 38;
            label1.Text = "Room Number";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbSubject
            // 
            cbSubject.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSubject.FormattingEnabled = true;
            cbSubject.Location = new Point(43, 170);
            cbSubject.Name = "cbSubject";
            cbSubject.Size = new Size(173, 29);
            cbSubject.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 146);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 41;
            label2.Text = "Subject ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 146);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 43;
            label3.Text = "Teacher";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbTeacher
            // 
            cbTeacher.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTeacher.FormattingEnabled = true;
            cbTeacher.Location = new Point(238, 170);
            cbTeacher.Name = "cbTeacher";
            cbTeacher.Size = new Size(173, 29);
            cbTeacher.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 220);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 45;
            label4.Text = "Schedule";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSchedule
            // 
            txtSchedule.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSchedule.Location = new Point(43, 244);
            txtSchedule.Multiline = true;
            txtSchedule.Name = "txtSchedule";
            txtSchedule.Size = new Size(158, 33);
            txtSchedule.TabIndex = 44;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(389, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(73, 40);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtRoomID
            // 
            txtRoomID.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomID.Location = new Point(279, 244);
            txtRoomID.Multiline = true;
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(158, 33);
            txtRoomID.TabIndex = 47;
            // 
            // AssignSubjectAndTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 450);
            Controls.Add(txtRoomID);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(txtSchedule);
            Controls.Add(label3);
            Controls.Add(cbTeacher);
            Controls.Add(label2);
            Controls.Add(cbSubject);
            Controls.Add(txtSection);
            Controls.Add(label1);
            Controls.Add(txtRoomNumberSelected);
            Controls.Add(label17);
            Name = "AssignSubjectAndTeacher";
            Text = "AssignSubjectAndTeacher";
            Load += AssignSubjectAndTeacher_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtRoomNumberSelected;
        private Label label17;
        public TextBox txtSection;
        private Label label1;
        private ComboBox cbSubject;
        private Label label2;
        private Label label3;
        private ComboBox cbTeacher;
        private Label label4;
        public TextBox txtSchedule;
        private Button btnSave;
        public TextBox txtRoomID;
    }
}