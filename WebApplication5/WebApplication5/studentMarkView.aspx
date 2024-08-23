<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentMarkView.aspx.cs" Inherits="WebApplication5.studentMarkView" %>

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
            <h1>Welcome Student</h1>
            <asp:Label ID="Label3" runat="server" Text="Student Name : "></asp:Label><br /><br />
            <asp:Label ID="Label1" runat="server" Text="Total Mark : "></asp:Label><br /><br />
            <asp:Label ID="Label2" runat="server" Text="Average Mark : "></asp:Label>
        </div>
    </form>
</body>
</html>
