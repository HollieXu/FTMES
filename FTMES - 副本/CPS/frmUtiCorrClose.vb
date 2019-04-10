Public Class frmUtiCorrClose

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim resultflag As Boolean
        Dim mysql As String

        If rb_pass.Checked = True Then
            resultflag = True
        End If
        If rb_fail.Checked = True Then
            resultflag = False
        End If

        mysql = "UPDATE  UtiCorrTrack SET pass= '" & resultflag & "', testqty='" & txt_testqty.Text &
            "', diffqty='" & txt_diffqty.Text & "', waiveremark='" & rtb_remark.Text & "', endtime='" & Now() & "' WHERE SN='" & UtilizationFormNo & "'"

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

    Private Sub frmUtiCorrClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

End Class