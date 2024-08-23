<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication6.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .sample{
            width:100px;
            height:100px;
            border-radius:5px;
            background-color:aquamarine;
            text-align:center;
            padding:10px;
            margin:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" RepeatDirection="Horizontal" RepeatColumns="3">
                <ItemTemplate>
                    <div class="sample">
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("Id") %>'></asp:Label><br /><br />
                        <asp:Label ID="Label2" runat="server" Text='<%#Eval("name") %>'></asp:Label><br /><br />
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("age") %>'></asp:Label><br /><br />
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
