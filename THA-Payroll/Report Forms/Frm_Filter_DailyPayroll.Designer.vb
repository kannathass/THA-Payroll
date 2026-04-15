<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Filter_DailyPayroll
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
        Me.DtPayroll = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.DGVFilterFields = New System.Windows.Forms.DataGridView()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ButGenerateAbsentees = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbPaymentBasis = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.butSingleSwipes = New System.Windows.Forms.Button()
        Me.ButRunningEmployees = New System.Windows.Forms.Button()
        CType(Me.DGVFilterFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(249, 15)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(32, 17)
        Me.LabelError.TabIndex = 96
        Me.LabelError.Text = "Err"
        Me.LabelError.Visible = False
        '
        'DtPayroll
        '
        Me.DtPayroll.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtPayroll.Location = New System.Drawing.Point(205, 59)
        Me.DtPayroll.Name = "DtPayroll"
        Me.DtPayroll.Size = New System.Drawing.Size(120, 24)
        Me.DtPayroll.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 17)
        Me.Label1.TabIndex = 98
        Me.Label1.Text = "Daily Payroll Date :"
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(495, 334)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(165, 23)
        Me.ButCancel.TabIndex = 4
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(378, 12)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(165, 23)
        Me.ButGenerate.TabIndex = 3
        Me.ButGenerate.Text = "Generate Report"
        Me.ButGenerate.UseVisualStyleBackColor = False
        Me.ButGenerate.Visible = False
        '
        'DGVFilterFields
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVFilterFields.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVFilterFields.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterFields.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterFields.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVFilterFields.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableFields, Me.Comparison, Me.FieldValue, Me.Conjunction})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterFields.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVFilterFields.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVFilterFields.Location = New System.Drawing.Point(51, 89)
        Me.DGVFilterFields.Name = "DGVFilterFields"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVFilterFields.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVFilterFields.RowHeadersVisible = False
        Me.DGVFilterFields.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterFields.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGVFilterFields.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVFilterFields.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVFilterFields.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVFilterFields.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVFilterFields.Size = New System.Drawing.Size(609, 219)
        Me.DGVFilterFields.TabIndex = 2
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
        'ButGenerateAbsentees
        '
        Me.ButGenerateAbsentees.BackColor = System.Drawing.Color.White
        Me.ButGenerateAbsentees.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerateAbsentees.Location = New System.Drawing.Point(23, 312)
        Me.ButGenerateAbsentees.Name = "ButGenerateAbsentees"
        Me.ButGenerateAbsentees.Size = New System.Drawing.Size(227, 23)
        Me.ButGenerateAbsentees.TabIndex = 99
        Me.ButGenerateAbsentees.Text = "View Running Absentees"
        Me.ButGenerateAbsentees.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(506, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 23)
        Me.Button1.TabIndex = 100
        Me.Button1.Text = "Day Report"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'cbPaymentBasis
        '
        Me.cbPaymentBasis.FormattingEnabled = True
        Me.cbPaymentBasis.Items.AddRange(New Object() {"Monthly", "Weekly"})
        Me.cbPaymentBasis.Location = New System.Drawing.Point(109, 15)
        Me.cbPaymentBasis.Name = "cbPaymentBasis"
        Me.cbPaymentBasis.Size = New System.Drawing.Size(121, 25)
        Me.cbPaymentBasis.TabIndex = 101
        Me.cbPaymentBasis.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Payment Type :"
        Me.Label2.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'butSingleSwipes
        '
        Me.butSingleSwipes.BackColor = System.Drawing.Color.White
        Me.butSingleSwipes.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butSingleSwipes.Location = New System.Drawing.Point(23, 341)
        Me.butSingleSwipes.Name = "butSingleSwipes"
        Me.butSingleSwipes.Size = New System.Drawing.Size(227, 23)
        Me.butSingleSwipes.TabIndex = 103
        Me.butSingleSwipes.Text = "View Single Swipes"
        Me.butSingleSwipes.UseVisualStyleBackColor = False
        '
        'ButRunningEmployees
        '
        Me.ButRunningEmployees.BackColor = System.Drawing.Color.White
        Me.ButRunningEmployees.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButRunningEmployees.Location = New System.Drawing.Point(256, 312)
        Me.ButRunningEmployees.Name = "ButRunningEmployees"
        Me.ButRunningEmployees.Size = New System.Drawing.Size(227, 23)
        Me.ButRunningEmployees.TabIndex = 104
        Me.ButRunningEmployees.Text = "View Running Employees"
        Me.ButRunningEmployees.UseVisualStyleBackColor = False
        '
        'Frm_Filter_DailyPayroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(672, 376)
        Me.Controls.Add(Me.ButRunningEmployees)
        Me.Controls.Add(Me.butSingleSwipes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbPaymentBasis)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButGenerateAbsentees)
        Me.Controls.Add(Me.DGVFilterFields)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.DtPayroll)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_DailyPayroll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Payroll"
        CType(Me.DGVFilterFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelError As System.Windows.Forms.Label
    Friend WithEvents DtPayroll As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents ButGenerate As System.Windows.Forms.Button
    Friend WithEvents DGVFilterFields As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButGenerateAbsentees As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbPaymentBasis As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TableFields As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Comparison As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents butSingleSwipes As Button
    Friend WithEvents ButRunningEmployees As Button
End Class
