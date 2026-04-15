<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Filter_Employee
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
        Me.LabelError = New System.Windows.Forms.Label()
        Me.DGVFilterField = New System.Windows.Forms.DataGridView()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DtTo = New System.Windows.Forms.DateTimePicker()
        Me.Dtfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButSummary = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbPaymentBasis = New System.Windows.Forms.ComboBox()
        Me.cbEmployeeStatus = New System.Windows.Forms.ComboBox()
        Me.lblEmployeeStatus = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbtAll = New System.Windows.Forms.RadioButton()
        Me.rbtMale = New System.Windows.Forms.RadioButton()
        Me.rbtFemale = New System.Windows.Forms.RadioButton()
        Me.CheckBoxDateFilter = New System.Windows.Forms.CheckBox()
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.BackColor = System.Drawing.Color.PaleGreen
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(190, 12)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 17)
        Me.LabelError.TabIndex = 153
        '
        'DGVFilterField
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVFilterField.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVFilterField.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVFilterField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableFields, Me.Comparison, Me.FieldValue, Me.Conjunction})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVFilterField.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.Location = New System.Drawing.Point(40, 143)
        Me.DGVFilterField.Name = "DGVFilterField"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVFilterField.RowHeadersVisible = False
        Me.DGVFilterField.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFilterField.Size = New System.Drawing.Size(579, 198)
        Me.DGVFilterField.TabIndex = 152
        '
        'TableFields
        '
        Me.TableFields.DisplayStyleForCurrentCellOnly = True
        Me.TableFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TableFields.Frozen = True
        Me.TableFields.HeaderText = "Field"
        Me.TableFields.Name = "TableFields"
        Me.TableFields.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TableFields.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.TableFields.Width = 120
        '
        'Comparison
        '
        Me.Comparison.DisplayStyleForCurrentCellOnly = True
        Me.Comparison.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Comparison.Frozen = True
        Me.Comparison.HeaderText = "Comparison"
        Me.Comparison.Name = "Comparison"
        Me.Comparison.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Comparison.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Comparison.Width = 150
        '
        'FieldValue
        '
        Me.FieldValue.Frozen = True
        Me.FieldValue.HeaderText = "Value"
        Me.FieldValue.Name = "FieldValue"
        Me.FieldValue.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FieldValue.Width = 150
        '
        'Conjunction
        '
        Me.Conjunction.DisplayStyleForCurrentCellOnly = True
        Me.Conjunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Conjunction.Frozen = True
        Me.Conjunction.HeaderText = "Conjunction"
        Me.Conjunction.Name = "Conjunction"
        Me.Conjunction.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Conjunction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Conjunction.Width = 150
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButCancel.Location = New System.Drawing.Point(439, 346)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(140, 23)
        Me.ButCancel.TabIndex = 151
        Me.ButCancel.Text = "&Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButGenerate.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButGenerate.Location = New System.Drawing.Point(258, 346)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(140, 23)
        Me.ButGenerate.TabIndex = 150
        Me.ButGenerate.Text = "&View Profile"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label4.Location = New System.Drawing.Point(465, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 17)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "to"
        '
        'DtTo
        '
        Me.DtTo.CalendarForeColor = System.Drawing.Color.DarkGreen
        Me.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTo.Location = New System.Drawing.Point(489, 91)
        Me.DtTo.Name = "DtTo"
        Me.DtTo.Size = New System.Drawing.Size(120, 24)
        Me.DtTo.TabIndex = 148
        '
        'Dtfrom
        '
        Me.Dtfrom.CalendarForeColor = System.Drawing.Color.DarkGreen
        Me.Dtfrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtfrom.Location = New System.Drawing.Point(340, 91)
        Me.Dtfrom.Name = "Dtfrom"
        Me.Dtfrom.Size = New System.Drawing.Size(121, 24)
        Me.Dtfrom.TabIndex = 147
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(294, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 146
        Me.Label1.Text = "Date"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'ButSummary
        '
        Me.ButSummary.BackColor = System.Drawing.Color.White
        Me.ButSummary.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSummary.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSummary.Location = New System.Drawing.Point(79, 346)
        Me.ButSummary.Name = "ButSummary"
        Me.ButSummary.Size = New System.Drawing.Size(140, 23)
        Me.ButSummary.TabIndex = 154
        Me.ButSummary.Text = "View &Summary"
        Me.ButSummary.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 156
        Me.Label2.Text = "Payment Type :"
        '
        'cbPaymentBasis
        '
        Me.cbPaymentBasis.FormattingEnabled = True
        Me.cbPaymentBasis.Items.AddRange(New Object() {"All", "Monthly", "Weekly"})
        Me.cbPaymentBasis.Location = New System.Drawing.Point(168, 54)
        Me.cbPaymentBasis.Name = "cbPaymentBasis"
        Me.cbPaymentBasis.Size = New System.Drawing.Size(121, 25)
        Me.cbPaymentBasis.TabIndex = 155
        '
        'cbEmployeeStatus
        '
        Me.cbEmployeeStatus.FormattingEnabled = True
        Me.cbEmployeeStatus.Items.AddRange(New Object() {"All", "On Duty", "Resigned"})
        Me.cbEmployeeStatus.Location = New System.Drawing.Point(168, 90)
        Me.cbEmployeeStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cbEmployeeStatus.Name = "cbEmployeeStatus"
        Me.cbEmployeeStatus.Size = New System.Drawing.Size(121, 25)
        Me.cbEmployeeStatus.TabIndex = 202
        '
        'lblEmployeeStatus
        '
        Me.lblEmployeeStatus.AutoSize = True
        Me.lblEmployeeStatus.BackColor = System.Drawing.Color.PaleGreen
        Me.lblEmployeeStatus.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblEmployeeStatus.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblEmployeeStatus.Location = New System.Drawing.Point(22, 94)
        Me.lblEmployeeStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployeeStatus.Name = "lblEmployeeStatus"
        Me.lblEmployeeStatus.Size = New System.Drawing.Size(138, 17)
        Me.lblEmployeeStatus.TabIndex = 203
        Me.lblEmployeeStatus.Text = "Employee Status :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbtAll)
        Me.GroupBox4.Controls.Add(Me.rbtMale)
        Me.GroupBox4.Controls.Add(Me.rbtFemale)
        Me.GroupBox4.Location = New System.Drawing.Point(313, 33)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(307, 46)
        Me.GroupBox4.TabIndex = 204
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Gender"
        '
        'rbtAll
        '
        Me.rbtAll.AutoSize = True
        Me.rbtAll.Checked = True
        Me.rbtAll.Location = New System.Drawing.Point(29, 18)
        Me.rbtAll.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtAll.Name = "rbtAll"
        Me.rbtAll.Size = New System.Drawing.Size(45, 21)
        Me.rbtAll.TabIndex = 198
        Me.rbtAll.TabStop = True
        Me.rbtAll.Text = "All"
        Me.rbtAll.UseVisualStyleBackColor = True
        '
        'rbtMale
        '
        Me.rbtMale.AutoSize = True
        Me.rbtMale.Location = New System.Drawing.Point(115, 17)
        Me.rbtMale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtMale.Name = "rbtMale"
        Me.rbtMale.Size = New System.Drawing.Size(59, 21)
        Me.rbtMale.TabIndex = 196
        Me.rbtMale.Text = "Male"
        Me.rbtMale.UseVisualStyleBackColor = True
        '
        'rbtFemale
        '
        Me.rbtFemale.AutoSize = True
        Me.rbtFemale.Location = New System.Drawing.Point(213, 18)
        Me.rbtFemale.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtFemale.Name = "rbtFemale"
        Me.rbtFemale.Size = New System.Drawing.Size(77, 21)
        Me.rbtFemale.TabIndex = 197
        Me.rbtFemale.Text = "Female"
        Me.rbtFemale.UseVisualStyleBackColor = True
        '
        'CheckBoxDateFilter
        '
        Me.CheckBoxDateFilter.AutoSize = True
        Me.CheckBoxDateFilter.Location = New System.Drawing.Point(615, 98)
        Me.CheckBoxDateFilter.Name = "CheckBoxDateFilter"
        Me.CheckBoxDateFilter.Size = New System.Drawing.Size(18, 17)
        Me.CheckBoxDateFilter.TabIndex = 205
        Me.CheckBoxDateFilter.UseVisualStyleBackColor = True
        '
        'Frm_Filter_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(707, 382)
        Me.Controls.Add(Me.CheckBoxDateFilter)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cbEmployeeStatus)
        Me.Controls.Add(Me.lblEmployeeStatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbPaymentBasis)
        Me.Controls.Add(Me.ButSummary)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.DGVFilterField)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DtTo)
        Me.Controls.Add(Me.Dtfrom)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information"
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents DGVFilterField As System.Windows.Forms.DataGridView
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButGenerate As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableFields As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comparison As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ButSummary As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbPaymentBasis As System.Windows.Forms.ComboBox
    Friend WithEvents cbEmployeeStatus As ComboBox
    Friend WithEvents lblEmployeeStatus As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rbtMale As RadioButton
    Friend WithEvents rbtFemale As RadioButton
    Friend WithEvents rbtAll As RadioButton
    Friend WithEvents CheckBoxDateFilter As CheckBox
End Class
