using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            string operation = Convert.ToString(txtOperation.Text);


            switch (operation) {
			    case "+":
			        double value = num1 + num2;
                    txtOut.Text = value.ToString();
                    break;

                case "-":
                    double value1 = num1 - num2;
                    txtOut.Text = value1.ToString();
                    break;

                case "*":
                    double value2 = num1 + num2;
                    txtOut.Text = value2.ToString();
                    break;

                case "/":
                    double value3 = num1 / num2;
                    txtOut.Text = value3.ToString();
                    break;

            }
        }
    }
}