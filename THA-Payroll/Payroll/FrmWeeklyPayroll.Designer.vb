<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWeeklyPayroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtAllowedDays = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.DGVPayroll = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkedDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Holidays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ELDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPayableDays = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OTHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButLoad = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButProcessPayroll = New System.Windows.Forms.Button()
        CType(Me.DGVPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAllowedDays
        '
        Me.txtAllowedDays.Location = New System.Drawing.Point(718, 73)
        Me.txtAllowedDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAllowedDays.MaxLength = 2
        Me.txtAllowedDays.Name = "txtAllowedDays"
        Me.txtAllowedDays.Size = New System.Drawing.Size(166, 22)
        Me.txtAllowedDays.TabIndex = 279
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(597, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 278
        Me.Label1.Text = "Allowed Days"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(127, 75)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(441, 22)
        Me.txtFilter.TabIndex = 277
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(31, 78)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 276
        Me.lblFilter.Text = "Filtered By,"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(61, 14)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 275
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(948, 697)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 269
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'DGVPayroll
        '
        Me.DGVPayroll.AllowUserToAddRows = False
        Me.DGVPayroll.AllowUserToDeleteRows = False
        Me.DGVPayroll.AllowUserToResizeRows = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVPayroll.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.EmployeeName, Me.WorkedDays, Me.Holidays, Me.CLDays, Me.ELDays, Me.TotalPayableDays, Me.OTHours, Me.PermissionHours})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPayroll.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGVPayroll.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVPayroll.Location = New System.Drawing.Point(13, 109)
        Me.DGVPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPayroll.Name = "DGVPayroll"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPayroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVPayroll.RowHeadersVisible = False
        Me.DGVPayroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVPayroll.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPayroll.Size = New System.Drawing.Size(1534, 575)
        Me.DGVPayroll.TabIndex = 268
        '
        'EmployeeCode
        '
        Me.EmployeeCode.HeaderText = "Employee Code"
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.ReadOnly = True
        Me.EmployeeCode.Width = 145
        '
        'EmployeeName
        '
        DataGridViewCellStyle10.NullValue = Nothing
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle10
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 148
        '
        'WorkedDays
        '
        Me.WorkedDays.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.WorkedDays.HeaderText = "Worked Days"
        Me.WorkedDays.Name = "WorkedDays"
        Me.WorkedDays.ReadOnly = True
        Me.WorkedDays.Width = 130
        '
        'Holidays
        '
        Me.Holidays.HeaderText = "Holidays"
        Me.Holidays.Name = "Holidays"
        Me.Holidays.Width = 95
        '
        'CLDays
        '
        Me.CLDays.HeaderText = "CL Days"
        Me.CLDays.Name = "CLDays"
        Me.CLDays.ReadOnly = True
        Me.CLDays.Width = 95
        '
        'ELDays
        '
        Me.ELDays.HeaderText = "EL Days"
        Me.ELDays.Name = "ELDays"
        Me.ELDays.ReadOnly = True
        Me.ELDays.Width = 94
        '
        'TotalPayableDays
        '
        Me.TotalPayableDays.HeaderText = "Payable Days"
        Me.TotalPayableDays.Name = "TotalPayableDays"
        Me.TotalPayableDays.ReadOnly = True
        Me.TotalPayableDays.Width = 129
        '
        'OTHours
        '
        Me.OTHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.OTHours.HeaderText = "OT Hours"
        Me.OTHours.Name = "OTHours"
        Me.OTHours.ReadOnly = True
        Me.OTHours.Width = 110
        '
        'PermissionHours
        '
        Me.PermissionHours.HeaderText = "Perm Hours"
        Me.PermissionHours.Name = "PermissionHours"
        Me.PermissionHours.ReadOnly = True
        Me.PermissionHours.Width = 119
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(1056, 697)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 270
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(258, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "To Date"
        '
        'DtEndDate
        '
        Me.DtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtEndDate.Location = New System.Drawing.Point(333, 37)
        Me.DtEndDate.Name = "DtEndDate"
        Me.DtEndDate.Size = New System.Drawing.Size(120, 22)
        Me.DtEndDate.TabIndex = 282
        '
        'DtStartDate
        '
        Me.DtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtStartDate.Location = New System.Drawing.Point(126, 37)
        Me.DtStartDate.Name = "DtStartDate"
        Me.DtStartDate.Size = New System.Drawing.Size(120, 22)
        Me.DtStartDate.TabIndex = 281
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(32, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "From Date"
        '
        'ButLoad
        '
        Me.ButLoad.BackColor = System.Drawing.Color.White
        Me.ButLoad.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButLoad.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButLoad.Location = New System.Drawing.Point(468, 34)
        Me.ButLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.ButLoad.Name = "ButLoad"
        Me.ButLoad.Size = New System.Drawing.Size(100, 28)
        Me.ButLoad.TabIndex = 284
        Me.ButLoad.Text = "&Load"
        Me.ButLoad.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(42, 697)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(100, 28)
        Me.ButDelete.TabIndex = 285
        Me.ButDelete.Text = "&Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMessage.Location = New System.Drawing.Point(614, 34)
        Me.lblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblMessage.TabIndex = 286
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 122
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.HeaderText = "No Of Days Worked"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 145
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "OverTime Hours"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Holiday OverTime Hours"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 171
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "EL Days"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 94
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Payable Days"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 129
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn8.HeaderText = "OT Hours"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 110
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Perm Hours"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 119
        '
        'ButProcessPayroll
        '
        Me.ButProcessPayroll.BackColor = System.Drawing.Color.PaleVioletRed
        Me.ButProcessPayroll.Enabled = False
        Me.ButProcessPayroll.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButProcessPayroll.Location = New System.Drawing.Point(484, 691)
        Me.ButProcessPayroll.Name = "ButProcessPayroll"
        Me.ButProcessPayroll.Size = New System.Drawing.Size(249, 34)
        Me.ButProcessPayroll.TabIndex = 287
        Me.ButProcessPayroll.Text = "Process Payroll"
        Me.ButProcessPayroll.UseVisualStyleBackColor = False
        '
        'FrmWeeklyPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1580, 730)
        Me.Controls.Add(Me.ButProcessPayroll)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.ButLoad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtEndDate)
        Me.Controls.Add(Me.DtStartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAllowedDays)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.DGVPayroll)
        Me.Controls.Add(Me.ButCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmWeeklyPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Weekly Payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGVPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtAllowedDays As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents PermissionHours As DataGridViewTextBoxColumn
    Friend WithEvents OTHours As DataGridViewTextBoxColumn
    Friend WithEvents TotalPayableDays As DataGridViewTextBoxColumn
    Friend WithEvents ELDays As DataGridViewTextBoxColumn
    Friend WithEvents CLDays As DataGridViewTextBoxColumn
    Friend WithEvents Holidays As DataGridViewTextBoxColumn
    Friend WithEvents WorkedDays As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCode As DataGridViewTextBoxColumn
    Friend WithEvents ButSave As Button
    Friend WithEvents DGVPayroll As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ButCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DtEndDate As DateTimePicker
    Friend WithEvents DtStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ButLoad As Button
    Friend WithEvents ButDelete As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents ButProcessPayroll As Button
End Class
