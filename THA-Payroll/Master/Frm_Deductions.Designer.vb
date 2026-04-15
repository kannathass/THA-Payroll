<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Deductions
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelError = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.DGVDeductions = New System.Windows.Forms.DataGridView()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.txtDeduction = New System.Windows.Forms.TextBox()
        CType(Me.DGVDeductions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(128, 12)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 17)
        Me.LabelError.TabIndex = 183
        Me.LabelError.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDescription.Location = New System.Drawing.Point(180, 63)
        Me.txtDescription.MaxLength = 500
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(332, 51)
        Me.txtDescription.TabIndex = 178
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(25, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 24)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Deduction Description :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 181
        Me.Label2.Text = "* Deduction Name :"
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.FlatAppearance.BorderSize = 0
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClose.Location = New System.Drawing.Point(471, 415)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(101, 23)
        Me.ButClose.TabIndex = 180
        Me.ButClose.Text = "&Cancel"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.FlatAppearance.BorderSize = 0
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButSave.Location = New System.Drawing.Point(180, 134)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(101, 23)
        Me.ButSave.TabIndex = 179
        Me.ButSave.Text = "&Save"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'DGVDeductions
        '
        Me.DGVDeductions.AllowUserToAddRows = False
        Me.DGVDeductions.AllowUserToDeleteRows = False
        Me.DGVDeductions.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DGVDeductions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DGVDeductions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVDeductions.BackgroundColor = System.Drawing.Color.PaleGreen
        Me.DGVDeductions.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.PaleGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVDeductions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DGVDeductions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDeductions.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGVDeductions.GridColor = System.Drawing.Color.PaleGreen
        Me.DGVDeductions.Location = New System.Drawing.Point(13, 176)
        Me.DGVDeductions.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVDeductions.Name = "DGVDeductions"
        Me.DGVDeductions.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVDeductions.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DGVDeductions.RowHeadersVisible = False
        Me.DGVDeductions.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.DarkGreen
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDeductions.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.DarkGreen
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DarkOliveGreen
        Me.DGVDeductions.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White
        Me.DGVDeductions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DGVDeductions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDeductions.Size = New System.Drawing.Size(559, 232)
        Me.DGVDeductions.TabIndex = 184
        '
        'ButClear
        '
        Me.ButClear.BackColor = System.Drawing.Color.White
        Me.ButClear.FlatAppearance.BorderSize = 0
        Me.ButClear.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClear.Location = New System.Drawing.Point(304, 134)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(101, 23)
        Me.ButClear.TabIndex = 185
        Me.ButClear.Text = "Clea&r"
        Me.ButClear.UseVisualStyleBackColor = False
        '
        'txtDeduction
        '
        Me.txtDeduction.BackColor = System.Drawing.Color.White
        Me.txtDeduction.ForeColor = System.Drawing.Color.DarkGreen
        Me.txtDeduction.Location = New System.Drawing.Point(180, 31)
        Me.txtDeduction.MaxLength = 200
        Me.txtDeduction.Name = "txtDeduction"
        Me.txtDeduction.Size = New System.Drawing.Size(332, 22)
        Me.txtDeduction.TabIndex = 177
        '
        'Frm_Deductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(585, 450)
        Me.Controls.Add(Me.ButClear)
        Me.Controls.Add(Me.DGVDeductions)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDeduction)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.ButSave)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Deductions"
        Me.Text = "Deductions"
        CType(Me.DGVDeductions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelError As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButClose As Button
    Friend WithEvents ButSave As Button
    Friend WithEvents DGVDeductions As DataGridView
    Friend WithEvents ButClear As Button
    Friend WithEvents txtDeduction As TextBox
End Class
