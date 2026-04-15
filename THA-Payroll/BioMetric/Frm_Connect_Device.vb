Imports System.Data.SqlClient
Imports System.IO
Imports System.Data.OleDb
Public Class Frm_Connect_Device

    Dim datacon As New ConnectSql
    Dim i As Integer
    Dim str As String
    Dim temp() As String
    Dim valid_fields As Boolean
    Dim bconn As Boolean
    Dim strVersion As String
    Dim DevIP As String
    Dim DevPort As String
    Dim MacId As String
    Dim CommNum As String
    Dim BaudRate As String
    Dim ShowDevice As Boolean = False
    Dim DevConn As Boolean = False
    Dim UserstrRollNo As String
    Dim UserEmpId As String
    Dim UserEnable As Boolean
    Dim UserMacId As String
    Dim UserEmpName As String
    Dim UserEmpPasswd As String
    Dim UserPrivil As String
    Dim ImageFile As String
    Dim TempStrRollNo As String
    Dim CheckIn As Date
    Dim TempDs As New DataSet
    Dim dtview As New DataView
    Dim Tabcount As Integer = -1

    Private Sub ButDeviceCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDeviceCon.Click
        Connect_Disconnect_Device()
    End Sub
    Private Sub Connect_Disconnect_Device()

        Dim TempDsAtt As New DataSet
        DGVAttendance.DataSource = TempDsAtt
        If DevConn = False And RbtNet.Checked = True Then
            valid_fields = validate_fields()
            LabelError.Visible = False
            If valid_fields Then
                DevConn = True
                update_device_status()
            Else
                LabelError.Visible = True
            End If
        ElseIf DevConn = False And RbtComm.Checked = True Then
            valid_fields = Validate_Comm_Fields()
            LabelError.Visible = False
            If valid_fields Then
                DevConn = True
                update_Comm_Device_status()
            Else
                LabelError.Visible = True
            End If
        Else
            DevConn = False
            ButDeviceCon.Text = "Connect &Device"
            AxCZKEM1.Beep(150)
            Application.DoEvents()
            AxCZKEM1.Disconnect()
            Timer1.Enabled = False
            LabelDevice.Visible = False
            For i = 0 To DGVDetails.NewRowIndex - 1
                DGVDetails(4, i).Value = " "
            Next
            Clear_Info()
        End If

    End Sub
    Private Function Validate_Comm_Fields()
        If tbCommNum.Text = Nothing Or IsNumeric(tbCommNum.Text) = False Then
            LabelError.Text = "Comm Number is Empty or Invalid"
            Return 0
        ElseIf tbMacNum.Text = Nothing Or IsNumeric(tbMacNum.Text) = False Then
            LabelError.Text = "Machine Number is Empty or Invalid"
            Return 0
        ElseIf tbBaudRate.Text = Nothing Or IsNumeric(tbBaudRate.Text) = False Then
            LabelError.Text = "Baud Rate is Empty or Invalid"
            Return 0
        End If
        Return 1
    End Function

    Private Sub update_device_status()
        For i = 0 To DGVDetails.NewRowIndex - 1
            If DGVDetails(0, i).Value Then
                Application.DoEvents()
                bconn = AxCZKEM1.Connect_Net(CStr(DGVDetails(2, i).Value), CLng(DGVDetails(3, i).Value))
                If bconn Then
                    DGVDetails(4, i).Value = "Connected Successfully"
                    AxCZKEM1.Beep(150)
                    AxCZKEM1.GetFirmwareVersion(CInt(DGVDetails(0, i).Value), strVersion)
                    DevIP = DGVDetails(2, i).Value
                    DevPort = DGVDetails(3, i).Value
                    MacId = DGVDetails(1, i).Value
                    LabelDevice.Text = "Connected Device ( " & DevIP & " )"
                    Timer1.Enabled = True
                    Timer1.Interval = 750
                    Update_Info()
                    ButDeviceCon.Text = "Disconnect &Device"
                Else
                    DGVDetails(4, i).Value = "Connection Failed"
                    Clear_Info()
                    DevConn = False
                End If
            End If
        Next

    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click

        valid_fields = validate_fields()
        LabelError.Visible = False
        If valid_fields Then
            Add_to_db()
        Else
            LabelError.Visible = True
        End If

    End Sub
    Private Sub Add_to_db()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("delete from FPDevCon", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()

        For i = 0 To DGVDetails.NewRowIndex - 1
            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd = New SqlCommand("insert into FPDevCon values (" & DGVDetails(1, i).Value & ",'" & DGVDetails(2, i).Value & "','" & DGVDetails(3, i).Value & "')", datacon.con)
            datacon.cmd.ExecuteNonQuery()
            datacon.con.Close()
        Next
        MsgBox("Devices Added Successfully")

    End Sub
    Private Function validate_fields()
        If DGVDetails.NewRowIndex = 0 Then
            For i = 0 To 2
                If DGVDetails(i, 0).Value = Nothing Then
                    LabelError.Text = "List is Empty"
                    Return 0
                End If
            Next
        Else
            For i = 0 To DGVDetails.NewRowIndex - 1
                If DGVDetails(1, i).Value = Nothing Or IsNumeric(DGVDetails(1, i).Value) = False Then
                    LabelError.Text = "Device Id is Empty or Invalid"
                    Return 0
                ElseIf DGVDetails(2, i).Value = Nothing Then
                    LabelError.Text = "IP Address is Empty/Invalid"
                    Return 0
                ElseIf DGVDetails(3, i).Value = Nothing Or IsNumeric(DGVDetails(3, i).Value) = False Then
                    LabelError.Text = "Port Number is Empty/Invalid"
                    Return 0
                Else
                    str = DGVDetails(2, i).Value
                    temp = str.Split(".")
                    If temp.Length = 4 Then
                        If IsNumeric(temp(0)) = False Or IsNumeric(temp(1)) = False Or IsNumeric(temp(2)) = False Or IsNumeric(temp(3)) = False Then
                            LabelError.Text = "Invalid IP Address"
                            Return 0
                        End If
                    Else
                        LabelError.Text = "Invalid IP Address"
                        Return 0
                    End If

                End If
            Next
        End If
        Return 1
    End Function

    Private Sub Frm_Connect_Device_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F2 And (tbUserName.Focused Or tbUserEmpNo.Focused) Then ' And rbtNewUser.Checked Then
            Frm_BioPop.Show()
        End If
    End Sub

    Private Sub Frm_Connect_Device_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        CmbUserPrivil.SelectedIndex = 0
        update_grid()
    End Sub
    Private Sub update_grid()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from FPDevCon", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        DGVDetails.Rows.Clear()
        i = 0
        While datacon.dr.Read
            DGVDetails.Rows.Add()
            DGVDetails(0, i).Value = 0
            DGVDetails(1, i).Value = datacon.dr.GetValue(0)
            DGVDetails(2, i).Value = datacon.dr.GetValue(1)
            DGVDetails(3, i).Value = datacon.dr.GetValue(2)
            i = i + 1
        End While
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ShowDevice Then
            LabelDevice.Visible = True
            ShowDevice = False
        Else
            LabelDevice.Visible = False
            ShowDevice = True
        End If

    End Sub
    Private Sub update_Comm_Device_status()
        Application.DoEvents()
        bconn = AxCZKEM1.Connect_Com(CLng(tbCommNum.Text), CLng(tbMacNum.Text), CLng(tbBaudRate.Text))
        If bconn Then
            AxCZKEM1.Beep(150)
            AxCZKEM1.GetFirmwareVersion(CInt(DGVDetails(1, i).Value), strVersion)
            CommNum = tbCommNum.Text
            MacId = tbMacNum.Text
            BaudRate = tbBaudRate.Text
            LabelDevice.Text = "Connected Device ( " & CommNum & " - " & MacId & " )"
            Timer1.Enabled = True
            Timer1.Interval = 750
            Update_Info()
            ButDeviceCon.Text = "Disconnect &Device"
        Else
            Clear_Info()
            DevConn = False
        End If

    End Sub
    Private Sub Update_Info()
        Dim IPAddr As String
        Dim sMac As String
        Dim dwSerialNumber As String
        Dim lpsxProductCode As String

        'Get Device IP Address
        AxCZKEM1.GetDeviceIP(CInt(MacId), IPAddr)
        tbDevIP.Text = IPAddr

        'Get MAC Address
        AxCZKEM1.GetDeviceMAC(CInt(MacId), sMac)
        tbDevMAC.Text = sMac

        'Get Serial Number
        AxCZKEM1.GetSerialNumber(CInt(MacId), dwSerialNumber)
        tbDevSNO.Text = dwSerialNumber

        'Get Product Code
        AxCZKEM1.GetProductCode(CInt(MacId), lpsxProductCode)
        tbDevPdtCode.Text = lpsxProductCode

        Find_Next_User()
    End Sub
    Private Sub Find_Next_User()
        Dim UserIDExist As Boolean = True
        If DevConn = True Then

            Dim EnrollNumber As Long
            Dim BackupNumber As Long
            Dim MachineNumber As Long
            Dim MachinePrivilege As Long
            Dim Enable As Long

            Dim test As Long

            While AxCZKEM1.GetAllUserID(1, EnrollNumber, MachineNumber, BackupNumber, MachinePrivilege, Enable) = True
                test = EnrollNumber
            End While
            'UserstrRollNo = 1
            'While UserIDExist = True
            '    UserIDExist = AxCZKEM1.GetUserInfo(1, CInt(UserstrRollNo), UserEmpName, UserEmpPasswd, UserPrivil, UserEnable)
            '    UserstrRollNo = UserstrRollNo + 1
            'End While
            'tbUserEnrollNo.Text = UserstrRollNo - 1
        Else
            MsgBox("Connect the Device First")
            DevConn = False
        End If

    End Sub

    Private Sub Clear_Info()
        tbDevIP.Text = " "
        tbDevMAC.Text = " "
        tbDevSNO.Text = " "
        tbDevPdtCode.Text = " "
    End Sub

    Private Sub RbtNet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtNet.Click
        If RbtNet.Checked Then
            DGVDetails.Enabled = True
            GrpCommSet.Enabled = False
        Else
            DGVDetails.Enabled = False
            GrpCommSet.Enabled = True
        End If
    End Sub

    Private Sub RbtComm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RbtComm.CheckedChanged
        If RbtComm.Checked Then
            DGVDetails.Enabled = False
            GrpCommSet.Enabled = True
        Else
            DGVDetails.Enabled = True
            GrpCommSet.Enabled = False
        End If
    End Sub

    Private Sub ButRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButRestart.Click
        AxCZKEM1.RestartDevice(CInt(MacId))
        Application.DoEvents()
        Connect_Disconnect_Device()
        Application.DoEvents()
        Connect_Disconnect_Device()
        Update_Info()
        Clear_User_Details()
    End Sub

    Private Sub ButSetMAC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSetMAC.Click
        AxCZKEM1.SetDeviceMAC(CInt(MacId), tbNewDevMAC.Text)
        Application.DoEvents()
    End Sub

    Private Sub ButSetIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSetIP.Click
        If tbNewDevIP.Text <> Nothing Then
            str = tbNewDevIP.Text
            temp = str.Split(".")
            If temp.Length = 4 Then
                If IsNumeric(temp(0)) = True And IsNumeric(temp(1)) = True And IsNumeric(temp(2)) = True And IsNumeric(temp(3)) = True Then
                    AxCZKEM1.SetDeviceIP(CInt(MacId), tbNewDevIP.Text)
                    Application.DoEvents()
                End If
            End If
        End If

    End Sub

    Private Sub AxCZKEM1_OnAttTransaction(ByVal sender As Object, ByVal e As Axzkemkeeper._IZKEMEvents_OnAttTransactionEvent) Handles AxCZKEM1.OnAttTransaction
        'Dim strDate As String
        ' MsgBox(e.enrollNumber & " - " & e.year & "\" & e.month & "\" & e.day & " - " & e.hour & ":" & e.minute & ":" & e.second)
        Display_Recent_Image(e.enrollNumber)
        ' lblEmpId.Text = e.enrollNumber
        'strDate = e.month & "-" & e.day & "-" & e.year & " " & e.hour & ":" & e.minute & ":" & e.second
        Dim CheckInDate As New Date(e.year, e.month, e.day, e.hour, e.minute, e.second)
        'CheckIn = strDate
        lblDateTime.Text = CheckInDate
    End Sub

    Private Sub Display_Recent_Image(ByVal RefEnrollNo As Integer)
        Dim MyData As Byte() = Nothing
        PbxRecentEmployee.ImageLocation = "NoImage.jpg"
        PbxRecentEmployee.Visible = False

        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select e.Emp_Image,e.EmployeeName,f.EmpId from tblEmployeePersonnalInfo e, FPUserDetails f where e.EmployeeCode=f.EmpId and f.EnrollNo='" & RefEnrollNo & "' and f.Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read() Then
            lblEmpName.Text = datacon.dr.GetValue(1)
            lblEmpId.Text = datacon.dr.GetValue(2)
            If IsDBNull(datacon.dr.GetValue(0)) = False Then
                MyData = CType(datacon.dr.GetValue(0), Byte())
                Dim intData As New Integer
                intData = MyData.GetUpperBound(0)
                Dim fs As New FileStream(("Blank1.jpg"), System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
                fs.Write(MyData, 0, intData)
                fs.Close()
                MyData = Nothing
                PbxRecentEmployee.ImageLocation = "Blank1.jpg"
                PbxRecentEmployee.Visible = True
            End If
        Else
            PbxRecentEmployee.ImageLocation = "NoImage.jpg"
            lblEmpName.Text = " "
            PbxRecentEmployee.Visible = False
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub
    Private Sub Add_to_user_Variables()
        UserstrRollNo = Trim(tbUserEnrollNo.Text)
        UserEmpId = Trim(tbUserEmpNo.Text)
        UserMacId = Trim(tbUserMacNo.Text)
        UserEmpName = Trim(tbUserName.Text)
        UserEmpPasswd = Trim(tbUserPwd.Text)
        If RbtUserDisable.Checked Then
            UserEnable = 0
        Else
            UserEnable = 1
        End If
        UserPrivil = CmbUserPrivil.SelectedIndex
    End Sub
    Private Function Validate_User_Details()

        If UserMacId = Nothing Or IsNumeric(UserMacId) = False Then
            LabelError.Text = "Machine Number is Empty/Invalid"
            Return 0
        End If

        If UserstrRollNo = Nothing Or IsNumeric(UserstrRollNo) = False Then
            LabelError.Text = "Enrollment Number is Empty/Invalid"
            Return 0
        End If

        If UserEmpName = Nothing Then
            LabelError.Text = "User Name is Empty"
            Return 0
        End If

        If UserEmpId = Nothing Then
            LabelError.Text = "Employee Id is Empty/Invalid"
            Return 0
        End If

        If UserEmpPasswd = Nothing Then
            LabelError.Text = "User Password is Empty/Invalid"
            Return 0
        End If

        If UserPrivil = "" Then
            LabelError.Text = "User Privilege is not Selected"
            Return 0
        End If

        Return 1

    End Function

    Private Sub Clear_User_Details()
        tbUserEnrollNo.Text = ""
        tbUserEmpNo.Text = " "
        tbUserMacNo.Text = " "
        tbUserName.Text = " "
        tbUserPwd.Text = " "
        Find_Next_User()
        PbxEmpImage.ImageLocation = "NoImage.jpg"
        PbxEmpImage.Visible = False
    End Sub

    Private Sub Update_User_to_Field(ByVal Mode As String)
        On Error Resume Next
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from FPUserDetails where EnrollNo='" & UserstrRollNo & "' and Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read Then
            tbUserMacNo.Text = datacon.dr.GetValue(0)
            tbUserEnrollNo.Text = datacon.dr.GetValue(1)
            tbUserName.Text = datacon.dr.GetValue(2)
            tbUserEmpNo.Text = datacon.dr.GetValue(3)
            UserEmpId = datacon.dr.GetValue(3)
            tbUserPwd.Text = datacon.dr.GetValue(4)
            CmbUserPrivil.SelectedIndex = datacon.dr.GetValue(6)
            rbtUserEnable.Checked = datacon.dr.GetValue(7)
            datacon.dr.Close()
            datacon.con.Close()
            If Mode = "Previous" And UserstrRollNo > 1 Then
                UserstrRollNo -= 1
            ElseIf Mode = "Next" Then
                UserstrRollNo += 1
            End If
        Else
            If Mode = "Previous" Then
                UserstrRollNo += 1
            ElseIf UserstrRollNo > 1 And Mode = "Next" Then
                UserstrRollNo -= 1
            Else
                MsgBox("No Record Found")
            End If
            datacon.dr.Close()
            datacon.con.Close()
            tbUserEnrollNo.Text = ""
            tbUserEmpNo.Text = " "
            tbUserMacNo.Text = " "
            tbUserName.Text = " "
            tbUserPwd.Text = " "
        End If
        Display_Image()

    End Sub
    Private Sub ButAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAddImage.Click
        DlgOpenImage.Filter = "JPEG Image (*.jpg)|*.jpg|GIF Image (*.gif)|*.gif|BMP Image (*.bmp)|*.bmp"
        DlgOpenImage.FilterIndex = 1
        DlgOpenImage.ShowDialog()
        ImageFile = DlgOpenImage.FileName
        If ImageFile <> Nothing Then
            PbxEmpImage.ImageLocation = ImageFile
            PbxEmpImage.Visible = True
        End If

        'Update_Image()
        'Display_Image()

    End Sub
    Private Sub Display_Image()
        Dim MyData As Byte() = Nothing

        PbxEmpImage.ImageLocation = "NoImage.jpg"
        PbxEmpImage.Visible = False

        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Emp_Image from tblEmployeePersonnalInfo where Del_Status='0' and EmployeeCode='" & UserEmpId & "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read() Then
            If IsDBNull(datacon.dr.GetValue(0)) = False Then
                MyData = CType(datacon.dr.GetValue(0), Byte())
                Dim intData As New Integer
                intData = MyData.GetUpperBound(0)
                Dim fs As New FileStream(("Blank.jpg"), System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
                fs.Write(MyData, 0, intData)
                fs.Close()
                MyData = Nothing
                PbxEmpImage.ImageLocation = "Blank.jpg"
                PbxEmpImage.Visible = True
            End If
        Else
            PbxEmpImage.ImageLocation = "NoImage.jpg"
            PbxEmpImage.Visible = False
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub
    Private Sub Update_Image()
        On Error Resume Next
        If ImageFile <> Nothing Then
            Dim fsPicture As FileStream = New FileStream(ImageFile, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read)

            Dim picData() As Byte = New Byte(fsPicture.Length) {}
            fsPicture.Read(picData, 0, System.Convert.ToInt32(fsPicture.Length))
            fsPicture.Close()

            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd = New SqlCommand("Update tblEmployeePersonnalInfo Set Emp_Image=@Emp_Image where EmployeeCode='" & UserEmpId & "'", datacon.con)
            datacon.cmd.Parameters.AddWithValue("@Emp_Image", OleDbType.Binary).Value = picData
            datacon.cmd.ExecuteNonQuery()
            datacon.con.Close()
        End If
    End Sub


    Private Sub ButCreateUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCreateUser.Click

        Dim bCrtUser As Boolean
        ''-----------------------------------------------------------
        'datacon = New ConnectSql
        'datacon.con.Open()
        'datacon.cmd = New SqlCommand("Select  MacId, EnrollNo, EmpName, Password, Privilege, Enabled from FPUserDetails where Del_Status='0' order by CONVERT(int,EnrollNo)", datacon.con)
        'datacon.dr = datacon.cmd.ExecuteReader
        'Dim test As String
        'test = ""
        'While datacon.dr.Read
        '    UserMacId = datacon.dr.GetValue(0)
        '    UserstrRollNo = datacon.dr.GetValue(1)
        '    UserEmpName = datacon.dr.GetValue(2)
        '    UserEmpPasswd = datacon.dr.GetValue(3)
        '    UserPrivil = datacon.dr.GetValue(4)
        '    UserEnable = datacon.dr.GetValue(5)
        '    bCrtUser = AxCZKEM1.SSR_SetUserInfo(CInt(UserMacId), CInt(UserstrRollNo), CStr(UserEmpName), CStr(UserEmpPasswd), CInt(UserPrivil), CBool(UserEnable))
        '    If bCrtUser = False Then
        '        test = test + UserstrRollNo + ", "
        '        'MessageBox.Show(UserstrRollNo)
        '    End If
        'End While
        'MessageBox.Show(test)
        'datacon.dr.Close()
        'datacon.con.Close()

        'End
        ''-----------------------------------------------------------
        Dim flgchk As Boolean
        'Dim FingerData As String

        Dim UserExist As Boolean

        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from FPUserDetails where (EmpId='" & Trim(tbUserEmpNo.Text) & "' or EnrollNo='" & Trim(tbUserEmpNo.Text) & "') and Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read = False Then
            UserExist = False
        Else
            UserExist = True
        End If
        datacon.dr.Close()
        datacon.con.Close()


        If rbtNewUser.Checked = False And TempStrRollNo = Trim(tbUserEnrollNo.Text) Then
            UserExist = False
        End If

        If DevConn = True Then

            'FingerData = "ocoigp66UQAVUrxWgBFJxVWAFF7FW0ANS"
            flgchk = False

            Add_to_user_Variables()

            ' Check the Id Created for the User Already
            valid_fields = Validate_User_Details()
            If valid_fields Then
                LabelError.Visible = False
                If UserExist = False Then
                    ' Create user in the Device
                    Application.DoEvents()
                    bCrtUser = AxCZKEM1.SSR_SetUserInfo(CInt(UserMacId), CInt(UserstrRollNo), CStr(UserEmpName), CStr(UserEmpPasswd), CInt(UserPrivil), CBool(UserEnable))
                    If bCrtUser Then
                        'bCrtUser = AxCZKEM1.SetUserTmpStr(CInt(UserMacId), CInt(UserstrRollNo), 1, FingerData) ' Machine,Id,FingerPrint Number,FingerPrint Template
                        MsgBox("User Created Successfully")

                        'Create User to the Database
                        datacon = New ConnectSql
                        datacon.con.Open()
                        If rbtNewUser.Checked Then
                            datacon.cmd = New SqlCommand("insert into FPUserDetails values('" & UserMacId & "','" & UserstrRollNo & "','" & UserEmpName & "','" & UserEmpId & "','" & UserEmpPasswd & "','" & 1 & "','" & UserPrivil & "','" & Enabled & "',' ','0')", datacon.con)
                        Else
                            'datacon.cmd = New SqlCommand("Update FPUserDetails set MacId='" & UserMacId & "',Password='" & UserEmpPasswd & "',Privilege='" & UserPrivil & "',Enabled='" & Enabled & "' where EnrollNo='" & UserstrRollNo & "'", datacon.con)
                            datacon.cmd = New SqlCommand("Update FPUserDetails set MacId='" & UserMacId & "',Password='" & UserEmpPasswd & "',Privilege='" & UserPrivil & "',Enabled='" & Enabled & "', EmpName='" & UserEmpName & "', EmpId='" & UserEmpId & "' where EnrollNo='" & UserstrRollNo & "'", datacon.con)
                        End If
                        datacon.cmd.ExecuteNonQuery()
                        datacon.con.Close()
                        Update_Image()
                        ImageFile = " "
                        Clear_User_Details()
                    Else
                        MsgBox("User is not created")
                    End If


                Else
                    LabelError.Text = "Enrollment for the User is Already Created"
                    LabelError.Visible = True
                    ImageFile = " "
                End If
            Else
                LabelError.Visible = True
                ImageFile = " "
            End If
        Else
            MsgBox("Connect the Device First")
        End If


    End Sub

    Private Sub ButClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClear.Click
        Clear_User_Details()
    End Sub

    Private Sub ButNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNext.Click
        Clear_User_Details()
        If UserstrRollNo > 1 Then
            ButPrevious.Enabled = True
        End If
        Update_User_to_Field("Next")
    End Sub

    Private Sub ButPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButPrevious.Click
        Clear_User_Details()
        If UserstrRollNo = 1 Then
            ButPrevious.Enabled = False
        End If
        Update_User_to_Field("Previous")
    End Sub


    Private Sub rbtViewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtViewUser.Click
        'Update_User_to_Field("Previous")
        ButPrevious.Enabled = True
        ButNext.Enabled = True
        ButFind.Enabled = True
        tbUserEnrollNo.ReadOnly = False
    End Sub


    Private Sub rbtNewUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtNewUser.Click
        Clear_User_Details()
        ButNext.Enabled = False
        ButPrevious.Enabled = False
        ButFind.Enabled = False
        'tbUserEnrollNo.ReadOnly = True
    End Sub


    Private Sub ButFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButFind.Click
        UserstrRollNo = Trim(tbUserEnrollNo.Text)
        TempStrRollNo = Trim(tbUserEnrollNo.Text)
        Update_User_to_Field("None")
    End Sub

    Private Sub ButClearDevice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClearDevice.Click
        Dim msres As MsgBoxResult
        If DevConn = True Then
            msres = MsgBox("Are you sure to Clear the Device Log ? ", MsgBoxStyle.YesNo, "Confirm Clear")
            If msres = MsgBoxResult.Yes Then
                AxCZKEM1.ClearGLog(CInt(MacId))
                Application.DoEvents()
            End If
            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd = New SqlCommand("Delete from TempLogDetails", datacon.con)
            datacon.cmd.ExecuteNonQuery()
            datacon.con.Close()
        Else
            MsgBox("Connect the Device and Proceed ... ")
        End If
    End Sub

    Private Sub AxCZKEM1_OnDisConnected(ByVal sender As Object, ByVal e As System.EventArgs) Handles AxCZKEM1.OnDisConnected
        Connect_Disconnect_Device()
    End Sub

    Private Sub ButGetAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButGetAttendance.Click
        Dim year As Long
        Dim Month As Long
        Dim Day As Long
        Dim Hour As Long
        Dim Minute As Long
        Dim EnrollNumber As Long
        'Dim emcno As Long
        Dim verifymode As Long
        Dim winoutmode As Long
        Dim dt As New DataTable

        Dim Second As Long
        Dim WorkCode As Long
        dt.Columns.Add("Enrollment_No")
        dt.Columns.Add("EmpName")
        dt.Columns.Add("Attendance_Date")
        TempDs.Tables.Add(dt)
        If DevConn = True Then
            TempDs.Tables(0).Clear()
            i = 0
            'Application.DoEvents()
            'While AxCZKEM1.GetAllGLogData(MacId, MacId, EnrollNumber, emcno, verifymode, winoutmode, year, Month, Day, Hour, Minute) = True
            'While AxCZKEM1.SSR_GetGeneralLogData(machineNumber, out dwEnrollNumber1, out dwVerifyMode, out dwInOutMode, out dwYear, out dwMonth, out dwDay, out dwHour, out dwMinute, out dwSecond, ref dwWorkCode))
            While AxCZKEM1.SSR_GetGeneralLogData(MacId, EnrollNumber, verifymode, winoutmode, year, Month, Day, Hour, Minute, Second, WorkCode) = True
                'CheckIn = Month & "-" & Day & "-" & year & " " & Hour & ":" & Minute
                'CheckIn = Day & "-" & Month & "-" & year & " " & Hour & ":" & Minute
                Dim CheckInDate As New Date(year, Month, Day, Hour, Minute, Second)
                datacon = New ConnectSql
                datacon.con.Open()
                datacon.cmd = New SqlCommand("Select EmpName from  FPUserDetails where EnrollNo='" & EnrollNumber & "' and Del_Status='0'", datacon.con)
                datacon.dr = datacon.cmd.ExecuteReader
                Dim MyRow As DataRow
                MyRow = TempDs.Tables(0).NewRow
                MyRow("Enrollment_No") = EnrollNumber
                If datacon.dr.Read Then
                    MyRow("EmpName") = datacon.dr.GetValue(0)
                Else
                    MyRow("EmpName") = " "
                End If
                MyRow("Attendance_Date") = CheckInDate
                TempDs.Tables(0).Rows.Add(MyRow)
                i = i + 1
                datacon.dr.Close()
                datacon.con.Close()
            End While
        Else
            MsgBox("Connect the Device First")
        End If
        dtview = TempDs.Tables(0).DefaultView
        dtview.Sort = "Enrollment_No,EmpName,Attendance_Date"
        DGVAttendance.DataSource = TempDs.Tables(0).DefaultView
        DGVAttendance.Columns(0).Width = 100
        DGVAttendance.Columns(1).Width = 150
        DGVAttendance.Columns(2).Width = 200
        'Dim checkCol As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        'checkCol.HeaderText = "CheckBox Column"

        'DGVAttendance.Columns.Add(checkCol)

        Tabcount = TempDs.Tables(0).Rows.Count - 1


    End Sub

    Private Sub ButUpdateAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUpdateAttendance.Click
        Dim Upd_Success As Boolean = False
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Delete from TempLogDetails_Report", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()

        For i = 0 To Tabcount
            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd = New SqlCommand("Select * from  TempLogDetails where MacId='" & MacId & "' and EnrollNo='" & TempDs.Tables(0).Rows(i).Item(0).ToString & "' and Enroll_Date=convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103)", datacon.con)
            datacon.dr = datacon.cmd.ExecuteReader
            If datacon.dr.Read Then
                datacon.dr.Close()
                datacon.con.Close()
                Upd_Success = True
            Else
                datacon.dr.Close()
                datacon.con.Close()
                datacon = New ConnectSql
                datacon.con.Open()
                datacon.cmd = New SqlCommand("insert into TempLogDetails values('" & MacId & "','" & TempDs.Tables(0).Rows(i).Item(0).ToString & "',convert(datetime,'" & TempDs.Tables(0).Rows(i).Item(2).ToString & "',103))", datacon.con)
                datacon.cmd.ExecuteNonQuery()
                datacon.con.Close()
                Upd_Success = True
            End If
        Next
        ' order_Attendance()
        Application.DoEvents()
        'Order_Shift_Attendance()
        If Upd_Success Then
            MsgBox("Updated the Attendance to Database Successfully")
            Dim TempDsAtt As New DataSet
            DGVAttendance.DataSource = TempDsAtt
        End If
    End Sub
    'Private Sub order_Attendance()

    '    Dim da As New SqlDataAdapter
    '    Dim datads As New DataSet
    '    Dim CalcDate As New DateTime
    '    Dim MorningWorkStart As New DateTime
    '    Dim MorningWorkEnd As New DateTime
    '    Dim EveningWorkStart As New DateTime
    '    Dim EveningWorkEnd As New DateTime
    '    Dim Enroll, EmployeeId As String
    '    Dim k As Integer
    '    Dim tempDate(1000) As DateTime
    '    Dim FNPresent As Integer
    '    Dim ANPresent As Integer
    '    Dim RecExist As Boolean = False

    '    datacon = New ConnectSql
    '    datacon.con.Open()
    '    da.SelectCommand = New SqlCommand("Select Fp.EmpId,Fp.EnrollNo,Sd.FNCheckIn,Sd.FNCheckOut,Sd.ANCheckIn,Sd.ANCheckOut from  FPUserDetails Fp, tblShiftTimings Sd where Sd.EmployeeCode=Fp.EmpId", datacon.con)
    '    da.Fill(datads, "Emp")
    '    datacon.con.Close()

    '    For i = 0 To datads.Tables(0).Rows.Count - 1

    '        Enroll = datads.Tables(0).Rows(i).Item(1).ToString
    '        EmployeeId = datads.Tables(0).Rows(i).Item(0).ToString
    '        CalcDate = datads.Tables(0).Rows(i).Item(2).ToString
    '        MorningWorkStart = CalcDate.AddHours(-1)
    '        CalcDate = datads.Tables(0).Rows(i).Item(3).ToString
    '        MorningWorkEnd = CalcDate.AddHours(-1)
    '        CalcDate = datads.Tables(0).Rows(i).Item(4).ToString
    '        EveningWorkStart = CalcDate.AddHours(-1)
    '        CalcDate = datads.Tables(0).Rows(i).Item(5).ToString
    '        EveningWorkEnd = CalcDate.AddHours(-1)

    '        datacon = New ConnectSql
    '        datacon.con.Open()
    '        datacon.cmd = New SqlCommand("Select distinct Enroll_Date from TempLogDetails where EnrollNo='" & Enroll & "'", datacon.con)
    '        datacon.dr = datacon.cmd.ExecuteReader
    '        k = 0
    '        While datacon.dr.Read
    '            tempDate(k) = datacon.dr.GetValue(0)
    '            k = k + 1
    '        End While
    '        datacon.dr.Close()
    '        datacon.con.Close()
    '        Dim Arraylen As Integer = k
    '        For k = 0 To Arraylen - 1
    '            CalcDate = tempDate(k)
    '            If CalcDate.Hour >= MorningWorkStart.Hour And CalcDate.Hour <= MorningWorkEnd.Hour Then
    '                FNPresent = 1
    '                ANPresent = 0
    '            ElseIf CalcDate.Hour >= EveningWorkStart.Hour And CalcDate.Hour <= EveningWorkEnd.Hour Then
    '                ANPresent = 1
    '                FNPresent = 0
    '            End If
    '            datacon = New ConnectSql
    '            datacon.con.Open()
    '            datacon.cmd = New SqlCommand("Select * from AttendanceDetails where EnrollNo='" & Enroll & "' and Enroll_Date='" & CalcDate.ToShortDateString & "'", datacon.con)
    '            datacon.dr = datacon.cmd.ExecuteReader
    '            If datacon.dr.Read Then
    '                RecExist = True
    '            Else
    '                RecExist = False
    '            End If
    '            datacon.dr.Close()
    '            datacon.con.Close()

    '            datacon = New ConnectSql
    '            datacon.con.Open()
    '            If RecExist = True Then
    '                If FNPresent = 1 Then
    '                    datacon.cmd = New SqlCommand("update AttendanceDetails set FN=" & FNPresent & ", LastTime='" & CalcDate & "' where EnrollNo='" & Enroll & "' and Enroll_Date='" & CalcDate.ToShortDateString & "'", datacon.con)
    '                Else
    '                    datacon.cmd = New SqlCommand("update AttendanceDetails set AN=" & ANPresent & ", LastTime='" & CalcDate & "' where EnrollNo='" & Enroll & "' and Enroll_Date='" & CalcDate.ToShortDateString & "'", datacon.con)
    '                End If
    '            Else
    '                datacon.cmd = New SqlCommand("insert into AttendanceDetails values('" & Enroll & "','" & EmployeeId & "','" & CalcDate.ToShortDateString & "'," & FNPresent & "," & ANPresent & ",'" & CalcDate & "','" & CalcDate & "')", datacon.con)
    '            End If
    '            datacon.cmd.ExecuteNonQuery()
    '            datacon.con.Close()
    '        Next
    '    Next
    'End Sub
    Private Sub Order_Shift_Attendance()

        Dim i As Integer
        Dim da As New SqlDataAdapter
        Dim datads As New DataSet
        Dim CalcDate As New DateTime
        Dim MorningWorkStart As New DateTime
        Dim MorningWorkEnd As New DateTime
        Dim EveningWorkStart As New DateTime
        Dim EveningWorkEnd As New DateTime
        Dim Enroll, EmployeeId As String
        Dim k As Integer

        Dim FNPresent As Integer
        Dim ANPresent As Integer
        Dim RecExist As Boolean = False
        Dim DayStart As New DateTime
        Dim DayEnd As New DateTime
        Dim NightDayStart As New DateTime
        Dim NightDayEnd As New DateTime
        Dim AttendanceDay As New DateTime
        Dim EmpDepartment As String
        Dim j As Integer

        datacon = New ConnectSql
        datacon.con.Open()
        da.SelectCommand = New SqlCommand("Select Fp.EmpId,Fp.EnrollNo,Sd.FNCheckIn,Sd.FNCheckOut,Sd.ANCheckIn,Sd.ANCheckOut,EMP.Department from  FPUserDetails Fp, tblShiftTimings Sd,tblEmployeePersonnalInfo EMP where EMP.EmployeeCode=Fp.EmpId and Sd.EmployeeCode=Fp.EmpId and Fp.Del_Status='0'", datacon.con)
        da.Fill(datads, "Emp")
        datacon.con.Close()

        For i = 0 To datads.Tables(0).Rows.Count - 1
            Dim tempDate(10000) As DateTime
            Enroll = datads.Tables(0).Rows(i).Item(1).ToString
            EmployeeId = datads.Tables(0).Rows(i).Item(0).ToString
            CalcDate = datads.Tables(0).Rows(i).Item(2).ToString
            MorningWorkStart = CalcDate.AddHours(-1)
            CalcDate = datads.Tables(0).Rows(i).Item(3).ToString
            MorningWorkEnd = CalcDate.AddHours(-1)
            CalcDate = datads.Tables(0).Rows(i).Item(4).ToString
            EveningWorkStart = CalcDate.AddHours(-1)
            CalcDate = datads.Tables(0).Rows(i).Item(5).ToString
            EveningWorkEnd = CalcDate.AddHours(-1)
            EmpDepartment = LCase(datads.Tables(0).Rows(i).Item(6).ToString)

            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd = New SqlCommand("Select distinct Enroll_Date from TempLogDetails where EnrollNo='" & Enroll & "' order by Enroll_Date", datacon.con)
            datacon.dr = datacon.cmd.ExecuteReader
            k = 0
            While datacon.dr.Read
                tempDate(k) = datacon.dr.GetValue(0)
                k = k + 1
            End While
            datacon.dr.Close()
            datacon.con.Close()
            Dim Arraylen As Integer = k
            For k = 0 To Arraylen - 1

                CalcDate = tempDate(k)
                If EmpDepartment.Contains("emb") Then
                    If MorningWorkStart.Hour < 10 Then
                        DayStart = CalcDate.Month & "-" & CalcDate.Day & "-" & CalcDate.Year & " 8:15 AM"
                        DayEnd = DateAdd(DateInterval.Day, 1, DayStart)
                        DayEnd = DayEnd.Month & "-" & DayEnd.Day & "-" & DayEnd.Year & " 8:45 AM"
                    Else
                        DayStart = CalcDate.Month & "-" & CalcDate.Day & "-" & CalcDate.Year & " 9:15 AM"
                        DayEnd = DateAdd(DateInterval.Day, 1, DayStart)
                        DayEnd = DayEnd.Month & "-" & DayEnd.Day & "-" & DayEnd.Year & " 9:45 AM"
                    End If
                ElseIf EmpDepartment.Contains("sec") Then
                    If MorningWorkStart.Hour < 8 Then
                        DayStart = CalcDate.Month & "-" & CalcDate.Day & "-" & CalcDate.Year & " 6:45 AM"
                        DayEnd = DateAdd(DateInterval.Day, 1, DayStart)
                        DayEnd = DayEnd.Month & "-" & DayEnd.Day & "-" & DayEnd.Year & " 7:15 AM"
                    Else
                        DayStart = CalcDate.Month & "-" & CalcDate.Day & "-" & CalcDate.Year & " 7:45 AM"
                        DayEnd = DateAdd(DateInterval.Day, 1, DayStart)
                        DayEnd = DayEnd.Month & "-" & DayEnd.Day & "-" & DayEnd.Year & " 8:15 AM"
                    End If
                Else
                    DayStart = CalcDate.Month & "-" & CalcDate.Day & "-" & CalcDate.Year & " 6:00 AM"
                    DayEnd = DateAdd(DateInterval.Day, 1, DayStart)
                End If
                'DayEnd = CalcDate.Month & "-" & (CalcDate.Day + 1) & "-" & CalcDate.Year & " 6:00 AM"
                'If (DayStart.Day - DayEnd.Day) > 2 Then
                '    If CalcDate.Hour >= DayStart.Hour Then
                '        AttendanceDay = DayStart
                '        'ElseIf DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                '    ElseIf CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                '        AttendanceDay = DateAdd(DateInterval.Day, -1, DayStart)
                '    End If
                'Else
                '    If DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour >= DayStart.Hour Then
                '        'If CalcDate.Hour >= DayStart.Hour Then
                '        AttendanceDay = DayStart
                '    ElseIf DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                '        'ElseIf CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                '        AttendanceDay = DateAdd(DateInterval.Day, -1, DayStart)
                '    End If
                'End If
                'If CalcDate.Hour >= MorningWorkStart.Hour And CalcDate.Hour <= MorningWorkEnd.Hour Then
                '    FNPresent = 1
                '    ANPresent = 0
                'ElseIf CalcDate.Hour >= EveningWorkStart.Hour And CalcDate.Hour <= EveningWorkEnd.Hour Then
                '    ANPresent = 1
                '    FNPresent = 0
                'End If

                If DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour >= DayStart.Hour Then
                    'If CalcDate.Hour >= DayStart.Hour Then
                    AttendanceDay = DayStart
                ElseIf DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                    'ElseIf CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                    AttendanceDay = DateAdd(DateInterval.Day, -1, DayStart)
                ElseIf (DayStart.Day - DayEnd.Day) > 2 Then
                    If CalcDate.Hour >= DayStart.Hour Then
                        AttendanceDay = DayStart
                        'ElseIf DayStart.Day <= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                    ElseIf CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                        AttendanceDay = DateAdd(DateInterval.Day, -1, DayStart)
                    End If
                End If

                If CalcDate.Hour >= MorningWorkStart.Hour And CalcDate.Hour <= MorningWorkEnd.Hour Then
                    FNPresent = 1
                    ANPresent = 0
                ElseIf DayStart.Day >= CalcDate.Day And CalcDate.Day <= DayEnd.Day And CalcDate.Hour <= DayEnd.Hour Then ' And CalcDate.Minute <= DayEnd.Minute Then
                    If CalcDate.Hour >= MorningWorkStart.Hour Then
                        FNPresent = 1
                        ANPresent = 0
                    Else
                        ANPresent = 1
                        FNPresent = 0
                    End If
                ElseIf CalcDate.Hour >= EveningWorkStart.Hour And CalcDate.Hour <= EveningWorkEnd.Hour Then
                    ANPresent = 1
                    FNPresent = 0
                End If

                datacon = New ConnectSql
                datacon.con.Open()
                datacon.cmd = New SqlCommand("Select * from AttendanceDetails where EnrollNo='" & Enroll & "' and Enroll_Date='" & AttendanceDay.ToShortDateString & "'", datacon.con)
                datacon.dr = datacon.cmd.ExecuteReader
                If datacon.dr.Read Then
                    RecExist = True
                Else
                    RecExist = False
                End If
                datacon.dr.Close()
                datacon.con.Close()

                datacon = New ConnectSql
                datacon.con.Open()
                If RecExist = True Then
                    If FNPresent = 1 Then
                        datacon.cmd = New SqlCommand("update AttendanceDetails set FN=" & FNPresent & ", LastTime='" & CalcDate & "' where EnrollNo='" & Enroll & "' and Enroll_Date='" & AttendanceDay.ToShortDateString & "'", datacon.con)
                    Else
                        datacon.cmd = New SqlCommand("update AttendanceDetails set AN=" & ANPresent & ", LastTime='" & CalcDate & "' where EnrollNo='" & Enroll & "' and Enroll_Date='" & AttendanceDay.ToShortDateString & "'", datacon.con)
                    End If
                Else
                    datacon.cmd = New SqlCommand("insert into AttendanceDetails values('" & Enroll & "','" & EmployeeId & "','" & AttendanceDay.ToShortDateString & "'," & FNPresent & "," & ANPresent & ",'" & CalcDate & "','" & CalcDate & "')", datacon.con)
                End If
                datacon.cmd.ExecuteNonQuery()
                datacon.con.Close()

                datacon = New ConnectSql
                datacon.con.Open()
                datacon.cmd = New SqlCommand("insert into TempLogDetails_Report values('1','" & Enroll & "','" & AttendanceDay.ToShortDateString & "','" & CalcDate & "')", datacon.con)
                datacon.cmd.ExecuteNonQuery()
                datacon.con.Close()
            Next
        Next
    End Sub

    Private Sub ButDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Dim vbres As MsgBoxResult
        Dim RemoveSuccess As Boolean
        TempStrRollNo = Trim(tbUserEnrollNo.Text)

        If DevConn = True Then
            vbres = MsgBox("Are you sure to Delete the User ? ", MsgBoxStyle.YesNo, "Delete User")
            If vbres = MsgBoxResult.Yes Then
                datacon = New ConnectSql
                datacon.con.Open()
                datacon.cmd = New SqlCommand("Update FPUserDetails set Del_Status='1' Where EnrollNo='" & TempStrRollNo & "'", datacon.con)
                datacon.cmd.ExecuteNonQuery()
                datacon.con.Close()
                MsgBox("The User Deleted from the Database" & Chr(13) & " Kindly Delete the User from your Device also")
            End If
            Clear_User_Details()
        Else
            MsgBox("Connect the Device and Proceed...")
        End If


    End Sub


    Private Sub DGVDetails_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetails.CellEnter
        On Error Resume Next
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVDetails_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetails.CellLeave
        On Error Resume Next
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVAttendance_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAttendance.CellEnter
        On Error Resume Next
        DGVAttendance(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVAttendance(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen

    End Sub

    Private Sub DGVAttendance_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAttendance.CellLeave
        On Error Resume Next
        DGVAttendance(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVAttendance(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub
End Class