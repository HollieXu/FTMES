Imports System.Data.SqlClient

Public Class frmShippingSet

    Private Sub frmShippingSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mysql2 As String
        Dim mydataset2 As New DataSet

        Me.Left = 10
        Me.Top = 10
        Me.BackColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor

        combo_shipmethod.Items.Add("物流快递")
        combo_shipmethod.Items.Add("司机送货")
        combo_shipmethod.Items.Add("客户自提")

        txt_sender.Text = "安测半导体技术（江苏）有限公司"
        txt_senderaddress.Text = "中国江苏省扬州高新技术产业开发区吉安南路158号金荣科技园1号楼 邮编 225100"

        combo_express.Items.Add("顺丰快递")
        combo_express.Items.Add("跨越快递")


        If Shipping_Operation_Mode = "MODIFY" Then

            combo_cust.Text = myship.ename
            combo_cust.Enabled = False
            txt_cust.Text = myship.cname
            txt_reciver.Text = myship.cname
            txt_ShipOrder.Text = myship.ShipOrder
            DateTimePicker1.Value = myship.shipdate
            combo_shipmethod.Text = myship.shipmethod
            txt_BoxQTY.Text = myship.boxqty

            txt_senderop.Text = myship.FactoryContactPerson
            txt_senderphone.Text = myship.FactoryContactNo

            txt_reciveraddress.Text = myship.ShipAddress
            txt_reciverop.Text = myship.ShipContactPerson
            txt_reciverphone.Text = myship.ShipContactNo

            combo_express.Text = myship.ShipExpress
            txt_ShippingExpressNo.Text = myship.ShipExpressNo
            rtb_remark.Text = myship.remark
            txt_sopath.Text = myship.attach


            '刷新显示DGV_LOT
            mysql2 = "select * from ShipDetail where ShipOrder='" & myship.ShipOrder & "'"
            Dim myadapter2 As New SqlDataAdapter(mysql2, myconn)
            myadapter2.Fill(mydataset2, "SHIPDETAIL")
            DGV_lot.DataSource = mydataset2.Tables("SHIPDETAIL")


        End If


        If myship.Status = "close" Then
            MsgBox("此出货单已完成销账，只能查看，无法修改!", vbOKOnly + vbExclamation)
            btn_add.Enabled = False
            btn_del.Enabled = False
            DGV_lot.Enabled = False
            btn_ok.Enabled = False
            btn_exit.Enabled = False
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
                txt_reciver.Text = mydataset.Tables("Cust").Rows(i).Item("cname")
            End If

        End If

        ' 每次选择客户时，自动生成一个内部Work Order 流水号
        txt_ShipOrder.Text = "CS" & Format(Now(), "yyyyMMddHHmmss")



    End Sub




    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim mysql As String

        If DGV_lot.Rows.Count = 0 Then
            MsgBox("未设定批号信息!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If Shipping_Operation_Mode = "NEW" Then

            mysql = "INSERT INTO ShipInfo (ShipOrder,Status,CUSTENG,CUSTCHN,ShipDate,ShipMethod,BoxQty,FactoryAddress,FactoryContactPerson,FactoryContactNo,ShipAddress,ShipContactPerson,ShipContactNo,ShipExpress,ShipExpressNo,remark,attach,Enable,CreateTime,Creater) VALUES ( '" &
                txt_ShipOrder.Text & "','" & "ongoing" & "','" & combo_cust.Text & "','" & txt_cust.Text & "','" & DateTimePicker1.Value & "','" & combo_shipmethod.Text & "','" & txt_BoxQTY.Text & "','" & txt_senderaddress.Text & "','" & txt_senderop.Text & "','" & txt_senderphone.Text & "','" & txt_reciveraddress.Text & "','" &
                txt_reciverop.Text & "','" & txt_reciverphone.Text & "','" & combo_express.Text & "','" & txt_ShippingExpressNo.Text & "','" & rtb_remark.Text & "','" & txt_sopath.Text & "','True','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbExclamation)
            End Try

            myconn.Close()

            MsgBox("开立出货单完成!", vbOKOnly + vbInformation)
            Me.Close()

        ElseIf Shipping_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  ShipInfo SET ShipDate= '" & DateTimePicker1.Value & "', ShipMethod='" & combo_shipmethod.Text & "', BoxQty='" & txt_BoxQTY.Text & "', FactoryContactPerson='" & txt_senderop.Text &
                "', FactoryContactNo='" & txt_senderphone.Text & "', ShipAddress='" & txt_reciveraddress.Text & "', ShipContactPerson ='" & txt_reciverop.Text & "', ShipContactNo ='" & txt_reciverphone.Text & "', ShipExpress ='" & combo_express.Text & "', ShipExpressNo='" & txt_ShippingExpressNo.Text &
                 "', remark='" & rtb_remark.Text & "', attach='" & txt_sopath.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ShipOrder='" & myship.ShipOrder & "'"

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

        Call frmShipping.btn_Query_Click("", e)




    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\ShippingSet\"

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
            txt_sopath.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")

            MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If


    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        Dim sourcefile As String, destfile As String

        'sourcefile = txt_wopath.Text
        sourcefile = Replace(txt_sopath.Text, "CPMES-SERVER", "10.10.31.99")

        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub



    Private Sub combo_ilot_DropDown(sender As Object, e As EventArgs) Handles combo_ilot.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select iTestLotNo from WIPLOT Where CUSTENG='" & combo_cust.Text & "' AND CurrentStep='SHIP' AND Status NOT IN ('INV','SMDONE')"

        ''测试用
        ''mysql = "select iTestLotNo from WIPLOT Where CUSTENG='" & combo_cust.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            combo_ilot.Items.Add("Query  Fail !")
        Else

            combo_ilot.Items.Clear()

            For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
                combo_ilot.Items.Add(mydataset.Tables("WIP").Rows(i).Item("iTestLotNo"))
            Next

        End If



    End Sub

    Private Sub combo_ilot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ilot.SelectedIndexChanged

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet



        mysql = "select * from WIPLOT where iTestLotNo='" & combo_ilot.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            MsgBox("Query WIP List Fail !", vbOKOnly + vbExclamation)

        Else

            myshipdetail.iTestLotNo = mydataset.Tables("WIP").Rows(i).Item("iTestLotNo")
            myshipdetail.ShipLotNo = mydataset.Tables("WIP").Rows(i).Item("ShipLotNo")
            myshipdetail.iTestProduct = mydataset.Tables("WIP").Rows(i).Item("iTestProduct")
            myshipdetail.ShipProduct = mydataset.Tables("WIP").Rows(i).Item("ShipProduct")
            myshipdetail.ReceivingWaferQty = mydataset.Tables("WIP").Rows(i).Item("ReceivingWaferQty")
            myshipdetail.CurrentWaferQty = mydataset.Tables("WIP").Rows(i).Item("CurrentWaferQty")
            myshipdetail.WaferList = mydataset.Tables("WIP").Rows(i).Item("WaferList")
            myshipdetail.Yield = mydataset.Tables("WIP").Rows(i).Item("Yield").ToString
            myshipdetail.GoodDieQty = mydataset.Tables("WIP").Rows(i).Item("GoodDieQty").ToString
            myshipdetail.GrossDieQty = mydataset.Tables("WIP").Rows(i).Item("GrossDieQty").ToString

            txt_slot.Text = myshipdetail.ShipLotNo
            txt_yield.Text = myshipdetail.Yield
            txt_gooddie.Text = myshipdetail.GoodDieQty
            txt_grossdie.Text = myshipdetail.GrossDieQty

        End If

    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim mysql As String
        Dim mydataset As New DataSet


        '栏位正确性校验

        If txt_yield.Text = "" Or txt_gooddie.Text = "" Or txt_grossdie.Text = "" Then
            MsgBox("良数信息不全!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If txt_outerboxid.Text = "" Or txt_GW.Text = "" Or txt_NW.Text = "" Or txt_length.Text = "" Or txt_width.Text = "" Or txt_height.Text = "" Then
            MsgBox("重量尺寸信息不全!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        mysql = "select * from ShipDetail where ShipOrder='" & txt_ShipOrder.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "SHIPDETAIL")

        Dim mydatarow As DataRow = mydataset.Tables("SHIPDETAIL").NewRow

        myshipdetail.ShipOrder = txt_ShipOrder.Text
        mydatarow("ShipOrder") = myshipdetail.ShipOrder
        mydatarow("iTestLotNo") = myshipdetail.iTestLotNo
        mydatarow("ShipLotNo") = myshipdetail.ShipLotNo
        mydatarow("iTestProduct") = myshipdetail.iTestProduct
        mydatarow("ShipProduct") = myshipdetail.ShipProduct
        mydatarow("ReceivingWaferQty") = myshipdetail.ReceivingWaferQty
        mydatarow("CurrentWaferQty") = myshipdetail.CurrentWaferQty
        mydatarow("WaferList") = myshipdetail.WaferList


        '下列数据目前由人员Keyin, 后续考虑自动带入
        mydatarow("Yield") = txt_yield.Text
        mydatarow("GoodDieQty") = txt_gooddie.Text
        mydatarow("GrossDieQty") = txt_grossdie.Text
        mydatarow("OuterBoxID") = txt_outerboxid.Text
        mydatarow("GrossWeight") = txt_GW.Text
        mydatarow("NetWeight") = txt_NW.Text  '后续评估由WaferQTY * 系数 0.076

        mydatarow("Length") = txt_length.Text
        mydatarow("Width") = txt_width.Text
        mydatarow("Height") = txt_height.Text

        mydataset.Tables("SHIPDETAIL").Rows.Add(mydatarow)
        Dim cm As SqlCommandBuilder = New SqlCommandBuilder(myadapter)
        myadapter.Update(mydataset, "SHIPDETAIL")


        DGV_lot.DataSource = mydataset.Tables("SHIPDETAIL")


    End Sub



    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        Dim mysql2 As String
        Dim mydataset2 As New DataSet

        If DGV_lot.Rows.Count = 0 Then Exit Sub

        mysql = "DELETE FROM ShipDetail WHERE iTestLotNo= '" & DGV_lot.SelectedRows(0).Cells("iTestLotNo").Value & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbExclamation)
        End Try

            myconn.Close()


        '刷新显示DGV_LOT
        mysql2 = "select * from ShipDetail where ShipOrder='" & txt_ShipOrder.Text & "'"
        Dim myadapter2 As New SqlDataAdapter(mysql2, myconn)
        myadapter2.Fill(mydataset2, "SHIPDETAIL")
        DGV_lot.DataSource = mydataset2.Tables("SHIPDETAIL")

    End Sub



End Class