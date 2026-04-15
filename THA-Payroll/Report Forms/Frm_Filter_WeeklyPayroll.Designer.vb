<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Filter_WeeklyPayroll
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CheckedListBoxDepartment = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBoxCategory = New System.Windows.Forms.CheckedListBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGVFilterField = New System.Windows.Forms.DataGridView()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DtEndDate = New System.Windows.Forms.DateTimePicker()
        Me.DtStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckedListBoxDepartment
        '
        Me.CheckedListBoxDepartment.CheckOnClick = True
        Me.CheckedListBoxDepartment.FormattingEnabled = True
        Me.CheckedListBoxDepartment.Location = New System.Drawing.Point(143, 78)
        Me.CheckedListBoxDepartment.Name = "CheckedListBoxDepartment"
        Me.CheckedListBoxDepartment.Size = New System.Drawing.Size(228, 123)
        Me.CheckedListBoxDepartment.TabIndex = 199
        '
        'CheckedListBoxCategory
        '
        Me.CheckedListBoxCategory.CheckOnClick = True
        Me.CheckedListBoxCategory.FormattingEnabled = True
        Me.CheckedListBoxCategory.Location = New System.Drawing.Point(479, 78)
        Me.CheckedListBoxCategory.Name = "CheckedListBoxCategory"
        Me.CheckedListBoxCategory.Size = New System.Drawing.Size(228, 123)
        Me.CheckedListBoxCategory.TabIndex = 198
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDepartment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDepartment.Location = New System.Drawing.Point(32, 78)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(103, 17)
        Me.lblDepartment.TabIndex = 196
        Me.lblDepartment.Text = "Department :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 150
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
        'FieldValue
        '
        Me.FieldValue.Frozen = True
        Me.FieldValue.HeaderText = "Value"
        Me.FieldValue.Name = "FieldValue"
        Me.FieldValue.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.FieldValue.Width = 150
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
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.PaleGreen
        Me.lblCategory.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblCategory.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblCategory.Location = New System.Drawing.Point(389, 78)
        Me.lblCategory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(83, 17)
        Me.lblCategory.TabIndex = 197
        Me.lblCategory.Text = "Category :"
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
        'DGVFilterField
        '
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVFilterField.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVFilterField.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVFilterField.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableFields, Me.Comparison, Me.FieldValue, Me.Conjunction})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterField.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVFilterField.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterField.Location = New System.Drawing.Point(70, 228)
        Me.DGVFilterField.Name = "DGVFilterField"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DGVFilterField.Size = New System.Drawing.Size(609, 113)
        Me.DGVFilterField.TabIndex = 190
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(84, 18)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(25, 17)
        Me.LabelError.TabIndex = 195
        Me.LabelError.Text = "Er"
        Me.LabelError.Visible = False
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(435, 349)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(156, 23)
        Me.ButCancel.TabIndex = 192
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(131, 349)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(160, 23)
        Me.ButGenerate.TabIndex = 191
        Me.ButGenerate.Text = "Generate Report"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label2.Location = New System.Drawing.Point(399, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 287
        Me.Label2.Text = "To Date :"
        '
        'DtEndDate
        '
        Me.DtEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtEndDate.Location = New System.Drawing.Point(479, 47)
        Me.DtEndDate.Name = "DtEndDate"
        Me.DtEndDate.Size = New System.Drawing.Size(120, 22)
        Me.DtEndDate.TabIndex = 286
        '
        'DtStartDate
        '
        Me.DtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtStartDate.Location = New System.Drawing.Point(145, 50)
        Me.DtStartDate.Name = "DtStartDate"
        Me.DtStartDate.Size = New System.Drawing.Size(120, 22)
        Me.DtStartDate.TabIndex = 285
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label3.Location = New System.Drawing.Point(43, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 284
        Me.Label3.Text = "From Date :"
        '
        'Frm_Filter_WeeklyPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(728, 386)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtEndDate)
        Me.Controls.Add(Me.DtStartDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckedListBoxDepartment)
        Me.Controls.Add(Me.CheckedListBoxCategory)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.DGVFilterField)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_WeeklyPayroll"
        Me.Text = "Weekly Payroll"
        CType(Me.DGVFilterField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckedListBoxDepartment As CheckedListBox
    Friend WithEvents CheckedListBoxCategory As CheckedListBox
    Friend WithEvents lblDepartment As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As DataGridViewTextBoxColumn
    Friend WithEvents Comparison As DataGridViewComboBoxColumn
    Friend WithEvents lblCategory As Label
    Friend WithEvents TableFields As DataGridViewComboBoxColumn
    Friend WithEvents DGVFilterField As DataGridView
    Friend WithEvents LabelError As Label
    Friend WithEvents ButCancel As Button
    Friend WithEvents ButGenerate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DtEndDate As DateTimePicker
    Friend WithEvents DtStartDate As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
