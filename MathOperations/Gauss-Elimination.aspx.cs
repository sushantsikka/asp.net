using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Gauss_Elimination : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal[,] m=new decimal[3,4];
            decimal[] d = new decimal[3] {0,0,0};
            int i, j, k;
            decimal c = 0;
            m[0, 0] = Convert.ToDecimal(TextBox6.Text);
            m[0, 1] = Convert.ToDecimal(TextBox7.Text);
            m[0, 2] = Convert.ToDecimal(TextBox8.Text);
            m[1, 0] = Convert.ToDecimal(TextBox9.Text);
            m[1, 1] = Convert.ToDecimal(TextBox10.Text);
            m[1, 2] = Convert.ToDecimal(TextBox11.Text);
            m[2, 0] = Convert.ToDecimal(TextBox12.Text);
            m[2, 1] = Convert.ToDecimal(TextBox13.Text);
            m[2, 2] = Convert.ToDecimal(TextBox14.Text);
            m[0, 3] = Convert.ToDecimal(TextBox15.Text);
            m[1, 3] = Convert.ToDecimal(TextBox16.Text);
            m[2, 3] = Convert.ToDecimal(TextBox17.Text);
            for (i = 2; i > 0; i--)        // partial pivoting
            {
                if (m[i - 1, 0] < m[i, 0])
                    for (j = 0; j <= 3; j++)
                    {
                        c = m[i, j];
                        m[i, j] = m[i - 1, j];
                        m[i - 1, j] = c;
                    }
            }
            for (k = 0; k < 2; k++)
                for (i = k; i < 2; i++)
                {
                    c = (m[i + 1, k] / m[k, k]);

                    for (j = 0; j <= 3; j++)
                        m[i + 1, j] -= c * m[k, j];
                }
            for (i = 2; i >= 0; i--)
            {
                c = 0;
                for (j = i; j <= 2; j++)
                    c = c + m[i, j] * d[j];

                d[i] = (m[i, 3] - c) / m[i, i];
                TextBox18.Text = Convert.ToString(d[0]);
                TextBox19.Text = Convert.ToString(d[1]);
                TextBox20.Text = Convert.ToString(d[2]);
            }
        }
    }
}