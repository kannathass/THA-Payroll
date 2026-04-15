<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOverTimeEntry
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.DGVDailyPayroll = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FromHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.calDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVDailyPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(116, 46)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(441, 22)
        Me.txtFilter.TabIndex = 271
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(12, 50)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 270
        Me.lblFilter.Text = "Filtered By,"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(52, 9)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 269
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(467, 680)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 268
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(359, 680)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 267
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'DGVDailyPayroll
        '
        Me.DGVDailyPayroll.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVDailyPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DGVDailyPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVDailyPayroll.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVDailyPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDailyPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVDailyPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDailyPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.EmployeeName, Me.FromHours, Me.ToHours, Me.SNo})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDailyPayroll.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGVDailyPayroll.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVDailyPayroll.Location = New System.Drawing.Point(40, 124)
        Me.DGVDailyPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVDailyPayroll.Name = "DGVDailyPayroll"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDailyPayroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DGVDailyPayroll.RowHeadersVisible = False
        Me.DGVDailyPayroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDailyPayroll.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVDailyPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDailyPayroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVDailyPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDailyPayroll.Size = New System.Drawing.Size(706, 540)
        Me.DGVDailyPayroll.TabIndex = 266
        '
        'EmployeeCode
        '
        Me.EmployeeCode.HeaderText = "EmployeeCode"
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.Width = 140
        '
        'EmployeeName
        '
        DataGridViewCellStyle13.NullValue = Nothing
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle13
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Width = 148
        '
        'FromHours
        '
        Me.FromHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.FromHours.HeaderText = "From (HH:MM)"
        Me.FromHours.Name = "FromHours"
        Me.FromHours.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FromHours.Width = 130
        '
        'ToHours
        '
        Me.ToHours.HeaderText = "To (HH:MM)"
        Me.ToHours.Name = "ToHours"
        Me.ToHours.Width = 118
        '
        'SNo
        '
        Me.SNo.HeaderText = "SNo"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 66
        '
        'calDate
        '
        Me.calDate.CustomFormat = ""
        Me.calDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calDate.Location = New System.Drawing.Point(132, 81)
        Me.calDate.Margin = New System.Windows.Forms.Padding(4)
        Me.calDate.Name = "calDate"
        Me.calDate.Size = New System.Drawing.Size(132, 22)
        Me.calDate.TabIndex = 265
        Me.calDate.Value = New Date(2007, 10, 16, 0, 0, 0, 0)
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.BackColor = System.Drawing.Color.PaleGreen
        Me.lblEmpName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmpName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmpName.Location = New System.Drawing.Point(44, 85)
        Me.lblEmpName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(61, 17)
        Me.lblEmpName.TabIndex = 264
        Me.lblEmpName.Text = "*Date :"
        '
        'DataGridViewTextBoxColumn1
        '
        DataGridViewCellStyle17.Format = "HH:MM:ss"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.HeaderText = "Morning"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 77
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle19.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn3.HeaderText = "Evening"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 77
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.HeaderText = "OverTime"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 88
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 130
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle20.Format = "HH:MM:ss"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn5.HeaderText = "HolidayOverTime"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 130
        '
        'FrmOverTimeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 727)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.DGVDailyPayroll)
        Me.Controls.Add(Me.calDate)
        Me.Controls.Add(Me.lblEmpName)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOverTimeEntry"
        Me.Text = "FrmOverTimeEntry"
        Me.TopMost = True
        CType(Me.DGVDailyPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFilter As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents lblFilter As Label
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents ButCancel As Button
    Friend WithEvents ButSave As Button
    Friend WithEvents DGVDailyPayroll As DataGridView
    Public WithEvents calDate As DateTimePicker
    Friend WithEvents lblEmpName As Label
    Friend WithEvents EmployeeCode As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents FromHours As DataGridViewTextBoxColumn
    Friend WithEvents ToHours As DataGridViewTextBoxColumn
    Friend WithEvents SNo As DataGridViewTextBoxColumn
End Class
