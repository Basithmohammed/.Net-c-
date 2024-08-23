<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication4.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #Button1{
            width:100px;
            background-color:aquamarine;
            border:2px solid aquamarine;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:Panel ID="Panel1" runat="server">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem>Select a product</asp:ListItem>
                    <asp:ListItem Value="1000">Product A</asp:ListItem>
                    <asp:ListItem Value="1500">Product B</asp:ListItem>
                    <asp:ListItem Value="2000">Product C</asp:ListItem>
                </asp:DropDownList>
            </asp:Panel><br /><br />
            <asp:Panel ID="Panel2" runat="server" Visible="false">
                <asp:Label ID="Label1" runat="server" Text="Price"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Calculate Bill" OnClick="Button1_Click" />
            </asp:Panel><br /><br />
            <asp:Panel ID="Panel3" runat="server" Visible="false">
                <asp:Label ID="Label2" runat="server" Text="Total Bill"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
