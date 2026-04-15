<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Filter_Attendance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVFilterFields = New System.Windows.Forms.DataGridView()
        Me.TableFields = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Comparison = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.FieldValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Conjunction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.DtTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButCancel = New System.Windows.Forms.Button()
        Me.ButGenerate = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtFrom = New System.Windows.Forms.DateTimePicker()
        Me.ButProcessedAttendance = New System.Windows.Forms.Button()
        Me.ButVerificationReport = New System.Windows.Forms.Button()
        Me.ButProcessedMonthly = New System.Windows.Forms.Button()
        Me.ButOTDetail = New System.Windows.Forms.Button()
        CType(Me.DGVFilterFields, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DGVFilterFields.Location = New System.Drawing.Point(65, 80)
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
        Me.DGVFilterFields.Size = New System.Drawing.Size(715, 180)
        Me.DGVFilterFields.TabIndex = 104
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
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(263, 6)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(32, 17)
        Me.LabelError.TabIndex = 107
        Me.LabelError.Text = "Err"
        Me.LabelError.Visible = False
        '
        'DtTo
        '
        Me.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtTo.Location = New System.Drawing.Point(407, 41)
        Me.DtTo.Name = "DtTo"
        Me.DtTo.Size = New System.Drawing.Size(120, 22)
        Me.DtTo.TabIndex = 103
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "To Date :"
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(704, 305)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(134, 23)
        Me.ButCancel.TabIndex = 106
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'ButGenerate
        '
        Me.ButGenerate.BackColor = System.Drawing.Color.White
        Me.ButGenerate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButGenerate.Location = New System.Drawing.Point(34, 305)
        Me.ButGenerate.Name = "ButGenerate"
        Me.ButGenerate.Size = New System.Drawing.Size(270, 23)
        Me.ButGenerate.TabIndex = 105
        Me.ButGenerate.Text = "Actual Attendance"
        Me.ButGenerate.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "From Date :"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DtFrom
        '
        Me.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFrom.Location = New System.Drawing.Point(164, 41)
        Me.DtFrom.Name = "DtFrom"
        Me.DtFrom.Size = New System.Drawing.Size(120, 22)
        Me.DtFrom.TabIndex = 113
        '
        'ButProcessedAttendance
        '
        Me.ButProcessedAttendance.BackColor = System.Drawing.Color.White
        Me.ButProcessedAttendance.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButProcessedAttendance.Location = New System.Drawing.Point(348, 305)
        Me.ButProcessedAttendance.Name = "ButProcessedAttendance"
        Me.ButProcessedAttendance.Size = New System.Drawing.Size(253, 23)
        Me.ButProcessedAttendance.TabIndex = 114
        Me.ButProcessedAttendance.Text = "Processed Attendance"
        Me.ButProcessedAttendance.UseVisualStyleBackColor = False
        '
        'ButVerificationReport
        '
        Me.ButVerificationReport.BackColor = System.Drawing.Color.White
        Me.ButVerificationReport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButVerificationReport.Location = New System.Drawing.Point(34, 343)
        Me.ButVerificationReport.Name = "ButVerificationReport"
        Me.ButVerificationReport.Size = New System.Drawing.Size(270, 23)
        Me.ButVerificationReport.TabIndex = 115
        Me.ButVerificationReport.Text = "Attendance Verification"
        Me.ButVerificationReport.UseVisualStyleBackColor = False
        '
        'ButProcessedMonthly
        '
        Me.ButProcessedMonthly.BackColor = System.Drawing.Color.White
        Me.ButProcessedMonthly.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButProcessedMonthly.Location = New System.Drawing.Point(348, 343)
        Me.ButProcessedMonthly.Name = "ButProcessedMonthly"
        Me.ButProcessedMonthly.Size = New System.Drawing.Size(343, 23)
        Me.ButProcessedMonthly.TabIndex = 116
        Me.ButProcessedMonthly.Text = "Processed Monthly Attendance"
        Me.ButProcessedMonthly.UseVisualStyleBackColor = False
        '
        'ButOTDetail
        '
        Me.ButOTDetail.BackColor = System.Drawing.Color.White
        Me.ButOTDetail.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButOTDetail.Location = New System.Drawing.Point(34, 374)
        Me.ButOTDetail.Name = "ButOTDetail"
        Me.ButOTDetail.Size = New System.Drawing.Size(270, 23)
        Me.ButOTDetail.TabIndex = 117
        Me.ButOTDetail.Text = "OT Detail"
        Me.ButOTDetail.UseVisualStyleBackColor = False
        '
        'Frm_Filter_Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(840, 409)
        Me.Controls.Add(Me.ButOTDetail)
        Me.Controls.Add(Me.ButProcessedMonthly)
        Me.Controls.Add(Me.ButVerificationReport)
        Me.Controls.Add(Me.ButProcessedAttendance)
        Me.Controls.Add(Me.DtFrom)
        Me.Controls.Add(Me.DGVFilterFields)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.DtTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButGenerate)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Filter_Attendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attendance Reports"
        CType(Me.DGVFilterFields, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVFilterFields As DataGridView
    Friend WithEvents TableFields As DataGridViewComboBoxColumn
    Friend WithEvents Comparison As DataGridViewComboBoxColumn
    Friend WithEvents FieldValue As DataGridViewTextBoxColumn
    Friend WithEvents Conjunction As DataGridViewComboBoxColumn
    Friend WithEvents LabelError As Label
    Friend WithEvents DtTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ButCancel As Button
    Friend WithEvents ButGenerate As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DtFrom As DateTimePicker
    Friend WithEvents ButProcessedAttendance As Button
    Friend WithEvents ButVerificationReport As Button
    Friend WithEvents ButProcessedMonthly As Button
    Friend WithEvents ButOTDetail As Button
End Class
