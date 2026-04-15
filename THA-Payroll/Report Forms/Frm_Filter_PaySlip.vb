Imports System.Data.SqlClient

Public Class Frm_Filter_PaySlip

    Dim datacon As New ConnectSql
    Dim MyCommand As New SqlCommand
    Dim DSEmp As DataSet

    Dim MyClassPayroll As New clsPayroll
    Dim VDP_Fields As New ArrayList
    Dim VDP_Comparison As New ArrayList
    Dim VDP_Conjunction As New ArrayList
    Dim objIniFile As New IniFile(Application.StartupPath & "\data.ini")
    Dim strDesc As String
    Dim strName As String
    Public ReportQuery As String
    Dim strField As String
    Dim strCompare As String
    Dim strConjunction As String
    Dim dateQuery As String
    Dim ConcatQuery As String

    Public PayrollMonth As Date


    Private Sub Frm_Filter_PaySlip_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        FunLoadYear()
        Load_Department()
        Load_Category()
        FunFillExistingPayrollOpenCloseSettings()
        Add_Fields()
        Add_Comparison()
        Add_Conjunction()
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

    Private Sub Add_Fields()
        Dim i As Integer
        strName = "Hai"
        i = 1
        VDP_Fields.Clear()
        TableFields.Items.Clear()

        While strName <> "(none)"
            strName = objIniFile.GetString("Pay_Slip", "Field" & i & ".Name", "(none)")
            strDesc = objIniFile.GetString("Pay_Slip", "Field" & i & ".Desc", "(none)")
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
        'VDP_Comparison.Add(New ClassFilter(">", "Greater than"))
        'VDP_Comparison.Add(New ClassFilter("<", "Less than"))
        VDP_Comparison.Add(New ClassFilter("<>", "Not Equal to"))
        'VDP_Comparison.Add(New ClassFilter(">=", "Greater than or Equal"))
        'VDP_Comparison.Add(New ClassFilter("<=", "Less than or Equal"))
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

    Private Sub ButGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGenerate.Click
        Dim valid_list As Boolean
        valid_list = Check_Filter_List() And Check_Grid_List()
        LabelError.Visible = False
        If valid_list = True Then
            'Generate_Query()
            'ReportPage.FrmName = "Pay_Slip"
            Filter_Query()

            BindMonthlyPayslipDetail()

            ReportPage.FrmName = "Monthly_Pay_Slip"
            ReportQuery = ConcatQuery

            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Public Sub BindMonthlyPayslipDetail()
        Try
            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "Report_SP_Payslip_Monthly"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            MyCommand.Parameters.AddWithValue("@PayrollMonth", MonthlyPayrollDate)
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

    Private Function Check_Filter_List()

        If CheckedListBoxDepartment.CheckedItems.Count = 0 Then
            LabelError.Text = "Department is not selected"
            Return 0
        End If

        If CheckedListBoxCategory.CheckedItems.Count = 0 Then
            LabelError.Text = "Category is not selected"
            Return 0
        End If
        Return 1
    End Function
    Private Function Check_Grid_List()
        Dim i As Integer

        For i = 0 To DGVFilterField.NewRowIndex - 1

            If i <> DGVFilterField.NewRowIndex - 1 Then
                If DGVFilterField(0, i).Value = Nothing Or
                     DGVFilterField(1, i).Value = Nothing Or
                     DGVFilterField(2, i).Value = Nothing Or
                     DGVFilterField(3, i).Value = Nothing Then
                    LabelError.Text = "Filter List is Incomplete"
                    Return 0
                End If
            Else
                If DGVFilterField(0, i).Value = Nothing Or
                     DGVFilterField(1, i).Value = Nothing Or
                     DGVFilterField(2, i).Value = Nothing Then
                    LabelError.Text = "Filter List is Incomplete"
                    Return 0
                End If
            End If
        Next
        Return 1
    End Function

    Private Sub Generate_Query()
        Dim Month1 As String
        Dim Year1 As String
        Month1 = Trim(cmbMonth.Text)
        Year1 = Trim(cmbYear.Text)
        Select Case Month1
            Case "January"
                Month1 = "1"
            Case "February"
                Month1 = "2"
            Case "March"
                Month1 = "3"
            Case "April"
                Month1 = "4"
            Case "May"
                Month1 = "5"
            Case "June"
                Month1 = "6"
            Case "July"
                Month1 = "7"
            Case "August"
                Month1 = "8"
            Case "September"
                Month1 = "9"
            Case "October"
                Month1 = "10"
            Case "November"
                Month1 = "11"
            Case "December"
                Month1 = "12"
                'Case Else
                '    Month1
        End Select
        dateQuery = " ({Report_PayrollMonthlyConsolidated.PayrollMonth}=Date('" & Trim(cmbYear.Text) & "-" & Month1 & "-01'))"

        'dateQuery = " ({Report_PayrollMonthlyConsolidated.PayrollMonth}=Date('" & Trim(cmbYear.Text) & "-" & Month1 & "-01'))"
        'dateQuery = "({Report_AttendanceMonthlyConsolidated.PayrollMonth}= Date('" & Trim(cmbYear.Text) & "-" & Month1 & "-01'))"

        'dateQuery = " ( {tblPaySlip.Del_Status}='0' ) and ({tblPaySlip.SalaryMonth}=('" & Month1 & " , " & Year1 & "')) and "

        Filter_Query()
        ReportQuery = ConcatQuery & dateQuery
    End Sub

    Private Sub Filter_Query()
        'Dim IsString As Integer
        Dim tempstr As String
        Dim StrValue As String
        Dim i As Integer

        ConcatQuery = ""

        For i = 0 To DGVFilterField.NewRowIndex - 1

            StrValue = Chr(39) & Trim(DGVFilterField(2, i).Value) & Chr(39)
            If i <> DGVFilterField.NewRowIndex - 1 Then
                strConjunction = " " + Trim(DGVFilterField(3, i).Value) + " "
            Else
                strConjunction = ""
            End If
            Select Case DGVFilterField(1, i).Value
                Case "Contains"
                    'If IsString = 1 Then
                    strField = "Instr({" & Trim(DGVFilterField(0, i).Value) & "}," & StrValue & ")>=1 " & strConjunction
                    'End If
                Case "Starts"
                    'If IsString = 1 Then
                    strField = "Mid({" & Trim(DGVFilterField(0, i).Value) & "},1,1)=" & StrValue & strConjunction
                    'End If
                Case "Ends"
                    'If IsString = 1 Then
                    tempstr = "Len ({" & Trim(DGVFilterField(0, i).Value) & "})"
                    strField = "Mid ({" & Trim(DGVFilterField(0, i).Value) & "}," & tempstr & ",1)=" & StrValue & strConjunction
                    'End If
                Case "="
                    strField = " ({" & Trim(DGVFilterField(0, i).Value) & "} " & Trim(DGVFilterField(1, i).Value) & StrValue & " )" & strConjunction
                Case Else
                    'If IsString = 0 Then
                    strField = " ({" & Trim(DGVFilterField(0, i).Value) & "} " & Trim(DGVFilterField(1, i).Value) & StrValue & " )" & strConjunction
                    'End If
            End Select
            ConcatQuery = ConcatQuery & strField
        Next
    End Sub


    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub DGVFilterField_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterField.CellEnter
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.PaleGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.DarkGreen

    End Sub

    Private Sub DGVFilterField_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterField.CellLeave
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.DarkOliveGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.White

    End Sub

    Private Sub ButGenerateConsolidatedPaySlip_Click(sender As Object, e As EventArgs) Handles ButGenerateConsolidatedPaySlip.Click
        Dim valid_list As Boolean
        valid_list = Check_Filter_List() And Check_Grid_List()
        LabelError.Visible = False
        If valid_list = True Then
            'Generate_Query()
            'ReportPage.FrmName = "Pay_Slip"
            BindMonthlyPayslip_Consolidated_Detail()
            ReportPage.FrmName = "Monthly_Pay_Slip_Consolidated"
            PayrollMonth = Convert.ToDateTime(Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text))

            'ReportQuery = dateQuery
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButConsolidatedOTReport_Click(sender As Object, e As EventArgs) Handles ButConsolidatedOTReport.Click
        Dim valid_list As Boolean
        valid_list = Check_Filter_List() And Check_Grid_List()
        LabelError.Visible = False
        If valid_list = True Then
            BindMonthlyOT_Consolidated_Detail()
            ReportPage.FrmName = "Monthly_OT_Consolidated"
            PayrollMonth = Convert.ToDateTime(Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text))

            'ReportQuery = dateQuery
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButOTReport_Click(sender As Object, e As EventArgs) Handles ButOTReport.Click
        Dim valid_list As Boolean
        valid_list = Check_Filter_List() And Check_Grid_List()
        LabelError.Visible = False
        If valid_list = True Then

            Filter_Query()

            BindMonthlyOT_Detail()

            ReportPage.FrmName = "Monthly_OT_Detail"
            ReportQuery = ConcatQuery

            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Public Sub BindMonthlyOT_Detail()
        Try
            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "Report_SP_OT_Monthly"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            MyCommand.Parameters.AddWithValue("@PayrollMonth", MonthlyPayrollDate)
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

    Public Sub BindMonthlyOT_Consolidated_Detail()
        Try
            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "Report_SP_OTMonthlyConsolidated"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            MyCommand.Parameters.AddWithValue("@PayrollMonth", MonthlyPayrollDate)
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

    Public Sub BindMonthlyPayslip_Consolidated_Detail()
        Try
            datacon.con.Open()
            MyCommand.Connection = datacon.con
            MyCommand.CommandType = CommandType.StoredProcedure
            MyCommand.CommandText = "Report_SP_PayslipMonthlyConsolidated"
            MyCommand.CommandTimeout = 0
            MyCommand.Parameters.Clear()
            Dim MonthlyPayrollDate As String = Trim(cmbMonth.Text) & "," & Trim(cmbYear.Text)
            MyCommand.Parameters.AddWithValue("@PayrollMonth", MonthlyPayrollDate)
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

        'Return strDepartments.TrimStart("|")
        Return strDepartments
    End Function

    Function getSelectedCategory() As String
        Dim strCategorys As String = ""

        If CheckedListBoxCategory.CheckedItems.Count > 0 Then
            For i As Integer = 0 To CheckedListBoxCategory.CheckedItems.Count - 1
                strCategorys = strCategorys + "|" + CheckedListBoxCategory.CheckedItems(i)
            Next
        End If

        'Return strCategorys.TrimStart("|")
        Return strCategorys
    End Function

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

End Class