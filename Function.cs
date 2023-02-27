using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = (LocalDB)\\MSSQLLocalDB;database = quiz; integrated security = true";
            return con;
        }

    }
}
