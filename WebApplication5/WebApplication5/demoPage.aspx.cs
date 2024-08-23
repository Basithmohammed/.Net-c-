using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class demoPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = Request.QueryString["name"];
            //Label1.Text += username;


            //session

            string name = Session["uname"].ToString();
            Label1.Text = name;


            string password = Request.QueryString["pass"];
            Label2.Text += password;
        }
    }
}