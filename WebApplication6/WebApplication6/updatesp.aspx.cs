using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class updatesp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int a1 = Convert.ToInt32(Request.QueryString["id"]);
                dbconnection db = new dbconnection();
                SqlCommand cmd = new SqlCommand("spIndividualView");
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", a1);
                SqlDataReader dr = db.getresult(cmd);

                if (dr.Read())
                {
                    TextBox1.Text = dr.GetInt32(0).ToString();
                    TextBox2.Text = dr.GetString(2);
                    TextBox3.Text = dr.GetInt32(3).ToString();
                }
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("spUpdate");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@age", Convert.ToInt32(TextBox3.Text));

            dbconnection db = new dbconnection();
            db.execute(cmd);
            Response.Redirect("WebForm3.aspx");
        }
    }
}