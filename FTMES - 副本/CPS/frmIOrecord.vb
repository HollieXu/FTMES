Imports System.Data.SqlClient

Public Class frmIOrecord

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_IO.DataSource = Nothing

        mysql = "select * from IOrecord"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "io")

        If mydataset.Tables("io").Rows.Count = 0 Then
            DGV_IO.DataSource = Nothing

        Else
            DGV_IO.DataSource = mydataset.Tables("io")
        End If

    End Sub

    Private Sub frmIOrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_IO_delete.Visible = True
            Case GROUPTYPE.MGR
                btn_IO_delete.Enabled = False

            Case GROUPTYPE.ENG
                btn_IO_delete.Enabled = False

                '工程师级别限定EAE工号才有新增/修改/启用/停用 权限
                If Strings.Left(UserID + "0000", 4) <> "0032" Then
                    btn_IO_new.Enabled = False
                    btn_IO_modify.Enabled = False
                End If

            Case GROUPTYPE.OP
                btn_IO_new.Enabled = False
                btn_IO_modify.Enabled = False
                btn_IO_delete.Enabled = False

        End Select




        Me.BackColor = mydefaultcolor
        DGV_IO.BackgroundColor = mydefaultcolor

    End Sub


    Private Sub btn_IO_new_Click(sender As Object, e As EventArgs) Handles btn_IO_new.Click

        IO_Operation_Mode = "NEW"
        frmIOset.Show()

    End Sub

    Private Sub btn_IO_modify_Click(sender As Object, e As EventArgs) Handles btn_IO_modify.Click

        IO_Operation_Mode = "MODIFY"
        If DGV_IO.Rows.Count = 0 Then Exit Sub

        myio.ID = DGV_IO.SelectedRows(0).Cells("CaseID").Value.ToString
        myio.type = DGV_IO.SelectedRows(0).Cells("Type").Value.ToString
        myio.INDate = DGV_IO.SelectedRows(0).Cells("InDate").Value.ToString
        myio.OUTDate = DGV_IO.SelectedRows(0).Cells("OutDate").Value.ToString
        myio.Status = DGV_IO.SelectedRows(0).Cells("status").Value.ToString
        myio.equipment = DGV_IO.SelectedRows(0).Cells("equip").Value.ToString
        myio.supplier = DGV_IO.SelectedRows(0).Cells("supplier").Value.ToString
        myio.config = DGV_IO.SelectedRows(0).Cells("config").Value.ToString
        myio.attach = DGV_IO.SelectedRows(0).Cells("Attachment").Value.ToString

        frmIOset.Show()

    End Sub

    Private Sub btn_IO_delete_Click(sender As Object, e As EventArgs) Handles btn_IO_delete.Click

        Dim mysql As String, s As Integer

        If DGV_IO.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myio.ID = DGV_IO.SelectedRows(0).Cells("CaseID").Value

            mysql = "DELETE FROM IOrecord WHERE CaseID='" & myio.ID & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_Query_Click("", e)

        End If





    End Sub



End Class