<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
        &nbsp;</p>
    <p>
        Name
        <asp:TextBox ID="TextBox1" runat="server" Width="203px" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Cannot be left blank" Visible="false"></asp:Label>
    </p>
    <p>
        College<asp:TextBox ID="TextBox2" runat="server" Width="203px" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="Cannot be left blank" Visible="false"></asp:Label>
    </p>
    <p>
        Year<asp:TextBox ID="TextBox3" runat="server" Width="203px" CssClass="form-control"></asp:TextBox>
    </p>
    <p>
        Email Id
        <asp:TextBox ID="TextBox4" runat="server" TextMode="Email" Width="203px" CssClass="form-control"></asp:TextBox>
    </p>
    <p>
        Branch<asp:TextBox ID="TextBox5" runat="server" Width="203px" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Cannot be left blank" Visible="false"></asp:Label>
    </p>
    <p>
        Event Name<asp:TextBox ID="TextBox6" runat="server" TextMode="Password" Width="203px" CssClass="form-control"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Both password inputs do not match." Visible="False"></asp:Label>
    </p>
    <p>
        Mobile Number
        <asp:TextBox ID="TextBox7" runat="server" Width="203px" CssClass="form-control"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button_Click" Text="Register" Width="119px" />
    </p>
</asp:Content>

