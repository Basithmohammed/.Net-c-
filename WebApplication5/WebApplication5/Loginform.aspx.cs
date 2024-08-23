using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class Loginform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //string uname = TextBox1.Text;
            string pass = TextBox2.Text;

            //Session

            Session["uname"] = TextBox1.Text;


            if (pass == "1234")
            {
                Response.Redirect("demoPage.aspx");
                //Response.Redirect("demoPage.aspx?name="+uname+"&pass="+pass);
            }
            else
            {
                Response.Write("<script>alert('Please enter valid password')</script>");
            }
            
        }
    }
}