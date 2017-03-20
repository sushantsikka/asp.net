using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Multiply_2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal[,] m1= new decimal[,] {{0,0,0},{0,0,0},{0,0,0}};
            int i, j;
            decimal[,] m2 = new decimal[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            m1[0, 0] = Convert.ToDecimal(TextBox1.Text);
            m1[0, 1] = Convert.ToDecimal(TextBox2.Text);
            m1[0, 2] = Convert.ToDecimal(TextBox3.Text);
            m1[1, 0] = Convert.ToDecimal(TextBox4.Text);
            m1[1, 1] = Convert.ToDecimal(TextBox5.Text);
            m1[1, 2] = Convert.ToDecimal(TextBox6.Text);
            m1[2, 0] = Convert.ToDecimal(TextBox7.Text);
            m1[2, 1] = Convert.ToDecimal(TextBox8.Text);
            m1[2, 2] = Convert.ToDecimal(TextBox9.Text);
            m2[0, 0] = Convert.ToDecimal(TextBox10.Text);
            m2[0, 1] = Convert.ToDecimal(TextBox11.Text);
            m2[0, 2] = Convert.ToDecimal(TextBox12.Text);
            m2[1, 0] = Convert.ToDecimal(TextBox13.Text);
            m2[1, 1] = Convert.ToDecimal(TextBox14.Text);
            m2[1, 2] = Convert.ToDecimal(TextBox15.Text);
            m2[2, 0] = Convert.ToDecimal(TextBox16.Text);
            m2[2, 1] = Convert.ToDecimal(TextBox17.Text);
            m2[2, 2] = Convert.ToDecimal(TextBox18.Text);
            decimal[,] res = new decimal[3,3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    res[i, j] = 0;
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        res[i, j] = res[i, j] + (m1[i, k] * m2[k, j]);
                    }
                }
            }

            TextBox19.Text = Convert.ToString(res[0, 0]);
            TextBox20.Text = Convert.ToString(res[0, 1]);
            TextBox21.Text = Convert.ToString(res[0, 2]);
            TextBox22.Text = Convert.ToString(res[1, 0]);
            TextBox23.Text = Convert.ToString(res[1, 1]);
            TextBox24.Text = Convert.ToString(res[1, 2]);
            TextBox25.Text = Convert.ToString(res[2, 0]);
            TextBox26.Text = Convert.ToString(res[2, 1]);
            TextBox27.Text = Convert.ToString(res[2, 2]);

        }
    }
}