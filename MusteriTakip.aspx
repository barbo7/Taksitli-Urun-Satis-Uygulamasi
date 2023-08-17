<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriTakip.aspx.cs" Inherits="TahsilatUyg_.MusteriTakip" %>

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
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CausesValidation="false" Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
            <br />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Müşteri Arama: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

            <br />

            <br />
            <asp:GridView ID="GridView1" AutoPostBack="true" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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
            <br />
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Müşteri Ödeme Güncelleme"></asp:Label>
            <br />
            <br />

            <asp:Label ID="Label3" runat="server" Text="Müşteri id:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" AutoPostBack="true" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Müşteri id Boş bırakılamaz"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Sayısal Veri Giriniz"></asp:RegularExpressionValidator>
            <br />
            <asp:GridView ID="GridView2" AutoPostBack="true" runat="server" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
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

            <asp:Label ID="Label4" runat="server" Text="Ödenen yeni miktar:"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox3" TextMode="Number" runat="server"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ödenen Miktar Giriniz"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Tam veya Ondalıklı Sayı Giriniz"></asp:RegularExpressionValidator>
            <br />

            <asp:Label ID="Label5" runat="server" Text="Tahsilatı yapılacak Ürün"></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" Height="16px" Width="121px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Güncelle" />
        </div>
    </form>
</body>
</html>