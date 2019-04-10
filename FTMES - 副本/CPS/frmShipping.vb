Imports System.Data.SqlClient

Public Class frmShipping


    Private Sub frmShipping_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UserGroup = GROUPTYPE.SU Then
            btn_shipping_delete.Visible = True
        End If
        Me.BackColor = mydefaultcolor
        DGV_Shipping.BackgroundColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor

        combo_shipstatus.Items.Add("ongoing")
        combo_shipstatus.Items.Add("hold")
        combo_shipstatus.Items.Add("close")
        combo_shipstatus.Text = "ongoing"

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
            combo_cust.Items.Add("*")
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
                txt_cust.Text = ""

            Else
                txt_cust.Text = mydataset.Tables("Cust").Rows(i).Item("cname")
            End If

        End If

    End Sub

    Private Sub combo_ilot_DropDown(sender As Object, e As EventArgs) Handles combo_ilot.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select iTestLotNo from WIPLOT"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            combo_ilot.Items.Add("Query Fail !")
        Else

            combo_ilot.Items.Clear()

            For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
                combo_ilot.Items.Add(mydataset.Tables("WIP").Rows(i).Item("iTestLotNo"))
            Next

            combo_clot.Text = "*"

        End If


    End Sub

    Private Sub combo_clot_DropDown(sender As Object, e As EventArgs) Handles combo_clot.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select CustLotNo from WIPLOT"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            combo_clot.Items.Add("Query  Fail !")

        Else

            combo_clot.Items.Clear()

            For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
                combo_clot.Items.Add(mydataset.Tables("WIP").Rows(i).Item("CustLotNo"))
            Next

            combo_ilot.Text = "*"

        End If

    End Sub


    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click


        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_Shipping.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If combo_cust.Text = "*" Then
            mysql = "select * from ShipInfo where Status = '" & combo_shipstatus.Text & "'"
        Else
            mysql = "select * from ShipInfo where CUSTENG='" & combo_cust.Text & "' AND Status = '" & combo_shipstatus.Text & "'"
        End If
        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "shipping")

        If mydataset.Tables("shipping").Rows.Count = 0 Then
            DGV_Shipping.DataSource = Nothing

        Else
            DGV_Shipping.DataSource = mydataset.Tables("shipping")
        End If



    End Sub

    Private Sub btn_shipping_new_Click(sender As Object, e As EventArgs) Handles btn_shipping_new.Click
        Shipping_Operation_Mode = "NEW"
        frmShippingSet.Show()
    End Sub

    Private Sub btn_shipping_modify_Click(sender As Object, e As EventArgs) Handles btn_shipping_modify.Click
        Shipping_Operation_Mode = "MODIFY"

        If DGV_Shipping.Rows.Count = 0 Then Exit Sub


        myship.ShipOrder = DGV_Shipping.SelectedRows(0).Cells("ShipOrder").Value.ToString
        myship.Status = DGV_Shipping.SelectedRows(0).Cells("Status").Value.ToString
        myship.ename = DGV_Shipping.SelectedRows(0).Cells("CUSTENG").Value.ToString
        myship.cname = DGV_Shipping.SelectedRows(0).Cells("CUSTCHN").Value.ToString
        myship.shipdate = DGV_Shipping.SelectedRows(0).Cells("ShipDate").Value.ToString
        myship.shipmethod = DGV_Shipping.SelectedRows(0).Cells("ShipMethod").Value.ToString
        myship.boxqty = DGV_Shipping.SelectedRows(0).Cells("BoxQty").Value.ToString
        myship.FactoryAddress = DGV_Shipping.SelectedRows(0).Cells("FactoryAddress").Value.ToString
        myship.FactoryContactPerson = DGV_Shipping.SelectedRows(0).Cells("FactoryContactPerson").Value.ToString
        myship.FactoryContactNo = DGV_Shipping.SelectedRows(0).Cells("FactoryContactNo").Value.ToString
        myship.ShipAddress = DGV_Shipping.SelectedRows(0).Cells("ShipAddress").Value.ToString
        myship.ShipContactPerson = DGV_Shipping.SelectedRows(0).Cells("ShipContactPerson").Value.ToString
        myship.ShipContactNo = DGV_Shipping.SelectedRows(0).Cells("ShipContactNo").Value.ToString
        myship.ShipExpress = DGV_Shipping.SelectedRows(0).Cells("ShipExpress").Value.ToString
        myship.ShipExpressNo = DGV_Shipping.SelectedRows(0).Cells("ShipExpressNo").Value.ToString
        myship.remark = DGV_Shipping.SelectedRows(0).Cells("remark").Value.ToString
        myship.attach = DGV_Shipping.SelectedRows(0).Cells("attach").Value.ToString

        frmShippingSet.Show()

    End Sub
























    Private Sub btn_shipping_disable_Click(sender As Object, e As EventArgs) Handles btn_shipping_disable.Click

        Dim mysql As String, s As Integer

        If DGV_Shipping.Rows.Count = 0 Then Exit Sub

        If DGV_Shipping.SelectedRows(0).Cells("Status").Value = "close" Then
            MsgBox("已销账单据,无法再操作!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        s = MessageBox.Show("确定要暂停出货吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE ShipInfo SET Status= 'hold' " & " WHERE ShipOrder= '" & DGV_Shipping.SelectedRows(0).Cells("ShipOrder").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("暂停出货设置完成!", vbOKOnly + vbInformation)
            Call btn_Query_Click("", e)

        End If

    End Sub

    Private Sub btn_shipping_confirm_Click(sender As Object, e As EventArgs) Handles btn_shipping_confirm.Click

        Dim mysql As String, s As Integer

        Dim i As Integer
        Dim mysql2 As String
        Dim mydataset2 As New DataSet

        If DGV_Shipping.Rows.Count = 0 Then Exit Sub

        If DGV_Shipping.SelectedRows(0).Cells("Status").Value = "close" Then
            MsgBox("已销账单据,无法再操作!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        s = MessageBox.Show("已完成系统资料及实物面作业,确定出货销账?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE ShipInfo SET Status= 'close' " & " WHERE ShipOrder= '" & DGV_Shipping.SelectedRows(0).Cells("ShipOrder").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()



            '批次信息 INV站别状态转换
            mysql2 = "select * from ShipDetail  WHERE ShipOrder= '" & DGV_Shipping.SelectedRows(0).Cells("ShipOrder").Value & "'"

            Dim myadapter As New SqlDataAdapter(mysql2, myconn)

            myadapter.Fill(mydataset2, "WIP")

            If mydataset2.Tables("WIP").Rows.Count = 0 Then
                'MsgBox("Query WIP List Fail !")
            Else

                For i = 0 To mydataset2.Tables("WIP").Rows.Count - 1

                    If SetWIPLotStatus(mydataset2.Tables("WIP").Rows(i).Item("iTestLotNo"), "INV", "INV") = False Then
                        MsgBox("出货销账失败,更新WIPLOT表 站别 为 <INV> 时 FAIL!", vbOKOnly + vbExclamation)
                        Exit Sub
                    Else
                        'do nothing
                    End If


                Next

            End If


            MsgBox("出货销账完成!", vbOKOnly + vbInformation)
            Call btn_Query_Click("", e)


        End If
    End Sub



    Private Sub btn_shipping_delete_Click(sender As Object, e As EventArgs) Handles btn_shipping_delete.Click
        Dim mysql As String, s As Integer

        If DGV_Shipping.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM ShipInfo WHERE ShipOrder= '" & DGV_Shipping.SelectedRows(0).Cells("ShipOrder").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            MsgBox("已成功删除!", vbOKOnly + vbInformation)

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_shipform_Click(sender As Object, e As EventArgs) Handles btn_shipform.Click
        MsgBox("暂不需要列印", vbOKOnly + vbInformation)
    End Sub


    '出货标签列印
    Private Sub btn_labelprint_Click(sender As Object, e As EventArgs) Handles btn_labelprint.Click

        If DGV_Shipping.Rows.Count = 0 Then Exit Sub

        LabelType = "OUT"
        LabelLot = ""
        frmLabel.Show()

    End Sub



End Class