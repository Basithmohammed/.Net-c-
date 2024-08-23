<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication4.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>SELECT A CHOICE</asp:ListItem>
                <asp:ListItem>APPLE</asp:ListItem>
                <asp:ListItem>MANGO</asp:ListItem>
                <asp:ListItem>ORANGE</asp:ListItem>
                <asp:ListItem>Grapes</asp:ListItem>
            </asp:DropDownList><br /><br />
            <asp:Button ID="Button1" runat="server" Text="remove single element" OnClick="Button1_Click" /><br /><br />
            <asp:Button ID="Button2" runat="server" Text="Clear All element" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
