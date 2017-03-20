using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Bisection : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public decimal func(decimal v)
        {
            decimal a, b, c, d;
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox2.Text);
            c = Convert.ToDecimal(TextBox3.Text);
            d = Convert.ToDecimal(TextBox4.Text);
            return (a*(v*v*v)) + (b*(v*v)) + (c*v) + d;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal a, b, c, d, x0 = 0, x1 = 0, x2 = 0, f0 = 0, f1 = 0, f2 = 0;
            int n;
            a = Convert.ToDecimal(TextBox1.Text);
            b = Convert.ToDecimal(TextBox2.Text);
            c = Convert.ToDecimal(TextBox3.Text);
            d = Convert.ToDecimal(TextBox4.Text);
            n = Convert.ToInt16(TextBox7.Text);
            x0 = Convert.ToDecimal(TextBox5.Text);
            x1 = Convert.ToDecimal(TextBox6.Text);
            if(n<=0)
            {

            }
            if(n>0 && x1>x0)
            {
                for(int j = 0;j<n;j++)
                {
                    x2 = (x1 + x0) / 2;
                    f0 = func(x0);
                    f1 = func(x1);
                    f2 = func(x2);
                    if(f0 * f2 < 0)
                    {
                        x1 = x2;
                    }
                    if(f1 * f2 < 0)
                    {
                        x0 = x2;
                    }
                }
            }
            TextBox8.Text = Convert.ToString(x2);
            
        }
    }
}