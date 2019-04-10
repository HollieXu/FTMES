Imports System.Data.SqlClient



Public Class frmSplitLot

    Dim mylot As WIPLOTTYPE

    Private Sub frmSplitLot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
        DGV_WaferList.BackgroundColor = mydefaultcolor
        txt_ilot.Focus()
    End Sub

    Private Sub txt_ilot_TextChanged(sender As Object, e As EventArgs) Handles txt_ilot.TextChanged

        Dim mysql As String
        Dim mydataset As New DataSet

        If Len(txt_ilot.Text) <> 12 Then
            btn_splitlot.Enabled = True
            Exit Sub
        End If

        mysql = "select * from WIPLOT where iTestLotNo=" & "'" & txt_ilot.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            MsgBox("查询批号信息失败!", vbOKOnly + vbExclamation)
        Else

            mylot.custeng = mydataset.Tables("WIP").Rows(0).Item("CUSTENG")
            mylot.iprod = mydataset.Tables("WIP").Rows(0).Item("iTestProduct")
            mylot.ilot = mydataset.Tables("WIP").Rows(0).Item("iTestLotNo")
            mylot.clot = mydataset.Tables("WIP").Rows(0).Item("CustLotNo")
            mylot.prodtype = mydataset.Tables("WIP").Rows(0).Item("ProductType")
            mylot.priority = mydataset.Tables("WIP").Rows(0).Item("Priority")
            mylot.CurrentStep = mydataset.Tables("WIP").Rows(0).Item("CurrentStep")
            mylot.status = mydataset.Tables("WIP").Rows(0).Item("Status")
            mylot.waferqty = mydataset.Tables("WIP").Rows(0).Item("ReceivingWaferQty")
            mylot.currentwaferqty = mydataset.Tables("WIP").Rows(0).Item("CurrentWaferQty")
            If IsDBNull(mydataset.Tables("WIP").Rows(0).Item("DieQty")) = True Then
                mylot.dieqty = 0
            Else
                mylot.dieqty = mydataset.Tables("WIP").Rows(0).Item("DieQty")
            End If
            mylot.waferlist = mydataset.Tables("WIP").Rows(0).Item("WaferList").ToString
            mylot.location = mydataset.Tables("WIP").Rows(0).Item("Location").ToString
            mylot.custid = mydataset.Tables("WIP").Rows(0).Item("CUSTID").ToString
            mylot.custchn = mydataset.Tables("WIP").Rows(0).Item("CUSTCHN").ToString
            mylot.itestorder = mydataset.Tables("WIP").Rows(0).Item("iTestOrder").ToString
            mylot.receivingExNo = mydataset.Tables("WIP").Rows(0).Item("ReceivingExpressNo").ToString
            mylot.custorder = mydataset.Tables("WIP").Rows(0).Item("CustOrder").ToString
            mylot.custorderseq = mydataset.Tables("WIP").Rows(0).Item("CustOrderSequence")
            mylot.orderdate = mydataset.Tables("WIP").Rows(0).Item("OrderDate")
            mylot.requiredate = mydataset.Tables("WIP").Rows(0).Item("RequireDate")
            mylot.receivingdate = mydataset.Tables("WIP").Rows(0).Item("ReceivingDate")
            mylot.bonded = mydataset.Tables("WIP").Rows(0).Item("bonded")
            mylot.flot = mydataset.Tables("WIP").Rows(0).Item("FabLotNo")
            mylot.slot = mydataset.Tables("WIP").Rows(0).Item("ShipLotNo")
            mylot.cprod = mydataset.Tables("WIP").Rows(0).Item("CustProduct")
            mylot.fprod = mydataset.Tables("WIP").Rows(0).Item("FabProduct")
            mylot.sprod = mydataset.Tables("WIP").Rows(0).Item("ShipProduct")
            mylot.code = mydataset.Tables("WIP").Rows(0).Item("CODE").ToString
            mylot.remark = mydataset.Tables("WIP").Rows(0).Item("Remark").ToString
            mylot.orderfile = mydataset.Tables("WIP").Rows(0).Item("OrderFile").ToString


            txt_clot.Text = mylot.clot
            txt_prod.Text = mylot.iprod
            txt_cust.Text = mylot.custeng
            txt_currstep.Text = mylot.CurrentStep
            txt_currstatus.Text = mylot.status
            txt_wqty.Text = mylot.waferqty
            txt_currqty.Text = mylot.currentwaferqty

        End If

        '只有CHECKIN 和 CHECKOUT 两种状态可以分批

        If mylot.status <> "CHECKIN" And mylot.status <> "CHECKOUT" Then
            MsgBox("该批次状态为: " & mylot.status & " , 不可执行分批作业!", vbOKOnly + vbExclamation)
            btn_splitlot.Enabled = False
        End If



    End Sub

    Private Sub btn_splitlot_Click(sender As Object, e As EventArgs) Handles btn_splitlot.Click

        Dim m As Integer
        Dim i As Integer
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim LatestLot As String, LatestLotChar As String, NewLotChar As String

        '批号状态确认
        If mylot.status = "SMDONE" Then
            MsgBox("此批货已被分批或合批，请以新批号作业!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        m = NUD_lots.Value

        '批数正确性确认
        If mylot.currentwaferqty < m Then
            MsgBox("当前片数不足以分成 " & m & " 批", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        DGV_WaferList.Rows.Clear()
        DGV_WaferList.Rows.Add(m + 1)

        '母批信息展示
        DGV_WaferList(0, 0).Value = mylot.ilot
        DGV_WaferList(0, 0).Style.BackColor = Color.Gray
        DGV_WaferList(0, 0).Style.ForeColor = Color.AliceBlue
        DGV_WaferList(1, 0).Value = mylot.currentwaferqty
        DGV_WaferList(1, 0).Style.BackColor = Color.Gray
        DGV_WaferList(1, 0).Style.ForeColor = Color.AliceBlue

        For i = 0 To 24
            DGV_WaferList(i + 2, 0).ReadOnly = True
            DGV_WaferList(i + 2, 0).Style.BackColor = Color.Gray
            If mylot.waferlist.Substring(i, 1) = "1" Then
                DGV_WaferList(i + 2, 0).Value = True
            End If
        Next

        '子批批号生成

        mysql = "select iTestLotNo from WIPLOT where iTestLotNo like " & "'%" & Strings.Left(mylot.ilot, 10) & "%' ORDER BY iTestLotNo DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            MsgBox("查询批号信息失败!", vbOKOnly + vbExclamation)
        Else
            LatestLot = mydataset.Tables("WIP").Rows(0).Item("iTestLotNo")
        End If

        If LatestLot.Substring(10, 2) = "A0" Then
            NewLotChar = "A"
        Else
            LatestLotChar = LatestLot.Substring(10, 1)
            NewLotChar = Chr(Asc(LatestLotChar) + 1)
        End If


        For i = 1 To m
            DGV_WaferList(0, i).Value = Strings.Left(mylot.ilot, 10) + NewLotChar + CStr(i)
        Next


    End Sub


    Private Sub btn_verify_Click(sender As Object, e As EventArgs) Handles btn_verify.Click

        Dim m As Integer, i As Integer
        Dim currentqty As Integer, Totalqty As Integer
        Dim waferidx As Integer, splitidx As Integer

        For m = 1 To NUD_lots.Value

            currentqty = 0

            For i = 0 To 24
                If DGV_WaferList(i + 2, m).Value = True Then
                    currentqty += 1
                End If
            Next

            DGV_WaferList(1, m).Value = currentqty

            If currentqty = 0 Then
                MsgBox("存在总片数为0的子批!", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            Totalqty += currentqty
        Next

        '总片数校验
        If mylot.currentwaferqty <> Totalqty Then
            MsgBox("子批总片数与母批总批数不一致!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        '单片勾选校验

        For i = 0 To 24

            waferidx = 0
            splitidx = 0

            If DGV_WaferList(i + 2, 0).Value = True Then
                waferidx = 1
            End If

            For m = 1 To NUD_lots.Value
                If DGV_WaferList(i + 2, m).Value = True Then
                    splitidx += 1
                End If
            Next

            If waferidx <> splitidx Then
                MsgBox("第 " & i + 1 & " 片勾选状态异常!", vbOKOnly + vbExclamation)
                Exit Sub
            End If

        Next

        btn_ok.Enabled = True

    End Sub



    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim mysql As String
        Dim m As Integer, i As Integer
        Dim splitlot As String, splitqty As Integer, splitwaferstr As String


        '将子批信息插入DB

        For m = 1 To NUD_lots.Value

            splitlot = DGV_WaferList(0, m).Value
            splitqty = DGV_WaferList(1, m).Value
            splitwaferstr = ""

            For i = 0 To 24
                If DGV_WaferList(i + 2, m).Value = True Then
                    splitwaferstr += "1"
                Else
                    splitwaferstr += "0"
                End If
            Next

            '子批插入DB时,状态统一改为CHECKIN，如果原母批状态为CHECKOUT，则需要重新进站.

            mysql = "INSERT INTO WIPLOT (CUSTENG,CUSTID,CUSTCHN,iTestOrder,ReceivingExpressNo,CustOrder,CustOrderSequence,OrderDate,RequireDate,ReceivingDate,ProductType,
                    Priority,bonded,iTestLotNo,CustLotNo,FabLotNo,ShipLotNo,iTestProduct,CustProduct,FabProduct,ShipProduct,ReceivingWaferQty,CurrentWaferQty,WaferList,CODE,OrderFile,Remark,CurrentStep,Status,Location,Enable,CreateTime,Creater) VALUES ( '" &
                mylot.custeng & "','" & mylot.custid & "','" & mylot.custchn & "','" & mylot.itestorder & "','" & mylot.receivingExNo & "','" & mylot.custorder & "','" & mylot.custorderseq & "','" & mylot.orderdate & "','" & mylot.requiredate & "','" & mylot.receivingdate & "','" & mylot.prodtype & "','" &
                mylot.priority & "','" & mylot.bonded & "','" & splitlot & "','" & mylot.clot & "','" & mylot.flot & "','" & mylot.slot & "','" & mylot.iprod & "','" & mylot.cprod & "','" & mylot.fprod & "','" & mylot.sprod & "','" & mylot.waferqty & "','" & splitqty & "','" & splitwaferstr & "','" & mylot.code &
                "','" & mylot.orderfile & "','" & mylot.remark & "','" & mylot.CurrentStep & "','" & "CHECKIN" & "','" & mylot.location & "','True','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

        Next


        ' 设置母批 Status为 'SMDONE'

        If SetWIPLotStatus(mylot.ilot, mylot.CurrentStep, "SMDONE") = False Then
            MsgBox("设置母批Status为 SMDONE 时发生异常!请立即通知PTE工程师确认", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case mylot.CurrentStep

            Case "WIPFS", "PACK", "FQC", "SHIP"
                MsgBox("分批完成!" & vbCrLf & "特别注意此批已经过WIPFS站别,需要重新Lock Final Good Die 或联系PTE处理!", vbOKOnly + vbInformation)

            Case Else
                MsgBox("分批完成!", vbOKOnly + vbInformation)

        End Select



    End Sub


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub


End Class