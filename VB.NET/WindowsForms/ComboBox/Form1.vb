Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Dim combo As New ComboBox With {.Location = New Point(30, 30), .Width = 150}
    Dim output As New Label With {.Location = New Point(30, 100), .AutoSize = True}

    Public Sub New()
        Text = "ComboBox"
        ClientSize = New Size(320, 160)
        combo.Items.AddRange(New Object() {"C", "C++", "VB.NET", "C#"})
        combo.SelectedIndex = 0
        Controls.Add(combo)

        Dim btn As New Button With {.Text = "Show", .Location = New Point(200, 30)}
        AddHandler btn.Click, Sub() output.Text = "Selected: " & combo.SelectedItem.ToString()
        Controls.Add(btn) : Controls.Add(output)
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
