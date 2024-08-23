using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class session2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["mark1"] = TextBox1.Text;
            Session["mark2"] = TextBox2.Text;
            Session["mark3"] = TextBox3.Text;
            Response.Redirect("session3.aspx");
        }
    }
}