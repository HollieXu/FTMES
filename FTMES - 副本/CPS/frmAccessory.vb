Imports System.Data.SqlClient

Public Class frmAccessory


    Private Sub frmAccessory_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_accessory_delete.Visible = True
            Case GROUPTYPE.MGR
                btn_accessory_delete.Enabled = False

            Case GROUPTYPE.ENG
                btn_accessory_delete.Enabled = False

                '工程师级别限定EAE工号才有新增/修改/启用/停用 权限
                If Strings.Left(UserID + "0000", 4) <> "0032" Then
                    btn_assessory_new.Enabled = False
                    btn_accessory_modify.Enabled = False
                    btn_accessory_enable.Enabled = False
                    btn_accessory_disable.Enabled = False
                End If

            Case GROUPTYPE.OP
                btn_assessory_new.Enabled = False
                btn_accessory_modify.Enabled = False
                btn_accessory_enable.Enabled = False
                btn_accessory_disable.Enabled = False
                btn_accessory_delete.Enabled = False

        End Select

        Me.BackColor = mydefaultcolor
        DGV_Accessory.BackgroundColor = mydefaultcolor

        combo_type.Text = "Load Board"

    End Sub



    Private Sub combo_type_DropDown(sender As Object, e As EventArgs) Handles combo_type.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Type from Accessory"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Accessory")

        If mydataset.Tables("Accessory").Rows.Count = 0 Then
            combo_type.Items.Add("Query Fail !")
        Else

            combo_type.Items.Clear()
            For i = 0 To mydataset.Tables("Accessory").Rows.Count - 1
                combo_type.Items.Add(mydataset.Tables("Accessory").Rows(i).Item(0))
            Next

        End If

    End Sub



    Private Sub combo_grp_DropDown(sender As Object, e As EventArgs) Handles combo_grp.DropDown


        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Grp from Accessory where Type='" & combo_type.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Accessory")

        If mydataset.Tables("Accessory").Rows.Count = 0 Then
            combo_grp.Items.Add("Query Fail !")
        Else

            combo_grp.Items.Clear()
            combo_grp.Items.Add("*")

            For i = 0 To mydataset.Tables("Accessory").Rows.Count - 1
                combo_grp.Items.Add(mydataset.Tables("Accessory").Rows(i).Item(0))
            Next

        End If

    End Sub



    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Customer from Accessory where Type='" & combo_type.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Accessory")

        If mydataset.Tables("Accessory").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Fail !")
        Else

            combo_cust.Items.Clear()
            combo_cust.Items.Add("*")

            For i = 0 To mydataset.Tables("Accessory").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Accessory").Rows(i).Item(0))
            Next

        End If

    End Sub

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_Accessory.DataSource = Nothing

        If combo_grp.Text = "*" Then

            If combo_cust.Text = "*" Then
                mysql = "select * from Accessory where Type='" & combo_type.Text & "'"
            Else
                mysql = "select * from Accessory where Type='" & combo_type.Text & "' AND Customer='" & combo_cust.Text & "'"
            End If

        ElseIf combo_grp.Text <> "*" Then

            If combo_cust.Text = "*" Then
                mysql = "select * from Accessory where Type='" & combo_type.Text & "' AND Grp='" & combo_grp.Text & "'"
            Else
                mysql = "select * from Accessory where Type='" & combo_type.Text & "' AND Grp='" & combo_grp.Text & "' AND Customer='" & combo_cust.Text & "'"
            End If

        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Accessory")

        If mydataset.Tables("Accessory").Rows.Count = 0 Then
            DGV_Accessory.DataSource = Nothing

        Else
            DGV_Accessory.DataSource = mydataset.Tables("Accessory")
        End If


    End Sub

    Private Sub btn_assessory_new_Click(sender As Object, e As EventArgs) Handles btn_assessory_new.Click
        Accessary_Operation_Mode = "NEW"
        frmAssySet.Show()

    End Sub

    Private Sub btn_accessory_modify_Click(sender As Object, e As EventArgs) Handles btn_accessory_modify.Click
        Accessary_Operation_Mode = "MODIFY"
        If DGV_Accessory.Rows.Count = 0 Then Exit Sub
        myassy.type = DGV_Accessory.SelectedRows(0).Cells("Type").Value.ToString
            myassy.grp = DGV_Accessory.SelectedRows(0).Cells("Grp").Value.ToString
            myassy.cust = DGV_Accessory.SelectedRows(0).Cells("Customer").Value.ToString
            myassy.prod = DGV_Accessory.SelectedRows(0).Cells("Product").Value.ToString
            myassy.partno = DGV_Accessory.SelectedRows(0).Cells("Partnumber").Value.ToString
            myassy.package = DGV_Accessory.SelectedRows(0).Cells("Package").Value.ToString
        myassy.state = DGV_Accessory.SelectedRows(0).Cells("State").Value.ToString
        myassy.id = DGV_Accessory.SelectedRows(0).Cells("ID").Value.ToString
        myassy.owner = DGV_Accessory.SelectedRows(0).Cells("Ownership").Value.ToString
            myassy.ioside = DGV_Accessory.SelectedRows(0).Cells("IOside").Value.ToString
            myassy.location = DGV_Accessory.SelectedRows(0).Cells("Location").Value.ToString
            myassy.manufact = DGV_Accessory.SelectedRows(0).Cells("manufacturer").Value.ToString
            myassy.supplier = DGV_Accessory.SelectedRows(0).Cells("supplier").Value.ToString
            myassy.inputdate = DGV_Accessory.SelectedRows(0).Cells("InputDate").Value.ToString
            myassy.remark = DGV_Accessory.SelectedRows(0).Cells("remark").Value.ToString
            myassy.attach = DGV_Accessory.SelectedRows(0).Cells("Attachment").Value.ToString
        ' Else
        If myassy.type = "SOCKET" Then
            myassy.live = DGV_Accessory.SelectedRows(0).Cells("LifeSpan").Value.ToString
        ElseIf myassy.type = "KIT" Then
            myassy.site = DGV_Accessory.SelectedRows(0).Cells("SiteMap").Value.ToString
            myassy.fit = DGV_Accessory.SelectedRows(0).Cells("Fitmachine").Value.ToString
            myassy.thick = DGV_Accessory.SelectedRows(0).Cells("Thick").Value.ToString
        End If
        frmAssySet.Show()
    End Sub

    Private Sub btn_accessory_disable_Click(sender As Object, e As EventArgs) Handles btn_accessory_disable.Click

        If DGV_Accessory.Rows.Count = 0 Then Exit Sub

        myassy.id = DGV_Accessory.SelectedRows(0).Cells("ID").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要停用该设备吗", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Accessory SET ENABLE= '" & False & " ' WHERE ID= '" & myassy.id & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbExclamation)
            End Try

            myconn.Close()

            Call btn_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_accessory_enable_Click(sender As Object, e As EventArgs) Handles btn_accessory_enable.Click

        If DGV_Accessory.Rows.Count = 0 Then Exit Sub

        myassy.id = DGV_Accessory.SelectedRows(0).Cells("ID").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要启用该设备吗", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Accessory SET ENABLE= '" & True & " ' WHERE ID= '" & myassy.id & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbExclamation)
            End Try

            myconn.Close()

            Call btn_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_accessory_delete_Click(sender As Object, e As EventArgs) Handles btn_accessory_delete.Click

        Dim mysql As String, s As Integer

        If DGV_Accessory.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myassy.id = DGV_Accessory.SelectedRows(0).Cells("ID").Value

            mysql = "DELETE FROM Accessory WHERE ID='" & myassy.id & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbExclamation)
            End Try

            myconn.Close()


            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_Query_Click("", e)

        End If


    End Sub

    Private Sub combo_grp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_grp.SelectedIndexChanged

    End Sub
End Class