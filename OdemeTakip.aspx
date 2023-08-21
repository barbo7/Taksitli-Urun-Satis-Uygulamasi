<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="OdemeTakip.aspx.cs" Inherits="TahsilatUyg_.OdemeTakip" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  CausesValidation="false"  Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Ödeme Takip"></asp:Label>
            <br />
            <br />
        <asp:Label ID="Label2" runat="server" Text="Müşteri Arama"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" BorderWidth="1px" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
      <!-- DATA TABLE 2-->
  <div class="table-responsive m-b-40" style="height: 200px">
      <table class="table table-borderless table-data3">
          <thead>
              <tr>
                  <th>Müşteri Ad Soyad</th>
                  <th>Ürün Adı</th>
                  <th>Taksit Miktarı</th>
                  <th>Toplam Fiyat</th>
                  <th>Ödenen Toplam</th>
                  <th>Ödeme Başlangıç Tarihi</th>
              </tr>
          </thead>
          <tbody>
              <tr>
                  <td colspan="6">
                      <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                  </td>
              </tr>
          </tbody>
      </table>
  </div>

        <!-- DATA TABLE 2-->
<div class="table-responsive m-b-40" style="height: 200px">
    <table class="table table-borderless table-data3">
        <thead>
            <tr>
                <th>Müşteri Ad Soyad</th>
                <th>Ürün Adı</th>
                <th>Ödenen Tutar</th>
                <th>Tarih</th>
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
        
</asp:Content>