<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Login.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lb1" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="UserName" Font-Bold="True" Width="100px"
            BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>
        <asp:TextBox ID="TextBox_user_name" runat="server" ForeColor="#993300" Width="100px" MaxLength="8" ></asp:TextBox><br />
        <asp:Label ID="Label3" runat="server" Text="Password" Font-Bold="True" Width="100px"
            BackColor="#FFFF66" ForeColor="#FF3300"></asp:Label>
        <asp:TextBox ID="TextBox_password" runat="server" ForeColor="#CC6600" TextMode="Password"
            Width="100px"></asp:TextBox><br />
        <asp:Button ID="btn_login" runat="server" Text="Login" Font-Bold="True" BackColor="#CCFF99"
            OnClientClick="Validate()" OnClick="btn_login_Click" /><br />
    </div>
    </form>
</body>
</html>
