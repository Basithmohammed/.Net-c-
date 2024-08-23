<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:Label ID="lblName" runat="server" Text="Enter Student Name "></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblMark1" runat="server" Text="Mark 1 "></asp:Label>
            <asp:TextBox ID="txtMark1" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblMark2" runat="server" Text="Mark 2 "></asp:Label>
            <asp:TextBox ID="txtMark2" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblMark3" runat="server" Text="Mark 3 "></asp:Label>
            <asp:TextBox ID="txtMark3" runat="server"></asp:TextBox><br />

            <asp:Label ID="lblMark4" runat="server" Text="Mark 4 "></asp:Label>
            <asp:TextBox ID="txtMark4" runat="server"></asp:TextBox><br />

            <asp:Button ID="btnSubmit" runat="server" Text="Calculate" OnClick="btnSubmit_Click"/><br /><br />
            
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                <asp:Label ID="lblView" runat="server" Text="Total Mark"></asp:Label>
                <asp:TextBox ID="txtSum" runat="server"></asp:TextBox><br />
                <asp:Label ID="lblView1" runat="server" Text="Average Mark"></asp:Label>
                <asp:TextBox ID="txtAvg" runat="server"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
