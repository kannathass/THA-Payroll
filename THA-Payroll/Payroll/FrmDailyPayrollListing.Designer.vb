<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDailyPayrollListing
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
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButEdit = New System.Windows.Forms.Button()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButOvertimeEntry = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(23, 180)
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
        Me.ButEdit.Location = New System.Drawing.Point(23, 54)
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
        Me.ButAdd.Location = New System.Drawing.Point(23, 18)
        Me.ButAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(100, 28)
        Me.ButAdd.TabIndex = 2
        Me.ButAdd.Text = "&Add"
        Me.ButAdd.UseVisualStyleBackColor = False
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
        Me.Panel2.Location = New System.Drawing.Point(336, 45)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(154, 266)
        Me.Panel2.TabIndex = 17
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClose.Location = New System.Drawing.Point(23, 216)
        Me.ButClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(100, 28)
        Me.ButClose.TabIndex = 5
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButOvertimeEntry
        '
        Me.ButOvertimeEntry.BackColor = System.Drawing.Color.White
        Me.ButOvertimeEntry.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButOvertimeEntry.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButOvertimeEntry.Location = New System.Drawing.Point(336, 334)
        Me.ButOvertimeEntry.Margin = New System.Windows.Forms.Padding(4)
        Me.ButOvertimeEntry.Name = "ButOvertimeEntry"
        Me.ButOvertimeEntry.Size = New System.Drawing.Size(140, 28)
        Me.ButOvertimeEntry.TabIndex = 6
        Me.ButOvertimeEntry.Text = "&Overtime Entry"
        Me.ButOvertimeEntry.UseVisualStyleBackColor = False
        Me.ButOvertimeEntry.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(35, 60)
        Me.MonthCalendar1.Margin = New System.Windows.Forms.Padding(12, 11, 12, 11)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Button1.Location = New System.Drawing.Point(101, 325)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 28)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "&Permission Entry"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'FrmDailyPayrollListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(537, 380)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButOvertimeEntry)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Panel2)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDailyPayrollListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Payroll List"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButEdit As System.Windows.Forms.Button
    Friend WithEvents ButAdd As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents ButOvertimeEntry As Button
    Friend WithEvents Button1 As Button
End Class
