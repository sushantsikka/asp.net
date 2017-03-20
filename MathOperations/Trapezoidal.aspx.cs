using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Trapezoidal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public decimal Func(decimal v)
        {
            decimal A, B, C, D, E;
            A = Convert.ToDecimal(TextBox1.Text);
            B = Convert.ToDecimal(TextBox2.Text);
            C = Convert.ToDecimal(TextBox3.Text);
            D = Convert.ToDecimal(TextBox4.Text);
            E = Convert.ToDecimal(TextBox5.Text);
            return (A * (v * v * v * v)) + (B * (v * v * v)) + (C * (v * v)) + (D * v) + E;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal A, B, C, D, E, m1 = 0,m2 = 0,n = 0,div = 0,sum = 0;
            A = Convert.ToDecimal(TextBox1.Text);
            B = Convert.ToDecimal(TextBox2.Text);
            C = Convert.ToDecimal(TextBox3.Text);
            D = Convert.ToDecimal(TextBox4.Text);
            E = Convert.ToDecimal(TextBox5.Text);
            m1 = Convert.ToDecimal(TextBox6.Text);
            m2 = Convert.ToDecimal(TextBox7.Text);
            n = Convert.ToDecimal(TextBox9.Text);
            div = (m2 - m1) / n;
            sum+=Func(m1)+Func(m2);
            for(decimal x=m1+div;x<m2-div;x=x+div)
            {
                sum += (2 * Func(x));
            }
            sum *= (div / 2);
            TextBox8.Text = Convert.ToString(sum);
        }
    }
}