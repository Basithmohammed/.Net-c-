using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class remove : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string a1 = Request.QueryString["id"];

            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "delete from Student where id=@id";

            cmd.Parameters.AddWithValue("@id", a1);

            db.execute(cmd);
            Response.Redirect("WebForm3.aspx");
        }
    }
}