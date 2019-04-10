Imports System.Data.SqlClient

Public Class frmIncomingset

    Private Sub frmIncomingset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor

        If Incoming_Operation_Mode = "MODIFY" Then
            txt_custcode.Text = myincoming.custid
            combo_cust.Text = myincoming.custeng
            txt_cust.Text = myincoming.custchn

            txt_ilot.Text = myincoming.ilot
            txt_iTestOrder.Text = myincoming.itestorder
            txt_ReceivingExpressNo.Text = myincoming.receivingExNo
            txt_CustOrder.Text = myincoming.custorder
            txt_CustOrderSequence.Text = myincoming.custorderseq

            DateTimePicker1.Value = myincoming.orderdate
            DateTimePicker2.Value = myincoming.requiredate
            DateTimePicker3.Value = myincoming.receivingdate

            Select Case myincoming.prodtype
                Case "PROD"
                    Rbt_MP.Checked = True
                Case "ENG"
                    Rbt_ENG.Checked = True
                Case "CORR"
                    Rbt_CORR.Checked = True
                Case Else
                    Rbt_MP.Checked = False
                    Rbt_ENG.Checked = False
                    Rbt_CORR.Checked = False
            End Select

            Select Case myincoming.priority
                Case "SUPER"
                    Rbt_S.Checked = True
                Case "HOT"
                    Rbt_H.Checked = True
                Case "NORMAL"
                    Rbt_N.Checked = True
                Case Else
                    Rbt_S.Checked = False
                    Rbt_H.Checked = False
                    Rbt_N.Checked = False

            End Select

            Select Case myincoming.bonded
                Case "True"
                    Rbt_bondYes.Checked = True

                Case "False"
                    Rbt_bondNo.Checked = True

                Case Else
                    Rbt_bondYes.Checked = False
                    Rbt_bondNo.Checked = False
            End Select


            txt_clot.Text = myincoming.clot
            txt_flot.Text = myincoming.flot
            txt_slot.Text = myincoming.slot

            combo_iprod.Text = myincoming.iprod
            txt_cprod.Text = myincoming.cprod
            txt_fprod.Text = myincoming.fprod
            txt_sprod.Text = myincoming.sprod

            txt_waferqty.Text = myincoming.waferqty
            txt_dieqty.Text = myincoming.dieqty
            txt_code.Text = myincoming.code
            txt_wopath.Text = myincoming.orderfile
            rtb_mark.Text = myincoming.remark

            combo_cust.Enabled = False
            btn_ilot.Enabled = False

        End If

    End Sub



    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Fail !")
        Else

            combo_cust.Items.Clear()

            For i = 0 To mydataset.Tables("Cust").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Cust").Rows(i).Item("ename"))
            Next

        End If


    End Sub

    Private Sub combo_cust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cust.SelectedIndexChanged
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_cust.Text <> "*" Then

            mysql = "select * from Customer where ename='" & combo_cust.Text & "'"

            Dim myadapter As New SqlDataAdapter(mysql, myconn)

            myadapter.Fill(mydataset, "Cust")

            If mydataset.Tables("Cust").Rows.Count = 0 Then
                MsgBox("Query Customer List Fail !", vbOKOnly + vbExclamation)

            Else
                txt_cust.Text = mydataset.Tables("Cust").Rows(i).Item("cname")
                txt_custshortchar.Text = mydataset.Tables("Cust").Rows(i).Item("shortchar")
                txt_custcode.Text = mydataset.Tables("Cust").Rows(i).Item("ID")
            End If

        End If

        ' 每次选择客户时，自动生成一个内部Work Order 流水号
        txt_iTestOrder.Text = "CW" & Format(Now(), "yyyyMMddHHmmss")



    End Sub



    Private Sub combo_iprod_DropDown(sender As Object, e As EventArgs) Handles combo_iprod.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select InternalProduct from Product where Customer='" & combo_cust.Text & "'"


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "product")

        If mydataset.Tables("product").Rows.Count = 0 Then
            combo_iprod.Items.Clear()
        Else
            combo_iprod.Items.Clear()

            For i = 0 To mydataset.Tables("product").Rows.Count - 1
                combo_iprod.Items.Add(mydataset.Tables("product").Rows(i).Item("InternalProduct"))
            Next

        End If

    End Sub


    Private Sub combo_iprod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_iprod.SelectedIndexChanged


        Dim mysql As String
        Dim mydataset As New DataSet


        mysql = "select * from Product where InternalProduct='" & combo_iprod.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "prod")

        If mydataset.Tables("prod").Rows.Count = 0 Then
            MsgBox("Query prod List Fail !", vbOKOnly + vbExclamation)

        Else
            txt_cprod.Text = mydataset.Tables("prod").Rows(0).Item("CustomerProduct").ToString
            txt_fprod.Text = mydataset.Tables("prod").Rows(0).Item("FabProduct").ToString
            txt_sprod.Text = mydataset.Tables("prod").Rows(0).Item("ShipProduct").ToString

        End If







    End Sub



    Private Sub btn_ilot_Click_1(sender As Object, e As EventArgs) Handles btn_ilot.Click

        Dim i As Integer
        Dim ilot As String
        Dim head As String
        Dim yymm As String
        Dim usedsn As String
        Dim sn As String
        Dim ends As String


        Dim mysql As String
        Dim mydataset As New DataSet


        If txt_custshortchar.Text = "" Then
            MsgBox("该客户简码未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        head = "C" & txt_custshortchar.Text
        yymm = Format(Now(), "yyMM")

        mysql = "select iTestLotNo from WIPLOT where iTestLotNo like '%" & head + yymm & "%' ORDER BY iTestLotNo DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            sn = "001"
        Else

            'For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
            '    Console.WriteLine(mydataset.Tables("WIP").Rows(i).Item("iTestLotNo").ToString)
            'Next

            usedsn = mydataset.Tables("WIP").Rows(0).Item("iTestLotNo").substring(7, 3)

            If CInt(usedsn) < 999 Then
                sn = CStr(CInt(usedsn) + 1)
                If Len(sn) = 1 Then sn = "00" + sn
                If Len(sn) = 2 Then sn = "0" + sn
            Else
                MsgBox("该客户本月收货已超过999批，联系IT确认收货批号规则!")
                sn = "A00"
            End If

        End If




        ends = "A0"


        ilot = head + yymm + sn + ends



        txt_ilot.Text = ilot


    End Sub




    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim mysql As String
        Dim prodtype As String
        Dim Priority As String
        Dim bondinfo As Boolean

        If Rbt_MP.Checked = True Then prodtype = "PROD"
        If Rbt_ENG.Checked = True Then prodtype = "ENG"
        If Rbt_CORR.Checked = True Then prodtype = "CORR"

        If Rbt_S.Checked = True Then Priority = "SUPER"
        If Rbt_H.Checked = True Then Priority = "HOT"
        If Rbt_N.Checked = True Then Priority = "NORMAL"

        If Rbt_bondYes.Checked = True Then bondinfo = True
        If Rbt_bondNo.Checked = True Then bondinfo = False

        If txt_ilot.Text = "" Then
            MsgBox("资料设定不完整，生产批号为空!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If Incoming_Operation_Mode = "NEW" Then

            mysql = "INSERT INTO WIPLOT (CUSTENG,CUSTID,CUSTCHN,iTestOrder,ReceivingExpressNo,CustOrder,CustOrderSequence,OrderDate,RequireDate,ReceivingDate,ProductType,
Priority,bonded,iTestLotNo,CustLotNo,FabLotNo,ShipLotNo,iTestProduct,CustProduct,FabProduct,ShipProduct,ReceivingWaferQty,CurrentWaferQty,DieQty,CODE,OrderFile,Remark,CurrentStep,Status,Location,Enable,CreateTime,Creater) VALUES ( '" &
                combo_cust.Text & "','" & txt_custcode.Text & "','" & txt_cust.Text & "','" & txt_iTestOrder.Text & "','" & txt_ReceivingExpressNo.Text & "','" & txt_CustOrder.Text & "','" & txt_CustOrderSequence.Text & "','" & DateTimePicker1.Value & "','" & DateTimePicker2.Value & "','" & DateTimePicker3.Value & "','" & prodtype & "','" &
                Priority & "','" & bondinfo & "','" & txt_ilot.Text & "','" & txt_clot.Text & "','" & txt_flot.Text & "','" & txt_slot.Text & "','" & combo_iprod.Text & "','" & txt_cprod.Text & "','" & txt_fprod.Text & "','" & txt_sprod.Text & "','" & txt_waferqty.Text & "','" & txt_waferqty.Text & "','" & txt_dieqty.Text & "','" & txt_code.Text & "','" & txt_wopath.Text & "','" & rtb_mark.Text & "','" & "RCV" & "','" & "RCVING" & "','" & "收料仓" & "','True','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            MsgBox("录入完成!", vbOKOnly + vbInformation)
            Me.Close()

        ElseIf Incoming_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  WIPLOT SET ReceivingExpressNo= '" & txt_ReceivingExpressNo.Text & "', CustOrder='" & txt_CustOrder.Text & "', CustOrderSequence='" & txt_CustOrderSequence.Text & "', OrderDate='" & DateTimePicker1.Value &
                "', RequireDate='" & DateTimePicker2.Value & "', ReceivingDate='" & DateTimePicker3.Value & "', ProductType ='" & prodtype & "', Priority ='" & Priority & "', bonded ='" & bondinfo & "', CustLotNo='" & txt_clot.Text &
                 "', FabLotNo='" & txt_flot.Text & "', ShipLotNo='" & txt_slot.Text & "', iTestProduct='" & combo_iprod.Text & "', CustProduct='" & txt_cprod.Text & "', FabProduct='" & txt_fprod.Text & "', ShipProduct='" & txt_sprod.Text &
                  "', ReceivingWaferQty='" & txt_waferqty.Text & "', CurrentWaferQty='" & txt_waferqty.Text & "', DieQty='" & txt_dieqty.Text & "', CODE='" & txt_code.Text & "', OrderFile='" & txt_wopath.Text & "', Remark='" & rtb_mark.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE iTestLotNo='" & myincoming.ilot & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("修改完毕!", vbOKOnly + vbInformation)
            Me.Close()

        End If

        Call frmIncoming.btn_Query_Click("", e)




    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\IncomingSet\"

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
            txt_wopath.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")

            MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If


    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        Dim sourcefile As String, destfile As String

        'sourcefile = txt_wopath.Text
        sourcefile = Replace(txt_wopath.Text, "CPMES-SERVER", "10.10.31.99")

        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub Rbt_MP_CheckedChanged(sender As Object, e As EventArgs) Handles Rbt_MP.CheckedChanged

    End Sub
End Class