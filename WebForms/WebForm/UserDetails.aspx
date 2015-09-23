<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetails.aspx.cs" Inherits="WebForm.UserDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="labelUser" runat="server" Text="User name: " />
            <asp:TextBox ID="textBoxUser" runat="server" />
            <%--<asp:RequiredFieldValidator ID="user" runat="server" ControlToValidate="textBoxUser" ErrorMessage="Empty"></asp:RequiredFieldValidator>--%>
            <br />
            <br />
            <asp:Label ID="labelPass" runat="server" Text="Password: "/>
            <asp:TextBox ID="textPass" runat="server"  TextMode="Password"/>
            <%--<asp:RequiredFieldValidator ID="pass" runat="server" ControlToValidate="textPass" />--%>
            <asp:Label ID="labelRepeatPass" runat="server" Text="Repeat Password: " />
            <asp:TextBox ID="textRepPass" runat="server" TextMode="Password"  />
            <%--<asp:RequiredFieldValidator ID="repPass" runat="server" ControlToValidate="textRepPass" />--%>
            <asp:CompareValidator ID="compPassword" runat="server"
                ControlToCompare="textPass"
                ControlToValidate="textRepPass"
                ErrorMessage="Password don`t match" />
            <br />
            <br />
            <asp:Label ID="age" runat="server" Text="Age: " />
            <asp:TextBox ID="ageBox" runat="server" />
            <br />
            <br />
            <asp:Label ID="email" runat="server" Text="Email: " />
            <asp:TextBox ID="emailBox" runat="server" TextMode="Email" />
            <br />
            <br />
            <asp:Button ID="button" runat="server" OnClick="Button_Click" Text="Register" />
        </div>
    </form>
</body>
</html>
