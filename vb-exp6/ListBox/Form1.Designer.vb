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
        lstItems = New ListBox()
        btnShowSelected = New Button()
        lblResult = New Label()
        btnAdd = New Button()
        btnRemove = New Button()
        btnClear = New Button()
        txtNewItem = New TextBox()
        lblTotal = New Label()
        btnTotal = New Button()
        SuspendLayout()
        ' 
        ' lstItems
        ' 
        lstItems.FormattingEnabled = True
        lstItems.Location = New Point(260, 70)
        lstItems.Name = "lstItems"
        lstItems.Size = New Size(120, 94)
        lstItems.TabIndex = 0
        ' 
        ' btnShowSelected
        ' 
        btnShowSelected.Location = New Point(417, 80)
        btnShowSelected.Name = "btnShowSelected"
        btnShowSelected.Size = New Size(99, 23)
        btnShowSelected.TabIndex = 1
        btnShowSelected.Text = "Show Selected"
        btnShowSelected.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(522, 86)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(48, 17)
        lblResult.TabIndex = 2
        lblResult.Text = "Result:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(232, 264)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add Item"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(226, 192)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(75, 38)
        btnRemove.TabIndex = 4
        btnRemove.Text = "Remove Selected"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(347, 192)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 38)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear All"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtNewItem
        ' 
        txtNewItem.Location = New Point(313, 264)
        txtNewItem.Name = "txtNewItem"
        txtNewItem.Size = New Size(100, 23)
        txtNewItem.TabIndex = 6
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(522, 129)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(41, 17)
        lblTotal.TabIndex = 7
        lblTotal.Text = "Total:"
        ' 
        ' btnTotal
        ' 
        btnTotal.Location = New Point(417, 127)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(99, 23)
        btnTotal.TabIndex = 8
        btnTotal.Text = "Show Total"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTotal)
        Controls.Add(lblTotal)
        Controls.Add(txtNewItem)
        Controls.Add(btnClear)
        Controls.Add(btnRemove)
        Controls.Add(btnAdd)
        Controls.Add(lblResult)
        Controls.Add(btnShowSelected)
        Controls.Add(lstItems)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstItems As ListBox
    Friend WithEvents btnShowSelected As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtNewItem As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnTotal As Button

End Class
