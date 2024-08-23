<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div{
            text-align:center;
            margin-top:30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:DropDownList ID="ddlProduct" runat="server">
                
            </asp:DropDownList>
        </div>

        <div class="div1">
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender"/><br />
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender"/><br />
            <asp:RadioButton ID="RadioButton3" runat="server" Text="Others" GroupName="gender"/><br />
        </div>

        <div class="div2">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
                <asp:ListItem>Others</asp:ListItem>
            </asp:RadioButtonList>
        </div>

    </form>
</body>
</html>
