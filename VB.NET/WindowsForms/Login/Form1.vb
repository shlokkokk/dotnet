Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Dim userBox As New TextBox With {.Location = New Point(130, 35)}
    Dim passBox As New TextBox With {.Location = New Point(130, 75), .UseSystemPasswordChar = True}

    Public Sub New()
        Text = "Login"
        ClientSize = New Size(360, 190)

        Controls.Add(New Label With {.Text = "Username", .Location = New Point(30, 40), .AutoSize = True})
        Controls.Add(New Label With {.Text = "Password", .Location = New Point(30, 80), .AutoSize = True})
        Controls.Add(userBox) : Controls.Add(passBox)

        Dim btn As New Button With {.Text = "Login", .Location = New Point(130, 120)}
        AddHandler btn.Click, Sub()
                                  If userBox.Text = "admin" AndAlso passBox.Text = "1234" Then
                                      MessageBox.Show("Login Successful")
                                  Else
                                      MessageBox.Show("Invalid Login")
                                  End If
                              End Sub
        Controls.Add(btn)
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
