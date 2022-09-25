<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebAppTest.accounts.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login<br />
        </div>
        <p>
            <asp:TextBox ID="TextBox2" runat="server" style="margin-bottom: 0px" Height="22px"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Submit" runat="server" OnClick="Button1_Click" Text="Submit" />
        </p>
        <asp:Label ID="ErrorLabel" runat="server" Text="Error: Check username and password are correct" Visible="False"></asp:Label>
    </form>
</body>
</html>
