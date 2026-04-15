Public Class FrmMonthlyDeductions
    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As DataSet
    Private Sub FrmMonthlyDeductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunLoadYear()
        FunFillExistingPayrollOpenCloseSettings()
        FunFillDeductionMaster()
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        If Validation() = True And DGVPayroll.Rows.Count > 0 Then
            FunSaveMonthlyPayrollDeduction()
            MsgBox("Deductions saved successfully")
            ClearForm()
        End If
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim msgboxRes As New MsgBoxResult
        If Validation() Then
            If (DGVPayroll.Rows.Count > 0) Then
                msgboxRes = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    FunDeleteMonthlyPayrollDeduction()
                    Me.Close()
                End If
            Else
                lblErrorMessage.Text = "No Record Found"
                lblErrorMessage.Visible = True
            End If
        End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub ButLoad_Click(sender As Object, e As EventArgs) Handles ButLoad.Click
        If Validation() = True Then
            ClearForm()
            FunFillExistingItems()
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            DGVPayroll.ClearSelection()
            DGVPayroll.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Private Sub cmbDeduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDeduction.SelectedIndexChanged
        ClearForm()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        ClearForm()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        ClearForm()
    End Sub

    Private Sub DGVPayroll_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayroll.CellEnter
        On Error Resume Next
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVPayroll_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVPayroll.CellLeave
        On Error Resume Next
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVPayroll(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
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

    Public Sub FunLoadYear()
        Try
            Dim i As New Integer
            For i = 2016 To 2025
                cmbYear.Items.Add(i)
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FunFillDeductionMaster()
        Try
            Dim i As New Integer

            cmbDeduction.Items.Clear()
            DSEmp = MyClassPayroll.FunDeductionMonthlyMaster("", "", 3)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                'cmbDeduction.Items.Add("Select")
                cmbDeduction.DataSource = DSEmp.Tables(0)
                cmbDeduction.DisplayMember = "Deduction"
                cmbDeduction.ValueMember = "SNo"
                'For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                '    cmbDeduction.Items.Add(DSEmp.Tables(0).Rows(i)("Deduction"))
                'Next
                'cmbDeduction.SelectedValue = "Select"
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function Validation() As Boolean
        Try
            Dim Valid As Boolean = True
            If Trim(cmbMonth.Text) = "Select" Then
                lblErrorMessage.Text = "Select Month"
                Valid = False
            ElseIf Trim(cmbYear.Text) = "Select" Then
                lblErrorMessage.Text = "Select Year"
                Valid = False
            ElseIf Trim(cmbDeduction.Text) = "Select" Then
                lblErrorMessage.Text = "Select Deduction"
                Valid = False
            End If
            If Valid Then
                lblErrorMessage.Visible = False
            Else
                lblErrorMessage.Visible = True
            End If
            Return Valid
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function


    Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i, Month As New Integer
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            DSEmp = MyClassPayroll.FunGetMonthlyPayrollDeduction(MonthlyPayrollDate, cmbDeduction.SelectedValue, 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVPayroll.Rows.Add()
                    DGVPayroll("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVPayroll("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                    DGVPayroll("DeductionValue", i).Value = IIf(DSEmp.Tables(0).Rows(i)("DeductionValue") = Nothing, "", DSEmp.Tables(0).Rows(i)("DeductionValue"))
                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub FunSaveMonthlyPayrollDeduction()
        Try
            Dim i As New Integer
            'Dim DStemp As New DataSet
            'Dim MyRow As DataRow
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            'DStemp = MyClassPayroll.FunGetMonthlyPayrollDeduction(MonthlyPayrollDate, cmbDeduction.Text, 1)

            For i = 0 To DGVPayroll.RowCount - 1
                'DStemp.Tables("MonthlyPayrollDuductionList").Rows.Clear()

                'MyRow = DStemp.Tables("MonthlyPayrollDuductionList").NewRow
                'MyRow("EmployeeCode") = DGVPayroll("EmployeeCode", i).Value.ToString

                'If DGVPayroll("DeductionValue", i).Value <> Nothing Then
                '    MyRow("DeductionValue") = DGVPayroll("DeductionValue", i).Value.ToString
                'Else
                '    MyRow("DeductionValue") = ""
                'End If
                'DStemp.Tables("MonthlyPayrollDuductionList").Rows.Add(MyRow)
                MyClassPayroll.FunMonthlyPayrollDuductionList(DGVPayroll("EmployeeCode", i).Value.ToString, MonthlyPayrollDate, cmbDeduction.SelectedValue,
                                                                  IIf(DGVPayroll("DeductionValue", i).Value <> Nothing, Convert.ToString(DGVPayroll("DeductionValue", i).Value), ""), 1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub


    Sub FunDeleteMonthlyPayrollDeduction()
        Try
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            MyClassPayroll.FunMonthlyPayrollDuductionList("", MonthlyPayrollDate, cmbDeduction.SelectedValue, "", 2)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub ClearForm()
        lblErrorMessage.Visible = False
        txtFilter.Clear()
        DGVPayroll.Rows.Clear()
    End Sub

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            DGVPayroll.ClearSelection()

            For i = 0 To DGVPayroll.RowCount - 1
                For j = 0 To 1
                    If DGVPayroll(j, i).Value <> Nothing And DGVPayroll(j, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                        DGVPayroll.FirstDisplayedScrollingRowIndex = i
                        DGVPayroll.Rows(i).Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGVPayroll_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVPayroll.CellValidating
        Dim cell As DataGridViewCell = DGVPayroll.Item(e.ColumnIndex, e.RowIndex)
        If cell.IsInEditMode Then
            Dim c As Control = DGVPayroll.EditingControl

            Select Case DGVPayroll.Columns(e.ColumnIndex).Name
                Case "DeductionValue"
                    c.Text = CleanInputNumber(c.Text)
            End Select
        End If
    End Sub

    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
    End Function
End Class