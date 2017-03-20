using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Transpose_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal[,] m = new decimal[3, 3];
            int k = 0, j = 0;
            decimal temp = 0;
            m[0, 0] = Convert.ToDecimal(TextBox10.Text);
            m[0, 1] = Convert.ToDecimal(TextBox11.Text);
            m[0, 2] = Convert.ToDecimal(TextBox12.Text);
            m[1, 0] = Convert.ToDecimal(TextBox13.Text);
            m[1, 1] = Convert.ToDecimal(TextBox14.Text);
            m[1, 2] = Convert.ToDecimal(TextBox15.Text);
            m[2, 0] = Convert.ToDecimal(TextBox16.Text);
            m[2, 1] = Convert.ToDecimal(TextBox17.Text);
            m[2, 2] = Convert.ToDecimal(TextBox18.Text);
            for (j = 0; j < 3; j++)
            {
                for (k = 0; k < 3; k++)
                {
                    temp = m[j, k];
                    m[j, k] = m[k, j];
                    m[k, j] = temp;
                }
            }
            TextBox19.Text = Convert.ToString(m[0, 0]);
            TextBox20.Text = Convert.ToString(m[1, 0]);
            TextBox21.Text = Convert.ToString(m[2, 0]);
            TextBox22.Text = Convert.ToString(m[0, 1]);
            TextBox23.Text = Convert.ToString(m[1, 1]);
            TextBox24.Text = Convert.ToString(m[2, 1]);
            TextBox25.Text = Convert.ToString(m[0, 2]);
            TextBox26.Text = Convert.ToString(m[1, 2]);
            TextBox27.Text = Convert.ToString(m[2, 2]);
        }
    }
}