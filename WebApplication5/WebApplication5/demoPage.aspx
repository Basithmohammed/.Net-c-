<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="demoPage.aspx.cs" Inherits="WebApplication5.demoPage" %>

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
        #Label1{
            font-size:20px;
        }
        #Label2{
            font-size:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <h1>WELCOME BOARD</h1>
            <asp:Label ID="Label1" runat="server" Text="Customer Name : "></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Customer Password : "></asp:Label>
        </div>
    </form>
</body>
</html>
