Public Class Frm_Filter_Attendance
    Dim datacon As New ConnectSql
    Dim VDP_Fields As New ArrayList
    Dim VDP_Comparison As New ArrayList
    Dim VDP_Conjunction As New ArrayList
    Dim objIniFile As New IniFile(Application.StartupPath & "\data.ini")
    Dim strDesc As String
    Dim strName As String
    Public ReportQuery, FromDate, ToDate As String
    Dim strField As String
    Dim strCompare As String
    Dim strConjunction As String
    Dim dateQuery As String
    Dim ConcatQuery As String
    Dim MyClassPayroll As New clsPayroll

    Private Sub Frm_Filter_Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Add_Fields()
        Add_Comparison()
        Add_Conjunction()
        'DtFrom.SelectedIndex = 0
    End Sub

    Private Sub ButGenerate_Click(sender As Object, e As EventArgs) Handles ButGenerate.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtTo.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Attenance()

            'FunFillPaymentBasisParameter()

            ReportQuery = ConcatQuery + " 0=0 "
            FromDate = DtFrom.Value.Date
            ToDate = DtTo.Value.Date
            ReportPage.FrmName = "AttendanceActual"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If

    End Sub

    Private Sub ButProcessedAttendance_Click(sender As Object, e As EventArgs) Handles ButProcessedAttendance.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtTo.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Attenance()

            ReportQuery = ConcatQuery + " 0=0 "
            FromDate = DtFrom.Value.Date
            ToDate = DtTo.Value.Date
            ReportPage.FrmName = "AttendanceProcessed"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButVerificationReport_Click(sender As Object, e As EventArgs) Handles ButVerificationReport.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtTo.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Attenance()

            ReportQuery = ConcatQuery + " 0=0 "
            FromDate = DtFrom.Value.Date
            ToDate = DtTo.Value.Date
            ReportPage.FrmName = "AttendanceVerification"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButProcessedMonthly_Click(sender As Object, e As EventArgs) Handles ButProcessedMonthly.Click
        Dim valid_list As Boolean
        Dim dtp1 As New Date
        dtp1 = DtTo.Value.Date

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Attenance()

            ReportQuery = ConcatQuery + " 0=0 "
            FromDate = DtFrom.Value.Date
            ToDate = DtTo.Value.Date
            ReportPage.FrmName = "AttendanceProcessedMonthly"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub

    Private Sub ButOTDetail_Click(sender As Object, e As EventArgs) Handles ButOTDetail.Click
        Dim valid_list As Boolean

        valid_list = Check_Filter_List()
        LabelError.Visible = False
        If valid_list = True Then
            Filter_Query_Attenance()

            ReportQuery = ConcatQuery + " 0=0 "
            FromDate = DtFrom.Value.Date
            ToDate = DtTo.Value.Date
            MyClassPayroll.FunGetOTDetail(FromDate, ToDate)

            ReportPage.FrmName = "GetOTDetail"
            ReportPage.Show()
        Else
            LabelError.Visible = True
        End If
    End Sub


    Private Sub ButCancel_Click(sender As Object, e As EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub Add_Fields()
        Dim i As Integer
        strName = ""
        i = 1
        VDP_Fields.Clear()
        TableFields.Items.Clear()

        While strName <> "(none)"
            strName = objIniFile.GetString("Attendance_Actual", "Field" & i & ".Name", "(none)")
            strDesc = objIniFile.GetString("Attendance_Actual", "Field" & i & ".Desc", "(none)")
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

    Private Sub Filter_Query_Attenance()
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
            ElseIf fieldname.Contains("Category") Then
                fieldstr = "command.Category"
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

End Class
