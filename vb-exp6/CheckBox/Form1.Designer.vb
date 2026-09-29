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
        chkReading = New CheckBox()
        chkMusic = New CheckBox()
        chkSports = New CheckBox()
        btnShowHobbies = New Button()
        lblResult = New Label()
        Label2 = New Label()
        chkGaming = New CheckBox()
        SuspendLayout()
        ' 
        ' chkReading
        ' 
        chkReading.AutoSize = True
        chkReading.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkReading.Location = New Point(423, 85)
        chkReading.Name = "chkReading"
        chkReading.Size = New Size(84, 24)
        chkReading.TabIndex = 0
        chkReading.Text = "Reading"
        chkReading.UseVisualStyleBackColor = True
        ' 
        ' chkMusic
        ' 
        chkMusic.AutoSize = True
        chkMusic.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkMusic.Location = New Point(423, 115)
        chkMusic.Name = "chkMusic"
        chkMusic.Size = New Size(68, 24)
        chkMusic.TabIndex = 1
        chkMusic.Text = "Music"
        chkMusic.UseVisualStyleBackColor = True
        ' 
        ' chkSports
        ' 
        chkSports.AutoSize = True
        chkSports.Checked = True
        chkSports.CheckState = CheckState.Checked
        chkSports.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkSports.Location = New Point(423, 145)
        chkSports.Name = "chkSports"
        chkSports.Size = New Size(71, 24)
        chkSports.TabIndex = 2
        chkSports.Text = "Sports"
        chkSports.UseVisualStyleBackColor = True
        ' 
        ' btnShowHobbies
        ' 
        btnShowHobbies.Font = New Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnShowHobbies.Location = New Point(297, 221)
        btnShowHobbies.Name = "btnShowHobbies"
        btnShowHobbies.Size = New Size(110, 23)
        btnShowHobbies.TabIndex = 3
        btnShowHobbies.Text = "Show Checked"
        btnShowHobbies.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(423, 224)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(0, 21)
        lblResult.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(174, 76)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 32)
        Label2.TabIndex = 5
        Label2.Text = "Select your hobbies:"
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chkGaming.Location = New Point(423, 175)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(81, 24)
        chkGaming.TabIndex = 6
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(chkGaming)
        Controls.Add(Label2)
        Controls.Add(lblResult)
        Controls.Add(btnShowHobbies)
        Controls.Add(chkSports)
        Controls.Add(chkMusic)
        Controls.Add(chkReading)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkReading As CheckBox
    Friend WithEvents chkMusic As CheckBox
    Friend WithEvents chkSports As CheckBox
    Friend WithEvents btnShowHobbies As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chkGaming As CheckBox

End Class
