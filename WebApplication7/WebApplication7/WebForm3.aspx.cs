using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["pname"].ToString();
            Label1.Text = "Person Name : " + name;

            int age = Convert.ToInt32(Session["age"]);
            Label2.Text = "Person Age : " + age.ToString();

            string email = Session["pemail"].ToString();
            Label3.Text = "Person Name : " + email;

            string degree = Session["degree"].ToString();
            Label4.Text = "Person Name : " + degree;

            if (age < 23 && degree == "pg")
            {
                Label5.Text = "You are Shortlisted";
            }
            else
            {
                Label5.Text = "You are not Shortlisted";
            }
        }
    }
}