<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Add.aspx.cs" Inherits="DatabaseDiary.Add" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

    <h2 style="font-family: Centaur; font-size: xx-large; font-weight: normal; font-style: normal;">Addition of 2 Matrices
    </h2>

            <br />
            <asp:Panel ID="Panel1" runat="server" Height="248px">
                <asp:TextBox ID="TextBox1" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server" Width="61px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox3" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox4" runat="server" Width="61px"></asp:TextBox>
                &nbsp;( Matrix 1 )<br />
                <br />
                <asp:TextBox ID="TextBox5" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox6" runat="server" Width="61px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox7" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox8" runat="server" Width="61px"></asp:TextBox>
                &nbsp;( Matrix 2 )<br />
                <br />
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Add" 
                    Width="120px" />
                <br />
                <br />
                <asp:TextBox ID="TextBox9" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox10" runat="server" Width="61px"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox11" runat="server" Width="61px"></asp:TextBox>
                <asp:TextBox ID="TextBox12" runat="server" Width="61px"></asp:TextBox>
                &nbsp;( Result )&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <br />

 </asp:Content>