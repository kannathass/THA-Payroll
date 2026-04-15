<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveEntry
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.DGVDailyPayroll = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstHalf = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaveTypeFirstHalf = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.SecondHalf = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LeaveTypeSecondHalf = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        CType(Me.DGVDailyPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Format = "HH:MM:ss"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn5.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "OverTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 88
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn3.HeaderText = "Evening"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "Morning"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle4.Format = "HH:MM:ss"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'calDate
        '
        Me.calDate.CustomFormat = ""
        Me.calDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calDate.Location = New System.Drawing.Point(133, 100)
        Me.calDate.Margin = New System.Windows.Forms.Padding(4)
        Me.calDate.Name = "calDate"
        Me.calDate.Size = New System.Drawing.Size(132, 22)
        Me.calDate.TabIndex = 273
        Me.calDate.Value = New Date(2007, 10, 16, 0, 0, 0, 0)
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.BackColor = System.Drawing.Color.PaleGreen
        Me.lblEmpName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmpName.Location = New System.Drawing.Point(45, 104)
        Me.lblEmpName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(61, 17)
        Me.lblEmpName.TabIndex = 272
        Me.lblEmpName.Text = "*Date :"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(13, 69)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 278
        Me.lblFilter.Text = "Filtered By,"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(53, 28)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 277
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(468, 699)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 276
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(360, 699)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 275
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'DGVDailyPayroll
        '
        Me.DGVDailyPayroll.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVDailyPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVDailyPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVDailyPayroll.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVDailyPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDailyPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVDailyPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDailyPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.EmployeeName, Me.FirstHalf, Me.LeaveTypeFirstHalf, Me.SecondHalf, Me.LeaveTypeSecondHalf})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDailyPayroll.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVDailyPayroll.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVDailyPayroll.Location = New System.Drawing.Point(41, 144)
        Me.DGVDailyPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVDailyPayroll.Name = "DGVDailyPayroll"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDailyPayroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVDailyPayroll.RowHeadersVisible = False
        Me.DGVDailyPayroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDailyPayroll.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDailyPayroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVDailyPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDailyPayroll.Size = New System.Drawing.Size(744, 540)
        Me.DGVDailyPayroll.TabIndex = 274
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
        DataGridViewCellStyle7.NullValue = Nothing
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle7
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 148
        '
        'FirstHalf
        '
        Me.FirstHalf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FirstHalf.HeaderText = "First Half"
        Me.FirstHalf.Name = "FirstHalf"
        Me.FirstHalf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FirstHalf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.FirstHalf.Width = 130
        '
        'LeaveTypeFirstHalf
        '
        Me.LeaveTypeFirstHalf.HeaderText = "Leave Type"
        Me.LeaveTypeFirstHalf.Items.AddRange(New Object() {"EL", "CL"})
        Me.LeaveTypeFirstHalf.Name = "LeaveTypeFirstHalf"
        Me.LeaveTypeFirstHalf.Width = 92
        '
        'SecondHalf
        '
        Me.SecondHalf.HeaderText = "Second Half"
        Me.SecondHalf.Name = "SecondHalf"
        Me.SecondHalf.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SecondHalf.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.SecondHalf.Width = 120
        '
        'LeaveTypeSecondHalf
        '
        Me.LeaveTypeSecondHalf.HeaderText = "Leave Type"
        Me.LeaveTypeSecondHalf.Items.AddRange(New Object() {"EL", "CL"})
        Me.LeaveTypeSecondHalf.Name = "LeaveTypeSecondHalf"
        Me.LeaveTypeSecondHalf.Width = 92
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(117, 65)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(441, 22)
        Me.txtFilter.TabIndex = 279
        '
        'FrmLeaveEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(830, 754)
        Me.Controls.Add(Me.calDate)
        Me.Controls.Add(Me.lblEmpName)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.DGVDailyPayroll)
        Me.Controls.Add(Me.txtFilter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLeaveEntry"
        Me.Text = "FrmLeaveEntry"
        Me.TopMost = True
        CType(Me.DGVDailyPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Public WithEvents calDate As DateTimePicker
    Friend WithEvents lblEmpName As Label
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents ButCancel As Button
    Friend WithEvents ButSave As Button
    Friend WithEvents DGVDailyPayroll As DataGridView
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents EmployeeCode As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents FirstHalf As DataGridViewCheckBoxColumn
    Friend WithEvents LeaveTypeFirstHalf As DataGridViewComboBoxColumn
    Friend WithEvents SecondHalf As DataGridViewCheckBoxColumn
    Friend WithEvents LeaveTypeSecondHalf As DataGridViewComboBoxColumn
End Class
