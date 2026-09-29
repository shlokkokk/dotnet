Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add items to the ComboBox
        cboItems.Items.Add("Item 1")
        cboItems.Items.Add("Item 2")
        cboItems.Items.Add("Item 3")
        cboItems.Items.Add("Item 4")
    End Sub
    Private Sub cboItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboItems.SelectedIndexChanged

    End Sub

    Private Sub btnShowChoice_Click(sender As Object, e As EventArgs) Handles btnShowChoice.Click
        If cboItems.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item.")
        Else
            lblChosen.Text = "Chosen Item: " & cboItems.SelectedItem.ToString()

        End If
    End Sub
End Class
