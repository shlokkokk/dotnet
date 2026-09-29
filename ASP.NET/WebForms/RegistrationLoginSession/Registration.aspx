<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Registration.aspx.vb" Inherits="RegistrationLoginSession.Registration" %>
<!DOCTYPE html>
<html><body>
<form runat="server">
    <h2>Registration</h2>
    <asp:TextBox ID="txtUser" runat="server" placeholder="Username" /><br /><br />
    <asp:TextBox ID="txtPass" runat="server" TextMode="Password" placeholder="Password" /><br /><br />
    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    <asp:Label ID="lbl" runat="server" />
</form>
</body></html>
