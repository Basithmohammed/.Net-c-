using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string val = DropDownList1.SelectedValue;
            TextBox1.Text = val;

            Panel2.Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(TextBox1.Text);
            int count = Convert.ToInt32(TextBox2.Text);


            TextBox3.Text = (value*count).ToString();

            Panel3.Visible = true;

        }
    }
}