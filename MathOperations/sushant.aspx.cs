using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Web.UI.WebControls;
namespace generate_page_runtime {
    public partial class sushant : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            output.Text = "sknkd";
Image1.ImageUrl =" ";
string connstr = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new  MySql.Data.MySqlClient.MySqlConnection(connstr);
string a="+TextBox1.Text.Trim()+";
string b=@"sushant"+".aspx"
string comm="INSERT into page(title,link) VALUES (@"sushant",b);
MySql.Data.MySqlClient.MySqlCommand insert = new MySql.Data.MySqlClient.MySqlCommand(comm, mySqlConnection);
insert.Connection.Open();
insert.ExecuteNonQuery();
mySqlConnection.Close();
        }
    }
}
