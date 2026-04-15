Imports System.Data.SqlClient

Public Class FrmSetShiftTimings

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Public EmpCode As String
    Dim datacon As New ConnectSql

    Private Sub Load_Department()
        cmbDptName.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        While datacon.dr.Read
            cmbDptName.Items.Add(datacon.dr.GetValue(0))
        End While
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Public Sub FunFillEmployees()
        Try
            Dim sno As New Long
            Dim i As New Integer
            Dim strDate As DateTime = Now.ToShortDateString     'dummy value
            DGVShiftTimings.Rows.Clear()
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, cmbDptName.Text, 9)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVShiftTimings.Rows.Add()
                    DGVShiftTimings("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVShiftTimings("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                Next
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeShiftTimings()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp.Clear()
            DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 11)
            For i = 0 To DGVShiftTimings.NewRowIndex - 1
                DStemp.Tables("selectEmployeeTab").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeTab").NewRow
                MyRow("employeeCode") = DGVShiftTimings("EmployeeCode", i).Value
                MyRow("FNCheckIn") = dtpFNCheckin.Value.ToShortTimeString
                MyRow("FNCheckOut") = dtpFNCheckOut.Value.ToShortTimeString
                MyRow("ANCheckIn") = dtpANCheckIn.Value.ToShortTimeString
                MyRow("ANCheckOut") = dtpANCheckOut.Value.ToShortTimeString
                MyRow("String1") = 0
                MyRow("String2") = ""
                MyRow("String3") = ""
                DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeShiftTimings(DStemp, 2)
            Next

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Initialize_Columns()
        'EmployeeCode EmployeeName ShowTimings
        Dim DgvColumn As DataGridViewColumn = DGVShiftTimings.Columns("ShowTimings")
        DgvColumn.DisplayIndex = 0
        DgvColumn = DGVShiftTimings.Columns("EmployeeCode")
        DgvColumn.DisplayIndex = 1
        DgvColumn = DGVShiftTimings.Columns("EmployeeName")
        DgvColumn.DisplayIndex = 2
    End Sub

    Private Sub FrmSetShiftTimings_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.F2 And DGVShiftTimings.Focused = True Then
            Dim rowid As Integer = DGVShiftTimings.NewRowIndex
            Dim ColumnIndex As Integer = DGVShiftTimings.CurrentCell.ColumnIndex
            'If ColumnIndex = 2 Then
            Call FunFillPopItem(ColumnIndex, rowid)
            'End If
        End If
    End Sub

    Private Sub FunFillPopItem(ByVal eColoumn As Integer, ByVal eRow As Integer)
        Try

            Dim i As New Integer
            Dim DuplicateItem As Boolean = False
            Dim strDate As New DateTime
            Dim ECode, EName As String

            If eColoumn = 1 Or eColoumn = 2 Then
                PopEmployeeNames.show()
                ECode = PopEmployeeNames.Empcode
                EName = PopEmployeeNames.EmpName
                If ECode <> Nothing Then
                    For i = 0 To DGVShiftTimings.NewRowIndex
                        If IsDBNull(DGVShiftTimings("EmployeeCode", i).Value) <> True Then
                            If DGVShiftTimings("EmployeeCode", i).Value <> Nothing Then
                                If DGVShiftTimings("EmployeeCode", i).Value = Trim(ECode) Then
                                    DuplicateItem = True
                                End If
                            End If
                        End If
                    Next
                    If DuplicateItem = False Then
                        If ECode <> Nothing Then
                            DGVShiftTimings.Rows.Add()
                            DGVShiftTimings("EmployeeCode", eRow).Value = ECode
                            DGVShiftTimings("EmployeeName", eRow).Value = EName
                        End If
                    Else
                        MsgBox("The Selected Item Already in the List Table.")
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub FrmSetShiftTimings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbDptName.Items.Insert(0, "Select")
        Load_Department()
        dtpFNCheckin.Value = "1/1/1980 9:30:00 AM"
        dtpFNCheckOut.Value = "1/1/1980 1:30:00 PM"
        dtpANCheckIn.Value = "1/1/1980 2:30:00 PM"
        dtpANCheckOut.Value = "1/1/1980 7:00:00 PM"
        Initialize_Columns()
    End Sub

    Private Sub cmbDptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDptName.SelectedIndexChanged
        FunFillEmployees()
    End Sub

    Private Sub ButUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButUpdate.Click
        FunSaveEmployeeShiftTimings()
        MsgBox("Shift Timings Updated.")
    End Sub

    Private Sub DGVShiftTimings_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVShiftTimings.CellContentClick

        If e.ColumnIndex = 0 Then
            FrmPopDailyPayrollEmpLOG.EmployeeCode = Trim(DGVShiftTimings("EmployeeCode", e.RowIndex).Value.ToString)
            FrmPopDailyPayrollEmpLOG.PayrollDate = DateTime.Today.Date.Date
            FrmPopDailyPayrollEmpLOG.ViewMode = "FillShiftTimings"
            FrmPopDailyPayrollEmpLOG.show()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class