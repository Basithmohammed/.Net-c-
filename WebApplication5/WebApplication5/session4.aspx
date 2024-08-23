<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session4.aspx.cs" Inherits="WebApplication5.session4" %>

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
            width:300px;
            height:300px;
            background-color:antiquewhite;
            border-radius:7px;
            border:2px solid black;
            text-align:center;
            margin-top:50%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <h1>Academic Details</h1>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label><br /><br />
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label><br /><br />

            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label><br /><br />
        </div>
    </form>
</body>
</html>
