Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Text = "CheckBox"
        ClientSize = New Size(360, 220)

        Dim c1 As New CheckBox With {.Text = "C#", .Location = New Point(30, 30)}
        Dim c2 As New CheckBox With {.Text = "VB.NET", .Location = New Point(30, 65)}
        Dim result As New Label With {.Location = New Point(30, 150), .AutoSize = True}

        Dim btn As New Button With {.Text = "Show", .Location = New Point(30, 105)}
        AddHandler btn.Click, Sub()
                                  Dim selected As New List(Of String)
                                  If c1.Checked Then selected.Add(c1.Text)
                                  If c2.Checked Then selected.Add(c2.Text)
                                  result.Text = If(selected.Count = 0, "Nothing selected", String.Join(", ", selected))
                              End Sub

        Controls.AddRange({c1, c2, btn, result})
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
