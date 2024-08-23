using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class session4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["sname"].ToString();
            Label1.Text = "Student Name : "+name;

            int mark1 = Convert.ToInt32(Session["mark1"]);
            Label2.Text = "Subject 1 Score : "+mark1.ToString();

            int  mark2 = Convert.ToInt32(Session["mark2"]);
            Label3.Text = "Subject 2 Score : " + mark2.ToString();

            int mark3 = Convert.ToInt32(Session["mark3"]);
            Label4.Text = "Subject 3 Score : " + mark3.ToString();


           int internal1 = Convert.ToInt32(Session["internal"]);
            Label5.Text = "Total Internal Mark : " + internal1.ToString();

            int t = (mark1 + mark2 + mark3 + internal1);
            Label6.Text = "Total Score : " + t.ToString();
        }
    }
}