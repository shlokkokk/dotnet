Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Dim txtName As New TextBox With {.Location = New Point(130, 30)}
    Dim txtNumber As New TextBox With {.Location = New Point(130, 70)}
    Dim lblResult As New Label With {.Location = New Point(30, 150), .AutoSize = True}

    Public Sub New()
        Text = "User Details"
        ClientSize = New Size(420, 230)

        Controls.Add(New Label With {.Text = "Name", .Location = New Point(30, 35), .AutoSize = True})
        Controls.Add(New Label With {.Text = "Number", .Location = New Point(30, 75), .AutoSize = True})
        Controls.Add(txtName) : Controls.Add(txtNumber)

        Dim btn As New Button With {.Text = "Show Details", .Location = New Point(130, 110)}
        AddHandler btn.Click, Sub()
                                  MessageBox.Show($"Name: {txtName.Text}{Environment.NewLine}Number: {txtNumber.Text}")
                              End Sub
        Controls.Add(btn)
        Controls.Add(lblResult)
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
