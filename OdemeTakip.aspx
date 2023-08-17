<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OdemeTakip.aspx.cs" Inherits="TahsilatUyg_.OdemeTakip" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  CausesValidation="false"  Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Ödeme Takip"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Label ID="Label2" runat="server" Text="Müşteri Arama"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoPostBack="true" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle VerticalAlign="Middle" BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoPostBack="true" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle VerticalAlign="Middle" BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" ForeColor="White" Font-Bold="True" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#284775" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
    </form>
</body>
</html>
