using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            
                Session["pname"] = TextBox1.Text;
                Session["age"] = TextBox2.Text;
                Session["pemail"] = TextBox3.Text;

            int age = Convert.ToInt32(TextBox2.Text);
            if (age > 0)
            {
                Response.Redirect("WebForm2.aspx");
            }
            else
            {
                Response.Write("<script>alert('Enter Valid Age');</script>");
            }
                
            


            
        }
    }
}