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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // instance of student object
            Student s = new Student(); // Instantiating
            s.StudentId = "156842358";
            string id = s.StudentId;
            s.FullName = "Jane Doe";

            string display = s.GetDisplayText("\n");
            MessageBox.Show(display);

            #region Object Initialization Syntax

            Student s2 = new Student()
            {
                StudentId = "123456789",
                DateOfBirth = new DateTime(1985, 1, 1),
                Email = "someone@student.cptc.edu",
                FullName = "Unknown Name"
            };
            string unknownData = s2.GetDisplayText("\n");
            #endregion
        }
    }
}
