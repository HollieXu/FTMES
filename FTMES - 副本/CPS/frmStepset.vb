Imports System.Data.SqlClient

Public Class frmStepset


    Private Sub StepDefineForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "Step recipe define for    CUSTOMER -> " & myProduct.Customer & ",    PRODUCT -> " & myProduct.InternalProduct
        Me.Left = 10
        Me.Top = 10

        If UserGroup = GROUPTYPE.SU Then
            btn_IQC_delete.Visible = True
            btn_FQC_delete.Visible = True
            btn_CP_delete.Visible = True
            btn_BAKE_delete.Visible = True
            btn_cpdt_delete.Visible = True
            btn_wipfs_delete.Visible = True
            btn_pack_delete.Visible = True
            btn_ship_delete.Visible = True
        End If

        Me.BackColor = mydefaultcolor
        TabControl1.TabPages(0).BackColor = mydefaultcolor
        TabControl1.TabPages(1).BackColor = mydefaultcolor
        TabControl1.TabPages(2).BackColor = mydefaultcolor
        TabControl1.TabPages(3).BackColor = mydefaultcolor
        TabControl1.TabPages(4).BackColor = mydefaultcolor
        TabControl1.TabPages(5).BackColor = mydefaultcolor
        TabControl1.TabPages(6).BackColor = mydefaultcolor
        TabControl1.TabPages(7).BackColor = mydefaultcolor

        Me.Height = My.Computer.Screen.Bounds.Height * 0.9

    End Sub

    Private Sub ClearPara()

        txt_IQC_id.Text = ""
        txt_IQC_lot.Text = ""
        txt_IQC_SamplePlan.Text = ""
        txt_IQC_WI.Text = ""
        txt_IQC_InspectionArea.Text = ""
        combo_IQC_type.Text = ""

        txt_FQC_ID.Text = ""
        txt_FQC_lot.Text = ""
        txt_FQC_SamplePlan.Text = ""
        txt_FQC_WI.Text = ""
        txt_FQC_InspectionArea.Text = ""
        combo_FQC_type.Text = ""
        txt_FQC_Probemark.Text = ""


        txt_cp_id.Text = ""
        combo_cp_flow.Text = ""
        combo_cp_type.Text = ""
        txt_cp_lot.Text = ""
        combo_cp_tester.Text = ""
        txt_cp_OS.Text = ""
        txt_cp_sw.Text = ""
        txt_cp_tt.Text = ""
        txt_cp_pid.Text = ""
        txt_cp_pgm.Text = ""
        txt_cp_probecard.Text = ""
        txt_cp_pib.Text = ""
        combo_cp_prober.Text = ""
        txt_cp_setupfile.Text = ""
        txt_cp_temp.Text = ""
        txt_cp_dc.Text = ""
        txt_cp_od.Text = ""
        combo_cp_cleanmethod.Text = ""
        combo_cp_sheetmaterial.Text = ""
        txt_cp_cleanfreq.Text = ""
        txt_cp_updown.Text = ""

        txt_cp_testeroperation.Text = ""
        txt_cp_proberoperation.Text = ""
        txt_cp_holdtiming.Text = ""
        txt_cp_remark.Text = ""



        txt_BAKE_id.Text = ""
        combo_BAKE_flow.Text = ""
        txt_BAKE_lot.Text = ""
        combo_BAKE_type.Text = ""
        combo_bake_recipe.Text = ""
        txt_bake_temp.Text = ""
        txt_bake_time.Text = ""
        txt_bake_remark.Text = ""

        txt_cpdt_id.Text = ""
        combo_cpdt_flow.Text = ""
        txt_cpdt_lot.Text = ""
        combo_cpdt_type.Text = ""
        txt_cpdt_hold.Text = ""
        txt_cpdt_operation.Text = ""

        txt_wipfs_id.Text = ""
        txt_wipfs_lot.Text = ""
        combo_wipfs_type.Text = ""
        combo_mappingflow.Text = ""
        txt_wipfs_operation.Text = ""

        txt_pack_id.Text = ""
        txt_pack_lot.Text = ""
        combo_pack_type.Text = ""
        txt_pack_operation.Text = ""
        txt_pack_recipe.Text = ""

        txt_ship_id.Text = ""
        txt_ship_lot.Text = ""
        combo_ship_type.Text = ""
        txt_ship_operation.Text = ""

    End Sub



    ''''''''''''''''''''''''''''''''''''''''
    '''IQC Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_IQC_Query_Click(sender As Object, e As EventArgs) Handles btn_IQC_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_IQC_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_IQC")

        If mydataset.Tables("Recipe_IQC").Rows.Count = 0 Then
            DGV_IQC.DataSource = Nothing

        Else

            DGV_IQC.DataSource = mydataset.Tables("Recipe_IQC")
            DGV_IQC.Columns(0).Width = COLUMNWIDTH * 1.5

        End If


    End Sub

    Private Sub btn_IQC_new_Click(sender As Object, e As EventArgs) Handles btn_IQC_new.Click

        StepDefine_Mode = "NEW"
        grp_IQC_para.Visible = True
        ClearPara()

    End Sub

    Private Sub btn_IQC_modify_Click(sender As Object, e As EventArgs) Handles btn_IQC_modify.Click


        StepDefine_Mode = "MODIFY"

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        grp_IQC_para.Visible = True

        txt_IQC_id.Text = DGV_IQC.SelectedRows(0).Cells("ID").Value
        txt_IQC_id.ReadOnly = True
        txt_IQC_lot.Text = DGV_IQC.SelectedRows(0).Cells("Lot").Value
        combo_IQC_type.Text = DGV_IQC.SelectedRows(0).Cells("Type").Value
        txt_IQC_SamplePlan.Text = DGV_IQC.SelectedRows(0).Cells("SamplingPlan").Value
        txt_IQC_InspectionArea.Text = DGV_IQC.SelectedRows(0).Cells("InspectionArea").Value
        txt_IQC_WI.Text = DGV_IQC.SelectedRows(0).Cells("Standard").Value


    End Sub

    Private Sub btn_iqc_copy_Click(sender As Object, e As EventArgs) Handles btn_iqc_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        grp_IQC_para.Visible = True
        txt_IQC_id.Text = ""
        txt_IQC_lot.Text = DGV_IQC.SelectedRows(0).Cells("Lot").Value
        combo_IQC_type.Text = DGV_IQC.SelectedRows(0).Cells("Type").Value
        txt_IQC_SamplePlan.Text = DGV_IQC.SelectedRows(0).Cells("SamplingPlan").Value
        txt_IQC_InspectionArea.Text = DGV_IQC.SelectedRows(0).Cells("InspectionArea").Value
        txt_IQC_WI.Text = DGV_IQC.SelectedRows(0).Cells("Standard").Value

    End Sub

    Private Sub btn_IQC_disable_Click(sender As Object, e As EventArgs) Handles btn_IQC_disable.Click

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_IQC.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_IQC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_IQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_IQC_Query_Click("", e)

        End If

    End Sub

    Private Sub btn_IQC_delete_Click(sender As Object, e As EventArgs) Handles btn_IQC_delete.Click


        Dim mysql As String, s As Integer

        If DGV_IQC.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_IQC WHERE ID ='" & DGV_IQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_IQC_Query_Click("", e)

        End If


    End Sub

    Private Sub btn_IQC_cancel_Click(sender As Object, e As EventArgs) Handles btn_IQC_cancel.Click
        Me.Close()
    End Sub

    Private Sub combo_IQC_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_IQC_type.SelectedIndexChanged
        If combo_IQC_type.Text = "SEN" Then
            txt_IQC_lot.ReadOnly = False
            txt_IQC_lot.Text = ""
        ElseIf combo_IQC_type.Text = "ECN" Then
            txt_IQC_lot.ReadOnly = True
            txt_IQC_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_IQC_confirm_Click(sender As Object, e As EventArgs) Handles btn_IQC_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_IQC_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If



        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_IQC_type.Text = "ECN" Then

                mysql = "select * from Recipe_IQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_IQC")

                If mydataset.Tables("Recipe_IQC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

            End If

            '往数据库插入

            If combo_IQC_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_IQC_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_IQC (ID,Customer,InternalProduct,Type,FlowName,Lot,SamplingPlan,InspectionArea,Standard,ENABLE,CreateTime,Creater) VALUES ( '" &
                ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_IQC_type.Text & "','" & "IQC" & "','" & txt_IQC_lot.Text & "','" &
                txt_IQC_SamplePlan.Text & "','" & txt_IQC_InspectionArea.Text & "','" & txt_IQC_WI.Text & "','TRUE','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_IQC_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_IQC SET LOT= '" & txt_IQC_lot.Text & "',SamplingPlan= '" & txt_IQC_SamplePlan.Text & "',InspectionArea= '" & txt_IQC_InspectionArea.Text & "', Standard= '" & txt_IQC_WI.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_IQC_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_IQC_Query_Click("", e)

            End If

        End If




    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    '''FQC Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_FQC_query_Click(sender As Object, e As EventArgs) Handles btn_FQC_query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_FQC_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_FQC")

        If mydataset.Tables("Recipe_FQC").Rows.Count = 0 Then
            DGV_FQC.DataSource = Nothing

        Else

            DGV_FQC.DataSource = mydataset.Tables("Recipe_FQC")
            DGV_FQC.Columns(0).Width = COLUMNWIDTH * 1.5

        End If


    End Sub

    Private Sub btn_FQC_new_Click(sender As Object, e As EventArgs) Handles btn_FQC_new.Click

        StepDefine_Mode = "NEW"
        grp_FQC_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_FQC_modify_Click(sender As Object, e As EventArgs) Handles btn_FQC_modify.Click

        StepDefine_Mode = "MODIFY"

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        grp_FQC_para.Visible = True

        txt_FQC_ID.Text = DGV_FQC.SelectedRows(0).Cells("ID").Value
        txt_FQC_ID.ReadOnly = True
        txt_FQC_lot.Text = DGV_FQC.SelectedRows(0).Cells("Lot").Value
        combo_FQC_type.Text = DGV_FQC.SelectedRows(0).Cells("Type").Value
        txt_FQC_SamplePlan.Text = DGV_FQC.SelectedRows(0).Cells("SamplingPlan").Value
        txt_FQC_InspectionArea.Text = DGV_FQC.SelectedRows(0).Cells("InspectionArea").Value
        txt_FQC_WI.Text = DGV_FQC.SelectedRows(0).Cells("Standard").Value
        txt_FQC_Probemark.Text = DGV_FQC.SelectedRows(0).Cells("ProbeMark").Value.ToString

    End Sub

    Private Sub btn_FQC_copy_Click(sender As Object, e As EventArgs) Handles btn_FQC_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        grp_FQC_para.Visible = True

        txt_FQC_ID.Text = ""
        txt_FQC_lot.Text = DGV_FQC.SelectedRows(0).Cells("Lot").Value
        combo_FQC_type.Text = DGV_FQC.SelectedRows(0).Cells("Type").Value
        txt_FQC_SamplePlan.Text = DGV_FQC.SelectedRows(0).Cells("SamplingPlan").Value
        txt_FQC_InspectionArea.Text = DGV_FQC.SelectedRows(0).Cells("InspectionArea").Value
        txt_FQC_WI.Text = DGV_FQC.SelectedRows(0).Cells("Standard").Value
        txt_FQC_Probemark.Text = DGV_FQC.SelectedRows(0).Cells("ProbeMark").Value

    End Sub

    Private Sub btn_FQC_disable_Click(sender As Object, e As EventArgs) Handles btn_FQC_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_FQC.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_FQC SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_FQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("已成功停用!", vbOKOnly + vbInformation)
            Call btn_FQC_query_Click("", e)

        End If

    End Sub

    Private Sub btn_FQC_delete_Click(sender As Object, e As EventArgs) Handles btn_FQC_delete.Click
        Dim mysql As String, s As Integer

        If DGV_FQC.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_FQC WHERE ID ='" & DGV_FQC.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_FQC_query_Click("", e)

        End If

    End Sub

    Private Sub btn_FQC_exit_Click(sender As Object, e As EventArgs) Handles btn_FQC_exit.Click
        Me.Close()
    End Sub

    Private Sub combo_FQC_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_FQC_type.SelectedIndexChanged
        If combo_FQC_type.Text = "SEN" Then
            txt_FQC_lot.ReadOnly = False
            txt_FQC_lot.Text = ""
        ElseIf combo_FQC_type.Text = "ECN" Then
            txt_FQC_lot.ReadOnly = True
            txt_FQC_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_FQC_confirm_Click(sender As Object, e As EventArgs) Handles btn_FQC_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_FQC_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_FQC_type.Text = "ECN" Then
                mysql = "select * from Recipe_FQC where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_FQC")

                If mydataset.Tables("Recipe_FQC").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_FQC_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_FQC_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_FQC (ID,Customer,InternalProduct,Type,FlowName,Lot,SamplingPlan,InspectionArea,Standard,ENABLE,ProbeMark,CreateTime,Creater) VALUES ( '" &
                ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_FQC_type.Text & "','" & "FQC" & "','" & txt_FQC_lot.Text & "','" &
                txt_FQC_SamplePlan.Text & "','" & txt_FQC_InspectionArea.Text & "','" & txt_FQC_WI.Text & "','TRUE','" & txt_FQC_Probemark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_FQC_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_FQC SET LOT= '" & txt_FQC_lot.Text & "',SamplingPlan= '" & txt_FQC_SamplePlan.Text & "',InspectionArea= '" & txt_FQC_InspectionArea.Text & "', Standard= '" & txt_FQC_WI.Text & "',ProbeMark='" & txt_FQC_Probemark.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_FQC_ID.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()
                MsgBox("已成功修改!", vbOKOnly + vbInformation)
                ClearPara()
                Call btn_FQC_query_Click("", e)

            End If

        End If
    End Sub

    ''''''''''''''''''''''''''''''''''''''''
    '''CP Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_CP_Query_Click(sender As Object, e As EventArgs) Handles btn_CP_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_cp_enable.Text
            Case "ENABLE"

                If combo_cp_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_CP where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_CP where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND FlowName='" & combo_cp_flowquery.Text & "'"
                End If

            Case "ALL"
                If combo_cp_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_CP where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_CP where InternalProduct='" & myProduct.InternalProduct & "'AND FlowName='" & combo_cp_flowquery.Text & "'"
                End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_CP")

        If mydataset.Tables("Recipe_CP").Rows.Count = 0 Then
            DGV_CP.DataSource = Nothing

        Else

            DGV_CP.DataSource = mydataset.Tables("Recipe_CP")
            DGV_CP.Columns(0).Width = COLUMNWIDTH * 1.5

        End If

    End Sub

    Private Sub btn_CP_new_Click(sender As Object, e As EventArgs) Handles btn_CP_new.Click

        StepDefine_Mode = "NEW"
        grp_CP_para.Visible = True
        ClearPara()

    End Sub

    Private Sub btn_CP_modify_Click(sender As Object, e As EventArgs) Handles btn_CP_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_CP.Rows.Count = 0 Then Exit Sub

        grp_CP_para.Visible = True

        txt_cp_id.Text = DGV_CP.SelectedRows(0).Cells("ID").Value
        txt_cp_id.ReadOnly = True

        combo_cp_flow.Text = DGV_CP.SelectedRows(0).Cells("FlowName").Value
        combo_cp_type.Text = DGV_CP.SelectedRows(0).Cells("Type").Value
        txt_cp_lot.Text = DGV_CP.SelectedRows(0).Cells("Lot").Value
        combo_cp_tester.Text = DGV_CP.SelectedRows(0).Cells("tester").Value
        txt_cp_OS.Text = DGV_CP.SelectedRows(0).Cells("OS").Value
        txt_cp_sw.Text = DGV_CP.SelectedRows(0).Cells("sw").Value
        txt_cp_tt.Text = DGV_CP.SelectedRows(0).Cells("tt").Value
        txt_cp_pid.Text = DGV_CP.SelectedRows(0).Cells("pid").Value
        txt_cp_pgm.Text = DGV_CP.SelectedRows(0).Cells("pgm").Value
        txt_cp_probecard.Text = DGV_CP.SelectedRows(0).Cells("probecard").Value
        txt_cp_pib.Text = DGV_CP.SelectedRows(0).Cells("pib").Value
        combo_cp_prober.Text = DGV_CP.SelectedRows(0).Cells("prober").Value
        txt_cp_setupfile.Text = DGV_CP.SelectedRows(0).Cells("setupfile").Value
        txt_cp_temp.Text = DGV_CP.SelectedRows(0).Cells("temp").Value
        txt_cp_dc.Text = DGV_CP.SelectedRows(0).Cells("dc").Value
        txt_cp_od.Text = DGV_CP.SelectedRows(0).Cells("od").Value

        combo_cp_cleanmethod.Text = DGV_CP.SelectedRows(0).Cells("cleanmethod").Value
        combo_cp_sheetmaterial.Text = DGV_CP.SelectedRows(0).Cells("sheetmaterial").Value
        txt_cp_cleanfreq.Text = DGV_CP.SelectedRows(0).Cells("cleanfreq").Value
        txt_cp_updown.Text = DGV_CP.SelectedRows(0).Cells("updown").Value

        txt_cp_testeroperation.Text = DGV_CP.SelectedRows(0).Cells("testeroperation").Value
        txt_cp_proberoperation.Text = DGV_CP.SelectedRows(0).Cells("proberoperation").Value
        txt_cp_holdtiming.Text = DGV_CP.SelectedRows(0).Cells("holdtiming").Value
        txt_cp_remark.Text = DGV_CP.SelectedRows(0).Cells("remark").Value
        txt_attachpic.Text = DGV_CP.SelectedRows(0).Cells("AttachPic").Value.ToString


    End Sub


    Private Sub btn_CP_copy_Click(sender As Object, e As EventArgs) Handles btn_CP_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_CP.Rows.Count = 0 Then Exit Sub

        grp_CP_para.Visible = True

        txt_cp_id.Text = ""

        combo_cp_flow.Text = DGV_CP.SelectedRows(0).Cells("FlowName").Value
        combo_cp_type.Text = DGV_CP.SelectedRows(0).Cells("Type").Value
        txt_cp_lot.Text = DGV_CP.SelectedRows(0).Cells("Lot").Value
        combo_cp_tester.Text = DGV_CP.SelectedRows(0).Cells("tester").Value
        txt_cp_OS.Text = DGV_CP.SelectedRows(0).Cells("OS").Value
        txt_cp_sw.Text = DGV_CP.SelectedRows(0).Cells("sw").Value
        txt_cp_tt.Text = DGV_CP.SelectedRows(0).Cells("tt").Value
        txt_cp_pid.Text = DGV_CP.SelectedRows(0).Cells("pid").Value
        txt_cp_pgm.Text = DGV_CP.SelectedRows(0).Cells("pgm").Value
        txt_cp_probecard.Text = DGV_CP.SelectedRows(0).Cells("probecard").Value
        txt_cp_pib.Text = DGV_CP.SelectedRows(0).Cells("pib").Value
        combo_cp_prober.Text = DGV_CP.SelectedRows(0).Cells("prober").Value
        txt_cp_setupfile.Text = DGV_CP.SelectedRows(0).Cells("setupfile").Value
        txt_cp_temp.Text = DGV_CP.SelectedRows(0).Cells("temp").Value
        txt_cp_dc.Text = DGV_CP.SelectedRows(0).Cells("dc").Value
        txt_cp_od.Text = DGV_CP.SelectedRows(0).Cells("od").Value

        combo_cp_cleanmethod.Text = DGV_CP.SelectedRows(0).Cells("cleanmethod").Value
        combo_cp_sheetmaterial.Text = DGV_CP.SelectedRows(0).Cells("sheetmaterial").Value
        txt_cp_cleanfreq.Text = DGV_CP.SelectedRows(0).Cells("cleanfreq").Value
        txt_cp_updown.Text = DGV_CP.SelectedRows(0).Cells("updown").Value

        txt_cp_testeroperation.Text = DGV_CP.SelectedRows(0).Cells("testeroperation").Value
        txt_cp_proberoperation.Text = DGV_CP.SelectedRows(0).Cells("proberoperation").Value
        txt_cp_holdtiming.Text = DGV_CP.SelectedRows(0).Cells("holdtiming").Value
        txt_cp_remark.Text = DGV_CP.SelectedRows(0).Cells("remark").Value
        txt_attachpic.Text = DGV_CP.SelectedRows(0).Cells("AttachPic").Value.ToString

    End Sub


    Private Sub combo_cp_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cp_type.SelectedIndexChanged
        If combo_cp_type.Text = "SEN" Then
            txt_cp_lot.ReadOnly = False
            txt_cp_lot.Text = ""
        ElseIf combo_cp_type.Text = "ECN" Then
            txt_cp_lot.ReadOnly = True
            txt_cp_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_CP_disable_Click(sender As Object, e As EventArgs) Handles btn_CP_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_CP.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_CP SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_CP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_CP_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_CP_delete_Click(sender As Object, e As EventArgs) Handles btn_CP_delete.Click
        Dim mysql As String, s As Integer

        If DGV_CP.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_CP WHERE ID ='" & DGV_CP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_CP_Query_Click("", e)

        End If
    End Sub


    Private Sub btn_CP_confirm_Click(sender As Object, e As EventArgs) Handles btn_cp_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_cp_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If





        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_cp_type.Text = "ECN" Then
                mysql = "select * from Recipe_CP where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN' AND FlowName='" & combo_cp_flow.Text & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_CP")

                If mydataset.Tables("Recipe_CP").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_cp_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_cp_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_cp (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,tester,os,sw,tt,pid,pgm,probecard,pib,prober,setupfile,temp,dc,od,cleanmethod,sheetmaterial,cleanfreq,updown,testeroperation,proberoperation,holdtiming,remark,AttachPic,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_cp_flow.Text & "','" & combo_cp_type.Text & "','TRUE','" & txt_cp_lot.Text & " ','" &
            combo_cp_tester.Text & "','" & txt_cp_OS.Text & "','" & txt_cp_sw.Text & "','" & txt_cp_tt.Text & "','" & txt_cp_pid.Text & "','" & txt_cp_pgm.Text & "','" & txt_cp_probecard.Text & "','" & txt_cp_pib.Text & "','" & combo_cp_prober.Text & "','" & txt_cp_setupfile.Text & "','" &
            txt_cp_temp.Text & "','" & txt_cp_dc.Text & "','" & txt_cp_od.Text & "','" & combo_cp_cleanmethod.Text & "','" & combo_cp_sheetmaterial.Text & "','" & txt_cp_cleanfreq.Text & "','" & txt_cp_updown.Text & "','" & txt_cp_testeroperation.Text & "','" & txt_cp_proberoperation.Text & "','" &
            txt_cp_holdtiming.Text & "','" & txt_cp_remark.Text & "','" & txt_attachpic.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_CP_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_CP SET LOT= '" & txt_cp_lot.Text & "',FlowName= '" & combo_cp_flow.Text & "',Type= '" & combo_cp_type.Text & "',tester= '" & combo_cp_tester.Text & "',os= '" & txt_cp_OS.Text & "', sw= '" & txt_cp_sw.Text & "',tt='" & txt_cp_tt.Text & "',pid='" & txt_cp_pid.Text &
                "',pgm='" & txt_cp_pgm.Text & "',probecard='" & txt_cp_probecard.Text & "',pib='" & txt_cp_pib.Text & "',prober='" & combo_cp_prober.Text & "',setupfile='" & txt_cp_setupfile.Text & "',temp='" & txt_cp_temp.Text &
                 "',dc='" & txt_cp_dc.Text & "',od='" & txt_cp_od.Text & "',cleanmethod='" & combo_cp_cleanmethod.Text & "',sheetmaterial='" & combo_cp_sheetmaterial.Text & "',cleanfreq='" & txt_cp_cleanfreq.Text & "',updown='" &
                 txt_cp_updown.Text & "',testeroperation='" & txt_cp_testeroperation.Text & "',proberoperation='" & txt_cp_proberoperation.Text & "',holdtiming='" & txt_cp_holdtiming.Text & "',remark='" & txt_cp_remark.Text & "',AttachPic='" & txt_attachpic.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_cp_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_CP_Query_Click("", e)

            End If

        End If
    End Sub

    Private Sub btn_cp_exit_Click(sender As Object, e As EventArgs) Handles btn_cp_exit.Click
        Me.Close()
    End Sub







    ''''''''''''''''''''''''''''''''''''''''
    '''BAKE Page Operation
    '''
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_BAKE_Query_Click(sender As Object, e As EventArgs) Handles btn_BAKE_Query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_BAKE_query.Text
            Case "ENABLE"

                If combo_bake_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND FlowName='" & combo_bake_flowquery.Text & "'"
                End If

            Case "ALL"
                If combo_bake_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND FlowName='" & combo_bake_flowquery.Text & "'"
                End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_BAKE")

        If mydataset.Tables("Recipe_BAKE").Rows.Count = 0 Then
            DGV_BAKE.DataSource = Nothing

        Else

            DGV_BAKE.DataSource = mydataset.Tables("Recipe_BAKE")
            DGV_BAKE.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_BAKE_new_Click(sender As Object, e As EventArgs) Handles btn_BAKE_new.Click
        StepDefine_Mode = "NEW"
        grp_bake_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_BAKE_modify_Click(sender As Object, e As EventArgs) Handles btn_BAKE_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        grp_bake_para.Visible = True

        txt_BAKE_id.Text = DGV_BAKE.SelectedRows(0).Cells("ID").Value
        txt_BAKE_id.ReadOnly = True

        combo_BAKE_flow.Text = DGV_BAKE.SelectedRows(0).Cells("FlowName").Value
        combo_BAKE_type.Text = DGV_BAKE.SelectedRows(0).Cells("Type").Value
        txt_BAKE_lot.Text = DGV_BAKE.SelectedRows(0).Cells("Lot").Value

        combo_bake_recipe.Text = DGV_BAKE.SelectedRows(0).Cells("Recipe").Value
        txt_bake_temp.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_time.Text = DGV_BAKE.SelectedRows(0).Cells("Time").Value
        txt_bake_remark.Text = DGV_BAKE.SelectedRows(0).Cells("Remark").Value.ToString

    End Sub

    Private Sub btn_BAKE_copy_Click(sender As Object, e As EventArgs) Handles btn_BAKE_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        grp_bake_para.Visible = True

        txt_BAKE_id.Text = ""

        combo_BAKE_flow.Text = DGV_BAKE.SelectedRows(0).Cells("FlowName").Value
        combo_BAKE_type.Text = DGV_BAKE.SelectedRows(0).Cells("Type").Value
        txt_BAKE_lot.Text = DGV_BAKE.SelectedRows(0).Cells("Lot").Value

        combo_bake_recipe.Text = DGV_BAKE.SelectedRows(0).Cells("Recipe").Value
        txt_bake_temp.Text = DGV_BAKE.SelectedRows(0).Cells("Temperature").Value
        txt_bake_time.Text = DGV_BAKE.SelectedRows(0).Cells("Time").Value
        txt_bake_remark.Text = DGV_BAKE.SelectedRows(0).Cells("Remark").Value.ToString


    End Sub

    Private Sub combo_BAKE_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_BAKE_type.SelectedIndexChanged
        If combo_BAKE_type.Text = "SEN" Then
            txt_BAKE_lot.ReadOnly = False
            txt_BAKE_lot.Text = ""
        ElseIf combo_BAKE_type.Text = "ECN" Then
            txt_BAKE_lot.ReadOnly = True
            txt_BAKE_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_BAKE_disable_Click(sender As Object, e As EventArgs) Handles btn_BAKE_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_BAKE.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_BAKE SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_BAKE.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("已成功停用!", vbOKOnly + vbInformation)
            Call btn_BAKE_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_BAKE_delete_Click(sender As Object, e As EventArgs) Handles btn_BAKE_delete.Click
        Dim mysql As String, s As Integer

        If DGV_BAKE.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_BAKE WHERE ID ='" & DGV_BAKE.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_BAKE_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_bake_confirm_Click(sender As Object, e As EventArgs) Handles btn_bake_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_BAKE_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_BAKE_type.Text = "ECN" Then
                mysql = "select * from Recipe_BAKE where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN' AND FlowName='" & combo_BAKE_flow.Text & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_BAKE")

                If mydataset.Tables("Recipe_BAKE").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_BAKE_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_BAKE_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_BAKE (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,Recipe,Temperature,Time,Remark,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_BAKE_flow.Text & "','" & combo_BAKE_type.Text & "','TRUE','" & txt_BAKE_lot.Text & " ','" & combo_bake_recipe.Text & " ','" &
            txt_bake_temp.Text & "','" & txt_bake_time.Text & "','" & txt_bake_remark.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_BAKE_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_BAKE SET LOT= '" & txt_BAKE_lot.Text & "',Recipe= '" & combo_bake_recipe.Text & "',Temperature= '" & txt_bake_temp.Text & "', Time= '" & txt_bake_time.Text & "',Remark='" & txt_bake_remark.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_BAKE_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_BAKE_Query_Click("", e)

            End If

        End If


    End Sub

    Private Sub btn_bake_exit_Click(sender As Object, e As EventArgs) Handles btn_bake_exit.Click
        Me.Close()

    End Sub






    ''''''''''''''''''''''''''''''''''''''''
    '''CPDT Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_cpdt_Query_Click(sender As Object, e As EventArgs) Handles btn_cpdt_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case combo_cpdt_query.Text

            Case "ENABLE"

                If combo_cpdt_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_CPDT where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
                Else
                    mysql = "select * from Recipe_CPDT where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND FlowName='" & combo_cpdt_flowquery.Text & "'"
                End If

            Case "ALL"
                If combo_cpdt_flowquery.Text = "ALL" Then
                    mysql = "select * from Recipe_cpdt where InternalProduct='" & myProduct.InternalProduct & "'"
                Else
                    mysql = "select * from Recipe_cpdt where InternalProduct='" & myProduct.InternalProduct & "'AND FlowName='" & combo_cpdt_flowquery.Text & "'"
                End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_CPDT")

        If mydataset.Tables("Recipe_CPDT").Rows.Count = 0 Then
            DGV_CPDT.DataSource = Nothing

        Else

            DGV_CPDT.DataSource = mydataset.Tables("Recipe_CPDT")
            DGV_CPDT.Columns(0).Width = COLUMNWIDTH * 1.5

        End If




    End Sub

    Private Sub btn_cpdt_new_Click(sender As Object, e As EventArgs) Handles btn_cpdt_new.Click
        StepDefine_Mode = "NEW"
        grp_cpdt_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_cpdt_modify_Click(sender As Object, e As EventArgs) Handles btn_cpdt_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_CPDT.Rows.Count = 0 Then Exit Sub

        grp_cpdt_para.Visible = True

        txt_cpdt_id.Text = DGV_CPDT.SelectedRows(0).Cells("ID").Value
        txt_cpdt_id.ReadOnly = True

        combo_cpdt_flow.Text = DGV_CPDT.SelectedRows(0).Cells("FlowName").Value
        combo_cpdt_type.Text = DGV_CPDT.SelectedRows(0).Cells("Type").Value
        txt_cpdt_lot.Text = DGV_CPDT.SelectedRows(0).Cells("Lot").Value


        txt_cpdt_hold.Text = DGV_CPDT.SelectedRows(0).Cells("Hold").Value
        txt_cpdt_operation.Text = DGV_CPDT.SelectedRows(0).Cells("Operation").Value


    End Sub

    Private Sub btn_cpdt_copy_Click(sender As Object, e As EventArgs) Handles btn_cpdt_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_CPDT.Rows.Count = 0 Then Exit Sub

        grp_cpdt_para.Visible = True

        txt_cpdt_id.Text = ""

        combo_cpdt_flow.Text = DGV_CPDT.SelectedRows(0).Cells("FlowName").Value
        combo_cpdt_type.Text = DGV_CPDT.SelectedRows(0).Cells("Type").Value
        txt_cpdt_lot.Text = DGV_CPDT.SelectedRows(0).Cells("Lot").Value


        txt_cpdt_hold.Text = DGV_CPDT.SelectedRows(0).Cells("Hold").Value
        txt_cpdt_operation.Text = DGV_CPDT.SelectedRows(0).Cells("Operation").Value


    End Sub

    Private Sub combo_cpdt_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cpdt_type.SelectedIndexChanged
        If combo_cpdt_type.Text = "SEN" Then
            txt_cpdt_lot.ReadOnly = False
            txt_cpdt_lot.Text = ""
        ElseIf combo_cpdt_type.Text = "ECN" Then
            txt_cpdt_lot.ReadOnly = True
            txt_cpdt_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_cpdt_disable_Click(sender As Object, e As EventArgs) Handles btn_cpdt_disable.Click
        Dim mysql As String, s As Integer


        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)


        If s = 1 Then

            If DGV_CPDT.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_CPDT SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_CPDT.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_cpdt_Query_Click("", e)

        End If

    End Sub

    Private Sub btn_cpdt_delete_Click(sender As Object, e As EventArgs) Handles btn_cpdt_delete.Click
        Dim mysql As String, s As Integer

        If DGV_CPDT.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_CPDT WHERE ID ='" & DGV_CPDT.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_cpdt_Query_Click("", e)

        End If
    End Sub

    Private Sub txt_cpdt_exit_Click(sender As Object, e As EventArgs) Handles txt_cpdt_exit.Click
        Me.Close()
    End Sub

    Private Sub txt_cpdt_confirm_Click(sender As Object, e As EventArgs) Handles txt_cpdt_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_cpdt_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_cpdt_type.Text = "ECN" Then
                mysql = "select * from Recipe_cpdt where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN' AND FlowName='" & combo_cpdt_flow.Text & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_CPDT")

                If mydataset.Tables("Recipe_CPDT").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_cpdt_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_cpdt_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_CPDT (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,Hold,Operation,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_cpdt_flow.Text & "','" & combo_cpdt_type.Text & "','TRUE','" & txt_cpdt_lot.Text & " ','" & txt_cpdt_hold.Text & " ','" &
            txt_cpdt_operation.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_cpdt_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_CPDT SET LOT= '" & txt_cpdt_lot.Text & "',Hold= '" & txt_cpdt_hold.Text & "',Operation= '" & txt_cpdt_operation.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_cpdt_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_cpdt_Query_Click("", e)

            End If

        End If

    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    '''WIPFS Page Operation
    ''''''''''''''''''''''''''''''''''''''''
    '''
    Private Sub btn_wipfs_Query_Click(sender As Object, e As EventArgs) Handles btn_wipfs_Query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_wipfs_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_WIPFS where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_WIPFS where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_WIPFS")

        If mydataset.Tables("Recipe_WIPFS").Rows.Count = 0 Then
            DGV_WIPFS.DataSource = Nothing

        Else

            DGV_WIPFS.DataSource = mydataset.Tables("Recipe_WIPFS")
            DGV_WIPFS.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_wipfs_new_Click(sender As Object, e As EventArgs) Handles btn_wipfs_new.Click
        StepDefine_Mode = "NEW"
        grp_wipfs_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_wipfs_modify_Click(sender As Object, e As EventArgs) Handles btn_wipfs_modify.Click

        StepDefine_Mode = "MODIFY"

        If DGV_WIPFS.Rows.Count = 0 Then Exit Sub

        grp_wipfs_para.Visible = True

        txt_wipfs_id.Text = DGV_WIPFS.SelectedRows(0).Cells("ID").Value
        txt_wipfs_id.ReadOnly = True
        txt_wipfs_lot.Text = DGV_WIPFS.SelectedRows(0).Cells("Lot").Value
        combo_wipfs_type.Text = DGV_WIPFS.SelectedRows(0).Cells("Type").Value

        combo_mappingflow.Text = DGV_WIPFS.SelectedRows(0).Cells("MappingFlow").Value
        txt_wipfs_operation.Text = DGV_WIPFS.SelectedRows(0).Cells("Operation").Value


    End Sub

    Private Sub btn_wipfs_copy_Click(sender As Object, e As EventArgs) Handles btn_wipfs_copy.Click

        StepDefine_Mode = "COPY"

        If DGV_WIPFS.Rows.Count = 0 Then Exit Sub

        grp_wipfs_para.Visible = True
        txt_wipfs_id.Text = ""

        txt_wipfs_lot.Text = DGV_WIPFS.SelectedRows(0).Cells("Lot").Value
        combo_wipfs_type.Text = DGV_WIPFS.SelectedRows(0).Cells("Type").Value

        combo_mappingflow.Text = DGV_WIPFS.SelectedRows(0).Cells("MappingFlow").Value
        txt_wipfs_operation.Text = DGV_WIPFS.SelectedRows(0).Cells("Operation").Value

    End Sub

    Private Sub btn_wipfs_disable_Click(sender As Object, e As EventArgs) Handles btn_wipfs_disable.Click
        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_WIPFS.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_WIPFS SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_WIPFS.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_wipfs_Query_Click("", e)

        End If
    End Sub

    Private Sub btn_wipfs_delete_Click(sender As Object, e As EventArgs) Handles btn_wipfs_delete.Click
        Dim mysql As String, s As Integer

        If DGV_WIPFS.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_WIPFS WHERE ID ='" & DGV_WIPFS.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_wipfs_Query_Click("", e)

        End If
    End Sub

    Private Sub combo_wipfs_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_wipfs_type.SelectedIndexChanged
        If combo_wipfs_type.Text = "SEN" Then
            txt_wipfs_lot.ReadOnly = False
            txt_wipfs_lot.Text = ""
        ElseIf combo_wipfs_type.Text = "ECN" Then
            txt_wipfs_lot.ReadOnly = True
            txt_wipfs_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_wipfs_exit_Click(sender As Object, e As EventArgs) Handles btn_wipfs_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_wipfs_confirm_Click(sender As Object, e As EventArgs) Handles btn_wipfs_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_wipfs_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_wipfs_type.Text = "ECN" Then
                mysql = "select * from Recipe_WIPFS where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_WIPFS")

                If mydataset.Tables("Recipe_WIPFS").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_wipfs_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_wipfs_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_WIPFS (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,MappingFlow,Operation,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "WIPFS" & "','" & combo_wipfs_type.Text & "','TRUE','" & txt_wipfs_lot.Text & " ','" & combo_mappingflow.Text & " ','" &
            txt_wipfs_operation.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_wipfs_Query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_WIPFS SET LOT= '" & txt_wipfs_lot.Text & "',MappingFlow= '" & combo_mappingflow.Text & "',Operation= '" & txt_wipfs_operation.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_wipfs_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_wipfs_Query_Click("", e)

            End If

        End If

    End Sub








    ''''''''''''''''''''''''''''''''''''''''
    '''PACK Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_pack_query_Click(sender As Object, e As EventArgs) Handles btn_pack_query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_pack_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_PACK")

        If mydataset.Tables("Recipe_PACK").Rows.Count = 0 Then
            DGV_PACK.DataSource = Nothing

        Else

            DGV_PACK.DataSource = mydataset.Tables("Recipe_PACK")
            DGV_PACK.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_pack_new_Click(sender As Object, e As EventArgs) Handles btn_pack_new.Click
        StepDefine_Mode = "NEW"
        grp_pack_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_pack_modify_Click(sender As Object, e As EventArgs) Handles btn_pack_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        grp_pack_para.Visible = True

        txt_pack_id.Text = DGV_PACK.SelectedRows(0).Cells("ID").Value
        txt_pack_id.ReadOnly = True
        txt_pack_lot.Text = DGV_PACK.SelectedRows(0).Cells("Lot").Value
        combo_pack_type.Text = DGV_PACK.SelectedRows(0).Cells("Type").Value
        txt_pack_operation.Text = DGV_PACK.SelectedRows(0).Cells("Operation").Value
        txt_pack_recipe.Text = DGV_PACK.SelectedRows(0).Cells("Recipe").Value

    End Sub

    Private Sub btn_pack_copy_Click(sender As Object, e As EventArgs) Handles btn_pack_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        grp_pack_para.Visible = True
        txt_pack_id.Text = ""

        txt_pack_lot.Text = DGV_PACK.SelectedRows(0).Cells("Lot").Value
        combo_pack_type.Text = DGV_PACK.SelectedRows(0).Cells("Type").Value
        txt_pack_operation.Text = DGV_PACK.SelectedRows(0).Cells("Operation").Value
        txt_pack_recipe.Text = DGV_PACK.SelectedRows(0).Cells("Recipe").Value

    End Sub

    Private Sub btn_pack_disable_Click(sender As Object, e As EventArgs) Handles btn_pack_disable.Click
        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_PACK.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_PACK SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_PACK.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_pack_query_Click("", e)

        End If





    End Sub

    Private Sub btn_pack_delete_Click(sender As Object, e As EventArgs) Handles btn_pack_delete.Click
        Dim mysql As String, s As Integer

        If DGV_PACK.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_PACK WHERE ID ='" & DGV_PACK.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_pack_query_Click("", e)

        End If





    End Sub

    Private Sub combo_pack_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_pack_type.SelectedIndexChanged
        If combo_pack_type.Text = "SEN" Then
            txt_pack_lot.ReadOnly = False
            txt_pack_lot.Text = ""
        ElseIf combo_pack_type.Text = "ECN" Then
            txt_pack_lot.ReadOnly = True
            txt_pack_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_pack_exit_Click(sender As Object, e As EventArgs) Handles btn_pack_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_pack_confirm_Click(sender As Object, e As EventArgs) Handles btn_pack_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_pack_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_pack_type.Text = "ECN" Then
                mysql = "select * from Recipe_PACK where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_PACK")

                If mydataset.Tables("Recipe_PACK").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_pack_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_pack_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_PACK (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,Recipe,Operation,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "PACK" & "','" & combo_pack_type.Text & "','TRUE','" & txt_pack_lot.Text & " ','" & txt_pack_recipe.Text & " ','" &
            txt_pack_operation.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_pack_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then

                mysql = "UPDATE Recipe_PACK SET LOT= '" & txt_pack_lot.Text & "',Recipe= '" & txt_pack_recipe.Text & "',Operation= '" & txt_pack_operation.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_pack_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_pack_query_Click("", e)

            End If

        End If

    End Sub







    ''''''''''''''''''''''''''''''''''''''''
    '''SHIP Page Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_ship_query_Click(sender As Object, e As EventArgs) Handles btn_ship_query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_ship_query.Text = "ENABLE" Then
            mysql = "select * from Recipe_SHIP where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE'"
        Else
            mysql = "select * from Recipe_SHIP where InternalProduct='" & myProduct.InternalProduct & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Recipe_SHIP")

        If mydataset.Tables("Recipe_SHIP").Rows.Count = 0 Then
            DGV_SHIP.DataSource = Nothing

        Else

            DGV_SHIP.DataSource = mydataset.Tables("Recipe_SHIP")
            DGV_SHIP.Columns(0).Width = COLUMNWIDTH * 1.5

        End If
    End Sub

    Private Sub btn_ship_new_Click(sender As Object, e As EventArgs) Handles btn_ship_new.Click
        StepDefine_Mode = "NEW"
        grp_ship_para.Visible = True
        ClearPara()
    End Sub

    Private Sub btn_ship_modify_Click(sender As Object, e As EventArgs) Handles btn_ship_modify.Click
        StepDefine_Mode = "MODIFY"

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        grp_ship_para.Visible = True

        txt_ship_id.Text = DGV_SHIP.SelectedRows(0).Cells("ID").Value
        txt_ship_id.ReadOnly = True
        txt_ship_lot.Text = DGV_SHIP.SelectedRows(0).Cells("Lot").Value
        combo_ship_type.Text = DGV_SHIP.SelectedRows(0).Cells("Type").Value
        txt_ship_operation.Text = DGV_SHIP.SelectedRows(0).Cells("Operation").Value


    End Sub

    Private Sub btn_ship_copy_Click(sender As Object, e As EventArgs) Handles btn_ship_copy.Click
        StepDefine_Mode = "COPY"

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        grp_ship_para.Visible = True
        txt_ship_id.Text = ""

        txt_ship_lot.Text = DGV_SHIP.SelectedRows(0).Cells("Lot").Value
        combo_ship_type.Text = DGV_SHIP.SelectedRows(0).Cells("Type").Value
        txt_ship_operation.Text = DGV_SHIP.SelectedRows(0).Cells("Operation").Value
    End Sub

    Private Sub btn_ship_disable_Click(sender As Object, e As EventArgs) Handles btn_ship_disable.Click

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该作业站参数吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            If DGV_SHIP.Rows.Count = 0 Then Exit Sub
            mysql = "UPDATE Recipe_SHIP SET ENABLE= '" & False & " ' WHERE ID= '" & DGV_SHIP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call btn_ship_query_Click("", e)

        End If

    End Sub

    Private Sub btn_ship_delete_Click(sender As Object, e As EventArgs) Handles btn_ship_delete.Click

        Dim mysql As String, s As Integer

        If DGV_SHIP.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "DELETE FROM Recipe_SHIP WHERE ID ='" & DGV_SHIP.SelectedRows(0).Cells("ID").Value & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_ship_query_Click("", e)

        End If

    End Sub

    Private Sub combo_ship_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ship_type.SelectedIndexChanged
        If combo_ship_type.Text = "SEN" Then
            txt_ship_lot.ReadOnly = False
            txt_ship_lot.Text = ""
        ElseIf combo_ship_type.Text = "ECN" Then
            txt_ship_lot.ReadOnly = True
            txt_ship_lot.Text = "*"
        End If
    End Sub

    Private Sub btn_ship_exit_Click(sender As Object, e As EventArgs) Handles btn_ship_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_ship_confirm_Click(sender As Object, e As EventArgs) Handles btn_ship_confirm.Click
        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim s As Integer

        '填入值正确性校验
        If combo_ship_type.Text = "" Then
            MsgBox("Recipe 类型未设定!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        If StepDefine_Mode = "NEW" Or StepDefine_Mode = "COPY" Then


            '先检查是否存在可用的ECN，ECN每个站别只能有一个处于可用状态
            If combo_ship_type.Text = "ECN" Then
                mysql = "select * from Recipe_SHIP where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Recipe_SHIP")

                If mydataset.Tables("Recipe_SHIP").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN，请作废后再点CONFIRM提交！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            End If

            '往数据库插入

            If combo_ship_type.Text = "ECN" Then
                ID = "RE"
            ElseIf combo_ship_type.Text = "SEN" Then
                ID = "RS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Recipe_SHIP (ID,customer,InternalProduct,FlowName,Type,ENABLE,Lot,Operation,CreateTime,Creater) VALUES ( '" &
            ID & "','" & myProduct.Customer & "','" & myProduct.InternalProduct & "','" & "SHIP" & "','" & combo_ship_type.Text & "','TRUE','" & txt_ship_lot.Text & " ','" &
            txt_ship_operation.Text & "','" & Now & "','" & UserID & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)
            ClearPara()
            Call btn_ship_query_Click("", e)

        ElseIf StepDefine_Mode = "MODIFY" Then

            s = MessageBox.Show("确定要修改吗?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            If s = 1 Then
                mysql = "UPDATE Recipe_SHIP SET LOT= '" & txt_ship_lot.Text & "',Operation= '" & txt_ship_operation.Text &
                 "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_ship_id.Text & "'"

                Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
                myconn.Open()

                Try
                    mycmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                myconn.Close()

                ClearPara()
                Call btn_ship_query_Click("", e)

            End If

        End If

    End Sub


    ''''''''''''''''''''''''''''''''''''''''
    ''mappic Operation
    ''''''''''''''''''''''''''''''''''''''''

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\RecipeSet\"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            sourcefile = OpenFileDialog1.FileName

            If InStr(sourcefile, " ") > 0 Then
                MsgBox("文件名包含空格!,请修改后上传", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            destfile += Format(Now(), "yyyyMMddHHmmss") + "_" + System.IO.Path.GetFileName(sourcefile)



            '文件复制
            FileCopy(sourcefile, destfile)

            'txt_attachpic.Text = destfile
            txt_attachpic.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")
            MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        Dim sourcefile As String, destfile As String

        'sourcefile = txt_attachpic.Text
        sourcefile = Replace(txt_attachpic.Text, "CPMES-SERVER", "10.10.31.99")
        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If
    End Sub



    Private Sub combo_cp_flowquery_DropDown(sender As Object, e As EventArgs) Handles combo_cp_flowquery.DropDown

        combo_cp_flowquery.Items.Clear()
        combo_cp_flowquery.Items.Add("ALL")
        For i = 1 To 9
            combo_cp_flowquery.Items.Add("CP" & i)
        Next

    End Sub



    Private Sub combo_cp_flow_DropDown(sender As Object, e As EventArgs) Handles combo_cp_flow.DropDown

        combo_cp_flow.Items.Clear()

        For i = 1 To 9
            combo_cp_flow.Items.Add("CP" & i)
        Next

    End Sub



    Private Sub combo_cpdt_flowquery_DropDown(sender As Object, e As EventArgs) Handles combo_cpdt_flowquery.DropDown

        combo_cpdt_flowquery.Items.Clear()
        combo_cpdt_flowquery.Items.Add("ALL")
        For i = 1 To 9
            combo_cpdt_flowquery.Items.Add("CP" & i & "DT")
        Next


    End Sub




    Private Sub combo_cpdt_flow_DropDown(sender As Object, e As EventArgs) Handles combo_cpdt_flow.DropDown

        combo_cpdt_flow.Items.Clear()

        For i = 1 To 9
            combo_cpdt_flow.Items.Add("CP" & i & "DT")
        Next

    End Sub

    Private Sub combo_cp_tester_DropDown(sender As Object, e As EventArgs) Handles combo_cp_tester.DropDown

        Dim grparray() As String
        grparray = GetTesterGrp()

        combo_cp_tester.Items.Clear()
        For i = 0 To UBound(grparray) - 1
            combo_cp_tester.Items.Add(grparray(i))
        Next

    End Sub


End Class

