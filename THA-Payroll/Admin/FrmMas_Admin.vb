Imports System.Data.SqlClient
Public Class FrmMas_Admin
    Dim datacon As New ConnectSql
    Dim i As Integer
    Dim valid As Boolean
    Public rowid As Integer


    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        valid = Validate_Fields()
        labelerror.visible = False
        If valid Then
            Add_to_db()
            Me.Close()
        Else
            LabelError.text = "List is Incomplete"
            labelError.visible = True
        End If

    End Sub
    Private Sub Add_to_db()
        'For i = 0 To DGVDetails.NewRowIndex - 1
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Delete from LoginDetails where EmpCode!='THA007'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
        ' Next

        For i = 0 To DGVDetails.NewRowIndex - 1
            datacon = New ConnectSql
            datacon.con.Open()
            datacon.cmd.Connection = datacon.con
            datacon.cmd.CommandType = CommandType.StoredProcedure
            datacon.cmd.CommandText = "SP_User_Details"
            datacon.cmd.Parameters.AddWithValue("@EmpCode", DGVDetails(1, i).Value)
            datacon.cmd.Parameters.AddWithValue("@EmpName", DGVDetails(2, i).Value)
            datacon.cmd.Parameters.AddWithValue("@UName", DGVDetails(3, i).Value)
            datacon.cmd.Parameters.AddWithValue("@PassWd", DGVDetails(4, i).Value)
            datacon.cmd.Parameters.AddWithValue("@Hint", DGVDetails(5, i).Value)
            datacon.cmd.Parameters.AddWithValue("@Privilege", DGVDetails(0, i).Value)
            datacon.cmd.Parameters.AddWithValue("@Last_Login", DGVDetails(6, i).Value)
            datacon.cmd.Parameters.AddWithValue("@Create_Date", DGVDetails(7, i).Value)
            datacon.cmd.Parameters.AddWithValue("@Modified_by", FrmLogin.UName)
            datacon.cmd.Parameters.AddWithValue("@LoggedIn", "No")
            datacon.cmd.ExecuteNonQuery()
            datacon.con.Close()
        Next

    End Sub
    Private Function Validate_Fields()
        Dim j As Integer

        If DGVDetails.NewRowIndex = 0 Then
            For i = 0 To 5
                If DGVDetails(i, 0).Value = Nothing Then
                    Return 0
                End If
            Next
        Else
            For i = 0 To DGVDetails.NewRowIndex - 1
                For j = 0 To 5
                    If DGVDetails(j, i).Value = Nothing Then
                        Return 0
                    End If
                Next
            Next
        End If
        Return 1
    End Function

    Private Sub FrmMas_Admin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BringToFront()
        Add_Privileges()
        Load_Existing_Users()

        'Dim User_Check As New Check_User_Privilege

        'If User_Check.HasPrivilege(FrmLogin.Privilege, Me.Name) = False Then
        '    MsgBox("You dont have Access Permission")
        '    Me.Close()
        'End If
    End Sub
   
    Private Sub Add_Privileges()
        Access_Role.Items.Clear()
        Access_Role.Items.Add("ADMIN")
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        While datacon.dr.Read
            Access_Role.Items.Add(datacon.dr.GetValue(0))
        End While
        datacon.dr.Close()
        datacon.con.Close()

    End Sub
    Private Sub Load_Existing_Users()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select * from LoginDetails where EmpCode<>'THA007'", datacon.con)
        'datacon.cmd = New SqlCommand("Select * from LoginDetails", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader
        i = 0
        While datacon.dr.Read
            DGVDetails.Rows.Add()
            DGVDetails(0, i).Value = UCase(datacon.dr.GetValue(5))
            DGVDetails(1, i).Value = datacon.dr.GetValue(0)
            DGVDetails(2, i).Value = datacon.dr.GetValue(1)
            DGVDetails(3, i).Value = datacon.dr.GetValue(2)
            DGVDetails(4, i).Value = datacon.dr.GetValue(3)
            DGVDetails(5, i).Value = datacon.dr.GetValue(4)
            DGVDetails(6, i).Value = datacon.dr.GetValue(6)
            DGVDetails(7, i).Value = datacon.dr.GetValue(7)
            DGVDetails(8, i).Value = datacon.dr.GetValue(8)
            DGVDetails(9, i).Value = datacon.dr.GetValue(9)
            i = i + 1
        End While

        datacon.dr.Close()
        datacon.con.Close()
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmMas_Admin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If

        If e.KeyCode = Keys.F2 And DGVDetails.Focused = True Then
            rowid = DGVDetails.CurrentRow.Index
            FrmPopAdmin.Show()
            'Show Employee Pop
        End If
    End Sub

    Private Sub DGVDetails_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetails.CellEnter
        On Error Resume Next
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.PaleGreen
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.DarkGreen
    End Sub

    Private Sub DGVDetails_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDetails.CellLeave
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionBackColor = Color.DarkOliveGreen
        DGVDetails(e.ColumnIndex, e.RowIndex).Style.SelectionForeColor = Color.White

    End Sub
End Class