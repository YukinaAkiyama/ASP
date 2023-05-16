<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication8.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="二刺螈"></asp:Label>
            <br />
            <br />
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/Resources/AD.xml" OnAdCreated="AdRotator1_AdCreated" Width="700px" />
        </div>
    </form>
</body>
</html>
