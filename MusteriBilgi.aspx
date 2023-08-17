<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MusteriBilgi.aspx.cs" Inherits="TahsilatUyg_.MusteriBilgi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.7.0.js"></script>
    <link href="Css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click"  CausesValidation="false"  Text="Ana Sayfaya Dön" CssClass="right-aligned-button" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" BackColor="#CCCCCC" BorderColor="White" Font-Bold="True" Font-Size="Larger" Text="Müşteri Girişi"></asp:Label>
            <br />
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Ad Soyad*:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" MaxLength="60" runat="server" ></asp:TextBox>
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
            <asp:TextBox ID="TextBox2" MaxLength="11"  runat="server" AutoPostBack="false" ></asp:TextBox>
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
            <asp:TextBox ID="TextBox3" runat="server"  Width="128px" MaxLength="11" AutoPostBack="false" ></asp:TextBox>
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
            <asp:TextBox ID="TextBox4"  MaxLength="10" runat="server" Height="22px" Width="128px" AutoPostBack="false" ></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Adres:"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="TextBox5" runat="server" Height="70px" Width="200px"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Kaydet" />
        </p>
    </form>
</body>
</html>
