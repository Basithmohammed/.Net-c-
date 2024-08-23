using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            dbconnection db1 = new dbconnection();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insert into Student values(@id,@name,@age)";


            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@name",TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(TextBox3.Text));


            db1.execute(cmd);
            Response.Redirect("");

        }
    }
}