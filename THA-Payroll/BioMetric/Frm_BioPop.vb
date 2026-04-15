Imports System.Data.SqlClient
Public Class Frm_BioPop
    Dim datacon As New ConnectSql
    Dim str As String
    Dim i As Integer
    Dim QueryTree As String

    Private Sub Frm_BioPop_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.Down And txtItem.Focused = True Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub Frm_BioPop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        QueryTree = "SELECT EmployeeCode,EmployeeName FROM tblEmployeePersonnalInfo where EmployeeStatus='On Duty' and Del_Status='0' order by EmployeeCode"
        Call Update_Emp_List()
        'LBItems.Select()
        'LBItems.Focus()
        txtItem.Text = ""
        txtItem.Select()
    End Sub
    Private Sub Update_Emp_List()
        datacon.con.Open()
        datacon.cmd = New SqlCommand(QueryTree, datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        LBItems.Items.Clear()
        While datacon.dr.Read
            str = datacon.dr.GetValue(0) & " - " & datacon.dr.GetValue(1)
            LBItems.Items.Add(Str)
        End While
        If LBItems.Items.Count > 0 Then
            Str = LBItems.Items.Item(0)
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub ButOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButOK.Click
        On Error GoTo ex
        Dim temp() As String
        temp = str.Split("-")
        Frm_Connect_Device.tbUserEmpNo.Text = Trim(temp(0))
        Frm_Connect_Device.tbUserName.Text = Trim(temp(1))
        Me.Close()
ex:
    End Sub

    Private Sub LBItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBItems.SelectedIndexChanged
        On Error GoTo ex
        str = LBItems.SelectedItem.ToString
ex:
    End Sub

    Private Sub ButCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged
        QueryTree = "SELECT EmployeeCode,EmployeeName FROM tblEmployeePersonnalInfo where EmployeeStatus='On Duty' and Del_Status='0' and EmployeeName like '%" & Trim(txtItem.Text) & "%' order by EmployeeCode"
        Call Update_Emp_List()
    End Sub
End Class