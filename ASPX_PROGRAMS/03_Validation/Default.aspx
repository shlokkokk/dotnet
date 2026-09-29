<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticalPack.ValidationDemo" %>
<!DOCTYPE html><html><body><form id="form1" runat="server">
Name: <asp:TextBox ID="txtName" runat="server" />
<asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required." />
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><asp:ValidationSummary ID="vs" runat="server" />
</form></body></html>
