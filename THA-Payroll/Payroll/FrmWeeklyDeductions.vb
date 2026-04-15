Public Class FrmWeeklyDeductions
    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As DataSet

    Dim fromDate As Date
    Dim toDate As Date
    Private Sub FrmWeeklyDeductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunFillExistingWeeklyPayrollOpenCloseSettings()
        FunFillDeductionMaster()
    End Sub

    Private Sub ButLoad_Click(sender As Object, e As EventArgs) Handles ButLoad.Click
        If Validation() = True Then
            ClearForm()
            FunFillExistingItems()
        End If
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        If Validation() = True And DGVPayroll.Rows.Count > 0 Then
            FunSaveWeeklyPayrollDeduction()
            MsgBox("Deductions saved successfully")
            ClearForm()
        End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim msgboxRes As New MsgBoxResult
        If Validation() Then
            If (DGVPayroll.Rows.Count > 0) Then
                msgboxRes = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    FunDeleteWeeklyPayrollDeduction()
                    Me.Close()
                End If
            Else
                lblErrorMessage.Text = "No Record Found"
                lblErrorMessage.Visible = True
            End If
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

    Private Sub DtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DtStartDate.ValueChanged
        ClearForm()
    End Sub

    Private Sub DtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DtEndDate.ValueChanged
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

    Public Sub FunFillExistingWeeklyPayrollOpenCloseSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                DtStartDate.Value = DSEmp.Tables(0).Rows(0)("FromDate")
                DtEndDate.Value = DSEmp.Tables(0).Rows(0)("ToDate")
                lblMessage.Text = "Current payroll week (" + DtStartDate.Value.Date + " - " + DtEndDate.Value.Date + ") Status (" + DSEmp.Tables(0).Rows(0)("Status") + ")"
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunFillDeductionMaster()
        Try
            Dim i As New Integer

            cmbDeduction.Items.Clear()
            DSEmp = MyClassPayroll.FunDeductionMonthlyMaster("", "", 3)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                cmbDeduction.DataSource = DSEmp.Tables(0)
                cmbDeduction.DisplayMember = "Deduction"
                cmbDeduction.ValueMember = "SNo"
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Function Validation() As Boolean
        Try
            Dim Valid As Boolean = True

            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                Dim Status As String = DSEmp.Tables(0).Rows(0)("Status")

                Dim fromDate As Date = DSEmp.Tables(0).Rows(0)("FromDate")
                Dim toDate As Date = DSEmp.Tables(0).Rows(0)("ToDate")

                If (fromDate.Date <> DtStartDate.Value.Date Or toDate.Date <> DtEndDate.Value.Date Or Status = "Close") Then
                    Valid = False
                End If
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

    Sub FunSaveWeeklyPayrollDeduction()
        Try
            Dim i As New Integer
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value

            For i = 0 To DGVPayroll.RowCount - 1
                MyClassPayroll.FunWeeklyPayrollDuductionList(DGVPayroll("EmployeeCode", i).Value.ToString, fromDate, toDate, cmbDeduction.SelectedValue,
                                                                  IIf(DGVPayroll("DeductionValue", i).Value <> Nothing, Convert.ToString(DGVPayroll("DeductionValue", i).Value), ""), 1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub ClearForm()
        lblErrorMessage.Visible = False
        txtFilter.Clear()
        DGVPayroll.Rows.Clear()
    End Sub

    Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i, Month As New Integer
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value
            DSEmp = MyClassPayroll.FunGetWeeklyPayrollDeduction(fromDate, toDate, cmbDeduction.SelectedValue, 1)
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

    Sub FunDeleteWeeklyPayrollDeduction()
        Try
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value
            MyClassPayroll.FunWeeklyPayrollDuductionList("", fromDate, toDate, cmbDeduction.SelectedValue, "", 2)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
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

    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s-]", "")
    End Function
End Class