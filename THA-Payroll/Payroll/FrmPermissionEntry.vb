Public Class FrmPermissionEntry
#Region "Declaration"
    Public PayrollDate As New DateTime
    Dim ExistingMode As Boolean = False
    'Dim DefaultAttendanceAlertForPOP As Boolean = False
    Dim DSEmp As New DataSet
    Dim MyClassPayroll As New clsPayroll
    Public NewPayrollDate As New DateTime
#End Region

    Private Sub FrmPermissionEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            Initialize_Columns()
            If PayrollDate <> Nothing Then
                ExistingMode = True
                calDate.Enabled = True
                FunFillExistingItems()
            Else
                ExistingMode = False
                calDate.Value = NewPayrollDate.ToShortDateString
                FunFillEmployees()
                FunLoadDefaultEmployeeAttendance()
                'DefaultAttendanceAlertForPOP = True
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        'If Validation() = True Then
        FunUpdateEmployeeDailyPayroll()
        Me.Close()
        'End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            DGVDailyPayroll.ClearSelection()
            DGVDailyPayroll.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            DGVDailyPayroll.ClearSelection()

            For i = 0 To DGVDailyPayroll.NewRowIndex - 1
                'For j = 0 To DGVDailyPayroll.ColumnCount - 1
                'If j = 2 Or j = 3 Then
                '    j = 4
                'End If
                If DGVDailyPayroll(1, i).Value <> Nothing And DGVDailyPayroll(1, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                    DGVDailyPayroll.FirstDisplayedScrollingRowIndex = i
                    DGVDailyPayroll.Rows(i).Selected = True
                End If
                'Next
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Initialize_Columns()
        Dim DgvColumn As DataGridViewColumn = DGVDailyPayroll.Columns("EmployeeCode")
        DgvColumn.DisplayIndex = 0
        DgvColumn = DGVDailyPayroll.Columns("EmployeeName")
        DgvColumn.DisplayIndex = 1
        DgvColumn = DGVDailyPayroll.Columns("Permission")
        DgvColumn.DisplayIndex = 2
        DgvColumn = DGVDailyPayroll.Columns("SNo")
        DgvColumn.DisplayIndex = 3
    End Sub

    Public Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i As New Integer
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(PayrollDate, 0, 2)

            If DSEmp.Tables("selectEmployeeDailyPayroll").Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables("selectEmployeeDailyPayroll").Rows.Count - 1
                    DGVDailyPayroll.Rows.Add()
                    calDate.Text = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("DailyPayrollDate")
                    DGVDailyPayroll("SNo", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("SNo")
                    DGVDailyPayroll("EmployeeCode", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("EmployeeCode")
                    DGVDailyPayroll("EmployeeName", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("EmployeeName")
                    DGVDailyPayroll("Permission", i).Value = DSEmp.Tables("selectEmployeeDailyPayroll").Rows(i)("Permission")
                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Public Sub FunFillEmployees()
        Try
            Dim sno As New Long
            Dim i As New Integer
            Dim strDate As DateTime = Now.ToShortDateString     'dummy value
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, 0, 4)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVDailyPayroll.Rows.Add()
                    DGVDailyPayroll("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVDailyPayroll("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                    DGVDailyPayroll("Permission", i).Value = "00:00"
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
                For j = 0 To DGVDailyPayroll.NewRowIndex - 1
                    If DSEmp.Tables(0).Rows(i)("EmpId") = DGVDailyPayroll("EmployeeCode", j).Value Then
                        DGVDailyPayroll("Permission", j).Value = "00:00"
                    End If
                Next
            Next
        Else
            For j = 0 To DGVDailyPayroll.NewRowIndex - 1
                DGVDailyPayroll("Permission", j).Value = "00:00"
            Next
        End If
    End Sub

    Public Sub FunUpdateEmployeeDailyPayroll()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow

            Dim strDate As DateTime = Now.ToShortDateString     'dummy value
            DStemp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, 0, 1)
            For i = 0 To DGVDailyPayroll.NewRowIndex - 1
                'If (Val(DGVDailyPayroll("Morning", i).Value) = 1 Or Val(DGVDailyPayroll("Evening", i).Value) = 1 Or DGVDailyPayroll("Morning", i).Value = True Or DGVDailyPayroll("Evening", i).Value = True) Then
                DStemp.Tables("selectEmployeeDailyPayroll").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeDailyPayroll").NewRow
                MyRow("SNo") = DGVDailyPayroll("SNo", i).Value.ToString
                'MyRow("DailyPayrollDate") = calDate.Value.ToShortDateString
                'MyRow("EmployeeCode") = DGVDailyPayroll("EmployeeCode", i).Value.ToString
                'MyRow("EmployeeName") = DGVDailyPayroll("EmployeeName", i).Value.ToString

                If DGVDailyPayroll("Permission", i).Value <> Nothing Then
                    MyRow("Permission") = DGVDailyPayroll("Permission", i).Value
                Else
                    MyRow("Permission") = "00:00"
                End If
                DStemp.Tables("selectEmployeeDailyPayroll").Rows.Add(MyRow)
                MyClassPayroll.FunUpdateEmployeeDailyPayroll(DStemp, 2)
                'End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class