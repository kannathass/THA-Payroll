Imports System.Data.SqlClient

Public Class Frm_Filter_WeeklyPayroll
    Dim MyCommand As New SqlCommand
    Dim DSEmp As DataSet

    Dim MyClassPayroll As New clsPayroll
    Dim datacon As New ConnectSql
    Dim VDP_Fields As New ArrayList
    Dim VDP_Comparison As New ArrayList
    Dim VDP_Conjunction As New ArrayList
    Dim VDP_Month As New ArrayList
    Dim objIniFile As New IniFile(Application.StartupPath & "\data.ini")
    Dim strDesc As String
    Dim strName As String
    Public ReportQuery As String
    Dim strField As String
    Dim strCompare As String
    Dim strConjunction As String
    Dim dateQuery As String
    Dim ConcatQuery As String
    Public FromDate As Date
    Public ToDate As Date
    Private Sub Frm_Filter_WeeklyPayroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Load_Department()
        Load_Category()
        FunFillExistingWeeklyPayrollOpenCloseSettings()
        Add_Fields()
        Add_Comparison()
        Add_Conjunction()
    End Sub

    Private Sub ButGenerate_Click(sender As Object, e As EventArgs) Handles ButGenerate.Click
        Dim valid_list As Boolean
        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            'Generate_Query()
            BindMonthlyAttendance()
            ReportPage.FrmName = "Weekly_Consolidated_Payslip"

            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()

    End Sub

    Private Sub DGVFilterField_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFilterField.CellEnter
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.PaleGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.DarkGreen
    End Sub

    Private Sub DGVFilterField_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVFilterField.CellLeave
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.DarkOliveGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.White
    End Sub

    Private Sub CheckedListBoxDepartment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxDepartment.SelectedIndexChanged
        If CheckedListBoxDepartment.SelectedItem.ToString = "Select All" Then
            If CheckedListBoxDepartment.GetItemChecked(0) Then
                For idx As Integer = 1 To CheckedListBoxDepartment.Items.Count - 1

                    CheckedListBoxDepartment.SetItemCheckState(idx, CheckState.Checked)

                Next
            Else
                For idx As Integer = 1 To CheckedListBoxDepartment.Items.Count - 1

                    CheckedListBoxDepartment.SetItemCheckState(idx, CheckState.Unchecked)

                Next
            End If
        End If
    End Sub

    Private Sub CheckedListBoxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxCategory.SelectedIndexChanged
        If CheckedListBoxCategory.SelectedItem.ToString = "Select All" Then
            If CheckedListBoxCategory.GetItemChecked(0) Then
                For idx As Integer = 1 To CheckedListBoxCategory.Items.Count - 1

                    CheckedListBoxCategory.SetItemCheckState(idx, CheckState.Checked)

                Next
            Else
                For idx As Integer = 1 To CheckedListBoxCategory.Items.Count - 1

                    CheckedListBoxCategory.SetItemCheckState(idx, CheckState.Unchecked)

                Next
            End If
        End If
    End Sub

    Private Sub DtStartDate_ValueChanged(sender As Object, e As EventArgs) Handles DtStartDate.ValueChanged

    End Sub

    Private Sub DtEndDate_ValueChanged(sender As Object, e As EventArgs) Handles DtEndDate.ValueChanged

    End Sub

    Public Sub BindMonthlyAttendance()
        Try
            FromDate = DtStartDate.Value.Date
            ToDate = DtEndDate.Value.Date

            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "Report_SP_PayslipWeeklyConsolidated"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            MyCommand.Parameters.AddWithValue("@FromDate", FromDate)
            MyCommand.Parameters.AddWithValue("@ToDate", ToDate)
            MyCommand.Parameters.AddWithValue("@FilterDepartment", getSelectedDepartment())
            MyCommand.Parameters.AddWithValue("@FilterCategory", getSelectedCategory())
            MyCommand.ExecuteNonQuery()
            'datacon.con.Close()
        Catch ex As Exception
            MsgBox(Err.Description)
        Finally
            datacon.con.Close()
        End Try
    End Sub

    Function getSelectedDepartment() As String
        Dim strDepartments As String = ""

        If CheckedListBoxDepartment.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBoxDepartment.CheckedItems.Count - 1
                strDepartments = strDepartments + "|" + CheckedListBoxDepartment.CheckedItems(i)
            Next
        End If

        Return strDepartments
    End Function

    Function getSelectedCategory() As String
        Dim strCategorys As String = ""

        If CheckedListBoxCategory.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBoxCategory.CheckedItems.Count - 1
                strCategorys = strCategorys + "|" + CheckedListBoxCategory.CheckedItems(i)
            Next
        End If

        Return strCategorys
    End Function

    Public Sub FunFillExistingWeeklyPayrollOpenCloseSettings()
        Try
            Dim i As New Integer
            DSEmp = MyClassPayroll.FunSelectPayrollOpenCloseSettings(2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                DtStartDate.Value = DSEmp.Tables(0).Rows(0)("FromDate")
                DtEndDate.Value = DSEmp.Tables(0).Rows(0)("ToDate")
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Load_Department()
        CheckedListBoxDepartment.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.HasRows Then
            CheckedListBoxDepartment.Items.Add("Select All")
            While datacon.dr.Read
                CheckedListBoxDepartment.Items.Add(datacon.dr.GetValue(0))
            End While
            'cmbDptName.SelectedIndex = 0
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub Load_Category()
        CheckedListBoxCategory.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Categ_Name from Category_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.HasRows Then
            CheckedListBoxCategory.Items.Add("Select All")
            While datacon.dr.Read
                CheckedListBoxCategory.Items.Add(datacon.dr.GetValue(0))
            End While
            'cmbCategName.SelectedIndex = 0
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub


    Private Sub Add_Fields()
        Dim i As Integer
        strName = "Hai"
        i = 1
        VDP_Fields.Clear()
        TableFields.Items.Clear()

        While strName <> "(none)"
            strName = objIniFile.GetString("Monthly_Payroll", "Field" & i & ".Name", "(none)")
            strDesc = objIniFile.GetString("Monthly_Payroll", "Field" & i & ".Desc", "(none)")
            If strName <> "(none)" And strDesc <> "(none)" Then
                VDP_Fields.Add(New ClassFilter(strName, strDesc))
            End If
            i = i + 1
        End While

        With TableFields
            .DisplayMember = "getDesc"
            .ValueMember = "getId"
            .DataSource = VDP_Fields
        End With
    End Sub

    Private Sub Add_Comparison()
        On Error Resume Next
        Comparison.Items.Clear()
        VDP_Comparison.Clear()

        VDP_Comparison.Add(New ClassFilter("=", "Equal to"))
        VDP_Comparison.Add(New ClassFilter(">", "Greater than"))
        VDP_Comparison.Add(New ClassFilter("<", "Less than"))
        VDP_Comparison.Add(New ClassFilter("<>", "Not Equal to"))
        VDP_Comparison.Add(New ClassFilter(">=", "Greater than or Equal"))
        VDP_Comparison.Add(New ClassFilter("<=", "Less than or Equal"))

        VDP_Comparison.Add(New ClassFilter("Contains", "Contains"))
        VDP_Comparison.Add(New ClassFilter("Starts", "Starts with"))
        VDP_Comparison.Add(New ClassFilter("Ends", "Ends with"))

        With Comparison
            .DisplayMember = "getDesc"
            .ValueMember = "getId"
            .DataSource = VDP_Comparison
        End With
    End Sub

    Private Sub Add_Conjunction()
        Conjunction.Items.Clear()
        VDP_Conjunction.Clear()
        VDP_Conjunction.Add(New ClassFilter("And", "And"))
        VDP_Conjunction.Add(New ClassFilter("Or", "Or"))

        With Conjunction
            .DisplayMember = "getDesc"
            .ValueMember = "getId"
            .DataSource = VDP_Conjunction
        End With
    End Sub

    Private Function Check_Filter_List()
        Dim i As Integer
        For i = 0 To DGVFilterField.NewRowIndex - 1
            If DGVFilterField(0, i).Value = Nothing Or
                    DGVFilterField(1, i).Value = Nothing Or
                    DGVFilterField(2, i).Value = Nothing Or
                    DGVFilterField(3, i).Value = Nothing Then
                LabelError.Text = "Filter List is Incomplete"
                Return 0
            End If
        Next
        Return 1
    End Function

End Class