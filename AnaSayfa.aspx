<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeBehind="AnaSayfa.aspx.cs" Inherits="TahsilatUyg_.AnaSayfa" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Burada sayfaya özgü stil veya bağlantılar eklenebilir -->
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Sayfa içeriği burada yer almalı -->

    <asp:Label ID="Label1" runat="server" Text="Kayıtlı Ürün Sayısı : "></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Text="Aktif Müşteri Sayısı : "></asp:Label>

    <br />
    <!-- CHART PERCENT-->
    <div class="chart-percent-3 m-b-40">
        <h3 class="title-3 m-b-25">Satılan Ürünler</h3>
        <div class="chart-note m-b-5">
            <span class="dot dot--blue"></span>
            <span>products</span>
        </div>
        <div class="chart-note">
            <span class="dot dot--red"></span>
            <span>services</span>
        </div>
        <div class="chart-wrap m-t-60">
            <canvas id="percent-chart2"></canvas>
        </div>
    </div>
    <!-- END CHART PERCENT-->
    <asp:Chart ID="Chart1" runat="server">
        <series>
            <asp:Series ChartType="Pie" Name="Series1">
            </asp:Series>
        </series>
        <chartareas>
            <asp:ChartArea Name="ChartArea1">
            </asp:ChartArea>
        </chartareas>
    </asp:Chart>

</asp:Content>
