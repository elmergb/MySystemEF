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
            // AssignSubjectAndTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}