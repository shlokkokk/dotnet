<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtName = New TextBox()
        btnGreet = New Button()
        lblOutput = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F)
        Label1.Location = New Point(230, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 0
        Label1.Text = "Enter your name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(391, 107)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Type a name"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 1
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(319, 156)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(75, 23)
        btnGreet.TabIndex = 2
        btnGreet.Text = "Greet me"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' lblOutput
        ' 
        lblOutput.AutoSize = True
        lblOutput.Font = New Font("Segoe UI", 15F)
        lblOutput.Location = New Point(230, 233)
        lblOutput.Name = "lblOutput"
        lblOutput.Size = New Size(69, 28)
        lblOutput.TabIndex = 3
        lblOutput.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 457)
        Controls.Add(lblOutput)
        Controls.Add(btnGreet)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnGreet As Button
    Friend WithEvents lblOutput As Label

End Class
