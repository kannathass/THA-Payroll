Imports System.Data.SqlClient

Public Class FrmMonthlyPayroll

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    'Dim SelectionMode As Boolean
    Dim iMode As New Integer
    Dim isLoaded As Boolean

    Public ExistingMode As Boolean
    Public NewPayrollMonth, NewPayrollYear As String
    Public MonthlyPayrollDate As String
    Public FrmMonthlyPayrollView As Boolean = False

#End Region

    Public Sub FunLoadYear()
        Try
            Dim i As New Integer
            For i = 2016 To 2025
                cmbYear.Items.Add(i)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FunSaveEmployeeMonthlyPayroll()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            Dim strDate As DateTime = Now.ToShortDateString           'dummy value
            DStemp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(strDate, 0, 2)
            MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            For i = 0 To DGVDailyPayroll.RowCount - 1
                '                If Val(DGVDailyPayroll("NoOfDaysWorked", i).Value) > 0 Or _
                '(DGVDailyPayroll("OverTimeHours", i).Value <> Nothing And DGVDailyPayroll("OverTimeHours", i).Value <> "00:00") Or _
                '(DGVDailyPayroll("HolidayOverTimeHours", i).Value <> Nothing And DGVDailyPayroll("HolidayOverTimeHours", i).Value <> "00:00") Or _
                '(DGVDailyPayroll("Permission", i).Value <> Nothing And DGVDailyPayroll("Permission", i).Value <> "00:00") Then

                DStemp.Tables("selectEmployeeMonthlyPayroll").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeMonthlyPayroll").NewRow
                MyRow("SNo") = 0
                MyRow("MonthlyPayrollDate") = MonthlyPayrollDate
                MyRow("EmployeeCode") = DGVDailyPayroll("EmployeeCode", i).Value.ToString
                MyRow("EmployeeName") = DGVDailyPayroll("EmployeeName", i).Value.ToString
                If DGVDailyPayroll("WorkedDays", i).Value <> Nothing Then
                    MyRow("WorkedDays") = DGVDailyPayroll("WorkedDays", i).Value.ToString
                Else
                    MyRow("WorkedDays") = ""
                End If
                If DGVDailyPayroll("Holidays", i).Value <> Nothing Then
                    MyRow("Holidays") = DGVDailyPayroll("Holidays", i).Value.ToString
                Else
                    MyRow("Holidays") = ""
                End If
                If DGVDailyPayroll("CLDays", i).Value <> Nothing Then
                    MyRow("CLDays") = DGVDailyPayroll("CLDays", i).Value.ToString
                Else
                    MyRow("CLDays") = ""
                End If
                If DGVDailyPayroll("ELDays", i).Value <> Nothing Then
                    MyRow("ELDays") = DGVDailyPayroll("ELDays", i).Value.ToString
                Else
                    MyRow("ELDays") = ""
                End If
                If DGVDailyPayroll("TotalPayableDays", i).Value <> Nothing Then
                    MyRow("TotalPayableDays") = DGVDailyPayroll("TotalPayableDays", i).Value.ToString
                Else
                    MyRow("TotalPayableDays") = ""
                End If
                If String.IsNullOrEmpty(DGVDailyPayroll("OTHours", i).Value) = False Then
                    MyRow("OTHours") = DGVDailyPayroll("OTHours", i).Value.ToString
                Else
                    MyRow("OTHours") = ""
                End If
                If String.IsNullOrEmpty(DGVDailyPayroll("PermissionHours", i).Value) = False Then
                    MyRow("PermissionHours") = DGVDailyPayroll("PermissionHours", i).Value.ToString
                Else
                    MyRow("PermissionHours") = ""
                End If
                DStemp.Tables("selectEmployeeMonthlyPayroll").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeMonthlyPayroll(DStemp, 1)
                'End If
            Next
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

            'Dim Year As String
            'Dim str As String
            'Dim arr() As String
            If ExistingMode = False Then
                DSEmp = MyClassPayroll.FunGetEmployeeMonthlyPayroll(MonthlyPayrollDate, 1)
            Else
                DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(MonthlyPayrollDate, "", 2)
            End If

            If DSEmp.Tables(0).Rows.Count > 0 Then
                'str = DSEmp.Tables(0).Rows(i)("MonthlyPayrollDate")
                'arr = str.Split("/")                    'split datetime(mm/dd/yyyy) into month,year
                'Month = Trim(arr(0))
                'Year = Trim(arr(2))
                'cmbMonth.SelectedIndex = Month
                'cmbYear.Text = Year

                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVDailyPayroll.Rows.Add()
                    DGVDailyPayroll("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVDailyPayroll("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                    DGVDailyPayroll("WorkedDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("WorkedDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("WorkedDays"))
                    DGVDailyPayroll("Holidays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("HoliDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("HoliDays"))
                    DGVDailyPayroll("ELDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("ELDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("ELDays"))
                    DGVDailyPayroll("CLDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("CLDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("CLDays"))

                    holidays = MyClassPayroll.FunSelectEmployeeMonthlyPayroll_Holidays(MonthlyPayrollDate, Convert.ToString(DSEmp.Tables(0).Rows(i)("EmployeeCode")), 2)
                    If (holidays <> "NA") Then
                        DGVDailyPayroll("Holidays", i).Value = holidays
                    End If

                    If ExistingMode = False Then
                        totalPayableDays = Convert.ToDecimal(IIf(DSEmp.Tables(0).Rows(i)("TotalPayableDays") = Nothing, 0, DSEmp.Tables(0).Rows(i)("TotalPayableDays"))) + Convert.ToDecimal(IIf(DGVDailyPayroll("Holidays", i).Value = Nothing, 0, DGVDailyPayroll("Holidays", i).Value))
                        'totalPayableDays = Convert.ToDecimal(IIf(DSEmp.Tables(0).Rows(i)("TotalPayableDays") = Nothing, 0, DSEmp.Tables(0).Rows(i)("TotalPayableDays"))) + Convert.ToDecimal(IIf(DSEmp.Tables(0).Rows(i)("HoliDays") = Nothing, 0, DSEmp.Tables(0).Rows(i)("HoliDays")))
                        DGVDailyPayroll("TotalPayableDays", i).Value = totalPayableDays
                    Else
                        DGVDailyPayroll("TotalPayableDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("TotalPayableDays") = Nothing, "", DSEmp.Tables(0).Rows(i)("TotalPayableDays"))
                    End If
                    DGVDailyPayroll("OTHours", i).Value = IIf(DSEmp.Tables(0).Rows(i)("OTHours") = Nothing, "", DSEmp.Tables(0).Rows(i)("OTHours"))
                    DGVDailyPayroll("PermissionHours", i).Value = IIf(DSEmp.Tables(0).Rows(i)("PermissionHours") = Nothing, "", DSEmp.Tables(0).Rows(i)("PermissionHours"))


                Next
            End If


        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunFillMonthlyPayrollSettings()
        Try
            DSEmp = MyClassPayroll.FunGetMonthlyPayroll_Settings(Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text), 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtAllowedDays.Text = DSEmp.Tables(0).Rows(0)("AllowedDays")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
    Public Function Validation() As Boolean
        Dim i, Count As New Integer
        Dim Valid As Boolean = True


        Dim SelectedPayrollMonthValue As String = cmbMonth.SelectedIndex
        Dim SelectedPayrollYear As String = Trim(cmbYear.Text)

        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)
        If DSEmp.Tables(0).Rows.Count > 0 Then
            If DSEmp.Tables(0).Rows(0)("OpenMonthValue") = Trim(SelectedPayrollMonthValue) And
                        DSEmp.Tables(0).Rows(0)("OpenYear") = Trim(SelectedPayrollYear) And
                        DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                'Eligible for Payroll Entry
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

        If DGVDailyPayroll("EmployeeCode", 0).Value = Nothing Then
            lblErrorMessage.Text = "Employee Name is Empty."
            Valid = False
            Exit Function
        End If

        If cmbMonth.Text = "Select" Then
            lblErrorMessage.Text = "Select Month."
            Valid = False
            Exit Function
        End If

        If cmbYear.Text = "Select" Then
            lblErrorMessage.Text = "Select Year."
            Valid = False
            Exit Function
        End If

        If (IsNumeric(txtAllowedDays.Text) = False) Then
            lblErrorMessage.Text = "Allowed Days should be a number."
            Valid = False
            Exit Function
        End If

        'Dim CheckDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
        'If ExistingMode = False Then
        '    DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(CheckDate, 0, 2)
        '    If DSEmp.Tables(0).Rows.Count > 0 Then
        '        lblErrorMessage.Text = "This Payroll Date is already Placed. Select the Payroll Date From the Monthly Payroll List Form"
        '        Valid = False
        '        Exit Function
        '    End If
        'End If

        Return Valid
    End Function

    Private Sub Initialize_Columns()
        Dim DgvColumn As DataGridViewColumn = DGVDailyPayroll.Columns("EmployeeCode")
        DgvColumn.DisplayIndex = 0
        DgvColumn = DGVDailyPayroll.Columns("EmployeeName")
        DgvColumn.DisplayIndex = 1
        DgvColumn = DGVDailyPayroll.Columns("WorkedDays")
        DgvColumn.DisplayIndex = 2
        DgvColumn = DGVDailyPayroll.Columns("HoliDays")
        DgvColumn.DisplayIndex = 3
        DgvColumn = DGVDailyPayroll.Columns("ELDays")
        DgvColumn.DisplayIndex = 4
        DgvColumn = DGVDailyPayroll.Columns("CLDays")
        DgvColumn.DisplayIndex = 5
        DgvColumn = DGVDailyPayroll.Columns("TotalPayableDays")
        DgvColumn.DisplayIndex = 6
        DgvColumn = DGVDailyPayroll.Columns("OTHours")
        DgvColumn.DisplayIndex = 7
        DgvColumn = DGVDailyPayroll.Columns("PermissionHours")
        DgvColumn.DisplayIndex = 8
    End Sub

    Private Sub FrmMonthlyPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            Initialize_Columns()
            cmbMonth.Enabled = False
            cmbYear.Enabled = False
            cmbMonth.Text = NewPayrollMonth
            FunLoadYear()
            cmbYear.Text = Val(NewPayrollYear)
            MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            FunFillExistingItems()
            FunFillMonthlyPayrollSettings()
            isLoaded = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DGVDailyPayroll_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDailyPayroll.CellLeave
        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVDailyPayroll_CellValidating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles DGVDailyPayroll.CellValidating
        If isLoaded = True And DGVDailyPayroll.Columns(e.ColumnIndex).Name = "Holidays" Then
            Dim cell As DataGridViewCell = DGVDailyPayroll.Item(e.ColumnIndex, e.RowIndex)

            If cell.IsInEditMode Then
                Dim c As Control = DGVDailyPayroll.EditingControl
                c.Text = CleanInputNumber(c.Text)
            End If
            'If (DGVDailyPayroll("Holidays", e.RowIndex).Value > DGVDailyPayroll("WorkedDays", e.RowIndex).Value) Then
            '    MsgBox("Holi days count is more thane worked days count")
            '    DGVDailyPayroll("Holidays", e.RowIndex).Value = Nothing
            'End If
        End If


        'Dim cell As DataGridViewCell = DGVDailyPayroll.Item(e.ColumnIndex, e.RowIndex)
        'If cell.IsInEditMode Then
        '    Dim c As Control = DGVDailyPayroll.EditingControl

        '    Select Case DGVDailyPayroll.Columns(e.ColumnIndex).Name
        '        Case "NoOfDaysWorked", "OverTimeHours", "HolidayOverTimeHours", "Permission"
        '            c.Text = CleanInputNumber(c.Text)
        '            'Case "name"
        '            'c.Text = CleanInputAlphabet(c.Text)
        '    End Select
        'End If

        'Dim arr(), str As String
        'Dim hh, mm As New Integer

        'If e.ColumnIndex = 3 Or e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then

        '    If DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value = Nothing Or IsDBNull(DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value) = True Then
        '        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value = "00:00"
        '    End If

        '    str = DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value

        '    If str.Contains(":") = True Then
        '        arr = str.Split(":")
        '        If IsNumeric(Trim(arr(0))) = False Or IsNumeric(Trim(arr(1))) = False Then
        '            DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value = "00:00"
        '        End If
        '    Else
        '        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Value = "00:00"
        '    End If

        'End If

    End Sub

    Private Sub DGVDailyPayroll_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDailyPayroll.CellValueChanged
        If isLoaded = True And DGVDailyPayroll.Columns(e.ColumnIndex).Name = "Holidays" Then
            'If (DGVDailyPayroll("Holidays", e.RowIndex).Value > 26) Then
            '    MsgBox("Holidays count is more than 26 days")
            '    DGVDailyPayroll("Holidays", e.RowIndex).Value = Nothing
            'Else
            'DGVDailyPayroll("TotalPayableDays", e.RowIndex).Value = Convert.ToString(Convert.ToDecimal(DGVDailyPayroll("WorkedDays", e.RowIndex).Value) +
            '                                                                         Convert.ToDecimal(DGVDailyPayroll("Holidays", e.RowIndex).Value) +
            '                                                                         Convert.ToDecimal(DGVDailyPayroll("CLDays", e.RowIndex).Value) +
            '                                                                         Convert.ToDecimal(DGVDailyPayroll("ELDays", e.RowIndex).Value))
            Dim workedDays As Decimal
            Dim Holidays As Decimal
            Dim CLDays As Decimal
            Dim ELDays As Decimal

            Decimal.TryParse(DGVDailyPayroll("WorkedDays", e.RowIndex).Value, workedDays)
            Decimal.TryParse(DGVDailyPayroll("Holidays", e.RowIndex).Value, Holidays)
            Decimal.TryParse(DGVDailyPayroll("CLDays", e.RowIndex).Value, CLDays)
            Decimal.TryParse(DGVDailyPayroll("ELDays", e.RowIndex).Value, ELDays)

            DGVDailyPayroll("TotalPayableDays", e.RowIndex).Value = Convert.ToString(workedDays + Holidays + CLDays + ELDays)

            'End If
        End If
    End Sub

    Private Function CleanInputNumber(ByVal str As String) As String
        'Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
        Return System.Text.RegularExpressions.Regex.Replace(str, "^[a-zA-Z?=.*!@#$%^&*_\-\s]+$", "")
    End Function

    Private Sub DGVDailyPayroll_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVDailyPayroll.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyValue = Keys.Delete Then
            If DGVDailyPayroll.Columns(DGVDailyPayroll.CurrentCell.ColumnIndex).Name = "Holidays" Then
                DGVDailyPayroll.CurrentCell.Value = String.Empty
            End If
        End If
        'If e.KeyCode = Keys.F2 And DGVDailyPayroll.Focused = True Then
        '    Dim rowid As Integer = DGVDailyPayroll.NewRowIndex
        '    Dim ColumnIndex As Integer = DGVDailyPayroll.CurrentCell.ColumnIndex
        '    'If ColumnIndex = 2 Then
        '    Call FunFillPopItem(ColumnIndex, rowid)
        '    'End If
        'End If
    End Sub

    'Private Sub FunFillPopItem(ByVal eColoumn As Integer, ByVal eRow As Integer)
    '    Try
    '        Dim i As New Integer
    '        Dim DuplicateItem As Boolean = False
    '        Dim strDate As New DateTime
    '        Dim ECode, EName As String

    '        If eColoumn = 0 Or eColoumn = 1 Then
    '            FrmMonthlyPayrollView = True
    '            PopEmployeeNames.ShowDialog()
    '            ECode = PopEmployeeNames.Empcode
    '            EName = PopEmployeeNames.EmpName
    '            If ECode <> Nothing Then
    '                For i = 0 To DGVDailyPayroll.NewRowIndex
    '                    If IsDBNull(DGVDailyPayroll("EmployeeCode", i).Value) <> True Then
    '                        If DGVDailyPayroll("EmployeeCode", i).Value <> Nothing Then
    '                            If DGVDailyPayroll("EmployeeCode", i).Value = Trim(ECode) Then
    '                                DuplicateItem = True
    '                            End If
    '                        End If
    '                    End If
    '                Next
    '                If DuplicateItem = False Then
    '                    If ECode <> Nothing Then
    '                        DGVDailyPayroll.Rows.Add()
    '                        DGVDailyPayroll("EmployeeCode", eRow).Value = ECode
    '                        DGVDailyPayroll("EmployeeName", eRow).Value = EName
    '                        'DGVDailyPayroll("OverTimeHours", eRow).Value = "00:00"
    '                        'DGVDailyPayroll("HolidayOverTimeHours", eRow).Value = "00:00"
    '                        'DGVDailyPayroll("Permission", eRow).Value = "00:00"
    '                    End If
    '                Else
    '                    MsgBox("The Selected Item Already in the List Table.")
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        'MsgBox(Err.Description)
    '    End Try
    'End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        If Validation() = True Then
            'If ExistingMode = False Then
            FunSaveEmployeeMonthlyPayroll()
            FunSaveMonthlyPayroll_Settings()
            Me.Close()
            'Else
            'FunDeleteEmpMonthlyPayroll()
            '    FunSaveEmployeeMonthlyPayroll()
            '    Me.Close()
            'End If
        End If
    End Sub

    Private Sub FunSaveMonthlyPayroll_Settings()
        MyClassPayroll.FunMonthlyPayroll_Settings(Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text), Trim(txtAllowedDays.Text), 2)
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub txtFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.TextChanged
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

            For i = 0 To DGVDailyPayroll.RowCount - 1
                'For j = 0 To DGVDailyPayroll.ColumnCount - 1
                For j = 0 To 1
                    If DGVDailyPayroll(j, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                        '' ''Me.DataGridView.FirstDisplayedScrollingRowIndex = SelIndex
                        '' ''Me.GridView.Rows(SelIndex).Selected = True
                        DGVDailyPayroll.FirstDisplayedScrollingRowIndex = i
                        DGVDailyPayroll.Rows(i).Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGVDailyPayroll_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDailyPayroll.CellEnter
        On Error Resume Next
        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVDailyPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub
End Class