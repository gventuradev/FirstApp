<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FirstApp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your name?
            <asp:TextBox ID="nameInput" runat="server"></asp:TextBox>
            <br />
            <br />
            What is your age?&nbsp;&nbsp; <asp:TextBox ID="ageInput" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Submit" />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
