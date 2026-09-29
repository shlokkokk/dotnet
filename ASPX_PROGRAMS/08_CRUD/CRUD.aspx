<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="PracticalPack.CRUD" %>
<!DOCTYPE html><html><body><form id="form1" runat="server">
ID:<asp:TextBox ID="txtId" runat="server" /><br />Name:<asp:TextBox ID="txtName" runat="server" /><br />Course:<asp:TextBox ID="txtCourse" runat="server" /><br />
<asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
<asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
<asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
<asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="btnLoad_Click" /><br />
<asp:Label ID="lblMessage" runat="server" /><br /><asp:GridView ID="GridView1" runat="server" />
</form></body></html>
