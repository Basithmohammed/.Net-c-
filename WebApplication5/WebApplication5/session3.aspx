<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session3.aspx.cs" Inherits="WebApplication5.session3" %>

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
            height:200px;
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
            <h1>STUDENT INTERNAL</h1>
            <asp:Label ID="Label1" runat="server" Text="Internam Mark "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            
            
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
