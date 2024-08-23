<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            display:flex;
            justify-content:center;
        }
        .div{
            text-align:center;
            margin-top:100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:Label ID="Label1" runat="server" Text="ID : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="NAME : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="AGE : "></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
