using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Inverse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal temp, det = 0;
            Label1.Visible = false;
           det = (Convert.ToDecimal(TextBox5.Text) * Convert.ToDecimal(TextBox8.Text)) - (Convert.ToDecimal(TextBox6.Text) * Convert.ToDecimal(TextBox7.Text));
            if (det == 0)
            {
                Label1.Visible = true;
            }
            else
            {
                temp = Convert.ToDecimal(TextBox5.Text);
                temp = temp / det;
                TextBox12.Text =Convert.ToString(temp);
                temp = Convert.ToDecimal(TextBox8.Text);
                temp = temp / det;
                TextBox9.Text = Convert.ToString(temp);
                temp = Convert.ToDecimal(TextBox6.Text);
                temp = (temp * (-1))/det;
                TextBox10.Text = Convert.ToString(temp);
                temp = Convert.ToDecimal(TextBox7.Text);
                temp = (temp * (-1))/det;
                TextBox11.Text = Convert.ToString(temp);
            }
        }
    }
}