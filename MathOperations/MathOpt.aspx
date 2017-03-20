<%@ Page Title="Mathineer" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="MathOpt.aspx.cs" Inherits="DatabaseDiary.WebForm1" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div>
     <h2 style="font-family: Centaur; font-size: xx-large; font-weight: normal; font-style: normal;">Matrices</h2>
    <ul style="font-family: Centaur;font-size: medium;">
    <li><a href="Add.aspx">Addition of 2 Matrices</a></li>
    <li><a href="Multiply.aspx">Multiplication of 2 Matrices</a></li>
    <li><a href="Inverse.aspx">Inverse of Matrix</a></li>
    <li><a href="Transpose.aspx">Transpose of Matrix</a></li>
    <li><a href="Adjoint.aspx">Adjoint of a Matrix</a></li>
    </ul>
        <img src="Baloo.jpg" runat="server" width="700" />
    </div>
    </asp:Content>
