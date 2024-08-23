using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Input = txtInput.Text;
            DropDownList1.Items.Add(Input);
            txtInput.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string val = DropDownList1.SelectedValue;
            // string val1 = DropDownList1.SelectedItem.Text;
            TextBox1.Text = val;

        }
    }
}