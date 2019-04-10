Imports System.Data.SqlClient

Public Class frmUtiRunClose


    Private Sub frmUtiRunClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String
        Dim mydataset As New DataSet

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor
        'Me.WindowState = FormWindowState.Normal
        'Me.Height = 760

        '查询DB: UtiRunTrack 并显示机台当前状态
        txt_FormNo.Text = UtilizationFormNo
        txt_tester.Text = UtilizationIdx

        mysql = "select * from UtiRunTrack where SN = '" & UtilizationFormNo & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "RUN")

        If mydataset.Tables("RUN").Rows.Count = 0 Then
        Else
            txt_ilot.Text = mydataset.Tables("RUN").Rows(0).Item("iLot")
            txt_ilot.Enabled = False
        End If

        'Wafer Select 增加一行
        DGV_waferselect.Rows.Add(1)


    End Sub

    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click

        Dim i As Integer
        For i = 0 To 24
            DGV_waferselect(i, 0).Value = True
        Next

    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click

        Dim i As Integer
        For i = 0 To 24
            DGV_waferselect(i, 0).Value = False
        Next

    End Sub



    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String
        Dim SelectedQty As Integer, waferliststr As String, currtestwafer As Integer, currtestdieqty As Integer

        'Wafer 勾选片数确认
        For i = 0 To 24
            If DGV_waferselect(i, 0).Value = True Then
                SelectedQty += 1
                waferliststr += "1"
            Else
                waferliststr += "0"
            End If
        Next

        If txt_currwafer.Text <> "" Then
            currtestwafer = CInt(txt_currwafer.Text)
        Else
            currtestwafer = 0
        End If

        If txt_testdieqty.Text <> "" Then
            currtestdieqty = CInt(txt_testdieqty.Text)
        Else
            currtestdieqty = 0
        End If




        mysql = "UPDATE  UtiRunTrack SET finishwaferqty= '" & SelectedQty & "', finishwaferlist='" & waferliststr &
            "', currtestwafer='" & currtestwafer & "', currtestdieqty='" & currtestdieqty & "', endtime='" & Now() & "' WHERE SN='" & UtilizationFormNo & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()

        Me.DialogResult = DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub


End Class