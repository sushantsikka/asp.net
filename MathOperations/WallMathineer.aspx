<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WallMathineer.aspx.cs" Inherits="DatabaseDiary.WallMathineer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div>
        <asp:TextBox ID="post" runat="server" Width="726px" Height="24px" TextMode="MultiLine"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" style="margin-left: 16px" Text="Post" Width="127px"  />
        </div>
        <div>

            <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label7" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label8" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label9" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label10" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
