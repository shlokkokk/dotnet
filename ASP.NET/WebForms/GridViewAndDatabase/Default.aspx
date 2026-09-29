<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="GridViewAndDatabase.Default" %>
<!DOCTYPE html>
<html>
<head runat="server"><title>Feedback</title></head>
<body>
<form id="form1" runat="server">
    <h2>Feedback</h2>
    <asp:TextBox ID="txtName" runat="server" placeholder="Name" />
    <br /><br />
    <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" placeholder="Feedback" />
    <br /><br />
    <asp:Button ID="btnSave" runat="server" Text="Save Feedback" OnClick="btnSave_Click" />
    <asp:Label ID="lblStatus" runat="server" />
    <hr />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
</form>
</body>
</html>
