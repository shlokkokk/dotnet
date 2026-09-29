Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Public Sub New()
        Text = "Form Control"
        ClientSize = New Size(420, 220)
        Dim title As New Label With {.Text = "VB.NET Form Control", .AutoSize = True, .Location = New Point(120, 45)}
        Dim button As New Button With {.Text = "Click Me", .Location = New Point(160, 90)}
        AddHandler button.Click, Sub() MessageBox.Show("Button clicked")
        Controls.AddRange({title, button})
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
