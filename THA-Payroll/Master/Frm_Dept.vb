Imports System.Data.SqlClient

Public Class Frm_Dept
    Dim datacon As New ConnectSql
    Dim Valid_Del As Integer
    Dim iMod As Integer
    Dim Proc_Name As String
    Dim Proc_Desc As String
    Dim Proc_Order As Integer
    Private Sub Frm_Dept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        Proc_Name = frmMas_Category.It_Name
        Check_Edit_Add()
    End Sub
    Private Function validate_fields()
        If Proc_Name = Nothing Then
            LabelError.Text = "Department Name is Empty"
            Return 0
        End If
        Return 1
    End Function
    Private Function validate_code()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Del_Status from Department_Details where Dept_Name='" & Proc_Name & "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader

        If datacon.dr.Read Then
            If datacon.dr.GetValue(0) = Nothing Then
                datacon.dr.Close()
                datacon.con.Close()
                Valid_Del = 0
                LabelError.Text = "Department Name already Exists"
                Return 0
            Else
                Valid_Del = 1
            End If
        End If
        datacon.dr.Close()
        datacon.con.Close()
        Return 1
    End Function
    Private Sub Update_Process()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Update Department_Details set Del_status='0' where Dept_Name='" & Proc_Name & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub
    Private Sub add_to_db()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd.Connection = datacon.con
        datacon.cmd.CommandType = CommandType.StoredProcedure
        datacon.cmd.CommandText = "Department_Details_Sp"
        datacon.cmd.Parameters.AddWithValue("@Dept_Name", Proc_Name)
        datacon.cmd.Parameters.AddWithValue("@Dept_Desc", Proc_Desc)
        datacon.cmd.Parameters.AddWithValue("@iMod", iMod)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub
    Private Sub Check_Edit_Add()
        If Proc_Name = Nothing Then
            iMod = 1

        Else
            iMod = 2
            TBProcessName.ReadOnly = True
            TBProcessName.BackColor = Color.DarkOliveGreen
            TBProcessName.ForeColor = Color.White
            Update_Controls()
        End If
    End Sub
    
    Private Sub Update_Controls()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from Department_Details where Dept_Name='" & Proc_Name & "'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        If datacon.dr.Read Then
            TBProcessName.Text = datacon.dr.GetValue(0)
            tbProcessDesc.Text = datacon.dr.GetValue(1)
        End If
        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub ButSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButSave.Click
        Dim valid_Fields As Boolean
        Dim valid_code As Boolean
        Add_to_variables()
        Valid_Del = 0
        valid_Fields = validate_fields()
        If valid_Fields Then
            valid_code = validate_code()
            If valid_code And Valid_Del = 0 Then
                add_to_db()
                frmMas_Category.It_Name = " "
                Me.Close()
                frmMas_Category.update_tree()
            ElseIf Valid_Del = 1 Then
                Update_Process()
                frmMas_Category.It_Name = " "
                Me.Close()
                frmMas_Category.update_tree()
            Else
                LabelError.Visible = True
            End If

        Else
            LabelError.Visible = True
        End If
    End Sub
    Private Sub Add_to_variables()
        Proc_Name = Trim(TBProcessName.Text)
        Proc_Desc = Trim(tbProcessDesc.Text)
    End Sub

    Private Sub ButClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButClose.Click
        frmMas_Category.It_Name = " "
        Me.Close()
    End Sub

    Private Sub Frm_Dept_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class