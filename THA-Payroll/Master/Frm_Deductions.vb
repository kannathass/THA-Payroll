Public Class Frm_Deductions
    Dim MyClassPayroll As New clsPayroll
    Dim datacon As New ConnectSql
    Dim DSEmp As DataSet

    Private Sub Frm_Deductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FunLoadDeduction()
        'DGVDeductions.Focus()
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click

        If Validation() Then
            saveData()
            ButClear_Click(Nothing, Nothing)
            FunLoadDeduction()
        End If
    End Sub

    Private Sub ButClose_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        Me.Close()
    End Sub

    Private Sub saveData()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd.Connection = datacon.con
        datacon.cmd.CommandType = CommandType.StoredProcedure
        datacon.cmd.CommandText = "DeductionMonthlyMaster"
        datacon.cmd.Parameters.AddWithValue("@Deduction", Trim(txtDeduction.Text))
        datacon.cmd.Parameters.AddWithValue("@Comments", Trim(txtDescription.Text))
        datacon.cmd.Parameters.AddWithValue("@iMode", 1)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub

    Private Sub FunLoadDeduction()
        Try
            Dim i As New Integer

            'DGVDeductions.Rows.Clear()
            DSEmp = MyClassPayroll.FunDeductionMonthlyMaster("", "", 2)
            If DSEmp.Tables(0).Rows.Count > 0 Then
                DGVDeductions.DataSource = DSEmp.Tables(0)
                DGVDeductions.AutoGenerateColumns = True
                'DGVDeductions.DataBindings()
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DGVDeductions_MouseClick(sender As Object, e As MouseEventArgs) Handles DGVDeductions.MouseClick
        txtDeduction.Text = DGVDeductions.SelectedCells.Item(1).Value.ToString
        txtDescription.Text = DGVDeductions.SelectedCells.Item(2).Value.ToString

    End Sub

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        txtDeduction.Clear()
        txtDescription.Clear()
    End Sub

    Public Function Validation() As Boolean
        Dim Valid As Boolean = True
        LabelError.Visible = False
        If Trim(txtDeduction.Text) = Nothing Then
            LabelError.Text = "Enter Deduction Name"
            Valid = False
            LabelError.Visible = True
        End If
        Return Valid
    End Function
End Class