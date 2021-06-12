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
    public partial class frmStudentMgmtSystem : Form
    {
        public frmStudentMgmtSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region NOTES
            //// instance of student object
            //Student s = new Student(); // Instantiating
            //s.StudentId = "156842358";
            //string id = s.StudentId;
            //s.FullName = "Jane Doe";

            //string display = s.GetDisplayText("\n");
            //MessageBox.Show(display);

            //#region Object Initialization Syntax

            //Student s2 = new Student()
            //{
            //    StudentId = "123456789",
            //    DateOfBirth = new DateTime(1985, 1, 1),
            //    Email = "someone@student.cptc.edu",
            //    FullName = "Unknown Name"
            //};
            //string unknownData = s2.GetDisplayText("\n");
            #endregion

            // load all students from the database.
            List<Student> allStudents = StudentDB.GetAllStudents();
            // Populate them in the list box.
            PopulateStudentList(allStudents);
        }
        #region Method To Populate Student List
        /// <summary>
        /// Populates list of Students from the database.
        /// </summary>
        /// <param name="students"></param>
        private void PopulateStudentList(List<Student> students)
        {
            // loop and add all the students into the list box
            foreach (Student s in students)
            {
                lstStudents.Items.Add(s);
            }
        }
        #endregion

        private void cmdAddStudent_Click(object sender, EventArgs e)
        {
            // TODO: Create a form to add a student to the database
            // After student is added place them into the list box
        }

        private void cmdUpdateStudent_Click(object sender, EventArgs e)
        {
            // Ensure user has selected a student in the listbox.
            // Open a form with the students data populated.
            // Once student is updated refresh listbox.
        }

        private void cmdDeleteStudent_Click(object sender, EventArgs e)
        {
            // Ensure user has selected a student in the listbox.
            // Ask user if the want to delete the current student
            // if yes: remove them from database and listbox.
        }
    }
}
