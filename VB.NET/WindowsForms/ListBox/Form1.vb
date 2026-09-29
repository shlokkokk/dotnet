Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Dim list As New ListBox With {.Location = New Point(30, 30), .Width = 150}
    Dim output As New Label With {.Location = New Point(30, 180), .AutoSize = True}

    Public Sub New()
        Text = "ListBox"
        ClientSize = New Size(360, 230)
        list.Items.AddRange(New Object() {"C", "C++", "VB.NET", "C#"})
        Controls.Add(list)

        Dim btn As New Button With {.Text = "Show Selected", .Location = New Point(200, 30)}
        AddHandler btn.Click, Sub()
                                  output.Text = If(list.SelectedItem Is Nothing, "Select an item", "Selected: " & list.SelectedItem.ToString())
                              End Sub
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
