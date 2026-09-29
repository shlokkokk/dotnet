Imports System.Collections.Generic

Public Class Form1

    Private Sub btnShowHobbies_Click(sender As Object, e As EventArgs) Handles btnShowHobbies.Click
        Dim hobbies As New List(Of String)

        If chkReading.Checked Then
            hobbies.Add("Reading")
        End If
        If chkMusic.Checked Then
            hobbies.Add("Music")
        End If
        If chkSports.Checked Then
            hobbies.Add("Sports")
        End If
        If chkGaming.Checked Then
            hobbies.Add("Gaming")
        End If

        If hobbies.Count = 0 Then
            lblResult.Text = "No hobbies selected."
        Else
            lblResult.Text = $"Selected hobbies: {String.Join(", ", hobbies)}"
        End If
    End Sub

End Class