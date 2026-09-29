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
        rdbEasy = New RadioButton()
        rdbMedium = New RadioButton()
        rdbHard = New RadioButton()
        Label1 = New Label()
        lblSelected = New Label()
        SuspendLayout()
        ' 
        ' rdbEasy
        ' 
        rdbEasy.AutoSize = True
        rdbEasy.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdbEasy.Location = New Point(229, 84)
        rdbEasy.Name = "rdbEasy"
        rdbEasy.Size = New Size(57, 24)
        rdbEasy.TabIndex = 0
        rdbEasy.TabStop = True
        rdbEasy.Text = "Easy"
        rdbEasy.UseVisualStyleBackColor = True
        ' 
        ' rdbMedium
        ' 
        rdbMedium.AutoSize = True
        rdbMedium.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdbMedium.Location = New Point(229, 123)
        rdbMedium.Name = "rdbMedium"
        rdbMedium.Size = New Size(84, 24)
        rdbMedium.TabIndex = 1
        rdbMedium.TabStop = True
        rdbMedium.Text = "Medium"
        rdbMedium.UseVisualStyleBackColor = True
        ' 
        ' rdbHard
        ' 
        rdbHard.AutoSize = True
        rdbHard.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        rdbHard.Location = New Point(229, 162)
        rdbHard.Name = "rdbHard"
        rdbHard.Size = New Size(61, 24)
        rdbHard.TabIndex = 2
        rdbHard.TabStop = True
        rdbHard.Text = "Hard"
        rdbHard.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(151, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(155, 25)
        Label1.TabIndex = 3
        Label1.Text = "Select Difficulty:"
        ' 
        ' lblSelected
        ' 
        lblSelected.AutoSize = True
        lblSelected.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblSelected.Location = New Point(163, 199)
        lblSelected.Name = "lblSelected"
        lblSelected.Size = New Size(0, 21)
        lblSelected.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSelected)
        Controls.Add(Label1)
        Controls.Add(rdbHard)
        Controls.Add(rdbMedium)
        Controls.Add(rdbEasy)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rdbEasy As RadioButton
    Friend WithEvents rdbMedium As RadioButton
    Friend WithEvents rdbHard As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSelected As Label

End Class
