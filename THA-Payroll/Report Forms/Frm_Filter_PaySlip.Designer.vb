<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Filter_PaySlip
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVFilterField = New System.Windows.Forms.DataGridView()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButGenerateConsolidatedPaySlip = New System.Windows.Forms.Button()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.CheckedListBoxCategory = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBoxDepartment = New System.Windows.Forms.CheckedListBox()
        Me.ButConsolidatedOTReport = New System.Windows.Forms.Button()
        Me.ButOTReport = New System.Windows.Forms.Button()
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(97, 9)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(32, 17)
        Me.LabelError.TabIndex = 103
        Me.LabelError.Text = "Err"
        Me.LabelError.Visible = False
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(535, 331)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(184, 23)
        Me.ButCancel.TabIndex = 5
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(27, 331)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(188, 23)
        Me.ButGenerate.TabIndex = 4
        Me.ButGenerate.Text = "Generate PaySlip"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(480, 39)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 25)
        Me.cmbYear.TabIndex = 2
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(144, 37)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 25)
        Me.cmbMonth.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(424, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Year :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 17)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Payroll Month :"
        '
        'DGVFilterField
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVFilterField.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVFilterField.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVFilterField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableFields, Me.Comparison, Me.FieldValue, Me.Conjunction})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVFilterField.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.Location = New System.Drawing.Point(89, 226)
        Me.DGVFilterField.Name = "DGVFilterField"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVFilterField.RowHeadersVisible = False
        Me.DGVFilterField.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFilterField.Size = New System.Drawing.Size(609, 99)
        Me.DGVFilterField.TabIndex = 3
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'ButGenerateConsolidatedPaySlip
        '
        Me.ButGenerateConsolidatedPaySlip.BackColor = System.Drawing.Color.White
        Me.ButGenerateConsolidatedPaySlip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerateConsolidatedPaySlip.Location = New System.Drawing.Point(222, 331)
        Me.ButGenerateConsolidatedPaySlip.Name = "ButGenerateConsolidatedPaySlip"
        Me.ButGenerateConsolidatedPaySlip.Size = New System.Drawing.Size(275, 23)
        Me.ButGenerateConsolidatedPaySlip.TabIndex = 113
        Me.ButGenerateConsolidatedPaySlip.Text = "Consolidated PaySlip"
        Me.ButGenerateConsolidatedPaySlip.UseVisualStyleBackColor = False
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDepartment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDepartment.Location = New System.Drawing.Point(31, 73)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(103, 17)
        Me.lblDepartment.TabIndex = 173
        Me.lblDepartment.Text = "Department :"
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.PaleGreen
        Me.lblCategory.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCategory.Location = New System.Drawing.Point(390, 73)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(83, 17)
        Me.lblCategory.TabIndex = 181
        Me.lblCategory.Text = "Category :"
        '
        'CheckedListBoxCategory
        '
        Me.CheckedListBoxCategory.CheckOnClick = True
        Me.CheckedListBoxCategory.FormattingEnabled = True
        Me.CheckedListBoxCategory.Location = New System.Drawing.Point(480, 73)
        Me.CheckedListBoxCategory.Name = "CheckedListBoxCategory"
        Me.CheckedListBoxCategory.Size = New System.Drawing.Size(228, 137)
        Me.CheckedListBoxCategory.TabIndex = 182
        '
        'CheckedListBoxDepartment
        '
        Me.CheckedListBoxDepartment.CheckOnClick = True
        Me.CheckedListBoxDepartment.FormattingEnabled = True
        Me.CheckedListBoxDepartment.Location = New System.Drawing.Point(144, 73)
        Me.CheckedListBoxDepartment.Name = "CheckedListBoxDepartment"
        Me.CheckedListBoxDepartment.Size = New System.Drawing.Size(228, 137)
        Me.CheckedListBoxDepartment.TabIndex = 183
        '
        'ButConsolidatedOTReport
        '
        Me.ButConsolidatedOTReport.BackColor = System.Drawing.Color.White
        Me.ButConsolidatedOTReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButConsolidatedOTReport.Location = New System.Drawing.Point(222, 379)
        Me.ButConsolidatedOTReport.Name = "ButConsolidatedOTReport"
        Me.ButConsolidatedOTReport.Size = New System.Drawing.Size(275, 23)
        Me.ButConsolidatedOTReport.TabIndex = 184
        Me.ButConsolidatedOTReport.Text = "Consolidated OT Report"
        Me.ButConsolidatedOTReport.UseVisualStyleBackColor = False
        '
        'ButOTReport
        '
        Me.ButOTReport.BackColor = System.Drawing.Color.White
        Me.ButOTReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButOTReport.Location = New System.Drawing.Point(27, 379)
        Me.ButOTReport.Name = "ButOTReport"
        Me.ButOTReport.Size = New System.Drawing.Size(188, 23)
        Me.ButOTReport.TabIndex = 185
        Me.ButOTReport.Text = "Monthly OT Report"
        Me.ButOTReport.UseVisualStyleBackColor = False
        '
        'Frm_Filter_PaySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(745, 414)
        Me.Controls.Add(Me.ButOTReport)
        Me.Controls.Add(Me.ButConsolidatedOTReport)
        Me.Controls.Add(Me.CheckedListBoxDepartment)
        Me.Controls.Add(Me.CheckedListBoxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.ButGenerateConsolidatedPaySlip)
        Me.Controls.Add(Me.DGVFilterField)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_PaySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Slip"
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButGenerate As System.Windows.Forms.Button
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGVFilterField As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableFields As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comparison As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ButGenerateConsolidatedPaySlip As Button
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents CheckedListBoxCategory As CheckedListBox
    Friend WithEvents CheckedListBoxDepartment As CheckedListBox
    Friend WithEvents ButConsolidatedOTReport As Button
    Friend WithEvents ButOTReport As Button
End Class
