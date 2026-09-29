Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Text = "RadioButton"
        ClientSize = New Size(350, 220)

        Dim r1 As New RadioButton With {.Text = "Male", .Location = New Point(30, 30)}
        Dim r2 As New RadioButton With {.Text = "Female", .Location = New Point(30, 65)}
        Dim result As New Label With {.Location = New Point(30, 150), .AutoSize = True}

        Dim btn As New Button With {.Text = "Show", .Location = New Point(30, 105)}
        AddHandler btn.Click, Sub()
                                  If r1.Checked Then
                                      result.Text = "Selected: Male"
                                  ElseIf r2.Checked Then
                                      result.Text = "Selected: Female"
                                  Else
                                      result.Text = "Select one"
                                  End If
                              End Sub

        Controls.AddRange({r1, r2, btn, result})
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
