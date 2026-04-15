Public Class FrmMonthlyPayrollListing


#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean

    'Dim NewPayrollMonth, NewPayrollYear As String
    Dim MonthlyPayrollDate As String

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

    Private Sub FrmMonthlyPayrollListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        cmbMonth.SelectedIndex = 0
        cmbYear.Items.Add("Select")
        cmbYear.SelectedIndex = 0
        FunLoadYear()
        FunFillExistingPayrollOpenCloseSettings()
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

    Private Sub ButAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButAdd.Click
        Try
            Dim MyForm As New FrmMonthlyPayroll
            If cmbMonth.Text <> "Select" And cmbYear.Text <> "Select" Then

                MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
                If MonthlyPayrollDate <> Nothing Then
                    DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(MonthlyPayrollDate, 0, 2)
                    If DSEmp.Tables(0).Rows.Count > 0 Then
                        MsgBox("Payroll is already Placed for the Selected Month.")
                    Else
                        'NewPayrollMonth = cmbMonth.Text
                        'NewPayrollYear = cmbYear.Text
                        FrmMonthlyPayroll.NewPayrollMonth = cmbMonth.Text
                        FrmMonthlyPayroll.NewPayrollYear = cmbYear.Text
                        FrmMonthlyPayroll.MonthlyPayrollDate = MonthlyPayrollDate

                        FrmMonthlyPayroll.Show()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButEdit.Click
        Try
            If cmbMonth.Text <> "Select" And cmbYear.Text <> "Select" Then
                MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
                If MonthlyPayrollDate <> Nothing Then
                    DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(MonthlyPayrollDate, 0, 2)
                    If DSEmp.Tables(0).Rows.Count > 0 Then
                        'NewPayrollMonth = cmbMonth.Text
                        'NewPayrollYear = cmbYear.Text
                        FrmMonthlyPayroll.ExistingMode = True
                        FrmMonthlyPayroll.NewPayrollMonth = cmbMonth.Text
                        FrmMonthlyPayroll.NewPayrollYear = cmbYear.Text
                        FrmMonthlyPayroll.MonthlyPayrollDate = MonthlyPayrollDate
                        FrmMonthlyPayroll.Show()
                    Else
                        MsgBox("There is No Payroll Available For the Selected Date.")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Try
            Dim str As String
            Dim msgboxRes As New MsgBoxResult

            MonthlyPayrollDate = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            If MonthlyPayrollDate <> Nothing Then
                Dim objDate As DateTime = MonthlyPayrollDate
                DSEmp = MyClassPayroll.FunSelectEmployeeMonthlyPayroll(MonthlyPayrollDate, 0, 2)
                If DSEmp.Tables(0).Rows.Count > 0 Then
                    msgboxRes = MessageBox.Show("Are you sure to Delete the Payrolls for the selected Date.: " & str & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If msgboxRes = MsgBoxResult.Yes Then
                        MyClassPayroll.FunDeleteEmployeeMonthlyPayroll(MonthlyPayrollDate)
                    End If
                Else
                    MsgBox("There is No Payroll Available For the Selected Date.")
                End If
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Me.Close()
    End Sub
End Class