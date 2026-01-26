namespace MySystem.Forms
{
    partial class Register
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
            label1 = new Label();
            txtUsername = new TextBox();
            btnCancel = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            cbStatus = new CheckBox();
            label4 = new Label();
            cbRole = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(253, 223);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(70, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 28);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(177, 27);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(145, 26);
            txtUsername.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(344, 223);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(70, 31);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 100);
            label2.Name = "label2";
            label2.Size = new Size(40, 18);
            label2.TabIndex = 4;
            label2.Text = "Role:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 61);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(145, 26);
            txtPassword.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 64);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // cbStatus
            // 
            cbStatus.AutoSize = true;
            cbStatus.Location = new Point(177, 142);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(15, 14);
            cbStatus.TabIndex = 8;
            cbStatus.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 138);
            label4.Name = "label4";
            label4.Size = new Size(54, 18);
            label4.TabIndex = 9;
            label4.Text = "Status:";
            // 
            // cbRole
            // 
            cbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRole.FormattingEnabled = true;
            cbRole.Location = new Point(177, 97);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(143, 26);
            cbRole.TabIndex = 10;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 267);
            Controls.Add(cbRole);
            Controls.Add(label4);
            Controls.Add(cbStatus);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private TextBox txtUsername;
        private Button btnCancel;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private CheckBox cbStatus;
        private Label label4;
        private ComboBox cbRole;
    }
}