<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPage
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
        Me.CryRpt1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'CryRpt1
        '
        Me.CryRpt1.ActiveViewIndex = -1
        Me.CryRpt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CryRpt1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CryRpt1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CryRpt1.Location = New System.Drawing.Point(0, 0)
        Me.CryRpt1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CryRpt1.Name = "CryRpt1"
        Me.CryRpt1.SelectionFormula = ""
        Me.CryRpt1.Size = New System.Drawing.Size(1056, 697)
        Me.CryRpt1.TabIndex = 0
        Me.CryRpt1.ToolPanelWidth = 267
        Me.CryRpt1.ViewTimeSelectionFormula = ""
        '
        'ReportPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 697)
        Me.Controls.Add(Me.CryRpt1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ReportPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Page"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CryRpt1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
