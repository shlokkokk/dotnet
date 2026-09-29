<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Student.aspx.vb" Inherits="RegistrationLoginSession.Student" %>
<!DOCTYPE html>
<html><body>
<form runat="server">
    <h2>Student Area</h2>
    <asp:Label ID="lblWelcome" runat="server" />
    <br /><br />
    <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
</form>
</body></html>
