using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class studentMark : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sname = TextBox1.Text;
            int mark1 = Convert.ToInt32(TextBox2.Text);
            int mark2 = Convert.ToInt32(TextBox3.Text);
            int mark3 = Convert.ToInt32(TextBox4.Text);

            int total = mark1 + mark2 + mark3;
            int average = total / 3;

            Response.Redirect("studentMarkView.aspx?name=" + sname + "&total=" + total + "&average=" + average);

        }
    }
}