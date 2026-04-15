Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Public Class FrmWeeklyAttendanceProcess
    Dim datacon As New ConnectSql
    Dim TempDs As New DataSet
    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim MyCommand As New SqlCommand

    Private Sub FrmWeeklyAttendanceProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunLoadYear()
        FunFillExistingPayrollOpenCloseSettings()
        getWeeks()
    End Sub

    Public Sub FunLoadYear()
        Try
            Dim i As New Integer
            For i = 2016 To 2025
                cmbYear.Items.Add(i)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Public Sub FunFillExistingPayrollOpenCloseSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                cmbMonth.Text = DSEmp.Tables(0).Rows(0)("OpenMonth")
                cmbYear.Text = DSEmp.Tables(0).Rows(0)("OpenYear")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub getWeeks()
        'Dim i As Int16
        DSEmp = MyClassPayroll.FunGetWeeksOfPayrollMonth()
        If DSEmp.Tables("WeeksList").Rows.Count > 0 Then
            'lbWeeks.Items.Clear()
            'For i = 0 To DSEmp.Tables("WeeksList").Rows.Count - 1
            '    lbWeeks.Items.Add(DSEmp.Tables("WeeksList").Rows(i)("WeekStart") & " (to) " & DSEmp.Tables("WeeksList").Rows(i)("WeekEnd"))
            'Next
            'lbWeeks.Select()
            DtStartDate.Value = DSEmp.Tables("WeeksList").Rows(0)("WeekStart")
            DtEndDate.Value = DSEmp.Tables("WeeksList").Rows(0)("WeekEnd")
        End If
    End Sub

    Private Sub ButProcess_Click(sender As Object, e As EventArgs) Handles ButProcess.Click
        Dim fromDate As Date
        Dim toDate As Date
        'Dim arr() As String

        'str = lbWeeks.SelectedItem.ToString
        'If lbWeeks.SelectedItem.ToString.Contains(" (to) ") = True And lbWeeks.Items(0).ToString.Contains(" (to) ") = True Then
        If DtStartDate.Value <> DtEndDate.Value Then
            'arr = lbWeeks.SelectedItem.ToString.Split(" (to) ")
            fromDate = DtStartDate.Value

            'arr = lbWeeks.Items(0).ToString.Split(" (to) ")
            toDate = DtEndDate.Value

            MyClassPayroll.FunProcessNightShift(fromDate, toDate)
        Else
            MsgBox("Open a Payroll Month before processing")
        End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub ButGenerate_Click(sender As Object, e As EventArgs) Handles ButGenerate.Click
        If cmbMonth.Text <> "" And cmbYear.Text <> "" Then
            BindMonthlyPayslipDetail()
        Else
            MsgBox("Open a Payroll Month before processing")
        End If
    End Sub

    Public Sub BindMonthlyPayslipDetail()
        Try
            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "PayslipProcessing_Monthly"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            MyCommand.Parameters.AddWithValue("@PayrollMonth", MonthlyPayrollDate)
            MyCommand.ExecuteNonQuery()
            'datacon.con.Close()
            MsgBox("Payroll Processing completed successfully")
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            datacon.con.Close()
        End Try
    End Sub

End Class