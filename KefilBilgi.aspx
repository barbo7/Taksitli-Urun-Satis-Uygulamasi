<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KefilBilgi.aspx.cs" Inherits="TahsilatUyg_.KefilBilgi" %>

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
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Kefil Kişi Bilgi Girişi"></asp:Label>
        </div>
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
            <asp:TextBox ID="TextBox1" MaxLength="60" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Ad-Soyad alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                ValidationExpression="^[a-zA-Z\s]+$" ErrorMessage="Lütfen sadece harf kullanın." Display="Dynamic" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Kefil Tel No*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" MaxLength="11" AutoPostBack="false" ></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3"
                ErrorMessage="Cep telefonu alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox3"
                ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli telefon numarasını giriniz." Display="Dynamic" />
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Kefil TC*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" MaxLength="11" AutoPostBack="false" ></asp:TextBox>
        </p>
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2"
                ErrorMessage="Tc No alanı boş bırakılamaz." Display="Dynamic" />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox2"
                ValidationExpression="^\d{11}$" ErrorMessage="11 Haneli TC giriniz." Display="Dynamic" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
        </p>
    </form>
</body>
</html>
