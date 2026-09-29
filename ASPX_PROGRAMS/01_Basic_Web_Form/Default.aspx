<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticalPack.BasicWebForm" %>
<!DOCTYPE html><html><body><form id="form1" runat="server">
Name: <asp:TextBox ID="txtName" runat="server" /><asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" /><br />
<asp:Label ID="lblResult" runat="server" />
</form></body></html>
