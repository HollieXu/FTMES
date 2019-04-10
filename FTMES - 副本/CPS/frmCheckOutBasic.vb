Public Class frmCheckOutBasic

    Private Sub frmCheckOutBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        '颜色/位置设定
        Me.BackColor = mydefaultcolor
        GroupBox4.BackColor = mydefaultcolor
        GroupBox5.BackColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
        txt_prod.BackColor = mydefaultcolor
        txt_ilot.BackColor = mydefaultcolor
        txt_clot.BackColor = mydefaultcolor
        txt_wqty.BackColor = mydefaultcolor
        txt_lastrecipeid.BackColor = mydefaultcolor
        txt_laststep.BackColor = mydefaultcolor
        txt_nextrecipeid.BackColor = mydefaultcolor
        txt_nextstep.BackColor = mydefaultcolor

        Me.Left = 10
        Me.Top = 10

        'Wafer选择表格行数设置
        DGV_WaferList.Visible = True

        For i = 0 To 24
            If mycheckio.waferlist.Substring(i, 1) = "1" Then
                DGV_WaferList(i, 0).Value = True
            End If
        Next

        '产品信息代入
        txt_cust.Text = mycheckio.custeng
        txt_prod.Text = mycheckio.iprod
        txt_ilot.Text = mycheckio.ilot
        txt_clot.Text = mycheckio.clot
        txt_wqty.Text = mycheckio.waferqty

        '站别信息带入
        txt_flowid.Text = mycheckio.flowid
        txt_currstep.Text = mycheckio.CurrentStep
        txt_currstatus.Text = mycheckio.status

        For i = 1 To UBound(mystep) - 1
            If mystep(i).name = mycheckio.CurrentStep Then '注意: 若同一个站别出现多次，会取最后一次出现的信息，所以此处并未用 exit for 跳出.
                txt_currrecipeid.Text = mystep(i).id

                If i > 1 Then
                    txt_laststep.Text = mystep(i - 1).name
                    txt_lastrecipeid.Text = mystep(i - 1).id
                End If

                If i < UBound(mystep) - 1 Then
                    txt_nextstep.Text = mystep(i + 1).name
                    txt_nextrecipeid.Text = mystep(i + 1).id
                End If

            End If
        Next



        ' 各站别 ParaInput 参数设定

        DGV_ParaInput.AllowUserToAddRows = False
        DGV_ParaInput.Rows.Add(10)

        Select Case mycheckio.CurrentStep


            Case "CP1DT", "CP2DT", "CP3DT", "CP4DT", "CP5DT", "CP6DT", "CP7DT", "CP8DT", "CP9DT"

            Case "WIPFS"

                DGV_ParaInput(0, 0).Value = "Yield"
                DGV_ParaInput(0, 1).Value = "FinalGoodDie"
                DGV_ParaInput(0, 2).Value = "GrossDie"

            Case Else

        End Select








    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim i As Integer

        ' 各站别 ParaInput 参数采集插入数据库

        Select Case mycheckio.CurrentStep

            Case "CP1DT", "CP2DT", "CP3DT", "CP4DT", "CP5DT", "CP6DT", "CP7DT", "CP8DT", "CP9DT"


            Case "WIPFS"

                If DGV_ParaInput(1, 0).Value = "" Then
                    MsgBox("Yield参数未填写!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                If DGV_ParaInput(1, 1).Value = "" Then
                    MsgBox("FinalGoodDie参数未填写!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                If DGV_ParaInput(1, 2).Value = "" Then
                    MsgBox("GrossDie参数未填写!", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                If DGV_ParaInput(1, 1).Value / DGV_ParaInput(1, 2).Value > 0.01 Then
                    If DGV_ParaInput(1, 0).Value < 1 Then
                        MsgBox("良率格式填写错误!" & vbCrLf & "1.良率范围 0 -100,如96.5" & vbCrLf & "2.可含小数部分，如96.56" & vbCrLf & "3.不带%符号", vbOKOnly + vbExclamation)
                        Exit Sub
                    End If
                End If


                '插入ShipDetail 记录表
                If SetLotFinalGoodDie(mycheckio.ilot, DGV_ParaInput(1, 0).Value, DGV_ParaInput(1, 1).Value, DGV_ParaInput(1, 2).Value) = False Then
                    MsgBox("Check OUT 失败,ShipDetail 记录表 FAIL,无法出站!", vbOKOnly + vbExclamation)
                    Exit Sub
                Else
                    ' do nothing
                End If

            Case Else

        End Select





        '插入LOTTRACK 记录表
        If SetLotTrackOUT(mycheckio.ilot, mycheckio.flowid, txt_currrecipeid.Text, mycheckio.CurrentStep, "", UserID) = False Then
            MsgBox("Check OUT 失败,插入LOTTRACK 记录表 FAIL,无法出站!", vbOKOnly + vbExclamation)
            Exit Sub
        Else
            ' do nothing
        End If

        '更新WIPLOT表 Status 为 下一站的CHECK IN
        If SetWIPLotStatus(mycheckio.ilot, txt_nextstep.Text, "CHECKIN") = False Then
            MsgBox("Check OUT 失败,更新WIPLOT表 Status 为 下一站CHECK IN 时 FAIL,无法出站!", vbOKOnly + vbExclamation)
            Exit Sub
        Else
            'do nothing
        End If

        Call frmCheckIO.btn_Query_Click("", e)

        MsgBox("Check Out 成功", vbOKOnly + vbInformation)
        Me.Close()


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub


End Class