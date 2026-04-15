Public Class FrmWeeklyPayroll

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    'Dim SelectionMode As Boolean
    Dim iMode As New Integer
    Dim isLoaded As Boolean

    Public ExistingMode As Boolean
    Public NewPayrollMonth, NewPayrollYear As String
    Public FrmMonthlyPayrollView As Boolean = False

    Dim fromDate As Date
    Dim toDate As Date
#End Region

    Private Sub FrmWeeklyPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            Initialize_Columns()

            FunFillExistingWeeklyPayrollOpenCloseSettings()
            'cmbMonth.Enabled = False
            'cmbYear.Enabled = False
            'cmbMonth.Text = NewPayrollMonth
            'FunLoadYear()
            'cmbYear.Text = Val(NewPayrollYear)
            'MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            'FunFillExistingItems()
            'FunFillMonthlyPayrollSettings()
            isLoaded = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingWeeklyPayrollOpenCloseSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                DtStartDate.Value = DSEmp.Tables(0).Rows(0)("FromDate")
                DtEndDate.Value = DSEmp.Tables(0).Rows(0)("ToDate")
                lblMessage.Text = "Current payroll week (" + DtStartDate.Value.Date + " - " + DtEndDate.Value.Date + ") Status (" + DSEmp.Tables(0).Rows(0)("Status") + ")"
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButLoad_Click(sender As Object, e As EventArgs) Handles ButLoad.Click
        'If Validation() = True Then
        ClearForm()
        FunFillExistingItems()
        'End If
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        If (DGVPayroll.Rows.Count > 0) Then
            If Validation() Then
                FunSaveEmployeeWeeklyPayroll()
                FunSaveWeeklyPayroll_Settings()
                Me.Close()
            Else
                MsgBox("You can not save selected weekly payroll. Check the payroll Settings.")
            End If
        Else
            lblErrorMessage.Text = "No Record Found"
            lblErrorMessage.Visible = True
        End If
    End Sub

    Private Sub ButProcessPayroll_Click(sender As Object, e As EventArgs) Handles ButProcessPayroll.Click
        If (DGVPayroll.Rows.Count > 0) Then
            If Validation() Then
                fromDate = DtStartDate.Value

                toDate = DtEndDate.Value
                MyClassPayroll.ProcessWeeklyPayroll(fromDate, toDate)
                MsgBox("Weekly payroll Processing completed successfully")
            Else
                MsgBox("You can not process selected weekly payroll. Check the payroll Settings.")
            End If
        Else
            lblErrorMessage.Text = "No Record Found"
            lblErrorMessage.Visible = True
        End If
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim msgboxRes As New MsgBoxResult

        If Validation() Then
            If (DGVPayroll.Rows.Count > 0) Then
                msgboxRes = MessageBox.Show("Are you sure to Delete the selected weekly payroll?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    fromDate = DtStartDate.Value
                    toDate = DtEndDate.Value
                    MyClassPayroll.FunDeleteEmployeeWeeklyPayroll(fromDate, toDate)
                    Me.Close()
                End If
            Else
                lblErrorMessage.Text = "No Record Found"
                lblErrorMessage.Visible = True
            End If
        Else
            MsgBox("You can not delete selected weekly payroll. Check the payroll Settings.")
        End If
    End Sub

    Private Sub DtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DtStartDate.ValueChanged
        ClearForm()
    End Sub

    Private Sub DtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DtEndDate.ValueChanged
        ClearForm()
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            DGVPayroll.ClearSelection()
            DGVPayroll.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Private Sub DGVPayroll_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayroll.CellEnter
        On Error Resume Next
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVPayroll_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayroll.CellLeave
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVPayroll_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVPayroll.CellValidating
        If isLoaded = True And DGVPayroll.Columns(e.ColumnIndex).Name = "Holidays" Then
            Dim cell As DataGridViewCell = DGVPayroll.Item(e.ColumnIndex, e.RowIndex)

            If cell.IsInEditMode Then
                Dim c As Control = DGVPayroll.EditingControl
                c.Text = CleanInputNumber(c.Text)
            End If
        End If
    End Sub

    Private Sub DGVPayroll_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayroll.CellValueChanged
        If isLoaded = True And DGVPayroll.Columns(e.ColumnIndex).Name = "Holidays" Then
            Dim workedDays As Decimal
            Dim Holidays As Decimal
            Dim CLDays As Decimal
            Dim ELDays As Decimal

            Decimal.TryParse(DGVPayroll("WorkedDays", e.RowIndex).Value, workedDays)
            Decimal.TryParse(DGVPayroll("Holidays", e.RowIndex).Value, Holidays)
            Decimal.TryParse(DGVPayroll("CLDays", e.RowIndex).Value, CLDays)
            Decimal.TryParse(DGVPayroll("ELDays", e.RowIndex).Value, ELDays)

            DGVPayroll("TotalPayableDays", e.RowIndex).Value = Convert.ToString(workedDays + Holidays + CLDays + ELDays)

            'End If
        End If
    End Sub

    Private Sub DGVPayroll_KeyDown(sender As Object, e As KeyEventArgs) Handles DGVPayroll.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyValue = Keys.Delete Then
            If DGVPayroll.Columns(DGVPayroll.CurrentCell.ColumnIndex).Name = "Holidays" Then
                DGVPayroll.CurrentCell.Value = String.Empty
            End If
        End If
    End Sub

#Region "CRUD Functions"
    Private Sub FunSaveEmployeeWeeklyPayroll()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            Dim strDate As DateTime = Now.ToShortDateString           'dummy value
            DStemp = MyClassPayroll.FunSelectEmployeeWeeklyPayroll(strDate, strDate, 0, 1)
            'MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            For i = 0 To DGVPayroll.RowCount - 1

                DStemp.Tables("selectEmployeeMonthlyPayroll").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeMonthlyPayroll").NewRow
                MyRow("SNo") = 0
                MyRow("FromDate") = fromDate
                MyRow("ToDate") = toDate
                MyRow("EmployeeCode") = DGVPayroll("EmployeeCode", i).Value.ToString
                MyRow("EmployeeName") = DGVPayroll("EmployeeName", i).Value.ToString
                If DGVPayroll("WorkedDays", i).Value <> Nothing Then
                    MyRow("WorkedDays") = DGVPayroll("WorkedDays", i).Value.ToString
                Else
                    MyRow("WorkedDays") = ""
                End If
                If DGVPayroll("Holidays", i).Value <> Nothing Then
                    MyRow("Holidays") = DGVPayroll("Holidays", i).Value.ToString
                Else
                    MyRow("Holidays") = ""
                End If
                If DGVPayroll("CLDays", i).Value <> Nothing Then
                    MyRow("CLDays") = DGVPayroll("CLDays", i).Value.ToString
                Else
                    MyRow("CLDays") = ""
                End If
                If DGVPayroll("ELDays", i).Value <> Nothing Then
                    MyRow("ELDays") = DGVPayroll("ELDays", i).Value.ToString
                Else
                    MyRow("ELDays") = ""
                End If
                If DGVPayroll("TotalPayableDays", i).Value <> Nothing Then
                    MyRow("TotalPayableDays") = DGVPayroll("TotalPayableDays", i).Value.ToString
                Else
                    MyRow("TotalPayableDays") = ""
                End If
                If String.IsNullOrEmpty(DGVPayroll("OTHours", i).Value) = False Then
                    MyRow("OTHours") = DGVPayroll("OTHours", i).Value.ToString
                Else
                    MyRow("OTHours") = ""
                End If
                If String.IsNullOrEmpty(DGVPayroll("PermissionHours", i).Value) = False Then
                    MyRow("PermissionHours") = DGVPayroll("PermissionHours", i).Value.ToString
                Else
                    MyRow("PermissionHours") = ""
                End If
                DStemp.Tables("selectEmployeeMonthlyPayroll").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeWeeklyPayroll(DStemp, 1)
                'End If
            Next
            ButProcessPayroll.Enabled = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i, Month As New Integer
            Dim totalPayableDays As Decimal
            Dim holidays As String

            fromDate = DtStartDate.Value

            toDate = DtEndDate.Value
            'If ExistingMode = False Then
            DSEmp = MyClassPayroll.FunGetEmployeeWeeklyPayroll(fromDate, toDate, 1)
            'Else
            '    DSEmp = MyClassPayroll.FunSelectEmployeeWeeklyPayroll(fromDate, toDate, "", 1)
            'End If

            If DSEmp.Tables(0).Rows.Count > 0 Then

                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVPayroll.Rows.Add()
                    DGVPayroll("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVPayroll("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                    DGVPayroll("WorkedDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("WorkedDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("WorkedDays"))

                    DGVPayroll("ELDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("ELDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("ELDays"))
                    DGVPayroll("CLDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("CLDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("CLDays"))

                    'Work pending
                    holidays = MyClassPayroll.FunSelectEmployeeWeeklyPayroll_Holidays(fromDate, toDate, Convert.ToString(DSEmp.Tables(0).Rows(i)("EmployeeCode")), 2)
                    If (holidays <> "NA") Then
                        DGVPayroll("Holidays", i).Value = holidays
                    Else
                        DGVPayroll("Holidays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("HoliDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("HoliDays"))
                    End If

                    If ExistingMode = False Then
                        totalPayableDays = Convert.ToDecimal(IIf(DSEmp.Tables(0).Rows(i)("TotalPayableDays") = Nothing, 0, DSEmp.Tables(0).Rows(i)("TotalPayableDays"))) + Convert.ToDecimal(IIf(DGVPayroll("Holidays", i).Value = Nothing, 0, DGVPayroll("Holidays", i).Value))
                        DGVPayroll("TotalPayableDays", i).Value = totalPayableDays
                    Else
                        DGVPayroll("TotalPayableDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("TotalPayableDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("TotalPayableDays"))
                    End If
                    DGVPayroll("OTHours", i).Value = IIf(DSEmp.Tables(0).Rows(i)("OTHours") = Nothing, "", DSEmp.Tables(0).Rows(i)("OTHours"))
                    DGVPayroll("PermissionHours", i).Value = IIf(DSEmp.Tables(0).Rows(i)("PermissionHours") = Nothing, "", DSEmp.Tables(0).Rows(i)("PermissionHours"))


                Next
                ButProcessPayroll.Enabled = True
            End If

            FunFillWeeklyPayrollSettings()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunSaveWeeklyPayroll_Settings()
        fromDate = DtStartDate.Value
        toDate = DtEndDate.Value
        MyClassPayroll.FunWeeklyPayroll_Settings(fromDate, toDate, IIf(Trim(txtAllowedDays.Text) = "", 0, Trim(txtAllowedDays.Text)), 2)
    End Sub

    Private Sub FunFillWeeklyPayrollSettings()
        Try
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value
            DSEmp = MyClassPayroll.FunGetWeeklyPayroll_Settings(fromDate, toDate, 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtAllowedDays.Text = DSEmp.Tables(0).Rows(0)("AllowedDays")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
#End Region

#Region "General Functions"
    'Action Pending
    Public Function Validation() As Boolean
        Dim Valid As Boolean = True

        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

        If DSEmp.Tables(0).Rows.Count > 0 Then
            Dim Status As String = DSEmp.Tables(0).Rows(0)("Status")

            Dim fromDate As Date = DSEmp.Tables(0).Rows(0)("FromDate")
            Dim toDate As Date = DSEmp.Tables(0).Rows(0)("ToDate")

            If (fromDate.Date <> DtStartDate.Value.Date Or toDate.Date <> DtEndDate.Value.Date Or Status = "Close") Then
                Valid = False
            End If
        End If
        Return Valid
    End Function

    Private Sub Initialize_Columns()
        Dim DgvColumn As DataGridViewColumn = DGVPayroll.Columns("EmployeeCode")
        DgvColumn.DisplayIndex = 0
        DgvColumn = DGVPayroll.Columns("EmployeeName")
        DgvColumn.DisplayIndex = 1
        DgvColumn = DGVPayroll.Columns("WorkedDays")
        DgvColumn.DisplayIndex = 2
        DgvColumn = DGVPayroll.Columns("HoliDays")
        DgvColumn.DisplayIndex = 3
        DgvColumn = DGVPayroll.Columns("ELDays")
        DgvColumn.DisplayIndex = 4
        DgvColumn = DGVPayroll.Columns("CLDays")
        DgvColumn.DisplayIndex = 5
        DgvColumn = DGVPayroll.Columns("TotalPayableDays")
        DgvColumn.DisplayIndex = 6
        DgvColumn = DGVPayroll.Columns("OTHours")
        DgvColumn.DisplayIndex = 7
        DgvColumn = DGVPayroll.Columns("PermissionHours")
        DgvColumn.DisplayIndex = 8
    End Sub

    Sub ClearForm()
        lblErrorMessage.Visible = False
        txtFilter.Clear()
        DGVPayroll.Rows.Clear()
    End Sub

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            DGVPayroll.ClearSelection()

            For i = 0 To DGVPayroll.RowCount - 1
                'For j = 0 To DGVDailyPayroll.ColumnCount - 1
                For j = 0 To 1
                    If DGVPayroll(j, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                        '' ''Me.DataGridView.FirstDisplayedScrollingRowIndex = SelIndex
                        '' ''Me.GridView.Rows(SelIndex).Selected = True
                        DGVPayroll.FirstDisplayedScrollingRowIndex = i
                        DGVPayroll.Rows(i).Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub



    Private Function CleanInputNumber(ByVal str As String) As String
        'Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
        Return System.Text.RegularExpressions.Regex.Replace(str, "^[a-zA-Z?=.*!@#$%^&*_\-\s]+$", "")
    End Function
#End Region
End Class