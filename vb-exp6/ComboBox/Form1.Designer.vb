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
        cboItems = New ComboBox()
        btnShowChoice = New Button()
        lblChosen = New Label()
        SuspendLayout()
        ' 
        ' cboItems
        ' 
        cboItems.DropDownStyle = ComboBoxStyle.DropDownList
        cboItems.FormattingEnabled = True
        cboItems.Location = New Point(271, 125)
        cboItems.Name = "cboItems"
        cboItems.Size = New Size(121, 23)
        cboItems.TabIndex = 0
        ' 
        ' btnShowChoice
        ' 
        btnShowChoice.Location = New Point(419, 125)
        btnShowChoice.Name = "btnShowChoice"
        btnShowChoice.Size = New Size(75, 42)
        btnShowChoice.TabIndex = 1
        btnShowChoice.Text = "Show Choice"
        btnShowChoice.UseVisualStyleBackColor = True
        ' 
        ' lblChosen
        ' 
        lblChosen.AutoSize = True
        lblChosen.Font = New Font("Segoe UI Historic", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblChosen.Location = New Point(427, 187)
        lblChosen.Name = "lblChosen"
        lblChosen.Size = New Size(0, 20)
        lblChosen.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblChosen)
        Controls.Add(btnShowChoice)
        Controls.Add(cboItems)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cboItems As ComboBox
    Friend WithEvents btnShowChoice As Button
    Friend WithEvents lblChosen As Label

End Class
