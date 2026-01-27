namespace MySystem.Forms
{
    partial class SubjectDE
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
            label3 = new Label();
            txtSubjectCode = new TextBox();
            label2 = new Label();
            lblSu = new Label();
            lblDes = new Label();
            txtDescription = new TextBox();
            lblC = new Label();
            txtCredits = new TextBox();
            btnSave = new Button();
            cbSubjects = new ComboBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 148);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 16;
            label3.Text = "Subject Code";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSubjectCode
            // 
            txtSubjectCode.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubjectCode.Location = new Point(23, 172);
            txtSubjectCode.Multiline = true;
            txtSubjectCode.Name = "txtSubjectCode";
            txtSubjectCode.Size = new Size(281, 33);
            txtSubjectCode.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 42);
            label2.Name = "label2";
            label2.Size = new Size(546, 23);
            label2.TabIndex = 14;
            label2.Text = "      Personal Information";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSu
            // 
            lblSu.AutoSize = true;
            lblSu.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSu.Location = new Point(20, 217);
            lblSu.Name = "lblSu";
            lblSu.Size = new Size(107, 21);
            lblSu.TabIndex = 18;
            lblSu.Text = "Subject Name";
            lblSu.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDes
            // 
            lblDes.AutoSize = true;
            lblDes.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDes.Location = new Point(17, 286);
            lblDes.Name = "lblDes";
            lblDes.Size = new Size(89, 21);
            lblDes.TabIndex = 20;
            lblDes.Text = "Description";
            lblDes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(20, 310);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(281, 33);
            txtDescription.TabIndex = 19;
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblC.Location = new Point(17, 360);
            lblC.Name = "lblC";
            lblC.Size = new Size(59, 21);
            lblC.TabIndex = 22;
            lblC.Text = "Credits";
            lblC.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCredits
            // 
            txtCredits.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCredits.Location = new Point(20, 384);
            txtCredits.Multiline = true;
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(281, 33);
            txtCredits.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(457, 477);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(123, 32);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbSubjects
            // 
            cbSubjects.Font = new Font("Microsoft New Tai Lue", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSubjects.FormattingEnabled = true;
            cbSubjects.Location = new Point(20, 241);
            cbSubjects.Name = "cbSubjects";
            cbSubjects.Size = new Size(281, 29);
            cbSubjects.TabIndex = 35;
            // 
            // SubjectDE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 511);
            Controls.Add(cbSubjects);
            Controls.Add(btnSave);
            Controls.Add(lblC);
            Controls.Add(txtCredits);
            Controls.Add(lblDes);
            Controls.Add(txtDescription);
            Controls.Add(lblSu);
            Controls.Add(label3);
            Controls.Add(txtSubjectCode);
            Controls.Add(label2);
            Name = "SubjectDE";
            Text = "SubjectDE";
            Load += SubjectDE_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label6;
        private Label label3;
        private TextBox txtSubjectCode;
        private Label label2;
        private Label lblSu;
        private Label lblDes;
        private TextBox txtDescription;
        private Label lblC;
        private TextBox txtCredits;
        private Button btnSave;
        private ComboBox cbSubjects;
    }
}