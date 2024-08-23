<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="Button1" runat="server" Text="ADD TO DROPDOWN" OnClick="Button1_Click" /><br /><br />
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList><br /><br />
            <asp:Button ID="Button2" runat="server" Text="ADD TO TEXT BOX" OnClick="Button2_Click"  /><br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
            
        </div>
    </form>
</body>
</html>
