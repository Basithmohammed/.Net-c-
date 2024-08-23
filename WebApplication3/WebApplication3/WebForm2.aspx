<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div{
            width:350px;
            height:400px;
            background-color:antiquewhite;
            text-align:center;
            margin-top:50px;
            display:flex;
            justify-content:center;
            align-items:center;
        }
        #Label1{
            margin:20px;
        }
        #Label2{
            margin:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Number 1 "></asp:Label>
                <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox><br /><br />

                <asp:Label ID="Label2" runat="server" Text="Number 2 "></asp:Label>
                <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox><br /><br />

                <asp:Label ID="Label3" runat="server" Text="Operation "></asp:Label>
                <asp:TextBox ID="txtOperation" runat="server"></asp:TextBox><br /><br />


                <asp:Button ID="Button1" runat="server" Text="CALCULATE" OnClick="Button1_Click" />
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" Visible="True">
                <asp:Label ID="Label4" runat="server" Text="Out "></asp:Label>
                <asp:TextBox ID="txtOut" runat="server"></asp:TextBox><br /><br />
            </asp:Panel>
        </div>
    </form>
</body>
</html>
