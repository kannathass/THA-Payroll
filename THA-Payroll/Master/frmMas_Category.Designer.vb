<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMas_Category
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
        Me.TrvMisc = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButEdit = New System.Windows.Forms.Button()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrvMisc
        '
        Me.TrvMisc.BackColor = System.Drawing.Color.White
        Me.TrvMisc.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TrvMisc.ForeColor = System.Drawing.Color.DarkGreen
        Me.TrvMisc.Location = New System.Drawing.Point(12, 24)
        Me.TrvMisc.Name = "TrvMisc"
        Me.TrvMisc.Size = New System.Drawing.Size(376, 362)
        Me.TrvMisc.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.ButClose)
        Me.Panel2.Controls.Add(Me.ButDelete)
        Me.Panel2.Controls.Add(Me.ButEdit)
        Me.Panel2.Controls.Add(Me.ButAdd)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Panel2.ForeColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(401, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(94, 362)
        Me.Panel2.TabIndex = 11
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClose.Location = New System.Drawing.Point(3, 327)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(75, 23)
        Me.ButClose.TabIndex = 5
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(3, 298)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButDelete.TabIndex = 4
        Me.ButDelete.Text = "&Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        Me.ButDelete.Visible = False
        '
        'ButEdit
        '
        Me.ButEdit.BackColor = System.Drawing.Color.White
        Me.ButEdit.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButEdit.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButEdit.Location = New System.Drawing.Point(3, 44)
        Me.ButEdit.Name = "ButEdit"
        Me.ButEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButEdit.TabIndex = 3
        Me.ButEdit.Text = "&Edit"
        Me.ButEdit.UseVisualStyleBackColor = False
        '
        'ButAdd
        '
        Me.ButAdd.BackColor = System.Drawing.Color.White
        Me.ButAdd.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButAdd.Location = New System.Drawing.Point(3, 15)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(75, 23)
        Me.ButAdd.TabIndex = 2
        Me.ButAdd.Text = "&Add"
        Me.ButAdd.UseVisualStyleBackColor = False
        '
        'frmMas_Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(507, 405)
        Me.Controls.Add(Me.TrvMisc)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMas_Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Department and Category Management"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TrvMisc As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButEdit As System.Windows.Forms.Button
    Friend WithEvents ButAdd As System.Windows.Forms.Button
End Class
