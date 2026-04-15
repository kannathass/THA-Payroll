<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BioPop
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
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButOK = New System.Windows.Forms.Button()
        Me.LBItems = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(176, 373)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(87, 23)
        Me.ButCancel.TabIndex = 4
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButOK
        '
        Me.ButOK.BackColor = System.Drawing.Color.White
        Me.ButOK.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButOK.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButOK.Location = New System.Drawing.Point(66, 373)
        Me.ButOK.Name = "ButOK"
        Me.ButOK.Size = New System.Drawing.Size(87, 23)
        Me.ButOK.TabIndex = 3
        Me.ButOK.Text = "&OK"
        Me.ButOK.UseVisualStyleBackColor = False
        '
        'LBItems
        '
        Me.LBItems.ForeColor = System.Drawing.Color.DarkGreen
        Me.LBItems.FormattingEnabled = True
        Me.LBItems.HorizontalScrollbar = True
        Me.LBItems.ItemHeight = 17
        Me.LBItems.Location = New System.Drawing.Point(3, 48)
        Me.LBItems.Name = "LBItems"
        Me.LBItems.Size = New System.Drawing.Size(343, 310)
        Me.LBItems.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = "Name :"
        '
        'txtItem
        '
        Me.txtItem.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtItem.Location = New System.Drawing.Point(66, 12)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(223, 24)
        Me.txtItem.TabIndex = 1
        '
        'Frm_BioPop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(349, 412)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButOK)
        Me.Controls.Add(Me.LBItems)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BioPop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Employee"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButOK As System.Windows.Forms.Button
    Friend WithEvents LBItems As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
End Class
