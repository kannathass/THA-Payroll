Imports System.Data.SqlClient
Public Class FrmPopAdmin
    Dim datacon As New ConnectSql
    Dim str As String
    Dim i As Integer
    Dim QueryTree As String

    Private Sub FrmPopAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        On Error GoTo ex
        Dim temp() As String
        temp = str.Split("-")

        'For i = 0 To FrmInward.DGVItems.NewRowIndex - 1
        '    If FrmMas_Admin.DGVDetails(1, i).Value.ToString = Trim(temp(0)) Then
        '        MsgBox("Item Already included")
        '        GoTo ex
        '    End If
        'Next

        'FrmMas_Admin.DGVDetails.Rows.Add()
        FrmMas_Admin.DGVDetails(1, FrmMas_Admin.rowid).Value = Trim(temp(0))
        FrmMas_Admin.DGVDetails(2, FrmMas_Admin.rowid).Value = Trim(temp(1))
        FrmMas_Admin.DGVDetails(6, FrmMas_Admin.rowid).Value = " "
        FrmMas_Admin.DGVDetails(7, FrmMas_Admin.rowid).Value = Date.Now
        Me.Close()
ex:
    End Sub

    Private Sub LBItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBItems.SelectedIndexChanged
        On Error GoTo ex
        str = LBItems.SelectedItem.ToString
ex:
    End Sub

    Private Sub FrmPopAdmin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.Down And txtItem.Focused = True Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItem.TextChanged
        QueryTree = "SELECT EmployeeCode,EmployeeName FROM tblEmployeePersonnalInfo where EmployeeStatus='On Duty' and Del_Status='0' and EmployeeName like'%" & Trim(txtItem.Text) & "%' order by EmployeeCode "
        Call Update_Emp_List()
    End Sub
End Class