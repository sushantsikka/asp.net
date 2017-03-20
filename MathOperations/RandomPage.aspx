<%@ Page Language="C#" AutoEventWireup="true"CodeFile="RandomPage.aspx.cs" Inherits="generate_page_runtime.RandomPage" %>
<!DOCTYPE html>
<head>
<title>Mathineer</title>
</head>
<style type="text/css"> 
body
{
 background: #6BBCF2;
 font-size: .80em;
 font-family: "Helvetica Neue","Lucida Grande", "Segoe UI", Arial, Helvetica, Verdana, sans-serif;
margin: 0px;
padding: 0px;
color: #696969;
}
div.hideSkiplink
{
 background-color:#3a4f63;
width:100%;
}
div.menu
{
  padding: 4px 0px 4px 8px;
}
div.menu ul
{
   list-style: none;
 margin: 0px;
padding: 0px;
 width: auto;
}
div.menu ul li a, div.menu ul li a:visited
{
  background-color: #4b6c9e;
  border: 1px #4e667d solid;
 color: #dde4ec;
display: block; 
line-height: 1.35em;
padding: 4px 14px;
text-decoration: none;
white-space: nowrap;
}
div.menu ul li a:hover
{
  background-color: #bfcbd6;
color: #465c71;
text-decoration: none;
}
div.menu ul li a:active
{
background-color: #465c71;
color: #cfdbe6;
text-decoration: none;
}
literal
{
font-family: "Century"
color: #000000; 
font-weight: bold;
}
</style>
 <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
<body>
   <form id="form1" runat="server">
<div class="clear hideSkiplink">
 <asp:Menu ID="NavigationMenu" runat="server" CssClass="menu" EnableViewState="false" IncludeStyleBlock="false" Orientation="Horizontal">
    <Items>
<asp:MenuItem NavigateUrl="~/Default.aspx" Text="Home"/>
<asp:MenuItem NavigateUrl="~/Math.aspx" Text="Mathematics"/>
 <asp:MenuItem NavigateUrl="~/Quiz-Page.aspx" Text="Quizzes"></asp:MenuItem>
<asp:MenuItem NavigateUrl="~/About.aspx" Text="About"/>
 </Items>
  </asp:Menu>
</div>
<div><br><br>
           <asp:Label ID="output" runat="server" Font-Names="Century" Font-Size="Medium">
</asp:Label>
       </div>
   </form>
</body>
</html>
