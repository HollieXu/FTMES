Imports System.Data.SqlClient


Public Class frmOffline


    Private Sub frmOffline_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
        DGV_offline.BackgroundColor = mydefaultcolor
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

        DGV_offline.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case combo_cust.Text

            Case "*"

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where CurrentStep='SHIP' AND Status = 'CHECKIN'"
                Else
                    mysql = "select * from WIPLOT where CurrentStep='SHIP' AND Status = 'CHECKIN' AND ProductType='" & combo_type.Text & "'"
                End If


            Case Else '选择指定客户时

                If combo_type.Text = "*" Then
                    mysql = "select * from WIPLOT where  CurrentStep='SHIP' AND Status = 'CHECKIN' AND CUSTENG='" & combo_cust.Text & "'"
                Else
                    mysql = "select * from WIPLOT where  CurrentStep='SHIP' AND Status = 'CHECKIN' AND  CUSTENG='" & combo_cust.Text & "' AND  ProductType='" & combo_type.Text & "'"
                End If

        End Select


        If Len(combo_ilot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where   CurrentStep='SHIP' AND Status = 'CHECKIN' AND iTestLotNo='" & combo_ilot.Text & "'"
        End If

        If Len(combo_clot.Text) > 2 Then '选择指定批号时
            mysql = "select * from WIPLOT where   CurrentStep='SHIP' AND Status = 'CHECKIN' AND CustLotNo='" & combo_clot.Text & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            DGV_offline.DataSource = Nothing

        Else
            DGV_offline.DataSource = mydataset.Tables("WIP")
        End If



    End Sub



    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click


        If DGV_offline.Rows.Count = 0 Then Exit Sub

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定入库该货批吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE WIPLOT SET CurrentStep= 'SHIP',Status='CHECKOUT' WHERE iTestLotNo= '" & DGV_offline.SelectedRows(0).Cells("iTestLotNo").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            Call btn_Query_Click("", e)

        End If


    End Sub


End Class