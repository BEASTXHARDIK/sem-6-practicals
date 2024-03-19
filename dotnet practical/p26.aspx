<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="prac26.aspx.cs" Inherits="dotnetsession.prac26" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1> Welcome To Asp .net , This is my .net viva project </h1>
        <div>
        </div>
        <asp:TextBox ID="Txt1" runat="server" placeholder="Enter Your Name"></asp:TextBox>
        <p>
            <asp:Button ID="click_me" runat="server" Text="Click me" OnClick="click_me_Click" />
        </p>
    </form>
</body>
</html>
