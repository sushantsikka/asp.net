<%@ Page Title="Mathineer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add-Page.aspx.cs" Inherits="DatabaseDiary.Add_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        Title
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 31px" Width="218px"></asp:TextBox>
    </p>
    <p>
        Content
        <asp:TextBox ID="TextBox2" runat="server" Height="172px" style="margin-left: 11px" TextMode="MultiLine" Width="606px"></asp:TextBox>
    </p>
    <p>
        Image<asp:FileUpload ID="FileUpload1" runat="server" style="margin-left: 25px" />
    </p>
    <p><hr />
        <p style="font-family: centaur; font-size: large; font-weight: bold;">Or</p><hr />
        Enter HTML Code for the page

        <asp:TextBox ID="TextBox3" runat="server" Height="172px" style="margin-left: 11px" TextMode="MultiLine" Width="606px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />

        <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Button1_Click" style="margin-left: 59px" Text="Generate" Width="163px" />
    </p>
    <img src="CalvinHobbes2.png" runat="server" width="600" />
    
</asp:Content>
