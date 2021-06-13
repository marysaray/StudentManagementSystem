using System;
using System.Collections.Generic;
using System.Data.SqlClient; // DB
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class StudentDB
    {
        /// <summary>
        /// Retrieve
        /// </summary>
        /// <returns></returns>
        public static List<Student> GetAllStudents()
        {
            // create connection
            SqlConnection con = 
                    new SqlConnection("Data Source =localhost;Initial Catalog=SMS;Integrated Security=True;");

            // create new instance of class SqlCommand
            SqlCommand cmd = new SqlCommand();

            // Query Statement
            cmd.CommandText = "SELECT Id " +
                              ",FullName " +
                              ",Email " +
                              ",DOB " +
                              "FROM Students ";

            // connect to DB
            cmd.Connection = con;

            // communicate with DB.
            con.Open();

            // sends query through connections and return sql data
            // store in a variable 
            SqlDataReader rdr = cmd.ExecuteReader();

            // create List of Students object.
            List<Student> studentList = new List<Student>(); 

            // while loop to get all rows
            while (rdr.Read())
            {
                // each row will be one new student.
                // loading data to memory.
                Student temp = new Student
                {
                    // read each data from column name
                    // convert for correct data type
                    StudentId = Convert.ToString(rdr["Id"]),
                    FullName = Convert.ToString(rdr["FullName"]),
                    Email = Convert.ToString(rdr["Email"]),
                    DateOfBirth = Convert.ToDateTime(rdr["DOB"])
                };
                // add to List of Students object
                studentList.Add(temp);
            }
            // close connection.
            con.Close();
            // return List of students
            return studentList;
        }
        /// <summary>
        /// Add
        /// </summary>
        /// <param name="s"></param>
        public static void Add(Student s)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Update
        /// </summary>
        /// <param name="s"></param>
        public static void Update(Student s)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="s"></param>
        public static void Delete(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
