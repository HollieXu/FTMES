Imports System.Data.SqlClient

Public Class frmRlsTable

    Private Sub frmRlsTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = mydefaultcolor

        txt_cust.BackColor = mydefaultcolor

        TabControl1.TabPages(0).BackColor = Color.SkyBlue
        DGV_tester.BackgroundColor = Color.SkyBlue

        TabControl1.TabPages(1).BackColor = Color.SpringGreen
        DGV_Assy.BackgroundColor = Color.SpringGreen


        '添加Flow
        combo_flow.Items.Clear()
        For i = 1 To 9
            combo_flow.Items.Add("CP" & i)
        Next



        Select Case UserGroup

            Case GROUPTYPE.SU, GROUPTYPE.MGR

            Case GROUPTYPE.ENG

                '工程师级别限定PTE工号才有权限
                If Strings.Left(UserID + "0000", 4) <> "0031" Then

                    btn_new.Enabled = False
                    btn_del.Enabled = False
                    btn_tester_ok.Enabled = False
                    btn_tester_exit.Enabled = False
                    btn_assy_new.Enabled = False
                    btn_assy_del.Enabled = False
                    btn_assy_ok.Enabled = False
                    btn_assy_exit.Enabled = False

                End If

            Case GROUPTYPE.OP

                btn_new.Enabled = False
                btn_del.Enabled = False
                btn_tester_ok.Enabled = False
                btn_tester_exit.Enabled = False
                btn_assy_new.Enabled = False
                btn_assy_del.Enabled = False
                btn_assy_ok.Enabled = False
                btn_assy_exit.Enabled = False

        End Select




    End Sub

    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown

        Dim custarray() As String
        custarray = GetCustomerList()

        combo_cust.Items.Clear()

        For i = 0 To UBound(custarray) - 1
            combo_cust.Items.Add(custarray(i))
        Next

    End Sub

    Private Sub combo_prod_DropDown(sender As Object, e As EventArgs) Handles combo_prod.DropDown
        Dim prodarray() As String
        prodarray = GetProductList(combo_cust.Text)

        combo_prod.Items.Clear()

        For i = 0 To UBound(prodarray) - 1
            combo_prod.Items.Add(prodarray(i))
        Next

    End Sub

    Private Sub combo_cust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cust.SelectedIndexChanged
        txt_cust.Text = GetCustCNAME(combo_cust.Text)
    End Sub


    Private Sub combo_grp_DropDown(sender As Object, e As EventArgs) Handles combo_grp.DropDown

        Dim grparray() As String
        grparray = GetTesterGrp()

        combo_grp.Items.Clear()
        For i = 0 To UBound(grparray) - 1
            combo_grp.Items.Add(grparray(i))
        Next

    End Sub


    Private Sub combo_part_DropDown(sender As Object, e As EventArgs) Handles combo_part.DropDown

        Dim partarray() As String
        partarray = GetAssyPartNo()

        combo_part.Items.Clear()
        For i = 0 To UBound(partarray) - 1
            combo_part.Items.Add(partarray(i))
        Next

    End Sub



    Private Sub btn_tester_query_Click(sender As Object, e As EventArgs) Handles btn_tester_query.Click

        Dim mysql As String
        Dim mydataset As New DataSet
        Dim testerarray() As String
        Dim i As Integer, j As Integer


        If combo_cust.Text = "" Or combo_prod.Text = "" Or combo_flow.Text = "" Or combo_grp.Text = "" Then
            MsgBox("客户/产品/站别/机台群组 均不能为空!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        testerarray = GetTesterList(combo_grp.Text)

        '显示机台列表
        LB_tester.Items.Clear()
        For i = 0 To UBound(testerarray) - 1
            LB_tester.Items.Add(testerarray(i))
        Next

        '显示已设定之RLS 机台
        DGV_tester.Rows.Clear()

        mysql = "select * from RLS_TESTER where InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND Grp='" & combo_grp.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "RLS")

        If mydataset.Tables("RLS").Rows.Count = 0 Then
        Else
            For i = 0 To mydataset.Tables("RLS").Rows.Count - 1
                DGV_tester.Rows.Add(1)
                DGV_tester(0, i).Value = mydataset.Tables("RLS").Rows(i).Item("Tester")
                DGV_tester(1, i).Value = mydataset.Tables("RLS").Rows(i).Item("Disable")
                DGV_tester(2, i).Value = mydataset.Tables("RLS").Rows(i).Item("DisableReason")

                '将该机台从未显示机台列表中删除
                For j = LB_tester.Items.Count - 1 To 0 Step -1
                    If LB_tester.Items(j) = DGV_tester(0, i).Value Then
                        LB_tester.Items.RemoveAt(j)
                    End If
                Next

            Next
        End If

    End Sub

    Private Sub btn_assy_query_Click(sender As Object, e As EventArgs) Handles btn_assy_query.Click

        Dim mysql As String
        Dim mydataset As New DataSet
        Dim assyarray() As String
        Dim i As Integer, j As Integer


        If combo_cust.Text = "" Or combo_prod.Text = "" Or combo_flow.Text = "" Or combo_part.Text = "" Then
            MsgBox("客户/产品/站别/配件料号 均不能为空!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        assyarray = GetAssyList(combo_part.Text)

        '显示配件列表
        LB_Assy.Items.Clear()
        For i = 0 To UBound(assyarray) - 1
            LB_Assy.Items.Add(assyarray(i))
        Next

        '显示已设定之RLS 配件
        DGV_Assy.Rows.Clear()

        mysql = "select * from RLS_ASSY where InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND PartNo='" & combo_part.Text & "'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "RLS")

        If mydataset.Tables("RLS").Rows.Count = 0 Then
        Else
            For i = 0 To mydataset.Tables("RLS").Rows.Count - 1
                DGV_Assy.Rows.Add(1)
                DGV_Assy(0, i).Value = mydataset.Tables("RLS").Rows(i).Item("PartID")
                DGV_Assy(1, i).Value = mydataset.Tables("RLS").Rows(i).Item("Disable")
                DGV_Assy(2, i).Value = mydataset.Tables("RLS").Rows(i).Item("DisableReason")

                '将该机台从未显示机台列表中删除
                For j = LB_Assy.Items.Count - 1 To 0 Step -1
                    If LB_Assy.Items(j) = DGV_Assy(0, i).Value Then
                        LB_Assy.Items.RemoveAt(j)
                    End If
                Next

            Next
        End If


    End Sub



    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        Dim mysql As String
        Dim mydataset As New DataSet


        If LB_tester.SelectedIndex = -1 Then
            MsgBox("请先选择要添加之机台!")
            Exit Sub
        End If

        '添加到已选列表
        DGV_tester.Rows.Add(1)
        DGV_tester(0, DGV_tester.Rows.Count - 1).Value = LB_tester.SelectedItem

        '插入RLS_TESTER数据库
        mysql = "INSERT INTO RLS_TESTER (InternalProduct,Customer,Flow,Grp,Tester,Releaser,ReleaseDate) VALUES ( '" &
    combo_prod.Text & "','" & combo_cust.Text & "','" & combo_flow.Text & "','" & combo_grp.Text & "','" & LB_tester.SelectedItem & "','" & UserID & "','" & Now() & "')"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()

        '从未选列表删除
        LB_tester.Items.RemoveAt(LB_tester.SelectedIndex)
        LB_tester.Refresh()


    End Sub

    Private Sub btn_assy_new_Click(sender As Object, e As EventArgs) Handles btn_assy_new.Click

        Dim mysql As String
        Dim mydataset As New DataSet


        If LB_Assy.SelectedIndex = -1 Then
            MsgBox("请先选择要添加之配件!")
            Exit Sub
        End If

        '添加到已选列表
        DGV_Assy.Rows.Add(1)
        DGV_Assy(0, DGV_Assy.Rows.Count - 1).Value = LB_Assy.SelectedItem

        '插入RLS_ASSY数据库
        mysql = "INSERT INTO RLS_ASSY (InternalProduct,Customer,Flow,PartNo,PartID,Releaser,ReleaseDate) VALUES ( '" &
    combo_prod.Text & "','" & combo_cust.Text & "','" & combo_flow.Text & "','" & combo_part.Text & "','" & LB_Assy.SelectedItem & "','" & UserID & "','" & Now() & "')"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()

        '从未选列表删除
        LB_Assy.Items.RemoveAt(LB_Assy.SelectedIndex)
        LB_Assy.Refresh()


    End Sub



    Private Sub btn_del_Click(sender As Object, e As EventArgs) Handles btn_del.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        If DGV_tester.Rows.Count = 0 Then Exit Sub

        If DGV_tester.CurrentCell.RowIndex = -1 Then
            MsgBox("请先选择要删除之机台!")
            Exit Sub
        End If

        '添加到未选列表
        LB_tester.Items.Add(DGV_tester(0, DGV_tester.CurrentCell.RowIndex).Value)
        LB_tester.Refresh()

        '从RLS_TESTER数据库删除
        mysql = "DELETE FROM RLS_TESTER WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND Grp='" & combo_grp.Text & "' AND Tester='" & DGV_tester(0, DGV_tester.CurrentCell.RowIndex).Value & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()


        '从已选列表删除
        DGV_tester.Rows.RemoveAt(DGV_tester.CurrentCell.RowIndex)


    End Sub

    Private Sub btn_assy_del_Click(sender As Object, e As EventArgs) Handles btn_assy_del.Click


        Dim mysql As String
        Dim mydataset As New DataSet

        If DGV_Assy.Rows.Count = 0 Then Exit Sub

        If DGV_Assy.CurrentCell.RowIndex = -1 Then
            MsgBox("请先选择要删除之配件!")
            Exit Sub
        End If

        '添加到未选列表
        LB_Assy.Items.Add(DGV_Assy(0, DGV_Assy.CurrentCell.RowIndex).Value)
        LB_Assy.Refresh()

        '从RLS_ASSY 数据库删除
        mysql = "DELETE FROM RLS_ASSY WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND PartNo='" & combo_part.Text & "' AND PartID='" & DGV_Assy(0, DGV_Assy.CurrentCell.RowIndex).Value & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()
        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconn.Close()


        '从已选列表删除
        DGV_Assy.Rows.RemoveAt(DGV_Assy.CurrentCell.RowIndex)

    End Sub



    Private Sub btn_tester_ok_Click(sender As Object, e As EventArgs) Handles btn_tester_ok.Click

        Dim mysql As String
        Dim mydataset As New DataSet
        Dim disableflag As Boolean, disablereason As String

        For i = 0 To DGV_tester.Rows.Count - 1

            If IsDBNull(DGV_tester(1, i).Value) = True Then
                disableflag = False
            Else
                disableflag = DGV_tester(1, i).Value
            End If

            If IsDBNull(DGV_tester(2, i).Value) = True Then
                disablereason = ""
            Else
                disablereason = DGV_tester(2, i).Value
            End If

            If disableflag = True Then

                mysql = "UPDATE  RLS_TESTER SET Disable= '" & True & "', DisableDate='" & Now() & "', Disabler='" & UserID & "', DisableReason='" & disablereason &
                "' WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND Grp='" & combo_grp.Text & "' AND Tester='" & DGV_tester(0, i).Value & "'"
            Else

                mysql = "UPDATE  RLS_TESTER SET Disable= '" & False & "', DisableDate='" & DBNull.Value & "', Disabler='" & "" & "', DisableReason='" & "" &
                "' WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND Grp='" & combo_grp.Text & "' AND Tester='" & DGV_tester(0, i).Value & "'"
            End If

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

        Next

        MsgBox("设定OK!", vbOKOnly + vbInformation)


    End Sub

    Private Sub btn_assy_ok_Click(sender As Object, e As EventArgs) Handles btn_assy_ok.Click

        Dim mysql As String
        Dim mydataset As New DataSet
        Dim disableflag As Boolean, disablereason As String

        For i = 0 To DGV_Assy.Rows.Count - 1

            If IsDBNull(DGV_Assy(1, i).Value) = True Then
                disableflag = False
            Else
                disableflag = DGV_Assy(1, i).Value
            End If

            If IsDBNull(DGV_Assy(2, i).Value) = True Then
                disablereason = ""
            Else
                disablereason = DGV_Assy(2, i).Value
            End If

            If disableflag = True Then

                mysql = "UPDATE  RLS_ASSY SET Disable= '" & True & "', DisableDate='" & Now() & "', Disabler='" & UserID & "', DisableReason='" & disablereason &
                "' WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND PartNo='" & combo_part.Text & "' AND PartID='" & DGV_Assy(0, i).Value & "'"
            Else

                mysql = "UPDATE  RLS_ASSY SET Disable= '" & False & "', DisableDate='" & DBNull.Value & "', Disabler='" & "" & "', DisableReason='" & "" &
                "' WHERE InternalProduct='" & combo_prod.Text & "' AND Flow='" & combo_flow.Text & "' AND PartNo='" & combo_part.Text & "' AND PartID='" & DGV_Assy(0, i).Value & "'"
            End If

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()
            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconn.Close()

        Next

        MsgBox("设定OK!", vbOKOnly + vbInformation)

    End Sub


    Private Sub btn_tester_exit_Click(sender As Object, e As EventArgs) Handles btn_tester_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_assy_exit_Click(sender As Object, e As EventArgs) Handles btn_assy_exit.Click
        Me.Close()
    End Sub


End Class