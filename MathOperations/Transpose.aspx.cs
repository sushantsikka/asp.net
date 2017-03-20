using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DatabaseDiary
{
    public partial class Transpose : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox11.Text = TextBox6.Text;
            TextBox10.Text = TextBox7.Text;
            TextBox9.Text = TextBox5.Text;
            TextBox12.Text = TextBox8.Text;
        }
    }
}