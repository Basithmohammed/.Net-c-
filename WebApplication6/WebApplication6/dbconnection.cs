using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication6
{
    public class dbconnection
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\users\412885\source\repos\WebApplication6\WebApplication6\App_Data\Database1.mdf;Integrated Security=True");

        public void execute(SqlCommand cmd)
        {
            cmd.Connection = cn;
            if(cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public SqlDataReader getresult(SqlCommand cmd)
        {
            cmd.Connection = cn;
            if (cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            cn.Close();
        }
    }
}