Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportPage
#Region "Define"
    Public FrmName As String
    Dim datacon As New ConnectSql
    Private Daily_Payroll As DailyPayroll
    'Private Monthly_Attendance As AttendanceMonthlyProcessedConsolidated
    Private Monthly_Attendance As AttendanceMonthlyConsolidated
    Private Pay_Slip As MonthlyPayslip
    Private Pay_Slip_Consolidated As MonthlyPayslipConsolidated
    Private OT_Consolidated As MonthlyOTConsolidated
    Private Monthly_OT_Detail As MonthlyOTDetail

    Private Employee_Profile As EmployeeDetails
    Private Employee_Summ As EmployeeSummary
    Private Daily_Absentees As DailyAbsentees
    'Private LateComer_Daily As LateComers
    Private Attendance_Actual As AttendanceActual
    Private Attendance_Processed As AttendanceProcessed
    Private Attendance_Verification As AttendanceVerificationReport
    Private Attendance_Processed_Montly As AttendanceMonthlyProcessed
    Private Attendance_Actual_Absentees As AttendanceActualAbsentees
    Private Attendance_SingleEntries_Processed As AttendanceProcessedSingleEntries
    Private Attendance_Running_Employees As AttendanceRunningEmployees
    Private OT_Detail As OTDetail

    Private Weekly_Consolidated_Payslip As WeeklyPayslipConsolidated

    Dim objIniFile As New IniFile(Application.StartupPath & "\Connection.ini")

#End Region
    Private Sub ReportPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Dim ISec As String
        'RefreshReport()

        Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
        myConnectionInfo.ServerName = objIniFile.GetString("Connection_String", "ServerName", "(none)")
        myConnectionInfo.DatabaseName = objIniFile.GetString("Connection_String", "DatabaseName", "(none)")
        ISec = objIniFile.GetString("Connection_String", "IntegratedSecurity", "(none)")
        If ISec = "True" Then
            myConnectionInfo.IntegratedSecurity = True
        Else
            myConnectionInfo.UserID = objIniFile.GetString("Connection_String", "UserID", "(none)")
            myConnectionInfo.Password = objIniFile.GetString("Connection_String", "Password", "(none)")
        End If
        CryRpt1.ShowRefreshButton = False
        CryRpt1.ShowCloseButton = False
        CryRpt1.ShowGroupTreeButton = False

        If FrmName = "DailyPayroll" Then
            Daily_Payroll = New DailyPayroll
            SetDBLogonForReport(myConnectionInfo, Daily_Payroll)
            CryRpt1.SelectionFormula = Trim(Frm_Filter_DailyPayroll.ReportQuery)
            CryRpt1.ReportSource = Daily_Payroll
        ElseIf FrmName = "Monthly_Attendance" Then
            'Monthly_Attendance = New AttendanceMonthlyProcessedConsolidated
            'Monthly_Attendance = New AttendanceMonthlyConsolidated
            'SetDBLogonForReport(myConnectionInfo, Monthly_Attendance)
            'CryRpt1.ReportSource = Monthly_Attendance


            Dim psfields As New ParameterFields
            Dim psfield1 As New ParameterField
            Dim disval1 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "PayrollMonth"

            disval1.Value = Frm_Filter_MonthlyPayroll.PayrollMonth

            psfield1.CurrentValues.Add(disval1)

            psfields.Add(psfield1)

            Monthly_Attendance = New AttendanceMonthlyConsolidated
            SetDBLogonForReport(myConnectionInfo, Monthly_Attendance)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.ReportSource = Monthly_Attendance
        ElseIf FrmName = "Weekly_Consolidated_Payslip" Then
            Dim psfields As New ParameterFields
            Dim psfield1 As New ParameterField
            Dim disval1 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"

            disval1.Value = Frm_Filter_WeeklyPayroll.FromDate

            psfield1.CurrentValues.Add(disval1)

            psfields.Add(psfield1)

            Dim psfield2 As New ParameterField
            Dim disval2 As New ParameterDiscreteValue

            psfield2.ParameterFieldName = "ToDate"

            disval2.Value = Frm_Filter_WeeklyPayroll.ToDate

            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)

            Weekly_Consolidated_Payslip = New WeeklyPayslipConsolidated
            SetDBLogonForReport(myConnectionInfo, Weekly_Consolidated_Payslip)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.ReportSource = Weekly_Consolidated_Payslip
        ElseIf FrmName = "Monthly_Pay_Slip" Then
            'Pay_Slip = New PaySlip
            'SetDBLogonForReport(myConnectionInfo, Pay_Slip)
            'CryRpt1.SelectionFormula = Trim(Frm_Filter_PaySlip.ReportQuery)
            'CryRpt1.ReportSource = Pay_Slip

            Pay_Slip = New MonthlyPayslip
            SetDBLogonForReport(myConnectionInfo, Pay_Slip)
            CryRpt1.SelectionFormula = Trim(Frm_Filter_PaySlip.ReportQuery)
            CryRpt1.ReportSource = Pay_Slip
        ElseIf FrmName = "Monthly_Pay_Slip_Consolidated" Then
            Dim psfields As New ParameterFields
            Dim psfield1 As New ParameterField
            Dim disval1 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "PayrollMonth"

            disval1.Value = Frm_Filter_PaySlip.PayrollMonth

            psfield1.CurrentValues.Add(disval1)

            psfields.Add(psfield1)

            Pay_Slip_Consolidated = New MonthlyPayslipConsolidated
            SetDBLogonForReport(myConnectionInfo, Pay_Slip_Consolidated)
            'CryRpt1.SelectionFormula = Trim(Frm_Filter_PaySlip.ReportQuery)
            CryRpt1.ParameterFieldInfo = psfields

            CryRpt1.ReportSource = Pay_Slip_Consolidated

        ElseIf FrmName = "Monthly_OT_Consolidated" Then
            'Dim psfields As New ParameterFields
            'Dim psfield1 As New ParameterField
            'Dim disval1 As New ParameterDiscreteValue

            'psfield1.ParameterFieldName = "PayrollMonth"

            'disval1.Value = Frm_Filter_PaySlip.PayrollMonth

            'psfield1.CurrentValues.Add(disval1)

            'psfields.Add(psfield1)

            OT_Consolidated = New MonthlyOTConsolidated
            SetDBLogonForReport(myConnectionInfo, OT_Consolidated)
            'CryRpt1.ParameterFieldInfo = psfields

            CryRpt1.ReportSource = OT_Consolidated
        ElseIf FrmName = "Monthly_OT_Detail" Then
            Monthly_OT_Detail = New MonthlyOTDetail
            SetDBLogonForReport(myConnectionInfo, Monthly_OT_Detail)
            CryRpt1.ReportSource = Monthly_OT_Detail
        ElseIf FrmName = "Employee_Profile" Then
            Employee_Profile = New EmployeeDetails
            SetDBLogonForReport(myConnectionInfo, Employee_Profile)
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Employee.ReportQuery)
            CryRpt1.ReportSource = Employee_Profile
        ElseIf FrmName = "Employee_Summary" Then
            Employee_Summ = New EmployeeSummary
            SetDBLogonForReport(myConnectionInfo, Employee_Summ)
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Employee.ReportQuery)
            CryRpt1.ReportSource = Employee_Summ
        ElseIf FrmName = "DailyAbsentees" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "Param1"
            psfield2.ParameterFieldName = "Param2"

            disval1.Value = Frm_Filter_DailyPayroll.ReportDate
            disval2.Value = Frm_Filter_DailyPayroll.strRptDailyAbsentiesParam2

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)

            Daily_Absentees = New DailyAbsentees
            SetDBLogonForReport(myConnectionInfo, Daily_Absentees)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_DailyPayroll.ReportQuery)
            CryRpt1.ReportSource = Daily_Absentees
            'ElseIf FrmName = "LateAttendance" Then
            '    LateComer_Daily = New LateComers
            '    SetDBLogonForReport(myConnectionInfo, LateComer_Daily)
            '    CryRpt1.SelectionFormula = Trim(frm_LateComers.ReportQuery)
            '    CryRpt1.ReportSource = LateComer_Daily
        ElseIf FrmName = "AttendanceActual" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"
            psfield2.ParameterFieldName = "ToDate"

            disval1.Value = Frm_Filter_Attendance.FromDate
            disval2.Value = Frm_Filter_Attendance.ToDate

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)
            Attendance_Actual = New AttendanceActual
            SetDBLogonForReport(myConnectionInfo, Attendance_Actual)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Attendance.ReportQuery)
            CryRpt1.ReportSource = Attendance_Actual
        ElseIf FrmName = "AttendanceProcessed" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"
            psfield2.ParameterFieldName = "ToDate"

            disval1.Value = Frm_Filter_Attendance.FromDate
            disval2.Value = Frm_Filter_Attendance.ToDate

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)
            Attendance_Processed = New AttendanceProcessed

            SetDBLogonForReport(myConnectionInfo, Attendance_Processed)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Attendance.ReportQuery)
            CryRpt1.ReportSource = Attendance_Processed
        ElseIf FrmName = "AttendanceVerification" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"
            psfield2.ParameterFieldName = "ToDate"

            disval1.Value = Frm_Filter_Attendance.FromDate
            disval2.Value = Frm_Filter_Attendance.ToDate

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)
            Attendance_Verification = New AttendanceVerificationReport

            SetDBLogonForReport(myConnectionInfo, Attendance_Verification)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Attendance.ReportQuery)
            CryRpt1.ReportSource = Attendance_Verification
        ElseIf FrmName = "AttendanceProcessedMonthly" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"
            psfield2.ParameterFieldName = "ToDate"

            disval1.Value = Frm_Filter_Attendance.FromDate
            disval2.Value = Frm_Filter_Attendance.ToDate

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)
            Attendance_Processed_Montly = New AttendanceMonthlyProcessed

            SetDBLogonForReport(myConnectionInfo, Attendance_Processed_Montly)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Attendance.ReportQuery)
            CryRpt1.ReportSource = Attendance_Processed_Montly
        ElseIf FrmName = "DailyAbsenteesRunning" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "EnrollDate"

            disval1.Value = Frm_Filter_DailyPayroll.ReportDate

            psfield1.CurrentValues.Add(disval1)

            psfields.Add(psfield1)

            Attendance_Actual_Absentees = New AttendanceActualAbsentees
            SetDBLogonForReport(myConnectionInfo, Attendance_Actual_Absentees)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_DailyPayroll.ReportQuery)
            CryRpt1.ReportSource = Attendance_Actual_Absentees
        ElseIf FrmName = "DailySingleEntries" Then
            Dim psfields As New ParameterFields
            Dim psfield1 As New ParameterField
            Dim disval1 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "PayrollDate"

            disval1.Value = Frm_Filter_DailyPayroll.ReportDate

            psfield1.CurrentValues.Add(disval1)

            psfields.Add(psfield1)

            Attendance_SingleEntries_Processed = New AttendanceProcessedSingleEntries
            SetDBLogonForReport(myConnectionInfo, Attendance_SingleEntries_Processed)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_DailyPayroll.ReportQuery)
            CryRpt1.ReportSource = Attendance_SingleEntries_Processed
        ElseIf FrmName = "RunningEmployees" Then
            'Dim psfields As New ParameterFields
            'Dim psfield1 As New ParameterField
            'Dim disval1 As New ParameterDiscreteValue

            'psfield1.ParameterFieldName = "PayrollDate"

            'disval1.Value = Frm_Filter_DailyPayroll.ReportDate

            'psfield1.CurrentValues.Add(disval1)

            'psfields.Add(psfield1)

            Attendance_Running_Employees = New AttendanceRunningEmployees
            SetDBLogonForReport(myConnectionInfo, Attendance_Running_Employees)
            'CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_DailyPayroll.ReportQuery)
            CryRpt1.ReportSource = Attendance_Running_Employees
        ElseIf FrmName = "GetOTDetail" Then
            Dim psfields As New ParameterFields
            Dim psfield1, psfield2 As New ParameterField
            Dim disval1, disval2 As New ParameterDiscreteValue

            psfield1.ParameterFieldName = "FromDate"
            psfield2.ParameterFieldName = "ToDate"

            disval1.Value = Frm_Filter_Attendance.FromDate
            disval2.Value = Frm_Filter_Attendance.ToDate

            psfield1.CurrentValues.Add(disval1)
            psfield2.CurrentValues.Add(disval2)

            psfields.Add(psfield1)
            psfields.Add(psfield2)

            OT_Detail = New OTDetail
            SetDBLogonForReport(myConnectionInfo, OT_Detail)
            CryRpt1.ParameterFieldInfo = psfields
            CryRpt1.SelectionFormula = Trim(Frm_Filter_Attendance.ReportQuery)
            CryRpt1.ReportSource = OT_Detail

        End If
    End Sub

    Private Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        Dim myTable As CrystalDecisions.CrystalReports.Engine.Table
        For Each myTable In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub RefreshReport()
        'CryRpt1.ReportSource = Nothing
        CryRpt1.RefreshReport()
    End Sub
End Class
