using System;
namespace PracticalPack
{
    public partial class Default : System.Web.UI.Page
    {
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = txtInput.Text;
        }
    }
}

/*
============================================================
THEORY / VIVA NOTES
============================================================
1. ASP.NET Web Forms uses an event-driven programming model.
2. The .aspx file contains markup and server controls.
3. Code-behind contains server-side logic and event handlers.
4. runat="server" makes a control available to server code.
5. Button Click executes the associated event handler.
6. TextBox.Text reads entered text and Label.Text displays text.
*/
