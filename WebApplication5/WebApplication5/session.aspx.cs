using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string name = Session["sname"].ToString();
            //Label1.Text = name;

            Session["sname"] = TextBox1.Text;
            Response.Redirect("session2.aspx");
        }
    }
}