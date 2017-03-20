using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;



namespace DatabaseDiary
{
    public partial class EmailsEnrolled : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!this.IsPostBack)
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
                MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("select * from email", con);
                MySql.Data.MySqlClient.MySqlDataAdapter adapter = new MySql.Data.MySqlClient.MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                GridView1.DataSource = dt; 
                GridView1.DataBind();
            }
        }

       

        

    }
}