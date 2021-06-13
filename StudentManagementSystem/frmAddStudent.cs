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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void CmdAddStudent_Click(object sender, EventArgs e)
        {
            // Validate input

            // Create Student object
            Student s = new Student();
            s.StudentId = txtStudentId.Text;
            s.FullName = txtFullName.Text;
            s.Email = txtFullName.Text;
            s.DateOfBirth = dtpDateOfBirth.Value;

            // Add to database
            StudentDB.Add(s);

            // Close form
            Close();
        }
    }
}
