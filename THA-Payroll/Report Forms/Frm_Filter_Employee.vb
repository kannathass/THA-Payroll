Imports System.Globalization

Public Class Frm_Filter_Employee
    Dim datacon As New ConnectSql
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
    Dim strPaymentBasisQuery As String

    Private Sub Frm_Filter_Employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Add_Fields()
        Add_Comparison()
        Add_Conjunction()
        cbPaymentBasis.SelectedIndex = 0
        cbEmployeeStatus.SelectedIndex = 0
    End Sub

    Private Sub Add_Fields()
        Dim i As Integer
        strName = "Hai"
        i = 1
        VDP_Fields.Clear()
        TableFields.Items.Clear()

        While strName <> "(none)"
            strName = objIniFile.GetString("Employee_Details", "Field" & i & ".Name", "(none)")
            strDesc = objIniFile.GetString("Employee_Details", "Field" & i & ".Desc", "(none)")
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

    Private Sub ButCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub ButGenerate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButGenerate.Click
        Dim Valid_List As Boolean
        Valid_List = Check_Filter_List()
        LabelError.Visible = False
        If Valid_List = True Then
            FunFillPaymentBasisQuery()
            Generate_Query()
            ReportPage.FrmName = "Employee_Profile"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If

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

    Public Sub FunFillPaymentBasisQuery()
        Try
            strPaymentBasisQuery = String.Empty
            If cbPaymentBasis.Text = "Monthly" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Monthly'"
            ElseIf cbPaymentBasis.Text = "Weekly" Then
                strPaymentBasisQuery = " and {tblEmployeePersonnalInfo.PaymentBasis}='Weekly'"
            End If

            If cbEmployeeStatus.Text = "On Duty" Then
                strPaymentBasisQuery = strPaymentBasisQuery + " and {tblEmployeePersonnalInfo.EmployeeStatus}<>'Resigned'"
            ElseIf cbEmployeeStatus.Text = "Resigned" Then
                strPaymentBasisQuery = strPaymentBasisQuery + " and {tblEmployeePersonnalInfo.EmployeeStatus}='Resigned'"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Generate_Query()
        Dim dt1 As DateTime
        Dim dt2 As DateTime
        dateQuery = String.Empty
        ReportQuery = String.Empty
        'DateTime.ParseExact(txtDate.Text, "M/d/yyyy", CultureInfo.InvariantCulture);
        If Dtfrom.Value > DtTo.Value Then
            dt1 = CDate(DtTo.Value)
            dt2 = CDate(Dtfrom.Value)
        Else
            dt2 = CDate(DtTo.Value)
            dt1 = CDate(Dtfrom.Value)
        End If
        'If Dtfrom.Value > DtTo.Value Then
        '    dt1 = CDate(DtTo.Value)
        '    dt2 = CDate(Dtfrom.Value)
        'Else
        '    dt2 = CDate(DtTo.Value)
        '    dt1 = CDate(Dtfrom.Value)
        'End If
        dateQuery = " ( {tblEmployeePersonnalInfo.Del_Status} = '0' ) "
        If CheckBoxDateFilter.Checked Then
            'If cbEmployeeStatus.Text = "On Duty" Then
            '    dateQuery = dateQuery + " and ({tblEmployeePersonnalInfo.DateOfJoining} in Date('" & Dtfrom.Value & "') to Date('" & DtTo.Value & "'))"
            'ElseIf cbEmployeeStatus.Text = "Resigned" Then
            '    dateQuery = dateQuery + " and ({tblEmployeePersonnalInfo.ResignedDate} in Date('" & Dtfrom.Value & "') to Date('" & DtTo.Value & "'))"
            'Else
            '    dateQuery = dateQuery + " ( and ( ({tblEmployeePersonnalInfo.DateOfJoining} in Date('" & Dtfrom.Value & "') to Date('" & DtTo.Value & "')) or ({tblEmployeePersonnalInfo.ResignedDate} in Date('" & Dtfrom.Value & "') to Date('" & DtTo.val & "')) )"
            'End If
            If cbEmployeeStatus.Text = "On Duty" Then
                dateQuery = dateQuery + " and ({tblEmployeePersonnalInfo.DateOfJoining} in Date('" & dt1.ToString("MM-dd-yyyy") & "') to Date('" & dt2.ToString("MM-dd-yyyy") & "'))"
            ElseIf cbEmployeeStatus.Text = "Resigned" Then
                dateQuery = dateQuery + " and ({tblEmployeePersonnalInfo.ResignedDate} in Date('" & dt1.ToString("MM-dd-yyyy") & "') to Date('" & dt2.ToString("MM-dd-yyyy") & "'))"
            Else
                dateQuery = dateQuery + " ( and ( ({tblEmployeePersonnalInfo.DateOfJoining} in Date('" & dt1.ToString("MM-dd-yyyy") & "') to Date('" & dt2.ToString("MM-dd-yyyy") & "')) or ({tblEmployeePersonnalInfo.ResignedDate} in Date('" & dt1.ToString("MM-dd-yyyy") & "') to Date('" & dt2.ToString("MM-dd-yyyy") & "')) )"
            End If
        End If

        If rbtMale.Checked Then
            dateQuery = dateQuery + " and {tblEmployeeAddInfo.EmpGender} = 'Male' "
        ElseIf rbtFemale.Checked Then
            dateQuery = dateQuery + " and {tblEmployeeAddInfo.EmpGender} = 'Female' "
        End If
        Filter_Query()
        ReportQuery = ConcatQuery & dateQuery & strPaymentBasisQuery
    End Sub

    Private Sub Filter_Query()
        Dim IsString As Integer
        Dim tempstr As String
        Dim StrValue As String
        Dim i As Integer

        ConcatQuery = ""

        For i = 0 To DGVFilterField.NewRowIndex - 1
            Select Case DGVFilterField(0, i).Value
                Case "tblEmployeePersonnalInfo.BasicSalary"
                    StrValue = Trim(DGVFilterField(2, i).Value)
                    IsString = 0
                Case Else
                    StrValue = Chr(39) & Trim(DGVFilterField(2, i).Value) & Chr(39)
                    IsString = 1
            End Select

            strConjunction = " " & Trim(DGVFilterField(3, i).Value) & " "
            Select Case DGVFilterField(1, i).Value
                Case "Contains"
                    If IsString = 1 Then
                        strField = "Instr({" & Trim(DGVFilterField(0, i).Value) & "}," & StrValue & ")>=1" & strConjunction
                    End If
                Case "Starts"
                    If IsString = 1 Then
                        strField = "Mid({" & Trim(DGVFilterField(0, i).Value) & "},1,1)=" & StrValue & strConjunction
                    End If
                Case "Ends"
                    If IsString = 1 Then
                        tempstr = "Len ({" & Trim(DGVFilterField(0, i).Value) & "})"
                        strField = "Mid({" & Trim(DGVFilterField(0, i).Value) & "}," & tempstr & "-1,1)=" & StrValue & strConjunction
                    End If
                Case "="
                    strField = " ({" & Trim(DGVFilterField(0, i).Value) & "} " & Trim(DGVFilterField(1, i).Value) & StrValue & " )" & strConjunction
                Case Else
                    If IsString = 0 Then
                        strField = " ({" & Trim(DGVFilterField(0, i).Value) & "} " & Trim(DGVFilterField(1, i).Value) & StrValue & " )" & strConjunction
                    End If
            End Select

            ConcatQuery = ConcatQuery & strField
        Next


    End Sub

    Private Sub ButSummary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSummary.Click
        Dim Valid_List As Boolean
        Valid_List = Check_Filter_List()
        LabelError.Visible = False
        If Valid_List = True Then
            FunFillPaymentBasisQuery()
            Generate_Query()
            ReportPage.FrmName = "Employee_Summary"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub DGVFilterField_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterField.CellEnter
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.PaleGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.DarkGreen
    End Sub

    Private Sub DGVFilterField_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVFilterField.CellLeave
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Drawing.Color.DarkOliveGreen
        DGVFilterField(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Drawing.Color.White
    End Sub
End Class