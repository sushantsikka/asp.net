<%@ Page Title="Mathineer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NumericalOpt.aspx.cs" Inherits="DatabaseDiary.NumericalOpt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2 style="font-family: Century; font-size: x-large; font-weight: normal; font-style: normal">
        Numerical Methods</h2>
    <ul style="font-family: Century; font-size: medium;">
        <li><a href="Bisection.aspx">Bisection Method</a></li>
        <li>
            <a href="Gauss-Elimination.aspx">
            Gauss Elimination</a></li>
        <li>Gauss Seidel</li>
        <li>Secant Method</li>
        <li>Crout's Method</li>
        <li>Newton's Interpolation</li>
        <li><a href="Trapezoidal.aspx">
            Trapezoidal Method</a></li>
        <li>Simpson's Method</li>
        <li>Romberg's Method</li>
        <li>Picard's Method</li>
        <li>Runge Kutta Method</li>
    </ul>
</asp:Content>
