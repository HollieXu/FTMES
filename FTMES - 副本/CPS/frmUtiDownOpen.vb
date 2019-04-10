Public Class frmUtiDownOpen





    Private Sub frmUtiDownOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim myuti As UTILIZATIONTYPE

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor

        txt_FormNo.Text = "UTD" + Format(Now(), "yyyyMMddHHmmss")
        UtilizationFormNo = txt_FormNo.Text '赋值给全局变量，传递到UtilizationTrack主表

        txt_tester.Text = UtilizationIdx

        '带入 DB:UtilizationTrack 上一条稼动信息
        myuti = GetUtiInfoByTester(UtilizationIdx)

        combo_ilot.Text = myuti.ilot
        combo_ilot.Enabled = False
        txt_cust.Text = myuti.cust
        txt_clot.Text = myuti.clot
        txt_prod.Text = myuti.iprod
        txt_step.Text = myuti.iStep
        combo_temp.Text = myuti.temperature
        combo_temp.Enabled = False
        combo_pc.Text = myuti.probecard
        combo_pc.Enabled = False
        txt_pgm.Text = myuti.program




    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String

        mysql = "INSERT INTO UtiDownTrack (SN,tester,iLot,cust,cLot,iprod,step,wqty,Temp,Probecard,PIB,Program,DownWafer,DownXY,starttime) VALUES ( '" &
                txt_FormNo.Text & "','" & UtilizationIdx & "','" & combo_ilot.Text & "','" & txt_cust.Text & "','" & txt_clot.Text &
                "','" & txt_prod.Text & "','" & txt_step.Text & "','" & txt_wqty.Text & "','" & combo_temp.Text & "','" & combo_pc.Text & "','" & combo_pib.Text & "','" & txt_pgm.Text & "','" & txt_downwafer.Text & "','" & txt_downXY.Text & "','" & Now() & "')"

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