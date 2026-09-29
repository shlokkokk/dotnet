<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticalPack.Default" %>
<!DOCTYPE html>
<html><head runat="server"><title>ASP.NET Web Forms</title></head>
<body><form id="form1" runat="server">
<asp:Label ID="lblOutput" runat="server" Text="Output"></asp:Label><br />
<asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
<asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
</form></body></html>
