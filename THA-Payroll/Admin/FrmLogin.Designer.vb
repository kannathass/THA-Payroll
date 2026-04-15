<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.ButClose = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.tbUname = New System.Windows.Forms.TextBox()
        Me.tbPassWd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButtonHint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.White
        Me.ButClose.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButClose.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButClose.Location = New System.Drawing.Point(188, 129)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(75, 23)
        Me.ButClose.TabIndex = 4
        Me.ButClose.Text = "&Cancel"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.White
        Me.ButSave.Font = New System.Drawing.Font("Verdana", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButSave.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButSave.Location = New System.Drawing.Point(80, 129)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(75, 23)
        Me.ButSave.TabIndex = 3
        Me.ButSave.Text = "&Login"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'tbUname
        '
        Me.tbUname.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbUname.Location = New System.Drawing.Point(132, 47)
        Me.tbUname.Name = "tbUname"
        Me.tbUname.Size = New System.Drawing.Size(127, 24)
        Me.tbUname.TabIndex = 1
        '
        'tbPassWd
        '
        Me.tbPassWd.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbPassWd.Location = New System.Drawing.Point(132, 93)
        Me.tbPassWd.Name = "tbPassWd"
        Me.tbPassWd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassWd.Size = New System.Drawing.Size(127, 24)
        Me.tbPassWd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(12, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(226, 35)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "BLOSSOM Payroll"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(183, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "-------------------------"
        '
        'ButtonHint
        '
        Me.ButtonHint.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHint.FlatAppearance.BorderSize = 0
        Me.ButtonHint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHint.Image = CType(resources.GetObject("ButtonHint.Image"), System.Drawing.Image)
        Me.ButtonHint.Location = New System.Drawing.Point(266, 95)
        Me.ButtonHint.Name = "ButtonHint"
        Me.ButtonHint.Size = New System.Drawing.Size(19, 17)
        Me.ButtonHint.TabIndex = 15
        Me.ButtonHint.UseVisualStyleBackColor = False
        Me.ButtonHint.Visible = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(342, 166)
        Me.Controls.Add(Me.ButtonHint)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPassWd)
        Me.Controls.Add(Me.tbUname)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents tbUname As System.Windows.Forms.TextBox
    Friend WithEvents tbPassWd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButtonHint As System.Windows.Forms.Button
End Class
