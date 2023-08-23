<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="UrunBilgi.aspx.cs" Inherits="TahsilatUyg_.UrunBilgi" %>

<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
    <style>
    .auto-style1 {
        width: 415px;
    }
</style>
</asp:Content>
<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  CausesValidation="false"  Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Ürün Bilgileri"></asp:Label>
            <br />
            <p>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
  <!-- DATA TABLE -->
            <div class="table-responsive m-b-40" style="height: 200px">
                <table class="table table-borderless table-data3">
                    <thead>
                        <tr>
                            <th class="auto-style1">Ürün Adı</th>
                            <th>Ürün Fiyatı</th>
                        </tr>
                    </thead>
                    <tr>
                        <td colspan="6">
                            <asp:Literal ID="Literal1" runat="server">
                            </asp:Literal>
                        </td>
                    </tr>
                </table>
            </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ürün adı*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" BorderWidth="1px" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
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
            <asp:TextBox ID="TextBox2" BorderWidth="1px" runat="server" OnTextChanged="TextBox2_TextChanged" TextMode="Number"></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Ürün fiyat alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        </p>
        <p>
&nbsp;&nbsp;&nbsp;
            <br />

            <asp:Button ID="Button1" class="btn btn-success btn-rounded" runat="server" OnClick="Button1_Click" Text="Ürün Kaydet" />
        </p>
            <div class="sufee-alert alert with-close alert-success alert-dismissible fade show" runat="server" id="successAlert" style="display: none;">
            <span class="badge badge-pill badge-success">Başarılı!</span>
            Ürün Kayıdı gerçekleştirildi.
            <button type="button" class="close" data-dismiss="alert" aria-label="Close">
                <span aria-hidden="true">&times;</span>
            </button>
        </div>

        <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show" runat="server" id="unsuccessAlert" style="display: none;">
        <span class="badge badge-pill badge-danger">Başarısız!</span>
        Aynı isimde ürün var. Kayıt Yapılmadı!
        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
	        <span aria-hidden="true">&times;</span>
        </button>
        </div>
        <p>
            &nbsp;</p>
</asp:Content>
