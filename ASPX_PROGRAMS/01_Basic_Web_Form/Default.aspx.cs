using System; namespace PracticalPack { public partial class BasicWebForm:System.Web.UI.Page { protected void btnShow_Click(object sender,EventArgs e){ lblResult.Text="Hello, "+txtName.Text; } } }
