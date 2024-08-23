using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class update : System.Web.UI.Page
    {
        string a = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                a = Request.QueryString["Id"];
                dbconnection db = new dbconnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Student where id=@id";
                cmd.Parameters.AddWithValue("@id", a);
                SqlDataReader dr = db.getresult(cmd);
                if (dr.Read())
                {
                    TextBox1.Text = dr.GetInt32(0).ToString();
                    TextBox2.Text = dr.GetString(1);
                    TextBox3.Text = dr.GetInt32(2).ToString();
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            dbconnection db1 = new dbconnection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "update Student set name=@name,id=@id,age=@age where id=@id";

            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", TextBox3.Text);

            db1.execute(cmd);
            Response.Redirect("WebForm3.aspx");
        }
    }
}