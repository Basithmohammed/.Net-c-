using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class spInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("spInsert");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(TextBox3.Text));


            dbconnection db = new dbconnection();
            db.execute(cmd);
            Response.Redirect("WebForm3.aspx");


        }
    }
}