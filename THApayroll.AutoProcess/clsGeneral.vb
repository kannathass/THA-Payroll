Imports System
Imports System.IO
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Configuration

Public Class clsGeneral

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    'Dim MyCommand As New SqlCommand

    Public dr As SqlDataReader

#Region "BiometricDevice"

    Private Sub update_device_status()
        'Dim bconn As Boolean

        'bconn = AxCZKEM1.Connect_Net(CStr(DGVDetails(2, i).Value), CLng(DGVDetails(3, i).Value))
        'If bconn Then
        'Else
        'End If

    End Sub

    Public Sub GetBiometricAttendanceAndUpdate()
        Dim TempDs As New DataSet

        Dim year As Long
        Dim Month As Long
        Dim Day As Long
        Dim Hour As Long
        Dim Minute As Long

        Dim MacId As String
        Dim EnrollNumber As Long
        'Dim emcno As Long
        Dim verifymode As Long
        Dim winoutmode As Long
        Dim dt As New DataTable

        Dim Second As Long
        Dim WorkCode As Long
        dt.Columns.Add("Enrollment_No")
        'dt.Columns.Add("EmpName")
        dt.Columns.Add("Attendance_Date")
        TempDs.Tables.Add(dt)
        TempDs.Tables(0).Clear()
        Dim AxCZKEM1 As Axzkemkeeper.AxCZKEM

        While AxCZKEM1.SSR_GetGeneralLogData(MacId, EnrollNumber, verifymode, winoutmode, year, Month, Day, Hour, Minute, Second, WorkCode) = True
            Dim CheckInDate As New Date(year, Month, Day, Hour, Minute, Second)
            Dim MyRow As DataRow
            MyRow = TempDs.Tables(0).NewRow
            MyRow("Enrollment_No") = EnrollNumber
            MyRow("Attendance_Date") = CheckInDate
            TempDs.Tables(0).Rows.Add(MyRow)
        End While

        con.Open()
        cmd = New SqlCommand("Delete from TempLogDetails_Report", con)
        cmd.ExecuteNonQuery()
        con.Close()

        For i = 0 To TempDs.Tables(0).Rows.Count - 1
            con.Open()
            cmd = New SqlCommand("Select * from  TempLogDetails where MacId='" & MacId & "' and EnrollNo='" & TempDs.Tables(0).Rows(i).Item(0).ToString & "' and Enroll_Date=convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103)", con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                dr.Close()
                con.Close()
            Else
                dr.Close()
                con.Close()
                con.Open()
                cmd = New SqlCommand("insert into TempLogDetails values('" & MacId & "','" & TempDs.Tables(0).Rows(i).Item(0).ToString & "',convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103))", con)
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Next
    End Sub

    'Private Sub ButUpdateAttendance_Click()
    '    Dim Upd_Success As Boolean = False
    '    'datacon = New ConnectSql
    '    con.Open()
    '    cmd = New SqlCommand("Delete from TempLogDetails_Report", con)
    '    cmd.ExecuteNonQuery()
    '    con.Close()

    '    For i = 0 To TempDs.Tables(0).Rows.Count - 1
    '        'datacon = New ConnectSql
    '        con.Open()
    '        cmd = New SqlCommand("Select * from  TempLogDetails where MacId='" & MacId & "' and EnrollNo='" & TempDs.Tables(0).Rows(i).Item(0).ToString & "' and Enroll_Date=convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103)", con)
    '        dr = cmd.ExecuteReader
    '        If dr.Read Then
    '            dr.Close()
    '            con.Close()
    '            Upd_Success = True
    '        Else
    '            dr.Close()
    '            con.Close()
    '            '= New ConnectSql
    '            con.Open()
    '            cmd = New SqlCommand("insert into TempLogDetails values('" & MacId & "','" & TempDs.Tables(0).Rows(i).Item(0).ToString & "',convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103))", con)
    '            cmd.ExecuteNonQuery()
    '            con.Close()
    '            Upd_Success = True
    '        End If
    '    Next
    '    'Application.DoEvents()
    '    'If Upd_Success Then
    '    '    MsgBox("Updated the Attendance to Database Successfully")
    '    '    Dim TempDsAtt As New DataSet
    '    '    DGVAttendance.DataSource = TempDsAtt
    '    'End If
    'End Sub

#End Region
#Region "Email"
    Public Sub SendEmail()
        Dim body As String = Me.PopulateBody("John",
            "Fetch multiple values as Key Value pair in ASP.Net AJAX AutoCompleteExtender",
            "http://www.aspsnippets.com/Articles/Fetch-multiple-values-as-Key-Value" &
            "-pair-in-ASP.Net-AJAX-AutoCompleteExtender.aspx",
            ("Here Mudassar Ahmed Khan has explained how to fetch multiple column values i.e. ID and Text values in" &
            " the ASP.Net AJAX Control Toolkit AutocompleteExtender" &
            "and also how to fetch the select text and value server side on postback"))
        Me.SendHtmlFormattedEmail("recipient@example.com", "New article published!", body)
    End Sub

    Private Function PopulateBody(ByVal userName As String, ByVal title As String, ByVal url As String, ByVal description As String) As String
        Dim body As String = String.Empty
        Dim path As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "EmailTemplates\AttendanceList.html")
        'Dim reader As StreamReader = New StreamReader(Server.MapPath("~/EmailTemplates/AttendanceList.html"))
        Dim reader As StreamReader = New StreamReader(path)
        body = reader.ReadToEnd
        body = body.Replace("{UserName}", userName)
        body = body.Replace("{Title}", title)
        body = body.Replace("{Url}", url)
        body = body.Replace("{Description}", description)
        Return body
    End Function

    Private Sub SendHtmlFormattedEmail(ByVal recepientEmail As String, ByVal subject As String, ByVal body As String)
        Dim mailMessage As MailMessage = New MailMessage
        mailMessage.From = New MailAddress(ConfigurationManager.AppSettings("UserName"))
        mailMessage.Subject = subject
        mailMessage.Body = body
        mailMessage.IsBodyHtml = True
        mailMessage.To.Add(New MailAddress(recepientEmail))
        Dim smtp As SmtpClient = New SmtpClient
        smtp.Host = ConfigurationManager.AppSettings("Host")
        smtp.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings("EnableSsl"))
        Dim NetworkCred As System.Net.NetworkCredential = New System.Net.NetworkCredential
        NetworkCred.UserName = ConfigurationManager.AppSettings("UserName")
        NetworkCred.Password = ConfigurationManager.AppSettings("Password")
        smtp.UseDefaultCredentials = True
        smtp.Credentials = NetworkCred
        smtp.Port = Integer.Parse(ConfigurationManager.AppSettings("Port"))
        smtp.Send(mailMessage)
    End Sub
#End Region


    'Accessed from Windows job schduler
    Public Sub FunProcessBiometricAttendance()
        Try
            ConnectSql()
            con.Open()
            cmd.Connection = con
            cmd.CommandType = CommandType.StoredProcedure
            cmd.CommandText = "processingbiometricattendance"
            cmd.CommandTimeout = 0
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            'Err.Raise(Err.Number, , Err.Description)
            WriteToFile(Err.Description)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub WriteToFile(text As String)
        Dim path As String = "D:\THAlogFiles\ProcessedBiometricAttendance_Log.txt"
        Using writer As New StreamWriter(path, True)
            'writer.WriteLine(String.Format(text, DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")))
            writer.WriteLine($"{DateTime.Now.ToString("dd/MM/yyyy hh: mm : ss tt")} - {text}")
            writer.Close()
        End Using
    End Sub

    Private Sub ConnectSql()
        'Dim objIniFile As New IniFile(Application.StartupPath & "\Connection.ini")
        'Dim ISec As String
        Dim constring As String
        Dim ServerName As String
        Dim DBName As String
        Dim UID As String
        Dim PWD As String

        'ServerName = objIniFile.GetString("Connection_String", "ServerName", "(none)")
        'DBName = objIniFile.GetString("Connection_String", "DatabaseName", "(none)")
        'ISec = objIniFile.GetString("Connection_String", "IntegratedSecurity", "(none)")
        'If ISec = "True" Then
        '    constring = "Data Source=" & ServerName & ";Initial Catalog=" & DBName & ";Integrated Security=true;Connection Timeout=45000;"
        'Else
        '    UID = objIniFile.GetString("Connection_String", "UserID", "(none)")
        '    PWD = objIniFile.GetString("Connection_String", "Password", "(none)")
        '    constring = "Data Source=" & ServerName & ";Initial Catalog=" & DBName & ";uid=" & UID & ";pwd=" & PWD & ";Connection Timeout=45000;"
        'End If
        ServerName = "YOUR_SQL_SERVER"
        DBName = "CBpayroll_v1"
        UID = "YOUR_USER"
        PWD = "YOUR_PASSWORD"

        constring = "Data Source=" & ServerName & ";Initial Catalog=" & DBName & ";uid=" & UID & ";pwd=" & PWD & ";Connection Timeout=45000;"

        con.ConnectionString = constring
    End Sub

End Class
