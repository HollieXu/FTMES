Imports System.Data.SqlClient

Public Class frmUtiSetupClose



    Private Sub frmUtiSetupClose_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql As String
        Dim mydataset As New DataSet


        Me.Left = 10
        Me.Height = 10
        Me.BackColor = mydefaultcolor
        Me.WindowState = FormWindowState.Normal
        Me.Height = 760

        '查询DB: UtiSetupTrack 并显示机台当前状态
        txt_FormNo.Text = UtilizationFormNo
        txt_tester.Text = UtilizationIdx

        mysql = "select * from UtiSetupTrack where SN = '" & UtilizationFormNo & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "SETUP")

        If mydataset.Tables("SETUP").Rows.Count = 0 Then

        Else
            combo_ilot.Text = mydataset.Tables("SETUP").Rows(0).Item("iLot")
            combo_ilot.Enabled = False
            txt_cust.Text = mydataset.Tables("SETUP").Rows(0).Item("cust")
            txt_clot.Text = mydataset.Tables("SETUP").Rows(0).Item("cLot")
            txt_prod.Text = mydataset.Tables("SETUP").Rows(0).Item("iprod")
            txt_step.Text = mydataset.Tables("SETUP").Rows(0).Item("step")
            txt_wqty.Text = mydataset.Tables("SETUP").Rows(0).Item("wqty").ToString
            combo_temp.Text = mydataset.Tables("SETUP").Rows(0).Item("Temp").ToString
            combo_temp.Enabled = False
            combo_tempchange.Text = mydataset.Tables("SETUP").Rows(0).Item("TempChange").ToString
            combo_tempchange.Enabled = False
            combo_pc.Text = mydataset.Tables("SETUP").Rows(0).Item("Probecard").ToString
            combo_pc.Enabled = False
            combo_pib.Text = mydataset.Tables("SETUP").Rows(0).Item("PIB").ToString
            combo_pib.Enabled = False
            txt_pgm.Text = mydataset.Tables("SETUP").Rows(0).Item("Program").ToString

        End If

        ' Setup 结单参数设定

        DGV_setup.Rows.Add(10)
        DGV_setup.Columns(0).ReadOnly = True

        DGV_setup(0, 0).Value = "First pin contact Z height (第1根pin pass Z高度)"
        DGV_setup(0, 1).Value = "Full pin contact Z height (所有 pin pass Z高度)"
        DGV_setup(0, 2).Value = "DC (水平值)"
        DGV_setup(0, 3).Value = "Over Drive (测试针压)"
        DGV_setup(0, 4).Value = "Probe Mark Setup Die (试打坐标)"
        DGV_setup(0, 5).Value = "Index Measure Result (Index量测结果)"

        DGV_setup.Columns(1).DefaultCellStyle.ForeColor = Color.Blue

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String
        Dim FirstOD As String, FullOD As String, DC As String, OD As String, ProbeMarkCoor As String, IndexResult As String

        FirstOD = DGV_setup(1, 0).Value
        FullOD = DGV_setup(1, 1).Value
        DC = DGV_setup(1, 2).Value
        OD = DGV_setup(1, 3).Value
        ProbeMarkCoor = DGV_setup(1, 4).Value
        IndexResult = DGV_setup(1, 5).Value


        mysql = "UPDATE  UtiSetupTrack SET FirstpinOD= '" & FirstOD & "', FullpinOD='" & FullOD &
            "', DC='" & DC & "', OD='" & OD & "', ProbeMarkCheckDieXY='" & ProbeMarkCoor & "', IndexMeas='" & IndexResult & "', endtime='" & Now() & "' WHERE SN='" & UtilizationFormNo & "'"

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