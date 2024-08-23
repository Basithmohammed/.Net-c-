<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication4.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>item1</asp:ListItem>
                <asp:ListItem>item2</asp:ListItem>
                <asp:ListItem>item3</asp:ListItem>
                <asp:ListItem>item4</asp:ListItem>
            </asp:DropDownList><br /><br />
            <asp:Button ID="Button1" runat="server" Text="COPY ITEMS" /><br /><br />
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList><br /><br />
            <asp:Button ID="Button2" runat="server" Text="COPY ALL" OnClick="Button2_Click" /><br /><br />
            <asp:DropDownList ID="DropDownList3" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
