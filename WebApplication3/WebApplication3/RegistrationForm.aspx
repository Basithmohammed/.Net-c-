<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationForm.aspx.cs" Inherits="WebApplication3.RegistrationForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .div{
            width:500px;
            height:700px;
            background-color:antiquewhite;
            text-align:center;
            padding:15px;
        }
        #Label1{
            margin:20px;
            
        }
        #TextBox1{
            padding:5px;
            margin-top:30px;
        }
        #TextBox2{
            padding:5px;
            margin-left:25px;
        }
        #Label2{
            margin:30px; 
        }
        #TextBox3{
            width:300px;
            padding:5px;
        }
        #TextBox4{
            width:300px;
            padding:5px;
            margin-left:180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div">
            
            <h1>Job Application</h1>
            <h4>Please complete the form below to apply for a position with us.</h4>
            <asp:Label ID="Label1" runat="server" Text="Full Name *" ></asp:Label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <p style="font-size:15px;margin-left:-180px;margin-top:1px;">First Name</p>
            <p style="font-size:15px;margin-left:230px;margin-top:-35px;">Second Name</p>
            <asp:Label ID="Label2" runat="server" Text="Current Address *"></asp:Label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <p style="font-size:15px;margin-left:-50px;margin-top:1px;">Street Address</p>
            </asp:Label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <p style="font-size:15px;margin-left:-5px;margin-top:1px;">Street Address Line 2</p>
        </div>
    </form>
</body>
</html>
