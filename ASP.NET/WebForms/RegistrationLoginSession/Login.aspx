<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Login.aspx.vb" Inherits="RegistrationLoginSession.Login" %>
<!DOCTYPE html>
<html><body>
<form runat="server">
    <h2>Login</h2>
    <asp:TextBox ID="txtUser" runat="server" placeholder="Username" /><br /><br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" placeholder="Password" /><br /><br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
    <asp:Label ID="lbl" runat="server" />
</form>
</body></html>
