Imports System.Data.SqlClient

Public Class frmIncoming



    Private Sub frmIncoming_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If UserGroup = GROUPTYPE.SU Then
            btn_incoming_delete.Visible = True
        End If
        Me.BackColor = mydefaultcolor
        DGV_Incoming.BackgroundColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor

    End Sub



    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown


        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            combo_cust.Items.Add("Query  Fail !")
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
            combo_clot.Items.Add("Query Fail !")
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

        DGV_Incoming.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case combo_cust.Text

            Case "*"

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where CurrentStep = 'RCV'"
                Else
                    mysql = "select * from WIPLOT where CurrentStep = 'RCV' AND ProductType='" & combo_type.Text & "'"
                End If


            Case Else '选择指定客户时

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where CurrentStep = 'RCV' AND CUSTENG='" & combo_cust.Text & "'"
                Else
                    mysql = "select * from WIPLOT where CurrentStep = 'RCV' AND CUSTENG='" & combo_cust.Text & "' AND  ProductType='" & combo_type.Text & "'"
                End If

        End Select


        If Len(combo_ilot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where CurrentStep = 'RCV' AND iTestLotNo='" & combo_ilot.Text & "'"
        End If

        If Len(combo_clot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where CurrentStep = 'RCV' AND CustLotNo='" & combo_clot.Text & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Incoming")

        If mydataset.Tables("Incoming").Rows.Count = 0 Then
            DGV_Incoming.DataSource = Nothing

        Else
            DGV_Incoming.DataSource = mydataset.Tables("Incoming")
        End If



    End Sub

    Private Sub btn_incoming_new_Click(sender As Object, e As EventArgs) Handles btn_incoming_new.Click
        Incoming_Operation_Mode = "NEW"
        frmIncomingset.Show()
    End Sub

    Private Sub btn_incoming_modify_Click(sender As Object, e As EventArgs) Handles btn_incoming_modify.Click
        Incoming_Operation_Mode = "MODIFY"

        If DGV_Incoming.Rows.Count = 0 Then Exit Sub


        myincoming.custid = DGV_Incoming.SelectedRows(0).Cells("CUSTID").Value.ToString
        myincoming.custeng = DGV_Incoming.SelectedRows(0).Cells("CUSTENG").Value.ToString
        myincoming.custchn = DGV_Incoming.SelectedRows(0).Cells("CUSTCHN").Value.ToString
        myincoming.ilot = DGV_Incoming.SelectedRows(0).Cells("iTestLotNo").Value.ToString
        myincoming.itestorder = DGV_Incoming.SelectedRows(0).Cells("iTestOrder").Value.ToString
        myincoming.receivingExNo = DGV_Incoming.SelectedRows(0).Cells("ReceivingExpressNo").Value.ToString
        myincoming.custorder = DGV_Incoming.SelectedRows(0).Cells("CustOrder").Value.ToString
        myincoming.custorderseq = DGV_Incoming.SelectedRows(0).Cells("CustOrderSequence").Value.ToString
        myincoming.orderdate = DGV_Incoming.SelectedRows(0).Cells("OrderDate").Value.ToString
        myincoming.requiredate = DGV_Incoming.SelectedRows(0).Cells("RequireDate").Value.ToString
        myincoming.receivingdate = DGV_Incoming.SelectedRows(0).Cells("ReceivingDate").Value.ToString
        myincoming.prodtype = DGV_Incoming.SelectedRows(0).Cells("ProductType").Value.ToString
        myincoming.priority = DGV_Incoming.SelectedRows(0).Cells("Priority").Value.ToString
        myincoming.bonded = DGV_Incoming.SelectedRows(0).Cells("bonded").Value.ToString
        myincoming.clot = DGV_Incoming.SelectedRows(0).Cells("CustLotNo").Value.ToString
        myincoming.flot = DGV_Incoming.SelectedRows(0).Cells("FabLotNo").Value.ToString
        myincoming.slot = DGV_Incoming.SelectedRows(0).Cells("ShipLotNo").Value.ToString
        myincoming.iprod = DGV_Incoming.SelectedRows(0).Cells("iTestProduct").Value.ToString
        myincoming.cprod = DGV_Incoming.SelectedRows(0).Cells("CustProduct").Value.ToString
        myincoming.fprod = DGV_Incoming.SelectedRows(0).Cells("FabProduct").Value.ToString
        myincoming.sprod = DGV_Incoming.SelectedRows(0).Cells("ShipProduct").Value.ToString
        myincoming.waferqty = DGV_Incoming.SelectedRows(0).Cells("ReceivingWaferQty").Value.ToString
        myincoming.dieqty = DGV_Incoming.SelectedRows(0).Cells("DieQty").Value.ToString
        myincoming.code = DGV_Incoming.SelectedRows(0).Cells("CODE").Value.ToString
        myincoming.orderfile = DGV_Incoming.SelectedRows(0).Cells("OrderFile").Value.ToString
        myincoming.remark = DGV_Incoming.SelectedRows(0).Cells("Remark").Value.ToString



        frmIncomingset.Show()



    End Sub

    Private Sub btn_incoming_delete_Click(sender As Object, e As EventArgs) Handles btn_incoming_delete.Click

        Dim mysql As String, s As Integer

        If DGV_Incoming.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM WIPLOT WHERE iTestLotNo='" & DGV_Incoming.SelectedRows(0).Cells("iTestLotNo").Value & "'"

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

    Private Sub btn_incoming_disable_Click(sender As Object, e As EventArgs) Handles btn_incoming_disable.Click


        If DGV_Incoming.Rows.Count = 0 Then Exit Sub

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要暂时收货吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE WIPLOT SET Status= 'RCVHOLD' " & " WHERE iTestLotNo= '" & DGV_Incoming.SelectedRows(0).Cells("iTestLotNo").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("暂收货完成!", vbOKOnly + vbInformation)
            Call btn_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_incoming_enable_Click(sender As Object, e As EventArgs) Handles btn_incoming_enable.Click


        If DGV_Incoming.Rows.Count = 0 Then Exit Sub

        Dim mysql As String, s As Integer

        s = MessageBox.Show("已完成该批次收货，进行确认?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE WIPLOT SET Status= 'RCVDONE' " & " WHERE iTestLotNo= '" & DGV_Incoming.SelectedRows(0).Cells("iTestLotNo").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("收货确认完成!", vbOKOnly + vbInformation)
            Call btn_Query_Click("", e)

        End If

    End Sub



    '进货标签打印
    Private Sub btn_labelprint_Click(sender As Object, e As EventArgs) Handles btn_labelprint.Click

        If DGV_Incoming.Rows.Count = 0 Then Exit Sub

        LabelType = "IN"
        LabelLot = DGV_Incoming.SelectedRows(0).Cells("iTestLotNo").Value.ToString
        frmLabel.Show()

    End Sub


End Class