<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication9.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <br />
        <br />



        <asp:Label Text="Столица:" runat="server" />
        <asp:TextBox runat="server" ID="CapitalTB"/>
  
        <br />
        <br />
        
        <asp:Label Text="Държава:" runat="server" />
        <asp:TextBox runat="server" ID="CountryTB" />
        <br />
        <br />

        <asp:Label Text="Население:" runat="server" />
        <asp:TextBox TextMode="Number" runat="server" ID="CityzensTB" />
        <br />
        <br />

        <asp:Button Text="Добави в файла" runat="server" id="btnSubmit" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnView" runat="server" Text="Преглед на статистиката" />
    
    </div>
    </form>
</body>
</html>
