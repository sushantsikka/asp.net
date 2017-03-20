<%@ Page Title="Mathineer" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Bisection-Code.aspx.cs" Inherits="DatabaseDiary.Bisection_Code" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>

        #include<iostream>&lt;iostream&gt;</p>
    <p>

        using namespace std;</p>
    <p>

        float func(float a, float b, float c, float d, float v)</p>
    <p>

        {

    </p>
    <p>

        return (a*(v*v*v)) + (b*(v*v)) + (c*v) + d;

    </p>
    <p>

        }</p>
    <p>

        int main()

    </p>
    <p>

        {

    </p>
    <p>

        float a =0,b =0,c =0,d =0,f0 =0,f1 =0,f2 =0,x2 =0,x0 =0,x1 =0;

    </p>
    <p>

        int N =0; cout&lt;&lt;&quot;\n Enter the function f(x) = a.x^3 + b.x^2 + c.x + d&quot;;</p>
    <p>

    &nbsp;cin&gt;&gt;a&gt;&gt;b&gt;&gt;c&gt;&gt;d;</p>
    <p>

    &nbsp;cout&lt;&lt;&quot;\n Enter x0 and x1&quot;;</p>
    <p>

    &nbsp;cin&gt;&gt;x0&gt;&gt;x1; cout&lt;&lt;&quot;\n Enter the number of iterations&quot;;</p>
    <p>

    &nbsp;cin&gt;&gt;N;</p>
    <p>

    &nbsp;for(int i =0;i&lt;N;i++)</p>
    <p>

    &nbsp;{ x2 = (x1 + x0) / 2;</p>
    <p>

    &nbsp;f0 = func(a,b,c,d,x0);</p>
    <p>

    &nbsp;f1 = func(a,b,c,d,x1);</p>
    <p>

    &nbsp;f2 = func(a,b,c,d,x2);</p>
    <p>

    &nbsp;if(f0 * f2 &lt; 0)</p>
    <p>

    &nbsp;{ x1 = x2; }</p>
    <p>

    &nbsp;if(f1 * f2 &lt; 0)</p>
    <p>

    &nbsp;{

    </p>
    <p>

        x0 = x2; </p>
    <p>

        }</p>
    <p>

    &nbsp;}</p>
    <p>

        cout&lt;&lt;&quot;\n Root =&gt; &quot;&lt;&lt;x2; </p>
    <p>

        return 0;

    </p>
    <p>

        }</p>
</asp:Content>
