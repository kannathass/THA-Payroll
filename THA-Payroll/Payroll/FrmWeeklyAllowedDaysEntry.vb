Public Class FrmWeeklyAllowedDaysEntry
    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet

    Dim fromDate As Date
    Dim toDate As Date

    Private Sub FrmWeeklyAllowedDaysEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunFillExistingWeeklyPayrollOpenCloseSettings()
        FunFillWeeklyPayrollSettings()
    End Sub

    Private Sub ButLoad_Click(sender As Object, e As EventArgs) Handles ButLoad.Click

        'If Validation() = True Then
        ClearForm()
        FunFillExistingItems()
        'End If
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        If Validation() = True And DGVAllowedDays.Rows.Count > 0 Then
            FunSaveWeeklyPayrollAllowedDays()

            Me.Close()
        Else
            MsgBox("You can not save. Check the payroll Settings.")
        End If
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim msgboxRes As New MsgBoxResult

        If Validation() Then
            If (DGVAllowedDays.Rows.Count > 0) Then
                msgboxRes = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    FunDeleteWeeklyPayrollAllowedDays()
                    Me.Close()
                End If
            Else
                lblErrorMessage.Text = "No Record Found"
                lblErrorMessage.Visible = True
            End If
        Else
            MsgBox("You can not delete. Check the payroll Settings.")
        End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub DGVAllowedDays_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAllowedDays.CellEnter
        On Error Resume Next
        DGVAllowedDays(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVAllowedDays(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVAllowedDays_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVAllowedDays.CellLeave
        On Error Resume Next
        DGVAllowedDays(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVAllowedDays(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White

    End Sub

    Private Sub DGVAllowedDays_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGVAllowedDays.CellValidating
        Dim cell As DataGridViewCell = DGVAllowedDays.Item(e.ColumnIndex, e.RowIndex)
        If cell.IsInEditMode Then
            Dim c As Control = DGVAllowedDays.EditingControl

            Select Case DGVAllowedDays.Columns(e.ColumnIndex).Name
                Case "AllowedDays"
                    c.Text = CleanInputNumber(c.Text)
            End Select
        End If
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            DGVAllowedDays.ClearSelection()
            DGVAllowedDays.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Private Sub DtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DtStartDate.ValueChanged
        ClearForm()
    End Sub

    Private Sub DtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DtEndDate.ValueChanged
        ClearForm()
    End Sub

    Sub ClearForm()
        lblErrorMessage.Visible = False
        txtFilter.Clear()
        DGVAllowedDays.Rows.Clear()
    End Sub


    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s]", "")
    End Function

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            DGVAllowedDays.ClearSelection()

            For i = 0 To DGVAllowedDays.RowCount - 1
                For j = 0 To 1
                    If DGVAllowedDays(j, i).Value <> Nothing And DGVAllowedDays(j, i).Value.ToString.ToUpper.Contains(strFilter.ToUpper) Then
                        DGVAllowedDays.FirstDisplayedScrollingRowIndex = i
                        DGVAllowedDays.Rows(i).Selected = True
                    End If
                Next
            Next
        Catch ex As Exception
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

    Sub FunFillExistingItems()
        Try
            Dim i As New Integer
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value
            DSEmp = MyClassPayroll.FunGetWeeklyPayrollAllowedDays(fromDate, toDate, 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DSEmp.Tables(0).Rows.Count - 1
                    DGVAllowedDays.Rows.Add()
                    DGVAllowedDays("EmployeeCode", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeCode")
                    DGVAllowedDays("EmployeeName", i).Value = DSEmp.Tables(0).Rows(i)("EmployeeName")
                    DGVAllowedDays("AllowedDays", i).Value = IIf(DSEmp.Tables(0).Rows(i)("AllowedDays") = Nothing, 0, DSEmp.Tables(0).Rows(i)("AllowedDays"))
                Next
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub FunSaveWeeklyPayrollAllowedDays()
        Try
            Dim i As New Integer
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value

            For i = 0 To DGVAllowedDays.RowCount - 1

                MyClassPayroll.FunWeeklyPayrollAllowedDays(fromDate, toDate, DGVAllowedDays("EmployeeCode", i).Value.ToString,
                                                                  IIf(DGVAllowedDays("AllowedDays", i).Value <> Nothing,
                                                                      Convert.ToString(DGVAllowedDays("AllowedDays", i).Value), ""), 1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Sub FunDeleteWeeklyPayrollAllowedDays()
        Try
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value

            MyClassPayroll.FunWeeklyPayrollAllowedDays(fromDate, toDate, "", "", 2)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunFillWeeklyPayrollSettings()
        Try
            fromDate = DtStartDate.Value
            toDate = DtEndDate.Value

            DSEmp = MyClassPayroll.FunGetWeeklyPayroll_Settings(fromDate, toDate, 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtAllowedDays.Text = DSEmp.Tables(0).Rows(0)("AllowedDays")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class