<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" Height="123px" Width="665px">
                <asp:Label ID="Label1" runat="server" Text="查找"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="查找内容："></asp:Label>
&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="更多&gt;&gt;" />
                &nbsp;
                <asp:Button ID="Button2" runat="server" Text="查找下一处" />
                &nbsp;
                <asp:Button ID="Button3" runat="server" Text="取消" />
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server" Height="163px" Visible="False" Width="665px">
            <asp:Label ID="Label3" runat="server" Text="查找范围："></asp:Label>
            &nbsp;
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem>全部</asp:ListItem>
                <asp:ListItem>前半段</asp:ListItem>
                <asp:ListItem>后半段</asp:ListItem>
            </asp:DropDownList>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True">
                <asp:ListItem>区分大小写</asp:ListItem>
                <asp:ListItem>全字匹配</asp:ListItem>
                <asp:ListItem>使用通配符</asp:ListItem>
                <asp:ListItem>同音（英文）</asp:ListItem>
            </asp:CheckBoxList>
        </asp:Panel>
    </form>
</body>
</html>
