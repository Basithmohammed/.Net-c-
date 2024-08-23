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
    public partial class removesp : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(Request.QueryString["id"]);

            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand("spDelete");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", a1);
            db.execute(cmd);

            Response.Redirect("WebForm3.aspx");

        }
    }
}