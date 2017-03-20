using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Add_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal a = 0, b = 0, c = 0;
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox10.Text);
            c = a + b;
            TextBox19.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox2.Text);
            b = Convert.ToDecimal(TextBox11.Text);
            c = a + b;
            TextBox20.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox3.Text);
            b = Convert.ToDecimal(TextBox12.Text);
            c = a + b;
            TextBox21.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox4.Text);
            b = Convert.ToDecimal(TextBox13.Text);
            c = a + b;
            TextBox22.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox5.Text);
            b = Convert.ToDecimal(TextBox14.Text);
            c = a + b;
            TextBox23.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox6.Text);
            b = Convert.ToDecimal(TextBox15.Text);
            c = a + b;
            TextBox24.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox7.Text);
            b = Convert.ToDecimal(TextBox16.Text);
            c = a + b;
            TextBox25.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox8.Text);
            b = Convert.ToDecimal(TextBox17.Text);
            c = a + b;
            TextBox26.Text = Convert.ToString(c);
            a = Convert.ToDecimal(TextBox9.Text);
            b = Convert.ToDecimal(TextBox18.Text);
            c = a + b;
            TextBox27.Text = Convert.ToString(c);
        }

        
    }
}