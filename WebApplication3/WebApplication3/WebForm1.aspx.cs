using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int mark1 = Convert.ToInt32(txtMark1.Text);
            int mark2 = Convert.ToInt32(txtMark2.Text);
            int mark3 = Convert.ToInt32(txtMark3.Text);
            int mark4 = Convert.ToInt32(txtMark4.Text);

            int sum = mark1 + mark2 + mark3 + mark4;

            int avg = sum / 4;

            txtSum.Text = sum.ToString();
            txtAvg.Text = avg.ToString();

            Panel1.Visible = true;
        }
    }
}