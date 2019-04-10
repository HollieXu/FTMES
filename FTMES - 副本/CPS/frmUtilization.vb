Imports System.Data.SqlClient

Public Class frmUtilization


    Public CurrentStatusSN As Long
    Public CurrentStatus As String
    Public CurrentStatusFormNo As String
    Public CurrStatusStart As Date

    Public NextStatus As String

    Private Sub frmUtilization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10
        Me.Width = 500
        Me.BackColor = mydefaultcolor
        btn_spread.BackColor = mydefaultcolor

        txt_op.Text = UserID

        Dim mysql As String
        Dim mydataset As New DataSet

        '查询DB并显示机台当前状态

        Label1.Text = UtilizationIdx

        mysql = "select * from UtilizationTrack where testerid = '" & UtilizationIdx & "' ORDER BY SN DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Track")

        If mydataset.Tables("Track").Rows.Count = 0 Then
            Label2.Text = "NA"
            Label3.Text = "NA"
            Label4.Text = "NA"
            Label5.Text = "NA"
            Label6.Text = "NA"
            Label7.Text = "NA"
            Label8.Text = "NA"
            Label9.Text = "NA"
            Label10.Text = "NA"
            Label11.Text = "NA"
            Label12.Text = "NA"
        Else
            CurrentStatusSN = mydataset.Tables("Track").Rows(0).Item("SN")

            CurrentStatus = mydataset.Tables("Track").Rows(0).Item("Status").ToString
            Label2.Text = CurrentStatus

            Label3.Text = mydataset.Tables("Track").Rows(0).Item("Detail").ToString

            CurrStatusStart = mydataset.Tables("Track").Rows(0).Item("StartTime")
            Label4.Text = CurrStatusStart

            CurrentStatusFormNo = mydataset.Tables("Track").Rows(0).Item("FormNo").ToString

            Label5.Text = DateDiff(DateInterval.Minute, mydataset.Tables("Track").Rows(0).Item("StartTime"), Now())

            Label6.Text = mydataset.Tables("Track").Rows(0).Item("Cust").ToString
            Label7.Text = mydataset.Tables("Track").Rows(0).Item("iprod").ToString
            Label8.Text = mydataset.Tables("Track").Rows(0).Item("iLot").ToString
            Label9.Text = mydataset.Tables("Track").Rows(0).Item("step").ToString
            Label10.Text = mydataset.Tables("Track").Rows(0).Item("ProbeCard").ToString
            Label11.Text = mydataset.Tables("Track").Rows(0).Item("Program").ToString
            Label12.Text = mydataset.Tables("Track").Rows(0).Item("Temperature").ToString

        End If


    End Sub


    Private Sub combo_detail_DropDown(sender As Object, e As EventArgs) Handles combo_detail.DropDown

        Dim temparray() As String
        temparray = GetUtilizationDetail(GetSelectStatus)

        combo_detail.Text = ""
        combo_reason.Text = ""
        combo_detail.Items.Clear()

        For i = 0 To UBound(temparray) - 1
            combo_detail.Items.Add(temparray(i))
        Next

    End Sub

    Private Sub combo_reason_DropDown(sender As Object, e As EventArgs) Handles combo_reason.DropDown

        Dim temparray() As String
        temparray = GetUtilizationReason(GetSelectStatus)

        combo_reason.Text = ""
        combo_reason.Items.Clear()

        For i = 0 To UBound(temparray) - 1
            combo_reason.Items.Add(temparray(i))
        Next


    End Sub


    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click

        Dim mysql As String
        Dim myuti As UTILIZATIONTYPE

        NextStatus = GetSelectStatus()


        '转换人员信息确认,目前并没有卡密码正确性，后续可加上证照卡关
        If txt_op.Text = "" Or txt_pwd.Text = "" Then
            MsgBox("OP & PWD栏位不可为空!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        If combo_detail.Text = "" Or combo_reason.Text = "" Then
            MsgBox("Detail(细项) & Reason(原因) 不能为空!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        Me.WindowState = FormWindowState.Minimized

        '当前状态先进行结单作业
        UtilizationFormNo = CurrentStatusFormNo '获取当前状态的FormNo

        If CloseCurrentStatus(CurrentStatus) = False Then
            MsgBox("当前状态结单取消!", vbOKOnly + vbExclamation)
            Me.WindowState = FormWindowState.Normal
            Exit Sub
        Else

            'Update UtilizationTrack表

            mysql = "UPDATE  UtilizationTrack SET EndTime= '" & Now() & "', EndOP='" & txt_op.Text & "', StatusMinutes='" & DateDiff(DateInterval.Minute, CurrStatusStart, Now()) & "' WHERE SN='" & CurrentStatusSN & "'"
            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

        End If


        '下一状态开单作业
        UtilizationFormNo = "" '初始化

        If OpenNextStatus(NextStatus) = False Then
            MsgBox("下一状态转换取消!", vbOKOnly + vbExclamation)
            Me.WindowState = FormWindowState.Normal
            Exit Sub
        Else

            'Update UtilizationTrack表

            '先取得下一状态开单信息
            myuti = GetUtiInfoByFormNo(NextStatus, UtilizationFormNo)

            mysql = "INSERT INTO UtilizationTrack (testerid,Status,Detail,StartTime,StartOP,FormNo,Cust,iprod,iLot,step,ProbeCard,Program,Temperature) VALUES ( '" & UtilizationIdx & "','" & NextStatus & "','" & combo_detail.Text & "','" & Now() & "','" & txt_op.Text & "','" & UtilizationFormNo &
            "','" & myuti.cust & "','" & myuti.iprod & "','" & myuti.ilot & "','" & myuti.iStep & "','" & myuti.probecard & "','" & myuti.program & "','" & myuti.temperature & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

        End If

        '转换完成
        Me.Close()

    End Sub





    Public Function GetSelectStatus() As String

        If rb_clean.Checked = True Then GetSelectStatus = "CLEAN"
        If rb_corr.Checked = True Then GetSelectStatus = "CORR"
        If rb_setup.Checked = True Then GetSelectStatus = "SETUP"
        If rb_run.Checked = True Then GetSelectStatus = "RUN"
        If rb_rework.Checked = True Then GetSelectStatus = "REWORK"
        If rb_idle.Checked = True Then GetSelectStatus = "IDLE"
        If rb_down.Checked = True Then GetSelectStatus = "DOWN"
        If rb_other.Checked = True Then GetSelectStatus = "OTHER"
        If rb_pm.Checked = True Then GetSelectStatus = "PM"
        If rb_ei.Checked = True Then GetSelectStatus = "EI"
        If rb_eo.Checked = True Then GetSelectStatus = "EO"

    End Function



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_spread_Click(sender As Object, e As EventArgs) Handles btn_spread.Click
        Me.Width = 1100
    End Sub
End Class