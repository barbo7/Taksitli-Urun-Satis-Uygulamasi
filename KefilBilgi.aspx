<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="KefilBilgi.aspx.cs" Inherits="TahsilatUyg_.KefilBilgi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Burada sayfaya özgü stil veya bağlantılar eklenebilir -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Kefil Kişi Bilgi Girişi"></asp:Label>
    <p>
        Kefil Olduğu Kişi*</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Kefil Ad Soyad*:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox1" MaxLength="60" runat="server" BorderWidth="1px"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ContentPlaceHolder1_TextBox1"  
            ErrorMessage="Ad-Soyad alanı boş bırakılamaz." Display="Dynamic"  />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="ContentPlaceHolder1_TextBox1" 
            ValidationExpression="^[a-zA-Z\s]+$" ErrorMessage="Lütfen sadece harf kullanın." Display="Dynamic"  />
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Kefil Tel No*:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox2" runat="server" BorderWidth="1px" MaxLength="11" AutoPostBack="false"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox2"
            ErrorMessage="Cep telefonu alanı boş bırakılamaz." Display="Dynamic" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2"
            ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli telefon numarasını giriniz." Display="Dynamic" />
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Kefil TC*:"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="TextBox3" runat="server" BorderWidth="1px" MaxLength="11" AutoPostBack="false"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3"
            ErrorMessage="Tc No alanı boş bırakılamaz." Display="Dynamic" />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3"
            ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli TC giriniz." Display="Dynamic" />
    </p>
    <br />
    <p>
        <asp:Button ID="Button1"  class="btn btn-success btn-rounded" runat="server" OnClick="Button1_Click" Text="Kaydet" />
    </p>

    <div class="sufee-alert alert with-close alert-success alert-dismissible fade show" runat="server" id="successAlert" style="display: none;">
    <span class="badge badge-pill badge-success">Başarılı!</span>
    Kayıt gerçekleştirildi.
    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
        <span aria-hidden="true">&times;</span>
        </button>
    </div>
   
<p>
    &nbsp;</p>
</asp:Content>
 