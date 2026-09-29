<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PracticalPack.WebControls" %>
<!DOCTYPE html><html><body><form id="form1" runat="server">
<asp:TextBox ID="txtName" runat="server" /><br />
<asp:CheckBox ID="chkStudent" runat="server" Text="Student" /><br />
<asp:RadioButton ID="rdoMale" runat="server" GroupName="Gender" Text="Male" />
<asp:RadioButton ID="rdoFemale" runat="server" GroupName="Gender" Text="Female" /><br />
<asp:DropDownList ID="ddlCourse" runat="server"><asp:ListItem>C#</asp:ListItem><asp:ListItem>VB.NET</asp:ListItem></asp:DropDownList>
<asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_Click" /><br /><asp:Label ID="lblResult" runat="server" />
</form></body></html>
