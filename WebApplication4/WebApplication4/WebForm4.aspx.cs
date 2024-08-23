using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListItem item = DropDownList1.SelectedItem;
            DropDownList2.Items.Add(new ListItem(item.Text, item.Value));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach(ListItem val in DropDownList1.Items)
            {
                DropDownList3.Items.Add(val);
            }
        }
    }
}