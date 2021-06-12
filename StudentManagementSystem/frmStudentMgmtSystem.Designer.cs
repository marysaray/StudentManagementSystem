
namespace StudentManagementSystem
{
    partial class frmStudentMgmtSystem
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
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.cmdAddStudent = new System.Windows.Forms.Button();
            this.cmdUpdateStudent = new System.Windows.Forms.Button();
            this.cmdDeleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 25;
            this.lstStudents.Location = new System.Drawing.Point(0, 0);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(273, 454);
            this.lstStudents.TabIndex = 0;
            // 
            // cmdAddStudent
            // 
            this.cmdAddStudent.Location = new System.Drawing.Point(351, 12);
            this.cmdAddStudent.Name = "cmdAddStudent";
            this.cmdAddStudent.Size = new System.Drawing.Size(150, 102);
            this.cmdAddStudent.TabIndex = 1;
            this.cmdAddStudent.Text = "Add Student";
            this.cmdAddStudent.UseVisualStyleBackColor = true;
            this.cmdAddStudent.Click += new System.EventHandler(this.cmdAddStudent_Click);
            // 
            // cmdUpdateStudent
            // 
            this.cmdUpdateStudent.Location = new System.Drawing.Point(351, 176);
            this.cmdUpdateStudent.Name = "cmdUpdateStudent";
            this.cmdUpdateStudent.Size = new System.Drawing.Size(150, 98);
            this.cmdUpdateStudent.TabIndex = 2;
            this.cmdUpdateStudent.Text = "Update Student";
            this.cmdUpdateStudent.UseVisualStyleBackColor = true;
            this.cmdUpdateStudent.Click += new System.EventHandler(this.cmdUpdateStudent_Click);
            // 
            // cmdDeleteStudent
            // 
            this.cmdDeleteStudent.Location = new System.Drawing.Point(351, 333);
            this.cmdDeleteStudent.Name = "cmdDeleteStudent";
            this.cmdDeleteStudent.Size = new System.Drawing.Size(141, 96);
            this.cmdDeleteStudent.TabIndex = 3;
            this.cmdDeleteStudent.Text = "Delete Student";
            this.cmdDeleteStudent.UseVisualStyleBackColor = true;
            this.cmdDeleteStudent.Click += new System.EventHandler(this.cmdDeleteStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdDeleteStudent);
            this.Controls.Add(this.cmdUpdateStudent);
            this.Controls.Add(this.cmdAddStudent);
            this.Controls.Add(this.lstStudents);
            this.Name = "Form1";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Button cmdAddStudent;
        private System.Windows.Forms.Button cmdUpdateStudent;
        private System.Windows.Forms.Button cmdDeleteStudent;
    }
}

