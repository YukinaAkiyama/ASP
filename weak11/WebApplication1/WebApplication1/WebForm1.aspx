<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="110px" ImageUrl="~/Resources/sina.jpg" OnClick="ImageButton1_Click" Width="161px" />
            <asp:ImageButton ID="ImageButton2" runat="server" Height="110px" ImageUrl="~/Resources/sohu.png" OnClick="ImageButton2_Click" Width="202px" />
        </div>
    </form>
</body>
</html>
