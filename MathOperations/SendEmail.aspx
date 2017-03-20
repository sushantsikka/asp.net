<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SendEmail.aspx.cs" Inherits="DatabaseDiary.SendEmail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    Enter Email Id<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 199px" Width="179px"></asp:TextBox>
    <br />
    Enter Subject<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 203px" Width="179px"></asp:TextBox>
    <br />
    Message<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 226px" Width="179px"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" style="margin-left: 179px" Text="Send" Width="89px" />
</asp:Content>
