﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Tahsilat.aspx.cs" Inherits="TahsilatUyg_.Tahsilat" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Bilgi Girişi"></asp:Label>
        &nbsp;
        <p>
            <asp:Label ID="Label2" runat="server" Text="Müşteri Adı*"></asp:Label>
        </p>
        <p>
            <asp:DropDownList ID="DropDownList2" CssClass="form-check-inline" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Ürün adı"></asp:Label>
        *<br />
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-check-inline" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
     
            </asp:DropDownList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Toplam Fiyat*"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" CssClass="form-control"  BorderWidth="1px" TextMode="Number" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Fiyat Girmeniz Gerekmektedir."></asp:RequiredFieldValidator>
        <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Sayısal Veri Giriniz"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Taksit Sayısı*"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" BorderWidth="1px" CssClass="form-control"  TextMode="Number" runat="server" AutoPostBack="true" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Taksit Sayısı Boş Bırakılamaz." Display="Dynamic" />
            <br />
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="En fazla 36 ay taksit yapılmaktadır."></asp:RangeValidator>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Peşin Alınan Miktar"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox4" CssClass="form-control"  BorderWidth="1px" runat="server" TextMode="Number" AutoPostBack="true" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Aylık Ödenecek Miktar"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" CssClass="form-control" BorderWidth="1px" runat="server"  TextMode="Number" AutoPostBack="true" Enabled="False"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="Müşteri Notu"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox6" BorderWidth="1px" runat="server" Height="67px" CssClass="form-control"  ></asp:TextBox>
        <br />
        &nbsp;&nbsp;
        <asp:Button ID="Button1" class="btn btn-success btn-rounded" AutoPostBack="true" runat="server" Text="Kaydet" OnClick="Button1_Click" />
        <br />
    <div class="sufee-alert alert with-close alert-success alert-dismissible fade show" runat="server" id="successAlert" style="display: none;">
    <span class="badge badge-pill badge-success">Başarılı!</span>
    Taksit Bilgileri Oluşturuldu.
    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
        <span aria-hidden="true">&times;</span>
    </button>
</div>
    <div class="sufee-alert alert with-close alert-danger alert-dismissible fade show" runat="server" id="unsuccessAlert" style="display: none;">
    <span class="badge badge-pill badge-danger">Başarısız!</span>
    Ürün adı ve müşteri adı boş bırakılamaz!.

    <button type="button" class="close" data-dismiss="alert" aria-label="Close">
	    <span aria-hidden="true">&times;</span>
    </button>
</div>
<p>
    &nbsp;</p>
</asp:Content>