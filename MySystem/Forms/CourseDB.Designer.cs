namespace MySystem.Forms
{
    partial class CourseDB
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
            btnSave = new Button();
            btnCancel = new Button();
            label1 = new Label();
            txtCode = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(331, 295);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 28);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(228, 295);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 28);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 122);
            label1.Name = "label1";
            label1.Size = new Size(96, 18);
            label1.TabIndex = 2;
            label1.Text = "Course Code:";
            // 
            // txtCode
            // 
            txtCode.Location = new Point(174, 122);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(189, 26);
            txtCode.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(174, 162);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(189, 26);
            txtDescription.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 162);
            label2.Name = "label2";
            label2.Size = new Size(102, 18);
            label2.TabIndex = 5;
            label2.Text = "Course Name:";
            // 
            // CourseDB
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 349);
            Controls.Add(label2);
            Controls.Add(txtDescription);
            Controls.Add(txtCode);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CourseDB";
            Text = "CourseDB";
            Load += CourseDB_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Label label1;
        private TextBox txtCode;
        private TextBox txtDescription;
        private Label label2;
    }
}