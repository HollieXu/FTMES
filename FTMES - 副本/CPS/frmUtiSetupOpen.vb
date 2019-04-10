
Public Class frmUtiSetupOpen

    Private Sub frmUtiSetupOpen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor

        txt_FormNo.Text = "UTS" + Format(Now(), "yyyyMMddHHmmss")
        UtilizationFormNo = txt_FormNo.Text '赋值给全局变量，传递到UtilizationTrack主表

        txt_tester.Text = UtilizationIdx

        combo_temp.Items.Clear()
        combo_temp.Items.Add("RoomTemp-常温")
        combo_temp.Items.Add("HighTemp-高温")
        combo_temp.Items.Add("ColdTemp-低温")

        combo_tempchange.Items.Clear()
        combo_tempchange.Items.Add("No Change 无转换")
        combo_tempchange.Items.Add("Change to Hot Temp 切换到高温")
        combo_tempchange.Items.Add("Change to Room Temp 切换到常温")
        combo_tempchange.Items.Add("Change to Cold Temp 切换到低温")

    End Sub

    Private Sub combo_ilot_TextChanged(sender As Object, e As EventArgs) Handles combo_ilot.TextChanged

        If Len(combo_ilot.Text) <> 12 Then Exit Sub

        combo_ilot.Text = UCase(combo_ilot.Text)

        Dim lotstatus As WIPLOTTYPE

        lotstatus = GetLotStatusByIlot(combo_ilot.Text)

        txt_cust.Text = lotstatus.custeng
        txt_clot.Text = lotstatus.clot
        txt_prod.Text = lotstatus.iprod
        txt_step.Text = lotstatus.CurrentStep
        txt_wqty.Text = lotstatus.currentwaferqty

    End Sub



    Private Sub combo_pc_DropDown(sender As Object, e As EventArgs) Handles combo_pc.DropDown

        Dim assyarray() As String

        assyarray = GetReleaseAssyList(txt_prod.Text, txt_step.Text)

        combo_pc.Items.Clear()
        For i = 0 To UBound(assyarray) - 1
            If Len(assyarray(i)) = 14 Then combo_pc.Items.Add(assyarray(i))  ' 14码长度为ProbeCard编号
        Next

    End Sub


    Private Sub combo_pib_DropDown(sender As Object, e As EventArgs) Handles combo_pib.DropDown

        Dim assyarray() As String

        assyarray = GetReleaseAssyList(txt_prod.Text, txt_step.Text)
        combo_pib.Items.Clear()
        For i = 0 To UBound(assyarray) - 1
            If Len(assyarray(i)) < 12 Then combo_pib.Items.Add(assyarray(i))  ' LoadBoard编码<12码.
        Next

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String

        If combo_ilot.Text = "" Then
            MsgBox("请先输入批号!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        mysql = "INSERT INTO UtiSetupTrack (SN,tester,iLot,cust,cLot,iprod,step,wqty,Temp,TempChange,Probecard,PIB,Program,starttime) VALUES ( '" &
                txt_FormNo.Text & "','" & UtilizationIdx & "','" & combo_ilot.Text & "','" & txt_cust.Text & "','" & txt_clot.Text &
                "','" & txt_prod.Text & "','" & txt_step.Text & "','" & txt_wqty.Text & "','" & combo_temp.Text & "','" & combo_tempchange.Text & "','" & combo_pc.Text & "','" & combo_pib.Text & "','" & txt_pgm.Text & "','" & Now() & "')"

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