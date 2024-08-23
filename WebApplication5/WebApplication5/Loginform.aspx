<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loginform.aspx.cs" Inherits="WebApplication5.Loginform" %>

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
            width:250px;
            height:230px;
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
            <h1>LOGIN FORM</h1>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br /><br />
            <a href="demoPage.aspx">Home Page</a>
        </div>
    </form>
</body>
</html>
