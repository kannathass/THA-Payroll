Imports System.Data
Imports System.Data.SqlClient
Public Class frm_LateComers
    Dim DateQuery, strPaymentBasisQuery As String
    Public ReportQuery As String
    Dim datacon As New ConnectSql
    Dim department As String

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

    Private Sub ButLateAttendance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButLateAttendance.Click
        Dim Dt1 As DateTime
        Dt1 = CDate(DtPayroll.Value)
        FunFillPaymentBasisQuery()
        DateQuery = " ( {tempLogDetails_Report.Enroll_Date}= Date('" & Dt1.ToShortDateString & "') and ( time({tempLogDetails_Report.Enroll_Timings}) > time('" & DtTime.Value & "'))" & department
        ReportQuery = DateQuery & strPaymentBasisQuery
        ReportPage.FrmName = "LateAttendance"
        ReportPage.Show()
    End Sub

    Private Sub frm_LateComers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_to_Department()
        cbPaymentBasis.SelectedIndex = 0
    End Sub

    Private Sub Add_to_Department()
        CmbDepartment.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        CmbDepartment.Items.Add("All")
        While datacon.dr.Read
            CmbDepartment.Items.Add(datacon.dr.GetValue(0))
        End While
        datacon.dr.Close()
        datacon.con.Close()
        CmbDepartment.SelectedItem = "All"
        department = "  )"
    End Sub

    Private Sub CmbDepartment_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbDepartment.SelectedIndexChanged
        department = CmbDepartment.SelectedItem
        If department = "All" Then
            department = "  )"
        Else
            department = "and ({tblEmployeePersonnalInfo.Department}='" & department & "') )"
        End If
    End Sub
End Class