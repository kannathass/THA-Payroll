<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaySlip
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPaySlip))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.lstEmployeeNames = New System.Windows.Forms.ListBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.lblPermissionLimit = New System.Windows.Forms.Label()
        Me.txtEarnings = New System.Windows.Forms.TextBox()
        Me.lblEarning = New System.Windows.Forms.Label()
        Me.txtDeductions = New System.Windows.Forms.TextBox()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.txtLoanInstallment = New System.Windows.Forms.TextBox()
        Me.lblLoan = New System.Windows.Forms.Label()
        Me.txtLeaveDays = New System.Windows.Forms.TextBox()
        Me.lblLeavesTaken = New System.Windows.Forms.Label()
        Me.txtGrossSalary = New System.Windows.Forms.TextBox()
        Me.lblGrossSalary = New System.Windows.Forms.Label()
        Me.txtNetSalary = New System.Windows.Forms.TextBox()
        Me.lblNetSalary = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtPayrollMonth = New System.Windows.Forms.TextBox()
        Me.lblPayrollMonth = New System.Windows.Forms.Label()
        Me.txtPaySlipNo = New System.Windows.Forms.TextBox()
        Me.lblPaySlipNo = New System.Windows.Forms.Label()
        Me.txtEmployeeCode = New System.Windows.Forms.TextBox()
        Me.lblEmployeeCode = New System.Windows.Forms.Label()
        Me.rbDaily = New System.Windows.Forms.RadioButton()
        Me.rbMonthly = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbWeekly = New System.Windows.Forms.RadioButton()
        Me.rbClose = New System.Windows.Forms.RadioButton()
        Me.rbOpen = New System.Windows.Forms.RadioButton()
        Me.GBpaymentBasis = New System.Windows.Forms.GroupBox()
        Me.txtOverTimeHrs = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOverTimeSalary = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPermissionTaken = New System.Windows.Forms.TextBox()
        Me.lblPermissionHrs = New System.Windows.Forms.Label()
        Me.lblErrorMessage = New System.Windows.Forms.Label()
        Me.txtNoOfDaysWorked = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.calStartDate = New System.Windows.Forms.DateTimePicker()
        Me.calEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DGVEarnings = New System.Windows.Forms.DataGridView()
        Me.EarningName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EarningValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVDeductions = New System.Windows.Forms.DataGridView()
        Me.DeductionName1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DPercentage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeductionValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chkOverTimeAllowed = New System.Windows.Forms.CheckBox()
        Me.chkPermissionAllowed = New System.Windows.Forms.CheckBox()
        Me.txtLeaveConcession = New System.Windows.Forms.TextBox()
        Me.txtSalaryPercentForEarning = New System.Windows.Forms.TextBox()
        Me.txtSalaryPercentForDeductions = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GBpaymentBasis.SuspendLayout()
        CType(Me.DGVEarnings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDeductions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.Label10.Location = New System.Drawing.Point(135, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 267
        Me.Label10.Text = "Date :"
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.AutoSize = True
        Me.lblEmployeeName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmployeeName.Location = New System.Drawing.Point(596, 110)
        Me.lblEmployeeName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(130, 17)
        Me.lblEmployeeName.TabIndex = 266
        Me.lblEmployeeName.Text = "Employee Name :"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtBasicSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtBasicSalary.ForeColor = System.Drawing.Color.White
        Me.txtBasicSalary.Location = New System.Drawing.Point(205, 180)
        Me.txtBasicSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.ReadOnly = True
        Me.txtBasicSalary.Size = New System.Drawing.Size(148, 24)
        Me.txtBasicSalary.TabIndex = 265
        Me.txtBasicSalary.TabStop = False
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblBasicSalary.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBasicSalary.Location = New System.Drawing.Point(81, 183)
        Me.lblBasicSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(103, 17)
        Me.lblBasicSalary.TabIndex = 264
        Me.lblBasicSalary.Text = "Basic Salary :"
        '
        'lstEmployeeNames
        '
        Me.lstEmployeeNames.BackColor = System.Drawing.SystemColors.Info
        Me.lstEmployeeNames.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstEmployeeNames.ForeColor = System.Drawing.Color.DarkGreen
        Me.lstEmployeeNames.FormattingEnabled = True
        Me.lstEmployeeNames.HorizontalScrollbar = True
        Me.lstEmployeeNames.ItemHeight = 16
        Me.lstEmployeeNames.Location = New System.Drawing.Point(748, 127)
        Me.lstEmployeeNames.Margin = New System.Windows.Forms.Padding(4)
        Me.lstEmployeeNames.Name = "lstEmployeeNames"
        Me.lstEmployeeNames.Size = New System.Drawing.Size(400, 160)
        Me.lstEmployeeNames.TabIndex = 5
        Me.lstEmployeeNames.Visible = False
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtEmployeeName.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEmployeeName.ForeColor = System.Drawing.Color.White
        Me.txtEmployeeName.Location = New System.Drawing.Point(748, 102)
        Me.txtEmployeeName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.ReadOnly = True
        Me.txtEmployeeName.Size = New System.Drawing.Size(191, 24)
        Me.txtEmployeeName.TabIndex = 4
        '
        'lblPermissionLimit
        '
        Me.lblPermissionLimit.AutoSize = True
        Me.lblPermissionLimit.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPermissionLimit.ForeColor = System.Drawing.Color.Red
        Me.lblPermissionLimit.Location = New System.Drawing.Point(961, 308)
        Me.lblPermissionLimit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermissionLimit.Name = "lblPermissionLimit"
        Me.lblPermissionLimit.Size = New System.Drawing.Size(156, 17)
        Me.lblPermissionLimit.TabIndex = 263
        Me.lblPermissionLimit.Text = "Permission Limit = "
        Me.lblPermissionLimit.Visible = False
        '
        'txtEarnings
        '
        Me.txtEarnings.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtEarnings.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEarnings.ForeColor = System.Drawing.Color.White
        Me.txtEarnings.Location = New System.Drawing.Point(205, 338)
        Me.txtEarnings.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEarnings.Name = "txtEarnings"
        Me.txtEarnings.ReadOnly = True
        Me.txtEarnings.Size = New System.Drawing.Size(148, 24)
        Me.txtEarnings.TabIndex = 273
        Me.txtEarnings.TabStop = False
        '
        'lblEarning
        '
        Me.lblEarning.AutoSize = True
        Me.lblEarning.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEarning.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEarning.Location = New System.Drawing.Point(73, 341)
        Me.lblEarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEarning.Name = "lblEarning"
        Me.lblEarning.Size = New System.Drawing.Size(108, 17)
        Me.lblEarning.TabIndex = 272
        Me.lblEarning.Text = "(+) Earnings :"
        '
        'txtDeductions
        '
        Me.txtDeductions.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtDeductions.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtDeductions.ForeColor = System.Drawing.Color.White
        Me.txtDeductions.Location = New System.Drawing.Point(761, 332)
        Me.txtDeductions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeductions.Name = "txtDeductions"
        Me.txtDeductions.ReadOnly = True
        Me.txtDeductions.Size = New System.Drawing.Size(191, 24)
        Me.txtDeductions.TabIndex = 275
        Me.txtDeductions.TabStop = False
        '
        'lblDeductions
        '
        Me.lblDeductions.AutoSize = True
        Me.lblDeductions.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDeductions.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDeductions.Location = New System.Drawing.Point(624, 337)
        Me.lblDeductions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(122, 17)
        Me.lblDeductions.TabIndex = 274
        Me.lblDeductions.Text = "(-) Deductions :"
        '
        'txtAdvance
        '
        Me.txtAdvance.BackColor = System.Drawing.Color.White
        Me.txtAdvance.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtAdvance.ForeColor = System.Drawing.Color.DarkRed
        Me.txtAdvance.Location = New System.Drawing.Point(205, 567)
        Me.txtAdvance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(148, 24)
        Me.txtAdvance.TabIndex = 277
        Me.txtAdvance.TabStop = False
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblAdvance.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblAdvance.Location = New System.Drawing.Point(87, 571)
        Me.lblAdvance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(102, 17)
        Me.lblAdvance.TabIndex = 276
        Me.lblAdvance.Text = "(-) Advance :"
        '
        'txtLoanInstallment
        '
        Me.txtLoanInstallment.BackColor = System.Drawing.Color.White
        Me.txtLoanInstallment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLoanInstallment.ForeColor = System.Drawing.Color.DarkRed
        Me.txtLoanInstallment.Location = New System.Drawing.Point(205, 599)
        Me.txtLoanInstallment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLoanInstallment.Name = "txtLoanInstallment"
        Me.txtLoanInstallment.Size = New System.Drawing.Size(148, 24)
        Me.txtLoanInstallment.TabIndex = 279
        Me.txtLoanInstallment.TabStop = False
        '
        'lblLoan
        '
        Me.lblLoan.AutoSize = True
        Me.lblLoan.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLoan.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLoan.Location = New System.Drawing.Point(24, 603)
        Me.lblLoan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoan.Name = "lblLoan"
        Me.lblLoan.Size = New System.Drawing.Size(160, 17)
        Me.lblLoan.TabIndex = 278
        Me.lblLoan.Text = "(-) Loan Installment :"
        '
        'txtLeaveDays
        '
        Me.txtLeaveDays.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtLeaveDays.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtLeaveDays.ForeColor = System.Drawing.Color.White
        Me.txtLeaveDays.Location = New System.Drawing.Point(205, 245)
        Me.txtLeaveDays.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLeaveDays.Name = "txtLeaveDays"
        Me.txtLeaveDays.ReadOnly = True
        Me.txtLeaveDays.Size = New System.Drawing.Size(148, 24)
        Me.txtLeaveDays.TabIndex = 281
        Me.txtLeaveDays.TabStop = False
        '
        'lblLeavesTaken
        '
        Me.lblLeavesTaken.AutoSize = True
        Me.lblLeavesTaken.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLeavesTaken.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblLeavesTaken.Location = New System.Drawing.Point(71, 249)
        Me.lblLeavesTaken.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeavesTaken.Name = "lblLeavesTaken"
        Me.lblLeavesTaken.Size = New System.Drawing.Size(112, 17)
        Me.lblLeavesTaken.TabIndex = 280
        Me.lblLeavesTaken.Text = "Leaves Taken :"
        '
        'txtGrossSalary
        '
        Me.txtGrossSalary.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtGrossSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtGrossSalary.ForeColor = System.Drawing.Color.White
        Me.txtGrossSalary.Location = New System.Drawing.Point(205, 535)
        Me.txtGrossSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrossSalary.Name = "txtGrossSalary"
        Me.txtGrossSalary.ReadOnly = True
        Me.txtGrossSalary.Size = New System.Drawing.Size(148, 24)
        Me.txtGrossSalary.TabIndex = 283
        Me.txtGrossSalary.TabStop = False
        '
        'lblGrossSalary
        '
        Me.lblGrossSalary.AutoSize = True
        Me.lblGrossSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblGrossSalary.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblGrossSalary.Location = New System.Drawing.Point(79, 539)
        Me.lblGrossSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrossSalary.Name = "lblGrossSalary"
        Me.lblGrossSalary.Size = New System.Drawing.Size(109, 17)
        Me.lblGrossSalary.TabIndex = 282
        Me.lblGrossSalary.Text = "Gross Salary :"
        '
        'txtNetSalary
        '
        Me.txtNetSalary.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtNetSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNetSalary.ForeColor = System.Drawing.Color.White
        Me.txtNetSalary.Location = New System.Drawing.Point(205, 631)
        Me.txtNetSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetSalary.Name = "txtNetSalary"
        Me.txtNetSalary.ReadOnly = True
        Me.txtNetSalary.Size = New System.Drawing.Size(148, 24)
        Me.txtNetSalary.TabIndex = 285
        Me.txtNetSalary.TabStop = False
        '
        'lblNetSalary
        '
        Me.lblNetSalary.AutoSize = True
        Me.lblNetSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNetSalary.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblNetSalary.Location = New System.Drawing.Point(97, 631)
        Me.lblNetSalary.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNetSalary.Name = "lblNetSalary"
        Me.lblNetSalary.Size = New System.Drawing.Size(91, 17)
        Me.lblNetSalary.TabIndex = 284
        Me.lblNetSalary.Text = "Net Salary :"
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(1061, 629)
        Me.ButCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(100, 28)
        Me.ButCancel.TabIndex = 5
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(953, 629)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(100, 28)
        Me.ButSave.TabIndex = 4
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtDate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtDate.ForeColor = System.Drawing.Color.White
        Me.txtDate.Location = New System.Drawing.Point(205, 84)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(148, 24)
        Me.txtDate.TabIndex = 288
        Me.txtDate.TabStop = False
        '
        'txtPayrollMonth
        '
        Me.txtPayrollMonth.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtPayrollMonth.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPayrollMonth.ForeColor = System.Drawing.Color.White
        Me.txtPayrollMonth.Location = New System.Drawing.Point(205, 116)
        Me.txtPayrollMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPayrollMonth.Name = "txtPayrollMonth"
        Me.txtPayrollMonth.ReadOnly = True
        Me.txtPayrollMonth.Size = New System.Drawing.Size(148, 24)
        Me.txtPayrollMonth.TabIndex = 290
        Me.txtPayrollMonth.TabStop = False
        '
        'lblPayrollMonth
        '
        Me.lblPayrollMonth.AutoSize = True
        Me.lblPayrollMonth.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollMonth.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPayrollMonth.Location = New System.Drawing.Point(73, 119)
        Me.lblPayrollMonth.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPayrollMonth.Name = "lblPayrollMonth"
        Me.lblPayrollMonth.Size = New System.Drawing.Size(113, 17)
        Me.lblPayrollMonth.TabIndex = 289
        Me.lblPayrollMonth.Text = "Payroll Month :"
        '
        'txtPaySlipNo
        '
        Me.txtPaySlipNo.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtPaySlipNo.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPaySlipNo.ForeColor = System.Drawing.Color.White
        Me.txtPaySlipNo.Location = New System.Drawing.Point(205, 52)
        Me.txtPaySlipNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPaySlipNo.Name = "txtPaySlipNo"
        Me.txtPaySlipNo.ReadOnly = True
        Me.txtPaySlipNo.Size = New System.Drawing.Size(148, 24)
        Me.txtPaySlipNo.TabIndex = 292
        Me.txtPaySlipNo.TabStop = False
        '
        'lblPaySlipNo
        '
        Me.lblPaySlipNo.AutoSize = True
        Me.lblPaySlipNo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaySlipNo.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblPaySlipNo.Location = New System.Drawing.Point(95, 55)
        Me.lblPaySlipNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaySlipNo.Name = "lblPaySlipNo"
        Me.lblPaySlipNo.Size = New System.Drawing.Size(92, 17)
        Me.lblPaySlipNo.TabIndex = 291
        Me.lblPaySlipNo.Text = "PaySlip No :"
        '
        'txtEmployeeCode
        '
        Me.txtEmployeeCode.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtEmployeeCode.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtEmployeeCode.ForeColor = System.Drawing.Color.White
        Me.txtEmployeeCode.Location = New System.Drawing.Point(205, 148)
        Me.txtEmployeeCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployeeCode.Name = "txtEmployeeCode"
        Me.txtEmployeeCode.ReadOnly = True
        Me.txtEmployeeCode.Size = New System.Drawing.Size(148, 24)
        Me.txtEmployeeCode.TabIndex = 295
        Me.txtEmployeeCode.TabStop = False
        '
        'lblEmployeeCode
        '
        Me.lblEmployeeCode.AutoSize = True
        Me.lblEmployeeCode.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmployeeCode.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmployeeCode.Location = New System.Drawing.Point(56, 151)
        Me.lblEmployeeCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeCode.Name = "lblEmployeeCode"
        Me.lblEmployeeCode.Size = New System.Drawing.Size(127, 17)
        Me.lblEmployeeCode.TabIndex = 294
        Me.lblEmployeeCode.Text = "Employee Code :"
        '
        'rbDaily
        '
        Me.rbDaily.AutoSize = True
        Me.rbDaily.Checked = True
        Me.rbDaily.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbDaily.Location = New System.Drawing.Point(19, 21)
        Me.rbDaily.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDaily.Name = "rbDaily"
        Me.rbDaily.Size = New System.Drawing.Size(60, 21)
        Me.rbDaily.TabIndex = 1
        Me.rbDaily.TabStop = True
        Me.rbDaily.Text = "Daily"
        Me.rbDaily.UseVisualStyleBackColor = True
        '
        'rbMonthly
        '
        Me.rbMonthly.AutoSize = True
        Me.rbMonthly.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbMonthly.Location = New System.Drawing.Point(249, 21)
        Me.rbMonthly.Margin = New System.Windows.Forms.Padding(4)
        Me.rbMonthly.Name = "rbMonthly"
        Me.rbMonthly.Size = New System.Drawing.Size(78, 21)
        Me.rbMonthly.TabIndex = 3
        Me.rbMonthly.Text = "Monthly"
        Me.rbMonthly.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbWeekly)
        Me.GroupBox1.Controls.Add(Me.rbDaily)
        Me.GroupBox1.Controls.Add(Me.rbMonthly)
        Me.GroupBox1.Location = New System.Drawing.Point(613, 42)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(340, 54)
        Me.GroupBox1.TabIndex = 301
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payroll"
        '
        'rbWeekly
        '
        Me.rbWeekly.AutoSize = True
        Me.rbWeekly.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbWeekly.Location = New System.Drawing.Point(135, 21)
        Me.rbWeekly.Margin = New System.Windows.Forms.Padding(4)
        Me.rbWeekly.Name = "rbWeekly"
        Me.rbWeekly.Size = New System.Drawing.Size(75, 21)
        Me.rbWeekly.TabIndex = 2
        Me.rbWeekly.Text = "Weekly"
        Me.rbWeekly.UseVisualStyleBackColor = True
        '
        'rbClose
        '
        Me.rbClose.AutoSize = True
        Me.rbClose.Enabled = False
        Me.rbClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbClose.Location = New System.Drawing.Point(99, 21)
        Me.rbClose.Margin = New System.Windows.Forms.Padding(4)
        Me.rbClose.Name = "rbClose"
        Me.rbClose.Size = New System.Drawing.Size(64, 21)
        Me.rbClose.TabIndex = 6
        Me.rbClose.TabStop = True
        Me.rbClose.Text = "Close"
        Me.rbClose.UseVisualStyleBackColor = True
        '
        'rbOpen
        '
        Me.rbOpen.AutoSize = True
        Me.rbOpen.Enabled = False
        Me.rbOpen.ForeColor = System.Drawing.Color.DarkGreen
        Me.rbOpen.Location = New System.Drawing.Point(23, 21)
        Me.rbOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Size = New System.Drawing.Size(64, 21)
        Me.rbOpen.TabIndex = 5
        Me.rbOpen.TabStop = True
        Me.rbOpen.Text = "Open"
        Me.rbOpen.UseVisualStyleBackColor = True
        '
        'GBpaymentBasis
        '
        Me.GBpaymentBasis.Controls.Add(Me.rbOpen)
        Me.GBpaymentBasis.Controls.Add(Me.rbClose)
        Me.GBpaymentBasis.Location = New System.Drawing.Point(379, 47)
        Me.GBpaymentBasis.Margin = New System.Windows.Forms.Padding(4)
        Me.GBpaymentBasis.Name = "GBpaymentBasis"
        Me.GBpaymentBasis.Padding = New System.Windows.Forms.Padding(4)
        Me.GBpaymentBasis.Size = New System.Drawing.Size(189, 54)
        Me.GBpaymentBasis.TabIndex = 302
        Me.GBpaymentBasis.TabStop = False
        Me.GBpaymentBasis.Text = "Payroll"
        Me.GBpaymentBasis.Visible = False
        '
        'txtOverTimeHrs
        '
        Me.txtOverTimeHrs.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtOverTimeHrs.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtOverTimeHrs.ForeColor = System.Drawing.Color.White
        Me.txtOverTimeHrs.Location = New System.Drawing.Point(205, 308)
        Me.txtOverTimeHrs.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOverTimeHrs.Name = "txtOverTimeHrs"
        Me.txtOverTimeHrs.ReadOnly = True
        Me.txtOverTimeHrs.Size = New System.Drawing.Size(148, 24)
        Me.txtOverTimeHrs.TabIndex = 304
        Me.txtOverTimeHrs.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label1.Location = New System.Drawing.Point(14, 311)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 17)
        Me.Label1.TabIndex = 303
        Me.Label1.Text = "(+) TotalOvertimeHrs :"
        '
        'txtOverTimeSalary
        '
        Me.txtOverTimeSalary.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtOverTimeSalary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtOverTimeSalary.ForeColor = System.Drawing.Color.White
        Me.txtOverTimeSalary.Location = New System.Drawing.Point(761, 303)
        Me.txtOverTimeSalary.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOverTimeSalary.Name = "txtOverTimeSalary"
        Me.txtOverTimeSalary.ReadOnly = True
        Me.txtOverTimeSalary.Size = New System.Drawing.Size(191, 24)
        Me.txtOverTimeSalary.TabIndex = 307
        Me.txtOverTimeSalary.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(581, 308)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 17)
        Me.Label2.TabIndex = 306
        Me.Label2.Text = "(+) OvertimeSalary :"
        '
        'txtPermissionTaken
        '
        Me.txtPermissionTaken.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtPermissionTaken.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtPermissionTaken.ForeColor = System.Drawing.Color.White
        Me.txtPermissionTaken.Location = New System.Drawing.Point(205, 277)
        Me.txtPermissionTaken.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPermissionTaken.Name = "txtPermissionTaken"
        Me.txtPermissionTaken.ReadOnly = True
        Me.txtPermissionTaken.Size = New System.Drawing.Size(148, 24)
        Me.txtPermissionTaken.TabIndex = 309
        Me.txtPermissionTaken.TabStop = False
        '
        'lblPermissionHrs
        '
        Me.lblPermissionHrs.AutoSize = True
        Me.lblPermissionHrs.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblPermissionHrs.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblPermissionHrs.Location = New System.Drawing.Point(19, 277)
        Me.lblPermissionHrs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermissionHrs.Name = "lblPermissionHrs"
        Me.lblPermissionHrs.Size = New System.Drawing.Size(163, 17)
        Me.lblPermissionHrs.TabIndex = 308
        Me.lblPermissionHrs.Text = "(-) Permission Taken :"
        '
        'lblErrorMessage
        '
        Me.lblErrorMessage.AutoSize = True
        Me.lblErrorMessage.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblErrorMessage.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMessage.Location = New System.Drawing.Point(140, 11)
        Me.lblErrorMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblErrorMessage.Name = "lblErrorMessage"
        Me.lblErrorMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblErrorMessage.TabIndex = 310
        '
        'txtNoOfDaysWorked
        '
        Me.txtNoOfDaysWorked.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.txtNoOfDaysWorked.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNoOfDaysWorked.ForeColor = System.Drawing.Color.White
        Me.txtNoOfDaysWorked.Location = New System.Drawing.Point(205, 212)
        Me.txtNoOfDaysWorked.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNoOfDaysWorked.Name = "txtNoOfDaysWorked"
        Me.txtNoOfDaysWorked.ReadOnly = True
        Me.txtNoOfDaysWorked.Size = New System.Drawing.Size(148, 24)
        Me.txtNoOfDaysWorked.TabIndex = 312
        Me.txtNoOfDaysWorked.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(28, 215)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 17)
        Me.Label3.TabIndex = 311
        Me.Label3.Text = "No of Days Worked :"
        '
        'calStartDate
        '
        Me.calStartDate.CustomFormat = ""
        Me.calStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calStartDate.Location = New System.Drawing.Point(613, 15)
        Me.calStartDate.Margin = New System.Windows.Forms.Padding(4)
        Me.calStartDate.Name = "calStartDate"
        Me.calStartDate.Size = New System.Drawing.Size(153, 22)
        Me.calStartDate.TabIndex = 313
        Me.calStartDate.Value = New Date(2007, 10, 16, 0, 0, 0, 0)
        '
        'calEndDate
        '
        Me.calEndDate.CustomFormat = ""
        Me.calEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.calEndDate.Location = New System.Drawing.Point(800, 15)
        Me.calEndDate.Margin = New System.Windows.Forms.Padding(4)
        Me.calEndDate.Name = "calEndDate"
        Me.calEndDate.Size = New System.Drawing.Size(152, 22)
        Me.calEndDate.TabIndex = 314
        Me.calEndDate.Value = New Date(2007, 10, 16, 0, 0, 0, 0)
        '
        'DGVEarnings
        '
        Me.DGVEarnings.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVEarnings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVEarnings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVEarnings.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVEarnings.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVEarnings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVEarnings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEarnings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EarningName, Me.EPercentage, Me.EarningValue})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEarnings.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGVEarnings.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVEarnings.Location = New System.Drawing.Point(16, 370)
        Me.DGVEarnings.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVEarnings.Name = "DGVEarnings"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVEarnings.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVEarnings.RowHeadersVisible = False
        Me.DGVEarnings.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVEarnings.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVEarnings.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVEarnings.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVEarnings.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVEarnings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVEarnings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEarnings.Size = New System.Drawing.Size(573, 150)
        Me.DGVEarnings.StandardTab = True
        Me.DGVEarnings.TabIndex = 320
        '
        'EarningName
        '
        Me.EarningName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.EarningName.DefaultCellStyle = DataGridViewCellStyle3
        Me.EarningName.HeaderText = "Earnings"
        Me.EarningName.Name = "EarningName"
        Me.EarningName.Width = 200
        '
        'EPercentage
        '
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.EPercentage.DefaultCellStyle = DataGridViewCellStyle4
        Me.EPercentage.HeaderText = "Percentage"
        Me.EPercentage.Name = "EPercentage"
        Me.EPercentage.Width = 114
        '
        'EarningValue
        '
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.EarningValue.DefaultCellStyle = DataGridViewCellStyle5
        Me.EarningValue.HeaderText = "EarningValue"
        Me.EarningValue.Name = "EarningValue"
        Me.EarningValue.Width = 127
        '
        'DGVDeductions
        '
        Me.DGVDeductions.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVDeductions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVDeductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DGVDeductions.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDeductions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDeductions.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeductionName1, Me.DPercentage, Me.DeductionValue})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDeductions.DefaultCellStyle = DataGridViewCellStyle14
        Me.DGVDeductions.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVDeductions.Location = New System.Drawing.Point(597, 370)
        Me.DGVDeductions.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVDeductions.Name = "DGVDeductions"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDeductions.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.DGVDeductions.RowHeadersVisible = False
        Me.DGVDeductions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDeductions.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDeductions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVDeductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDeductions.Size = New System.Drawing.Size(597, 150)
        Me.DGVDeductions.TabIndex = 321
        '
        'DeductionName1
        '
        Me.DeductionName1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DeductionName1.DefaultCellStyle = DataGridViewCellStyle11
        Me.DeductionName1.HeaderText = "Deductions"
        Me.DeductionName1.Name = "DeductionName1"
        Me.DeductionName1.Width = 200
        '
        'DPercentage
        '
        DataGridViewCellStyle12.Format = "N2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.DPercentage.DefaultCellStyle = DataGridViewCellStyle12
        Me.DPercentage.HeaderText = "Percentage"
        Me.DPercentage.Name = "DPercentage"
        Me.DPercentage.Width = 114
        '
        'DeductionValue
        '
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DeductionValue.DefaultCellStyle = DataGridViewCellStyle13
        Me.DeductionValue.HeaderText = "DeductionValue"
        Me.DeductionValue.Name = "DeductionValue"
        Me.DeductionValue.Width = 145
        '
        'chkOverTimeAllowed
        '
        Me.chkOverTimeAllowed.AutoSize = True
        Me.chkOverTimeAllowed.Checked = True
        Me.chkOverTimeAllowed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOverTimeAllowed.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverTimeAllowed.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkOverTimeAllowed.Location = New System.Drawing.Point(363, 310)
        Me.chkOverTimeAllowed.Margin = New System.Windows.Forms.Padding(4)
        Me.chkOverTimeAllowed.Name = "chkOverTimeAllowed"
        Me.chkOverTimeAllowed.Size = New System.Drawing.Size(116, 18)
        Me.chkOverTimeAllowed.TabIndex = 322
        Me.chkOverTimeAllowed.Text = "Add OverTime"
        Me.chkOverTimeAllowed.UseVisualStyleBackColor = True
        '
        'chkPermissionAllowed
        '
        Me.chkPermissionAllowed.AutoSize = True
        Me.chkPermissionAllowed.Font = New System.Drawing.Font("Verdana", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPermissionAllowed.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkPermissionAllowed.Location = New System.Drawing.Point(363, 277)
        Me.chkPermissionAllowed.Margin = New System.Windows.Forms.Padding(4)
        Me.chkPermissionAllowed.Name = "chkPermissionAllowed"
        Me.chkPermissionAllowed.Size = New System.Drawing.Size(145, 18)
        Me.chkPermissionAllowed.TabIndex = 323
        Me.chkPermissionAllowed.Text = "Deduct Permission"
        Me.chkPermissionAllowed.UseVisualStyleBackColor = True
        '
        'txtLeaveConcession
        '
        Me.txtLeaveConcession.Location = New System.Drawing.Point(363, 245)
        Me.txtLeaveConcession.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLeaveConcession.Name = "txtLeaveConcession"
        Me.txtLeaveConcession.Size = New System.Drawing.Size(64, 22)
        Me.txtLeaveConcession.TabIndex = 324
        '
        'txtSalaryPercentForEarning
        '
        Me.txtSalaryPercentForEarning.Location = New System.Drawing.Point(363, 337)
        Me.txtSalaryPercentForEarning.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalaryPercentForEarning.Name = "txtSalaryPercentForEarning"
        Me.txtSalaryPercentForEarning.Size = New System.Drawing.Size(64, 22)
        Me.txtSalaryPercentForEarning.TabIndex = 325
        '
        'txtSalaryPercentForDeductions
        '
        Me.txtSalaryPercentForDeductions.Location = New System.Drawing.Point(965, 334)
        Me.txtSalaryPercentForDeductions.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalaryPercentForDeductions.Name = "txtSalaryPercentForDeductions"
        Me.txtSalaryPercentForDeductions.Size = New System.Drawing.Size(64, 22)
        Me.txtSalaryPercentForDeductions.TabIndex = 326
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(948, 96)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Size = New System.Drawing.Size(200, 36)
        Me.GroupBox2.TabIndex = 302
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkGreen
        Me.RadioButton1.Location = New System.Drawing.Point(108, 10)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(76, 21)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.Text = "Non PF"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkGreen
        Me.RadioButton2.Location = New System.Drawing.Point(15, 10)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 21)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "PF"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn1.HeaderText = "Deductions"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn2.HeaderText = "DeductionValue"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn3.HeaderText = "Earnings"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn4.HeaderText = "EarningValue"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle21.Format = "N2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn5.HeaderText = "Percentage"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 96
        '
        'DataGridViewTextBoxColumn6
        '
        DataGridViewCellStyle22.Format = "N2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn6.HeaderText = "EarningValue"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 107
        '
        'FrmPaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(1205, 693)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSalaryPercentForDeductions)
        Me.Controls.Add(Me.txtSalaryPercentForEarning)
        Me.Controls.Add(Me.txtLeaveConcession)
        Me.Controls.Add(Me.chkPermissionAllowed)
        Me.Controls.Add(Me.chkOverTimeAllowed)
        Me.Controls.Add(Me.DGVEarnings)
        Me.Controls.Add(Me.DGVDeductions)
        Me.Controls.Add(Me.calEndDate)
        Me.Controls.Add(Me.calStartDate)
        Me.Controls.Add(Me.txtNoOfDaysWorked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.lstEmployeeNames)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblEmployeeName)
        Me.Controls.Add(Me.lblErrorMessage)
        Me.Controls.Add(Me.txtPermissionTaken)
        Me.Controls.Add(Me.lblPermissionHrs)
        Me.Controls.Add(Me.txtOverTimeSalary)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOverTimeHrs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBpaymentBasis)
        Me.Controls.Add(Me.txtEmployeeCode)
        Me.Controls.Add(Me.lblEmployeeCode)
        Me.Controls.Add(Me.txtPaySlipNo)
        Me.Controls.Add(Me.lblPaySlipNo)
        Me.Controls.Add(Me.txtPayrollMonth)
        Me.Controls.Add(Me.lblPayrollMonth)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.txtNetSalary)
        Me.Controls.Add(Me.lblNetSalary)
        Me.Controls.Add(Me.txtGrossSalary)
        Me.Controls.Add(Me.lblGrossSalary)
        Me.Controls.Add(Me.txtLeaveDays)
        Me.Controls.Add(Me.lblLeavesTaken)
        Me.Controls.Add(Me.txtLoanInstallment)
        Me.Controls.Add(Me.lblLoan)
        Me.Controls.Add(Me.txtAdvance)
        Me.Controls.Add(Me.lblAdvance)
        Me.Controls.Add(Me.txtDeductions)
        Me.Controls.Add(Me.lblDeductions)
        Me.Controls.Add(Me.txtEarnings)
        Me.Controls.Add(Me.lblEarning)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtBasicSalary)
        Me.Controls.Add(Me.lblBasicSalary)
        Me.Controls.Add(Me.lblPermissionLimit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPaySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PaySlip"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GBpaymentBasis.ResumeLayout(False)
        Me.GBpaymentBasis.PerformLayout()
        CType(Me.DGVEarnings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDeductions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeName As System.Windows.Forms.Label
    Friend WithEvents txtBasicSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblBasicSalary As System.Windows.Forms.Label
    Friend WithEvents lstEmployeeNames As System.Windows.Forms.ListBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents lblPermissionLimit As System.Windows.Forms.Label
    Friend WithEvents txtEarnings As System.Windows.Forms.TextBox
    Friend WithEvents lblEarning As System.Windows.Forms.Label
    Friend WithEvents txtDeductions As System.Windows.Forms.TextBox
    Friend WithEvents lblDeductions As System.Windows.Forms.Label
    Friend WithEvents txtAdvance As System.Windows.Forms.TextBox
    Friend WithEvents lblAdvance As System.Windows.Forms.Label
    Friend WithEvents txtLoanInstallment As System.Windows.Forms.TextBox
    Friend WithEvents lblLoan As System.Windows.Forms.Label
    Friend WithEvents txtLeaveDays As System.Windows.Forms.TextBox
    Friend WithEvents lblLeavesTaken As System.Windows.Forms.Label
    Friend WithEvents txtGrossSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblGrossSalary As System.Windows.Forms.Label
    Friend WithEvents txtNetSalary As System.Windows.Forms.TextBox
    Friend WithEvents lblNetSalary As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPayrollMonth As System.Windows.Forms.TextBox
    Friend WithEvents lblPayrollMonth As System.Windows.Forms.Label
    Friend WithEvents txtPaySlipNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPaySlipNo As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents lblEmployeeCode As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rbDaily As System.Windows.Forms.RadioButton
    Friend WithEvents rbMonthly As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbClose As System.Windows.Forms.RadioButton
    Friend WithEvents rbOpen As System.Windows.Forms.RadioButton
    Friend WithEvents GBpaymentBasis As System.Windows.Forms.GroupBox
    Friend WithEvents txtOverTimeHrs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOverTimeSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPermissionTaken As System.Windows.Forms.TextBox
    Friend WithEvents lblPermissionHrs As System.Windows.Forms.Label
    Friend WithEvents lblErrorMessage As System.Windows.Forms.Label
    Friend WithEvents txtNoOfDaysWorked As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbWeekly As System.Windows.Forms.RadioButton
    Public WithEvents calStartDate As System.Windows.Forms.DateTimePicker
    Public WithEvents calEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DGVEarnings As System.Windows.Forms.DataGridView
    Friend WithEvents EarningName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EPercentage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EarningValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVDeductions As System.Windows.Forms.DataGridView
    Friend WithEvents DeductionName1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DPercentage As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeductionValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkOverTimeAllowed As System.Windows.Forms.CheckBox
    Friend WithEvents chkPermissionAllowed As System.Windows.Forms.CheckBox
    Friend WithEvents txtLeaveConcession As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryPercentForEarning As System.Windows.Forms.TextBox
    Friend WithEvents txtSalaryPercentForDeductions As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
