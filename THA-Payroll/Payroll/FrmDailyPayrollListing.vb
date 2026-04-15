Public Class FrmDailyPayrollListing


#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean

    Dim NewPayrollDate As New DateTime
    Dim DailyPayrollDate As New DateTime

#End Region

    Public Sub FunListEmployees()
        'Try
        '    Dim i As New Long
        '    Dim PayrollDate As New DateTime
        '    Dim strDate As DateTime = Now.ToShortDateString
        '    DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(strDate, 0, 3)
        '    If DSEmp.Tables(0).Rows.Count > 0 Then
        '        For i = 0 To DSEmp.Tables(0).Rows.Count - 1
        '            Dim ChildNode As New TreeNode
        '            PayrollDate = DSEmp.Tables(0).Rows(i)("DailyPayrollDate")
        '            ChildNode.Text = PayrollDate.ToShortDateString
        '            ChildNode.Name = PayrollDate.ToShortDateString
        '            TrvDailyPayrollListing.Nodes.Add(ChildNode)
        '        Next
        '        TrvDailyPayrollListing.Select()
        '    End If
        'Catch ex As Exception
        '    'MsgBox(Err.Description)
        'End Try
    End Sub

    Private Sub FrmDailyPayrollListing_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmDailyPayrollListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButAdd.Click
        Try
            Dim MyForm As New FrmDailyPayroll

            Dim str As String
            str = MonthCalendar1.SelectionStart
            NewPayrollDate = str
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(NewPayrollDate.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                MsgBox("This Payroll Date is already Placed. Click Edit Button and View it.")
            Else
                MyForm.NewPayrollDate = NewPayrollDate.ToShortDateString
                MyForm.show()
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButEdit.Click
        Try
            Dim str As String
            str = MonthCalendar1.SelectionStart
            DailyPayrollDate = str

            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(DailyPayrollDate.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                FrmDailyPayroll.PayrollDate = DailyPayrollDate.ToShortDateString
                FrmDailyPayroll.Show()
            Else
                MsgBox("There is No Payroll Available For the Selected Date.")
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Try
            Dim str As String
            Dim msgboxRes As New MsgBoxResult

            str = MonthCalendar1.SelectionStart
            DailyPayrollDate = str

            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(DailyPayrollDate.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                msgboxRes = MessageBox.Show("Are you sure to Delete the Payrolls for the selected Date.: " & str & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    MyClassPayroll.FunDeleteEmployeeDailyPayroll(DailyPayrollDate)
                End If
            Else
                MsgBox("There is No Payroll Available For the Selected Date.")
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButOvertimeEntry_Click(sender As Object, e As EventArgs) Handles ButOvertimeEntry.Click
        Try
            Dim MyForm As New FrmOverTimeEntry

            Dim str As String
            str = MonthCalendar1.SelectionStart
            NewPayrollDate = str
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(NewPayrollDate.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count = 0 Then
                MsgBox("This Payroll Date is not yet placed.")
            Else
                MyForm.PayrollDate = NewPayrollDate.ToShortDateString
                MyForm.Show()
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim MyForm As New FrmPermissionEntry

            Dim str As String
            str = MonthCalendar1.SelectionStart
            NewPayrollDate = str
            DSEmp = MyClassPayroll.FunSelectEmployeeDailyPayroll(NewPayrollDate.ToShortDateString, 0, 2)
            If DSEmp.Tables(0).Rows.Count = 0 Then
                MsgBox("This Payroll Date is not yet placed.")
            Else
                MyForm.PayrollDate = NewPayrollDate.ToShortDateString
                MyForm.Show()
            End If

        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub
End Class