Imports System.Data.SqlClient

Public Class frmHold

    Private Sub frmHold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
        DGV_Hold.BackgroundColor = mydefaultcolor

        combo_status.Items.Add("ongoing")
        combo_status.Items.Add("close")
        combo_status.Text = "ongoing"

        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_hold_delete.Visible = True
            Case GROUPTYPE.MGR, GROUPTYPE.ENG
                btn_hold_new.Enabled = True
                btn_itest_rls.Enabled = True
            Case GROUPTYPE.OP
                btn_hold_new.Enabled = True
                btn_itest_rls.Enabled = False
        End Select

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

    Private Sub combo_prod_DropDown(sender As Object, e As EventArgs) Handles combo_prod.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_cust.Text <> "*" Then
            mysql = "select InternalProduct from Product where Customer='" & combo_cust.Text & "'"
        Else
            mysql = "select InternalProduct from Product"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "product")

        If mydataset.Tables("product").Rows.Count = 0 Then
            combo_prod.Items.Clear()
            combo_prod.Items.Add("*")
        Else
            combo_prod.Items.Clear()
            combo_prod.Items.Add("*")

            For i = 0 To mydataset.Tables("product").Rows.Count - 1
                combo_prod.Items.Add(mydataset.Tables("product").Rows(i).Item("InternalProduct"))
            Next

        End If

    End Sub

    Private Sub combo_ilot_DropDown(sender As Object, e As EventArgs) Handles combo_ilot.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select iTestLotNo from ERFHold"

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

        mysql = "select DISTINCT CustLotNo from ERFHold"

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

        DGV_Hold.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case combo_cust.Text

            Case "*"

                If combo_prod.Text = "*" Then
                    mysql = "select * from ERFHold where Status = '" & combo_status.Text & "'"
                Else
                    mysql = "select * from ERFHold where Status = '" & combo_status.Text & "' AND iTestProduct='" & combo_prod.Text & "'"
                End If


            Case Else '选择指定客户时

                If combo_prod.Text = "*" Then
                    mysql = "select * from ERFHold where Status = '" & combo_status.Text & "' AND CUSTENG='" & combo_cust.Text & "'"
                Else
                    mysql = "select * from ERFHold where Status = '" & combo_status.Text & "' AND CUSTENG='" & combo_cust.Text & "' AND iTestProduct='" & combo_prod.Text & "'"
                End If

        End Select


        If Len(combo_ilot.Text) > 2 Then '选择指定批号时
            mysql = "select * from ERFHold where iTestLotNo='" & combo_ilot.Text & "'"
        End If

        If Len(combo_clot.Text) > 2 Then '选择指定批号时
            mysql = "select * from ERFHold where CustLotNo='" & combo_clot.Text & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "HOLD")

        If mydataset.Tables("HOLD").Rows.Count = 0 Then
            DGV_Hold.DataSource = Nothing

        Else
            DGV_Hold.DataSource = mydataset.Tables("HOLD")
        End If



    End Sub

    Private Sub btn_hold_new_Click(sender As Object, e As EventArgs) Handles btn_hold_new.Click

        Hold_Operation_Mode = "HOLD"
        frmHoldSet.Show()

    End Sub

    Private Sub btn_hold_rls_Click(sender As Object, e As EventArgs) Handles btn_itest_rls.Click

        Hold_Operation_Mode = "RELEASE"
        If DGV_Hold.Rows.Count = 0 Then Exit Sub

        myholdlot.HoldSN = DGV_Hold.SelectedRows(0).Cells("HoldSN").Value.ToString
        myholdlot.ilot = DGV_Hold.SelectedRows(0).Cells("iTestLotNo").Value.ToString
        myholdlot.clot = DGV_Hold.SelectedRows(0).Cells("CustLotNo").Value.ToString
        myholdlot.holdstep = DGV_Hold.SelectedRows(0).Cells("HoldStep").Value.ToString
        myholdlot.cust = DGV_Hold.SelectedRows(0).Cells("CUSTENG").Value.ToString
        myholdlot.iprod = DGV_Hold.SelectedRows(0).Cells("iTestProduct").Value.ToString
        myholdlot.cprod = DGV_Hold.SelectedRows(0).Cells("CustProduct").Value.ToString
        myholdlot.currqty = DGV_Hold.SelectedRows(0).Cells("CurrentQTY").Value.ToString
        myholdlot.holdqty = DGV_Hold.SelectedRows(0).Cells("HoldQTY").Value.ToString
        myholdlot.holdwaferlist = DGV_Hold.SelectedRows(0).Cells("HoldWaferlist").Value.ToString
        myholdlot.holdtime = DGV_Hold.SelectedRows(0).Cells("HoldTime").Value.ToString
        myholdlot.holder = DGV_Hold.SelectedRows(0).Cells("Holder").Value.ToString
        myholdlot.holdtype = DGV_Hold.SelectedRows(0).Cells("HoldType").Value.ToString
        myholdlot.holdreason = DGV_Hold.SelectedRows(0).Cells("HoldReason").Value.ToString

        myholdlot.owner = DGV_Hold.SelectedRows(0).Cells("Owner").Value.ToString
        myholdlot.ownerGrp = DGV_Hold.SelectedRows(0).Cells("OwnerGrp").Value.ToString
        myholdlot.itestdisposeflag = DGV_Hold.SelectedRows(0).Cells("iTestDisposeFlag").Value.ToString
        myholdlot.itestdisposecmd = DGV_Hold.SelectedRows(0).Cells("iTestDisposeCmd").Value.ToString

        If IsDBNull(DGV_Hold.SelectedRows(0).Cells("InformTime").Value) = False Then
            myholdlot.informtime = DGV_Hold.SelectedRows(0).Cells("InformTime").Value
        End If

        myholdlot.Custowner = DGV_Hold.SelectedRows(0).Cells("CustOwner").Value.ToString
        myholdlot.custdisposeflag = DGV_Hold.SelectedRows(0).Cells("CustDisposeFlag").Value.ToString
        myholdlot.custdisposecmd = DGV_Hold.SelectedRows(0).Cells("CustDisposeCmd").Value.ToString

        myholdlot.attach = DGV_Hold.SelectedRows(0).Cells("attach").Value.ToString
        myholdlot.status = DGV_Hold.SelectedRows(0).Cells("Status").Value.ToString
        myholdlot.closer = DGV_Hold.SelectedRows(0).Cells("closer").Value.ToString

        If myholdlot.status = "close" Then
            MsgBox("该笔异常已处于结单状态,仅供查看!", vbOKOnly + vbExclamation)
        End If

        frmHoldSet.Show()

    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If DGV_Hold.Rows.Count = 0 Then Exit Sub

        MsgBox("尚未上线!", vbOKOnly + vbInformation)


    End Sub

    Private Sub btn_hold_delete_Click(sender As Object, e As EventArgs) Handles btn_hold_delete.Click

        Dim mysql As String, s As Integer

        If DGV_Hold.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM ERFHold WHERE HoldSN='" & DGV_Hold.SelectedRows(0).Cells("HoldSN").Value & "'"

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

End Class