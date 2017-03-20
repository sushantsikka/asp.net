using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal a = 0, b = 0, c = 0;
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox5.Text);
            c = a + b;
            TextBox9.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox2.Text);
            b = Convert.ToDecimal(TextBox6.Text);
            c = a + b;
            TextBox10.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox3.Text);
            b = Convert.ToDecimal(TextBox7.Text);
            c = a + b;
            TextBox11.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox4.Text);
            b = Convert.ToDecimal(TextBox8.Text);
            c = a + b;
            TextBox12.Text = Convert.ToString(c); 
        }

    }
}