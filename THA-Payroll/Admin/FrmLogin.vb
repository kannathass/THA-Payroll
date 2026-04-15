Imports System.Data.SqlClient
Public Class FrmLogin
    Dim WrPass As Integer
    Public UName As String
    Public Privilege As String
    Dim PassWd As String
    Dim TpStr As String
    Public EmpID As String
    Dim LoggedIn As String
    Dim datacon As New ConnectSql
    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        Dim ValUser As Boolean
        ValUser = validate_User()
        If ValUser Then
            'Update_Login()
            Me.Hide()
            TexoMain.Show()
        Else
            Show_MsgBox(TpStr)
        End If

        If WrPass = 3 Then
            ButtonHint.Visible = True
            Show_Tooltip("Type User Name and Click to view Hint")
        ElseIf WrPass = 6 Then
            MsgBox("Sorry, Please try Later", MsgBoxStyle.Critical, "Login")
            Application.Exit()
        End If
    End Sub
    Private Sub Update_Login()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Update LoginDetails set Last_Login='" & Date.Now & "',LoggedIn='Yes' where EmpCode='" & EmpID & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub
    Private Function validate_User()
        UName = Trim(tbUname.Text)
        PassWd = Trim(tbPassWd.Text)

        If UName = Nothing And PassWd = Nothing Then
            TpStr = "User Name and Password is Empty"
            WrPass += 1
            Return 0
        ElseIf UName = Nothing Then
            TpStr = "User Name is Empty"
            WrPass += 1
            Return 0
        ElseIf PassWd = Nothing Then
            TpStr = "Password is Empty"
            WrPass += 1
            Return 0
        End If
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from LoginDetails where UName='" & UName & "' and PassWd='" & PassWd & "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read() Then
            EmpID = datacon.dr.GetValue(0)
            LoggedIn = datacon.dr.GetValue(9)
            Privilege = datacon.dr.GetValue(5)
            datacon.dr.Close()
            datacon.con.Close()
            'If LoggedIn = "Yes" Then
            '    TpStr = "The User Already Logged In another System"
            '    Return 0
            'Else
            Return 1
            'End If
        Else
            TpStr = "Invalid User Name/Password"
            datacon.dr.Close()
            datacon.con.Close()
            WrPass += 1
            Return 0
        End If
    End Function
    Private Sub ButClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Application.Exit()
    End Sub

    Private Sub FrmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim cs As New System.Drawing.Size
        Me.BringToFront()
        Static WrPass = 1
    End Sub
    Private Sub Show_Tooltip(ByVal Tpstr As String)
        Dim Tp As New ToolTip
        Tp.Show(Tpstr, Me, ButtonHint.Right + 10, ButtonHint.Bottom + 10, 3000)
    End Sub
    Private Sub Show_MsgBox(ByVal Tpstr As String)
        MsgBox(Tpstr, MsgBoxStyle.Information, "Login")
    End Sub

    Private Sub ButtonHint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHint.Click
        UName = Trim(tbUname.Text)
        TpStr = "Type User Name and Click"
        If UName <> Nothing Then
            TpStr = "Invalid User Name"
            datacon.con.Open()
            datacon.cmd = New SqlCommand("Select Hint from LoginDetails where UName='" & UName & "'", datacon.con)
            datacon.dr = datacon.cmd.ExecuteReader
            If datacon.dr.Read() Then
                TpStr = "Hint : " & datacon.dr.GetValue(0)
            End If
            datacon.dr.Close()
            datacon.con.Close()
        End If
        Show_Tooltip(TpStr)
    End Sub

    Private Sub FrmLogin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class