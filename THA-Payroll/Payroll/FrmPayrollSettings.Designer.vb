<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayrollSettings
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tabListOfHolidays = New System.Windows.Forms.TabPage()
        Me.btnCloseListOfHolidays = New System.Windows.Forms.Button()
        Me.btnSaveListOfHolidays = New System.Windows.Forms.Button()
        Me.DGVListOfHolidays = New System.Windows.Forms.DataGridView()
        Me.SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dates = New THA_Payroll.clsCalendarColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabTimeSetting = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtESIEmployeeContribution = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtESIEmployerContribution = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtPFEmployeeContribution = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPFEmployerContribution = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMinimumPFCriteria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaximumPFCriteria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPermisson = New System.Windows.Forms.TextBox()
        Me.btnCloseTimeSetting = New System.Windows.Forms.Button()
        Me.btnSaveTimeSetting = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpMorning = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpEvening = New System.Windows.Forms.DateTimePicker()
        Me.lblPermisson = New System.Windows.Forms.Label()
        Me.lblMorning = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblEvening = New System.Windows.Forms.Label()
        Me.tabPayrollSetting = New System.Windows.Forms.TabControl()
        Me.PqyrollONOFF = New System.Windows.Forms.TabPage()
        Me.GBpaymentBasis = New System.Windows.Forms.GroupBox()
        Me.rbOpen = New System.Windows.Forms.RadioButton()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.rbClose = New System.Windows.Forms.RadioButton()
        Me.lblyear = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.ButClosePayrollopenClose = New System.Windows.Forms.Button()
        Me.ButSavePayrollOpenClose = New System.Windows.Forms.Button()
        Me.WeeklyPayroll = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbWeeklyOpen = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rbWeeklyClose = New System.Windows.Forms.RadioButton()
        Me.DtWeeklyEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DtWeeklyStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ButWeeklyPayrollSettingClose = New System.Windows.Forms.Button()
        Me.ButSaveWeeklyPayrollSetting = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClsCalendarColumn1 = New THA_Payroll.clsCalendarColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.tabListOfHolidays.SuspendLayout()
        CType(Me.DGVListOfHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTimeSetting.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPayrollSetting.SuspendLayout()
        Me.PqyrollONOFF.SuspendLayout()
        Me.GBpaymentBasis.SuspendLayout()
        Me.WeeklyPayroll.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabListOfHolidays
        '
        Me.tabListOfHolidays.BackColor = System.Drawing.Color.PaleGreen
        Me.tabListOfHolidays.Controls.Add(Me.btnCloseListOfHolidays)
        Me.tabListOfHolidays.Controls.Add(Me.btnSaveListOfHolidays)
        Me.tabListOfHolidays.Controls.Add(Me.DGVListOfHolidays)
        Me.tabListOfHolidays.Location = New System.Drawing.Point(4, 25)
        Me.tabListOfHolidays.Margin = New System.Windows.Forms.Padding(4)
        Me.tabListOfHolidays.Name = "tabListOfHolidays"
        Me.tabListOfHolidays.Padding = New System.Windows.Forms.Padding(4)
        Me.tabListOfHolidays.Size = New System.Drawing.Size(625, 511)
        Me.tabListOfHolidays.TabIndex = 2
        Me.tabListOfHolidays.Text = "List Of Holidays"
        Me.tabListOfHolidays.UseVisualStyleBackColor = True
        '
        'btnCloseListOfHolidays
        '
        Me.btnCloseListOfHolidays.BackColor = System.Drawing.Color.White
        Me.btnCloseListOfHolidays.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCloseListOfHolidays.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCloseListOfHolidays.Location = New System.Drawing.Point(519, 473)
        Me.btnCloseListOfHolidays.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCloseListOfHolidays.Name = "btnCloseListOfHolidays"
        Me.btnCloseListOfHolidays.Size = New System.Drawing.Size(91, 28)
        Me.btnCloseListOfHolidays.TabIndex = 265
        Me.btnCloseListOfHolidays.Text = "&Cancel"
        Me.btnCloseListOfHolidays.UseVisualStyleBackColor = False
        '
        'btnSaveListOfHolidays
        '
        Me.btnSaveListOfHolidays.BackColor = System.Drawing.Color.White
        Me.btnSaveListOfHolidays.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSaveListOfHolidays.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSaveListOfHolidays.Location = New System.Drawing.Point(417, 473)
        Me.btnSaveListOfHolidays.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveListOfHolidays.Name = "btnSaveListOfHolidays"
        Me.btnSaveListOfHolidays.Size = New System.Drawing.Size(91, 28)
        Me.btnSaveListOfHolidays.TabIndex = 264
        Me.btnSaveListOfHolidays.Text = "&Save"
        Me.btnSaveListOfHolidays.UseVisualStyleBackColor = False
        '
        'DGVListOfHolidays
        '
        Me.DGVListOfHolidays.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVListOfHolidays.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListOfHolidays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVListOfHolidays.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVListOfHolidays.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVListOfHolidays.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVListOfHolidays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListOfHolidays.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SNo, Me.Dates, Me.Description})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListOfHolidays.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVListOfHolidays.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVListOfHolidays.Location = New System.Drawing.Point(-5, -4)
        Me.DGVListOfHolidays.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVListOfHolidays.Name = "DGVListOfHolidays"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListOfHolidays.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVListOfHolidays.RowHeadersVisible = False
        Me.DGVListOfHolidays.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVListOfHolidays.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVListOfHolidays.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVListOfHolidays.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVListOfHolidays.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVListOfHolidays.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVListOfHolidays.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVListOfHolidays.Size = New System.Drawing.Size(633, 517)
        Me.DGVListOfHolidays.TabIndex = 171
        '
        'SNo
        '
        Me.SNo.HeaderText = "SNo"
        Me.SNo.Name = "SNo"
        Me.SNo.Width = 66
        '
        'Dates
        '
        Me.Dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Dates.HeaderText = "Date"
        Me.Dates.Name = "Dates"
        Me.Dates.Width = 80
        '
        'Description
        '
        Me.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Description.DefaultCellStyle = DataGridViewCellStyle3
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Description.Width = 300
        '
        'tabTimeSetting
        '
        Me.tabTimeSetting.BackColor = System.Drawing.Color.PaleGreen
        Me.tabTimeSetting.Controls.Add(Me.Panel1)
        Me.tabTimeSetting.Location = New System.Drawing.Point(4, 25)
        Me.tabTimeSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.tabTimeSetting.Name = "tabTimeSetting"
        Me.tabTimeSetting.Padding = New System.Windows.Forms.Padding(4)
        Me.tabTimeSetting.Size = New System.Drawing.Size(625, 511)
        Me.tabTimeSetting.TabIndex = 0
        Me.tabTimeSetting.Text = "General Setting"
        Me.tabTimeSetting.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtESIEmployeeContribution)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtESIEmployerContribution)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtPFEmployeeContribution)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtPFEmployerContribution)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtMinimumPFCriteria)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtMaximumPFCriteria)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtPermisson)
        Me.Panel1.Controls.Add(Me.btnCloseTimeSetting)
        Me.Panel1.Controls.Add(Me.btnSaveTimeSetting)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtpMorning)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.dtpEvening)
        Me.Panel1.Controls.Add(Me.lblPermisson)
        Me.Panel1.Controls.Add(Me.lblMorning)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.lblEvening)
        Me.Panel1.Location = New System.Drawing.Point(-1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 514)
        Me.Panel1.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label19.Location = New System.Drawing.Point(60, 64)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(180, 17)
        Me.Label19.TabIndex = 286
        Me.Label19.Text = "* Maximum Leave/Year :"
        '
        'txtESIEmployeeContribution
        '
        Me.txtESIEmployeeContribution.Location = New System.Drawing.Point(259, 262)
        Me.txtESIEmployeeContribution.Margin = New System.Windows.Forms.Padding(4)
        Me.txtESIEmployeeContribution.MaxLength = 6
        Me.txtESIEmployeeContribution.Name = "txtESIEmployeeContribution"
        Me.txtESIEmployeeContribution.Size = New System.Drawing.Size(116, 22)
        Me.txtESIEmployeeContribution.TabIndex = 283
        Me.txtESIEmployeeContribution.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.PaleGreen
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label13.Location = New System.Drawing.Point(384, 268)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 17)
        Me.Label13.TabIndex = 285
        Me.Label13.Text = "%"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.PaleGreen
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label14.Location = New System.Drawing.Point(21, 265)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(219, 17)
        Me.Label14.TabIndex = 284
        Me.Label14.Text = "* ESI Employee contribution :"
        '
        'txtESIEmployerContribution
        '
        Me.txtESIEmployerContribution.Location = New System.Drawing.Point(260, 302)
        Me.txtESIEmployerContribution.Margin = New System.Windows.Forms.Padding(4)
        Me.txtESIEmployerContribution.MaxLength = 6
        Me.txtESIEmployerContribution.Name = "txtESIEmployerContribution"
        Me.txtESIEmployerContribution.Size = New System.Drawing.Size(116, 22)
        Me.txtESIEmployerContribution.TabIndex = 280
        Me.txtESIEmployerContribution.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.PaleGreen
        Me.Label15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label15.Location = New System.Drawing.Point(385, 308)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(23, 17)
        Me.Label15.TabIndex = 282
        Me.Label15.Text = "%"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.PaleGreen
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label16.Location = New System.Drawing.Point(23, 305)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(217, 17)
        Me.Label16.TabIndex = 281
        Me.Label16.Text = "* ESI Employer contribution :"
        '
        'txtPFEmployeeContribution
        '
        Me.txtPFEmployeeContribution.Location = New System.Drawing.Point(260, 183)
        Me.txtPFEmployeeContribution.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPFEmployeeContribution.MaxLength = 6
        Me.txtPFEmployeeContribution.Name = "txtPFEmployeeContribution"
        Me.txtPFEmployeeContribution.Size = New System.Drawing.Size(116, 22)
        Me.txtPFEmployeeContribution.TabIndex = 277
        Me.txtPFEmployeeContribution.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.PaleGreen
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label9.Location = New System.Drawing.Point(385, 189)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 17)
        Me.Label9.TabIndex = 279
        Me.Label9.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.PaleGreen
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label10.Location = New System.Drawing.Point(29, 183)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(211, 17)
        Me.Label10.TabIndex = 278
        Me.Label10.Text = "* PF Employee contribution :"
        '
        'txtPFEmployerContribution
        '
        Me.txtPFEmployerContribution.Location = New System.Drawing.Point(261, 223)
        Me.txtPFEmployerContribution.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPFEmployerContribution.MaxLength = 6
        Me.txtPFEmployerContribution.Name = "txtPFEmployerContribution"
        Me.txtPFEmployerContribution.Size = New System.Drawing.Size(116, 22)
        Me.txtPFEmployerContribution.TabIndex = 274
        Me.txtPFEmployerContribution.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.PaleGreen
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label11.Location = New System.Drawing.Point(386, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 17)
        Me.Label11.TabIndex = 276
        Me.Label11.Text = "%"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.PaleGreen
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label12.Location = New System.Drawing.Point(31, 223)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(209, 17)
        Me.Label12.TabIndex = 275
        Me.Label12.Text = "* PF Employer contribution :"
        '
        'txtMinimumPFCriteria
        '
        Me.txtMinimumPFCriteria.Location = New System.Drawing.Point(260, 100)
        Me.txtMinimumPFCriteria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMinimumPFCriteria.MaxLength = 6
        Me.txtMinimumPFCriteria.Name = "txtMinimumPFCriteria"
        Me.txtMinimumPFCriteria.Size = New System.Drawing.Size(116, 22)
        Me.txtMinimumPFCriteria.TabIndex = 271
        Me.txtMinimumPFCriteria.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.PaleGreen
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(385, 106)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 17)
        Me.Label3.TabIndex = 273
        Me.Label3.Text = "Rs"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.PaleGreen
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(66, 100)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 17)
        Me.Label4.TabIndex = 272
        Me.Label4.Text = "* PF Minimum amount :"
        '
        'txtMaximumPFCriteria
        '
        Me.txtMaximumPFCriteria.Location = New System.Drawing.Point(261, 140)
        Me.txtMaximumPFCriteria.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaximumPFCriteria.MaxLength = 6
        Me.txtMaximumPFCriteria.Name = "txtMaximumPFCriteria"
        Me.txtMaximumPFCriteria.Size = New System.Drawing.Size(116, 22)
        Me.txtMaximumPFCriteria.TabIndex = 268
        Me.txtMaximumPFCriteria.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PaleGreen
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(386, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 17)
        Me.Label1.TabIndex = 270
        Me.Label1.Text = "Rs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.PaleGreen
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(61, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 17)
        Me.Label2.TabIndex = 269
        Me.Label2.Text = "* PF Maximum amount :"
        '
        'txtPermisson
        '
        Me.txtPermisson.Location = New System.Drawing.Point(260, 28)
        Me.txtPermisson.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPermisson.MaxLength = 6
        Me.txtPermisson.Name = "txtPermisson"
        Me.txtPermisson.Size = New System.Drawing.Size(116, 22)
        Me.txtPermisson.TabIndex = 1
        Me.txtPermisson.Text = "00:00"
        '
        'btnCloseTimeSetting
        '
        Me.btnCloseTimeSetting.BackColor = System.Drawing.Color.White
        Me.btnCloseTimeSetting.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCloseTimeSetting.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCloseTimeSetting.Location = New System.Drawing.Point(507, 471)
        Me.btnCloseTimeSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCloseTimeSetting.Name = "btnCloseTimeSetting"
        Me.btnCloseTimeSetting.Size = New System.Drawing.Size(100, 28)
        Me.btnCloseTimeSetting.TabIndex = 267
        Me.btnCloseTimeSetting.Text = "&Cancel"
        Me.btnCloseTimeSetting.UseVisualStyleBackColor = False
        '
        'btnSaveTimeSetting
        '
        Me.btnSaveTimeSetting.BackColor = System.Drawing.Color.White
        Me.btnSaveTimeSetting.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSaveTimeSetting.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnSaveTimeSetting.Location = New System.Drawing.Point(399, 471)
        Me.btnSaveTimeSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSaveTimeSetting.Name = "btnSaveTimeSetting"
        Me.btnSaveTimeSetting.Size = New System.Drawing.Size(100, 28)
        Me.btnSaveTimeSetting.TabIndex = 266
        Me.btnSaveTimeSetting.Text = "&Save"
        Me.btnSaveTimeSetting.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.PaleGreen
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label8.Location = New System.Drawing.Point(385, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 218
        Me.Label8.Text = "Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.PaleGreen
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label6.Location = New System.Drawing.Point(311, 471)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 216
        Me.Label6.Text = "HH:MM"
        Me.Label6.Visible = False
        '
        'dtpMorning
        '
        Me.dtpMorning.CustomFormat = "hh:mm"
        Me.dtpMorning.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMorning.Location = New System.Drawing.Point(186, 434)
        Me.dtpMorning.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpMorning.Name = "dtpMorning"
        Me.dtpMorning.ShowUpDown = True
        Me.dtpMorning.Size = New System.Drawing.Size(116, 22)
        Me.dtpMorning.TabIndex = 210
        Me.dtpMorning.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.PaleGreen
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label7.Location = New System.Drawing.Point(385, 34)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 217
        Me.Label7.Text = "HH:MM"
        '
        'dtpEvening
        '
        Me.dtpEvening.CustomFormat = "hh:mm"
        Me.dtpEvening.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEvening.Location = New System.Drawing.Point(186, 466)
        Me.dtpEvening.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEvening.Name = "dtpEvening"
        Me.dtpEvening.ShowUpDown = True
        Me.dtpEvening.Size = New System.Drawing.Size(116, 22)
        Me.dtpEvening.TabIndex = 211
        Me.dtpEvening.Visible = False
        '
        'lblPermisson
        '
        Me.lblPermisson.AutoSize = True
        Me.lblPermisson.BackColor = System.Drawing.Color.PaleGreen
        Me.lblPermisson.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPermisson.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPermisson.Location = New System.Drawing.Point(85, 31)
        Me.lblPermisson.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermisson.Name = "lblPermisson"
        Me.lblPermisson.Size = New System.Drawing.Size(155, 17)
        Me.lblPermisson.TabIndex = 209
        Me.lblPermisson.Text = "* Permisson/Month :"
        '
        'lblMorning
        '
        Me.lblMorning.AutoSize = True
        Me.lblMorning.BackColor = System.Drawing.Color.PaleGreen
        Me.lblMorning.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblMorning.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMorning.Location = New System.Drawing.Point(89, 434)
        Me.lblMorning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMorning.Name = "lblMorning"
        Me.lblMorning.Size = New System.Drawing.Size(84, 17)
        Me.lblMorning.TabIndex = 208
        Me.lblMorning.Text = "*Morning :"
        Me.lblMorning.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.PaleGreen
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label5.Location = New System.Drawing.Point(311, 439)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 215
        Me.Label5.Text = "HH:MM"
        Me.Label5.Visible = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(260, 61)
        Me.NumericUpDown1.Margin = New System.Windows.Forms.Padding(4)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(117, 22)
        Me.NumericUpDown1.TabIndex = 214
        '
        'lblEvening
        '
        Me.lblEvening.AutoSize = True
        Me.lblEvening.BackColor = System.Drawing.Color.PaleGreen
        Me.lblEvening.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEvening.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEvening.Location = New System.Drawing.Point(85, 466)
        Me.lblEvening.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEvening.Name = "lblEvening"
        Me.lblEvening.Size = New System.Drawing.Size(88, 17)
        Me.lblEvening.TabIndex = 207
        Me.lblEvening.Text = "* Evening :"
        Me.lblEvening.Visible = False
        '
        'tabPayrollSetting
        '
        Me.tabPayrollSetting.Controls.Add(Me.tabTimeSetting)
        Me.tabPayrollSetting.Controls.Add(Me.tabListOfHolidays)
        Me.tabPayrollSetting.Controls.Add(Me.PqyrollONOFF)
        Me.tabPayrollSetting.Controls.Add(Me.WeeklyPayroll)
        Me.tabPayrollSetting.Location = New System.Drawing.Point(89, 58)
        Me.tabPayrollSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.tabPayrollSetting.Name = "tabPayrollSetting"
        Me.tabPayrollSetting.SelectedIndex = 0
        Me.tabPayrollSetting.Size = New System.Drawing.Size(633, 540)
        Me.tabPayrollSetting.TabIndex = 168
        '
        'PqyrollONOFF
        '
        Me.PqyrollONOFF.BackColor = System.Drawing.Color.PaleGreen
        Me.PqyrollONOFF.Controls.Add(Me.GBpaymentBasis)
        Me.PqyrollONOFF.Controls.Add(Me.ButClosePayrollopenClose)
        Me.PqyrollONOFF.Controls.Add(Me.ButSavePayrollOpenClose)
        Me.PqyrollONOFF.Location = New System.Drawing.Point(4, 25)
        Me.PqyrollONOFF.Margin = New System.Windows.Forms.Padding(4)
        Me.PqyrollONOFF.Name = "PqyrollONOFF"
        Me.PqyrollONOFF.Padding = New System.Windows.Forms.Padding(4)
        Me.PqyrollONOFF.Size = New System.Drawing.Size(625, 511)
        Me.PqyrollONOFF.TabIndex = 3
        Me.PqyrollONOFF.Text = "Monthly Setting"
        '
        'GBpaymentBasis
        '
        Me.GBpaymentBasis.Controls.Add(Me.rbOpen)
        Me.GBpaymentBasis.Controls.Add(Me.cmbYear)
        Me.GBpaymentBasis.Controls.Add(Me.rbClose)
        Me.GBpaymentBasis.Controls.Add(Me.lblyear)
        Me.GBpaymentBasis.Controls.Add(Me.lblMonth)
        Me.GBpaymentBasis.Controls.Add(Me.cmbMonth)
        Me.GBpaymentBasis.Location = New System.Drawing.Point(64, 35)
        Me.GBpaymentBasis.Margin = New System.Windows.Forms.Padding(4)
        Me.GBpaymentBasis.Name = "GBpaymentBasis"
        Me.GBpaymentBasis.Padding = New System.Windows.Forms.Padding(4)
        Me.GBpaymentBasis.Size = New System.Drawing.Size(344, 124)
        Me.GBpaymentBasis.TabIndex = 206
        Me.GBpaymentBasis.TabStop = False
        Me.GBpaymentBasis.Text = "Monthly Payroll"
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.Checked = True
        Me.rbOpen.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbOpen.Location = New System.Drawing.Point(254, 44)
        Me.rbOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(64, 21)
        Me.rbOpen.TabIndex = 5
        Me.rbOpen.TabStop = True
        Me.rbOpen.Text = "Open"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(95, 74)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(135, 24)
        Me.cmbYear.TabIndex = 205
        '
        'rbClose
        '
        Me.rbClose.AutoSize = True
        Me.rbClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbClose.Location = New System.Drawing.Point(254, 73)
        Me.rbClose.Margin = New System.Windows.Forms.Padding(4)
        Me.rbClose.Name = "rbClose"
        Me.rbClose.Size = New System.Drawing.Size(64, 21)
        Me.rbClose.TabIndex = 6
        Me.rbClose.Text = "Close"
        Me.rbClose.UseVisualStyleBackColor = True
        '
        'lblyear
        '
        Me.lblyear.AutoSize = True
        Me.lblyear.BackColor = System.Drawing.Color.PaleGreen
        Me.lblyear.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblyear.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblyear.Location = New System.Drawing.Point(27, 77)
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
        Me.lblMonth.Location = New System.Drawing.Point(13, 40)
        Me.lblMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(72, 17)
        Me.lblMonth.TabIndex = 186
        Me.lblMonth.Text = "*Month :"
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"Select", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(95, 37)
        Me.cmbMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(135, 24)
        Me.cmbMonth.TabIndex = 188
        '
        'ButClosePayrollopenClose
        '
        Me.ButClosePayrollopenClose.BackColor = System.Drawing.Color.White
        Me.ButClosePayrollopenClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButClosePayrollopenClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClosePayrollopenClose.Location = New System.Drawing.Point(461, 448)
        Me.ButClosePayrollopenClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButClosePayrollopenClose.Name = "ButClosePayrollopenClose"
        Me.ButClosePayrollopenClose.Size = New System.Drawing.Size(100, 28)
        Me.ButClosePayrollopenClose.TabIndex = 205
        Me.ButClosePayrollopenClose.Text = "&Cancel"
        Me.ButClosePayrollopenClose.UseVisualStyleBackColor = False
        '
        'ButSavePayrollOpenClose
        '
        Me.ButSavePayrollOpenClose.BackColor = System.Drawing.Color.White
        Me.ButSavePayrollOpenClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSavePayrollOpenClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSavePayrollOpenClose.Location = New System.Drawing.Point(353, 448)
        Me.ButSavePayrollOpenClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSavePayrollOpenClose.Name = "ButSavePayrollOpenClose"
        Me.ButSavePayrollOpenClose.Size = New System.Drawing.Size(100, 28)
        Me.ButSavePayrollOpenClose.TabIndex = 204
        Me.ButSavePayrollOpenClose.Text = "&Save"
        Me.ButSavePayrollOpenClose.UseVisualStyleBackColor = False
        '
        'WeeklyPayroll
        '
        Me.WeeklyPayroll.BackColor = System.Drawing.Color.PaleGreen
        Me.WeeklyPayroll.Controls.Add(Me.GroupBox2)
        Me.WeeklyPayroll.Controls.Add(Me.ButWeeklyPayrollSettingClose)
        Me.WeeklyPayroll.Controls.Add(Me.ButSaveWeeklyPayrollSetting)
        Me.WeeklyPayroll.Location = New System.Drawing.Point(4, 25)
        Me.WeeklyPayroll.Name = "WeeklyPayroll"
        Me.WeeklyPayroll.Size = New System.Drawing.Size(625, 511)
        Me.WeeklyPayroll.TabIndex = 4
        Me.WeeklyPayroll.Text = "Weekly Setting"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbWeeklyOpen)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.rbWeeklyClose)
        Me.GroupBox2.Controls.Add(Me.DtWeeklyEndDate)
        Me.GroupBox2.Controls.Add(Me.DtWeeklyStartDate)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Location = New System.Drawing.Point(104, 67)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(344, 108)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Weekly Payroll"
        '
        'rbWeeklyOpen
        '
        Me.rbWeeklyOpen.AutoSize = True
        Me.rbWeeklyOpen.Checked = True
        Me.rbWeeklyOpen.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbWeeklyOpen.Location = New System.Drawing.Point(260, 36)
        Me.rbWeeklyOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.rbWeeklyOpen.Name = "rbWeeklyOpen"
        Me.rbWeeklyOpen.Size = New System.Drawing.Size(64, 21)
        Me.rbWeeklyOpen.TabIndex = 5
        Me.rbWeeklyOpen.TabStop = True
        Me.rbWeeklyOpen.Text = "Open"
        Me.rbWeeklyOpen.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label17.Location = New System.Drawing.Point(36, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 17)
        Me.Label17.TabIndex = 287
        Me.Label17.Text = "To Date :"
        '
        'rbWeeklyClose
        '
        Me.rbWeeklyClose.AutoSize = True
        Me.rbWeeklyClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbWeeklyClose.Location = New System.Drawing.Point(260, 65)
        Me.rbWeeklyClose.Margin = New System.Windows.Forms.Padding(4)
        Me.rbWeeklyClose.Name = "rbWeeklyClose"
        Me.rbWeeklyClose.Size = New System.Drawing.Size(64, 21)
        Me.rbWeeklyClose.TabIndex = 6
        Me.rbWeeklyClose.Text = "Close"
        Me.rbWeeklyClose.UseVisualStyleBackColor = True
        '
        'DtWeeklyEndDate
        '
        Me.DtWeeklyEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtWeeklyEndDate.Location = New System.Drawing.Point(117, 68)
        Me.DtWeeklyEndDate.Name = "DtWeeklyEndDate"
        Me.DtWeeklyEndDate.Size = New System.Drawing.Size(120, 22)
        Me.DtWeeklyEndDate.TabIndex = 286
        '
        'DtWeeklyStartDate
        '
        Me.DtWeeklyStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtWeeklyStartDate.Location = New System.Drawing.Point(116, 34)
        Me.DtWeeklyStartDate.Name = "DtWeeklyStartDate"
        Me.DtWeeklyStartDate.Size = New System.Drawing.Size(120, 22)
        Me.DtWeeklyStartDate.TabIndex = 285
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label18.Location = New System.Drawing.Point(16, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(93, 17)
        Me.Label18.TabIndex = 284
        Me.Label18.Text = "From Date :"
        '
        'ButWeeklyPayrollSettingClose
        '
        Me.ButWeeklyPayrollSettingClose.BackColor = System.Drawing.Color.White
        Me.ButWeeklyPayrollSettingClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButWeeklyPayrollSettingClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButWeeklyPayrollSettingClose.Location = New System.Drawing.Point(510, 472)
        Me.ButWeeklyPayrollSettingClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButWeeklyPayrollSettingClose.Name = "ButWeeklyPayrollSettingClose"
        Me.ButWeeklyPayrollSettingClose.Size = New System.Drawing.Size(100, 28)
        Me.ButWeeklyPayrollSettingClose.TabIndex = 206
        Me.ButWeeklyPayrollSettingClose.Text = "&Cancel"
        Me.ButWeeklyPayrollSettingClose.UseVisualStyleBackColor = False
        '
        'ButSaveWeeklyPayrollSetting
        '
        Me.ButSaveWeeklyPayrollSetting.BackColor = System.Drawing.Color.White
        Me.ButSaveWeeklyPayrollSetting.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSaveWeeklyPayrollSetting.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSaveWeeklyPayrollSetting.Location = New System.Drawing.Point(402, 472)
        Me.ButSaveWeeklyPayrollSetting.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSaveWeeklyPayrollSetting.Name = "ButSaveWeeklyPayrollSetting"
        Me.ButSaveWeeklyPayrollSetting.Size = New System.Drawing.Size(100, 28)
        Me.ButSaveWeeklyPayrollSetting.TabIndex = 205
        Me.ButSaveWeeklyPayrollSetting.Text = "&Save"
        Me.ButSaveWeeklyPayrollSetting.UseVisualStyleBackColor = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "SNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'ClsCalendarColumn1
        '
        Me.ClsCalendarColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ClsCalendarColumn1.HeaderText = "Date"
        Me.ClsCalendarColumn1.Name = "ClsCalendarColumn1"
        Me.ClsCalendarColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(72, 20)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 263
        '
        'FrmPayrollSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(829, 636)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.tabPayrollSetting)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPayrollSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Settings"
        Me.TopMost = True
        Me.tabListOfHolidays.ResumeLayout(False)
        CType(Me.DGVListOfHolidays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTimeSetting.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPayrollSetting.ResumeLayout(False)
        Me.PqyrollONOFF.ResumeLayout(False)
        Me.GBpaymentBasis.ResumeLayout(False)
        Me.GBpaymentBasis.PerformLayout()
        Me.WeeklyPayroll.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabListOfHolidays As System.Windows.Forms.TabPage
    Friend WithEvents tabTimeSetting As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents dtpEvening As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpMorning As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPermisson As System.Windows.Forms.Label
    Friend WithEvents lblMorning As System.Windows.Forms.Label
    Friend WithEvents lblEvening As System.Windows.Forms.Label
    Friend WithEvents tabPayrollSetting As System.Windows.Forms.TabControl
    Friend WithEvents DGVListOfHolidays As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClsCalendarColumn1 As THA_Payroll.clsCalendarColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dates As THA_Payroll.clsCalendarColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PqyrollONOFF As System.Windows.Forms.TabPage
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents btnCloseTimeSetting As System.Windows.Forms.Button
    Friend WithEvents btnSaveTimeSetting As System.Windows.Forms.Button
    Friend WithEvents btnCloseListOfHolidays As System.Windows.Forms.Button
    Friend WithEvents btnSaveListOfHolidays As System.Windows.Forms.Button
    Friend WithEvents txtPermisson As System.Windows.Forms.TextBox
    Friend WithEvents txtMinimumPFCriteria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtMaximumPFCriteria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtESIEmployeeContribution As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtESIEmployerContribution As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtPFEmployeeContribution As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPFEmployerContribution As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents WeeklyPayroll As TabPage
    Friend WithEvents ButWeeklyPayrollSettingClose As Button
    Friend WithEvents ButSaveWeeklyPayrollSetting As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbWeeklyOpen As RadioButton
    Friend WithEvents Label17 As Label
    Friend WithEvents rbWeeklyClose As RadioButton
    Friend WithEvents DtWeeklyEndDate As DateTimePicker
    Friend WithEvents DtWeeklyStartDate As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents GBpaymentBasis As GroupBox
    Friend WithEvents rbOpen As RadioButton
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents rbClose As RadioButton
    Friend WithEvents lblyear As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents ButClosePayrollopenClose As Button
    Friend WithEvents ButSavePayrollOpenClose As Button
    Friend WithEvents Label19 As Label
End Class
