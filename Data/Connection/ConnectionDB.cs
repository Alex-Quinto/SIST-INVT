using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIST_INVT.Data.Connection
{
    public class ConnectionDB
    {
        private static readonly string connectionString
              //= "Server=localhost\\SQLEXPRESS;Database=BD_INVENT;Trusted_Connection=True;";
              = "Server=localhost;Database=BD_INVENT;Integrated Security=True;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
