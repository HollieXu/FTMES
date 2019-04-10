Imports System.Data.SqlClient

Public Class frmOnline


    Private Sub frmOnline_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.BackColor = mydefaultcolor
        DGV_online.BackgroundColor = mydefaultcolor
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
            combo_cust.Items.Add("Query Customer List Fail !")
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
            combo_ilot.Items.Add("Query Lot List Fail !")
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
            combo_clot.Items.Add("Query Lot List Fail !")
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

        DGV_online.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case combo_cust.Text

            Case "*"

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where Status = 'RCVDONE'"
                Else
                    mysql = "select * from WIPLOT where Status = 'RCVDONE' AND ProductType='" & combo_type.Text & "'"
                End If


            Case Else '选择指定客户时

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where Status = 'RCVDONE' AND CUSTENG='" & combo_cust.Text & "'"
                Else
                    mysql = "select * from WIPLOT where Status = 'RCVDONE' AND  CUSTENG='" & combo_cust.Text & "' AND  ProductType='" & combo_type.Text & "'"
                End If

        End Select


        If Len(combo_ilot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where  Status = 'RCVDONE' AND iTestLotNo='" & combo_ilot.Text & "'"
        End If

        If Len(combo_clot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where  Status = 'RCVDONE' AND CustLotNo='" & combo_clot.Text & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            DGV_online.DataSource = Nothing

        Else
            DGV_online.DataSource = mydataset.Tables("WIP")
        End If



    End Sub



    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click

        Dim mysql As String, s As Integer
        Dim cust As String, prod As String, ilot As String, flowid As String
        Dim i As Integer

        If DGV_online.Rows.Count = 0 Then Exit Sub

        cust = DGV_online.SelectedRows(0).Cells("CUSTENG").Value.ToString
        prod = DGV_online.SelectedRows(0).Cells("iTestProduct").Value.ToString
        ilot = DGV_online.SelectedRows(0).Cells("iTestLotNo").Value.ToString
        flowid = GetFlowIDbyLotNo(cust, prod, ilot)

        'Flow正确性确认
        If flowid = "" Then
            MsgBox("查询不到此型号的流程，无法派工，请联系PTE处理!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Call GetStepNameArraybyFlowID(cust, prod, ilot, flowid)

        'Step正确性确认
        If UBound(mystep) = 0 Then
            MsgBox("查询不到此型号的具体作业站信息，无法派工，请联系PTE处理!", vbOKOnly + vbExclamation)
            Exit Sub

        ElseIf UBound(mystep) > 0 Then
            For i = 1 To UBound(mystep) - 1
                If mystep(i).name = "" Or mystep(i).id = "" Then
                    MsgBox("作业站设定异常: 站别名->" & mystep(i).name & ",RecipeID->" & mystep(i).id)
                    Exit Sub
                End If
            Next

        End If


        s = MessageBox.Show("确定领用该货批吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            '领用后，货批 变为Flow第一个Step的 待Check IN 状态
            mysql = "UPDATE WIPLOT SET CurrentStep= '" & mystep(1).name & "',Status='CHECKIN' WHERE iTestLotNo= '" & ilot & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            Call btn_Query_Click("", e)
            MsgBox("成功领料上线!", vbOKOnly + vbInformation)
        End If


    End Sub



End Class