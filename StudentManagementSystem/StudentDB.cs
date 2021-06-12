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
                    new SqlConnection("Data Source =localhost;InitialCatalog=SMS;IntegratedSecurity=True;");
            // communicate with DB.
            con.Open();
            // close connection.
            con.Close();
            throw new NotImplementedException();
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
