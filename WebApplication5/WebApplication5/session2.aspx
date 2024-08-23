﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="session2.aspx.cs" Inherits="WebApplication5.session2" %>

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
            height:280px;
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
            <h1>STUDENT MARK DETAILS</h1>
            <asp:Label ID="Label1" runat="server" Text="Mark 1"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Mark 2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server" Text="Mark 3"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Load" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>