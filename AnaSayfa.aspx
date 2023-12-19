<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="AnaSayfa.aspx.cs" Inherits="TahsilatUyg_.AnaSayfa" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Burada sayfaya özgü stil veya bağlantılar eklenebilir -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Sayfa içeriği burada yer almalı -->
    <asp:Label ID="Label1" runat="server" Text="Kayıtlı Ürün Sayısı : "></asp:Label>
    &nbsp;&nbsp;&nbsp;   
    <asp:Label ID="Label2" runat="server" Text="Aktif Müşteri Sayısı : "></asp:Label>
    <br />
    <asp:Chart ID="Chart1" runat="server">
        <Series>
            <asp:Series ChartType="Pie" Name="Series1"></asp:Series>
        </Series>
        <ChartAreas>
            <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
        </ChartAreas>
    </asp:Chart>
</asp:Content>
