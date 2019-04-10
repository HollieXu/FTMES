Imports System.Data.SqlClient

Public Class frmEquipment


    Private Sub combo_type_DropDown(sender As Object, e As EventArgs) Handles combo_type.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet
        combo_type.Items.Add("*")
        mysql = "select DISTINCT Type from Equipment"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            combo_type.Items.Add("Query Equipment List Fail !")
        Else

            combo_type.Items.Clear()

            'List All customer
            For i = 0 To mydataset.Tables("Equipment").Rows.Count - 1
                combo_type.Items.Add(mydataset.Tables("Equipment").Rows(i).Item(0))
            Next


        End If
    End Sub


    Private Sub combo_grp_DropDown(sender As Object, e As EventArgs) Handles combo_grp.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Grp from Equipment where Type='" & combo_type.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            MsgBox("Query Equipment List Fail !")

        Else

            combo_grp.Items.Clear()
            'List All customer

            For i = 0 To mydataset.Tables("Equipment").Rows.Count - 1
                combo_grp.Items.Add(mydataset.Tables("Equipment").Rows(i).Item(0))
            Next


        End If
    End Sub



    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_equipment.DataSource = Nothing
        DGV_equipment.DataSource = Nothing

        If combo_type.Text = "" Then
            MsgBox("Please select equipment first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If combo_type.Text = "*" Then
            mysql = "select * from Equipment where Type='" & combo_type.Text & "'"
        ElseIf combo_grp.Text <> "*" Then
            mysql = "select * from Equipment where Type='" & combo_type.Text & "' AND Grp='" & combo_grp.Text & "'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            DGV_equipment.DataSource = Nothing

        Else
            DGV_equipment.DataSource = mydataset.Tables("Equipment")
        End If
    End Sub

    Private Sub btn_equipment_new_Click(sender As Object, e As EventArgs) Handles btn_equipment_new.Click
        Equipment_Operation_Mode = "NEW"
        frmEquipset.Show()

    End Sub

    Private Sub btn_equipment_modify_Click(sender As Object, e As EventArgs) Handles btn_equipment_modify.Click

        Equipment_Operation_Mode = "MODIFY"


        If DGV_equipment.Rows.Count = 0 Then Exit Sub
        myequip.type = DGV_equipment.SelectedRows(0).Cells("Type").Value.ToString
        myequip.grp = DGV_equipment.SelectedRows(0).Cells("Grp").Value.ToString
        myequip.ID = DGV_equipment.SelectedRows(0).Cells("ID").Value.ToString
        myequip.SN = DGV_equipment.SelectedRows(0).Cells("SN").Value.ToString
        myequip.manufacturer = DGV_equipment.SelectedRows(0).Cells("manufacturer").Value.ToString
        myequip.supplier = DGV_equipment.SelectedRows(0).Cells("supplier").Value.ToString
        myequip.inputdate = DGV_equipment.SelectedRows(0).Cells("InputDate").Value
        myequip.config = DGV_equipment.SelectedRows(0).Cells("config").Value.ToString
        myequip.attach = DGV_equipment.SelectedRows(0).Cells("Attachment").Value.ToString
        myequip.floor = DGV_equipment.SelectedRows(0).Cells("Floor").Value.ToString
        myequip.position = DGV_equipment.SelectedRows(0).Cells("Position").Value.ToString

        If myequip.type = "Handler" Then
            myequip.sysno = DGV_equipment.SelectedRows(0).Cells("SystemNo").Value.ToString
            myequip.model = DGV_equipment.SelectedRows(0).Cells("Model").Value.ToString
            myequip.state = DGV_equipment.SelectedRows(0).Cells("State").Value.ToString
            myequip.version = DGV_equipment.SelectedRows(0).Cells("Version").Value.ToString
            myequip.license = DGV_equipment.SelectedRows(0).Cells("License").Value.ToString
            myequip.pmdate = DGV_equipment.SelectedRows(0).Cells("PMDate").Value.ToString
            myequip.nextpmdate = DGV_equipment.SelectedRows(0).Cells("NextPMDate").Value.ToString

        End If

        frmEquipset.Show()

    End Sub

    Private Sub btn_equipment_disable_Click(sender As Object, e As EventArgs) Handles btn_equipment_disable.Click

        If DGV_equipment.Rows.Count = 0 Then Exit Sub

        myequip.ID = DGV_equipment.SelectedRows(0).Cells("ID").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要停用该设备吗", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Equipment SET ENABLE= '" & False & " ' WHERE ID= '" & myequip.ID & "'"

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

    Private Sub btn_equipment_delete_Click(sender As Object, e As EventArgs) Handles btn_equipment_delete.Click
        Dim mysql As String, s As Integer

        If DGV_equipment.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myequip.ID = DGV_equipment.SelectedRows(0).Cells("ID").Value

            mysql = "DELETE FROM Equipment WHERE ID='" & myequip.ID & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_equipment_enable_Click(sender As Object, e As EventArgs) Handles btn_equipment_enable.Click

        If DGV_equipment.Rows.Count = 0 Then Exit Sub

        myequip.ID = DGV_equipment.SelectedRows(0).Cells("ID").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要启用该设备吗", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Equipment SET ENABLE= '" & True & " ' WHERE ID= '" & myequip.ID & "'"

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

    Private Sub frmEquipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_equipment_delete.Visible = True
            Case GROUPTYPE.MGR
                btn_equipment_delete.Enabled = False

            Case GROUPTYPE.ENG
                btn_equipment_delete.Enabled = False

                '工程师级别限定EAE工号才有新增/修改/启用/停用 权限
                If Strings.Left(UserID + "0000", 4) <> "0032" Then
                    btn_equipment_new.Enabled = False
                    btn_equipment_modify.Enabled = False
                    btn_equipment_enable.Enabled = False
                    btn_equipment_disable.Enabled = False
                End If

            Case GROUPTYPE.OP
                btn_equipment_new.Enabled = False
                btn_equipment_modify.Enabled = False
                btn_equipment_enable.Enabled = False
                btn_equipment_disable.Enabled = False
                btn_equipment_delete.Enabled = False

        End Select


        Me.BackColor = mydefaultcolor
        DGV_equipment.BackgroundColor = mydefaultcolor

    End Sub

    Private Sub combo_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_type.SelectedIndexChanged
        'combo_type.Items.Add("*")
    End Sub
End Class