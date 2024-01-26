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
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).BeginInit();
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
            picAvatar.Location = new Point(0, 3);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(378, 280);
            picAvatar.SizeMode = PictureBoxSizeMode.AutoSize;
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
            pnlImage.Location = new Point(29, 115);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(393, 297);
            pnlImage.TabIndex = 4;
            // 
            // dgvStudentList
            // 
            dgvStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentList.Location = new Point(428, 115);
            dgvStudentList.Name = "dgvStudentList";
            dgvStudentList.RowTemplate.Height = 25;
            dgvStudentList.Size = new Size(395, 297);
            dgvStudentList.TabIndex = 5;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(428, 16);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(102, 29);
            btnLoadData.TabIndex = 6;
            btnLoadData.Text = "Load Data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += LoadData;
            // 
            // StudentListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 424);
            Controls.Add(btnLoadData);
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
            pnlImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudentList).EndInit();
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
    }
}