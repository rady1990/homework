<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Interface.aspx.cs" Inherits="WebApplication9.Interface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h1>Търси по:</h1>

        Столица: 
        <asp:Label Text="" runat="server" id="CapitalSearch" />
        <br />
        <br />
        
        Държава: 
        <asp:Label Text="" runat="server" id="CountrySearch" />
        <br />
        <br />

        
        Население: 
        <asp:Label Text="" runat="server" id="CityzensSearch" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
