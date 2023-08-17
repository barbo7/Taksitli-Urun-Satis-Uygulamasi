<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="TahsilatUyg_.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
  #form1 {
    margin-top: 50px; /* Yukarıdan 50 piksel boşluk */
    /* veya padding-top: 20px; */
    text-align: center; /* Form içeriğini ortalamak için */
    /* Diğer stil özellikleri */
  }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Height="55px" OnClick="Button1_Click" Text="Müşteri Girişi" Width="183px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="55px" OnClick="Button4_Click" Text="Kefil Bilgi Girişi" Width="183px" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="55px" OnClick="Button2_Click" Text="Ürün Girişi" Width="183px" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="55px" OnClick="Button3_Click" Text="Tahsilat Bilgileri Girişi" Width="183px" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Height="55px" OnClick="Button5_Click" Text="Müşteri Takip" Width="183px" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="55px" OnClick="Button6_Click" Text="ÖdemeTakip" Width="183px" />
        <br />
    </form>
</body>
</html>
