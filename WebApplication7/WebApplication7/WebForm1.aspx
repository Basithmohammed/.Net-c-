<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

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
            <h1>PERSONAL DETAILS</h1>
            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Age "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" MinLength=""></asp:TextBox><br /><br />
            
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Type="email"></asp:TextBox><br /><br />
            
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/><br /><br />

            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>

            
                
                
        </div>
    </form>
</body>
</html>
