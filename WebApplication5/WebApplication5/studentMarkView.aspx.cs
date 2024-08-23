using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class studentMarkView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string studentname = Request.QueryString["name"];
            Label3.Text += studentname;

            string total = Request.QueryString["total"];
            Label1.Text += total;

            string avg = Request.QueryString["average"];
            Label2.Text += avg;



        }
    }
}