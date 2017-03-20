<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Inverse.aspx.cs" Inherits="DatabaseDiary.Inverse" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
    
    <br />
                <asp:TextBox ID="TextBox5" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox6" runat="server" Width="61px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox7" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox8" runat="server" Width="61px"></asp:TextBox>
                &nbsp;<br />
        <asp:Label ID="Label1" runat="server" Visible="false"
            Text="Inverse does not exist as the determinant of the given matrix is 0."></asp:Label>
        <br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Find Inverse" 
                    Width="120px" />
                <br />
                <br />
                <asp:TextBox ID="TextBox9" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox10" runat="server" Width="61px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox11" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox12" runat="server" Width="61px"></asp:TextBox>
                &nbsp;( Result )&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel></div>
    </asp:Content>
