Imports System.Data.SqlClient

Public Class clsPayroll

#Region "Declaration"

    Dim MyclassConnectSql As New ConnectSql
    Dim MyCommand As New SqlCommand
    Dim SqlDR As SqlDataReader
    Dim SqlDA As New SqlDataAdapter

#End Region

#Region "Function"

    Public Function FunSelectEmployeeTab(ByVal EmployeeCode As String, ByVal Param1 As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_selectEmployeeTab"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@Param1", Param1)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeTab")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeePersonnalInfo(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeePersonnalInfo"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@EmployeeName", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeName"))
            MyCommand.Parameters.AddWithValue("@Alias", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Alias"))
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@Designation", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Designation"))
            MyCommand.Parameters.AddWithValue("@PaymentBasis", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PaymentBasis"))
            MyCommand.Parameters.AddWithValue("@BasicSalary", MyDataSet.Tables("selectEmployeeTab").Rows(0)("BasicSalary"))
            MyCommand.Parameters.AddWithValue("@Category", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Category"))
            MyCommand.Parameters.AddWithValue("@Address1", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Address1"))
            MyCommand.Parameters.AddWithValue("@Address2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Address2"))
            MyCommand.Parameters.AddWithValue("@Department", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Department"))
            MyCommand.Parameters.AddWithValue("@Nationality", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Nationality"))
            MyCommand.Parameters.AddWithValue("@DateOfJoining", MyDataSet.Tables("selectEmployeeTab").Rows(0)("DateOfJoining"))
            MyCommand.Parameters.AddWithValue("@AppraisalDate", MyDataSet.Tables("selectEmployeeTab").Rows(0)("AppraisalDate"))
            MyCommand.Parameters.AddWithValue("@ResignedDate", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ResignedDate"))
            MyCommand.Parameters.AddWithValue("@VisaNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("VisaNo"))
            MyCommand.Parameters.AddWithValue("@PassportNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PassportNo"))
            MyCommand.Parameters.AddWithValue("@ContractNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ContractNo"))
            MyCommand.Parameters.AddWithValue("@VisaExpiry", MyDataSet.Tables("selectEmployeeTab").Rows(0)("VisaExpiry"))
            MyCommand.Parameters.AddWithValue("@PassportExpiry", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PassportExpiry"))
            MyCommand.Parameters.AddWithValue("@IdentityProofNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("IdentityProofNo"))
            MyCommand.Parameters.AddWithValue("@PayableAccount", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PayableAccount"))
            MyCommand.Parameters.AddWithValue("@SalaryAccount", MyDataSet.Tables("selectEmployeeTab").Rows(0)("SalaryAccount"))
            MyCommand.Parameters.AddWithValue("@EmployeeStatus", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeStatus"))
            'MyCommand.Parameters.AddWithValue("@String1", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String1"))
            'MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            'MyCommand.Parameters.AddWithValue("@String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@ESINo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ESINo"))
            MyCommand.Parameters.AddWithValue("@PFNo", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PFNo"))
            MyCommand.Parameters.AddWithValue("@IdentityProofName", MyDataSet.Tables("selectEmployeeTab").Rows(0)("IdentityProofName"))
            MyCommand.Parameters.AddWithValue("@SalaryAccountBranch", MyDataSet.Tables("selectEmployeeTab").Rows(0)("SalaryAccountBranch"))

            MyCommand.Parameters.AddWithValue("@ESIApplicability", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ESIApplicability"))
            MyCommand.Parameters.AddWithValue("@PFApplicability", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PFApplicability"))
            MyCommand.Parameters.AddWithValue("@SalaryType", MyDataSet.Tables("selectEmployeeTab").Rows(0)("SalaryType"))

            MyCommand.Parameters.AddWithValue("@FixedSalary", MyDataSet.Tables("selectEmployeeTab").Rows(0)("FixedSalary"))
            MyCommand.Parameters.AddWithValue("@HRA", MyDataSet.Tables("selectEmployeeTab").Rows(0)("HRA"))
            MyCommand.Parameters.AddWithValue("@OtherSalary", MyDataSet.Tables("selectEmployeeTab").Rows(0)("OtherSalary"))

            MyCommand.Parameters.AddWithValue("@ESIEmployer", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ESIEmployer"))
            MyCommand.Parameters.AddWithValue("@PFEmployer", MyDataSet.Tables("selectEmployeeTab").Rows(0)("PFEmployer"))

            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeEarning(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeEarning"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@Earning_Name", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EarningName"))
            MyCommand.Parameters.AddWithValue("@Earning_Value", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EarningValue"))
            MyCommand.Parameters.AddWithValue("@Percentage", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Percentage"))
            MyCommand.Parameters.AddWithValue("@Earning_String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@Earning_String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeDeduction(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeDeduction"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@Deduction_Name", MyDataSet.Tables("selectEmployeeTab").Rows(0)("DeductionName"))
            MyCommand.Parameters.AddWithValue("@Deduction_Value", MyDataSet.Tables("selectEmployeeTab").Rows(0)("DeductionValue"))
            MyCommand.Parameters.AddWithValue("@Percentage", MyDataSet.Tables("selectEmployeeTab").Rows(0)("Percentage"))
            MyCommand.Parameters.AddWithValue("@Deduction_String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@Deduction_String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeSalaryAdvance(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeSalaryAdvance"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@sa_BalanceAmount", MyDataSet.Tables("selectEmployeeTab").Rows(0)("sa_BalanceAmount"))
            MyCommand.Parameters.AddWithValue("@sa_Installment", MyDataSet.Tables("selectEmployeeTab").Rows(0)("sa_Installment"))
            MyCommand.Parameters.AddWithValue("@sa_String1", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@sa_String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@sa_String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeloan(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_Employeeloan"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@loan_BalanceAmount", MyDataSet.Tables("selectEmployeeTab").Rows(0)("loan_BalanceAmount"))
            MyCommand.Parameters.AddWithValue("@loan_Installment", MyDataSet.Tables("selectEmployeeTab").Rows(0)("loan_Installment"))
            MyCommand.Parameters.AddWithValue("@loan_String1", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@loan_String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@loan_String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeShiftTimings(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeShiftTimings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeTab").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@FNCheckIn", MyDataSet.Tables("selectEmployeeTab").Rows(0)("FNCheckIn"))
            MyCommand.Parameters.AddWithValue("@FNCheckOut", MyDataSet.Tables("selectEmployeeTab").Rows(0)("FNCheckOut"))
            MyCommand.Parameters.AddWithValue("@ANCheckIn", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ANCheckIn"))
            MyCommand.Parameters.AddWithValue("@ANCheckOut", MyDataSet.Tables("selectEmployeeTab").Rows(0)("ANCheckOut"))
            MyCommand.Parameters.AddWithValue("@String1", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@String3", MyDataSet.Tables("selectEmployeeTab").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunDeleteEmployeeTab(ByVal EmployeeCode As String)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_Delete_EmployeeTab"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunSelectEmployeeDailyPayroll(ByVal DailyPayrollDate As DateTime, ByVal EmployeeCode As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeDailyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@DailyPayrollDate", DailyPayrollDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeDailyPayroll")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectEmployeeWeekly(ByVal DailyPayrollDate As DateTime, ByVal EmployeeCode As String,
                                ByVal WeekStartDate As DateTime, ByVal WeekEndDate As String,
                                ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeWeekly"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@DailyPayrollDate", DailyPayrollDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@WeekStartDate", WeekStartDate)
            MyCommand.Parameters.AddWithValue("@WeekEndDate", WeekEndDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "SelectEmployeeWeekly")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeDailyPayroll(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeDailyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@DailyPayrollDate", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("DailyPayrollDate"))
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@EmployeeName", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("EmployeeName"))
            MyCommand.Parameters.AddWithValue("@FirstEntry", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("FirstEntry"))
            MyCommand.Parameters.AddWithValue("@LastEntry", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LastEntry"))

            MyCommand.Parameters.AddWithValue("@OverTimeFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeFromHours"))
            MyCommand.Parameters.AddWithValue("@OverTimeToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeToHours"))
            MyCommand.Parameters.AddWithValue("@OverTimeComment", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeComment"))
            MyCommand.Parameters.AddWithValue("@PermissionFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionFromHours"))
            MyCommand.Parameters.AddWithValue("@PermissionToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionToHours"))
            MyCommand.Parameters.AddWithValue("@PermissionComment", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionComment"))
            MyCommand.Parameters.AddWithValue("@OnDutyFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OnDutyFromHours"))

            MyCommand.Parameters.AddWithValue("@OnDutyToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OnDutyToHours"))
            MyCommand.Parameters.AddWithValue("@OnDutyComment", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OnDutyComment"))
            MyCommand.Parameters.AddWithValue("@LeaveTypeFirstHalf", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LeaveTypeFirstHalf"))
            MyCommand.Parameters.AddWithValue("@LeaveFirstHalf", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LeaveFirstHalf"))
            MyCommand.Parameters.AddWithValue("@LeaveTypeSecondHalf", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LeaveTypeSecondHalf"))
            MyCommand.Parameters.AddWithValue("@LeaveSecondHalf", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LeaveSecondHalf"))
            MyCommand.Parameters.AddWithValue("@LeaveComment", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("LeaveComment"))
            MyCommand.Parameters.AddWithValue("@ExtraEntry", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("ExtraEntry"))

            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunUpdateEmployeeDailyPayroll(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeDailyPayrollUpdate"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@OverTimeFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeFromHours"))
            MyCommand.Parameters.AddWithValue("@OverTimeToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeToHours"))
            MyCommand.Parameters.AddWithValue("@OverTimeComments", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("OverTimeComment"))

            MyCommand.Parameters.AddWithValue("@PermissionFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionFromHours"))
            MyCommand.Parameters.AddWithValue("@PermissionToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionToHours"))
            MyCommand.Parameters.AddWithValue("@PermissionComments", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionComment"))

            MyCommand.Parameters.AddWithValue("@OnDutyFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionFromHours"))
            MyCommand.Parameters.AddWithValue("@OnDutyToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionToHours"))
            MyCommand.Parameters.AddWithValue("@OnDutyComments", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionComment"))

            MyCommand.Parameters.AddWithValue("@CompOffFromHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionFromHours"))
            MyCommand.Parameters.AddWithValue("@CompOffToHours", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionToHours"))
            MyCommand.Parameters.AddWithValue("@CompOffComments", MyDataSet.Tables("selectEmployeeDailyPayroll").Rows(0)("PermissionComment"))

            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function


    'Public Function FunSelectEmployeeLog(ByVal EmployeeCode As String, ByVal PayrollDate As DateTime) As DataSet
    '    Dim MyDataSet As New DataSet
    '    Try
    '        MyclassConnectSql.con.Open()
    '        MyCommand.Connection = MyclassConnectSql.con
    '        MyCommand.CommandType = CommandType.StoredProcedure
    '        MyCommand.CommandText = "Sp_SelectEmployeeLog"
    '        MyCommand.Parameters.Clear()
    '        MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
    '        MyCommand.Parameters.AddWithValue("@PayrollDate", PayrollDate)
    '        SqlDA.SelectCommand = MyCommand
    '        SqlDA.Fill(MyDataSet, "SelectEmployeeLog")
    '    Catch ex As Exception
    '        Err.Raise(Err.Number, , Err.Description)
    '    Finally
    '        MyclassConnectSql.con.Close()
    '    End Try
    '    Return MyDataSet
    'End Function

    Public Sub FunDeleteEmployeeDailyPayroll(ByVal DailyPayrollDate As DateTime)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_Delete_EmployeeDailyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@DailyPayrollDate", DailyPayrollDate)
            MyCommand.Parameters.AddWithValue("@iMode", 1)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunSelectEmployeeMonthlyPayroll(ByVal MonthlyPayrollDate As DateTime, ByVal EmployeeCode As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeMonthlyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectEmployeeWeeklyPayroll(ByVal FromDate As DateTime, ByVal ToDate As DateTime, ByVal EmployeeCode As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeWeeklyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectEmployeeMonthlyPayroll_Holidays(ByVal MonthlyPayrollDate As DateTime, ByVal EmployeeCode As String, ByVal iMode As Int16) As String
        'Dim MyDataSet As New DataSet
        Dim holidays As String = "NA"
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeMonthlyPayroll_Holidays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@Holidays", "")
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            'SqlDA.SelectCommand = MyCommand
            'SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll_Holidays")
            SqlDR = MyCommand.ExecuteReader
            'If SqlDR.HasRows Then
            While (SqlDR.Read)
                'LBItems.Items.Add(SqlDR.GetValue(0).ToString & " , " & SqlDR.GetValue(1).ToString)
                holidays = Convert.ToString(SqlDR.GetValue(0))
            End While
            'End If
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            SqlDR.Close()
            MyclassConnectSql.con.Close()
        End Try
        Return holidays
    End Function

    Public Function FunSelectEmployeeWeeklyPayroll_Holidays(ByVal FromDate As DateTime, ByVal ToDate As DateTime, ByVal EmployeeCode As String, ByVal iMode As Int16) As String
        'Dim MyDataSet As New DataSet
        Dim holidays As String = "NA"
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeWeeklyPayroll_Holidays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@Holidays", "")
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            'SqlDA.SelectCommand = MyCommand
            'SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll_Holidays")
            SqlDR = MyCommand.ExecuteReader
            'If SqlDR.HasRows Then
            While (SqlDR.Read)
                'LBItems.Items.Add(SqlDR.GetValue(0).ToString & " , " & SqlDR.GetValue(1).ToString)
                holidays = Convert.ToString(SqlDR.GetValue(0))
            End While
            'End If
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            SqlDR.Close()
            MyclassConnectSql.con.Close()
        End Try
        Return holidays
    End Function

    Public Function FunGetEmployeeMonthlyPayroll(ByVal MonthlyPayrollDate As DateTime, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetMonthlyPayrollList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunGetEmployeeWeeklyPayroll(ByVal FromDate As DateTime, ByVal ToDate As DateTime, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetWeeklyPayrollList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectEmployeeMonthlyPayroll")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeMonthlyPayroll(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeMonthlyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("MonthlyPayrollDate"))
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@EmployeeName", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("EmployeeName"))
            MyCommand.Parameters.AddWithValue("@WorkedDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("WorkedDays"))
            MyCommand.Parameters.AddWithValue("@Holidays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("Holidays"))
            MyCommand.Parameters.AddWithValue("@CLDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("CLDays"))
            MyCommand.Parameters.AddWithValue("@ELDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("ELDays"))
            MyCommand.Parameters.AddWithValue("@TotalPayableDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("TotalPayableDays"))
            MyCommand.Parameters.AddWithValue("@OTHours", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("OTHours"))
            MyCommand.Parameters.AddWithValue("@PermissionHours", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("PermissionHours"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveEmployeeWeeklyPayroll(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_EmployeeWeeklyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@FromDate", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("FromDate"))
            MyCommand.Parameters.AddWithValue("@ToDate", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("ToDate"))
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@EmployeeName", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("EmployeeName"))
            MyCommand.Parameters.AddWithValue("@WorkedDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("WorkedDays"))
            MyCommand.Parameters.AddWithValue("@Holidays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("Holidays"))
            MyCommand.Parameters.AddWithValue("@CLDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("CLDays"))
            MyCommand.Parameters.AddWithValue("@ELDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("ELDays"))
            MyCommand.Parameters.AddWithValue("@TotalPayableDays", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("TotalPayableDays"))
            MyCommand.Parameters.AddWithValue("@OTHours", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("OTHours"))
            MyCommand.Parameters.AddWithValue("@PermissionHours", MyDataSet.Tables("selectEmployeeMonthlyPayroll").Rows(0)("PermissionHours"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunDeleteEmployeeMonthlyPayroll(ByVal MonthlyPayrollDate As String)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_Delete_EmployeeMonthlyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunDeleteEmployeeWeeklyPayroll(ByVal FromDate As DateTime, ByVal ToDate As DateTime)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_Delete_EmployeeWeeklyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunSelectPayrollShiftTimeSettings(ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectPayrollShiftTimeSettings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectPayrollShiftTimeSettings")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSavePayrollShiftTimeSettings(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_PayrollShiftTimeSettings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@Date", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("Date"))
            MyCommand.Parameters.AddWithValue("@MorningHrs", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("MorningHrs"))
            MyCommand.Parameters.AddWithValue("@EveningHrs", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("EveningHrs"))
            MyCommand.Parameters.AddWithValue("@PermissionHrs", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("PermissionHrs"))
            MyCommand.Parameters.AddWithValue("@MaxLeavePerYear", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("MaxLeavePerYear"))
            MyCommand.Parameters.AddWithValue("@MinPFSalaryCriteria", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("MinPFSalaryCriteria"))
            MyCommand.Parameters.AddWithValue("@MaxPFSalaryCriteria", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("MaxPFSalaryCriteria"))

            MyCommand.Parameters.AddWithValue("@PFEmployeeContribution", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("PFEmployeeContribution"))
            MyCommand.Parameters.AddWithValue("@PFEmployerContribution", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("PFEmployerContribution"))
            MyCommand.Parameters.AddWithValue("@ESIEmployeeContribution", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("ESIEmployeeContribution"))
            MyCommand.Parameters.AddWithValue("@ESIEmployerContribution", MyDataSet.Tables("selectPayrollShiftTimeSettings").Rows(0)("ESIEmployerContribution"))

            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectListOfHolidays(ByVal MyDate As DateTime, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectListOfHolidays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@Date", MyDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectListOfHolidays")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveListOfHolidays(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_ListOfHolidays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectListOfHolidays").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@Date", MyDataSet.Tables("selectListOfHolidays").Rows(0)("Date"))
            MyCommand.Parameters.AddWithValue("@Description", MyDataSet.Tables("selectListOfHolidays").Rows(0)("Description"))
            MyCommand.Parameters.AddWithValue("@String1", MyDataSet.Tables("selectListOfHolidays").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectListOfHolidays").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@String3", MyDataSet.Tables("selectListOfHolidays").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function


    Public Function FunSelectPayrollOpenCloseSettings(ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectPayrollOpenCloseSettings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectPayrollOpenCloseSettings")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSavePayrollOpenCloseSettings(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_PayrollOpenCloseSettings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@Date", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("Date"))
            MyCommand.Parameters.AddWithValue("@OpenMonth", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("OpenMonth"))
            MyCommand.Parameters.AddWithValue("@OpenMonthValue", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("OpenMonthValue"))
            MyCommand.Parameters.AddWithValue("@OpenYear", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("OpenYear"))
            MyCommand.Parameters.AddWithValue("@Status", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("Status"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@String3", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("String3"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSaveWeeklyPayrollOpenCloseSettings(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_WeeklyPayrollOpenCloseSettings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@OpenedDate", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("OpenedDate"))
            MyCommand.Parameters.AddWithValue("@FromDate", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("FromDate"))
            MyCommand.Parameters.AddWithValue("@ToDate", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("ToDate"))
            MyCommand.Parameters.AddWithValue("@Status", MyDataSet.Tables("selectPayrollOpenCloseSettings").Rows(0)("Status"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectPaySlip(ByVal PaySlipNo As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectPaySlip"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@PaySlipNo", PaySlipNo)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectPaySlip")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSavePaySlip(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_PaySlip"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPaySlip").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@PaySlipNo", MyDataSet.Tables("selectPaySlip").Rows(0)("PaySlipNo"))
            MyCommand.Parameters.AddWithValue("@Date", MyDataSet.Tables("selectPaySlip").Rows(0)("Date"))
            MyCommand.Parameters.AddWithValue("@SalaryMonth", MyDataSet.Tables("selectPaySlip").Rows(0)("SalaryMonth"))
            MyCommand.Parameters.AddWithValue("@EmployeeCode", MyDataSet.Tables("selectPaySlip").Rows(0)("EmployeeCode"))
            MyCommand.Parameters.AddWithValue("@EmployeeName", MyDataSet.Tables("selectPaySlip").Rows(0)("EmployeeName"))
            MyCommand.Parameters.AddWithValue("@BasicSalary", MyDataSet.Tables("selectPaySlip").Rows(0)("BasicSalary"))
            MyCommand.Parameters.AddWithValue("@LeavesTaken", MyDataSet.Tables("selectPaySlip").Rows(0)("LeavesTaken"))
            MyCommand.Parameters.AddWithValue("@PermissionTaken", MyDataSet.Tables("selectPaySlip").Rows(0)("PermissionTaken"))
            MyCommand.Parameters.AddWithValue("@TotalOverTimeHrs", MyDataSet.Tables("selectPaySlip").Rows(0)("TotalOverTimeHrs"))
            MyCommand.Parameters.AddWithValue("@OverTimeSalary", MyDataSet.Tables("selectPaySlip").Rows(0)("OverTimeSalary"))
            MyCommand.Parameters.AddWithValue("@TotalEarnings", MyDataSet.Tables("selectPaySlip").Rows(0)("TotalEarnings"))
            MyCommand.Parameters.AddWithValue("@TotalDeductions", MyDataSet.Tables("selectPaySlip").Rows(0)("TotalDeductions"))
            MyCommand.Parameters.AddWithValue("@GrossSalary", MyDataSet.Tables("selectPaySlip").Rows(0)("GrossSalary"))
            MyCommand.Parameters.AddWithValue("@Advance", MyDataSet.Tables("selectPaySlip").Rows(0)("Advance"))
            MyCommand.Parameters.AddWithValue("@LoanInstallMent", MyDataSet.Tables("selectPaySlip").Rows(0)("LoanInstallMent"))
            MyCommand.Parameters.AddWithValue("@NetSalary", MyDataSet.Tables("selectPaySlip").Rows(0)("NetSalary"))
            MyCommand.Parameters.AddWithValue("@NoofDaysWorked", MyDataSet.Tables("selectPaySlip").Rows(0)("NoofDaysWorked"))
            MyCommand.Parameters.AddWithValue("@LeaveDays", MyDataSet.Tables("selectPaySlip").Rows(0)("LeaveDays"))
            MyCommand.Parameters.AddWithValue("@LeaveConcession", MyDataSet.Tables("selectPaySlip").Rows(0)("LeaveConcession"))
            MyCommand.Parameters.AddWithValue("@SalaryPercentForEarnings", MyDataSet.Tables("selectPaySlip").Rows(0)("SalaryPercentForEarnings"))
            MyCommand.Parameters.AddWithValue("@SalaryPercentForDeductions", MyDataSet.Tables("selectPaySlip").Rows(0)("SalaryPercentForDeductions"))
            MyCommand.Parameters.AddWithValue("@WeekStartDate", MyDataSet.Tables("selectPaySlip").Rows(0)("WeekStartDate"))
            MyCommand.Parameters.AddWithValue("@WeekEndDate", MyDataSet.Tables("selectPaySlip").Rows(0)("WeekEndDate"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectPaySlip").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@string3", MyDataSet.Tables("selectPaySlip").Rows(0)("string3"))
            MyCommand.Parameters.AddWithValue("@String4", MyDataSet.Tables("selectPaySlip").Rows(0)("String4"))
            MyCommand.Parameters.AddWithValue("@String5", MyDataSet.Tables("selectPaySlip").Rows(0)("String5"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSelectPaySlipAllowance(ByVal PaySlipNo As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectPaySlipAllowance"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@PaySlipNo", PaySlipNo)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "selectPaySlipAllowance")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSavePaySlipEarnings(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_PaySlipEarnings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@PaySlipNo", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("PaySlipNo"))
            MyCommand.Parameters.AddWithValue("@EarningName", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("EarningName"))
            MyCommand.Parameters.AddWithValue("@Percentage", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("Percentage"))
            MyCommand.Parameters.AddWithValue("@EarningValue", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("EarningValue"))
            MyCommand.Parameters.AddWithValue("@String1", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunSavePaySlipDeductions(ByVal MyDataSet As DataSet, ByVal iMode As Integer) As DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_PaySlipDeductions"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@SNo", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("SNo"))
            MyCommand.Parameters.AddWithValue("@PaySlipNo", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("PaySlipNo"))
            MyCommand.Parameters.AddWithValue("@DeductionName", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("DeductionName"))
            MyCommand.Parameters.AddWithValue("@Percentage", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("Percentage"))
            MyCommand.Parameters.AddWithValue("@DeductionValue", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("DeductionValue"))
            MyCommand.Parameters.AddWithValue("@String1", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("String1"))
            MyCommand.Parameters.AddWithValue("@String2", MyDataSet.Tables("selectPaySlipAllowance").Rows(0)("String2"))
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

#End Region
    Public Function FunGetWeeksOfPayrollMonth() As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetWeeksOfPayrollMonth"
            MyCommand.Parameters.Clear()
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "WeeksList")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunProcessNightShift(ByVal FromDate As Date, ByVal ToDate As Date)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 0
            MyCommand.CommandText = "ProcessNightShift"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.ExecuteNonQuery()
            MsgBox("Attendance Processing completed successfully")

        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunProcessNightShiftForReport()
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 0
            MyCommand.CommandText = "Report_ProcessNightShift"
            MyCommand.Parameters.Clear()
            MyCommand.ExecuteNonQuery()

        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunGetMonthlyPayrollDeduction(ByVal MonthlyPayrollDate As DateTime, ByVal DeductionId As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetMonthlyPayrollDuductionList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.Parameters.AddWithValue("@DeductionId", DeductionId)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "MonthlyPayrollDuductionList")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunGetWeeklyPayrollDeduction(ByVal FromDate As Date, ByVal ToDate As Date, ByVal DeductionId As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetWeeklyPayrollDuductionList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@DeductionId", DeductionId)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "WeeklyPayrollDuductionList")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunDeductionMonthlyMaster(ByVal Deduction As String, ByVal Comments As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "DeductionMonthlyMaster"
            MyCommand.Parameters.Clear()
            'MyCommand.Parameters.AddWithValue("@SNo", SNo)
            MyCommand.Parameters.AddWithValue("@Deduction", Deduction)
            MyCommand.Parameters.AddWithValue("@Comments", Comments)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "DeductionMonthlyMaster")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunMonthlyPayrollDuductionList(ByVal EmployeeCode As String, ByVal PayrollMonth As String, ByVal DeductionId As Int16, ByVal DeductionValue As String, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "MonthlyPayrollDuductionList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", PayrollMonth)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@DeductionId", DeductionId)
            MyCommand.Parameters.AddWithValue("@DeductionValue", DeductionValue)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunMonthlyPayrollDuductionList(ByVal EmployeeCode As String, ByVal FromDate As Date, ByVal ToDate As Date, ByVal DeductionId As Int16, ByVal DeductionValue As String, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "WeeklyPayrollDuductionList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@DeductionId", DeductionId)
            MyCommand.Parameters.AddWithValue("@DeductionValue", DeductionValue)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunWeeklyPayrollDuductionList(ByVal EmployeeCode As String, ByVal FromDate As Date, ByVal ToDate As Date, ByVal DeductionId As Int16, ByVal DeductionValue As String, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "WeeklyPayrollDuductionList"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@DeductionId", DeductionId)
            MyCommand.Parameters.AddWithValue("@DeductionValue", DeductionValue)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunMonthlyPayroll_Settings(ByVal PayrollMonth As String, ByVal AllowedDays As Int16, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "MonthlyPayroll_Settings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", PayrollMonth)
            MyCommand.Parameters.AddWithValue("@AllowedDays", AllowedDays)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunWeeklyPayroll_Settings(ByVal FromDate As Date, ByVal ToDate As Date, ByVal AllowedDays As Int16, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "WeeklyPayroll_Settings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@AllowedDays", AllowedDays)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunGetMonthlyPayroll_Settings(ByVal PayrollMonth As String, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "MonthlyPayroll_Settings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", PayrollMonth)
            MyCommand.Parameters.AddWithValue("@AllowedDays", 0)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "MonthlyPayrollSettings")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunGetWeeklyPayroll_Settings(ByVal FromDate As Date, ByVal ToDate As Date, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "WeeklyPayroll_Settings"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@AllowedDays", 0)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "MonthlyPayrollSettings")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunMonthlyPayrollAllowedDays(ByVal EmployeeCode As String, ByVal PayrollMonth As String, ByVal DeductionValue As String, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "MonthlyAllowedDays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", PayrollMonth)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@AllowedDays", DeductionValue)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub FunWeeklyPayrollAllowedDays(ByVal FromDate As Date, ByVal ToDate As Date, ByVal EmployeeCode As String, ByVal AllowedDays As String, ByVal iMode As Integer)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "WeeklyAllowedDays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
            MyCommand.Parameters.AddWithValue("@AllowedDays", AllowedDays)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Function FunGetMonthlyPayrollAllowedDays(ByVal MonthlyPayrollDate As DateTime, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetMonthlyAllowedDays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", MonthlyPayrollDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "MonthlyPayrollAllowedDaysList")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Function FunGetWeeklyPayrollAllowedDays(ByVal FromDate As Date, ByVal ToDate As Date, ByVal iMode As Int16) As DataSet
        Dim MyDataSet As New DataSet
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "GetWeeklyAllowedDays"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@iMode", iMode)
            SqlDA.SelectCommand = MyCommand
            SqlDA.Fill(MyDataSet, "WeeklyPayrollAllowedDaysList")
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
        Return MyDataSet
    End Function

    Public Sub FunGetOTDetail(ByVal FromDate As Date, ByVal ToDate As Date)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandTimeout = 0
            MyCommand.CommandText = "Report_SP_OT_Detail"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.ExecuteNonQuery()

        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub

    Public Sub ProcessWeeklyPayroll(ByVal FromDate As Date, ByVal ToDate As Date)
        Try
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "PayslipProcessing_Weekly"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.ExecuteNonQuery()
        Catch ex As Exception
            Err.Raise(Err.Number, , Err.Description)
        Finally
            MyclassConnectSql.con.Close()
        End Try
    End Sub
End Class
