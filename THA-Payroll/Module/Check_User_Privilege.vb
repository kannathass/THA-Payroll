Public Class Check_User_Privilege

    Dim objIniFile As New IniFile(Application.StartupPath & "\Privilege.ini")
    Dim strName As String
    Public Function HasPrivilege(ByVal Privilege As String, ByVal FrmName As String)
        Dim i As Integer
        strName = "Hai"
        i = 1
        While strName <> "(none)"
            strName = objIniFile.GetString(Privilege, "Form" & i, "(none)")
            If strName = FrmName Then
                Return 1
            End If
            i = i + 1
        End While

        Return 0
    End Function
End Class
