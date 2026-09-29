Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click
        If txtName.Text = "" Then
            MessageBox.Show("Please enter your name.")
        Else
            lblOutput.Text = "Hello, " & txtName.Text & "! Welcome to VB.NET."
        End If
    End Sub
End Class