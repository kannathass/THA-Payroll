Imports system.data.sqlclient

Public Class PopEmployeeNames


#Region "Declaration"
    Dim MyClassPayroll As New clsPayroll
    Dim selectionConfirm As Boolean = False

    Dim MyclassConnectSql As New ConnectSql
    Dim MyCommand As New SqlCommand
    Dim SqlDR As SqlDataReader
    Dim SqlDA As New SqlDataAdapter

    Public Empcode, EmpName As String

#End Region

#Region "Function"

    Public Sub FunFillDailyEmployeeNames()
        Try
            Dim RefNo As New Long
            Dim i, j As New Integer
            MyclassConnectSql.con.Close()
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeDailyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@DailyPayrollDate", "")
            MyCommand.Parameters.AddWithValue("@EmployeeCode", 0)
            MyCommand.Parameters.AddWithValue("@iMode", 4)
            SqlDR = MyCommand.ExecuteReader
            LBItems.Items.Clear()
            If SqlDR.HasRows Then
                While (SqlDR.Read)
                    LBItems.Items.Add(SqlDR.GetValue(0).ToString & " , " & SqlDR.GetValue(1).ToString)
                End While
            End If
            SqlDR.Close()
            MyclassConnectSql.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFillMonthlyEmployeeNames()
        Try
            Dim RefNo As New Long
            Dim i, j As New Integer
            MyclassConnectSql.con.Close()
            MyclassConnectSql.con.Open()
            MyCommand.Connection = MyclassConnectSql.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "SP_SelectEmployeeMonthlyPayroll"
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@MonthlyPayrollDate", 0)
            MyCommand.Parameters.AddWithValue("@EmployeeCode", 0)
            MyCommand.Parameters.AddWithValue("@iMode", 4)
            SqlDR = MyCommand.ExecuteReader
            LBItems.Items.Clear()
            While (SqlDR.Read)
                LBItems.Items.Add(SqlDR.GetValue(0).ToString & " , " & SqlDR.GetValue(1).ToString)
            End While

            SqlDR.Close()
            MyclassConnectSql.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try

    End Sub

#End Region

    Private Sub PopEmployeeNames_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub PopEmployeeNames_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Try
            If FrmMonthlyPayroll.FrmMonthlyPayrollView = True Then
                FunFillMonthlyEmployeeNames()
            Else
                FunFillDailyEmployeeNames()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Dim arr() As String
            Dim str As String
            Empcode = Nothing
            EmpName = Nothing
            If selectionConfirm = True Then
                str = LBItems.SelectedItem.ToString
                arr = str.Split(",")
                Empcode = Trim(arr(0))
                EmpName = Trim(arr(1))
            End If
            selectionConfirm = False
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            selectionConfirm = False
            Empcode = Nothing
            EmpName = Nothing
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub LBItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LBItems.SelectedIndexChanged
        Try
            selectionConfirm = True
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class