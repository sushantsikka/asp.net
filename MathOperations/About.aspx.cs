using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.Sql;
namespace DatabaseDiary
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connstr);

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);

            mySqlConnection.Open();
            MySql.Data.MySqlClient.MySqlCommand insert = new MySql.Data.MySqlClient.MySqlCommand("insert into comm values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "')", mySqlConnection);


            try
            {
                insert.ExecuteNonQuery();
                mySqlConnection.Close();
                Label1.Visible = true;

            }
            catch
            {
                mySqlConnection.Close();
                Response.Write("Error !");
            }
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

       

    }
}
