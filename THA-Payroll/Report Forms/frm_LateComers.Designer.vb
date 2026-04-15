<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LateComers
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
        Me.DtPayroll = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButLateAttendance = New System.Windows.Forms.Button()
        Me.DtTime = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbDepartment = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPaymentBasis = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'DtPayroll
        '
        Me.DtPayroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPayroll.Location = New System.Drawing.Point(238, 73)
        Me.DtPayroll.Name = "DtPayroll"
        Me.DtPayroll.Size = New System.Drawing.Size(101, 24)
        Me.DtPayroll.TabIndex = 99
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(113, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Daily Payroll Date :"
        '
        'ButLateAttendance
        '
        Me.ButLateAttendance.BackColor = System.Drawing.Color.White
        Me.ButLateAttendance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButLateAttendance.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButLateAttendance.Location = New System.Drawing.Point(238, 167)
        Me.ButLateAttendance.Name = "ButLateAttendance"
        Me.ButLateAttendance.Size = New System.Drawing.Size(169, 23)
        Me.ButLateAttendance.TabIndex = 102
        Me.ButLateAttendance.Text = "Late Comers"
        Me.ButLateAttendance.UseVisualStyleBackColor = False
        '
        'DtTime
        '
        Me.DtTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtTime.Location = New System.Drawing.Point(238, 100)
        Me.DtTime.Name = "DtTime"
        Me.DtTime.ShowUpDown = True
        Me.DtTime.Size = New System.Drawing.Size(101, 24)
        Me.DtTime.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(114, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Card Shown Time :"
        '
        'CmbDepartment
        '
        Me.CmbDepartment.FormattingEnabled = True
        Me.CmbDepartment.Location = New System.Drawing.Point(238, 127)
        Me.CmbDepartment.Name = "CmbDepartment"
        Me.CmbDepartment.Size = New System.Drawing.Size(169, 25)
        Me.CmbDepartment.TabIndex = 105
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(148, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 106
        Me.Label3.Text = "Department :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(134, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 17)
        Me.Label4.TabIndex = 158
        Me.Label4.Text = "Payment Type :"
        '
        'cbPaymentBasis
        '
        Me.cbPaymentBasis.FormattingEnabled = True
        Me.cbPaymentBasis.Items.AddRange(New Object() {"Monthly", "Daily", "Weekly", "Contract"})
        Me.cbPaymentBasis.Location = New System.Drawing.Point(238, 46)
        Me.cbPaymentBasis.Name = "cbPaymentBasis"
        Me.cbPaymentBasis.Size = New System.Drawing.Size(131, 25)
        Me.cbPaymentBasis.TabIndex = 157
        '
        'frm_LateComers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(419, 198)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbPaymentBasis)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbDepartment)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtTime)
        Me.Controls.Add(Me.ButLateAttendance)
        Me.Controls.Add(Me.DtPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_LateComers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Late Comers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtPayroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButLateAttendance As System.Windows.Forms.Button
    Friend WithEvents DtTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbDepartment As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbPaymentBasis As System.Windows.Forms.ComboBox
End Class
