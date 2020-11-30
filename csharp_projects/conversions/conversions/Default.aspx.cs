using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace conversions
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //int i;
            //i = Convert.ToInt32("Hello World");


            //double k = 3.5;
            //int i = (int)k;
            //resultLabel.Text = i.ToString();


            string i = inputTextBox.Text;
            int j = int.Parse(i);
            int k = j + 1;
            resultLabel.Text = k.ToString();


        }
    }
}