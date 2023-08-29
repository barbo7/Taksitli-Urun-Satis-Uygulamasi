<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="MusteriBilgi.aspx.cs" Inherits="TahsilatUyg_.MusteriBilgi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Müşteri Girişi"></asp:Label>
            <br />
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ad Soyad*:"></asp:Label>
        </p>
        <p>
            <asp:Textbox CssClass="form-control" ID="TextBox1" MaxLength="60" runat="server" BorderWidth="1px" ></asp:Textbox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Ad-Soyad alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                ValidationExpression="^[a-zA-Z\s]+$" ErrorMessage="Lütfen sadece harf kullanın." Display="Dynamic" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="TC*:"></asp:Label>
        </p>
        <p>
            <asp:Textbox CssClass="form-control" ID="TextBox2" MaxLength="11"  runat="server" BorderWidth="1px" AutoPostBack="false" ></asp:Textbox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="Tc No alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2"
                ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli TC giriniz." Display="Dynamic" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Telefon No*:"></asp:Label>
        </p>
        <p>
            <asp:Textbox CssClass="form-control" ID="TextBox3" runat="server" BorderWidth="1px"  MaxLength="11" AutoPostBack="false" ></asp:Textbox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="Cep telefonu alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3"
                ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli telefon numarasını giriniz." Display="Dynamic" />
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Vergi Kimlik No:"></asp:Label>
        </p>
        <p>
            <asp:Textbox CssClass="form-control" ID="TextBox4" BorderWidth="1px" MaxLength="10" runat="server" AutoPostBack="false" ></asp:Textbox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Adres:"></asp:Label>
        </p>
        <p>
            <asp:Textbox CssClass="form-control" ID="TextBox5" BorderWidth="1px" runat="server" Height="70px"></asp:Textbox>
        </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;<asp:Button ID="Button1" class="btn btn-success btn-rounded" runat="server" OnClick="Button1_Click" Text="Kaydet" />
        </p>
            <p>
                &nbsp;</p>
            <div class="sufee-alert alert with-close alert-success alert-dismissible fade show" runat="server" id="successAlert" style="display: none;">
		        <span class="badge badge-pill badge-success">Başarılı!</span>
		        Kayıt gerçekleştirildi.
		        <button type="button" class="close" data-dismiss="alert" aria-label="Close">
			        <span aria-hidden="true">&times;</span>
		        </button>
	        </div>
        <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show" runat="server" id="unsuccessAlert" style="display: none;">
    <span class="badge badge-pill badge-danger">Başarısız!</span>
    Müşteri adı veya TC no mükerrer olamaz!.

    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
	    <span aria-hidden="true">&times;</span>
    </button>
</div>
            <p>
                &nbsp;</p>


 </asp:Content>