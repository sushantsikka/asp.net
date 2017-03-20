<%@ Page Title="Mathineer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmailSubscription.aspx.cs" Inherits="DatabaseDiary.EmailSubscription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <p>
        Name
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 48px" Width="165px"></asp:TextBox>
    </p>
    <p>
        Email Address <asp:TextBox ID="TextBox2" runat="server" Width="165px"></asp:TextBox>
    </p>
    <p>
        Gender
        <asp:DropDownList ID="DropDownList1" runat="server" style="margin-left: 44px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem Value="nil">Do not wish to specify</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Height="30px" OnClick="Button1_Click" style="margin-left: 86px" Text="Subscribe" Width="155px" />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Visible="false" Font-Names="century" Font-Size="Medium" Text="Thanks for subscribing !"></asp:Label>
    </p>
</asp:Content>
