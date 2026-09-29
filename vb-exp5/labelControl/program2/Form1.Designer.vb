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
        Label2 = New Label()
        txtName = New TextBox()
        txtNumber = New TextBox()
        btnShow = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(256, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 21)
        Label1.TabIndex = 0
        Label1.Text = "Enter name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(256, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 21)
        Label2.TabIndex = 1
        Label2.Text = "Enter No."
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(351, 87)
        txtName.Name = "txtName"
        txtName.Size = New Size(100, 23)
        txtName.TabIndex = 2
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(351, 142)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(100, 23)
        txtNumber.TabIndex = 3
        ' 
        ' btnShow
        ' 
        btnShow.Font = New Font("Segoe UI", 14F)
        btnShow.Location = New Point(296, 190)
        btnShow.Name = "btnShow"
        btnShow.Size = New Size(121, 64)
        btnShow.TabIndex = 4
        btnShow.Text = "Show Details"
        btnShow.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnShow)
        Controls.Add(txtNumber)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnShow As Button

End Class
