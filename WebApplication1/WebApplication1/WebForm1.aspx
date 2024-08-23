<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        
        .div{
            background-color:aqua;
            width:300px;
            text-align:center;
            margin-top:30px;
            border:2px solid black;
            margin-left:400px;
            border-radius:5px;
            
        }   
        #Button1{
            background-color:red;
            margin-bottom:20px;
            padding:5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <h2 style="color:darkslategrey;">LOGIN PAGE</h2>
            <asp:Label ID="Label1" runat="server" Text="USER NAME : "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="PASSWORD : "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="LOGIN" />
        </div>
        
    </form>
</body>
</html>
