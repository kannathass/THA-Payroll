Imports System.Data.SqlClient
Imports System.IO

Public Class ConnectSql

    Public con As New SqlConnection
    'Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public dr As SqlDataReader
    Dim objIniFile As New IniFile(Application.StartupPath & "\Connection.ini")
    Dim ServerName As String
    Dim DBName As String
    Dim UID As String
    Dim PWD As String

    Public Sub New()
        Dim ISec As String
        Dim constring As String

        ServerName = objIniFile.GetString("Connection_String", "ServerName", "(none)")
        DBName = objIniFile.GetString("Connection_String", "DatabaseName", "(none)")
        ISec = objIniFile.GetString("Connection_String", "IntegratedSecurity", "(none)")
        If ISec = "True" Then
            constring = "Data Source=" & ServerName & ";Initial Catalog=" & DBName & ";Integrated Security=true;Connection Timeout=45000;"
        Else
            UID = objIniFile.GetString("Connection_String", "UserID", "(none)")
            PWD = objIniFile.GetString("Connection_String", "Password", "(none)")
            constring = "Data Source=" & ServerName & ";Initial Catalog=" & DBName & ";uid=" & UID & ";pwd=" & PWD & ";Connection Timeout=45000;"
        End If
        con.ConnectionString = constring
    End Sub


End Class
