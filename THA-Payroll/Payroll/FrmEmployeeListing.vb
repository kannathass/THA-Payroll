Imports System.Data.SqlClient

Public Class FrmEmployeeListing

#Region "Declaration"

    Dim MyClassPayroll As New clsPayroll
    Dim DSEmp As New DataSet
    Dim OrderNo As New Long
    Dim VendorName As String
    Dim SelectionMode As Boolean

    Dim EmpCode As String
    Dim datacon As New ConnectSql

#End Region

    Private Sub Load_Department()
        cmbDptName.Items.Clear()
        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        While datacon.dr.Read
            cmbDptName.Items.Add(datacon.dr.GetValue(0))
        End While
        datacon.dr.Close()
        datacon.con.Close()
        cmbDptName.Items.Add("All")
    End Sub

    Public Sub FunListEmployees()
        Try
            Dim i As New Long
            Dim EmpCode, EmpName, EmpDesignation, EmpDept, SelectedDept As String
            If cmbDptName.Text = "All" Then
                SelectedDept = ""
            ElseIf cmbDptName.Text <> Nothing Then
                SelectedDept = cmbDptName.Text
            Else
                SelectedDept = ""
            End If
            DSEmp.Clear()
            DSEmp = MyClassPayroll.FunSelectEmployeeTab(0, SelectedDept, 12)
            If DSEmp.Tables("selectEmployeeTab").Rows.Count > 0 Then
                TrvEmployeeListing.Nodes.Clear()
                For i = 0 To DSEmp.Tables("selectEmployeeTab").Rows.Count - 1
                    Dim ChildNode As New TreeNode
                    EmpCode = DSEmp.Tables("selectEmployeeTab").Rows(i)("EmployeeCode")
                    EmpName = DSEmp.Tables("selectEmployeeTab").Rows(i)("EmployeeName")
                    EmpDesignation = DSEmp.Tables("selectEmployeeTab").Rows(i)("Designation")
                    EmpDept = DSEmp.Tables("selectEmployeeTab").Rows(i)("Department")
                    ChildNode.Text = EmpCode & " | " & EmpName & " | " & EmpDesignation & " | " & EmpDept
                    ChildNode.Name = EmpCode
                    TrvEmployeeListing.Nodes.Add(ChildNode)
                Next
                'TrvEmployeeListing.Select()
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FrmEmployeeListing_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            SelectionMode = False
            TrvEmployeeListing.Nodes.Clear()
            Load_Department()
            FunListEmployees()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub FrmEmployeeListing_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub FrmEmployeeListing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BringToFront()
            SelectionMode = False
            Load_Department()
            cmbDptName.SelectedIndex = 0
            TrvEmployeeListing.Nodes.Clear()
            FunListEmployees()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButAdd.Click
        Try
            Dim MyForm As New FrmEmployee
            MyForm.show()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButEdit.Click
        Try
            Dim arr() As String
            Dim str As String

            If TrvEmployeeListing.Nodes.Count <> 0 Then
                If SelectionMode = True Then
                    SelectionMode = False
                    str = TrvEmployeeListing.SelectedNode.Text
                    arr = str.Split("|")
                    EmpCode = Trim(arr(0))
                    FrmEmployee.EmpCode = EmpCode
                    FrmEmployee.Show()
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TrvEmployeeListing_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrvEmployeeListing.MouseDoubleClick
        Try
            Dim arr() As String
            Dim str As String

            If TrvEmployeeListing.Nodes.Count <> 0 Then
                If SelectionMode = True Then
                    SelectionMode = False
                    str = TrvEmployeeListing.SelectedNode.Text
                    arr = str.Split("|")
                    EmpCode = Trim(arr(0))
                    FrmEmployee.EmpCode = EmpCode
                    FrmEmployee.Show()
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub TrvEmployeeListing_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrvEmployeeListing.MouseDown
        Try
            SelectionMode = True
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub ButDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Try
            Dim arr() As String
            Dim str As String
            Dim msgboxRes As New MsgBoxResult

            If TrvEmployeeListing.Nodes.Count <> 0 Then
                If SelectionMode = True Then
                    SelectionMode = False
                    str = TrvEmployeeListing.SelectedNode.Text
                    arr = str.Split("|")
                    EmpCode = Trim(arr(0))
                    Dim DsCheck As New DataSet

                    'To check Whether the order in Outward_Main when deleting the order in LPO or LPOInHouse

                    'DSEmp = MyClassPayroll.FunSelectEmployeeTab(0, 9)
                    'If DsCheck.Tables(0).Rows.Count > 0 Then
                    '    MsgBox("Outward is already planned for this Slip No." & Chr(13) & "Delete that and then Proceed.")
                    'Else
                    msgboxRes = MessageBox.Show("Are you sure to Delete the Reference No.: " & str & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If msgboxRes = MsgBoxResult.Yes Then
                        MyClassPayroll.FunDeleteEmployeeTab(EmpCode)
                        TrvEmployeeListing.Nodes.Clear()
                        FunListEmployees()
                    End If
                    'End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(Err.Description)
        End Try
    End Sub

    Public Sub FunFilter()
        Try
            Dim i, j As New Integer
            Dim strFilter As String
            strFilter = txtFilter.Text

            TrvEmployeeListing.Nodes.Clear()
            FunListEmployees()

            For i = 0 To TrvEmployeeListing.Nodes.Count - 1
                If TrvEmployeeListing.Nodes(i).Text.ToUpper.Contains(strFilter.ToUpper) Then

                    TrvEmployeeListing.SelectedNode = TrvEmployeeListing.Nodes.Item(i)
                    TrvEmployeeListing.SelectedNode.ForeColor = Color.White
                    TrvEmployeeListing.SelectedNode.BackColor = Color.DarkBlue
                    'TrvEmployeeListing.SelectedNode.EnsureVisible()

                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(txtFilter.Text) <> Nothing Then
            FunFilter()
        Else
            TrvEmployeeListing.FullRowSelect = False
        End If
    End Sub

    Private Sub cmbDptName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDptName.SelectedIndexChanged
        If cmbDptName.Text <> Nothing Then
            FunListEmployees()
        End If
    End Sub
End Class