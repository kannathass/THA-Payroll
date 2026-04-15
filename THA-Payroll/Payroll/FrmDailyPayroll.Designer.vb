<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDailyPayroll
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.calDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.GVPayroll = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OutTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExtraEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverTimeFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverTimeTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverTimeComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnDutyFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnDutyTo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnDutycomment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LeaveTypeFH = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LeaveFirstHalf = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaveTypeSH = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LeaveSecondHalf = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaveComment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Attendance = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GVPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calDate
        '
        Me.calDate.CustomFormat = ""
        Me.calDate.Enabled = False
        Me.calDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calDate.Location = New System.Drawing.Point(105, 38)
        Me.calDate.Margin = New System.Windows.Forms.Padding(4)
        Me.calDate.Name = "calDate"
        Me.calDate.Size = New System.Drawing.Size(132, 22)
        Me.calDate.TabIndex = 175
        Me.calDate.Value = New Date(2007, 10, 16, 0, 0, 0, 0)
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.BackColor = System.Drawing.Color.PaleGreen
        Me.lblEmpName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmpName.Location = New System.Drawing.Point(17, 42)
        Me.lblEmpName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(61, 17)
        Me.lblEmpName.TabIndex = 174
        Me.lblEmpName.Text = "*Date :"
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(961, 701)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 178
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(853, 701)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 177
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(25, 12)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 261
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(347, 40)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 262
        Me.lblFilter.Text = "Filtered By,"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(451, 36)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(441, 22)
        Me.txtFilter.TabIndex = 263
        '
        'GVPayroll
        '
        Me.GVPayroll.AllowUserToAddRows = False
        Me.GVPayroll.AllowUserToDeleteRows = False
        Me.GVPayroll.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.2!)
        Me.GVPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GVPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.GVPayroll.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.GVPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GVPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GVPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.EmployeeName, Me.InTime, Me.OutTime, Me.ExtraEntry, Me.OverTimeFrom, Me.OverTimeTo, Me.OverTimeComment, Me.PermissionFrom, Me.PermissionTo, Me.PermissionComment, Me.OnDutyFrom, Me.OnDutyTo, Me.OnDutycomment, Me.LeaveTypeFH, Me.LeaveFirstHalf, Me.LeaveTypeSH, Me.LeaveSecondHalf, Me.LeaveComment, Me.Attendance})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GVPayroll.DefaultCellStyle = DataGridViewCellStyle3
        Me.GVPayroll.GridColor = System.Drawing.Color.PaleGreen
        Me.GVPayroll.Location = New System.Drawing.Point(28, 75)
        Me.GVPayroll.Name = "GVPayroll"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GVPayroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GVPayroll.RowHeadersVisible = False
        Me.GVPayroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.GVPayroll.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GVPayroll.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.GVPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.GVPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.GVPayroll.RowTemplate.Height = 24
        Me.GVPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVPayroll.Size = New System.Drawing.Size(1474, 621)
        Me.GVPayroll.TabIndex = 264
        '
        'EmployeeCode
        '
        Me.EmployeeCode.Frozen = True
        Me.EmployeeCode.HeaderText = "Code"
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.ReadOnly = True
        Me.EmployeeCode.Width = 73
        '
        'EmployeeName
        '
        Me.EmployeeName.Frozen = True
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 136
        '
        'InTime
        '
        Me.InTime.Frozen = True
        Me.InTime.HeaderText = "In Time"
        Me.InTime.Name = "InTime"
        Me.InTime.Width = 82
        '
        'OutTime
        '
        Me.OutTime.Frozen = True
        Me.OutTime.HeaderText = "Out Time"
        Me.OutTime.Name = "OutTime"
        Me.OutTime.Width = 93
        '
        'ExtraEntry
        '
        Me.ExtraEntry.HeaderText = "Extra Entry"
        Me.ExtraEntry.Name = "ExtraEntry"
        Me.ExtraEntry.Width = 109
        '
        'OverTimeFrom
        '
        Me.OverTimeFrom.HeaderText = "OT In"
        Me.OverTimeFrom.Name = "OverTimeFrom"
        Me.OverTimeFrom.Width = 58
        '
        'OverTimeTo
        '
        Me.OverTimeTo.HeaderText = "OT Out"
        Me.OverTimeTo.Name = "OverTimeTo"
        Me.OverTimeTo.Width = 82
        '
        'OverTimeComment
        '
        Me.OverTimeComment.HeaderText = "OTComment"
        Me.OverTimeComment.Name = "OverTimeComment"
        Me.OverTimeComment.Visible = False
        Me.OverTimeComment.Width = 125
        '
        'PermissionFrom
        '
        Me.PermissionFrom.HeaderText = "Perm In"
        Me.PermissionFrom.Name = "PermissionFrom"
        Me.PermissionFrom.Width = 72
        '
        'PermissionTo
        '
        Me.PermissionTo.HeaderText = "Perm Out"
        Me.PermissionTo.Name = "PermissionTo"
        Me.PermissionTo.Width = 72
        '
        'PermissionComment
        '
        Me.PermissionComment.HeaderText = "PermComment"
        Me.PermissionComment.Name = "PermissionComment"
        Me.PermissionComment.Visible = False
        Me.PermissionComment.Width = 140
        '
        'OnDutyFrom
        '
        Me.OnDutyFrom.HeaderText = "OD In"
        Me.OnDutyFrom.Name = "OnDutyFrom"
        Me.OnDutyFrom.Width = 60
        '
        'OnDutyTo
        '
        Me.OnDutyTo.HeaderText = "OD Out"
        Me.OnDutyTo.Name = "OnDutyTo"
        Me.OnDutyTo.Width = 83
        '
        'OnDutycomment
        '
        Me.OnDutycomment.HeaderText = "ODComment"
        Me.OnDutycomment.Name = "OnDutycomment"
        Me.OnDutycomment.Visible = False
        Me.OnDutycomment.Width = 127
        '
        'LeaveTypeFH
        '
        Me.LeaveTypeFH.HeaderText = "LT FH"
        Me.LeaveTypeFH.Items.AddRange(New Object() {"", "LV", "CL", "EL", "CO", "WO", "OD"})
        Me.LeaveTypeFH.Name = "LeaveTypeFH"
        Me.LeaveTypeFH.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveTypeFH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LeaveTypeFH.Width = 55
        '
        'LeaveFirstHalf
        '
        Me.LeaveFirstHalf.HeaderText = "FH"
        Me.LeaveFirstHalf.Name = "LeaveFirstHalf"
        Me.LeaveFirstHalf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveFirstHalf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LeaveFirstHalf.Width = 55
        '
        'LeaveTypeSH
        '
        Me.LeaveTypeSH.HeaderText = "LT SH"
        Me.LeaveTypeSH.Items.AddRange(New Object() {"", "LV", "CL", "EL", "CO", "WO", "OD"})
        Me.LeaveTypeSH.Name = "LeaveTypeSH"
        Me.LeaveTypeSH.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveTypeSH.Width = 50
        '
        'LeaveSecondHalf
        '
        Me.LeaveSecondHalf.HeaderText = "SH"
        Me.LeaveSecondHalf.Name = "LeaveSecondHalf"
        Me.LeaveSecondHalf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveSecondHalf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.LeaveSecondHalf.Width = 57
        '
        'LeaveComment
        '
        Me.LeaveComment.HeaderText = "LeaveComment"
        Me.LeaveComment.Name = "LeaveComment"
        Me.LeaveComment.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.LeaveComment.Visible = False
        Me.LeaveComment.Width = 145
        '
        'Attendance
        '
        Me.Attendance.HeaderText = "Attendance"
        Me.Attendance.Name = "Attendance"
        Me.Attendance.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Attendance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Attendance.Text = "View Timings"
        Me.Attendance.UseColumnTextForLinkValue = True
        Me.Attendance.Width = 117
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle6.Format = "HH:MM:ss"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Morning"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.Frozen = True
        Me.DataGridViewTextBoxColumn3.HeaderText = "Evening"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.Frozen = True
        Me.DataGridViewTextBoxColumn4.HeaderText = "OverTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 88
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Format = "HH:MM:ss"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn5.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn6.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn7.HeaderText = "Permission (HH:MM)"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Perm End (HH:MM)"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 169
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "OD Start (HH:MM)"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 165
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "OD End (HH:MM)"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Visible = False
        Me.DataGridViewTextBoxColumn10.Width = 156
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "CO Start (HH:MM)"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 164
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "CO End (HH:MM)"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 155
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn13.HeaderText = "HolidayOverTime (HH:MM)"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 170
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn14.HeaderText = "Permission (HH:MM)"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.Visible = False
        Me.DataGridViewTextBoxColumn14.Width = 130
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "CO To"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 79
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "COComment"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        Me.DataGridViewTextBoxColumn16.Width = 126
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.HeaderText = "Leave Comment"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 150
        '
        'FrmDailyPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1539, 736)
        Me.Controls.Add(Me.GVPayroll)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.calDate)
        Me.Controls.Add(Me.lblEmpName)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmDailyPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Payroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents calDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEmpName As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents GVPayroll As DataGridView
    Friend WithEvents EmployeeCode As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents InTime As DataGridViewTextBoxColumn
    Friend WithEvents OutTime As DataGridViewTextBoxColumn
    Friend WithEvents ExtraEntry As DataGridViewTextBoxColumn
    Friend WithEvents OverTimeFrom As DataGridViewTextBoxColumn
    Friend WithEvents OverTimeTo As DataGridViewTextBoxColumn
    Friend WithEvents OverTimeComment As DataGridViewTextBoxColumn
    Friend WithEvents PermissionFrom As DataGridViewTextBoxColumn
    Friend WithEvents PermissionTo As DataGridViewTextBoxColumn
    Friend WithEvents PermissionComment As DataGridViewTextBoxColumn
    Friend WithEvents OnDutyFrom As DataGridViewTextBoxColumn
    Friend WithEvents OnDutyTo As DataGridViewTextBoxColumn
    Friend WithEvents OnDutycomment As DataGridViewTextBoxColumn
    Friend WithEvents LeaveTypeFH As DataGridViewComboBoxColumn
    Friend WithEvents LeaveFirstHalf As DataGridViewCheckBoxColumn
    Friend WithEvents LeaveTypeSH As DataGridViewComboBoxColumn
    Friend WithEvents LeaveSecondHalf As DataGridViewCheckBoxColumn
    Friend WithEvents LeaveComment As DataGridViewTextBoxColumn
    Friend WithEvents Attendance As DataGridViewLinkColumn
End Class
