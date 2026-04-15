Imports System.Data.SqlClient

Public Class FrmPaySlip

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean
    Dim ExistingMode As Boolean = False
    Dim iMode As New Integer

    Dim strPayrollMonth, strPayrollYear As String
    Dim StrPayrollMonthValue As New Integer

    Dim ActualworkingDays, NoofDaysWorked, LeaveDays As New Double
    Dim intBasicSalary, OneDaySalary, OneHourSalary, OneMinuteSalary, PermissionHourSalary, OverTimeSalary As New Double
    Dim SalaryForWorkingDays, TotalEarninings, TotalDeductions, intWorkSalary As New Double
    Dim intWorkSalaryForEarnings, intWorkSalaryForDeductions As New Double

    'ActualworkingDays      - DaysInMonth - (ListOfHoliDays + TotalSundays) filled in FunFillLeaveDays() 
    'LeaveDays              - Get from database filled in FunFillLeaveDays() 
    'NoofDaysWorked         - from database filled in FunFillLeaveDays() 

    'intBasicSalary = Val(txtBasicSalary.Text) filled in FunFillOverTimeHrs() 
    'OneHourSalary = OneDaySalary / NetWorkHrsPerDay filled in FunFillOverTimeHrs() 
    'OneMinuteSalary = (OneHourSalary / 60) filled in FunFillOverTimeHrs() 
    'PermissionHourSalary filled in FunFillOverTimeHrs() 
    'OverTimeSalary filled in FunFillOverTimeHrs() 

    'SalaryForWorkingDays   - onedaysalary * noofdaysworked filled in FunSalaryCalculation() 
    'intWorkSalary          - SalaryForWorkingDays + earnings filled in FunSalaryCalculation() 
    'TotalEarninings        - total earnings allowed
    'TotalDeductions        - total deductions allowed

    Dim EmployeePayItemsLoadComplete As Boolean = False

#End Region

#Region "Function"

    Public Sub FunGetAutoSlipNo()
        Try
            Dim IdentCurrent, Count As New Long
            DSEmp = MyClassPayroll.FunSelectPaySlip(0, 3)
            If DSEmp.Tables("selectPaySlip").Rows.Count > 0 Then
                IdentCurrent = DSEmp.Tables("selectPaySlip").Rows(0)("IdentCurrent")
                Count = DSEmp.Tables("selectPaySlip").Rows(0)("Counts")
                If IdentCurrent = 1 And Count = 0 Then
                    txtPaySlipNo.Text = "PaySlip_" & IdentCurrent
                ElseIf IdentCurrent = 1 And Count = 1 Then
                    txtPaySlipNo.Text = "PaySlip_" & IdentCurrent + 1
                Else
                    txtPaySlipNo.Text = "PaySlip_" & IdentCurrent + 1
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub ClearValues()
        ActualworkingDays = 0
        NoofDaysWorked = 0
        intBasicSalary = 0
        OneHourSalary = 0
        OneMinuteSalary = 0
        PermissionHourSalary = 0
        SalaryForWorkingDays = 0
        intWorkSalary = 0
        TotalEarninings = 0
        TotalDeductions = 0
    End Sub

    Public Sub ClearFields()

        ActualworkingDays = 0
        NoofDaysWorked = 0
        intBasicSalary = 0
        OneHourSalary = 0
        OneMinuteSalary = 0
        PermissionHourSalary = 0
        SalaryForWorkingDays = 0
        intWorkSalary = 0
        TotalEarninings = 0
        TotalDeductions = 0

        DGVEarnings.Rows.Clear()
        DGVDeductions.Rows.Clear()
        lstEmployeeNames.Items.Clear()
        txtEmployeeCode.Text = Nothing
        txtEmployeeName.Text = Nothing
        txtBasicSalary.Text = Nothing
        txtNoOfDaysWorked.Text = Nothing
        txtPermissionTaken.Text = Nothing
        txtOverTimeHrs.Text = Nothing
        txtOverTimeSalary.Text = Nothing
        txtAdvance.Text = Nothing
        txtDeductions.Text = Nothing
        txtEarnings.Text = Nothing
        txtGrossSalary.Text = Nothing
        txtLeaveDays.Text = Nothing
        txtLoanInstallment.Text = Nothing
        txtNetSalary.Text = Nothing
        lblPermissionLimit.Text = ""
        txtLeaveConcession.Text = 0
        txtSalaryPercentForEarning.Text = 40
        txtSalaryPercentForDeductions.Text = 60
        chkOverTimeAllowed.Checked = False
        chkPermissionAllowed.Checked = False

    End Sub

    Public Sub FunListEmployees()
        Try
            Dim i As New Long
            Dim EmpCode, EmpName As String
            Dim strPayrollMonth As DateTime = Trim(txtPayrollMonth.Text)

            If rbDaily.Checked = True Then              'load employee names from daily payroll table
                ClearFields()
                DSEmp.Clear()
                DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strPayrollMonth, 0, 5)
                If DSEmp.Tables(0).Rows.Count > 0 Then
                    For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                        EmpCode = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                        EmpName = DSEmp.Tables(0).Rows(i)("EmployeeName")
                        lstEmployeeNames.Items.Add(EmpCode & ", " & EmpName)
                    Next
                End If
            ElseIf rbMonthly.Checked = True Then        'load employee names from monthly payroll table
                ClearFields()
                DSEmp.Clear()
                DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(strPayrollMonth, 0, 5)
                If DSEmp.Tables("selectEmployeeMonthlyPayroll").Rows.Count > 0 Then
                    For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                        EmpCode = DSEmp.Tables("selectEmployeeMonthlyPayroll").Rows(i)("EmployeeCode")
                        EmpName = DSEmp.Tables("selectEmployeeMonthlyPayroll").Rows(i)("EmployeeName")
                        lstEmployeeNames.Items.Add(EmpCode & ", " & EmpName)
                    Next
                End If
            ElseIf rbWeekly.Checked = True Then 'load employee names from daily payroll table where type=Weekly
                ClearFields()
                DSEmp.Clear()
                DSEmp = MyClassPayroll.FunSelectEmployeeWeekly("1/1/1753", 0, calStartDate.Value.ToShortDateString, calEndDate.Value.ToShortDateString, 1)
                If DSEmp.Tables(0).Rows.Count > 0 Then
                    For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                        EmpCode = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                        EmpName = DSEmp.Tables(0).Rows(i)("EmployeeName")
                        lstEmployeeNames.Items.Add(EmpCode & ", " & EmpName)
                    Next
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSavePaySlip()
        Try
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectPaySlip(0, 1)
            DStemp.Tables("selectPaySlip").Rows.Clear()
            MyRow = DStemp.Tables("selectPaySlip").NewRow
            MyRow("SNo") = 0
            MyRow("PaySlipNo") = txtPaySlipNo.Text
            MyRow("Date") = txtDate.Text
            MyRow("SalaryMonth") = txtPayrollMonth.Text
            MyRow("EmployeeCode") = txtEmployeeCode.Text
            MyRow("EmployeeName") = txtEmployeeName.Text
            MyRow("BasicSalary") = txtBasicSalary.Text
            MyRow("LeavesTaken") = txtLeaveDays.Text
            If chkPermissionAllowed.Checked = True Then
                MyRow("PermissionTaken") = txtPermissionTaken.Text
            Else
                MyRow("PermissionTaken") = "00:00"
            End If
            If chkOverTimeAllowed.Checked = True Then
                MyRow("TotalOverTimeHrs") = txtOverTimeHrs.Text
                MyRow("OverTimeSalary") = txtOverTimeSalary.Text
            Else
                MyRow("TotalOverTimeHrs") = "00:00"
                MyRow("OverTimeSalary") = 0.0
            End If
            MyRow("TotalEarnings") = Val(txtEarnings.Text)
            MyRow("TotalDeductions") = Val(txtDeductions.Text)
            MyRow("GrossSalary") = txtGrossSalary.Text
            MyRow("Advance") = txtAdvance.Text
            MyRow("LoanInstallMent") = txtLoanInstallment.Text
            MyRow("NetSalary") = txtNetSalary.Text
            MyRow("NoofDaysWorked") = Val(txtNoOfDaysWorked.Text)
            MyRow("LeaveDays") = LeaveDays
            MyRow("LeaveConcession") = Val(txtLeaveConcession.Text)
            MyRow("SalaryPercentForEarnings") = Val(txtSalaryPercentForEarning.Text)
            MyRow("SalaryPercentForDeductions") = Val(txtSalaryPercentForDeductions.Text)
            MyRow("WeekStartDate") = calStartDate.Value
            MyRow("WeekEndDate") = calEndDate.Value
            MyRow("String2") = 0
            MyRow("string3") = 0
            MyRow("String4") = ""
            MyRow("String5") = ""
            DStemp.Tables("selectPaySlip").Rows.Add(MyRow)
            MyClassPayroll.FunSavePaySlip(DStemp, 1)

            ''''Update Loan and advance amount
            Dim MyclassConnectSql As New ConnectSql
            Dim MyCommand As New SqlCommand
            MyclassConnectSql.con.Close()
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_UPDATE_EMPLOYEE_LOAN_ADVANCE"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text)
            MyCommand.Parameters.AddWithValue("@Advance_CurrentInstallment", Val(txtAdvance.Text))
            MyCommand.Parameters.AddWithValue("@Loan_CurrentInstallment", Val(txtLoanInstallment.Text))
            MyCommand.Parameters.AddWithValue("@iMode", 1)
            MyCommand.ExecuteNonQuery()
            MyclassConnectSql.con.Close()

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSavePaySlipEarning()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectPaySlipAllowance(0, 1)
            For i = 0 To DGVEarnings.NewRowIndex
                If DGVEarnings("EarningName", i).Value <> Nothing And Val(DGVEarnings("EarningValue", i).Value) > 0 Then
                    DStemp.Tables("selectPaySlipAllowance").Rows.Clear()
                    MyRow = DStemp.Tables("selectPaySlipAllowance").NewRow
                    MyRow("PaySlipNo") = txtPaySlipNo.Text
                    MyRow("EarningName") = DGVEarnings("EarningName", i).Value
                    MyRow("Percentage") = DGVEarnings("EPercentage", i).Value
                    MyRow("EarningValue") = Val(DGVEarnings("EarningValue", i).Value)
                    MyRow("String1") = ""
                    MyRow("String2") = ""
                    DStemp.Tables("selectPaySlipAllowance").Rows.Add(MyRow)
                    MyClassPayroll.FunSavePaySlipEarnings(DStemp, 1)
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSavePaySlipDeduction()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectPaySlipAllowance(0, 3)
            For i = 0 To DGVDeductions.NewRowIndex
                If DGVDeductions("DeductionName1", i).Value <> Nothing And Val(DGVDeductions("DeductionValue", i).Value) > 0 Then
                    DStemp.Tables("selectPaySlipAllowance").Rows.Clear()
                    MyRow = DStemp.Tables("selectPaySlipAllowance").NewRow
                    MyRow("PaySlipNo") = txtPaySlipNo.Text
                    MyRow("DeductionName") = DGVDeductions("DeductionName1", i).Value
                    MyRow("Percentage") = DGVDeductions("DPercentage", i).Value
                    MyRow("DeductionValue") = Val(DGVDeductions("DeductionValue", i).Value)
                    MyRow("String1") = ""
                    MyRow("String2") = ""
                    DStemp.Tables("selectPaySlipAllowance").Rows.Add(MyRow)
                    MyClassPayroll.FunSavePaySlipDeductions(DStemp, 1)
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Function GetPayrollMonthStatus() As Boolean
        Dim Valid As Boolean = False
        DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(1)

        If DSEmp.Tables(0).Rows.Count > 0 Then
            strPayrollMonth = DSEmp.Tables(0).Rows(0)("OpenMonth")
            StrPayrollMonthValue = DSEmp.Tables(0).Rows(0)("OpenMonthValue")
            strPayrollYear = DSEmp.Tables(0).Rows(0)("OpenYear")
            txtPayrollMonth.Text = strPayrollMonth & " , " & strPayrollYear
            If DSEmp.Tables(0).Rows(0)("Status") = "Open" Then
                rbOpen.Checked = True
                Valid = True
            ElseIf DSEmp.Tables(0).Rows(0)("Status") = "Close" Then
                rbClose.Checked = True
                Valid = False
            End If
        End If
        Return Valid
    End Function

    Public Sub FunSalaryCalculation()

        Dim i, j As New Integer
        Dim tempOverTimeSalary, tempPermissionHourSalary As New Double

        If chkOverTimeAllowed.Checked = True Then
            tempOverTimeSalary = Math.Round(OverTimeSalary)
        Else
            tempOverTimeSalary = 0
        End If

        If chkPermissionAllowed.Checked = True Then
            tempPermissionHourSalary = Math.Round(PermissionHourSalary)
        Else
            tempPermissionHourSalary = 0
        End If

        SalaryForWorkingDays = NoofDaysWorked * Math.Round(OneDaySalary, 3)
        intWorkSalary = (SalaryForWorkingDays + tempOverTimeSalary) - tempPermissionHourSalary

        'GROSS SALARY
        txtGrossSalary.Text = intWorkSalary

        If Val(txtSalaryPercentForEarning.Text) > 0 Then
            intWorkSalaryForEarnings = intWorkSalary * (Val(txtSalaryPercentForEarning.Text) / 100)
        End If
        If Val(txtSalaryPercentForDeductions.Text) > 0 Then
            intWorkSalaryForDeductions = intWorkSalary * (Val(txtSalaryPercentForDeductions.Text) / 100)
        End If

        TotalEarninings = 0
        For i = 0 To DGVEarnings.NewRowIndex
            If DGVEarnings(0, i).Value <> Nothing And Val(DGVEarnings(1, i).Value) > 0 Then
                DGVEarnings("EarningValue", i).Value = intWorkSalaryForEarnings * (Val(DGVEarnings("EPercentage", i).Value) / 100)
                TotalEarninings += Val(DGVEarnings(2, i).Value)
            End If
        Next

        'TOTAL EARNINGS
        txtEarnings.Text = TotalEarninings
        'txtGrossSalary.Text = intWorkSalary + Val(txtEarnings.Text)

        TotalDeductions = 0
        For j = 0 To DGVDeductions.NewRowIndex
            If DGVDeductions(0, j).Value <> Nothing And Val(DGVDeductions(1, j).Value) > 0 Then
                DGVDeductions(2, j).Value = intWorkSalaryForDeductions * (Val(DGVDeductions(1, j).Value) / 100)
                TotalDeductions += Val(DGVDeductions(2, j).Value)
            End If
        Next

        'TOTAL DEDUCTIONS
        txtDeductions.Text = TotalDeductions

        If Val(txtLoanInstallment.Text) <= 0 Or Val(txtLoanInstallment.Text) > Val(txtGrossSalary.Text) Then
            txtLoanInstallment.Text = 0
        End If
        If Val(txtAdvance.Text) <= 0 Or Val(txtAdvance.Text) > Val(txtGrossSalary.Text) Then
            txtAdvance.Text = 0
        End If

        'txtNetSalary.Text = Val(txtGrossSalary.Text) - (Val(txtDeductions.Text) + Val(txtLoanInstallment.Text) + Val(txtAdvance.Text))

        txtNetSalary.Text = (Val(txtGrossSalary.Text) + Val(txtEarnings.Text)) - (Val(txtDeductions.Text) + Val(txtLoanInstallment.Text) + Val(txtAdvance.Text))

        RoundValue()
        TotalEarninings = 0
        TotalDeductions = 0
    End Sub

    Public Sub FunFillOverTimeHrs()

        Dim strOverTimeHrs, strHolidayOverTimeHrs, strPermission As String
        Dim arr1(), arr2(), arr3() As String
        Dim i, OTHours, OTMinutes, HOTHours, HOTMinutes, PHours, PMinutes As New Integer
        Dim TotalOTHours, TotalOTMinutes As New Integer
        Dim strPayMonth As DateTime = Trim(txtPayrollMonth.Text)
        Dim EmpCode As String = Trim(txtEmployeeCode.Text)

        'Calculate TotalOverTimeHrs,TotalPermissionHrs for the employee for particular month
        If rbDaily.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strPayMonth, EmpCode, 7)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    strOverTimeHrs = DSEmp.Tables(0).Rows(i)("OverTimeHrs")
                    arr1 = strOverTimeHrs.Split(":")
                    OTHours += Val(Trim(arr1(0)))
                    OTMinutes += Val(Trim(arr1(1)))

                    strHolidayOverTimeHrs = DSEmp.Tables(0).Rows(i)("HolidayOverTimeHrs")
                    arr2 = strHolidayOverTimeHrs.Split(":")
                    HOTHours += Val(Trim(arr2(0)))
                    HOTMinutes += Val(Trim(arr2(1)))

                    strPermission = DSEmp.Tables(0).Rows(i)("Permission")
                    arr3 = strPermission.Split(":")
                    PHours += Val(Trim(arr3(0)))
                    PMinutes += Val(Trim(arr3(1)))
                Next
            End If
        ElseIf rbMonthly.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(strPayMonth, EmpCode, 7)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                strOverTimeHrs = DSEmp.Tables(0).Rows(0)("TotalOverTimeHrs")
                arr1 = strOverTimeHrs.Split(":")
                OTHours = Val(Trim(arr1(0)))
                OTMinutes = Val(Trim(arr1(1)))

                strHolidayOverTimeHrs = DSEmp.Tables(0).Rows(0)("TotalHolidayOverTimeHrs")
                arr2 = strHolidayOverTimeHrs.Split(":")
                HOTHours = Val(Trim(arr2(0)))
                HOTMinutes = Val(Trim(arr2(1)))

                strPermission = DSEmp.Tables(0).Rows(0)("Permission")
                arr3 = strPermission.Split(":")
                PHours = Val(Trim(arr3(0)))
                PMinutes = Val(Trim(arr3(1)))
            End If
        ElseIf rbWeekly.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeWeekly("1/1/1753", EmpCode, calStartDate.Value.ToShortDateString, calEndDate.Value.ToShortDateString, 3)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    strOverTimeHrs = DSEmp.Tables(0).Rows(i)("OverTimeHrs")
                    arr1 = strOverTimeHrs.Split(":")
                    OTHours += Val(Trim(arr1(0)))
                    OTMinutes += Val(Trim(arr1(1)))

                    strHolidayOverTimeHrs = DSEmp.Tables(0).Rows(i)("HolidayOverTimeHrs")
                    arr2 = strHolidayOverTimeHrs.Split(":")
                    HOTHours += Val(Trim(arr2(0)))
                    HOTMinutes += Val(Trim(arr2(1)))

                    strPermission = DSEmp.Tables(0).Rows(i)("Permission")
                    arr3 = strPermission.Split(":")
                    PHours += Val(Trim(arr3(0)))
                    PMinutes += Val(Trim(arr3(1)))
                Next
            End If
        End If

        TotalOTHours = OTHours + HOTHours
        TotalOTMinutes = OTMinutes + HOTMinutes

        Dim DividentHrs, ReminderMinutes, PDividentHrs, PReminderMinutes As New Integer
        Dim NetOTHours, NetOTMinutes, NetPermissionHours, NetPermissionMinutes As New Integer

        If TotalOTMinutes > 60 Then
            DividentHrs = TotalOTMinutes / 60
            ReminderMinutes = TotalOTMinutes - (DividentHrs * 60)
        Else
            DividentHrs = 0
            ReminderMinutes = TotalOTMinutes
        End If
        NetOTHours = TotalOTHours + DividentHrs           'NetOverTimeHours for the Employee for the month
        NetOTMinutes = ReminderMinutes                    'NetOverTimeMinutes for the Employee for the month
        txtOverTimeHrs.Text = NetOTHours & ":" & NetOTMinutes

        If PMinutes > 60 Then
            PDividentHrs = PMinutes / 60
            PReminderMinutes = PMinutes - (PDividentHrs * 60)
        Else
            PDividentHrs = 0
            PReminderMinutes = PMinutes
        End If
        NetPermissionHours = PHours + PDividentHrs          'NetPermissionHours for the employee for the month
        NetPermissionMinutes = PReminderMinutes             'NetPermissionMinutes for the employee for the month
        txtPermissionTaken.Text = NetPermissionHours & ":" & NetPermissionMinutes

        '***************

        'Calculate Workinghour,Workingminutes per One day
        Dim strMorningSiftHrsPerDay, strEveningShiftHrsPerDay, strPermissionHrsPerMonth As String
        Dim MHrs, MMinutes, EHrs, EMinutes, PHrs, PMutes As New Integer
        DSEmp = MyClassPayroll.FunSelectPayrollShiftTimeSettings(1)

        If DSEmp.Tables(0).Rows.Count > 0 Then
            strMorningSiftHrsPerDay = DSEmp.Tables(0).Rows(0)("MorningHrs")
            arr1 = strMorningSiftHrsPerDay.Split(":")
            MHrs = Val(Trim(arr1(0)))
            MMinutes = Val(Trim(arr1(1)))

            strEveningShiftHrsPerDay = DSEmp.Tables(0).Rows(0)("EveningHrs")
            arr2 = strEveningShiftHrsPerDay.Split(":")
            EHrs = Val(Trim(arr2(0)))
            EMinutes = Val(Trim(arr2(1)))

            strPermissionHrsPerMonth = DSEmp.Tables(0).Rows(0)("PermissionHrs")
            arr3 = strPermissionHrsPerMonth.Split(":")
            PHrs = Val(Trim(arr3(0)))                       'Permission Hour Limit for one Month
            PMutes = Val(Trim(arr3(1)))                     'Permission Minute Limit for one Month
        End If


        lblPermissionLimit.Text = "Permission Limit = " & PHrs & ":" & PMutes

        Dim WorkingHrsPerDay, WorkingMinutesPerDay As New Integer
        Dim NetWorkHrsPerDay, NetWorkMinutesDay As New Integer
        WorkingHrsPerDay = MHrs + EHrs
        WorkingMinutesPerDay = MMinutes + EMinutes

        Dim DividentWorkHrs, ReminderWorkMinutes As New Integer
        'Dim NetWorkHours, NetWorkMinutes As New Integer
        DividentWorkHrs = WorkingMinutesPerDay / 60
        ReminderWorkMinutes = WorkingMinutesPerDay - (DividentHrs * 60)

        NetWorkHrsPerDay = WorkingHrsPerDay + DividentWorkHrs                   'Working hours per day
        NetWorkMinutesDay = ReminderWorkMinutes                                 'Working minutes per day

        '*****************

        intBasicSalary = Val(txtBasicSalary.Text)
        If rbMonthly.Checked = True Then
            If ActualworkingDays <> 0 Then
                OneDaySalary = intBasicSalary / ActualworkingDays
            End If
        ElseIf rbWeekly.Checked = True Then
            OneDaySalary = intBasicSalary
        ElseIf rbDaily.Checked = True Then
            If ActualworkingDays <> 0 Then
                OneDaySalary = intBasicSalary / ActualworkingDays
            End If
        End If
        If NetWorkHrsPerDay <> 0 Then
            OneHourSalary = OneDaySalary / NetWorkHrsPerDay
        End If
        OneMinuteSalary = (OneHourSalary / 60)

        Dim OvertimeHrSalary, OvertimeMinSalary As Double
        OvertimeHrSalary = NetOTHours * OneHourSalary
        OvertimeMinSalary = NetOTMinutes * OneMinuteSalary
        OverTimeSalary = OvertimeHrSalary + OvertimeMinSalary
        txtOverTimeSalary.Text = OverTimeSalary

        Dim LimitedPermissionMinutesPerMonth, PermissionTakenMinutesForSalaryMonth As New Long
        LimitedPermissionMinutesPerMonth = PMutes + (PHrs * 60)         'Hrs Convert to  minutes
        PermissionTakenMinutesForSalaryMonth = NetPermissionMinutes + (NetPermissionHours * 60) 'Hrs Convert to  minutes

        If PermissionTakenMinutesForSalaryMonth > LimitedPermissionMinutesPerMonth Then
            PermissionHourSalary = ((NetPermissionHours - PHrs) * OneHourSalary) + ((NetPermissionMinutes - PMutes) * OneMinuteSalary)
        Else
            PermissionHourSalary = 0
        End If

    End Sub

    Public Sub FunFillLeaveDays()

        Dim DaysInMonth As New Integer
        Dim PreDaysInMonth As New Integer
        Dim TotalSundays As New Integer

        Dim strPayMonth As DateTime = Trim(txtPayrollMonth.Text)
        Dim EmpCode As String = Trim(txtEmployeeCode.Text)
        Dim ListOfHoliDays As New Integer

        If rbDaily.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strPayMonth, EmpCode, 6)
            NoofDaysWorked = 0
            If DSEmp.Tables(0).Rows.Count > 0 Then
                If DSEmp.Tables(0).Rows(0)("FullShiftDays") > 0 Then
                    NoofDaysWorked = DSEmp.Tables(0).Rows(0)("FullShiftDays")
                End If
            End If
            If DSEmp.Tables(1).Rows.Count > 0 Then
                If DSEmp.Tables(1).Rows(0)("HalfShiftDays") > 0 Then
                    NoofDaysWorked = NoofDaysWorked + Val(DSEmp.Tables(1).Rows(0)("HalfShiftDays")) / 2
                End If
            End If

            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectListOfHolidays(strPayMonth, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                ListOfHoliDays = DSEmp.Tables(0).Rows(0)("CountListOfHoliDays")
            End If

            DaysInMonth = Date.DaysInMonth(CInt(strPayrollYear), StrPayrollMonthValue)
            PreDaysInMonth = strPayMonth.DayOfWeek

            ' '' ''Formula 
            ' '' ''If PreDaysInMonth > 0
            ' '' ''TotalSundays=(DaysInMonth+(PreDaysInMonth-1))/7
            ' '' ''else if PreDaysInMonth = 0
            ' '' ''TotalSundays=(DaysInMonth+(PreDaysInMonth+8))/7

            If PreDaysInMonth > 0 Then
                TotalSundays = (DaysInMonth + (PreDaysInMonth - 1)) / 7
            ElseIf PreDaysInMonth = 0 Then
                TotalSundays = (DaysInMonth + (PreDaysInMonth + 8)) / 7
            End If

            ActualworkingDays = DaysInMonth - (ListOfHoliDays + TotalSundays)
            LeaveDays = ActualworkingDays - NoofDaysWorked
            txtNoOfDaysWorked.Text = NoofDaysWorked
            txtLeaveDays.Text = LeaveDays

        ElseIf rbMonthly.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(strPayMonth, EmpCode, 6)
            NoofDaysWorked = 0
            If Val(DSEmp.Tables(0).Rows(0)("NoOfDaysWorked")) > 0 Then
                NoofDaysWorked = DSEmp.Tables(0).Rows(0)("NoOfDaysWorked")
            End If

            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectListOfHolidays(strPayMonth, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                ListOfHoliDays = DSEmp.Tables(0).Rows(0)("CountListOfHoliDays")
            End If

            DaysInMonth = Date.DaysInMonth(CInt(strPayrollYear), StrPayrollMonthValue)
            PreDaysInMonth = strPayMonth.DayOfWeek

            ' '' ''Formula 
            ' '' ''If PreDaysInMonth > 0
            ' '' ''TotalSundays=(DaysInMonth+(PreDaysInMonth-1))/7
            ' '' ''else if PreDaysInMonth = 0
            ' '' ''TotalSundays=(DaysInMonth+(PreDaysInMonth+8))/7

            If PreDaysInMonth > 0 Then
                TotalSundays = (DaysInMonth + (PreDaysInMonth - 1)) / 7
            ElseIf PreDaysInMonth = 0 Then
                TotalSundays = (DaysInMonth + (PreDaysInMonth + 8)) / 7
            End If

            'ActualworkingDays = DaysInMonth - (ListOfHoliDays + TotalSundays)
            ActualworkingDays = 26
            LeaveDays = ActualworkingDays - NoofDaysWorked
            txtNoOfDaysWorked.Text = NoofDaysWorked
            txtLeaveDays.Text = LeaveDays
        ElseIf rbWeekly.Checked = True Then
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeWeekly("1/1/1753", EmpCode, calStartDate.Value.ToShortDateString, calEndDate.Value.ToShortDateString, 2)
            NoofDaysWorked = 0
            If DSEmp.Tables(0).Rows.Count > 0 Then
                If DSEmp.Tables(0).Rows(0)("FullShiftDays") > 0 Then
                    NoofDaysWorked = DSEmp.Tables(0).Rows(0)("FullShiftDays")
                End If
            End If
            If DSEmp.Tables(1).Rows.Count > 0 Then
                If DSEmp.Tables(1).Rows(0)("HalfShiftDays") > 0 Then
                    NoofDaysWorked = NoofDaysWorked + Val(DSEmp.Tables(1).Rows(0)("HalfShiftDays")) / 2
                End If
            End If
            ActualworkingDays = 7
            LeaveDays = ActualworkingDays - NoofDaysWorked
            txtNoOfDaysWorked.Text = NoofDaysWorked
            txtLeaveDays.Text = LeaveDays
        End If
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Public Sub FunFillEmployeePaySlipItems()
        Try
            Dim sno As New Long
            Dim i As New Integer
            Dim strDate As New DateTime
            Dim EmpCode As String = Nothing
            If txtEmployeeCode.Text <> Nothing Then
                EmpCode = Trim(txtEmployeeCode.Text)
            End If

            DSEmp = MyClassPayroll.FunSelectEmployeeTab(EmpCode, "", 2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtEmployeeCode.Text = DSEmp.Tables(0).Rows(0)("EmployeeCode")
                txtEmployeeName.Text = DSEmp.Tables(0).Rows(0)("EmployeeName")
                txtBasicSalary.Text = DSEmp.Tables(0).Rows(0)("BasicSalary")
            End If

            Dim DStemp As New DataSet
            DStemp = MyClassPayroll.FunSelectEmployeeTab(EmpCode, "", 7)

            If DStemp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DStemp.Tables(0).Rows.Count - 1
                    DGVEarnings.Rows.Add()
                    DGVEarnings("EarningName", i).Value = DStemp.Tables(0).Rows(i)("EarningName")
                    DGVEarnings("EPercentage", i).Value = DStemp.Tables(0).Rows(i)("Percentage")
                    DGVEarnings("EarningValue", i).Value = DStemp.Tables(0).Rows(i)("EarningValue")
                Next
            Else
                DGVEarnings.Rows.Clear()
                txtEarnings.Text = ""
            End If

            If DStemp.Tables(1).Rows.Count > 0 Then
                For i = 0 To DStemp.Tables(1).Rows.Count - 1
                    DGVDeductions.Rows.Add()
                    DGVDeductions("DeductionName1", i).Value = DStemp.Tables(1).Rows(i)("DeductionName")
                    DGVDeductions("DPercentage", i).Value = DStemp.Tables(1).Rows(i)("Percentage")
                    DGVDeductions("DeductionValue", i).Value = DStemp.Tables(1).Rows(i)("DeductionValue")
                Next
            Else
                DGVDeductions.Rows.Clear()
                txtDeductions.Text = ""
            End If

            If DStemp.Tables(2).Rows.Count > 0 Then
                If Val(DStemp.Tables(2).Rows(0)("sa_Installment")) > 0 Then
                    txtAdvance.Text = DStemp.Tables(2).Rows(0)("sa_Installment")
                End If
            Else
                txtAdvance.Text = ""
            End If

            If DStemp.Tables(3).Rows.Count > 0 Then
                If Val(DStemp.Tables(3).Rows(0)("loan_Installment")) > 0 Then
                    txtLoanInstallment.Text = DStemp.Tables(3).Rows(0)("loan_Installment")
                End If
            Else
                txtLoanInstallment.Text = ""
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub SelectEmployee()
        Dim str As String
        Dim arr() As String
        If lstEmployeeNames.Items.Count > 0 Then
            If lstEmployeeNames.SelectedIndex >= 0 Then
                str = lstEmployeeNames.SelectedItem.ToString
                arr = str.Split(",")
                txtEmployeeName.Text = Trim(arr(1))
                txtEmployeeCode.Text = Trim(arr(0))
                FunFillEmployeePaySlipItems()
                FunFillLeaveDays()
                FunFillOverTimeHrs()
                FunSalaryCalculation()
                RoundValue()
            End If
        End If
    End Sub

    Public Function Validation()
        Try
            Dim Valid As Boolean = True

            If txtEmployeeCode.Text = Nothing Then
                lblErrorMessage.Text = "Select Employee."
                Valid = False
            End If

            If rbDaily.Checked = False And rbMonthly.Checked = False And rbWeekly.Checked = False Then
                lblErrorMessage.Text = "Select Any one of the Employee Type."
                Valid = False
            End If
            Return Valid
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Private Sub Initialize_Columns()
        Dim DgvColumn As DataGridViewColumn = DGVEarnings.Columns("EarningName")
        DgvColumn.DisplayIndex = 0
        DgvColumn = DGVEarnings.Columns("EPercentage")
        DgvColumn.DisplayIndex = 1
        DgvColumn = DGVEarnings.Columns("EarningValue")
        DgvColumn.DisplayIndex = 2


        Dim DgvColumn1 As DataGridViewColumn = DGVDeductions.Columns("DeductionName1")
        DgvColumn1.DisplayIndex = 0
        DgvColumn1 = DGVDeductions.Columns("DPercentage")
        DgvColumn1.DisplayIndex = 1
        DgvColumn1 = DGVDeductions.Columns("DeductionValue")
        DgvColumn1.DisplayIndex = 2
    End Sub

#End Region

    Private Sub FrmPaySlip_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtEmployeeName.Focused = True Then
                ClearValues()
                lstEmployeeNames.Visible = True
                lstEmployeeNames.Focus()
                EmployeePayItemsLoadComplete = False
            ElseIf lstEmployeeNames.Focused = True Then
                SelectEmployee()
                lstEmployeeNames.Visible = False
                txtEmployeeName.Focus()
                EmployeePayItemsLoadComplete = True
            Else
                SendKeys.Send("{TAB}")
            End If
        End If
    End Sub

    Public Sub RoundValue()
        Dim MyclassValidation As New clsValidation

        txtBasicSalary.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtBasicSalary.Text))
        txtOverTimeSalary.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtOverTimeSalary.Text))
        txtEarnings.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtEarnings.Text))
        txtDeductions.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtDeductions.Text))
        txtGrossSalary.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtGrossSalary.Text))
        txtLoanInstallment.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtLoanInstallment.Text))
        txtAdvance.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtAdvance.Text))
        txtNetSalary.Text = MyclassValidation.FunRoundValueofDecimal(Val(txtNetSalary.Text))
    End Sub

    Private Sub FrmPaySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Initialize_Columns()
        If GetPayrollMonthStatus() = True Then
            lblErrorMessage.Text = ""
            RoundValue()
            rbMonthly.Checked = True
            FunGetAutoSlipNo()
            FunListEmployees()
            txtDate.Text = DateTime.Now.ToShortDateString

            txtLeaveConcession.Text = 0
            txtSalaryPercentForDeductions.Text = 60
            txtSalaryPercentForEarning.Text = 40
        Else
            lblErrorMessage.Text = "Open the Payroll Month and Proceed."
        End If
    End Sub

    Private Sub rbDaily_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDaily.Click
        calStartDate.Enabled = False
        calEndDate.Enabled = False
        If GetPayrollMonthStatus() = True And rbDaily.Checked = True And lstEmployeeNames.Visible = False Then
            FunListEmployees()
        Else
            lblErrorMessage.Text = "Open the Payroll Month and Proceed."
        End If
    End Sub

    Private Sub rbMonthly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMonthly.Click
        calStartDate.Enabled = False
        calEndDate.Enabled = False
        If GetPayrollMonthStatus() = True And rbMonthly.Checked = True And lstEmployeeNames.Visible = False Then
            FunListEmployees()
        Else
            lblErrorMessage.Text = "Open the Payroll Month and Proceed."
        End If
    End Sub

    Private Sub rbWeekly_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbWeekly.Click
        calStartDate.Enabled = True
        calEndDate.Enabled = True
        If GetPayrollMonthStatus() = True And rbWeekly.Checked = True And lstEmployeeNames.Visible = False Then
            FunListEmployees()
        Else
            lblErrorMessage.Text = "Open the Payroll Month and Proceed."
        End If
    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        If Validation() = True Then
            FunSavePaySlip()
            FunSavePaySlipEarning()
            FunSavePaySlipDeduction()
            Me.Close()
        End If
    End Sub

    Private Sub lstEmployeeNames_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEmployeeNames.Leave
        lstEmployeeNames.Visible = False
    End Sub

    Private Sub calStartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calStartDate.ValueChanged
        '' '' ''Dim StartDate As New DateTime
        '' '' ''Dim PayrollDate As New DateTime
        '' '' ''StartDate = calStartDate.Value
        '' '' ''PayrollDate = txtPayrollMonth.Text
        '' '' ''if StartDate not in PayrollDate then

        '' '' ''End If


    End Sub

    Private Sub txtAdvance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvance.TextChanged
        FunSalaryCalculation()

    End Sub

    Private Sub txtLoanInstallment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoanInstallment.TextChanged
        FunSalaryCalculation()
    End Sub

    Private Sub DGVEarnings_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellLeave
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVEarnings_CellValueChanged_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellValueChanged

        Dim i, ColumnIndex As New Integer
        ColumnIndex = e.ColumnIndex

        If EmployeePayItemsLoadComplete = True Then
            If Val(txtSalaryPercentForEarning.Text) > 0 Then
                intWorkSalaryForEarnings = intWorkSalary * (Val(txtSalaryPercentForEarning.Text) / 100)
            End If

            If DGVEarnings.RowCount > 0 Then
                For i = 0 To DGVEarnings.NewRowIndex - 1
                    If ColumnIndex = 1 And EmployeePayItemsLoadComplete = True Then
                        If DGVEarnings(0, i).Value <> Nothing And Val(DGVEarnings(1, i).Value) > 0 Then
                            DGVEarnings(2, i).Value = intWorkSalaryForEarnings * (Val(DGVEarnings(1, i).Value) / 100)

                            'TotalEarninings += Val(DGVEarnings("EarningValue", i).Value)
                        End If
                    End If
                    If ColumnIndex = 2 And EmployeePayItemsLoadComplete = True Then
                        If DGVEarnings(0, i).Value <> Nothing And Val(DGVEarnings(2, i).Value) > 0 Then
                            DGVEarnings(1, i).Value = (Val(DGVEarnings(2, i).Value) * 100) / intWorkSalaryForEarnings
                            'TotalEarninings += Val(DGVEarnings("EarningValue", i).Value)
                        End If
                    End If

                Next
            End If
            ColumnIndex = -1
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub DGVDeductions_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDeductions.CellEnter
        On Error Resume Next
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVDeductions_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDeductions.CellLeave
        On Error Resume Next
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVDeductions_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDeductions.CellValueChanged

        Dim i, ColumnIndex As New Integer
        ColumnIndex = e.ColumnIndex

        If EmployeePayItemsLoadComplete = True Then
            If Val(txtSalaryPercentForDeductions.Text) > 0 Then
                intWorkSalaryForDeductions = intWorkSalary * (Val(txtSalaryPercentForDeductions.Text) / 100)
            End If

            If DGVDeductions.RowCount > 0 Then
                For i = 0 To DGVDeductions.NewRowIndex - 1
                    If ColumnIndex = 1 And EmployeePayItemsLoadComplete = True Then
                        If DGVDeductions(0, i).Value <> Nothing And Val(DGVDeductions(1, i).Value) > 0 Then
                            DGVDeductions(2, i).Value = intWorkSalaryForDeductions * (Val(DGVDeductions(1, i).Value) / 100)
                        End If
                    End If
                    If ColumnIndex = 2 And EmployeePayItemsLoadComplete = True Then
                        If DGVDeductions(0, i).Value <> Nothing And Val(DGVDeductions(2, i).Value) > 0 Then
                            DGVDeductions(1, i).Value = (Val(DGVDeductions(2, i).Value) * 100) / intWorkSalaryForDeductions
                        End If
                    End If
                Next
            End If
            ColumnIndex = -1
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub chkOverTimeAllowed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOverTimeAllowed.CheckedChanged
        FunSalaryCalculation()
    End Sub

    Private Sub chkPermissionAllowed_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPermissionAllowed.CheckedChanged
        FunSalaryCalculation()
    End Sub

    Private Sub DGVEarnings_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellEnter
        On Error Resume Next
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub txtLeaveConcession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLeaveConcession.TextChanged
        If EmployeePayItemsLoadComplete = True Then
            FunFillLeaveDays()
            If Val(txtLeaveConcession.Text) > 0 Then
                If Val(txtLeaveConcession.Text) > LeaveDays Then
                    MsgBox("Concession Days Is Greater than Leave Days")
                    txtLeaveConcession.Text = 0
                Else
                    NoofDaysWorked = NoofDaysWorked + Val(txtLeaveConcession.Text)
                End If
            End If
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub txtSalaryPercentForEarning_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalaryPercentForEarning.TextChanged
        If Val(txtSalaryPercentForEarning.Text) > 0 Then
            txtSalaryPercentForDeductions.Text = 100 - Val(txtSalaryPercentForEarning.Text)
        End If

        If EmployeePayItemsLoadComplete = True Then
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub txtSalaryPercentForDeductions_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalaryPercentForDeductions.TextChanged
        If Val(txtSalaryPercentForDeductions.Text) > 0 Then
            txtSalaryPercentForEarning.Text = 100 - Val(txtSalaryPercentForDeductions.Text)
        End If

        If EmployeePayItemsLoadComplete = True Then
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub DGVDeductions_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGVDeductions.RowsRemoved
        If EmployeePayItemsLoadComplete = True Then
            FunSalaryCalculation()
        End If
    End Sub

    Private Sub DGVEarnings_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DGVEarnings.RowsRemoved
        If EmployeePayItemsLoadComplete = True Then
            FunSalaryCalculation()
        End If
    End Sub
End Class



