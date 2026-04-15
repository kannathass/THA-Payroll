Imports System.Data.SqlClient

Public Class FrmDailyPayroll

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean
    Dim ExistingMode As Boolean = False
    Dim iMode As New Integer
    Dim DefaultAttendanceAlertForPOP As Boolean = False
    Dim InTimeHour, InTimeMinute, OutTimeHour, OutTimeMinute As Integer

    Public NewPayrollDate As New DateTime
    Public PayrollDate As New DateTime

    'Dim isDeleteCell As Boolean
#End Region

    Public Sub FunFillEmployees()
        Try
            Dim sno As New Long
            Dim i As New Integer
            Dim strDate As DateTime = Now.ToShortDateString     'dummy value
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, 0, 4)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    GVPayroll.Rows.Add()
                    GVPayroll("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    GVPayroll("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")

                Next
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    'Public Sub FunDeleteEmpDailyPayroll()
    '    Try
    '        Dim MyclassConnectSql As New ConnectSql
    '        Dim MyCommand As New SqlCommand
    '        MyclassConnectSql.con.Open()
    '        MyCommand.Connection = MyclassConnectSql.con
    '        MyCommand.CommandText = "delete from tblEmployeeDailyPayroll Where DailyPayrollDate= convert(datetime,'" & calDate.Value.ToShortDateString & "',103)"
    '        MyCommand.ExecuteNonQuery()
    '        MyclassConnectSql.con.Close()
    '    Catch ex As Exception
    '        MsgBox(Err.Description)
    '    End Try
    'End Sub

    Public Sub FunSaveEmployeeDailyPayroll()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow

            Dim strDate As DateTime = Now.ToShortDateString     'dummy value
            DStemp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, 0, 2)
            For i = 0 To GVPayroll.RowCount - 1

                DStemp.Tables("selectEmployeeDailyPayroll").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeDailyPayroll").NewRow
                MyRow("SNo") = 0
                MyRow("DailyPayrollDate") = calDate.Value.ToShortDateString
                MyRow("EmployeeCode") = GVPayroll("EmployeeCode", i).Value.ToString
                MyRow("EmployeeName") = GVPayroll("EmployeeName", i).Value.ToString
                If GVPayroll("InTime", i).Value <> Nothing Then
                    MyRow("FirstEntry") = GVPayroll("InTime", i).Value.ToString
                Else
                    MyRow("FirstEntry") = "0:0"
                End If
                If GVPayroll("OutTime", i).Value <> Nothing Then
                    MyRow("LastEntry") = GVPayroll("OutTime", i).Value.ToString
                Else
                    MyRow("LastEntry") = "0:0"
                End If

                If GVPayroll("OverTimeFrom", i).Value <> Nothing Then
                    MyRow("OverTimeFromHours") = GVPayroll("OverTimeFrom", i).Value.ToString
                Else
                    MyRow("OverTimeFromHours") = "0:0"
                End If

                If GVPayroll("OverTimeTo", i).Value <> Nothing Then
                    MyRow("OverTimeToHours") = GVPayroll("OverTimeTo", i).Value.ToString
                Else
                    MyRow("OverTimeToHours") = "0:0"
                End If

                If GVPayroll("OverTimeComment", i).Value <> Nothing Then
                    MyRow("OverTimeComment") = GVPayroll("OverTimeComment", i).Value.ToString
                Else
                    MyRow("OverTimeComment") = ""
                End If

                If GVPayroll("PermissionFrom", i).Value <> Nothing Then
                    MyRow("PermissionFromHours") = GVPayroll("PermissionFrom", i).Value.ToString
                Else
                    MyRow("PermissionFromHours") = "0:0"
                End If

                If GVPayroll("PermissionTo", i).Value <> Nothing Then
                    MyRow("PermissionToHours") = GVPayroll("PermissionTo", i).Value.ToString
                Else
                    MyRow("PermissionToHours") = "0:0"
                End If


                If GVPayroll("PermissionComment", i).Value <> Nothing Then
                    MyRow("PermissionComment") = GVPayroll("PermissionComment", i).Value.ToString
                Else
                    MyRow("PermissionComment") = ""
                End If

                If GVPayroll("OnDutyFrom", i).Value <> Nothing Then
                    MyRow("OnDutyFromHours") = GVPayroll("OnDutyFrom", i).Value.ToString
                Else
                    MyRow("OnDutyFromHours") = "0:0"
                End If

                If GVPayroll("OnDutyTo", i).Value <> Nothing Then
                    MyRow("OnDutyToHours") = GVPayroll("OnDutyTo", i).Value.ToString
                Else
                    MyRow("OnDutyToHours") = "0:0"
                End If

                If GVPayroll("OnDutyComment", i).Value <> Nothing Then
                    MyRow("OnDutyComment") = GVPayroll("OnDutyComment", i).Value.ToString
                Else
                    MyRow("OnDutyComment") = ""
                End If

                If GVPayroll("LeaveTypeFH", i).Value <> Nothing Then
                    MyRow("LeaveTypeFirstHalf") = GVPayroll("LeaveTypeFH", i).Value.ToString
                Else
                    MyRow("LeaveTypeFirstHalf") = ""
                End If

                If GVPayroll("LeaveFirstHalf", i).Value <> Nothing Then
                    MyRow("LeaveFirstHalf") = GVPayroll("LeaveFirstHalf", i).Value
                Else
                    MyRow("LeaveFirstHalf") = 0
                End If
                If GVPayroll("LeaveTypeSH", i).Value <> Nothing Then
                    MyRow("LeaveTypeSecondHalf") = GVPayroll("LeaveTypeSH", i).Value.ToString
                Else
                    MyRow("LeaveTypeSecondHalf") = ""
                End If
                If GVPayroll("LeaveSecondHalf", i).Value <> Nothing Then
                    MyRow("LeaveSecondHalf") = GVPayroll("LeaveSecondHalf", i).Value
                Else
                    MyRow("LeaveSecondHalf") = 0
                End If
                If GVPayroll("LeaveComment", i).Value <> Nothing Then
                    MyRow("LeaveComment") = GVPayroll("LeaveComment", i).Value.ToString
                Else
                    MyRow("LeaveComment") = ""
                End If

                If GVPayroll("ExtraEntry", i).Value <> Nothing Then
                    MyRow("ExtraEntry") = GVPayroll("ExtraEntry", i).Value.ToString
                Else
                    MyRow("ExtraEntry") = "0:0"
                End If

                DStemp.Tables("selectEmployeeDailyPayroll").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeDailyPayroll(DStemp, 1)
                'End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i As New Integer
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(calDate.Value.ToShortDateString, 0, 2)

            If DSEmp.Tables("selectEmployeeDailyPayroll").Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables("selectEmployeeDailyPayroll").Rows.Count - 1
                    GVPayroll.Rows.Add()
                    'calDate.Text = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("DailyPayrollDate")
                    GVPayroll("EmployeeCode", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("EmployeeCode")
                    GVPayroll("EmployeeName", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("EmployeeName")
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("FirstEntry") = "00:00" Then
                        GVPayroll("InTime", i).Value = Nothing
                    Else
                        GVPayroll("InTime", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("FirstEntry")
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LastEntry").ToString = "00:00" Then
                        GVPayroll("OutTime", i).Value = Nothing
                    Else
                        GVPayroll("OutTime", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LastEntry")
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OverTimeFromHours").ToString = "00:00" Then
                        GVPayroll("OverTimeFrom", i).Value = Nothing
                    Else
                        GVPayroll("OverTimeFrom", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OverTimeFromHours")

                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OverTimeToHours").ToString = "00:00" Then
                        GVPayroll("OverTimeTo", i).Value = Nothing
                    Else
                        GVPayroll("OverTimeTo", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OverTimeToHours")
                    End If
                    GVPayroll("OverTimeComment", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OverTimeComment")

                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("PermissionFromHours").ToString = "00:00" Then
                        GVPayroll("PermissionFrom", i).Value = Nothing
                    Else
                        GVPayroll("PermissionFrom", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("PermissionFromHours")
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("PermissionToHours").ToString = "00:00" Then
                        GVPayroll("PermissionTo", i).Value = Nothing
                    Else
                        GVPayroll("PermissionTo", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("PermissionToHours")
                    End If
                    GVPayroll("PermissionComment", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("PermissionComment")

                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OnDutyFromHours").ToString = "00:00" Then
                        GVPayroll("OnDutyFrom", i).Value = Nothing
                    Else
                        GVPayroll("OnDutyFrom", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OnDutyFromHours")
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OnDutyToHours").ToString = "00:00" Then
                        GVPayroll("OnDutyTo", i).Value = Nothing
                    Else
                        GVPayroll("OnDutyTo", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OnDutyToHours")
                    End If
                    GVPayroll("OnDutyComment", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("OnDutyComment")

                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveTypeFirstHalf").ToString <> "" Then
                        GVPayroll("LeaveTypeFH", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveTypeFirstHalf")
                    Else
                        GVPayroll("LeaveTypeFH", i).Value = ""
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveFirstHalf").ToString.ToLower = "false" Then
                        GVPayroll("LeaveFirstHalf", i).Value = 0
                    Else
                        GVPayroll("LeaveFirstHalf", i).Value = 1
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveTypeSecondHalf").ToString <> "" Then
                        GVPayroll("LeaveTypeSH", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveTypeSecondHalf")
                    Else
                        GVPayroll("LeaveTypeSH", i).Value = ""
                    End If
                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveSecondHalf").ToString.ToLower = "false" Then
                        GVPayroll("LeaveSecondHalf", i).Value = 0
                    Else
                        GVPayroll("LeaveSecondHalf", i).Value = 1
                    End If
                    GVPayroll("LeaveComment", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("LeaveComment")

                    If DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("ExtraEntry").ToString = "00:00" Then
                        GVPayroll("ExtraEntry", i).Value = Nothing
                    Else
                        GVPayroll("ExtraEntry", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("ExtraEntry")
                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunLoadDefaultEmployeeAttendance()

        Dim i, j As New Integer
        DSEmp.Clear()
        DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(calDate.Value.ToShortDateString, 0, 8)
        If DSEmp.Tables(0).Rows.Count > 0 Then
            For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                For j = 0 To GVPayroll.RowCount - 1
                    If DSEmp.Tables(0).Rows(i)("EmployeeCode") = GVPayroll("EmployeeCode", j).Value Then
                        GVPayroll("InTime", j).Value = DSEmp.Tables(0).Rows(i)("FirstEntry")
                        If DSEmp.Tables(0).Rows(i)("FirstEntry") <> DSEmp.Tables(0).Rows(i)("LastEntry") Then
                            GVPayroll("OutTime", j).Value = DSEmp.Tables(0).Rows(i)("LastEntry")
                        Else
                            GVPayroll("OutTime", j).Value = ""
                        End If


                    End If
                Next
            Next
        Else

        End If
    End Sub

    Public Function Validation() As Boolean
        Dim i, Count As New Integer
        Dim Valid As Boolean = True

        Dim SelectedPayrollMonthValue As String = calDate.Value.Month
        Dim SelectedPayrollYear As String = calDate.Value.Year
        Dim MonthlyPayrollDate As Date
        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)
        If DSEmp.Tables(0).Rows.Count > 0 Then
            MonthlyPayrollDate = DSEmp.Tables(0).Rows(0)("OpenMonthValue") & "," & DSEmp.Tables(0).Rows(0)("OpenYear")

            If DSEmp.Tables(0).Rows(0)("OpenMonthValue") = Trim(SelectedPayrollMonthValue) And
                        DSEmp.Tables(0).Rows(0)("OpenYear") = Trim(SelectedPayrollYear) And
                        DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                'Eligible for Payroll Entry (Daily payroll date belongs to opened payroll month)
            ElseIf Convert.ToInt16(Format(MonthlyPayrollDate.AddMonths(1), "MM")) = Convert.ToInt16(Trim(SelectedPayrollMonthValue)) And
         Format(MonthlyPayrollDate.AddMonths(1), "yyyy") = Trim(SelectedPayrollYear) And
         DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                'Eligible for Payroll Entry (Daily payroll date belongs tonNext month of opened payroll month)

            ElseIf (DSEmp.Tables(0).Rows(0)("OpenMonthValue") <> Trim(SelectedPayrollMonthValue) Or
                            DSEmp.Tables(0).Rows(0)("OpenYear") <> Trim(SelectedPayrollYear)) And
                            DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                lblErrorMessage.Text = "Payroll OpenMonth is '" & DSEmp.Tables(0).Rows(0)("OpenMonth") & ", " & DSEmp.Tables(0).Rows(0)("OpenYear") & "'"
                Valid = False
                Exit Function
            ElseIf (DSEmp.Tables(0).Rows(0)("OpenMonthValue") <> Trim(SelectedPayrollMonthValue) Or
                        DSEmp.Tables(0).Rows(0)("OpenYear") <> Trim(SelectedPayrollYear)) And
                        DSEmp.Tables(0).Rows(0)("Status") = "Close" Then
                lblErrorMessage.Text = "Payroll Closed Month is '" & DSEmp.Tables(0).Rows(0)("OpenMonth") & ", " & DSEmp.Tables(0).Rows(0)("OpenYear") & "'"
                Valid = False
                Exit Function
            End If
        Else
            MsgBox("Open the Payroll Month From Payroll Settings.")
            Valid = False
            Exit Function
        End If

        'If GVPayroll("EmployeeCode", 0).Value = Nothing Then
        '    lblErrorMessage.Text = "Employee Name is Empty."
        '    Valid = False
        '    Exit Function
        'End If

        If ExistingMode = False Then
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(calDate.Value.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                lblErrorMessage.Text = "This Payroll Date is already Placed. Select the Payroll Date From the Daily Payroll List Form"
                Valid = False
                Exit Function
            End If
        End If

        Return Valid
    End Function

    Private Sub FrmDailyPayroll_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.F2 And GVPayroll.Focused = True Then
            Dim rowid As Integer = GVPayroll.RowCount
            Dim ColumnIndex As Integer = GVPayroll.CurrentCell.ColumnIndex
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

            If eColoumn = 0 Or eColoumn = 1 Then
                PopEmployeeNames.ShowDialog()
                ECode = PopEmployeeNames.Empcode
                EName = PopEmployeeNames.EmpName
                If ECode <> Nothing Then
                    For i = 0 To GVPayroll.RowCount - 1
                        If IsDBNull(GVPayroll("EmployeeCode", i).Value) <> True Then
                            If GVPayroll("EmployeeCode", i).Value <> Nothing Then
                                If GVPayroll("EmployeeCode", i).Value = Trim(ECode) Then
                                    DuplicateItem = True
                                End If
                            End If
                        End If
                    Next
                    If DuplicateItem = False Then
                        If ECode <> Nothing Then
                            GVPayroll.Rows.Add()
                            GVPayroll("EmployeeCode", eRow).Value = ECode
                            GVPayroll("EmployeeName", eRow).Value = EName
                        End If
                    Else
                        MsgBox("The Selected Item Already in the List Table.")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Initialize_Columns()
        Dim DgvColumn As DataGridViewColumn = GVPayroll.Columns("EmployeeCode")
        DgvColumn.DisplayIndex = 0
        DgvColumn = GVPayroll.Columns("EmployeeName")
        DgvColumn.DisplayIndex = 1
        DgvColumn = GVPayroll.Columns("InTime")
        DgvColumn.DisplayIndex = 2
        DgvColumn = GVPayroll.Columns("OutTime")
        DgvColumn.DisplayIndex = 3
        DgvColumn = GVPayroll.Columns("ExtraEntry")
        DgvColumn.DisplayIndex = 4
        DgvColumn = GVPayroll.Columns("OverTimeFrom")
        DgvColumn.DisplayIndex = 5
        DgvColumn = GVPayroll.Columns("OverTimeTo")
        DgvColumn.DisplayIndex = 6
        DgvColumn = GVPayroll.Columns("PermissionFrom")
        DgvColumn.DisplayIndex = 7
        DgvColumn = GVPayroll.Columns("PermissionTo")
        DgvColumn.DisplayIndex = 8
        DgvColumn = GVPayroll.Columns("OnDutyFrom")
        DgvColumn.DisplayIndex = 9
        DgvColumn = GVPayroll.Columns("OnDutyTo")
        DgvColumn.DisplayIndex = 10
        DgvColumn = GVPayroll.Columns("LeaveTypeFH")
        DgvColumn.DisplayIndex = 11
        DgvColumn = GVPayroll.Columns("LeaveFirstHalf")
        DgvColumn.DisplayIndex = 12
        DgvColumn = GVPayroll.Columns("LeaveTypeSH")
        DgvColumn.DisplayIndex = 13
        DgvColumn = GVPayroll.Columns("LeaveSecondHalf")
        DgvColumn.DisplayIndex = 14
        DgvColumn = GVPayroll.Columns("Attendance")
        DgvColumn.DisplayIndex = 15
    End Sub

    Private Sub FrmDailyPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.BringToFront()
            Initialize_Columns()
            If PayrollDate <> Nothing Then
                ExistingMode = True
                calDate.Value = PayrollDate.ToShortDateString
                'calDate.Enabled = True
                FunFillExistingItems()
                DefaultAttendanceAlertForPOP = True
            Else
                ExistingMode = False
                calDate.Value = NewPayrollDate.ToShortDateString
                FunFillEmployees()
                FunLoadDefaultEmployeeAttendance()
                DefaultAttendanceAlertForPOP = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        If Validation() = True Then
            'If ExistingMode = False Then
            '    FunSaveEmployeeDailyPayroll()
            '    Me.Close()
            'Else
            '    FunDeleteEmpDailyPayroll()
            '    FunSaveEmployeeDailyPayroll()
            '    Me.Close()
            'End If
            FunSaveEmployeeDailyPayroll()
            Me.Close()
        End If
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[.a-zA-Z\b\s-]", "")
    End Function

    Private Sub calDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calDate.ValueChanged
        'FunLoadDefaultEmployeeAttendance()
    End Sub

    'Private Sub DGVDailyPayroll_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    Dim cell As DataGridViewCell = GVPayroll.Item(e.ColumnIndex, e.RowIndex)
    '    If cell.IsInEditMode Then
    '        Dim c As Control = GVPayroll.EditingControl

    '        Select Case GVPayroll.Columns(e.ColumnIndex).Name
    '            Case "FirstEntry", "LastEnty", "OverTimeFrom", "OverTimeTo", "PermissionFrom", "PermissionTo", "OnDutyFrom", "OnDutyTo"
    '                c.Text = CleanInputNumber(c.Text)
    '                'Case "name"
    '                'c.Text = CleanInputAlphabet(c.Text)
    '        End Select
    '    End If

    'End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            GVPayroll.ClearSelection()
            GVPayroll.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Private Sub GVPayroll_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles GVPayroll.CellEnter
        On Error Resume Next
        GVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        GVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen

    End Sub

    Private Sub GVPayroll_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles GVPayroll.CellLeave
        On Error Resume Next
        GVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        GVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White

    End Sub

    Private Sub GVPayroll_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles GVPayroll.CellValueChanged
        'If isDeleteCell = False Then

        If DefaultAttendanceAlertForPOP = True Then
            ' FunLoadDefaultEmployeeAttendance()
            Dim str As String

            If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Or e.ColumnIndex = 6 Or e.ColumnIndex = 8 Or e.ColumnIndex = 9 Or e.ColumnIndex = 11 Or e.ColumnIndex = 12 Then
                If GVPayroll(e.ColumnIndex, e.RowIndex).Value <> Nothing Then
                    str = GVPayroll(e.ColumnIndex, e.RowIndex).Value.ToString
                    If IsNumeric(Trim(str)) Then
                        GVPayroll(e.ColumnIndex, e.RowIndex).Value = Trim(str).ToString + ":00"
                    End If
                    If (IsDate(GVPayroll(e.ColumnIndex, e.RowIndex).Value) = False) Then
                        GVPayroll(e.ColumnIndex, e.RowIndex).Value = Nothing
                    End If

                End If

            End If

            If GVPayroll.Columns(e.ColumnIndex).Name = "LeaveTypeFH" Or GVPayroll.Columns(e.ColumnIndex).Name = "LeaveTypeSH" Then
                If (GVPayroll("LeaveTypeFH", e.RowIndex).Value = "OD" And GVPayroll("LeaveTypeSH", e.RowIndex).Value = "OD" And (GVPayroll("InTime", e.RowIndex).Value <> "" Or GVPayroll("OutTime", e.RowIndex).Value <> "")) Then
                    MsgBox("Full day On Duty employees should not have in or out time")
                    GVPayroll("LeaveTypeFH", e.RowIndex).Value = ""
                    GVPayroll("LeaveTypeSH", e.RowIndex).Value = ""
                End If
                If (GVPayroll("LeaveTypeFH", e.RowIndex).Value = "") Then
                    GVPayroll("LeaveFirstHalf", e.RowIndex).Value = False
                Else
                    GVPayroll("LeaveFirstHalf", e.RowIndex).Value = True
                End If
                If (GVPayroll("LeaveTypeSH", e.RowIndex).Value = "") Then
                    GVPayroll("LeaveSecondHalf", e.RowIndex).Value = False
                Else
                    GVPayroll("LeaveSecondHalf", e.RowIndex).Value = True
                End If
                If (GVPayroll("LeaveTypeFH", e.RowIndex).Value <> "" And GVPayroll("LeaveTypeSH", e.RowIndex).Value <> "") Then
                    'GVPayroll("LeaveFirstHalf", e.RowIndex).Value = 1
                    'GVPayroll("LeaveSecondHalf", e.RowIndex).Value = 1
                    If (GVPayroll("InTime", e.RowIndex).Value <> Nothing And GVPayroll("OutTime", e.RowIndex).Value <> Nothing) Then
                        GVPayroll("InTime", e.RowIndex).Value = Nothing
                        GVPayroll("OutTime", e.RowIndex).Value = Nothing
                    End If
                End If

                'If (GVPayroll("LeaveTypeFH", e.RowIndex).Value <> "") Then
                '    GVPayroll("LeaveFirstHalf", e.RowIndex).Value = 1
                'End If
                'If (GVPayroll("LeaveTypeSH", e.RowIndex).Value <> "") Then
                '    GVPayroll("LeaveSecondHalf", e.RowIndex).Value = 1
                'End If
            End If

            If GVPayroll.Columns(e.ColumnIndex).Name = "LeaveFirstHalf" Or GVPayroll.Columns(e.ColumnIndex).Name = "LeaveSecondHalf" Then
                If (GVPayroll("LeaveFirstHalf", e.RowIndex).Value = True And GVPayroll("LeaveSecondHalf", e.RowIndex).Value = True) Then
                    If (GVPayroll("InTime", e.RowIndex).Value <> Nothing And GVPayroll("OutTime", e.RowIndex).Value <> Nothing) Then
                        GVPayroll("InTime", e.RowIndex).Value = Nothing
                        GVPayroll("OutTime", e.RowIndex).Value = Nothing
                    End If
                End If
                If GVPayroll("LeaveFirstHalf", e.RowIndex).Value = False Then
                    GVPayroll("LeaveTypeFH", e.RowIndex).Value = ""
                End If
                If GVPayroll("LeaveSecondHalf", e.RowIndex).Value = False Then
                    GVPayroll("LeaveTypeSH", e.RowIndex).Value = ""
                End If
            End If

            If GVPayroll.Columns(e.ColumnIndex).Name = "InTime" Or GVPayroll.Columns(e.ColumnIndex).Name = "OutTime" Then
                If (checkTimeDifference(GVPayroll("InTime", e.RowIndex).Value, GVPayroll("OutTime", e.RowIndex).Value) <> True) Then
                    MsgBox("Out Time is earlier than In Time")
                    GVPayroll("OutTime", e.RowIndex).Value = Nothing
                    'ElseIf (GVPayroll("InTime", e.RowIndex).Value <> Nothing And GVPayroll("OutTime", e.RowIndex).Value <> Nothing) Then
                    '    GVPayroll("LeaveTypeFH", e.RowIndex).Value = ""
                    '    GVPayroll("LeaveTypeSH", e.RowIndex).Value = ""

                    'GVPayroll("LeaveFirstHalf", e.RowIndex).Value = 0
                    'GVPayroll("LeaveSecondHalf", e.RowIndex).Value = 0
                End If
            ElseIf GVPayroll.Columns(e.ColumnIndex).Name = "OverTimeFrom" Or GVPayroll.Columns(e.ColumnIndex).Name = "OverTimeTo" Then
                If (checkTimeDifference(GVPayroll("OverTimeFrom", e.RowIndex).Value, GVPayroll("OverTimeTo", e.RowIndex).Value) <> True) Then
                    MsgBox("OT out is earlier than OT in Time")
                    GVPayroll("OverTimeTo", e.RowIndex).Value = Nothing
                End If
            ElseIf GVPayroll.Columns(e.ColumnIndex).Name = "PermissionFrom" Or GVPayroll.Columns(e.ColumnIndex).Name = "PermissionTo" Then
                If (checkTimeDifference(GVPayroll("PermissionFrom", e.RowIndex).Value, GVPayroll("PermissionTo", e.RowIndex).Value) <> True) Then
                    MsgBox("Permission out is earlier than Permission in Time")
                    GVPayroll("PermissionTo", e.RowIndex).Value = Nothing
                End If
            ElseIf GVPayroll.Columns(e.ColumnIndex).Name = "OnDutyFrom" Or GVPayroll.Columns(e.ColumnIndex).Name = "OnDutyTo" Then
                If (checkTimeDifference(GVPayroll("OnDutyFrom", e.RowIndex).Value, GVPayroll("OnDutyTo", e.RowIndex).Value) <> True) Then
                    MsgBox("On Duty out is earlier than On Duty in Time")
                    GVPayroll("OnDutyTo", e.RowIndex).Value = Nothing
                End If
            End If
        End If
        'End If
    End Sub

    Private Sub GVPayroll_KeyDown(sender As Object, e As KeyEventArgs) Handles GVPayroll.KeyDown
        If e.KeyValue = Keys.Delete Then
            If GVPayroll.CurrentCell.ColumnIndex = 2 Or GVPayroll.CurrentCell.ColumnIndex = 3 Or GVPayroll.CurrentCell.ColumnIndex = 4 Or GVPayroll.CurrentCell.ColumnIndex = 5 Or GVPayroll.CurrentCell.ColumnIndex = 6 Or GVPayroll.CurrentCell.ColumnIndex = 8 Or GVPayroll.CurrentCell.ColumnIndex = 9 Or GVPayroll.CurrentCell.ColumnIndex = 11 Or GVPayroll.CurrentCell.ColumnIndex = 12 Then
                'isDeleteCell = True
                GVPayroll.CurrentCell.Value = Nothing
                'isDeleteCell = False
            End If
        End If
    End Sub

    Private Function checkTimeDifference(FirstValue As DateTime, SecondValue As DateTime) As Boolean
        If FirstValue <> Nothing And SecondValue <> Nothing Then
            Dim TimeDifference = DateTime.Compare(FirstValue, SecondValue)
            If (TimeDifference >= 0) Then
                Return False
            End If
        End If
        Return True
    End Function

    'Private Sub GVPayroll_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles GVPayroll.DataError
    '    e.ThrowException = False
    'End Sub

    Private Sub GVPayroll_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVPayroll.CellContentClick
        If e.ColumnIndex = 19 Then
            FrmPopDailyPayrollEmpLOG.EmployeeCode = Trim(GVPayroll("EmployeeCode", e.RowIndex).Value.ToString)
            FrmPopDailyPayrollEmpLOG.PayrollDate = Trim(calDate.Value.ToShortDateString)
            FrmPopDailyPayrollEmpLOG.ViewMode = "FillAttendanceLogs"
            FrmPopDailyPayrollEmpLOG.Show()
        End If
    End Sub

    'Private Sub GVPayroll_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles GVPayroll.CellValidating
    'Dim cell As DataGridViewCell = GVPayroll.Item(e.ColumnIndex, e.RowIndex)
    'If cell.IsInEditMode Then
    '    Dim c As Control = GVPayroll.EditingControl

    '    Select Case GVPayroll.Columns(e.ColumnIndex).Name
    '        Case "InTime", "OutTime", "OverTimeFrom", "OverTimeTo", "PermissionFrom", "PermissionTo", "OnDutyFrom", "OnDutyTo"
    '            c.Text = CleanInputNumber(c.Text)
    '            'Case "name"
    '            'c.Text = CleanInputAlphabet(c.Text)
    '    End Select
    'End If
    'End Sub

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            GVPayroll.ClearSelection()

            For i = 0 To GVPayroll.RowCount - 1
                For j = 0 To 1
                    'If j = 2 Or j = 3 Then
                    '    j = 4
                    'End If
                    If GVPayroll(j, i).Value <> Nothing And GVPayroll(j, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                        '' ''Me.DataGridView.FirstDisplayedScrollingRowIndex = SelIndex
                        '' ''Me.GridView.Rows(SelIndex).Selected = True
                        GVPayroll.FirstDisplayedScrollingRowIndex = i
                        GVPayroll.Rows(i).Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class