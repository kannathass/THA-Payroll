<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BackupData
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
        Me.components = New System.ComponentModel.Container
        Me.ButBackup = New System.Windows.Forms.Button
        Me.ButCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblProcess = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ButBrowse = New System.Windows.Forms.Button
        Me.TbFileName = New System.Windows.Forms.TextBox
        Me.RbtRestore = New System.Windows.Forms.RadioButton
        Me.RbtBackup = New System.Windows.Forms.RadioButton
        Me.DlgOpen = New System.Windows.Forms.OpenFileDialog
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DlgSave = New System.Windows.Forms.SaveFileDialog
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButBackup
        '
        Me.ButBackup.BackColor = System.Drawing.Color.White
        Me.ButBackup.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButBackup.Location = New System.Drawing.Point(128, 238)
        Me.ButBackup.Name = "ButBackup"
        Me.ButBackup.Size = New System.Drawing.Size(75, 23)
        Me.ButBackup.TabIndex = 0
        Me.ButBackup.Text = "OK"
        Me.ButBackup.UseVisualStyleBackColor = False
        '
        'ButCancel
        '
        Me.ButCancel.BackColor = System.Drawing.Color.White
        Me.ButCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButCancel.Location = New System.Drawing.Point(209, 238)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButCancel.TabIndex = 1
        Me.ButCancel.Text = "Cancel"
        Me.ButCancel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProcess)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.ButBrowse)
        Me.GroupBox1.Controls.Add(Me.TbFileName)
        Me.GroupBox1.Controls.Add(Me.RbtRestore)
        Me.GroupBox1.Controls.Add(Me.RbtBackup)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 182)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup/Restore"
        '
        'lblProcess
        '
        Me.lblProcess.AutoSize = True
        Me.lblProcess.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblProcess.Location = New System.Drawing.Point(21, 115)
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.Size = New System.Drawing.Size(0, 13)
        Me.lblProcess.TabIndex = 5
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.White
        Me.ProgressBar1.ForeColor = System.Drawing.Color.Green
        Me.ProgressBar1.Location = New System.Drawing.Point(21, 134)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(236, 20)
        Me.ProgressBar1.Step = 5
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.Visible = False
        '
        'ButBrowse
        '
        Me.ButBrowse.BackColor = System.Drawing.Color.White
        Me.ButBrowse.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ButBrowse.Location = New System.Drawing.Point(182, 78)
        Me.ButBrowse.Name = "ButBrowse"
        Me.ButBrowse.Size = New System.Drawing.Size(75, 23)
        Me.ButBrowse.TabIndex = 3
        Me.ButBrowse.Text = "Browse"
        Me.ButBrowse.UseVisualStyleBackColor = False
        '
        'TbFileName
        '
        Me.TbFileName.Location = New System.Drawing.Point(21, 80)
        Me.TbFileName.Name = "TbFileName"
        Me.TbFileName.Size = New System.Drawing.Size(161, 20)
        Me.TbFileName.TabIndex = 2
        '
        'RbtRestore
        '
        Me.RbtRestore.AutoSize = True
        Me.RbtRestore.Location = New System.Drawing.Point(21, 43)
        Me.RbtRestore.Name = "RbtRestore"
        Me.RbtRestore.Size = New System.Drawing.Size(62, 17)
        Me.RbtRestore.TabIndex = 1
        Me.RbtRestore.Text = "Restore"
        Me.RbtRestore.UseVisualStyleBackColor = True
        '
        'RbtBackup
        '
        Me.RbtBackup.AutoSize = True
        Me.RbtBackup.Checked = True
        Me.RbtBackup.Location = New System.Drawing.Point(21, 20)
        Me.RbtBackup.Name = "RbtBackup"
        Me.RbtBackup.Size = New System.Drawing.Size(62, 17)
        Me.RbtBackup.TabIndex = 0
        Me.RbtBackup.TabStop = True
        Me.RbtBackup.Text = "Backup"
        Me.RbtBackup.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Frm_BackupData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(296, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButBackup)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_BackupData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup/Restore Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButBackup As System.Windows.Forms.Button
    Friend WithEvents ButCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbtRestore As System.Windows.Forms.RadioButton
    Friend WithEvents RbtBackup As System.Windows.Forms.RadioButton
    Friend WithEvents TbFileName As System.Windows.Forms.TextBox
    Friend WithEvents ButBrowse As System.Windows.Forms.Button
    Friend WithEvents DlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblProcess As System.Windows.Forms.Label
    Friend WithEvents DlgSave As System.Windows.Forms.SaveFileDialog
End Class
