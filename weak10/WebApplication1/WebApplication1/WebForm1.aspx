<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 275px;
        }
        .auto-style2 {
            margin-left: 80px;
        }
        .auto-style3 {
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text="登录"></asp:Label>
        </div>
        <asp:Label ID="Label2" runat="server" Text="用户名："></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" Width="170px"></asp:TextBox>
        <br />
&nbsp;
        <asp:Label ID="Label3" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3" OnTextChanged="TextBox2_TextChanged" Width="170px"></asp:TextBox>
        <p class="auto-style2">
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="登入" />
        </p>
    </form>
</body>
</html>
