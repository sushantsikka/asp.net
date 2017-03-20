using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Adjoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal temp;
            TextBox12.Text = TextBox5.Text;
            TextBox9.Text = TextBox8.Text;
            temp = Convert.ToDecimal(TextBox6.Text);
            temp = temp * (-1);
            TextBox10.Text = Convert.ToString(temp);
            temp = Convert.ToDecimal(TextBox7.Text);
            temp = temp * (-1);
            TextBox11.Text = Convert.ToString(temp);
        }
    }
}