Imports System.Data.SqlClient

Public Class frmHoldSet



    Private Sub frmHoldSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10

        txt_head.BackColor = mydefaultcolor

        Me.BackColor = mydefaultcolor
        txt_ERFNo.BackColor = mydefaultcolor
        txt_clot.BackColor = mydefaultcolor
        txt_currstep.BackColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
        txt_iprod.BackColor = mydefaultcolor
        txt_cprod.BackColor = mydefaultcolor
        txt_currqty.BackColor = mydefaultcolor
        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor
        DGV_waferselect.BackgroundColor = mydefaultcolor

        btn_all.BackColor = mydefaultcolor
        btn_clear.BackColor = mydefaultcolor

        combo_ERFtype.Items.Add("测试异常")
        combo_ERFtype.Items.Add("品质异常")

        txt_ilot.Focus()

        Select Case Hold_Operation_Mode

            Case "HOLD"

                '新开立Hold阶段
                txt_operator.Text = UserID

                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = False
                GroupBox4.Enabled = False
                GroupBox5.Enabled = False

            Case "RELEASE"

                GroupBox1.Enabled = False
                txt_ERFNo.Text = myholdlot.HoldSN
                txt_ilot.Text = myholdlot.ilot
                txt_clot.Text = myholdlot.clot
                txt_currstep.Text = myholdlot.holdstep
                txt_cust.Text = myholdlot.cust
                txt_iprod.Text = myholdlot.iprod
                txt_cprod.Text = myholdlot.cprod
                txt_currqty.Text = myholdlot.currqty

                GroupBox2.Enabled = False
                txt_operator.Text = myholdlot.holder
                DTP_holdtime.Value = myholdlot.holdtime
                combo_ERFtype.Text = myholdlot.holdtype
                NUD_holdqty.Value = myholdlot.holdqty
                RTB_holdreason.Text = myholdlot.holdreason

                'hold waferlist 显示
                DGV_waferselect.Rows.Clear()
                DGV_waferselect.Rows.Add(1)
                For i = 0 To 24
                    If myholdlot.holdwaferlist.Substring(i, 1) = "1" Then
                        DGV_waferselect(i, 0).Value = True
                        DGV_waferselect(i, 0).Style.BackColor = Color.Red
                    End If
                Next


                ' 厂内第一步处置
                If myholdlot.owner = "" Then
                    GroupBox3.Enabled = True
                    'txt_owner.Text = UserID
                    GroupBox5.Enabled = True
                Else
                    GroupBox3.Enabled = False
                    txt_owner.Text = myholdlot.owner
                    txt_ownergrp.Text = myholdlot.ownerGrp

                    Select Case myholdlot.itestdisposeflag
                        Case "itest-release"
                            RB_itestrelease.Checked = True
                        Case "inform-customer"
                            rb_informcustomer.Checked = True
                            DTP_informtime.Value = myholdlot.informtime
                    End Select

                    rtb_itestdispose.Text = myholdlot.itestdisposecmd

                End If

                ' 客户第二步处置
                If myholdlot.Custowner = "" Then

                    If rb_informcustomer.Checked = True Then
                        GroupBox4.Enabled = True
                    End If

                Else
                    '  GroupBox4.Enabled = False ' keep hold之后还是会转成release,所以不能disable
                    txt_custowner.Text = myholdlot.Custowner

                    Select Case myholdlot.custdisposeflag
                        Case "cust-release"
                            rb_custrelease.Checked = True
                        Case "cust-hold"
                            rb_custhold.Checked = True
                        Case "cust-other"
                            rb_custother.Checked = True
                    End Select

                    rtb_custdispose.Text = myholdlot.custdisposecmd

                End If

                '结单状态的ERF只能查看
                If myholdlot.status = "close" Then
                    cb_close.Checked = True
                    txt_closer.Text = myholdlot.closer
                    txt_attach.Text = myholdlot.attach
                    GroupBox4.Enabled = False
                    GroupBox5.Enabled = False
                    btn_ok.Enabled = False
                    btn_exit.Enabled = False
                End If

        End Select


    End Sub

    Private Sub txt_ilot_TextChanged(sender As Object, e As EventArgs) Handles txt_ilot.TextChanged

        Dim mysql As String
        Dim mydataset As New DataSet
        Dim waferlist As String
        Dim status As String


        If Hold_Operation_Mode = "HOLD" Then

            If Len(txt_ilot.Text) <> 12 Then
                btn_ok.Enabled = True
                Exit Sub
            End If

            txt_ERFNo.Text = "ERF" + Format(Now(), "yyyyMMddHHmmss")

            mysql = "select * from WIPLOT where iTestLotNo=" & "'" & txt_ilot.Text & "'"

            Dim myadapter As New SqlDataAdapter(mysql, myconn)

            myadapter.Fill(mydataset, "WIP")

            If mydataset.Tables("WIP").Rows.Count = 0 Then
                MsgBox("查询批号信息失败!", vbOKOnly + vbExclamation)
            Else

                txt_clot.Text = mydataset.Tables("WIP").Rows(0).Item("CustLotNo")
                txt_currstep.Text = mydataset.Tables("WIP").Rows(0).Item("CurrentStep")
                txt_currqty.Text = mydataset.Tables("WIP").Rows(0).Item("CurrentWaferQty")
                waferlist = mydataset.Tables("WIP").Rows(0).Item("WaferList")
                txt_cust.Text = mydataset.Tables("WIP").Rows(0).Item("CUSTENG")
                txt_iprod.Text = mydataset.Tables("WIP").Rows(0).Item("iTestProduct")
                txt_cprod.Text = mydataset.Tables("WIP").Rows(0).Item("CustProduct")
                status = mydataset.Tables("WIP").Rows(0).Item("Status")

            End If

            '当批次片号填充,空白片Enable设置为False
            DGV_waferselect.Rows.Clear()
            DGV_waferselect.Rows.Add(1)
            For i = 0 To 24
                If waferlist.Substring(i, 1) = "0" Then
                    DGV_waferselect(i, 0).ReadOnly = True
                    DGV_waferselect(i, 0).Style.BackColor = Color.SlateGray
                End If
            Next


            '只有CHECKIN / CHECKOUT / WAIT 三种状态可以Hold

            If InStr("-CHECKIN-CHECKOUT-WAIT-", status) = 0 Then
                MsgBox("该批次状态为: " & status & " , 不可执行Hold作业!", vbOKOnly + vbExclamation)
                btn_ok.Enabled = False
            End If

        End If


    End Sub

    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click

        If DGV_waferselect.Rows.Count = 0 Then Exit Sub
        For i = 0 To 24
            If DGV_waferselect(i, 0).ReadOnly = False Then
                DGV_waferselect(i, 0).Value = True
            End If
        Next
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If DGV_waferselect.Rows.Count = 0 Then Exit Sub
        For i = 0 To 24
            If DGV_waferselect(i, 0).ReadOnly = False Then
                DGV_waferselect(i, 0).Value = False
            End If
        Next
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click


        Dim mysql As String
        Dim holdwaferlist As String
        Dim iTestDisposeFlag As String, CustDisposeFlag As String, Status As String


        '插入ERFHold表
        If Hold_Operation_Mode = "HOLD" Then

            'User填入值正确性校验
            If combo_ERFtype.Text = "" Then
                MsgBox("异常类型未设定!", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            'Hold wafer List format
            For i = 0 To 24
                If DGV_waferselect(i, 0).ReadOnly = True Then
                    holdwaferlist += "0"
                Else
                    If DGV_waferselect(i, 0).Value = True Then
                        holdwaferlist += "1"
                    Else
                        holdwaferlist += "0"
                    End If
                End If
            Next

            mysql = "INSERT INTO ERFHold (HoldSN,iTestLotNo,CustLotNo,Status,CUSTENG,iTestProduct,CustProduct,HoldStep,CurrentQTY,HoldQTY,HoldWaferlist,HoldTime,Holder,HoldType,HoldReason) VALUES ( '" &
                txt_ERFNo.Text & "','" & txt_ilot.Text & "','" & txt_clot.Text & "','" & "ongoing" & "','" & txt_cust.Text & "','" & txt_iprod.Text & "','" &
                txt_cprod.Text & "','" & txt_currstep.Text & "','" & txt_currqty.Text & "','" & NUD_holdqty.Text & "','" & holdwaferlist & "','" & DTP_holdtime.Value & "','" & txt_operator.Text & "','" & combo_ERFtype.Text & "','" & RTB_holdreason.Text & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

            'Update WIPLOT表 Status为HOLD.
            If SetWIPLotStatus(txt_ilot.Text, txt_currstep.Text, "HOLD") = True Then
                MsgBox("Hold设定完成 !", vbOKOnly + vbInformation)
            Else
                MsgBox("在设定主表WIPLOT为Hold状态时发生异常,请联系PTE确认!", vbOKOnly + vbExclamation)
                Exit Sub
            End If


        ElseIf Hold_Operation_Mode = "RELEASE" Then

            '厂内第一步处置信息插入DB
            If txt_owner.Text <> "" Then

                If rtb_itestdispose.Text = "" Then
                    MsgBox("厂内处置意见未填写!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                If RB_itestrelease.Checked = True Then
                    iTestDisposeFlag = "itest-release"
                End If

                If rb_informcustomer.Checked = True Then
                    iTestDisposeFlag = "inform-customer"
                End If

                mysql = "UPDATE  ERFHold SET Owner= '" & txt_owner.Text & "', OwnerGrp='" & txt_ownergrp.Text & "', iTestDisposeFlag='" & iTestDisposeFlag & "', iTestDisposeCmd='" & rtb_itestdispose.Text & "' WHERE HoldSN='" & txt_ERFNo.Text & "'"
                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()
                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()

                '通知客户时间插入DB
                If iTestDisposeFlag = "inform-customer" Then

                    mysql = "UPDATE  ERFHold SET InformTime= '" & DTP_informtime.Value & "' WHERE HoldSN='" & txt_ERFNo.Text & "'"
                    Dim mycmd2 As New SqlClient.SqlCommand(mysql, myconn)
                    myconn.Open()
                    Try
                        mycmd2.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    myconn.Close()

                End If


            End If


            '客户第二步处置信息插入DB
            If txt_custowner.Text <> "" Then

                If rtb_custdispose.Text = "" Then
                    MsgBox("客户处置意见未填写!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                If rb_custrelease.Checked = True Then
                    CustDisposeFlag = "cust-release"
                End If

                If rb_custhold.Checked = True Then
                    CustDisposeFlag = "cust-hold"
                End If

                If rb_custother.Checked = True Then
                    CustDisposeFlag = "cust-other"
                End If

                mysql = "UPDATE  ERFHold SET CustOwner= '" & txt_custowner.Text & "', CustDisposeFlag='" & CustDisposeFlag & "', CustDisposeCmd='" & rtb_custdispose.Text & "' WHERE HoldSN='" & txt_ERFNo.Text & "'"
                Dim mycmd3 As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()
                Try
                    mycmd3.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                myconn.Close()

            End If

            '第三步结单信息插入DB

            If cb_close.Checked = True Then
                Status = "close"
                '通知到客户之异常结单必须上传附件
                If txt_custowner.Text <> "" And txt_attach.Text = "" Then
                    MsgBox("客户处理之异常必须附上相关附件!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            Else
                Status = "ongoing"
            End If

            mysql = "UPDATE  ERFHold SET attach = '" & txt_attach.Text & "', Status='" & Status & "', closer='" & txt_closer.Text & "', closeTime='" & Now() & "' WHERE HoldSN='" & txt_ERFNo.Text & "'"
            Dim mycmd4 As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd4.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

            'Update WIPLOT表 Status为当前站别的CHECKIN.
            If cb_close.Checked = True Then
                If SetWIPLotStatus(txt_ilot.Text, txt_currstep.Text, "CHECKIN") = True Then
                    MsgBox("Hold已解除 !", vbOKOnly + vbInformation)
                Else
                    MsgBox("在设定主表WIPLOT为CHECKIN状态时发生异常,请联系PTE确认!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

        End If

        Call frmHold.btn_Query_Click("", e)
        Me.Close()

    End Sub

    Private Sub btn_cal_Click(sender As Object, e As EventArgs) Handles btn_cal.Click
        If DGV_waferselect.Rows.Count = 0 Then Exit Sub
        Dim holdqty As Integer

        For i = 0 To 24
            If DGV_waferselect(i, 0).ReadOnly = False Then
                If DGV_waferselect(i, 0).Value = True Then
                    holdqty += 1
                End If
            End If
        Next

        NUD_holdqty.Value = holdqty

        If holdqty = 0 Then
            MsgBox("注意: 异常片数为0!", vbOKOnly + vbExclamation)
            Exit Sub
        End If



    End Sub

    Private Sub txt_owner_TextChanged(sender As Object, e As EventArgs) Handles txt_owner.TextChanged
        'If Len(txt_owner.Text) = 9 Then
        '    txt_ownergrp.Text = GetEmployeeGrpbyID(UserID)
        'End If
    End Sub

    Private Sub rb_informcustomer_CheckedChanged(sender As Object, e As EventArgs) Handles rb_informcustomer.CheckedChanged

        If rb_informcustomer.Checked = True Then
            GroupBox4.Enabled = True
        Else
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub cb_close_CheckedChanged(sender As Object, e As EventArgs) Handles cb_close.CheckedChanged
        If cb_close.Checked = True Then
            txt_closer.Text = UserID
        End If
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\HoldSet\"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            sourcefile = OpenFileDialog1.FileName

            If InStr(sourcefile, " ") > 0 Then
                MsgBox("文件名包含空格!,请修改后上传", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            destfile += Format(Now(), "yyyyMMddHHmmss") + "_" + System.IO.Path.GetFileName(sourcefile)

            '文件复制
            FileCopy(sourcefile, destfile)

            ' txt_wopath.Text = destfile
            txt_attach.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")

            MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If


    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        Dim sourcefile As String, destfile As String

        'sourcefile = txt_wopath.Text
        sourcefile = Replace(txt_attach.Text, "CPMES-SERVER", "10.10.31.99")

        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub


    Private Sub txt_ownergrp_DropDown(sender As Object, e As EventArgs) Handles txt_ownergrp.DropDown

        'Dim i As Integer

        'Dim mysql As String
        'Dim mydataset As New DataSet

        'mysql = "select DISTINCT Department from Employee"

        'Dim myadapter As New SqlDataAdapter(mysql, myconn)

        'myadapter.Fill(mydataset, "Grp")

        'If mydataset.Tables("Grp").Rows.Count = 0 Then
        '    txt_ownergrp.Items.Add("Query Fail")
        'Else

        '    txt_ownergrp.Items.Clear()

        '    For i = 0 To mydataset.Tables("Grp").Rows.Count - 1
        '        txt_ownergrp.Items.Add(mydataset.Tables("Grp").Rows(i).Item("Department"))
        '    Next

        '    txt_ownergrp.Text = "*"

        'End If

        txt_ownergrp.Items.Clear()
        txt_ownergrp.Items.Add(GetEmployeeGrpbyID(txt_owner.Text))



    End Sub



End Class