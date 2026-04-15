<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployeeListing
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
        Me.TrvEmployeeListing = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButEdit = New System.Windows.Forms.Button()
        Me.ButAdd = New System.Windows.Forms.Button()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblFilter = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbDptName = New System.Windows.Forms.ComboBox()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrvEmployeeListing
        '
        Me.TrvEmployeeListing.BackColor = System.Drawing.Color.White
        Me.TrvEmployeeListing.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TrvEmployeeListing.ForeColor = System.Drawing.Color.DarkGreen
        Me.TrvEmployeeListing.Location = New System.Drawing.Point(57, 59)
        Me.TrvEmployeeListing.Margin = New System.Windows.Forms.Padding(4)
        Me.TrvEmployeeListing.Name = "TrvEmployeeListing"
        Me.TrvEmployeeListing.Size = New System.Drawing.Size(671, 650)
        Me.TrvEmployeeListing.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel2.Controls.Add(Me.ButClose)
        Me.Panel2.Controls.Add(Me.ButDelete)
        Me.Panel2.Controls.Add(Me.ButEdit)
        Me.Panel2.Controls.Add(Me.ButAdd)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Navy
        Me.Panel2.Location = New System.Drawing.Point(737, 59)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(120, 651)
        Me.Panel2.TabIndex = 15
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClose.Location = New System.Drawing.Point(4, 610)
        Me.ButClose.Margin = New System.Windows.Forms.Padding(4)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(100, 28)
        Me.ButClose.TabIndex = 5
        Me.ButClose.Text = "&Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.White
        Me.ButDelete.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButDelete.Location = New System.Drawing.Point(4, 575)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(100, 28)
        Me.ButDelete.TabIndex = 4
        Me.ButDelete.Text = "&Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        Me.ButDelete.Visible = False
        '
        'ButEdit
        '
        Me.ButEdit.BackColor = System.Drawing.Color.White
        Me.ButEdit.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButEdit.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButEdit.Location = New System.Drawing.Point(4, 54)
        Me.ButEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButEdit.Name = "ButEdit"
        Me.ButEdit.Size = New System.Drawing.Size(100, 28)
        Me.ButEdit.TabIndex = 3
        Me.ButEdit.Text = "&Edit"
        Me.ButEdit.UseVisualStyleBackColor = False
        '
        'ButAdd
        '
        Me.ButAdd.BackColor = System.Drawing.Color.White
        Me.ButAdd.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButAdd.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButAdd.Location = New System.Drawing.Point(4, 18)
        Me.ButAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.ButAdd.Name = "ButAdd"
        Me.ButAdd.Size = New System.Drawing.Size(100, 28)
        Me.ButAdd.TabIndex = 2
        Me.ButAdd.Text = "&Add"
        Me.ButAdd.UseVisualStyleBackColor = False
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(572, 17)
        Me.txtFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(156, 22)
        Me.txtFilter.TabIndex = 267
        '
        'lblFilter
        '
        Me.lblFilter.AutoSize = True
        Me.lblFilter.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFilter.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblFilter.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFilter.Location = New System.Drawing.Point(468, 21)
        Me.lblFilter.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFilter.Name = "lblFilter"
        Me.lblFilter.Size = New System.Drawing.Size(86, 17)
        Me.lblFilter.TabIndex = 266
        Me.lblFilter.Text = "Filtered By,"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(737, 17)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(53, 25)
        Me.Button1.TabIndex = 268
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbDptName
        '
        Me.cmbDptName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDptName.FormattingEnabled = True
        Me.cmbDptName.Location = New System.Drawing.Point(173, 18)
        Me.cmbDptName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDptName.Name = "cmbDptName"
        Me.cmbDptName.Size = New System.Drawing.Size(285, 24)
        Me.cmbDptName.TabIndex = 270
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDepartment.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDepartment.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblDepartment.Location = New System.Drawing.Point(56, 22)
        Me.lblDepartment.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(103, 17)
        Me.lblDepartment.TabIndex = 269
        Me.lblDepartment.Text = "Department :"
        '
        'FrmEmployeeListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(899, 725)
        Me.Controls.Add(Me.cmbDptName)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.lblFilter)
        Me.Controls.Add(Me.TrvEmployeeListing)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEmployeeListing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee List"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrvEmployeeListing As System.Windows.Forms.TreeView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButEdit As System.Windows.Forms.Button
    Friend WithEvents ButAdd As System.Windows.Forms.Button
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents lblFilter As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbDptName As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartment As System.Windows.Forms.Label
End Class
