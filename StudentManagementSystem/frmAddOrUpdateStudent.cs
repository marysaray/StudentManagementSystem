using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmAddOrUpdateStudent : Form
    {
        public frmAddOrUpdateStudent()
        {
            InitializeComponent();
        }
        // field
        Student existingStu;

        /// <summary>
        /// Auto populates the Add or Update 
        /// student form with student object
        /// </summary>
        /// <param name="s"></param>
        public frmAddOrUpdateStudent(Student s)
        {
            InitializeComponent();
            txtStudentId.Text = s.StudentId;
            txtFullName.Text = s.FullName;
            txtEmail.Text = s.Email;
            dtpDateOfBirth.Value = s.DateOfBirth;

            cmdAddStudent.Text = "Update Student"; // changes text on the Add or Update form
            Text = "Update " + s.FullName;
            txtStudentId.Enabled = false;
            existingStu = s;
        }

        private void CmdAddStudent_Click(object sender, EventArgs e)
        {
            // Validate input
            if (existingStu == null) // Adding a new Student
            {
                // Create Student object
                Student s = new Student();
                s.StudentId = txtStudentId.Text;
                s.FullName = txtFullName.Text;
                s.Email = txtFullName.Text;
                s.DateOfBirth = dtpDateOfBirth.Value;

                // Add to database
                StudentDB.Add(s);
            }
            else // Updating an existing student
            {
                existingStu.FullName = txtFullName.Text;
                existingStu.Email = txtEmail.Text;
                existingStu.DateOfBirth = dtpDateOfBirth.Value;

                StudentDB.Update(existingStu);
            }
            // Close form
            Close();
        }
    }
}
