<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Category
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.tbProcessDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBProcessName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(145, 14)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 17)
        Me.LabelError.TabIndex = 176
        Me.LabelError.Visible = False
        '
        'tbProcessDesc
        '
        Me.tbProcessDesc.BackColor = System.Drawing.Color.White
        Me.tbProcessDesc.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbProcessDesc.Location = New System.Drawing.Point(197, 65)
        Me.tbProcessDesc.Multiline = True
        Me.tbProcessDesc.Name = "tbProcessDesc"
        Me.tbProcessDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbProcessDesc.Size = New System.Drawing.Size(143, 51)
        Me.tbProcessDesc.TabIndex = 171
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(51, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 14)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Category Description :"
        '
        'TBProcessName
        '
        Me.TBProcessName.BackColor = System.Drawing.Color.White
        Me.TBProcessName.ForeColor = System.Drawing.Color.DarkGreen
        Me.TBProcessName.Location = New System.Drawing.Point(197, 33)
        Me.TBProcessName.Name = "TBProcessName"
        Me.TBProcessName.Size = New System.Drawing.Size(143, 24)
        Me.TBProcessName.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 17)
        Me.Label2.TabIndex = 174
        Me.Label2.Text = "*Category Name :"
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.FlatAppearance.BorderSize = 0
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClose.Location = New System.Drawing.Point(212, 150)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(101, 23)
        Me.ButClose.TabIndex = 173
        Me.ButClose.Text = "&Cancel"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.FlatAppearance.BorderSize = 0
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButSave.Location = New System.Drawing.Point(104, 150)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(101, 23)
        Me.ButSave.TabIndex = 172
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'Frm_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(388, 191)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.tbProcessDesc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBProcessName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.ButSave)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents tbProcessDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TBProcessName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButSave As System.Windows.Forms.Button
End Class
