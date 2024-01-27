namespace StudentManagement
{
    partial class StudentListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btnExit = new Button();
            dlgOF = new OpenFileDialog();
            btnImage = new Button();
            picAvatar = new PictureBox();
            lblFileName = new Label();
            pnlImage = new Panel();
            dgvStudentList = new DataGridView();
            btnLoadData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtYob = new TextBox();
            txtGpa = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            btnAddNew = new Button();
            btnSearch = new Button();
            dgvSearchResult = new DataGridView();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 12);
            button1.Name = "button1";
            button1.Size = new Size(93, 36);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SayHello;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(151, 12);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 36);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += SayGoodbye;
            // 
            // dlgOF
            // 
            dlgOF.Filter = "JPEG files|*.jpeg|PNG files|*.png|All files|*.*";
            // 
            // btnImage
            // 
            btnImage.Location = new Point(29, 75);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(114, 32);
            btnImage.TabIndex = 1;
            btnImage.Text = "Choose Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += OpenImage;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.Fixed3D;
            picAvatar.Location = new Point(0, 11);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(297, 229);
            picAvatar.TabIndex = 2;
            picAvatar.TabStop = false;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(159, 84);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(59, 15);
            lblFileName.TabIndex = 3;
            lblFileName.Text = "File Name";
            // 
            // pnlImage
            // 
            pnlImage.AutoScroll = true;
            pnlImage.Controls.Add(picAvatar);
            pnlImage.Location = new Point(29, 113);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(300, 243);
            pnlImage.TabIndex = 4;
            // 
            // dgvStudentList
            // 
            dgvStudentList.AllowUserToResizeColumns = false;
            dgvStudentList.AllowUserToResizeRows = false;
            dgvStudentList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.EnableHeadersVisualStyles = false;
            dgvStudentList.Location = new Point(348, 175);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowTemplate.Height = 25;
            dgvStudentList.Size = new Size(399, 240);
            dgvStudentList.TabIndex = 5;
            dgvStudentList.SelectionChanged += ShowAStudent;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(422, 15);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(109, 29);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 56);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 90);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 28);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 7;
            label4.Text = "Yob";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(216, 53);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 7;
            label5.Text = "Gpa";
            // 
            // txtID
            // 
            txtID.Location = new Point(74, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(74, 82);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtYob
            // 
            txtYob.Location = new Point(278, 22);
            txtYob.Name = "txtYob";
            txtYob.Size = new Size(100, 23);
            txtYob.TabIndex = 8;
            // 
            // txtGpa
            // 
            txtGpa.Location = new Point(278, 48);
            txtGpa.Name = "txtGpa";
            txtGpa.Size = new Size(100, 23);
            txtGpa.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(txtGpa);
            groupBox1.Controls.Add(txtYob);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(348, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 118);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student Info";
            // 
            // button2
            // 
            button2.Location = new Point(422, 15);
            button2.Name = "button2";
            button2.Size = new Size(109, 29);
            button2.TabIndex = 6;
            button2.Text = "Load Data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += LoadData;
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(562, 15);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(109, 29);
            btnAddNew.TabIndex = 6;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += AddNewStudent;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(764, 132);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 29);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += SearchStudents;
            // 
            // dgvSearchResult
            // 
            dgvSearchResult.AllowUserToResizeColumns = false;
            dgvSearchResult.AllowUserToResizeRows = false;
            dgvSearchResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvSearchResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSearchResult.EnableHeadersVisualStyles = false;
            dgvSearchResult.Location = new Point(753, 175);
            dgvSearchResult.Name = "dgvSearchResult";
            dgvSearchResult.RowTemplate.Height = 25;
            dgvSearchResult.Size = new Size(377, 240);
            dgvSearchResult.TabIndex = 5;
            dgvSearchResult.SelectionChanged += ShowAStudent;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(898, 135);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(143, 23);
            txtSearch.TabIndex = 8;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 424);
            Controls.Add(groupBox1);
            Controls.Add(btnSearch);
            Controls.Add(btnAddNew);
            Controls.Add(button2);
            Controls.Add(txtSearch);
            Controls.Add(btnLoadData);
            Controls.Add(dgvSearchResult);
            Controls.Add(dgvStudentList);
            Controls.Add(pnlImage);
            Controls.Add(lblFileName);
            Controls.Add(btnImage);
            Controls.Add(btnExit);
            Controls.Add(button1);
            Name = "StudentListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student List";
            Click += SayGoodBye;
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSearchResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button btnExit;
        private OpenFileDialog dlgOF;
        private Button btnImage;
        private PictureBox picAvatar;
        private Label lblFileName;
        private Panel pnlImage;
        private DataGridView dgvStudentList;
        private Button btnLoadData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtYob;
        private TextBox txtGpa;
        private GroupBox groupBox1;
        private Button button2;
        private Button btnAddNew;
        private Button btnSearch;
        private DataGridView dgvSearchResult;
        private TextBox txtSearch;
    }
}