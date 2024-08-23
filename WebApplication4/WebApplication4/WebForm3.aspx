<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>APPLE</asp:ListItem>
                <asp:ListItem>MANGO</asp:ListItem>
                <asp:ListItem>BANANA</asp:ListItem>
                <asp:ListItem>ORANGE</asp:ListItem>
                <asp:ListItem>GRAPES</asp:ListItem>
            </asp:DropDownList><br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
