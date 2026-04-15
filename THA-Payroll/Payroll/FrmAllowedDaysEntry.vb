Public Class FrmAllowedDaysEntry
    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As DataSet
    Private Sub FrmAllowedDaysEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunLoadYear()
        FunFillExistingPayrollOpenCloseSettings()
        FunFillMonthlyPayrollSettings()
    End Sub

    Private Sub cmbMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonth.SelectedIndexChanged
        ClearForm()
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbYear.SelectedIndexChanged
        ClearForm()
    End Sub

    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            DGVAllowedDays.ClearSelection()
            DGVAllowedDays.FirstDisplayedScrollingRowIndex = 0
        End If
    End Sub

    Private Sub ButLoad_Click(sender As Object, e As EventArgs) Handles ButLoad.Click
        If Validation() = True Then
            ClearForm()
            FunFillExistingItems()
        End If
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        If Validation() = True And DGVAllowedDays.Rows.Count > 0 Then
            FunSaveMonthlyPayrollDeduction()

            Me.Close()
        End If
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim msgboxRes As New MsgBoxResult
        If Validation() Then
            If (DGVAllowedDays.Rows.Count > 0) Then
                msgboxRes = MessageBox.Show("Are you sure want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    FunDeleteMonthlyPayrollAllowedDays()
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

    Sub FunSaveMonthlyPayrollDeduction()
        Try
            Dim i As New Integer

            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            For i = 0 To DGVAllowedDays.RowCount - 1

                MyClassPayroll.FunMonthlyPayrollAllowedDays(DGVAllowedDays("EmployeeCode", i).Value.ToString, MonthlyPayrollDate,
                                                                  IIf(DGVAllowedDays("AllowedDays", i).Value <> Nothing,
                                                                      Convert.ToString(DGVAllowedDays("AllowedDays", i).Value), ""), 1)
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
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

    Private Function CleanInputNumber(ByVal str As String) As String
        Return System.Text.RegularExpressions.Regex.Replace(str, "[a-zA-Z\b\s]", "")
    End Function

    Function Validation() As Boolean
        Try
            Dim Valid As Boolean = True
            If Trim(cmbMonth.Text) = "Select" Then
                lblErrorMessage.Text = "Select Month"
                Valid = False
            ElseIf Trim(cmbYear.Text) = "Select" Then
                lblErrorMessage.Text = "Select Year"
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

    Sub ClearForm()
        txtFilter.Clear()
        DGVAllowedDays.Rows.Clear()
    End Sub

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

    Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i, Month As New Integer
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            DSEmp = MyClassPayroll.FunGetMonthlyPayrollAllowedDays(MonthlyPayrollDate, 1)
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

    Sub FunDeleteMonthlyPayrollAllowedDays()
        Try
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)

            MyClassPayroll.FunMonthlyPayrollAllowedDays("", MonthlyPayrollDate, "", 2)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunFillMonthlyPayrollSettings()
        Try
            DSEmp = MyClassPayroll.FunGetMonthlyPayroll_Settings(Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text), 1)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtAllowedDays.Text = DSEmp.Tables(0).Rows(0)("AllowedDays")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

End Class