using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    static class DBHelper
    {
        public static SqlConnection GetConnection()
        {
            // create connection
            SqlConnection con =
                    new SqlConnection("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=SMS;Integrated Security=True;");

            return con;
        }
    }
}
