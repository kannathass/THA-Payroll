<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSetShiftTimings
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbDptName = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpANCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpANCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.dtpFNCheckOut = New System.Windows.Forms.DateTimePicker()
        Me.dtpFNCheckin = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DGVShiftTimings = New System.Windows.Forms.DataGridView()
        Me.ShowTimings = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ButUpdate = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGVShiftTimings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDptName
        '
        Me.cmbDptName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDptName.FormattingEnabled = True
        Me.cmbDptName.Location = New System.Drawing.Point(345, 49)
        Me.cmbDptName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbDptName.Name = "cmbDptName"
        Me.cmbDptName.Size = New System.Drawing.Size(263, 24)
        Me.cmbDptName.TabIndex = 205
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDepartment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDepartment.Location = New System.Drawing.Point(225, 53)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(103, 17)
        Me.lblDepartment.TabIndex = 204
        Me.lblDepartment.Text = "Department :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.PaleGreen
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label16.Location = New System.Drawing.Point(476, 100)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(103, 17)
        Me.Label16.TabIndex = 289
        Me.Label16.Text = "After Noon :-"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.PaleGreen
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(43, 101)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 17)
        Me.Label15.TabIndex = 288
        Me.Label15.Text = "Fore Noon :-"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PaleGreen
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(539, 122)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 17)
        Me.Label11.TabIndex = 287
        Me.Label11.Text = "Check In :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.PaleGreen
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label12.Location = New System.Drawing.Point(528, 150)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 286
        Me.Label12.Text = "Check Out :"
        '
        'dtpANCheckOut
        '
        Me.dtpANCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpANCheckOut.Location = New System.Drawing.Point(637, 150)
        Me.dtpANCheckOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpANCheckOut.Name = "dtpANCheckOut"
        Me.dtpANCheckOut.ShowUpDown = True
        Me.dtpANCheckOut.Size = New System.Drawing.Size(135, 22)
        Me.dtpANCheckOut.TabIndex = 285
        '
        'dtpANCheckIn
        '
        Me.dtpANCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpANCheckIn.Location = New System.Drawing.Point(637, 117)
        Me.dtpANCheckIn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpANCheckIn.Name = "dtpANCheckIn"
        Me.dtpANCheckIn.ShowUpDown = True
        Me.dtpANCheckIn.Size = New System.Drawing.Size(135, 22)
        Me.dtpANCheckIn.TabIndex = 284
        '
        'dtpFNCheckOut
        '
        Me.dtpFNCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFNCheckOut.Location = New System.Drawing.Point(200, 150)
        Me.dtpFNCheckOut.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFNCheckOut.Name = "dtpFNCheckOut"
        Me.dtpFNCheckOut.ShowUpDown = True
        Me.dtpFNCheckOut.Size = New System.Drawing.Size(135, 22)
        Me.dtpFNCheckOut.TabIndex = 283
        '
        'dtpFNCheckin
        '
        Me.dtpFNCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpFNCheckin.Location = New System.Drawing.Point(200, 117)
        Me.dtpFNCheckin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFNCheckin.Name = "dtpFNCheckin"
        Me.dtpFNCheckin.ShowUpDown = True
        Me.dtpFNCheckin.Size = New System.Drawing.Size(135, 22)
        Me.dtpFNCheckin.TabIndex = 282
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.PaleGreen
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Location = New System.Drawing.Point(101, 122)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 17)
        Me.Label13.TabIndex = 281
        Me.Label13.Text = "Check In :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PaleGreen
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label14.Location = New System.Drawing.Point(91, 153)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(92, 17)
        Me.Label14.TabIndex = 280
        Me.Label14.Text = "Check Out :"
        '
        'DGVShiftTimings
        '
        Me.DGVShiftTimings.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVShiftTimings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVShiftTimings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVShiftTimings.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVShiftTimings.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVShiftTimings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVShiftTimings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVShiftTimings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ShowTimings, Me.EmployeeCode, Me.EmployeeName})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVShiftTimings.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGVShiftTimings.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVShiftTimings.Location = New System.Drawing.Point(39, 251)
        Me.DGVShiftTimings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGVShiftTimings.Name = "DGVShiftTimings"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVShiftTimings.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVShiftTimings.RowHeadersVisible = False
        Me.DGVShiftTimings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVShiftTimings.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVShiftTimings.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVShiftTimings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVShiftTimings.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVShiftTimings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVShiftTimings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVShiftTimings.Size = New System.Drawing.Size(768, 491)
        Me.DGVShiftTimings.TabIndex = 290
        '
        'ShowTimings
        '
        Me.ShowTimings.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ShowTimings.HeaderText = "Timings"
        Me.ShowTimings.Name = "ShowTimings"
        Me.ShowTimings.ReadOnly = True
        Me.ShowTimings.Text = "Show Timings"
        Me.ShowTimings.UseColumnTextForLinkValue = True
        '
        'EmployeeCode
        '
        Me.EmployeeCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.EmployeeCode.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeCode.HeaderText = "Employee Code"
        Me.EmployeeCode.Name = "EmployeeCode"
        Me.EmployeeCode.ReadOnly = True
        Me.EmployeeCode.Width = 150
        '
        'EmployeeName
        '
        Me.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle4
        Me.EmployeeName.HeaderText = "EmployeeName"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 300
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.White
        Me.BtnClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.BtnClose.Location = New System.Drawing.Point(673, 207)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(100, 28)
        Me.BtnClose.TabIndex = 292
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'ButUpdate
        '
        Me.ButUpdate.BackColor = System.Drawing.Color.White
        Me.ButUpdate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButUpdate.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButUpdate.Location = New System.Drawing.Point(565, 207)
        Me.ButUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButUpdate.Name = "ButUpdate"
        Me.ButUpdate.Size = New System.Drawing.Size(100, 28)
        Me.ButUpdate.TabIndex = 291
        Me.ButUpdate.Text = "&Update"
        Me.ButUpdate.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Employee Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "EmployeeName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'FrmSetShiftTimings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(823, 757)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ButUpdate)
        Me.Controls.Add(Me.DGVShiftTimings)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dtpANCheckOut)
        Me.Controls.Add(Me.dtpANCheckIn)
        Me.Controls.Add(Me.dtpFNCheckOut)
        Me.Controls.Add(Me.dtpFNCheckin)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbDptName)
        Me.Controls.Add(Me.lblDepartment)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSetShiftTimings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Shift Timings"
        Me.TopMost = True
        CType(Me.DGVShiftTimings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbDptName As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpANCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpANCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFNCheckOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFNCheckin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DGVShiftTimings As System.Windows.Forms.DataGridView
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ButUpdate As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShowTimings As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents EmployeeCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
