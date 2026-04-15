<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMonthlyDeductions
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.DGVPayroll = New System.Windows.Forms.DataGridView()
        Me.EmployeeCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.cmbDeduction = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButLoad = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButDelete = New System.Windows.Forms.Button()
        CType(Me.DGVPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(52, 150)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 274
        Me.lblFilter.Text = "Filtered By,"
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(156, 147)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(313, 22)
        Me.txtFilter.TabIndex = 275
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(82, 24)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 273
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(438, 59)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(160, 24)
        Me.cmbYear.TabIndex = 272
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Select", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(156, 62)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(160, 24)
        Me.cmbMonth.TabIndex = 271
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.PaleGreen
        Me.lblyear.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblyear.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblyear.Location = New System.Drawing.Point(372, 62)
        Me.lblyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblyear.Name = "lblyear"
        Me.lblyear.Size = New System.Drawing.Size(58, 17)
        Me.lblyear.TabIndex = 270
        Me.lblyear.Text = "*Year :"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.BackColor = System.Drawing.Color.PaleGreen
        Me.lblMonth.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMonth.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMonth.Location = New System.Drawing.Point(78, 66)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(72, 17)
        Me.lblMonth.TabIndex = 269
        Me.lblMonth.Text = "*Month :"
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(532, 705)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 267
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'DGVPayroll
        '
        Me.DGVPayroll.AllowUserToAddRows = False
        Me.DGVPayroll.AllowUserToDeleteRows = False
        Me.DGVPayroll.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVPayroll.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVPayroll.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVPayroll.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVPayroll.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPayroll.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeCode, Me.EmployeeName, Me.DeductionValue})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPayroll.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVPayroll.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVPayroll.Location = New System.Drawing.Point(45, 187)
        Me.DGVPayroll.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVPayroll.Name = "DGVPayroll"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPayroll.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVPayroll.RowHeadersVisible = False
        Me.DGVPayroll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVPayroll.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVPayroll.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVPayroll.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVPayroll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVPayroll.Size = New System.Drawing.Size(695, 510)
        Me.DGVPayroll.TabIndex = 266
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
        DataGridViewCellStyle3.NullValue = Nothing
        Me.EmployeeName.DefaultCellStyle = DataGridViewCellStyle3
        Me.EmployeeName.HeaderText = "Employee Name"
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.ReadOnly = True
        Me.EmployeeName.Width = 148
        '
        'DeductionValue
        '
        Me.DeductionValue.HeaderText = "Amount"
        Me.DeductionValue.Name = "DeductionValue"
        Me.DeductionValue.Width = 93
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(640, 705)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 268
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'cmbDeduction
        '
        Me.cmbDeduction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeduction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDeduction.FormattingEnabled = True
        Me.cmbDeduction.Items.AddRange(New Object() {"Select", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbDeduction.Location = New System.Drawing.Point(156, 105)
        Me.cmbDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDeduction.Name = "cmbDeduction"
        Me.cmbDeduction.Size = New System.Drawing.Size(313, 24)
        Me.cmbDeduction.TabIndex = 277
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(51, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 276
        Me.Label1.Text = "*Deduction :"
        '
        'ButLoad
        '
        Me.ButLoad.BackColor = System.Drawing.Color.White
        Me.ButLoad.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButLoad.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButLoad.Location = New System.Drawing.Point(501, 102)
        Me.ButLoad.Margin = New System.Windows.Forms.Padding(4)
        Me.ButLoad.Name = "ButLoad"
        Me.ButLoad.Size = New System.Drawing.Size(100, 28)
        Me.ButLoad.TabIndex = 278
        Me.ButLoad.Text = "&Load"
        Me.ButLoad.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Employee Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "No Of Days Worked"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 145
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Holiday OverTime Hours"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 171
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "OverTime Hours"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(13, 705)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(100, 28)
        Me.ButDelete.TabIndex = 279
        Me.ButDelete.Text = "&Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'FrmMonthlyDeductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(763, 743)
        Me.Controls.Add(Me.ButDelete)
        Me.Controls.Add(Me.ButLoad)
        Me.Controls.Add(Me.cmbDeduction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.lblyear)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.DGVPayroll)
        Me.Controls.Add(Me.ButCancel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMonthlyDeductions"
        Me.Text = "Monthly Deductions"
        CType(Me.DGVPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFilter As Label
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents lblErrorMessage As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents lblyear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents ButSave As Button
    Friend WithEvents DGVPayroll As DataGridView
    Friend WithEvents ButCancel As Button
    Friend WithEvents cmbDeduction As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ButLoad As Button
    Friend WithEvents EmployeeCode As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeName As DataGridViewTextBoxColumn
    Friend WithEvents DeductionValue As DataGridViewTextBoxColumn
    Friend WithEvents ButDelete As Button
End Class
