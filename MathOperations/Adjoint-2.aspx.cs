using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Adjoint_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal[,] m = new decimal[3, 3];
            int k = 0, j = 0;
            decimal[,] i = new decimal[3, 3] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
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
                    i[j, k] = ((m[(j + 1) % 3, (k + 1) % 3] * m[(j + 2) % 3, (k + 2) % 3]) - (m[(j + 1) % 3, (k + 2) % 3] * m[(j + 2) % 3, (k + 1) % 3]));
                }
            }
            TextBox19.Text = Convert.ToString(i[0, 0]);
            TextBox20.Text = Convert.ToString(i[0, 1]);
            TextBox21.Text = Convert.ToString(i[0, 2]);
            TextBox22.Text = Convert.ToString(i[1, 0]);
            TextBox23.Text = Convert.ToString(i[1, 1]);
            TextBox24.Text = Convert.ToString(i[1, 2]);
            TextBox25.Text = Convert.ToString(i[2, 0]);
            TextBox26.Text = Convert.ToString(i[2, 1]);
            TextBox27.Text = Convert.ToString(i[2, 2]);
        }
    }
}