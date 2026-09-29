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
        txtNum1 = New TextBox()
        txtNum2 = New TextBox()
        btnAdd = New Button()
        btnSub = New Button()
        btnMult = New Button()
        btnDiv = New Button()
        lblResult = New Label()
        btnReset = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(239, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 0
        Label1.Text = "Number 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(239, 112)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 21)
        Label2.TabIndex = 1
        Label2.Text = "Number 2:"
        ' 
        ' txtNum1
        ' 
        txtNum1.Location = New Point(335, 68)
        txtNum1.Name = "txtNum1"
        txtNum1.Size = New Size(100, 23)
        txtNum1.TabIndex = 2
        ' 
        ' txtNum2
        ' 
        txtNum2.Location = New Point(335, 112)
        txtNum2.Name = "txtNum2"
        txtNum2.Size = New Size(100, 23)
        txtNum2.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(160, 165)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSub
        ' 
        btnSub.Location = New Point(267, 165)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(75, 23)
        btnSub.TabIndex = 5
        btnSub.Text = "Subtract"
        btnSub.UseVisualStyleBackColor = True
        ' 
        ' btnMult
        ' 
        btnMult.Location = New Point(376, 165)
        btnMult.Name = "btnMult"
        btnMult.Size = New Size(75, 23)
        btnMult.TabIndex = 6
        btnMult.Text = "Multiply"
        btnMult.UseVisualStyleBackColor = True
        ' 
        ' btnDiv
        ' 
        btnDiv.Location = New Point(480, 165)
        btnDiv.Name = "btnDiv"
        btnDiv.Size = New Size(75, 23)
        btnDiv.TabIndex = 7
        btnDiv.Text = "Divide"
        btnDiv.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(272, 236)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(70, 25)
        lblResult.TabIndex = 8
        lblResult.Text = "Result:"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(670, 24)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(75, 23)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnReset)
        Controls.Add(lblResult)
        Controls.Add(btnDiv)
        Controls.Add(btnMult)
        Controls.Add(btnSub)
        Controls.Add(btnAdd)
        Controls.Add(txtNum2)
        Controls.Add(txtNum1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button

    Friend WithEvents lblResult As Label
    Friend WithEvents btnReset As Button
End Class
