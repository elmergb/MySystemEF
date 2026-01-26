namespace MySystem.Forms
{
    partial class Classess
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
            label6 = new Label();
            panel5 = new Panel();
            txtSearch = new TextBox();
            cbStatus = new ComboBox();
            cbSection = new ComboBox();
            btnAssign = new Button();
            btnExport = new Button();
            btnViewDetails = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            panel4 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            flowLayoutPanelClasses = new FlowLayoutPanel();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 288);
            label6.Name = "label6";
            label6.Size = new Size(879, 52);
            label6.TabIndex = 21;
            label6.Text = "    STUDENT RECORD";
            label6.TextAlign = ContentAlignment.MiddleLeft;
        
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(cbStatus);
            panel5.Controls.Add(cbSection);
            panel5.Controls.Add(btnAssign);
            panel5.Controls.Add(btnExport);
            panel5.Controls.Add(btnViewDetails);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnEdit);
            panel5.Controls.Add(btnAdd);
            panel5.Location = new Point(12, 185);
            panel5.Name = "panel5";
            panel5.Size = new Size(879, 100);
            panel5.TabIndex = 20;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(292, 59);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(241, 27);
            txtSearch.TabIndex = 13;
            // 
            // cbStatus
            // 
            cbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(175, 59);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(98, 23);
            cbStatus.TabIndex = 12;
            // 
            // cbSection
            // 
            cbSection.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(13, 59);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(145, 23);
            cbSection.TabIndex = 11;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(657, 13);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(79, 34);
            btnAssign.TabIndex = 10;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(524, 13);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(113, 34);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export to Excell";
            btnExport.UseVisualStyleBackColor = true;
            // 
            // btnViewDetails
            // 
            btnViewDetails.Location = new Point(408, 13);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(98, 34);
            btnViewDetails.TabIndex = 3;
            btnViewDetails.Text = "View Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(292, 13);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(175, 13);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(98, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add New Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(469, 71);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 92);
            panel4.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 10);
            label5.Name = "label5";
            label5.Size = new Size(116, 18);
            label5.TabIndex = 7;
            label5.Text = "New This Month";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(242, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 92);
            panel3.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 10);
            label4.Name = "label4";
            label4.Size = new Size(119, 18);
            label4.TabIndex = 7;
            label4.Text = "Inactive Students";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 92);
            panel1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 10);
            label3.Name = "label3";
            label3.Size = new Size(109, 18);
            label3.TabIndex = 7;
            label3.Text = "Active Students";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(76, 131, 158);
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Bitstream Vera Sans Mono", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(945, 52);
            label1.TabIndex = 16;
            label1.Text = "     Class Management";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelClasses
            // 
            flowLayoutPanelClasses.AutoScroll = true;
            flowLayoutPanelClasses.Location = new Point(27, 343);
            flowLayoutPanelClasses.Name = "flowLayoutPanelClasses";
            flowLayoutPanelClasses.Padding = new Padding(10);
            flowLayoutPanelClasses.Size = new Size(853, 312);
            flowLayoutPanelClasses.TabIndex = 15;
            // 
            // Classess
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(962, 521);
            Controls.Add(label6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanelClasses);
            Name = "Classess";
            Text = "Classess";
            Load += Classess_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label6;
        private Panel panel5;
        private TextBox txtSearch;
        private ComboBox cbStatus;
        private ComboBox cbSection;
        private Button btnAssign;
        private Button btnExport;
        private Button btnViewDetails;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel4;
        private Label label5;
        private Panel panel3;
        private Label label4;
        private Panel panel1;
        private Label label3;
        private Label label1;
        public FlowLayoutPanel flowLayoutPanelClasses;
    }
}