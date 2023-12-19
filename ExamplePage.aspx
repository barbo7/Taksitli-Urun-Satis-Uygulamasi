<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExamplePage.aspx.cs" Inherits="YourNamespace.ExamplePage" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Extended Example Page</title>
    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .form-group {
            margin-bottom: 15px;
        }

            .form-group label {
                display: block;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-group">
            <label for="TextBoxName">Name:</label>
            <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxEmail">Email:</label>
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="TextBoxComments">Comments:</label>
            <asp:TextBox ID="TextBoxComments" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        </div>
        <div>
            <asp:Label ID="LabelResult" runat="server" Text="Deneme"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Deneme"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Deneme"></asp:Label>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Deneme"></asp:Label>
        </div>
        <div class="form-group">
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        </div>
    </form>
</body>
</html>
