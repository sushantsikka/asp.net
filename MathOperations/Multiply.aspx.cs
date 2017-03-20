using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Multiply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal a, b, c, d, res;
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox2.Text);
            c = Convert.ToDecimal(TextBox5.Text);
            d = Convert.ToDecimal(TextBox7.Text);
            res = (a * c) + (b * d);
            TextBox9.Text = Convert.ToString(res);
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox2.Text);
            c = Convert.ToDecimal(TextBox6.Text);
            d = Convert.ToDecimal(TextBox8.Text);
            res = (a * c) + (b * d);
            TextBox10.Text = Convert.ToString(res);
            a = Convert.ToDecimal(TextBox3.Text);
            b = Convert.ToDecimal(TextBox4.Text);
            c = Convert.ToDecimal(TextBox5.Text);
            d = Convert.ToDecimal(TextBox7.Text);
            res = (a * c) + (b * d);
            TextBox11.Text = Convert.ToString(res);
            a = Convert.ToDecimal(TextBox3.Text);
            b = Convert.ToDecimal(TextBox4.Text);
            c = Convert.ToDecimal(TextBox6.Text);
            d = Convert.ToDecimal(TextBox8.Text);
            res = (a * c) + (b * d);
            TextBox12.Text = Convert.ToString(res);
        }
    }
}