<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication7.WebForm2" %>

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
            
                <asp:DropDownList ID="DropDownList1" runat="server" >
                    <asp:ListItem>Select a degree</asp:ListItem>
                    <asp:ListItem Value="ug">UG</asp:ListItem>
                    <asp:ListItem Value="pg">PG</asp:ListItem>
                    
                </asp:DropDownList><br /><br />
            
            <asp:Label ID="Label1" runat="server" Text="Enter College Name "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
