Imports System.Data.SqlClient

Public Class Frm_Filter_DailyPayroll
    Dim datacon As New ConnectSql
    Dim VDP_Fields As New ArrayList
    Dim VDP_Comparison As New ArrayList
    Dim VDP_Conjunction As New ArrayList
    Dim objIniFile As New IniFile(Application.StartupPath & "\data.ini")
    Dim strDesc As String
    Dim strName As String
    Public ReportQuery, ReportDate, strRptDailyAbsentiesParam2, strPaymentBasisQuery As String
    Dim strField As String
    Dim strCompare As String
    Dim strConjunction As String
    Dim dateQuery As String
    Dim ConcatQuery As String

    Private Sub Frm_Filter_DailyPayroll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Add_Fields()
        Add_Comparison()
        Add_Conjunction()
        cbPaymentBasis.SelectedIndex = 0
    End Sub

    Private Sub Add_Fields()
        Dim i As Integer
        strName = "Hai"
        i = 1
        VDP_Fields.Clear()
        TableFields.Items.Clear()

        While strName <> "(none)"
            strName = objIniFile.GetString("Daily_Payroll", "Field" & i & ".Name", "(none)")
            strDesc = objIniFile.GetString("Daily_Payroll", "Field" & i & ".Desc", "(none)")
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
        'VDP_Comparison.Add(New ClassFilter("<>", "Not Equal to"))
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
        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Generate_Query()
            ReportPage.FrmName = "DailyPayroll"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If

    End Sub

    Private Function Check_Filter_List()
        Dim i As Integer
        For i = 0 To DGVFilterFields.NewRowIndex - 1
            If DGVFilterFields(0, i).Value = Nothing Or
                     DGVFilterFields(1, i).Value = Nothing Or
                     DGVFilterFields(2, i).Value = Nothing Or
                     DGVFilterFields(3, i).Value = Nothing Then
                LabelError.Text = "Filter List is Incomplete"
                Return 0
            End If
        Next

        Return 1
    End Function

    Private Sub Generate_Query()
        Dim Dt1 As DateTime
        Dt1 = CDate(DtPayroll.Value)
        dateQuery = " ( {tblEmployeeDailyPayroll.Del_Status}='0' ) and ({tblEmployeeDailyPayroll.DailyPayrollDate}=Date('" & Dt1.ToShortDateString & "'))"
        Filter_Query()
        ReportQuery = ConcatQuery & dateQuery
    End Sub

    Private Sub Filter_Query()
        'Dim IsString As Integer
        Dim tempstr As String
        Dim StrValue As String
        Dim i As Integer

        ConcatQuery = ""

        For i = 0 To DGVFilterFields.NewRowIndex - 1

            StrValue = Chr(39) & Trim(DGVFilterFields(2, i).Value) & Chr(39)
            strConjunction = " " + Trim(DGVFilterFields(3, i).Value) + " "
            Select Case DGVFilterFields(1, i).Value
                Case "Contains"
                    strField = "Instr({" & Trim(DGVFilterFields(0, i).Value) & "}," & StrValue & ")>=1 " & strConjunction
                Case "Starts"
                    strField = "Mid({" & Trim(DGVFilterFields(0, i).Value) & "},1,1)=" & StrValue & strConjunction
                Case "Ends"
                    tempstr = "Len ({" & Trim(DGVFilterFields(0, i).Value) & "})"
                    strField = "Mid ({" & Trim(DGVFilterFields(0, i).Value) & "}," & tempstr & ",1)=" & StrValue & strConjunction
                Case "="
                    strField = " ({" & Trim(DGVFilterFields(0, i).Value) & "} " & Trim(DGVFilterFields(1, i).Value) & StrValue & " )" & strConjunction
                Case Else
                    strField = " ({" & Trim(DGVFilterFields(0, i).Value) & "} " & Trim(DGVFilterFields(1, i).Value) & StrValue & " )" & strConjunction
            End Select
            ConcatQuery = ConcatQuery & strField
        Next
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Public Sub FunFillPaymentBasisParameter()
        Try
            If cbPaymentBasis.Text = "Monthly" Then
                strRptDailyAbsentiesParam2 = "Monthly"
            ElseIf cbPaymentBasis.Text = "Daily" Then
                strRptDailyAbsentiesParam2 = "Daily"
            ElseIf cbPaymentBasis.Text = "Weekly" Then
                strRptDailyAbsentiesParam2 = "Weekly"
            ElseIf cbPaymentBasis.Text = "Contract" Then
                strRptDailyAbsentiesParam2 = "Contract"
            Else
                strRptDailyAbsentiesParam2 = "Monthly"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButGenerateAbsentees_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGenerateAbsentees.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtPayroll.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Absentees()

            FunFillPaymentBasisParameter()

            ReportQuery = ConcatQuery & " 0=0 "
            ''ReportQuery = ConcatQuery
            ReportDate = DtPayroll.Value.Date
            ReportPage.FrmName = "DailyAbsenteesRunning"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If

    End Sub

    Private Sub Filter_Query_Absentees()
        'Dim IsString As Integer
        Dim tempstr As String
        Dim StrValue As String
        Dim fieldname As String
        Dim fieldstr As String
        Dim i As Integer

        ConcatQuery = ""

        fieldstr = ""
        For i = 0 To DGVFilterFields.NewRowIndex - 1
            fieldname = Trim(DGVFilterFields(0, i).Value)
            If fieldname.Contains("EmployeeCode") Then
                fieldstr = "command.EmployeeCode"
            ElseIf fieldname.Contains("EmployeeName") Then
                fieldstr = "command.EmployeeName"
            ElseIf fieldname.Contains("Department") Then
                fieldstr = "command.Department"
            End If
            If fieldstr <> Nothing Then
                StrValue = Chr(39) & Trim(DGVFilterFields(2, i).Value) & Chr(39)
                strConjunction = " " + Trim(DGVFilterFields(3, i).Value) + " "
                Select Case DGVFilterFields(1, i).Value
                    Case "Contains"
                        strField = "Instr({" & fieldstr & "}," & StrValue & ")>=1 " & strConjunction
                    Case "Starts"
                        strField = "Mid({" & fieldstr & "},1,1)=" & StrValue & strConjunction
                    Case "Ends"
                        tempstr = "Len ({" & fieldstr & "})"
                        strField = "Mid ({" & fieldstr & "}," & tempstr & ",1)=" & StrValue & strConjunction
                    Case "="
                        strField = " ({" & fieldstr & "} " & Trim(DGVFilterFields(1, i).Value) & StrValue & " )" & strConjunction
                    Case Else
                        strField = " ({" & fieldstr & "} " & Trim(DGVFilterFields(1, i).Value) & StrValue & " )" & strConjunction
                End Select
                ConcatQuery = ConcatQuery & strField
            End If
        Next
    End Sub

    Private Sub DGVFilterFields_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterFields.CellEnter
        DGVFilterFields(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.PaleGreen
        DGVFilterFields(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.DarkGreen
    End Sub

    Private Sub butSingleSwipes_Click(sender As Object, e As EventArgs) Handles butSingleSwipes.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtPayroll.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Absentees()

            ReportQuery = ConcatQuery & " 0=0 "
            ReportDate = DtPayroll.Value.Date
            ReportPage.FrmName = "DailySingleEntries"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButRunningEmployees_Click(sender As Object, e As EventArgs) Handles ButRunningEmployees.Click
        Dim MyClassPayroll As New clsPayroll

        Dim valid_list As Boolean

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            MyClassPayroll.FunProcessNightShiftForReport()

            Filter_Query_Absentees()

            ReportQuery = ConcatQuery & " 0=0 "
            ReportDate = DtPayroll.Value.Date
            ReportPage.FrmName = "RunningEmployees"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If

    End Sub

    Private Sub DGVFilterFields_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterFields.CellLeave
        DGVFilterFields(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.DarkOliveGreen
        DGVFilterFields(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.White
    End Sub

    Public Sub FunFillPaymentBasisQuery()
        Try
            If cbPaymentBasis.Text = "Monthly" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Monthly' and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            ElseIf cbPaymentBasis.Text = "Daily" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Daily' and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            ElseIf cbPaymentBasis.Text = "Weekly" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Weekly' and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            ElseIf cbPaymentBasis.Text = "Contract" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Contract' and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            Else
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Monthly' and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Dt1 As DateTime

        'FunFillPaymentBasisQuery()

        Dt1 = CDate(DtPayroll.Value)
        dateQuery = " ( {tempLogDetails_Report.Enroll_Date}= Date('" & Dt1.ToShortDateString & "'))"
        'ReportQuery = dateQuery & strPaymentBasisQuery
        ReportQuery = dateQuery
        ReportPage.FrmName = "Day Report"
        ReportPage.Show()
    End Sub
End Class