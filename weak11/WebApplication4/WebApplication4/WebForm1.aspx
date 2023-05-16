<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="选择曲目"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>大声唱</asp:ListItem>
                <asp:ListItem>半岛铁盒</asp:ListItem>
                <asp:ListItem>烟花易冷</asp:ListItem>
                <asp:ListItem>下雨天</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label2" runat="server" Text="点击这里播放："></asp:Label>
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
