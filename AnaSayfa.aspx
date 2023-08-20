<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="AnaSayfa.aspx.cs" Inherits="TahsilatUyg_.AnaSayfa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Burada sayfaya özgü stil veya bağlantılar eklenebilir -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Sayfa içeriği burada yer almalı -->
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
    <asp:Button ID="Button6" runat="server" Height="55px" OnClick="Button6_Click" Text="Ödeme Takip" Width="183px" />
    <br />
</asp:Content>
