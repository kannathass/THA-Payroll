<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Filter_MonthlyPayroll
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
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.DGVFilterField = New System.Windows.Forms.DataGridView()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedListBoxDepartment = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBoxCategory = New System.Windows.Forms.CheckedListBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(72, 9)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(25, 17)
        Me.LabelError.TabIndex = 108
        Me.LabelError.Text = "Er"
        Me.LabelError.Visible = False
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(375, 347)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(156, 23)
        Me.ButCancel.TabIndex = 5
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(136, 347)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(160, 23)
        Me.ButGenerate.TabIndex = 4
        Me.ButGenerate.Text = "Generate Report"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'DGVFilterField
        '
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVFilterField.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.DGVFilterField.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.DGVFilterField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableFields, Me.Comparison, Me.FieldValue, Me.Conjunction})
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.DefaultCellStyle = DataGridViewCellStyle28
        Me.DGVFilterField.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.Location = New System.Drawing.Point(75, 226)
        Me.DGVFilterField.Name = "DGVFilterField"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.DGVFilterField.RowHeadersVisible = False
        Me.DGVFilterField.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle30.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVFilterField.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterField.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFilterField.Size = New System.Drawing.Size(609, 113)
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
        'CheckedListBoxDepartment
        '
        Me.CheckedListBoxDepartment.CheckOnClick = True
        Me.CheckedListBoxDepartment.FormattingEnabled = True
        Me.CheckedListBoxDepartment.Location = New System.Drawing.Point(148, 76)
        Me.CheckedListBoxDepartment.Name = "CheckedListBoxDepartment"
        Me.CheckedListBoxDepartment.Size = New System.Drawing.Size(228, 137)
        Me.CheckedListBoxDepartment.TabIndex = 187
        '
        'CheckedListBoxCategory
        '
        Me.CheckedListBoxCategory.CheckOnClick = True
        Me.CheckedListBoxCategory.FormattingEnabled = True
        Me.CheckedListBoxCategory.Location = New System.Drawing.Point(484, 76)
        Me.CheckedListBoxCategory.Name = "CheckedListBoxCategory"
        Me.CheckedListBoxCategory.Size = New System.Drawing.Size(228, 137)
        Me.CheckedListBoxCategory.TabIndex = 186
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.PaleGreen
        Me.lblCategory.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCategory.Location = New System.Drawing.Point(394, 76)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(83, 17)
        Me.lblCategory.TabIndex = 185
        Me.lblCategory.Text = "Category :"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDepartment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDepartment.Location = New System.Drawing.Point(37, 76)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(103, 17)
        Me.lblDepartment.TabIndex = 184
        Me.lblDepartment.Text = "Department :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Payroll Month :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(429, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Year :"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(148, 42)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 25)
        Me.cmbMonth.TabIndex = 1
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(484, 39)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 25)
        Me.cmbYear.TabIndex = 2
        '
        'Frm_Filter_MonthlyPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(725, 382)
        Me.Controls.Add(Me.CheckedListBoxDepartment)
        Me.Controls.Add(Me.CheckedListBoxCategory)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.DGVFilterField)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_MonthlyPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Payroll"
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButGenerate As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGVFilterField As System.Windows.Forms.DataGridView
    Friend WithEvents TableFields As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comparison As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents CheckedListBoxDepartment As CheckedListBox
    Friend WithEvents CheckedListBoxCategory As CheckedListBox
    Friend WithEvents lblCategory As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbYear As ComboBox
End Class
