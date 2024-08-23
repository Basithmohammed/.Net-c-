using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Remove(DropDownList1.SelectedItem);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DropDownList1.Items.Clear();

            //for (int i = DropDownList1.Items.Count - 1; i >= 0; i++)
            //{
              //  DropDownList1.Items.RemoveAt(i);
            //}
        }
    }
}