<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="CLICK" OnClick="Button1_Click" /><br /><br />
            <asp:TextBox ID="txtAnswer" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
