using System;
using System.Collections.Generic;
using System.Data;
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
        public DataSet getData(String query)
        {
             SqlConnection con = getConnection();
             SqlCommand cmd = new SqlCommand();
             cmd.Connection = con;
             cmd.CommandText = query;
             SqlDataAdapter da = new SqlDataAdapter(cmd);
             DataSet ds = new DataSet();
             da.Fill(ds);
             return ds;
   
        }
    }
}
