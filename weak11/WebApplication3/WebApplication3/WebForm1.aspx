<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>注册</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="欢迎"></asp:Label>
        注册xxx<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="姓 名"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="年 龄"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="性别"></asp:Label>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>男</asp:ListItem>
            <asp:ListItem>女</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label8" runat="server" Text="地 区"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="出生日期"></asp:Label>
&nbsp;<asp:TextBox ID="TextBox7" runat="server" OnTextChanged="TextBox7_TextChanged1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="用户名"></asp:Label>
&nbsp; <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="密 码"></asp:Label>
&nbsp;&nbsp;<asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        <br />
        <br />
        确认密码 <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="注册" Width="80px" OnClick="Button1_Click1" />
    </form>
</body>
</html>
