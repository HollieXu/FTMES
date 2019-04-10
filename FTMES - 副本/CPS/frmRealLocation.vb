Imports System.Data.SqlClient

Public Class frmRealLocation

    Private Sub frmRealLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 50
        Me.Top = 50
        Me.BackColor = mydefaultcolor

        txt_id.Focus()


    End Sub



    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim mysql As String
        Dim ErrorInfo As String

        If txt_id.Text = "" Then
            MsgBox("批号/编号栏位不可以为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If txt_location.Text = "" Then
            MsgBox("库位不可以为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If rb_wafer.Checked = True Then

            '首先判断输入的ID是否存在
            Dim mydataset As New DataSet

            mysql = "select * from WIPLOT Where iTestLotNo='" & txt_id.Text & "'"

            Dim myadapter As New SqlDataAdapter(mysql, myconn)

            myadapter.Fill(mydataset, "WIP")

            If mydataset.Tables("WIP").Rows.Count = 0 Then
                MsgBox("输入的批号不存在 !", vbOKOnly + vbExclamation)
                Exit Sub
            Else
                If mydataset.Tables("WIP").Rows(0).Item("CurrentStep") = "INV" Then
                    MsgBox("已出货站别，无法更新!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '更新库位
            mysql = "UPDATE WIPLOT SET Location= '" & txt_location.Text & "' WHERE iTestLotNo= '" & txt_id.Text & "'"

        End If



        If rb_accessory.Checked = True Then

            '首先判断输入的ID是否存在
            Dim mydataset2 As New DataSet

            mysql = "select * from Accessory Where ID='" & txt_id.Text & "'"

            Dim myadapter2 As New SqlDataAdapter(mysql, myconn)

            myadapter2.Fill(mydataset2, "Assy")

            If mydataset2.Tables("Assy").Rows.Count = 0 Then
                MsgBox("输入的编号不存在 !", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            '更新库位
            mysql = "UPDATE Accessory SET Location= '" & txt_location.Text & "' WHERE ID= '" & txt_id.Text & "'"

        End If

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrorInfo = ex.Message
            MsgBox(ex.Message, vbOKOnly + vbExclamation)
        End Try

        myconn.Close()


        If ErrorInfo = "" Then
            txt_id.Text = ""
            txt_location.Text = ""
        Else
            MsgBox("更新失败 !", vbOKOnly + vbExclamation)
        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class