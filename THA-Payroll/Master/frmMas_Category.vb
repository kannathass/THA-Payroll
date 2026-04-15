Imports System.Data.SqlClient
Public Class frmMas_Category
    Dim datacon As New ConnectSql
    Public It_Name As String
    Private Sub frmMas_Category_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BringToFront()
        update_tree()
    End Sub
    Public Sub update_tree()
        Dim Deptnode As New TreeNode
        Dim Categnode As New TreeNode

        Dim k As Integer

        TrvMisc.Nodes.Clear()

        Deptnode.Name = "Department"
        Deptnode.Text = "Department"
        TrvMisc.Nodes.Add(Deptnode)

        Categnode.Name = "Category"
        Categnode.Text = "Category"
        TrvMisc.Nodes.Add(Categnode)

        datacon.con.Close()
        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Dept_Name from Department_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader

        k = 0
        While datacon.dr.Read()
            Dim childnode As New TreeNode
            childnode.Text = datacon.dr.GetValue(0)
            childnode.Name = k
            Deptnode.Nodes.Add(childnode)
            k = k + 1
        End While

        datacon.dr.Close()
        datacon.con.Close()

        datacon.con.Open()
        datacon.cmd = New SqlCommand("Select Categ_Name from Category_Details where Del_Status='0'", datacon.con)
        datacon.dr = datacon.cmd.ExecuteReader

        While datacon.dr.Read()
            Dim childnode As New TreeNode
            childnode.Text = datacon.dr.GetValue(0)
            childnode.Name = k
            Categnode.Nodes.Add(childnode)
            k = k + 1
        End While

        datacon.dr.Close()
        datacon.con.Close()

        TrvMisc.Parent.Select()
        TrvMisc.ExpandAll()
    End Sub

    Private Sub ButAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAdd.Click
        On Error Resume Next
        It_Name = ""
        If TrvMisc.SelectedNode.Text = "Department" Then
            Frm_Dept.Show()
        ElseIf TrvMisc.SelectedNode.Text = "Category" Then
            Frm_Category.Show()
        ElseIf TrvMisc.SelectedNode.Parent.Text = "Department" Then
            Frm_Dept.Show()
        ElseIf TrvMisc.SelectedNode.Parent.Text = "Category" Then
            Frm_Category.Show()
        End If
    End Sub

    Private Sub ButEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButEdit.Click
        On Error GoTo ex
        If TrvMisc.Nodes.Count <> 0 Then
            It_Name = TrvMisc.SelectedNode.Text
            If TrvMisc.SelectedNode.Level = 1 Then
                If TrvMisc.SelectedNode.Parent.Text = "Category" Then
                    Frm_Category.Show()
                ElseIf TrvMisc.SelectedNode.Parent.Text = "Department" Then
                    Frm_Dept.Show()
                End If
            End If
        End If
        TrvMisc.Select()
ex:
    End Sub

    Private Sub ButDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        On Error GoTo ex
        If TrvMisc.Nodes.Count <> 0 Then
            It_Name = TrvMisc.SelectedNode.Text
            If TrvMisc.SelectedNode.Level = 1 Then
                Dim msgboxRes As New MsgBoxResult
                msgboxRes = MessageBox.Show("Are you sure to Delete the Item.: " & TrvMisc.SelectedNode.Text & "?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If msgboxRes = MsgBoxResult.Yes Then
                    If TrvMisc.SelectedNode.Parent.Text = "Category" Then
                        Delete_Category()
                    ElseIf TrvMisc.SelectedNode.Parent.Text = "Department" Then
                        Delete_Department()
                    End If
                End If
            End If
        End If
ex:
    End Sub

    Private Sub Delete_Category()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("update Category_Details set Del_Status='1', Del_Date='" & Date.Now & "' where Categ_Name='" & It_Name & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub

    Private Sub Delete_Department()
        datacon = New ConnectSql
        datacon.con.Open()
        datacon.cmd = New SqlCommand("update Department_Details set Del_Status='1', Del_Date='" & Date.Now & "' where Dept_Name='" & It_Name & "'", datacon.con)
        datacon.cmd.ExecuteNonQuery()
        datacon.con.Close()
    End Sub

    Private Sub frmMas_Category_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub ButClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButClose.Click
        Me.Close()
    End Sub
End Class