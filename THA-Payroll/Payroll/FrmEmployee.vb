Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Data
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Data.OleDb

Public Class FrmEmployee

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim SelectionMode As Boolean
    Dim ExistingMode As Boolean = False
    Dim iMode As New Integer
    Dim GridValidAlert As Boolean = False
    Dim GridEarningAlert As Boolean = False
    Dim GridDeductionAlert As Boolean = False

    Public EmpCode As String
    Dim datacon As New ConnectSql
    Dim MyCommand As New SqlCommand

    Dim ImagePath As String

    Dim intMinPFSalaryCriteria As Int32
    Dim intMaxPFSalaryCriteria As Int32
    Dim decPFEmployeeContribution As Decimal
    Dim decPFEmployerContribution As Decimal
    Dim decESIEmployeeContribution As Decimal
    Dim decESIEmployerContribution As Decimal

    Dim isFormLoading As Boolean = True
    Dim isGridViewAutoUpdate As Boolean

#End Region

#Region "Function"

    Public Sub FunGetAutoSlipNo()
        Try
            If cmbDptName.Text <> "Select" Then
                Dim IdentCurrent, Count As New Long
                Dim Prefix As String
                DSEmp = MyClassPayroll.FunSelectEmployeeTab(0, "", 8)
                If DSEmp.Tables("selectEmployeeTab").Rows.Count > 0 Then
                    IdentCurrent = DSEmp.Tables("selectEmployeeTab").Rows(0)("IdentCurrent")
                    Count = DSEmp.Tables("selectEmployeeTab").Rows(0)("Counts")
                    If cmbDptName.Text <> Nothing And cmbDptName.Text <> "Select" And cmbDptName.Text.Length >= 3 Then
                        Prefix = cmbDptName.Text.Substring(0, 3)
                    Else
                        Prefix = cmbDptName.Text
                    End If
                    If IdentCurrent = 1 And Count = 0 Then
                        txtEmployeeCode.Text = Prefix & "_" & IdentCurrent
                    ElseIf IdentCurrent = 1 And Count = 1 Then
                        txtEmployeeCode.Text = Prefix & "_" & IdentCurrent + 1
                    Else
                        txtEmployeeCode.Text = Prefix & "_" & IdentCurrent + 1
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub cmbDptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDptName.SelectedIndexChanged
        If ExistingMode = False Then
            FunGetAutoSlipNo()
        End If
    End Sub

    Public Sub FunSaveEmployeePersonnalInfo()
        Try
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 2)
            DStemp.Tables("selectEmployeeTab").Rows.Clear()
            MyRow = DStemp.Tables("selectEmployeeTab").NewRow
            MyRow("SNo") = 0
            MyRow("EmployeeName") = Trim(txtEmployeeName.Text)
            MyRow("Alias") = Trim(txtEmployeeNo.Text)
            MyRow("EmployeeCode") = Trim(txtEmployeeCode.Text)
            MyRow("Designation") = Trim(cmbDesignation.Text)
            'If rbDaily.Checked = True Then
            '    MyRow("PaymentBasis") = "Daily"
            'ElseIf rbContract.Checked = True Then
            '    MyRow("PaymentBasis") = "Contract"
            'Else
            If rbMonthly.Checked = True Then
                MyRow("PaymentBasis") = "Monthly"
            ElseIf rbWeekly.Checked = True Then
                MyRow("PaymentBasis") = "Weekly"
            End If
            MyRow("BasicSalary") = IIf(IsNumeric(txtBasicSalary.Text), txtBasicSalary.Text, 0)
            MyRow("Category") = cmbCategName.Text
            MyRow("Address1") = txtAddress1.Text
            MyRow("Address2") = txtAddress2.Text
            MyRow("Department") = cmbDptName.Text
            MyRow("Nationality") = txtNationality.Text
            MyRow("DateOfJoining") = dtpDOJ.Value
            MyRow("AppraisalDate") = dtpDOB.Value
            MyRow("VisaNo") = txtVisaNo.Text
            MyRow("PassportNo") = txtPassportNo.Text
            MyRow("ContractNo") = txtContractNo.Text
            MyRow("VisaExpiry") = txtVisaExpiry.Text
            MyRow("PassportExpiry") = txtPassportExpiry.Text
            MyRow("IdentityProofNo") = txtContrctExpiry.Text
            'MyRow("PayableAccount") = txtIDCardNo.Text
            MyRow("PayableAccount") = ""
            MyRow("SalaryAccount") = txtSalaryAccount.Text
            MyRow("EmployeeStatus") = cmbEmployeeStatus.Text
            'If (cmbEmployeeStatus.Text = "Resigned") Then
            MyRow("ResignedDate") = dtpResignedDate.Value 'RegistrationDate used to store Resigned date
            'Else
            '    MyRow("ResignedDate") = ""
            'End If

            MyRow("ESINo") = txtESINo.Text
            MyRow("PFNo") = txtPFNo.Text
            MyRow("IdentityProofName") = cmbIDProofName.Text
            MyRow("SalaryAccountBranch") = txtSalaryAccountBranch.Text
            If CheckBoxESIApplicable.Checked Then
                MyRow("ESIApplicability") = True
            Else
                MyRow("ESIApplicability") = False
            End If
            If CheckBoxPFApplicable.Checked Then
                MyRow("PFApplicability") = True
            Else
                MyRow("PFApplicability") = False
            End If

            If rbBank.Checked = True Then
                MyRow("SalaryType") = "Bank"
            ElseIf rbCash.Checked = True Then
                MyRow("SalaryType") = "Cash"
            End If
            MyRow("FixedSalary") = IIf(IsNumeric(txtFixedSalary.Text), txtFixedSalary.Text, 0)
            'MyRow("HRA") = IIf(IsNumeric(txtHRA.Text), txtHRA.Text, 0)
            'MyRow("OtherSalary") = IIf(IsNumeric(txtOtherSalary.Text), txtOtherSalary.Text, 0)
            MyRow("ESIEmployer") = IIf(IsNumeric(txtESIEmployer.Text), txtESIEmployer.Text, 0)
            MyRow("PFEmployer") = IIf(IsNumeric(txtPFEmployer.Text), txtPFEmployer.Text, 0)
            DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
            MyClassPayroll.FunSaveEmployeePersonnalInfo(DStemp, iMode)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeEarning()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 3)
            For i = 0 To DGVEarnings.NewRowIndex - 1
                If Val(DGVEarnings(1, i).Value) > 0 Or Val(DGVEarnings(2, i).Value) > 0 Then
                    DStemp.Tables("selectEmployeeTab").Rows.Clear()
                    MyRow = DStemp.Tables("selectEmployeeTab").NewRow
                    MyRow("EmployeeCode") = txtEmployeeCode.Text
                    MyRow("EarningName") = Convert.ToString(DGVEarnings(0, i).Value)
                    MyRow("EarningValue") = Convert.ToString(DGVEarnings(2, i).Value)
                    MyRow("Percentage") = Val(DGVEarnings(1, i).Value)
                    'MyRow("String2") = ""
                    'MyRow("String3") = ""
                    DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
                    MyClassPayroll.FunSaveEmployeeEarning(DStemp, 1)
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeDeduction()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 4)
            For i = 0 To DGVDeductions.NewRowIndex - 1
                If Val(DGVDeductions(1, i).Value) > 0 Or Val(DGVDeductions(2, i).Value) > 0 Then
                    DStemp.Tables("selectEmployeeTab").Rows.Clear()
                    MyRow = DStemp.Tables("selectEmployeeTab").NewRow
                    MyRow("EmployeeCode") = txtEmployeeCode.Text
                    MyRow("DeductionName") = Convert.ToString(DGVDeductions(0, i).Value)
                    MyRow("DeductionValue") = Convert.ToString(DGVDeductions(2, i).Value)
                    MyRow("Percentage") = Val(DGVDeductions(1, i).Value)
                    'MyRow("String2") = ""
                    'MyRow("String3") = ""
                    DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
                    MyClassPayroll.FunSaveEmployeeDeduction(DStemp, 1)
                End If
            Next
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeSalaryAdvance()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            If Val(txtSalaryBalance.Text) > 0 Or Val(txtSalaryInstallment.Text) > 0 Then
                DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 5)
                DStemp.Tables("selectEmployeeTab").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeTab").NewRow
                MyRow("EmployeeCode") = txtEmployeeCode.Text
                MyRow("sa_BalanceAmount") = Val(txtSalaryBalance.Text)
                MyRow("sa_Installment") = Val(txtSalaryInstallment.Text)
                'MyRow("String1") = 0
                'MyRow("String2") = ""
                'MyRow("String3") = ""
                DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeSalaryAdvance(DStemp, 1)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeloan()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            If Val(txtLoanAdvance.Text) > 0 Or Val(txtLoanInstallment.Text) > 0 Then
                DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 6)
                DStemp.Tables("selectEmployeeTab").Rows.Clear()
                MyRow = DStemp.Tables("selectEmployeeTab").NewRow
                MyRow("EmployeeCode") = txtEmployeeCode.Text
                MyRow("loan_BalanceAmount") = Val(txtLoanAdvance.Text)
                MyRow("loan_Installment") = Val(txtLoanInstallment.Text)
                'MyRow("String1") = 0
                'MyRow("String2") = ""
                'MyRow("String3") = ""
                DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
                MyClassPayroll.FunSaveEmployeeloan(DStemp, 1)
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunSaveEmployeeShiftTimings()
        Try
            Dim i, Count As New Integer
            Dim DStemp As New DataSet
            Dim MyRow As DataRow
            DStemp.Clear()
            DStemp = MyClassPayroll.FunSelectEmployeeTab(0, "", 11)
            DStemp.Tables("selectEmployeeTab").Rows.Clear()
            MyRow = DStemp.Tables("selectEmployeeTab").NewRow
            MyRow("employeeCode") = Trim(txtEmployeeCode.Text)
            MyRow("FNCheckIn") = dtpFNCheckin.Value.ToShortTimeString
            MyRow("FNCheckOut") = dtpFNCheckOut.Value.ToShortTimeString
            MyRow("ANCheckIn") = dtpANCheckIn.Value.ToShortTimeString
            MyRow("ANCheckOut") = dtpANCheckOut.Value.ToShortTimeString
            'MyRow("String1") = 0
            'MyRow("String2") = ""
            'MyRow("String3") = ""
            DStemp.Tables("selectEmployeeTab").Rows.Add(MyRow)
            MyClassPayroll.FunSaveEmployeeShiftTimings(DStemp, 1)
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FunSaveEmployeeAddInfo()
        Dim Gender As String
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Delete from tblEmployeeAddInfo where EmployeeCode='" & Trim(txtEmployeeCode.Text) & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
        If rbtMale.Checked Then
            Gender = rbtMale.Text
        Else
            Gender = rbtFemale.Text
        End If
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd.Connection = datacon.con
        datacon.cmd.CommandType = CommandType.StoredProcedure
        datacon.cmd.CommandText = "SP_EmployeeAddInfo"
        datacon.cmd.Parameters.AddWithValue("@EmployeeCode", Trim(txtEmployeeCode.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpAge", Trim(txtAge.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpGender", Trim(Gender))
        datacon.cmd.Parameters.AddWithValue("@EmpQual", Trim(txtQual.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpReligion", Trim(txtReligion.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpCaste", Trim(txtCaste.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpFatherName", Trim(txtFatherName.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpFatherOccup", Trim(txtFatherOccup.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpMotherName", Trim(txtMotherName.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpMotherOccup", Trim(txtMotherOccup.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpSiblings", Trim(txtSiblings.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpSpouse", Trim(txtSpouse.Text))
        datacon.cmd.Parameters.AddWithValue("@EmpChild", Trim(txtChild.Text))
        datacon.cmd.Parameters.AddWithValue("@Del_Status", "0")
        datacon.cmd.Parameters.AddWithValue("@Del_Date", " ")
        'datacon.cmd.Parameters.AddWithValue("@String1", 0)
        'datacon.cmd.Parameters.AddWithValue("@String2", " ")
        'datacon.cmd.Parameters.AddWithValue("@String3", " ")
        datacon.cmd.Parameters.AddWithValue("@EmpQualDetails", Trim(TxtQualDetails.Text))
        datacon.cmd.Parameters.AddWithValue("@BloodGroup", Trim(txtBloodGroup.Text))
        If rbtMarried.Checked Then
            datacon.cmd.Parameters.AddWithValue("@MaritalStatus", "Married")
        Else
            datacon.cmd.Parameters.AddWithValue("@MaritalStatus", "Single")
        End If
        datacon.cmd.Parameters.AddWithValue("@iMode", 1)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub

    Public Sub FunFillExistingItems()
        Try
            Dim sno As New Long
            Dim i As New Integer
            Dim strDate As New DateTime
            Dim strPaymentBasis As String
            DSEmp = MyClassPayroll.FunSelectEmployeeTab(EmpCode, "", 2)

            If DSEmp.Tables(0).Rows.Count > 0 Then
                txtEmployeeName.Text = DSEmp.Tables(0).Rows(0)("EmployeeName")
                txtEmployeeNo.Text = DSEmp.Tables(0).Rows(0)("Alias")
                txtEmployeeCode.Text = DSEmp.Tables(0).Rows(0)("EmployeeCode")
                txtEmployeeCode.ReadOnly = True
                cmbDesignation.Text = DSEmp.Tables(0).Rows(0)("Designation")
                strPaymentBasis = DSEmp.Tables(0).Rows(0)("PaymentBasis")
                'If Trim(strPaymentBasis) = "Daily" Then
                '    rbDaily.Checked = True
                'ElseIf Trim(strPaymentBasis) = "Contract" Then
                '    rbContract.Checked = True
                'Else
                If Trim(strPaymentBasis) = "Monthly" Then
                    rbMonthly.Checked = True
                ElseIf Trim(strPaymentBasis) = "Weekly" Then
                    rbWeekly.Checked = True
                End If
                txtBasicSalary.Text = DSEmp.Tables(0).Rows(0)("BasicSalary")
                cmbCategName.Text = DSEmp.Tables(0).Rows(0)("Category")
                txtAddress1.Text = DSEmp.Tables(0).Rows(0)("Address1")
                txtAddress2.Text = DSEmp.Tables(0).Rows(0)("Address2")
                cmbDptName.Text = DSEmp.Tables(0).Rows(0)("Department")
                txtNationality.Text = DSEmp.Tables(0).Rows(0)("Nationality")
                dtpDOJ.Value = DSEmp.Tables(0).Rows(0)("DateOfJoining")
                dtpDOB.Value = DSEmp.Tables(0).Rows(0)("AppraisalDate")
                txtVisaNo.Text = DSEmp.Tables(0).Rows(0)("VisaNo")
                txtPassportNo.Text = DSEmp.Tables(0).Rows(0)("PassportNo")
                txtContractNo.Text = DSEmp.Tables(0).Rows(0)("ContractNo")
                txtVisaExpiry.Text = DSEmp.Tables(0).Rows(0)("VisaExpiry")
                txtPassportExpiry.Text = DSEmp.Tables(0).Rows(0)("PassportExpiry")
                txtContrctExpiry.Text = DSEmp.Tables(0).Rows(0)("IdentityProofNo")
                'txtIDCardNo.Text = DSEmp.Tables(0).Rows(0)("PayableAccount")
                txtSalaryAccount.Text = DSEmp.Tables(0).Rows(0)("SalaryAccount")
                cmbEmployeeStatus.Text = DSEmp.Tables(0).Rows(0)("EmployeeStatus")
                'dtpResignedDate.Value = IIf(DSEmp.Tables(0).Rows(0)("ResignedDate") = "", Date.Today, DSEmp.Tables(0).Rows(0)("ResignedDate")) 'RegistrationDate used to store Resigned date
                dtpResignedDate.Value = DSEmp.Tables(0).Rows(0)("ResignedDate")
                txtESINo.Text = DSEmp.Tables(0).Rows(0)("ESINo")
                txtPFNo.Text = DSEmp.Tables(0).Rows(0)("PFNo")
                cmbIDProofName.Text = DSEmp.Tables(0).Rows(0)("IdentityProofName")
                txtSalaryAccountBranch.Text = DSEmp.Tables(0).Rows(0)("SalaryAccountBranch")
                If DSEmp.Tables(0).Rows(0)("ESIApplicability") = True Then
                    CheckBoxESIApplicable.Checked = True
                Else
                    CheckBoxESIApplicable.Checked = False
                End If

                If DSEmp.Tables(0).Rows(0)("PFApplicability") = True Then
                    CheckBoxPFApplicable.Checked = True
                Else
                    CheckBoxPFApplicable.Checked = False
                End If

                If DSEmp.Tables(0).Rows(0)("SalaryType").ToString = "Bank" Then
                    rbBank.Checked = True
                ElseIf DSEmp.Tables(0).Rows(0)("SalaryType").ToString = "Cash" Then
                    rbCash.Checked = True
                End If

                txtFixedSalary.Text = DSEmp.Tables(0).Rows(0)("FixedSalary")
                'txtHRA.Text = DSEmp.Tables(0).Rows(0)("HRA")
                'txtOtherSalary.Text = DSEmp.Tables(0).Rows(0)("OtherSalary")
                txtESIEmployer.Text = DSEmp.Tables(0).Rows(0)("ESIEmployer")
                txtPFEmployer.Text = DSEmp.Tables(0).Rows(0)("PFEmployer")
            End If

            Dim DStemp As New DataSet
            DStemp = MyClassPayroll.FunSelectEmployeeTab(EmpCode, "", 7)
            If DStemp.Tables(0).Rows.Count > 0 Then
                For i = 0 To DStemp.Tables(0).Rows.Count - 1
                    DGVEarnings.Rows.Add()
                    DGVEarnings(0, i).Value = DStemp.Tables(0).Rows(i)("EarningName")
                    DGVEarnings(1, i).Value = DStemp.Tables(0).Rows(i)("Percentage")
                    DGVEarnings(2, i).Value = DStemp.Tables(0).Rows(i)("EarningValue")
                Next
            Else
                FunLoadEarnings()
            End If


            If DStemp.Tables(1).Rows.Count > 0 Then
                For i = 0 To DStemp.Tables(1).Rows.Count - 1
                    DGVDeductions.Rows.Add()
                    DGVDeductions(0, i).Value = DStemp.Tables(1).Rows(i)("DeductionName")
                    DGVDeductions(1, i).Value = DStemp.Tables(1).Rows(i)("Percentage")
                    DGVDeductions(2, i).Value = DStemp.Tables(1).Rows(i)("DeductionValue")
                Next
            Else
                FunLoadDeductions()
            End If

            If DStemp.Tables(2).Rows.Count > 0 Then
                txtSalaryBalance.Text = DStemp.Tables(2).Rows(0)("sa_BalanceAmount")
                txtSalaryInstallment.Text = DStemp.Tables(2).Rows(0)("sa_Installment")
            End If

            If DStemp.Tables(3).Rows.Count > 0 Then
                txtLoanAdvance.Text = DStemp.Tables(3).Rows(0)("loan_BalanceAmount")
                txtLoanInstallment.Text = DStemp.Tables(3).Rows(0)("loan_Installment")
            End If

            If DStemp.Tables(4).Rows.Count > 0 Then
                dtpFNCheckin.Text = DStemp.Tables(4).Rows(0)("FNCheckIn")
                dtpFNCheckOut.Text = DStemp.Tables(4).Rows(0)("FNCheckOut")
                dtpANCheckIn.Text = DStemp.Tables(4).Rows(0)("ANCheckIn")
                dtpANCheckOut.Text = DStemp.Tables(4).Rows(0)("ANCheckOut")
            End If
            FillAddInfo()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FillAddInfo()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select [EmpAge],[EmpGender],[EmpQual],[EmpReligion],[EmpCaste],[EmpFatherName],[EmpFatherOccup],[EmpMotherName],[EmpMotherOccup],[EmpSiblings],[EmpSpouse],[EmpChild],[EmpQualDetails],isnull([BloodGroup],'') BloodGroup, isnull(MaritalStatus,'') from tblEmployeeAddInfo where EmployeeCode='" & EmpCode & "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        While datacon.dr.Read
            txtAge.Text = datacon.dr.GetValue(0)
            If datacon.dr.GetValue(1) = rbtMale.Text Then
                rbtMale.Checked = True
            Else
                rbtFemale.Checked = True
            End If
            'txtQual.Text = datacon.dr.GetValue(4)
            'txtReligion.Text = datacon.dr.GetValue(5)
            'txtCaste.Text = datacon.dr.GetValue(6)
            'txtFatherName.Text = datacon.dr.GetValue(7)
            'txtFatherOccup.Text = datacon.dr.GetValue(8)
            'txtMotherName.Text = datacon.dr.GetValue(9)
            'txtMotherOccup.Text = datacon.dr.GetValue(10)
            'txtSiblings.Text = datacon.dr.GetValue(11)
            'txtSpouse.Text = datacon.dr.GetValue(12)
            'txtChild.Text = datacon.dr.GetValue(13)
            'TxtQualDetails.Text = datacon.dr.GetValue(19)
            txtQual.Text = datacon.dr.GetValue(2)
            txtReligion.Text = datacon.dr.GetValue(3)
            txtCaste.Text = datacon.dr.GetValue(4)
            txtFatherName.Text = datacon.dr.GetValue(5)
            txtFatherOccup.Text = datacon.dr.GetValue(6)
            txtMotherName.Text = datacon.dr.GetValue(7)
            txtMotherOccup.Text = datacon.dr.GetValue(8)
            txtSiblings.Text = datacon.dr.GetValue(9)
            txtSpouse.Text = datacon.dr.GetValue(10)
            txtChild.Text = datacon.dr.GetValue(11)
            TxtQualDetails.Text = datacon.dr.GetValue(12)
            txtBloodGroup.Text = datacon.dr.GetValue(13)
            If datacon.dr.GetValue(14) = rbtMarried.Text Then
                rbtMarried.Checked = True
            Else
                rbtSingle.Checked = True
            End If
        End While
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Public Function Validation() As Boolean
        Try
            Dim Valid As Boolean = True
            Dim DOJ As New DateTime
            Dim DOB As New DateTime
            DOJ = dtpDOJ.Value.ToShortDateString
            DOB = dtpDOB.Value.ToShortDateString

            Dim YearDiff As Integer = DOJ.Year - DOB.Year
            If Trim(txtEmployeeName.Text) = Nothing Then
                lblErrorMessage.Text = "Enter Employee Name."
                Valid = False
            ElseIf Trim(txtEmployeeNo.Text) = Nothing Then
                lblErrorMessage.Text = "Enter Employee Number."
                Valid = False
            ElseIf Trim(cmbDptName.Text) = "Select" Then
                lblErrorMessage.Text = "Select Department Name."
                Valid = False
            ElseIf Trim(cmbDesignation.Text) = "Select" Or Trim(cmbDesignation.Text) = "" Then
                lblErrorMessage.Text = "Select Designation Name."
                Valid = False
            ElseIf rbMonthly.Checked = False And rbWeekly.Checked = False Then
                lblErrorMessage.Text = "Select Any one of the Payment Basis Option."
                Valid = False
            ElseIf YearDiff < 14 Then
                lblErrorMessage.Text = "Date of Birth is Invalid"
                Valid = False
                'Else
                '    lblErrorMessage.Text = "Some Records are missing"
                '    Valid = False
            End If
            Return Valid
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Function

    Public Sub FunLoadEarnings()
        Try
            DGVEarnings.Rows.Add()
            'DGVEarnings(0, 0).Value = "Basic + DA"
            'DGVEarnings.Rows.Add()
            DGVEarnings(0, 0).Value = "HRA"
            DGVEarnings.Rows.Add()
            DGVEarnings(0, 1).Value = "Others"
            'DGVEarnings.Rows.Add()
            'DGVEarnings(0, 3).Value = "Food Allowance"
            'DGVEarnings.Rows.Add()
            'DGVEarnings(0, 4).Value = "Utility Allowance"
            'DGVEarnings.Rows.Add()
            'DGVEarnings(0, 5).Value = "Leave Salary"
            'DGVEarnings.Rows.Add()
            'DGVEarnings(0, 6).Value = "Over Time"
            'DGVEarnings.Rows.Add()
            'DGVEarnings(0, 7).Value = "Bonus"
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FunLoadDeductions()
        Try

            DGVDeductions.Rows.Add()
            DGVDeductions(0, 0).Value = "ESI"
            DGVDeductions(1, 0).Value = decESIEmployeeContribution

            DGVDeductions.Rows.Add()
            DGVDeductions(0, 1).Value = "PF"
            DGVDeductions(1, 1).Value = decPFEmployeeContribution
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub


    Public Sub FunCalcDeductions()
        Try
            Dim i As Int16
            For i = 0 To DGVDeductions.NewRowIndex - 1
                If Convert.ToString(DGVDeductions(0, i).Value).ToLower = "esi" Then
                    DGVDeductions(2, i).Value = calcESI(txtFixedSalary.Text, DGVDeductions(1, i).Value)
                    txtESIEmployer.Text = calcESI(txtFixedSalary.Text, decESIEmployerContribution)

                ElseIf Convert.ToString(DGVDeductions(0, i).Value).ToLower = "pf" Then
                    DGVDeductions(2, i).Value = calcPF(txtBasicSalary.Text, DGVDeductions(1, i).Value)
                    txtPFEmployer.Text = calcPF(txtBasicSalary.Text, decPFEmployerContribution)

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Public Sub FunCalcEarnings()
        Try
            Dim i As Int16
            For i = 0 To DGVEarnings.NewRowIndex - 1
                DGVEarnings(2, i).Value = calcEaringValue(txtBasicSalary.Text, DGVEarnings(1, i).Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
#End Region

#Region "Function"

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        Try
            Dim EmpCode As String
            Dim DsCheck As New DataSet
            Dim DsCheck1 As New DataSet
            EmpCode = Trim(txtEmployeeCode.Text)
            lblErrorMessage.Visible = False
            If Validation() = True Then
                DSEmp = MyClassPayroll.FunSelectEmployeeTab(EmpCode, "", 2)
                If DSEmp.Tables(0).Rows.Count > 0 Then
                    iMode = 2
                Else
                    iMode = 1
                End If

                If checkEmployeeIdExistence() = False Then
                    FunSaveEmployeePersonnalInfo()
                    FunSaveEmployeeEarning()
                    FunSaveEmployeeDeduction()
                    FunSaveEmployeeSalaryAdvance()
                    FunSaveEmployeeloan()
                    FunSaveEmployeeShiftTimings()
                    FunSaveEmployeeAddInfo()
                    FunSaveProofImage()
                    'Me.Close()
                    FrmEmployeeListing.TrvEmployeeListing.Nodes.Clear()
                    FrmEmployeeListing.FunListEmployees()
                    Me.Close()
                Else
                    lblErrorMessage.Visible = True
                End If

            Else
                lblErrorMessage.Visible = True
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FrmEmployee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And txtAddress1.Focused = False And txtAddress2.Focused = False And txtProofDescription.Focused = False Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FunLoadPFSettings()
        DSEmp = MyClassPayroll.FunSelectPayrollShiftTimeSettings(1)

        If DSEmp.Tables(0).Rows.Count > 0 Then
            intMinPFSalaryCriteria = DSEmp.Tables(0).Rows(0)("MinPFSalaryCriteria")
            intMaxPFSalaryCriteria = DSEmp.Tables(0).Rows(0)("MaxPFSalaryCriteria")
            decPFEmployeeContribution = DSEmp.Tables(0).Rows(0)("PFEmployeeContribution")
            decPFEmployerContribution = DSEmp.Tables(0).Rows(0)("PFEmployerContribution")
            decESIEmployeeContribution = DSEmp.Tables(0).Rows(0)("ESIEmployeeContribution")
            decESIEmployerContribution = DSEmp.Tables(0).Rows(0)("ESIEmployerContribution")
        End If
    End Sub

    Private Sub FrmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            isFormLoading = True
            Me.BringToFront()
            Load_Designation()
            Load_Department()
            Load_Category()
            FunLoadPFSettings()

            If EmpCode <> Nothing Then
                ExistingMode = True
                FunFillExistingItems()
                Show_Proof_Image()
            Else
                ExistingMode = False
                FunGetAutoSlipNo()
                FunLoadEarnings()
                FunLoadDeductions()
                rbMonthly.Checked = True
                'cmbDptName.SelectedIndex = 0
                cmbEmployeeStatus.Text = "On Duty"
                dtpFNCheckin.Value = "1/1/1980 9:30:00 AM"
                dtpFNCheckOut.Value = "1/1/1980 1:30:00 PM"
                dtpANCheckIn.Value = "1/1/1980 2:30:00 PM"
                dtpANCheckOut.Value = "1/1/1980 7:00:00 PM"
            End If
            isFormLoading = False
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Load_Designation()
        cmbDesignation.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("select distinct designation from tblEmployeePersonnalInfo order by Designation", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.HasRows Then
            cmbDesignation.Items.Add("Select")
            While datacon.dr.Read
                cmbDesignation.Items.Add(datacon.dr.GetValue(0))
            End While
            cmbDesignation.SelectedIndex = 0
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub Load_Department()
        cmbDptName.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.HasRows Then
            cmbDptName.Items.Add("Select")
            While datacon.dr.Read
                cmbDptName.Items.Add(datacon.dr.GetValue(0))
            End While
            cmbDptName.SelectedIndex = 0
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub Load_Category()
        cmbCategName.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Categ_Name from Category_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.HasRows Then
            cmbCategName.Items.Add("Select")

            While datacon.dr.Read
                cmbCategName.Items.Add(datacon.dr.GetValue(0))
            End While
            cmbCategName.SelectedIndex = 0
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Function checkEmployeeIdExistence() As Boolean
        Dim isEmployeeIdExist As Boolean
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("SELECT [EmployeeCode] FROM [tblEmployeePersonnalInfo] where Alias='" + Trim(txtEmployeeNo.Text) + "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read Then
            If iMode = 2 And datacon.dr.Item("EmployeeCode") = txtEmployeeCode.Text Then
                isEmployeeIdExist = False
            Else
                lblErrorMessage.Text = "Employee Number " + txtEmployeeNo.Text + " already used for the Employee Code " + datacon.dr.Item("EmployeeCode")
                isEmployeeIdExist = True
            End If
        End If
        datacon.dr.Close()
        datacon.con.Close()
        Return isEmployeeIdExist
    End Function

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub MyDGVEarnings_CellValueChanged()
        Dim i As New Integer
        If Val(txtBasicSalary.Text) > 0 Then
            For i = 0 To DGVEarnings.NewRowIndex - 1
                If Val(DGVEarnings(1, i).Value) > 0 Then
                    DGVEarnings(2, i).Value = Val(txtBasicSalary.Text) * (Val(DGVEarnings(1, i).Value) / 100)
                Else
                    DGVEarnings(2, i).Value = 0
                End If
            Next
        Else
            For i = 0 To DGVEarnings.NewRowIndex - 1
                DGVEarnings(1, i).Value = 0
                DGVEarnings(2, i).Value = 0
            Next
        End If
    End Sub

    Private Sub MyDGVDeductions_CellValueChanged()
        Dim i As New Integer

        If Val(txtBasicSalary.Text) > 0 Then
            For i = 0 To DGVDeductions.NewRowIndex - 1
                If Val(DGVDeductions(1, i).Value) > 0 Then
                    DGVDeductions(2, i).Value = Val(txtBasicSalary.Text) * (Val(DGVDeductions(1, i).Value) / 100)
                Else
                    DGVDeductions(2, i).Value = 0
                End If
            Next
        Else
            For i = 0 To DGVDeductions.NewRowIndex - 1
                DGVDeductions(1, i).Value = 0
                DGVDeductions(2, i).Value = 0
            Next
        End If
    End Sub

    Private Sub DGVEarnings_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellLeave
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub



    Private Sub DGVEarnings_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellValueChanged
        If isFormLoading = False Then
            If isGridViewAutoUpdate = False Then
                'isGridViewAutoUpdate = True

                Dim i As New Integer
                If e.ColumnIndex = 1 Then
                    If Val(DGVEarnings("Percentages", e.RowIndex).Value) > 0 Then
                        DGVEarnings("EarningValue", e.RowIndex).Value = calcEaringValue(txtBasicSalary.Text, DGVEarnings("Percentages", e.RowIndex).Value)
                        'Else
                        '    DGVEarnings("EarningValue", e.RowIndex).Value = 0
                    End If
                End If

                ''If e.ColumnIndex = 2 Then
                ''    If Val(DGVEarnings("EarningValue", e.RowIndex).Value) > 0 Then
                ''        DGVEarnings("Percentages", e.RowIndex).Value = calcEarningPercent(txtBasicSalary.Text, DGVEarnings("EarningValue", e.RowIndex).Value)
                ''    Else
                ''        DGVEarnings("Percentages", e.RowIndex).Value = 0
                ''    End If
                ''End If
                'isGridViewAutoUpdate = False

                'Dim RunningPercentage As New Decimal

                'For i = 0 To DGVEarnings.NewRowIndex - 1
                '    If Val(DGVEarnings(1, i).Value) > 0 Then
                '        RunningPercentage += Val(DGVEarnings(1, i).Value)
                '        If RunningPercentage > 50 Then
                '            MsgBox("Total Earnings Greater than 50%")
                '            DGVEarnings(1, i).Value = 0
                '            DGVEarnings(2, i).Value = 0
                '        End If
                '    End If
                'Next
                CalcFixedSalary()
            End If
        End If
    End Sub

    Private Function calcEaringValue(salary As String, percentage As String) As Int32
        Return Convert.ToDouble(IIf(IsNumeric(percentage), percentage, 0)) * (Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) / 100)
    End Function

    Private Function calcEarningPercent(salary As String, amount As String) As Double
        If Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) > 0 Then
            Return (IIf(IsNumeric(amount), amount, 0) / Convert.ToInt32(IIf(IsNumeric(salary), salary, 0))) * 100
        End If
    End Function

    Private Sub DGVEarnings_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEarnings.CellEnter
        On Error Resume Next
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVEarnings(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

#End Region

    Private Function calcPF(salary As String, percentage As String) As Int32
        If CheckBoxPFApplicable.Checked Then
            If Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) < intMinPFSalaryCriteria Then
                Return Convert.ToDouble(IIf(IsNumeric(percentage), percentage, 0)) * (intMinPFSalaryCriteria / 100)
            ElseIf Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) > intMaxPFSalaryCriteria Then
                Return Convert.ToDouble(IIf(IsNumeric(percentage), percentage, 0)) * (intMaxPFSalaryCriteria / 100)
            Else
                Return Convert.ToDouble(IIf(IsNumeric(percentage), percentage, 0)) * (Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) / 100)
            End If
        Else
            Return 0
        End If
    End Function

    Private Function calcPFPercent(salary As String, amount As String) As Double
        If CheckBoxPFApplicable.Checked And Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) > 0 Then
            Return (IIf(IsNumeric(amount), amount, 0) / Convert.ToInt32(IIf(IsNumeric(salary), salary, 0))) * 100
        Else
            Return 0
        End If
    End Function

    Private Function calcESI(salary As String, percentage As String) As Int32
        If CheckBoxESIApplicable.Checked Then
            Return Convert.ToDouble(IIf(IsNumeric(percentage), percentage, 0)) * (Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) / 100)
        Else
            Return 0
        End If

    End Function

    Private Function calcESIPercent(salary As String, amount As String) As Double
        If CheckBoxESIApplicable.Checked And Convert.ToInt32(IIf(IsNumeric(salary), salary, 0)) > 0 Then
            Return (IIf(IsNumeric(amount), amount, 0) / Convert.ToInt32(IIf(IsNumeric(salary), salary, 0))) * 100
        Else
            Return 0
        End If

    End Function

    Public Sub Show_Proof_Image()
        Try
            Dim MyData As Byte() = Nothing
            datacon.con.Open()
            datacon.cmd = New SqlCommand("select SNo,EmployeeCode,ImageField,Description,String1 from tblEmployeeProof Where EmployeeCode='" & EmpCode & "'", datacon.con)
            datacon.dr = datacon.cmd.ExecuteReader

            While datacon.dr.Read()
                MyData = CType(datacon.dr.GetValue(2), Byte())
                Dim intData As New Integer
                intData = MyData.GetUpperBound(0)
                Dim fs As New FileStream(("Proof.jpg"), System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite)
                fs.Write(MyData, 0, intData)
                fs.Close()
                MyData = Nothing

                PictureBox1.ImageLocation = "Proof.jpg"
                txtProofDescription.Text = datacon.dr.GetValue(3)

            End While
            datacon.dr.Close()
            datacon.con.Close()

        Catch ex As Exception

        End Try

    End Sub

    Public Sub FunSaveProofImage()
        Try
            If ImagePath <> Nothing Then
                Dim fsPicture As FileStream = New FileStream(ImagePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim picData() As Byte = New Byte(fsPicture.Length) {}
                fsPicture.Read(picData, 0, Int32.Parse(fsPicture.Length))
                fsPicture.Close()
                'OleDbType.Binary).Value = picData
                datacon.con.Open()
                MyCommand.Connection = datacon.con
                MyCommand.CommandType = CommandType.StoredProcedure
                MyCommand.CommandText = "SP_EmployeeProof"
                MyCommand.Parameters.Clear()
                MyCommand.Parameters.AddWithValue("@SNo", 0)
                MyCommand.Parameters.AddWithValue("@EmployeeCode", Trim(txtEmployeeCode.Text))
                MyCommand.Parameters.AddWithValue("@ImageField", picData)
                If txtProofDescription.Text <> Nothing Then
                    MyCommand.Parameters.AddWithValue("@Description", txtProofDescription.Text)
                Else
                    MyCommand.Parameters.AddWithValue("@Description", "")
                End If
                MyCommand.Parameters.AddWithValue("@String1", "")
                MyCommand.Parameters.AddWithValue("@iMode", 1)
                MyCommand.ExecuteNonQuery()
                datacon.con.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnImageAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImageAdd.Click
        OpenFileDialog1.ShowDialog()
        ImagePath = OpenFileDialog1.FileName
        PictureBox1.ImageLocation = ImagePath
    End Sub

    Private Sub CalcFixedSalary()
        If isFormLoading = False Then

            Dim i, intEarnings As Int32
            For i = 0 To DGVEarnings.NewRowIndex - 1
                intEarnings = intEarnings + Val(DGVEarnings(2, i).Value)
            Next

            txtFixedSalary.Text = Val(txtBasicSalary.Text) + intEarnings
            FunCalcDeductions()
            'FunCalcEarnings()
        End If
    End Sub

    Private Sub cmbEmployeeStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmployeeStatus.SelectedIndexChanged
        If (cmbEmployeeStatus.SelectedItem.ToString <> "Resigned") Then
            dtpResignedDate.Visible = False
        Else
            dtpResignedDate.Visible = True
            dtpResignedDate.Value = Date.Today
        End If
    End Sub


    Private Sub DGVDeductions_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDeductions.CellEnter
        On Error Resume Next
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVDeductions_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDeductions.CellLeave
        On Error Resume Next
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVDeductions(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White
    End Sub

    Private Sub DGVDeductions_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDeductions.CellValueChanged
        If isFormLoading = False Then
            If isGridViewAutoUpdate = False Then
                isGridViewAutoUpdate = True
                Dim i As New Integer

                If e.ColumnIndex = 1 Then
                    If Convert.ToString(DGVDeductions(0, e.RowIndex).Value).ToLower = "esi" Then
                        DGVDeductions(2, e.RowIndex).Value = calcESI(txtFixedSalary.Text, DGVDeductions(1, e.RowIndex).Value)
                        txtESIEmployer.Text = calcESI(txtFixedSalary.Text, decESIEmployerContribution)
                    ElseIf Convert.ToString(DGVDeductions(0, e.RowIndex).Value).ToLower = "pf" Then
                        DGVDeductions(2, e.RowIndex).Value = calcPF(txtBasicSalary.Text, DGVDeductions(1, e.RowIndex).Value)
                        txtPFEmployer.Text = calcPF(txtBasicSalary.Text, decPFEmployerContribution)
                    Else
                        DGVDeductions(2, e.RowIndex).Value = calcESI(txtFixedSalary.Text, DGVDeductions(1, e.RowIndex).Value)
                    End If
                End If
                'If e.ColumnIndex = 2 Then
                '    If Convert.ToString(DGVDeductions(0, e.RowIndex).Value).ToLower = "esi" Then
                '        DGVDeductions(1, e.RowIndex).Value = calcESIPercent(txtFixedSalary.Text, DGVDeductions(2, e.RowIndex).Value)
                '    ElseIf Convert.ToString(DGVDeductions(0, e.RowIndex).Value).ToLower = "pf" Then
                '        DGVDeductions(1, e.RowIndex).Value = calcPFPercent(txtBasicSalary.Text, DGVDeductions(2, e.RowIndex).Value)
                '    Else
                '        DGVDeductions(1, e.RowIndex).Value = calcESIPercent(txtFixedSalary.Text, DGVDeductions(2, e.RowIndex).Value)
                '    End If
                'End If
                isGridViewAutoUpdate = False
                Dim RunningPercentage As New Decimal
                For i = 0 To DGVDeductions.NewRowIndex - 1
                    If Val(DGVDeductions(1, i).Value) > 0 Then
                        RunningPercentage += Val(DGVDeductions(1, i).Value)
                        If RunningPercentage > 75 Then
                            MsgBox("Total Deductions Greater than 75%")
                            DGVDeductions(1, i).Value = 0
                            DGVDeductions(2, i).Value = 0
                        End If
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub txtBasicSalary_TextChanged(sender As Object, e As EventArgs) Handles txtBasicSalary.TextChanged
        CalcFixedSalary()
    End Sub

    Private Sub CheckBoxESIApplicable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxESIApplicable.CheckedChanged
        FunCalcDeductions()
    End Sub

    Private Sub CheckBoxPFApplicable_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPFApplicable.CheckedChanged
        FunCalcDeductions()
    End Sub
End Class

