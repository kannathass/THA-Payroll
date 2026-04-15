Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports SQLDMO

Public Class Frm_BackupData

    Dim FileName As String
    Dim objIniFile As New IniFile(System.Windows.Forms.Application.StartupPath & "\Connection.ini")
    Dim ServerName As String
    Dim DBName As String
    Dim UID As String
    Dim PWD As String
    Dim x As Integer
    Dim Process_Name As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButBackup.Click
        Dim oSQLServer As New SQLDMO.SQLServer
        Dim oBackup As New SQLDMO.Backup
        Dim oRestore As New SQLDMO.Restore
        'Dim BACKUPFILE As String
        Dim DATABASE As String

        'Dim ISec As String
        'Dim constring As String

        Dim FExist As Boolean = System.IO.File.Exists(Trim(TbFileName.Text))

        If FExist And RbtBackup.Checked Then
            MsgBox("The File Name already Exists, type a New Name")
            Exit Sub
        End If

       

        ServerName = objIniFile.GetString("Connection_String", "ServerName", "(none)")
        DBName = objIniFile.GetString("Connection_String", "DatabaseName", "(none)")
        'ISec = objIniFile.GetString("Connection_String", "IntegratedSecurity", "(none)")
        'If ISec = "True" Then

        'Else
        UID = objIniFile.GetString("Connection_String", "UserID", "(none)")
        PWD = objIniFile.GetString("Connection_String", "Password", "(none)")
        'End If

        DATABASE = DBName

        oSQLServer.Connect(ServerName, UID, PWD)
        Dim oRegistry As SQLDMO.Registry2
        oRegistry = oSQLServer.Registry
        ' Current directory
        Debug.Print(oRegistry.BackupDirectory)
        oRegistry.BackupDirectory = System.Windows.Forms.Application.StartupPath & "\Backup"

        oSQLServer.DisConnect()

        oSQLServer.Connect(ServerName, UID, PWD)

        ButBackup.Enabled = False
        ButCancel.Enabled = False


        If RbtBackup.Checked Then
            oBackup.Files = "[" & Trim(TbFileName.Text) & "]"
            oBackup.Database = DATABASE
            oBackup.BackupSetName = DBName
            oBackup.BackupSetDescription = "Backup on " & Date.Now
            Timer1.Interval = 750
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            oBackup.SQLBackup(oSQLServer)
            Process_Name = "Backup"
            x = 0
            oSQLServer.DisConnect()
        Else
            oRestore.Files = FileName
            oRestore.Database = DATABASE
            Timer1.Interval = 750
            Timer1.Enabled = True
            ProgressBar1.Visible = True
            oRestore.SQLRestore(oSQLServer)
            Process_Name = "Restore"
            x = 0
            oSQLServer.DisConnect()
        End If


    End Sub

    Private Sub ButBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButBrowse.Click
        If RbtBackup.Checked = True Then
            DlgSave.Filter = " Backup File (*.bkp) | *.bkp"
            DlgSave.FilterIndex = 1
            DlgSave.ShowDialog()
            FileName = DlgSave.FileName
        Else
            DlgOpen.Filter = " Backup File (*.bkp) | *.bkp"
            DlgOpen.FilterIndex = 1
            DlgOpen.ShowDialog()
            FileName = DlgOpen.FileName
        End If
      
        TbFileName.Text = FileName
    End Sub

    Private Sub RbtBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtBackup.Click
        If RbtBackup.Checked = True Then
            ButBrowse.Enabled = True
            TbFileName.Enabled = False
        End If
    End Sub

    Private Sub RbtRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtRestore.Click
        If RbtRestore.Checked = True Then
            ButBrowse.Enabled = True
            TbFileName.Enabled = False
        End If
    End Sub

    Private Sub Frm_BackupData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButBrowse.Enabled = True
        TbFileName.Enabled = False
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If x > 100 Then
            Timer1.Enabled = False
            ProgressBar1.Visible = False
            lblProcess.Visible = False
            MsgBox("The " & Process_Name & "Process Completed Successfully")
            ButBackup.Enabled = True
            ButCancel.Enabled = True
        Else
            lblProcess.Visible = True
            lblProcess.Text = "The " & Process_Name & " Process is In Progress..."
            ProgressBar1.Value = x
            x = x + 5
        End If
    End Sub
End Class
