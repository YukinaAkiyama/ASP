<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label5" runat="server" Text="重庆红色景点"></asp:Label>
            <br />
            <br />
            <asp:ImageMap ID="ImageMap1" runat="server" Height="170px" ImageUrl="~/Picture/歌乐山烈士陵园.jpg" Width="300px" OnClick="ImageMap1_Click">
                <asp:CircleHotSpot PostBackValue="place" Radius="100" NavigateUrl="~/Picture/歌乐山烈士陵园.jpg" X="100" Y="100" />
            </asp:ImageMap>
            <asp:ImageMap ID="ImageMap2" runat="server" Height="170px" ImageUrl="~/Picture/红岩革命纪念馆.jpg" Width="300px" OnClick="ImageMap2_Click">
                <asp:CircleHotSpot PostBackValue="place" Radius="100" NavigateUrl="~/Picture/红岩革命纪念馆.jpg" X="100" Y="100" />
            </asp:ImageMap>
            <asp:ImageMap ID="ImageMap3" runat="server" Height="170px" ImageUrl="~/Picture/人民解放纪念碑.jpg" Width="300px" OnClick="ImageMap3_Click">
                <asp:CircleHotSpot PostBackValue="place" Radius="100" NavigateUrl="~/Picture/人民解放纪念碑.jpg" X="100" Y="100" />
            </asp:ImageMap>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Width="80px"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="歌乐山烈士陵园" Width="300px"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="红岩革命纪念馆" Width="330px"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="人民解放纪念碑"></asp:Label>
        </div>
        <p>
            <asp:ImageMap ID="ImageMap4" runat="server" Height="555px" ImageUrl="~/Picture/地图2.png" OnClick="ImageMap4_Click" HotSpotMode="Navigate">
                <asp:CircleHotSpot HotSpotMode="Navigate" NavigateUrl="https://baike.baidu.com/item/%E9%87%8D%E5%BA%86%E6%AD%8C%E4%B9%90%E5%B1%B1%E7%83%88%E5%A3%AB%E9%99%B5%E5%9B%AD/7233458?fromtitle=%E6%AD%8C%E4%B9%90%E5%B1%B1%E7%83%88%E5%A3%AB%E9%99%B5%E5%9B%AD&amp;fromid=1244949&amp;fr=aladdin" PostBackValue="Location1" Radius="50" X="110" Y="75" />
            </asp:ImageMap>
        </p>
    </form>
</body>
</html>
