Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Dim a As New TextBox With {.Location = New Point(120, 30)}
    Dim b As New TextBox With {.Location = New Point(120, 70)}
    Dim op As New ComboBox With {.Location = New Point(120, 110), .Width = 80}
    Dim result As New Label With {.Location = New Point(30, 160), .AutoSize = True}

    Public Sub New()
        Text = "Simple Calculator"
        ClientSize = New Size(380, 220)

        Controls.Add(New Label With {.Text = "First", .Location = New Point(30, 35), .AutoSize = True})
        Controls.Add(New Label With {.Text = "Second", .Location = New Point(30, 75), .AutoSize = True})
        Controls.Add(New Label With {.Text = "Operator", .Location = New Point(30, 115), .AutoSize = True})
        Controls.Add(a) : Controls.Add(b) : Controls.Add(op)
        op.Items.AddRange(New Object() {"+", "-", "*", "/"}) : op.SelectedIndex = 0

        Dim btn As New Button With {.Text = "Calculate", .Location = New Point(220, 108)}
        AddHandler btn.Click, AddressOf Calculate
        Controls.Add(btn) : Controls.Add(result)
    End Sub

    Private Sub Calculate(sender As Object, e As EventArgs)
        Dim x As Double
        Dim y As Double
        If Not Double.TryParse(a.Text, x) OrElse Not Double.TryParse(b.Text, y) Then
            result.Text = "Enter valid numbers"
            Return
        End If
        If op.Text = "/" AndAlso y = 0 Then
            result.Text = "Cannot divide by zero"
            Return
        End If

        Dim r As Double
        Select Case op.Text
            Case "+" : r = x + y
            Case "-" : r = x - y
            Case "*" : r = x * y
            Case "/" : r = x / y
        End Select

        result.Text = "Result = " & r.ToString()
    End Sub
End Class

Module Program
    <STAThread>
    Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub
End Module
