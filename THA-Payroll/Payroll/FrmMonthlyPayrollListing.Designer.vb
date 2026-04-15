<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonthlyPayrollListing
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
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButEdit = New System.Windows.Forms.Button()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbYear
        '
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(127, 146)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(160, 24)
        Me.cmbYear.TabIndex = 189
        '
        'cmbMonth
        '
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Select", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(127, 105)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(160, 24)
        Me.cmbMonth.TabIndex = 188
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.PaleGreen
        Me.lblyear.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblyear.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblyear.Location = New System.Drawing.Point(23, 150)
        Me.lblyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(58, 17)
        Me.lblyear.TabIndex = 187
        Me.lblyear.Text = "*Year :"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.PaleGreen
        Me.lblMonth.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMonth.Location = New System.Drawing.Point(23, 108)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(72, 17)
        Me.lblMonth.TabIndex = 186
        Me.lblMonth.Text = "*Month :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.ButClose)
        Me.Panel2.Controls.Add(Me.ButDelete)
        Me.Panel2.Controls.Add(Me.ButEdit)
        Me.Panel2.Controls.Add(Me.ButAdd)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(321, 34)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 223)
        Me.Panel2.TabIndex = 190
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClose.Location = New System.Drawing.Point(4, 175)
        Me.ButClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(100, 28)
        Me.ButClose.TabIndex = 5
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(4, 139)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(100, 28)
        Me.ButDelete.TabIndex = 4
        Me.ButDelete.Text = "&Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'ButEdit
        '
        Me.ButEdit.BackColor = System.Drawing.Color.White
        Me.ButEdit.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButEdit.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButEdit.Location = New System.Drawing.Point(4, 54)
        Me.ButEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButEdit.Name = "ButEdit"
        Me.ButEdit.Size = New System.Drawing.Size(100, 28)
        Me.ButEdit.TabIndex = 3
        Me.ButEdit.Text = "&Edit"
        Me.ButEdit.UseVisualStyleBackColor = False
        '
        'ButAdd
        '
        Me.ButAdd.BackColor = System.Drawing.Color.White
        Me.ButAdd.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButAdd.Location = New System.Drawing.Point(4, 18)
        Me.ButAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(100, 28)
        Me.ButAdd.TabIndex = 2
        Me.ButAdd.Text = "&Add"
        Me.ButAdd.UseVisualStyleBackColor = False
        '
        'FrmMonthlyPayrollListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(457, 295)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.lblMonth)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonthlyPayrollListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Payroll List"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents lblyear As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButEdit As System.Windows.Forms.Button
    Friend WithEvents ButAdd As System.Windows.Forms.Button
End Class
