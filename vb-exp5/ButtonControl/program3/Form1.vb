Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "admin" And txtPass.Text = "password" Then
            MessageBox.Show("Login successful!")
        Else
            MessageBox.Show("Invalid username or password.")
        End If
    End Sub
End Class
