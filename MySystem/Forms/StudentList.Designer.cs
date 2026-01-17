namespace MySystem.Forms
{
    partial class StudentList
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
            panel1 = new Panel();
            label2 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            txtSearch = new TextBox();
            cbStatus = new ComboBox();
            cbSection = new ComboBox();
            btnPrint = new Button();
            btnExport = new Button();
            btnViewDetails = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dgvStudents = new DataGridView();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(1, -5);
            label1.Name = "label1";
            label1.Size = new Size(1191, 52);
            label1.TabIndex = 1;
            label1.Text = "    STUDENT LIST";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(18, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(191, 92);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(103, 18);
            label2.TabIndex = 6;
            label2.Text = "Total Students";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(249, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 92);
            panel2.TabIndex = 3;
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
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Location = new Point(479, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(191, 92);
            panel3.TabIndex = 4;
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
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Location = new Point(706, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(191, 92);
            panel4.TabIndex = 5;
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
            label5.Click += label5_Click;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(txtSearch);
            panel5.Controls.Add(cbStatus);
            panel5.Controls.Add(cbSection);
            panel5.Controls.Add(btnPrint);
            panel5.Controls.Add(btnExport);
            panel5.Controls.Add(btnViewDetails);
            panel5.Controls.Add(btnDelete);
            panel5.Controls.Add(btnEdit);
            panel5.Controls.Add(btnAdd);
            panel5.Location = new Point(18, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(879, 100);
            panel5.TabIndex = 7;
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
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(175, 59);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(98, 23);
            cbStatus.TabIndex = 12;
            // 
            // cbSection
            // 
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(13, 59);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(145, 23);
            cbSection.TabIndex = 11;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(657, 13);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(79, 34);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
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
            btnEdit.Click += btnEdit_Click;
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
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(18, 365);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(879, 293);
            dgvStudents.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 311);
            label6.Name = "label6";
            label6.Size = new Size(879, 52);
            label6.TabIndex = 9;
            label6.Text = "    STUDENT RECORD";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(958, 712);
            Controls.Add(label6);
            Controls.Add(dgvStudents);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "StudentList";
            Text = "StudentList";
            Load += StudentList_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel5;
        private DataGridView dgvStudents;
        private Button btnAdd;
        private TextBox txtSearch;
        private ComboBox cbStatus;
        private ComboBox cbSection;
        private Button btnPrint;
        private Button btnExport;
        private Button btnViewDetails;
        private Button btnDelete;
        private Button btnEdit;
        private Label label6;
    }
}