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
    public partial class remove_update_sp_ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbconnection db = new dbconnection();
            SqlCommand cmd = new SqlCommand("spView");
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = db.getresult(cmd);
            DataList1.DataSource = dr;
            DataList1.DataBind();
        }
    }
}