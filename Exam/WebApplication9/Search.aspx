<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebApplication9.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton Text="Home" runat="server" CssClass="button" PostBackUrl="~/Home.aspx"/>
        <asp:LinkButton Text="Search for a book" runat="server" PostBackUrl="~/Search.aspx"/>
        <br />
        <br />
        <asp:Label Text="Searching with capital:" runat="server" ID="capitalLabel" />
        <asp:TextBox runat="server" id="CapitalTB" />  
        <br />
        <br />
        <asp:Label Text="Searhing with country:" runat="server" ID="CountryLabel" />
        <asp:TextBox runat="server" id="CountryTB" />
        <br />
        <br />
        <asp:Label Text="Searhing with Cityzens:" runat="server" ID="CityzensLabel" />
        <asp:TextBox runat="server" id="CityzensTB"  />
        <br />
        <br />
        <asp:Button Text="Show result" ID="addBookBtn" runat="server" OnClick="addBookBtn_Click"/>
        <asp:Label Text="sss" runat="server" ForeColor="Green" ID="resultLabel"/>
    
    </div>
    </form>
</body>
</html>
