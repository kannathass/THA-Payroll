Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class TexoMain
    Dim User_Check As New Check_User_Privilege
    Dim datacon As New ConnectSql

    Private Sub TexoMain_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        'Update_Login()
        Application.Exit()
    End Sub

    Private Sub TexoMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Set_Forms_as_Child()
    End Sub
    Private Sub MenuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuExit.Click
        'Update_Login()
        Application.Exit()
    End Sub

    Private Sub Set_Forms_as_Child()
        'Report Page
        ReportPage.MdiParent = Me

        'Backup
        Frm_BackupData.MdiParent = Me

        'Login
        FrmMas_Admin.MdiParent = Me

        'Master
        Frm_Category.MdiParent = Me
        Frm_Dept.MdiParent = Me
        frmMas_Category.MdiParent = Me

        ' Payroll
        FrmDailyPayroll.MdiParent = Me
        FrmDailyPayrollListing.MdiParent = Me
        FrmEmployee.MdiParent = Me
        FrmEmployeeListing.MdiParent = Me
        FrmMonthlyPayroll.MdiParent = Me
        FrmMonthlyPayrollListing.MdiParent = Me
        FrmPayrollSettings.MdiParent = Me
        FrmPaySlip.MdiParent = Me

        'Report Forms
        Frm_Filter_DailyPayroll.MdiParent = Me
        Frm_Filter_Employee.MdiParent = Me
        frm_LateComers.MdiParent = Me
        Frm_Filter_MonthlyPayroll.MdiParent = Me
        Frm_Filter_PaySlip.MdiParent = Me

        Me.LayoutMdi(MdiLayout.ArrangeIcons)

    End Sub

    Private Sub MenuRptQuote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' FrmQuoteRpt.Show()
    End Sub

    Private Sub MenuPayEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayEmployee.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmEmployeeListing.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmEmployeeListing.Show()
        End If

    End Sub

    Private Sub MenuPayDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayDay.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmDailyPayrollListing.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmDailyPayrollListing.Show()
        End If

    End Sub

    'Private Sub MenuPayMonth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuPayMonth.Click


    'End Sub

    Private Sub MenuAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuAdmin.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmMas_Admin.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmMas_Admin.Show()
        End If

    End Sub

    Private Sub Update_Login()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Update LoginDetails set Last_Login='" & Date.Now & "',LoggedIn='No' where EmpCode='" & FrmLogin.EmpID & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub

    Private Sub PayrollSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayrollSettingsToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmPayrollSettings.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmPayrollSettings.Show()
        End If

    End Sub

    Private Sub BioMetricAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BioMetricAttendanceToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Connect_Device.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Connect_Device.Show()
        End If

    End Sub

    'Private Sub PayslipToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PayslipToolStripMenuItem1.Click
    '    If User_Check.HasPrivilege(FrmLogin.Privilege, FrmPaySlip.Name) = False Then
    '        MsgBox("You dont have Access Permission")
    '    Else
    '        FrmPaySlip.Show()
    '    End If

    'End Sub

    Private Sub DepartmentCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentCategoryToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, frmMas_Category.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            frmMas_Category.Show()
        End If

    End Sub

    Private Sub AppBackData_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AppBackData.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_BackupData.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_BackupData.Show()
        End If
    End Sub

    'Private Sub ShiftTimingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShiftTimingsToolStripMenuItem.Click
    '    If User_Check.HasPrivilege(FrmLogin.Privilege, FrmSetShiftTimings.Name) = False Then
    '        MsgBox("You dont have Access Permission")
    '    Else
    '        FrmSetShiftTimings.Show()
    '    End If
    'End Sub

    Private Sub MenuCalc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuCalc.Click
        Shell("Calc.exe")
    End Sub

    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_Employee.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_Employee.Show()
        End If
    End Sub

    Private Sub DailyPayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyPayrollToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_DailyPayroll.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_DailyPayroll.Show()
        End If
    End Sub

    Private Sub MonthlyPayrollToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyPayrollToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_MonthlyPayroll.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_MonthlyPayroll.Show()
        End If
    End Sub

    Private Sub EmpPayslipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpPayslipToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_PaySlip.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_PaySlip.Show()
        End If

    End Sub

    Private Sub LateComersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LateComersToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, frm_LateComers.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            frm_LateComers.Show()
        End If
    End Sub

    Private Sub AttendanceActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AttendanceActualToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_Attendance.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_Attendance.Show()
        End If
    End Sub

    Private Sub WeeklyProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeeklyProcessToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmWeeklyAttendanceProcess.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmWeeklyAttendanceProcess.Show()
        End If
    End Sub

    'Private Sub MonthlyDeductionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyDeductionsToolStripMenuItem.Click

    'End Sub

    Private Sub DeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeductionToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmMonthlyDeductions.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Deductions.Show()
        End If
    End Sub

    'Private Sub AllowedDaysEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllowedDaysEntryToolStripMenuItem.Click

    'End Sub

    Private Sub WeeklyPayrollEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeeklyPayrollEntryToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmWeeklyPayroll.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmWeeklyPayroll.Show()
        End If
    End Sub

    Private Sub AllowedDaysEntryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AllowedDaysEntryToolStripMenuItem1.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmWeeklyAllowedDaysEntry.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmWeeklyAllowedDaysEntry.Show()
        End If
    End Sub

    Private Sub WeeklyDeductionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeeklyDeductionsToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmWeeklyDeductions.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmWeeklyDeductions.Show()
        End If
    End Sub

    Private Sub WeeklyPayrollToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles WeeklyPayrollToolStripMenuItem1.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, Frm_Filter_WeeklyPayroll.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            Frm_Filter_WeeklyPayroll.Show()
        End If
    End Sub

    Private Sub MonthlyPayrollEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyPayrollEntryToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmMonthlyPayrollListing.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmMonthlyPayrollListing.Show()
        End If
    End Sub

    Private Sub AllowedDaysEntryToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AllowedDaysEntryToolStripMenuItem2.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmAllowedDaysEntry.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmAllowedDaysEntry.Show()
        End If
    End Sub

    Private Sub DeductionEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeductionEntryToolStripMenuItem.Click
        If User_Check.HasPrivilege(FrmLogin.Privilege, FrmMonthlyDeductions.Name) = False Then
            MsgBox("You dont have Access Permission")
        Else
            FrmMonthlyDeductions.Show()
        End If
    End Sub
End Class
