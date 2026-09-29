Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If txtName.Text = "" Or txtNumber.Text = "" Then
            MessageBox.Show("Please fill in both fields.")
        Else
            MessageBox.Show("Name: " & txtName.Text & vbCrLf & "Number: " & txtNumber.Text)
        End If
    End Sub
End Class