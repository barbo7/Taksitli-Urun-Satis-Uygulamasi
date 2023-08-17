<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunBilgi.aspx.cs" Inherits="TahsilatUyg_.UrunBilgi" %>

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
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Ürün Bilgileri"></asp:Label>
            <br />
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="572px" HorizontalAlign="Center" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Ürün Adı" HeaderText="Ürün Adı" SortExpression="Ürün Adı" />
                        <asp:BoundField DataField="Fiyat" HeaderText="Fiyat" SortExpression="Fiyat" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
            </p>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ürün adı*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Ürün adı alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"  ErrorMessage="Geçerli bir Ürün adı giriniz" Display="Dynamic"></asp:RegularExpressionValidator>
            </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Ürün Fiyatı*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Ürün fiyat alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ürün Kaydet" />
        </p>
    </form>
</body>
</html>
