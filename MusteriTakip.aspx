<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="MusteriTakip.aspx.cs" Inherits="TahsilatUyg_.MusteriTakip" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="head">
    <style>
        .btn-rounded {
            border-radius: 20px;
            padding: 10px 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" CausesValidation="false" Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Müşteri Arama: " Font-Bold="False" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" BorderWidth="1px" Font-Bold="False" Font-Overline="False"></asp:TextBox>

    <br />

    <br />
        <!-- DATA TABLE 1-->
                <div class="table-responsive m-b-40" style="height: 300px">
                    <table class="table table-borderless table-data3" >
                        <thead>
                            <tr>
                                <th>Müşteri ID</th>
                                <th>Ad Soyad</th>
                                <th>Toplam Borç</th>
                                <th>Ödenen Toplam</th>
                                <th>Kalan Toplam</th>
                                <th>Maksimum Taksit Miktarı</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td colspan="6">
                                    <asp:Literal ID="myLiteralControl" runat="server"></asp:Literal>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
    <br />
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Müşteri Ödeme Güncelleme" ForeColor="Black"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Müşteri id:" ForeColor="Black"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" AutoPostBack="true" OnTextChanged="TextBox2_TextChanged" BorderWidth="1px"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Müşteri id Boş bırakılamaz" ForeColor="Red"></asp:RequiredFieldValidator>
    &nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Sayısal Veri Giriniz" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />
            <!-- DATA TABLE 2-->
            <div class="table-responsive m-b-40" style="height: 200px">
                <table class="table table-borderless table-data3">
                    <thead>
                        <tr>
                            <th>Müşteri Ad Soyad</th>
                            <th>Ürün Adı</th>
                            <th>Alış Tarihi</th>
                            <th>Kalan Tutar</th>
                            <th>Aylık Taksit Tutarı</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td colspan="6">
                                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Ödenen yeni miktar:" ForeColor="Black"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" TextMode="Number" runat="server" BorderWidth="1px"></asp:TextBox>
    <br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Ödenen Miktar Giriniz" ForeColor="Red"></asp:RequiredFieldValidator>
    &nbsp;
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Tam veya Ondalıklı Sayı Giriniz" ForeColor="Red"></asp:RegularExpressionValidator>
    <br />

    <asp:Label ID="Label5" runat="server" Text="Tahsilatı yapılacak Ürün" ForeColor="Black"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" AutoPostBack="true" runat="server" Height="30px" Width="121px">
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="Button3" class="btn btn-success btn-rounded" runat="server" OnClick="Button3_Click" Text="Güncelle" />
    <br />
 </asp:Content>