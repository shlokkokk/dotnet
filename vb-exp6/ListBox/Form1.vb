Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstItems.Items.Add("Item 1")
        lstItems.Items.Add("Item 2")
        lstItems.Items.Add("Item 3")
    End Sub
    Private Sub lstItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItems.SelectedIndexChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtNewItem.Text = "" Then
            MessageBox.Show("Please enter a new item.")
        Else
            lstItems.Items.Add(txtNewItem.Text)
            txtNewItem.Text = ""
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstItems.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item to remove.")
        Else
            lstItems.Items.RemoveAt(lstItems.SelectedIndex)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstItems.Items.Clear()
    End Sub

    Private Sub btnShowSelected_Click(sender As Object, e As EventArgs) Handles btnShowSelected.Click
        If lstItems.SelectedIndex = -1 Then
            MessageBox.Show("Please select an item.")
        Else
            lblResult.Text = "Selected Item: " & lstItems.SelectedItem
        End If
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        lblTotal.Text = "Total: " & lstItems.Items.Count.ToString()
    End Sub
End Class
