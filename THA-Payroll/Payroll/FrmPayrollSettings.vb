Imports System.Data.SqlClient

Public Class FrmPayrollSettings

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean
    Dim ExistingMode As Boolean = False
    Dim iMode As New Integer

    Dim CurrentPayrollMonthValue As New Integer

#End Region

#Region "Function"

    Public Sub FunLoadYear()
        Try
            Dim i As New Integer
            For i = 2016 To 2025
                cmbYear.Items.Add(i)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FunDeletePayrollShiftTimeSettings()
        Try
            Dim MyclassConnectSql As New ConnectSql
            Dim MyCommand As New SqlCommand
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandText = "delete from tblPayrollShiftTimeSettings"
            MyCommand.ExecuteNonQuery()
            MyclassConnectSql.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunDeleteListOfHolidays()
        Try
            Dim MyclassConnectSql As New ConnectSql
            Dim MyCommand As New SqlCommand
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandText = "delete from tblListOfHolidays"
            MyCommand.ExecuteNonQuery()
            MyclassConnectSql.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunDeletePayrollOpenCloseSettings()
        Try
            Dim MyclassConnectSql As New ConnectSql
            Dim MyCommand As New SqlCommand
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandText = "delete from tblPayrollOpenCloseSettings"
            MyCommand.ExecuteNonQuery()
            MyclassConnectSql.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSavePayrollShiftTimeSettings()
        Try
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectPayrollShiftTimeSettings(1)
            DStemp.Tables("selectPayrollShiftTimeSettings").Rows.Clear()
            MyRow = DStemp.Tables("selectPayrollShiftTimeSettings").NewRow
            MyRow("SNo") = 0
            MyRow("Date") = Now.ToShortDateString
            MyRow("MorningHrs") = dtpMorning.Text
            MyRow("EveningHrs") = dtpEvening.Text
            MyRow("PermissionHrs") = txtPermisson.Text
            MyRow("MaxLeavePerYear") = NumericUpDown1.Value
            MyRow("MinPFSalaryCriteria") = txtMinimumPFCriteria.Text
            MyRow("MaxPFSalaryCriteria") = txtMaximumPFCriteria.Text
            MyRow("PFEmployeeContribution") = txtPFEmployeeContribution.Text
            MyRow("PFEmployerContribution") = txtPFEmployerContribution.Text
            MyRow("ESIEmployeeContribution") = txtESIEmployeeContribution.Text
            MyRow("ESIEmployerContribution") = txtESIEmployerContribution.Text

            DStemp.Tables("selectPayrollShiftTimeSettings").Rows.Add(MyRow)
            MyClassPayroll.FunSavePayrollShiftTimeSettings(DStemp, 1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveListOfHolidays()
        Try
            Dim i As New Integer
            Dim strDate As DateTime = Now.ToShortDateString         'dummy value
            DSEmp = MyClassPayroll.FunSelectListOfHolidays(strDate, 1)
            Dim MyRow As DataRow
            For i = 0 To DGVListOfHolidays.NewRowIndex - 1
                DSEmp.Tables("selectListOfHolidays").Rows.Clear()
                MyRow = DSEmp.Tables("selectListOfHolidays").NewRow
                Dim MyDate As DateTime = DGVListOfHolidays("Dates", i).Value
                MyRow("SNo") = 0
                MyRow("Date") = MyDate.ToShortDateString
                MyRow("Description") = DGVListOfHolidays("Description", i).Value
                MyRow("String1") = ""
                MyRow("String2") = ""
                MyRow("String3") = ""
                DSEmp.Tables("selectListOfHolidays").Rows.Add(MyRow)
                MyClassPayroll.FunSaveListOfHolidays(DSEmp, 1)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub FunSavePayrollOpenCloseSettings()
        Try
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)
            DStemp.Tables("selectPayrollOpenCloseSettings").Rows.Clear()
            MyRow = DStemp.Tables("selectPayrollOpenCloseSettings").NewRow
            MyRow("SNo") = 0
            MyRow("Date") = Now.ToShortDateString
            MyRow("OpenMonth") = Trim(cmbMonth.Text)
            MyRow("OpenYear") = Trim(cmbYear.Text)
            If rbOpen.Checked = True Then
                MyRow("Status") = "Open"
            ElseIf rbClose.Checked = True Then
                MyRow("Status") = "Close"
            End If
            MyRow("OpenMonthValue") = cmbMonth.SelectedIndex
            MyRow("String2") = ""
            MyRow("String3") = ""
            DStemp.Tables("selectPayrollOpenCloseSettings").Rows.Add(MyRow)
            MyClassPayroll.FunSavePayrollOpenCloseSettings(DStemp, 1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingPayrollShiftTimeSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollShiftTimeSettings(1)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                dtpMorning.Text = DSEmp.Tables(0).Rows(0)("MorningHrs")
                dtpEvening.Text = DSEmp.Tables(0).Rows(0)("EveningHrs")
                txtPermisson.Text = DSEmp.Tables(0).Rows(0)("PermissionHrs")
                NumericUpDown1.Value = DSEmp.Tables(0).Rows(0)("MaxLeavePerYear")
                txtMinimumPFCriteria.Text = DSEmp.Tables(0).Rows(0)("MinPFSalaryCriteria")
                txtMaximumPFCriteria.Text = DSEmp.Tables(0).Rows(0)("MaxPFSalaryCriteria")
                txtPFEmployeeContribution.Text = DSEmp.Tables(0).Rows(0)("PFEmployeeContribution")
                txtPFEmployerContribution.Text = DSEmp.Tables(0).Rows(0)("PFEmployerContribution")
                txtESIEmployeeContribution.Text = DSEmp.Tables(0).Rows(0)("ESIEmployeeContribution")
                txtESIEmployerContribution.Text = DSEmp.Tables(0).Rows(0)("ESIEmployerContribution")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingPayrollOpenCloseSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                cmbMonth.Text = DSEmp.Tables(0).Rows(0)("OpenMonth")
                cmbYear.Text = DSEmp.Tables(0).Rows(0)("OpenYear")
                If DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                    rbOpen.Checked = True
                ElseIf DSEmp.Tables(0).Rows(0)("Status") = "Close" Then
                    rbClose.Checked = True
                End If
                CurrentPayrollMonthValue = DSEmp.Tables(0).Rows(0)("OpenMonthValue")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingWeeklyPayrollOpenCloseSettings()
        Try
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                DtWeeklyStartDate.Value = DSEmp.Tables(0).Rows(0)("FromDate")
                DtWeeklyEndDate.Value = DSEmp.Tables(0).Rows(0)("ToDate")
                If DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                    rbWeeklyOpen.Checked = True
                ElseIf DSEmp.Tables(0).Rows(0)("Status") = "Close" Then
                    rbWeeklyClose.Checked = True
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillExistingListOfHolidays()
        Try
            Dim i As New Integer
            Dim j As Integer = 1
            Dim strDate As DateTime = Now.ToShortDateString         'dummy value
            DSEmp = MyClassPayroll.FunSelectListOfHolidays(strDate, 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVListOfHolidays.Rows.Add()
                    DGVListOfHolidays("SNo", i).Value = j
                    DGVListOfHolidays("Dates", i).Value = DSEmp.Tables(0).Rows(i)("Date")
                    DGVListOfHolidays("Description", i).Value = DSEmp.Tables(0).Rows(i)("Description")
                    j += 1
                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Function ValidationTime() As Boolean
        Return True
    End Function

    Public Function ValidationHolidays() As Boolean
        Return True
    End Function

    Public Function ValidationPayrollOpenClose() As Boolean
        Dim i, Count As New Integer
        Dim Valid As Boolean = True

        If cmbMonth.Text = "Select" Then
            lblErrorMessage.Text = "Select Month."
            Return False
        End If

        Dim SelectMonthValue As Integer = cmbMonth.SelectedIndex
        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)
        If DSEmp.Tables(0).Rows.Count > 0 Then

            Dim Status As String = DSEmp.Tables(0).Rows(0)("Status")
            Dim CurrentPayrollMonthName As String = DSEmp.Tables(0).Rows(0)("OpenMonth")
            Dim CurrentPayrollYear As String = DSEmp.Tables(0).Rows(0)("OpenYear")
            Dim AllowPayrollMonthValue As Integer = DSEmp.Tables(0).Rows(0)("OpenMonthValue")

            Dim AllowPayrollYear As String = DSEmp.Tables(0).Rows(0)("OpenYear")

            If AllowPayrollMonthValue = 12 Then
                AllowPayrollMonthValue = 1
                AllowPayrollYear = Val(CurrentPayrollYear) + 1
            Else
                AllowPayrollMonthValue += 1
            End If



            If rbOpen.Checked = True And Status = "Close" And SelectMonthValue = AllowPayrollMonthValue And AllowPayrollYear = Trim(cmbYear.Text) Then
                Return True
            ElseIf rbOpen.Checked = True And Status = "Open" Then
                lblErrorMessage.Text = "Payroll is Already Opened for the month '" & CurrentPayrollMonthName & "," & CurrentPayrollYear & "'."
                Return False
            ElseIf rbOpen.Checked = True And Status = "Close" Then
                lblErrorMessage.Text = "Payroll is Closed for the month '" & CurrentPayrollMonthName & "," & CurrentPayrollYear & "'." & "Select the Next Month and Open"
                Return False
            End If

            If rbClose.Checked = True And Status = "Open" And SelectMonthValue = CurrentPayrollMonthValue And CurrentPayrollYear = Trim(cmbYear.Text) Then
                Dim msgboxres As MsgBoxResult
                msgboxres = MessageBox.Show("Are you sure to Close the Payroll Month.: " & CurrentPayrollMonthName & "," & CurrentPayrollYear & "'?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxres = MsgBoxResult.Yes Then
                    Return True
                Else
                    Me.Close()
                End If
            ElseIf rbClose.Checked = True And Status = "Open" Then
                lblErrorMessage.Text = "Payroll is Opened month is '" & CurrentPayrollMonthName & "," & CurrentPayrollYear & "'."
            ElseIf rbClose.Checked = True And Status = "Close" Then
                lblErrorMessage.Text = "Payroll is Already Closed for the month '" & CurrentPayrollMonthName & "," & CurrentPayrollYear & "'."
                Return False
            End If
        Else
            If rbClose.Checked = True Then
                lblErrorMessage.Text = "No Payroll available to Close."
                Return False
            ElseIf rbOpen.Checked = True Then
                Return True
            End If
        End If

    End Function

    Public Function ValidationWeeklyPayrollOpenClose() As Boolean
        Dim i, Count As New Integer
        Dim Valid As Boolean = True

        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)
        If DSEmp.Tables(0).Rows.Count > 0 Then

            Dim Status As String = DSEmp.Tables(0).Rows(0)("Status")

            Dim fromDate As Date = DSEmp.Tables(0).Rows(0)("FromDate")
            Dim toDate As Date = DSEmp.Tables(0).Rows(0)("ToDate")

            If (fromDate.Date.AddDays(7) <> DtWeeklyStartDate.Value.Date Or toDate.Date.AddDays(7) <> DtWeeklyEndDate.Value.Date) And Status = "Close" And rbWeeklyOpen.Checked = True Then
                lblErrorMessage.Text = "New payroll week should be next to already closed week (" + fromDate.Date + " - " + toDate.Date + ")"
                Return False
            End If

            If rbWeeklyOpen.Checked = True And Status = "Close" And DtWeeklyStartDate.Value.Date = fromDate.Date.AddDays(7) And DtWeeklyEndDate.Value.Date = toDate.Date.AddDays(7) Then
                Return True
            ElseIf rbWeeklyOpen.Checked = True And Status = "Open" Then
                lblErrorMessage.Text = "Payroll is already Opened for the week (" + fromDate.Date + " - " + toDate.Date + ")"
                Return False
            ElseIf rbWeeklyOpen.Checked = True And Status = "Close" Then
                lblErrorMessage.Text = "Payroll is closed for the week (" + fromDate.Date + " - " + toDate.Date + ")"
                Return False
            End If

            If rbWeeklyClose.Checked = True And Status = "Open" And DtWeeklyStartDate.Value = fromDate And DtWeeklyEndDate.Value = DtWeeklyEndDate.Value Then
                Dim msgboxres As MsgBoxResult
                msgboxres = MessageBox.Show("Are you sure to close the payroll week (" + fromDate.Date + " - " + toDate.Date + ")?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxres = MsgBoxResult.Yes Then
                    Return True
                Else
                    Me.Close()
                End If
            ElseIf rbWeeklyClose.Checked = True And Status = "Open" Then
                lblErrorMessage.Text = "Payroll opened week is (" + fromDate.Date + " - " + toDate.Date + ")"
            ElseIf rbWeeklyClose.Checked = True And Status = "Close" Then
                lblErrorMessage.Text = "Payroll is already closed for the week (" + fromDate.Date + " - " + toDate.Date + ")"
                Return False
            End If
        Else
            If rbWeeklyClose.Checked = True Then
                lblErrorMessage.Text = "No weekly payroll available to close."
                Return False
            ElseIf rbWeeklyOpen.Checked = True Then
                Return True
            End If
        End If

    End Function

#End Region

    Private Sub FrmPayrollSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        cmbMonth.SelectedIndex = 0
        'txtYear.Text = Date.Now.Year
        FunLoadYear()
        FunFillExistingPayrollShiftTimeSettings()
        FunFillExistingListOfHolidays()
        FunFillExistingPayrollOpenCloseSettings()
        FunFillExistingWeeklyPayrollOpenCloseSettings()
    End Sub

    Private Sub btnSaveTimeSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveTimeSetting.Click
        If ValidationTime() = True Then
            FunDeletePayrollShiftTimeSettings()
            FunSavePayrollShiftTimeSettings()
            Me.Close()
        End If
    End Sub

    Private Sub btnCloseTimeSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseTimeSetting.Click
        Me.Close()
    End Sub

    Private Sub btnSaveListOfHolidays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveListOfHolidays.Click
        If ValidationHolidays() = True Then
            FunDeleteListOfHolidays()
            FunSaveListOfHolidays()
            Me.Close()
        End If
    End Sub

    Private Sub btnCloseListOfHolidays_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseListOfHolidays.Click
        Me.Close()
    End Sub

    Private Sub ButSavePayrollOpenClose_Click(sender As Object, e As EventArgs) Handles ButSavePayrollOpenClose.Click
        If ValidationPayrollOpenClose() = True Then
            FunDeletePayrollOpenCloseSettings()
            FunSavePayrollOpenCloseSettings()
            Me.Close()
        End If
    End Sub

    Private Sub ButClosePayrollopenClose_Click(sender As Object, e As EventArgs) Handles ButClosePayrollopenClose.Click
        Me.Close()
    End Sub

    Private Sub DGVListOfHolidays_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVListOfHolidays.CellEnter
        On Error Resume Next
        DGVListOfHolidays(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVListOfHolidays(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVListOfHolidays_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVListOfHolidays.CellLeave
        On Error Resume Next
        DGVListOfHolidays(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVListOfHolidays(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub ButSaveWeeklyPayrollSetting_Click(sender As Object, e As EventArgs) Handles ButSaveWeeklyPayrollSetting.Click
        If ValidationWeeklyPayrollOpenClose() Then
            FunSaveWeeklyPayrollOpenCloseSettings()
            Me.Close()
        End If
    End Sub

    Private Sub ButWeeklyPayrollSettingClose_Click(sender As Object, e As EventArgs) Handles ButWeeklyPayrollSettingClose.Click
        Me.Close()
    End Sub

    Public Sub FunSaveWeeklyPayrollOpenCloseSettings()
        Try
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            Dim fromDate As Date = DtWeeklyStartDate.Value
            Dim toDate As Date = DtWeeklyEndDate.Value

            DStemp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)
            DStemp.Tables("selectPayrollOpenCloseSettings").Rows.Clear()
            MyRow = DStemp.Tables("selectPayrollOpenCloseSettings").NewRow
            MyRow("SNo") = 0
            MyRow("OpenedDate") = Now.ToShortDateString
            MyRow("FromDate") = fromDate
            MyRow("ToDate") = toDate
            If rbWeeklyOpen.Checked = True Then
                MyRow("Status") = "Open"
            ElseIf rbWeeklyClose.Checked = True Then
                MyRow("Status") = "Close"
            End If
            DStemp.Tables("selectPayrollOpenCloseSettings").Rows.Add(MyRow)
            MyClassPayroll.FunSaveWeeklyPayrollOpenCloseSettings(DStemp, 1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class