<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Trapezoidal.aspx.cs" Inherits="DatabaseDiary.Trapezoidal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        The order of the function is 4, that is, the function is given by f(x) = a.x^4 + b.x^3 + c.x^2 + d.x + e</p>
    <p>
        a &gt;&gt;&gt;
    <asp:TextBox ID="TextBox1" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        b &gt;&gt;&gt;
    <asp:TextBox ID="TextBox2" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        c &gt;&gt;&gt;
    <asp:TextBox ID="TextBox3" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        d &gt;&gt;&gt;
    <asp:TextBox ID="TextBox4" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        e &gt;&gt;&gt;
    <asp:TextBox ID="TextBox5" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        Enter the lower limit of integration &gt;&gt;&gt;
    <asp:TextBox ID="TextBox6" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        Enter the upper limit of integration &gt;&gt;&gt;
    <asp:TextBox ID="TextBox7" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
        Enter the number of divisions &gt;&gt;&gt;
    <asp:TextBox ID="TextBox9" runat="server" Width="55px"></asp:TextBox>
    </p>
    <p>
&nbsp;<asp:Button ID="Button1" runat="server" Height="34px" OnClick="Button1_Click" Text="Solve" Width="166px" />
    </p>
    <p>
        Area under the curve &gt;&gt;&gt; <asp:TextBox ID="TextBox8" runat="server" Width="126px"></asp:TextBox>
    </p>

</asp:Content>
