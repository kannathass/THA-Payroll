Imports system.data.sqlclient

Public Class FrmPopDailyPayrollEmpLOG

#Region "Declaration"
    Dim MyClassPayroll As New clsPayroll

    Dim MyclassConnectSql As New ConnectSql
    Dim MyCommand As New SqlCommand
    Dim SqlDR As SqlDataReader
    Dim SqlDA As New SqlDataAdapter

    Public EmployeeCode As String
    Public PayrollDate As New DateTime

    Public ViewMode As String

#End Region

    Public Sub FunFillAttendanceLogs()
        Try
            Dim RefNo As New Long
            Dim i, j As New Integer
            If EmployeeCode <> Nothing Then
                MyclassConnectSql.con.Close()
                MyclassConnectSql.con.Open()
                MyCommand.Connection = MyclassConnectSql.con
                MyCommand.CommandType = CommandType.StoredProcedure
                MyCommand.CommandText = "Sp_SelectEmployeeLog"
                MyCommand.Parameters.Clear()
                MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
                MyCommand.Parameters.AddWithValue("@PayrollDate", PayrollDate)
                MyCommand.Parameters.AddWithValue("@iMode", 1)
                SqlDR = MyCommand.ExecuteReader
                LBItems.Items.Clear()
                j = 1
                While (SqlDR.Read)
                    LBItems.Items.Add(j & ". " & SqlDR.GetValue(1).ToString)
                    j += 1
                End While
                SqlDR.Close()
                MyclassConnectSql.con.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

    Public Sub FunFillShiftTimings()
        Try
            Dim RefNo As New Long
            Dim i, j As New Integer
            If EmployeeCode <> Nothing Then
                MyclassConnectSql.con.Close()
                MyclassConnectSql.con.Open()
                MyCommand.Connection = MyclassConnectSql.con
                MyCommand.CommandType = CommandType.StoredProcedure
                MyCommand.CommandText = "Sp_SelectEmployeeLog"
                MyCommand.Parameters.Clear()
                MyCommand.Parameters.AddWithValue("@EmployeeCode", EmployeeCode)
                MyCommand.Parameters.AddWithValue("@PayrollDate", PayrollDate)
                MyCommand.Parameters.AddWithValue("@iMode", 2)
                SqlDR = MyCommand.ExecuteReader
                LBItems.Items.Clear()

                'Select EmployeeCode,FNCheckIn,FNCheckOut,ANCheckin,ANCheckOut From tblShiftTimings 
                'Where EmployeeCode=@EmployeeCode
                While (SqlDR.Read)
                    LBItems.Items.Add("1. " & SqlDR.GetValue(1).ToString)
                    LBItems.Items.Add("2. " & SqlDR.GetValue(2).ToString)
                    LBItems.Items.Add("3. " & SqlDR.GetValue(3).ToString)
                    LBItems.Items.Add("4. " & SqlDR.GetValue(4).ToString)
                End While
                SqlDR.Close()
                MyclassConnectSql.con.Close()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub


    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmPopDailyPayrollEmpLOG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        If ViewMode = "FillAttendanceLogs" Then
            FunFillAttendanceLogs()
        ElseIf ViewMode = "FillShiftTimings" Then
            FunFillShiftTimings()
        End If
    End Sub
End Class