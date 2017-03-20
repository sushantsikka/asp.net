<%@ Page Title="About Us" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="DatabaseDiary.About" %>
    
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p style="font-family:Century">
        Sushant Sikka
    </p>
    <p style="font-family:Century">
    Delhi Technological University, New Delhi
    
    </p>
 
    <p style="font-family:Century; font-weight: bold; font-size: large;" 
        align="center">
        Contact</p>
    <p align="left" style="font-family:Century">
        Name&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="187px" BorderColor="#99CCFF"></asp:TextBox>
    </p>
    <p align="left" style="font-family:Century">
        Email Id
        <asp:TextBox ID="TextBox2" runat="server" Width="187px" BorderColor="#99CCFF" TextMode="Email"></asp:TextBox>
    </p>
    <p align="left" style="font-family:Century">
        Comments
        <asp:TextBox ID="TextBox3" runat="server" Height="55px" Width="256px" 
            BorderColor="#99CCFF" TextMode="MultiLine"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Font-Names="century" Font-Size="Medium" Text="Message Sent !" Visible="false"></asp:Label>
    </p>
    <p align="left" style="font-family:Century" >
        <asp:Button ID="Button1" runat="server" BorderColor="#99CCFF" BorderWidth="4px" 
            
            
            style="font-family:Century; font-weight: bold; font-size: large; margin-left: 408px;" align="center"
            Text="Send" Width="137px" OnClick="Button1_Click" />
    </p>

</asp:Content>
