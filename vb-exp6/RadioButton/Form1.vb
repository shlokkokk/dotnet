Public Class Form1
    Dim result As String
    Private Sub rdbEasy_CheckedChanged(sender As Object, e As EventArgs) Handles rdbEasy.CheckedChanged
        If rdbEasy.Checked Then
            result = "Easy"
            lblSelected.Text = $"Selected: {result}"
        End If
    End Sub

    Private Sub rdbMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMedium.CheckedChanged
        If rdbMedium.Checked Then
            result = "Medium"
            lblSelected.Text = $"Selected: {result}"
        End If
    End Sub

    Private Sub rdbHard_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHard.CheckedChanged
        If rdbHard.Checked Then
            result = "Hard"
            lblSelected.Text = $"Selected: {result}"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
