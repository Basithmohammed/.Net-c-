<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication7.WebForm3" %>

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
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <h1>Complete Details</h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br /><br />
        </div>
    </form>
</body>
</html>
