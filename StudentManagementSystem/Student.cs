using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    /// <summary>
    /// Represents an Individual CPTC Student.
    /// </summary>
    class Student
    {
        #region Fields
        // this is data is available for every object instance.
        // commented out because it is unused.
        // public string endOfStudentEmail = "@student.cptc.edu";
        #endregion
        #region Constructors
        public Student(string studentId)
        {
            StudentId = studentId;
        }
        public Student(string studentId, string fullName)
        {
            StudentId = studentId;
            FullName = fullName;
        }
        #endregion
        #region Properties

        // Id, Name, Date of birth, email
        // Properties
        /// <summary>
        /// The 9 digit Student Identification number.
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// The full legal name of the student.
        /// First and Last name.
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Student's email.
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Student's Date of birth.
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Gets a string representation of current student instance.
        /// </summary>
        /// <param name="separator">
        /// A string to separate each piece of information
        /// </param>  
        /// <returns></returns>
        public string GetDisplayText(string separator)
        {
            return $"{StudentId}{separator}{FullName}{separator}" +
                $"{Email}{separator}{DateOfBirth}";
        }
        /// <summary>
        /// Register a student for a specific course.
        /// </summary>
        /// <param name="courseCode">
        /// Code for the course to register for.
        /// </param> 
        public void Register(string courseCode)
        {
            throw new NotImplementedException(); // method stub
        }
        #endregion
    }
}
