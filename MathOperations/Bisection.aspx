<%@ Page Title="Mathineer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bisection.aspx.cs" Inherits="DatabaseDiary.Bisection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    The function f(x) is of order 3, that is, f(x) = a.x^3 + b.x^2 + c.x + d
    <br />
    <br />
    Enter the values of a, b, c and d<br />
    <br />
    a &gt;&gt;&gt;
    <asp:TextBox ID="TextBox1" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    b &gt;&gt;&gt;
    <asp:TextBox ID="TextBox2" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    c &gt;&gt;&gt;
    <asp:TextBox ID="TextBox3" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    d &gt;&gt;&gt;
    <asp:TextBox ID="TextBox4" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    Enter the range in which to find solution<br />
    <br />
    Min &gt;&gt;&gt;
    <asp:TextBox ID="TextBox5" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    Max &gt;&gt;&gt;
    <asp:TextBox ID="TextBox6" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    Enter the number of iterations &gt;&gt;&gt;
    <asp:TextBox ID="TextBox7" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Height="34px" OnClick="Button1_Click" Text="Solve" Width="166px" />
    <br />
    <br />
    The solution is &gt;&gt;&gt;
    <asp:TextBox ID="TextBox8" runat="server" Width="55px"></asp:TextBox>
    <br />
    <br />
    <asp:HyperLink ID="HyperLink1" NavigateUrl="~/Bisection-Code.aspx" runat="server">View Code ( C++ )</asp:HyperLink>
    <br />

</asp:Content>
