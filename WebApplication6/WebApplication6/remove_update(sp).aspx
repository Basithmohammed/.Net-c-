﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="remove_update(sp).aspx.cs" Inherits="WebApplication6.remove_update_sp_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            <asp:DataList ID="DataList1" runat="server">
                <HeaderTemplate>
                    <table style ="border-collapse: collapse;text-align:center;" border="1">
                        <tr>
                            <td style="width:250px;">ID</td>
                            <td style="width:250px;">NAME</td>
                            <td style="width:250px;">AGE</td>
                        </tr>
                    </table>
                </HeaderTemplate>
                <ItemTemplate>
                    <table style ="border-collapse: collapse;text-align:center;" border="1">
                        <tr>
                            <td style="width:250px;">
                                <asp:Label ID="Label1" runat="server" Text='<%#Eval("Id")%>'></asp:Label>
                            </td>
                            <td style="width:250px;">
                                <asp:Label ID="Label2" runat="server" Text='<%#Eval("name")%>'></asp:Label>
                            </td>
                            <td style="width:250px;">
                                <asp:Label ID="Label3" runat="server" Text='<%#Eval("age")%>'></asp:Label>
                            </td>

                            <td>
                                <a class="btn btn-danger btn-sm" href="removesp.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id") %>">remove</a>
                            </td>
                            <td>
                                <a class="btn btn-danger btn-sm" href="updatesp.aspx?id=<%#DataBinder.Eval(Container.DataItem,"id") %>">Update</a>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
