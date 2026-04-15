<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmWeeklyAttendanceProcess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Me.ButProcess = New System.Windows.Forms.Button()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.DtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButProcess
        '
        Me.ButProcess.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ButProcess.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButProcess.Location = New System.Drawing.Point(512, 44)
        Me.ButProcess.Name = "ButProcess"
        Me.ButProcess.Size = New System.Drawing.Size(255, 28)
        Me.ButProcess.TabIndex = 1
        Me.ButProcess.Text = "Process Daily Attendance"
        Me.ButProcess.UseVisualStyleBackColor = False
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(651, 297)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(116, 23)
        Me.ButCancel.TabIndex = 2
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 17)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Start Date"
        '
        'DtStartDate
        '
        Me.DtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtStartDate.Location = New System.Drawing.Point(126, 45)
        Me.DtStartDate.Name = "DtStartDate"
        Me.DtStartDate.Size = New System.Drawing.Size(120, 22)
        Me.DtStartDate.TabIndex = 100
        '
        'DtEndDate
        '
        Me.DtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtEndDate.Location = New System.Drawing.Point(353, 45)
        Me.DtEndDate.Name = "DtEndDate"
        Me.DtEndDate.Size = New System.Drawing.Size(120, 22)
        Me.DtEndDate.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(273, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "End Date"
        '
        'cmbYear
        '
        Me.cmbYear.Enabled = False
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(352, 110)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 114
        '
        'cmbMonth
        '
        Me.cmbMonth.Enabled = False
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(123, 110)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 24)
        Me.cmbMonth.TabIndex = 113
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = "Year"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Payroll Month"
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(518, 110)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(255, 28)
        Me.ButGenerate.TabIndex = 117
        Me.ButGenerate.Text = "Process Payslip"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'FrmWeeklyAttendanceProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(812, 332)
        Me.Controls.Add(Me.ButGenerate)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtEndDate)
        Me.Controls.Add(Me.DtStartDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButProcess)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWeeklyAttendanceProcess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Process"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButProcess As Button
    Friend WithEvents ButCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DtStartDate As DateTimePicker
    Friend WithEvents DtEndDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButGenerate As Button
End Class
