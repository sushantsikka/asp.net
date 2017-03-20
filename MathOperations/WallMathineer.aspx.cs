using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DatabaseDiary
{
    public partial class WallMathineer : System.Web.UI.Page
    {
        int i = 1;
        Label abc = new Label();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string connstr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new  MySql.Data.MySqlClient.MySqlConnection(connstr);

            //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString);

            mySqlConnection.Open();
            MySql.Data.MySqlClient.MySqlCommand insert = new MySql.Data.MySqlClient.MySqlCommand("insert into post(post,userid) values('" + post.Text + "','abc'", mySqlConnection);
            
    
            try
            {
                insert.ExecuteNonQuery();
                //mySqlConnection.Close();
          
            }
            catch
            {
               // mySqlConnection.Close();
                Response.Write("Error !");
            }
            post.Text = "";
            string ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("select * from post", con);
                command.Connection = con; 
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                
                MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();

                adapter.SelectCommand = command;
                Label abc = new Label();
           //     reader = command.ExecuteReader();
                reader.Read();
                Label1.Text = reader["post"].ToString();
            
        }
            
        }

    }
