using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
namespace DatabaseDiary
{
    public partial class Add_Page : System.Web.UI.Page
    {

        public string[] Conv(string a)
        {
            return new [] { a };
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            string[] aspxLines = {"<%@ Page Language=\"C#\" AutoEventWireup=\"true\"CodeFile=\""+TextBox1.Text.Trim()+".aspx.cs\" Inherits=\"generate_page_runtime."+TextBox1.Text.Trim()+"\" %>",
"<!DOCTYPE html>",
"<head>",
"<title>Mathineer</title>",
"</head>",
"<style type=\"text/css\"> ",
"body",   
"{",
   " background: #6BBCF2;",
   " font-size: .80em;",
   " font-family: \"Helvetica Neue\",\"Lucida Grande\", \"Segoe UI\", Arial, Helvetica, Verdana, sans-serif;",
    "margin: 0px;",
    "padding: 0px;",
    "color: #696969;",
"}",
"div.hideSkiplink",
"{",
   " background-color:#3a4f63;",
    "width:100%;",
"}",

"div.menu",
"{",
  "  padding: 4px 0px 4px 8px;",
"}",

"div.menu ul",
"{",
 "   list-style: none;",
   " margin: 0px;",
    "padding: 0px;",
   " width: auto;",
"}",

"div.menu ul li a, div.menu ul li a:visited",
"{",
  "  background-color: #4b6c9e;",
  "  border: 1px #4e667d solid;",
   " color: #dde4ec;",
   "display: block; ",
    "line-height: 1.35em;",
    "padding: 4px 14px;",
    "text-decoration: none;",
    "white-space: nowrap;",

"}",

"div.menu ul li a:hover",

"{",
  "  background-color: #bfcbd6;",
    "color: #465c71;",
    "text-decoration: none;",
"}",

"div.menu ul li a:active",
"{",
    "background-color: #465c71;",
    "color: #cfdbe6;",
    "text-decoration: none;",
"}",

"div",
"{",
"width:300px",
"padding: 10px",
"border: 8px",
"}",

"</style>",
" <link href=\"~/Styles/Site.css\" rel=\"stylesheet\" type=\"text/css\" />",
"<body>",
"   <form id=\"form1\" runat=\"server\">",
"<div class=\"clear hideSkiplink\">",


               " <asp:Menu ID=\"NavigationMenu\" runat=\"server\" CssClass=\"menu\" EnableViewState=\"false\" IncludeStyleBlock=\"false\" Orientation=\"Horizontal\">",
                "    <Items>",
                        "<asp:MenuItem NavigateUrl=\"~/Default.aspx\" Text=\"Home\"/>",
                         "<asp:MenuItem NavigateUrl=\"~/Math.aspx\" Text=\"Mathematics\"/>",
                        " <asp:MenuItem NavigateUrl=\"~/Quiz-Page.aspx\" Text=\"Quizzes\"></asp:MenuItem>",
                        "<asp:MenuItem NavigateUrl=\"~/About.aspx\" Text=\"About\"/>",
                       

                   " </Items>",
              "  </asp:Menu>",
              "</div>",
              "<div><br><br>",
"           <asp:Label ID=\"output\" runat=\"server\" Font-Names=\"Century\" Font-Size=\"Medium\">",
"</asp:Label>",
" <asp:Image ID=\"Image1\" runat=\"server\" />",
"       </div>",
"   </form>",
"</body>",
"</html>"};
            
           
string[] csLines = {"using System;",
                       "using System.Data.SqlClient;",
"using System.Data.Sql;",
"using System.Configuration;",
"using System.Web.UI.WebControls;",
"namespace generate_page_runtime {",
"    public partial class "+TextBox1.Text.Trim()+" : System.Web.UI.Page {",
"        protected void Page_Load(object sender, EventArgs e) {",
"            output.Text = \""+TextBox2.Text+"\";",
"Image1.ImageUrl =\""+FileUpload1.FileName+" \";",
"string connstr = ConfigurationManager.ConnectionStrings[\"cn\"].ConnectionString;",
            "MySql.Data.MySqlClient.MySqlConnection mySqlConnection = new  MySql.Data.MySqlClient.MySqlConnection(connstr);",
            "string a=\"+TextBox1.Text.Trim()+\";",
            "string b=@\""+TextBox1.Text.Trim()+"\"+\".aspx\"",
            "string comm=\"INSERT into page(title,link) VALUES (@\""+TextBox1.Text.Trim()+"\",b);",
            "MySql.Data.MySqlClient.MySqlCommand insert = new MySql.Data.MySqlClient.MySqlCommand(comm, mySqlConnection);",
            "insert.Connection.Open();",
            "insert.ExecuteNonQuery();",
                "mySqlConnection.Close();",
            "        }",
"    }",
"}"};

            
System.IO.File.WriteAllLines(Server.MapPath("" + TextBox1.Text.Trim() + ".aspx"), aspxLines);
System.IO.File.WriteAllLines(Server.MapPath("" + TextBox1.Text.Trim() + ".aspx.cs"), csLines);
string url;
url = "" + TextBox1.Text.Trim() + ".aspx";
Response.Redirect(url);

}


    
    }


}

      
   
