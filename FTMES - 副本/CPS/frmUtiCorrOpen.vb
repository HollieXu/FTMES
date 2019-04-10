Public Class frmUtiCorrOpen

    Private Sub frmUtiCorrOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor

        txt_FormNo.Text = "UTC" + Format(Now(), "yyyyMMddHHmmss")
        UtilizationFormNo = txt_FormNo.Text '赋值给全局变量，传递到UtilizationTrack主表

        For i = 1 To 25
            combo_wlist.Items.Add(i)
            combo_corrwlist.Items.Add(i)
        Next

        For i = 1 To 9
            combo_corrstep.Items.Add("CP" & i)
        Next


    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim recordflag As String, corrflag As String
        Dim mysql As String


        If rb_system.Checked = True Then
            recordflag = "SYSTEM"
        End If
        If rb_paper.Checked = True Then
            recordflag = "PAPER"
        End If

        If rb_currwafer.Checked = True Then
            corrflag = "CurrentWafer"
        End If
        If rb_goldwafer.Checked = True Then
            corrflag = "GoldenWafer"
        End If


        mysql = "INSERT INTO UtiCorrTrack (SN,tester,recordflag,prodlot,prodwafer,corrflag,corrlot,corrwafer,step,probecard,program,starttime) VALUES ( '" &
                txt_FormNo.Text & "','" & UtilizationIdx & "','" & recordflag & "','" & txt_lot.Text & "','" & combo_wlist.Text & "','" & corrflag & "','" & txt_corrlot.Text & "','" &
                combo_corrwlist.Text & "','" & combo_corrstep.Text & "','" & txt_pc.Text & "','" & txt_pgm.Text & "','" & Now() & "')"

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