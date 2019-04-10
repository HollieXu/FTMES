Imports System.Data.SqlClient

Public Class frmFlowset


    Dim cbarray() As ComboBox


    Private Sub FlowOPSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10

        combo_cust.Text = myProduct.Customer
        combo_prod.Text = myProduct.InternalProduct

        Me.cbarray = New ComboBox() {cb01, cb02, cb03, cb04, cb05, cb06, cb07, cb08, cb09, cb10, cb11, cb12, cb13, cb14, cb15, cb16, cb17, cb18, cb19, cb20}


        If Flow_Operation_Mode = "NEW" Then

            Me.BackColor = mydefaultcolor

        ElseIf Flow_Operation_Mode = "MODIFY" Then

            Me.BackColor = mydefaultcolor
            combo_cust.Text = myProduct.Customer
            combo_prod.Text = myProduct.InternalProduct
            txt_flowid.Text = myFlow.ID
            combo_type.Text = myFlow.Type

            txt_ilot.Text = myFlow.ilot
            txt_clot.Text = myFlow.clot


            cb01.Text = myFlow.step01
            cb02.Text = myFlow.step02
            cb03.Text = myFlow.step03
            cb04.Text = myFlow.step04
            cb05.Text = myFlow.step05
            cb06.Text = myFlow.step06
            cb07.Text = myFlow.step07
            cb08.Text = myFlow.step08
            cb09.Text = myFlow.step09
            cb10.Text = myFlow.step10
            cb11.Text = myFlow.step11
            cb12.Text = myFlow.step12
            cb13.Text = myFlow.step13
            cb14.Text = myFlow.step14
            cb15.Text = myFlow.step15
            cb16.Text = myFlow.step16
            cb17.Text = myFlow.step17
            cb18.Text = myFlow.step18
            cb19.Text = myFlow.step19
            cb20.Text = myFlow.step20

        End If


    End Sub

    Private Sub cb01_Dropdown(sender As Object, e As EventArgs) Handles cb01.DropDown, cb02.DropDown, cb03.DropDown, cb04.DropDown, cb05.DropDown, cb06.DropDown, cb07.DropDown, cb08.DropDown,
    cb09.DropDown, cb10.DropDown, cb11.DropDown, cb12.DropDown, cb13.DropDown, cb14.DropDown, cb15.DropDown, cb16.DropDown, cb17.DropDown, cb18.DropDown, cb19.DropDown, cb20.DropDown


        cbarray(sender.tabindex - 1).Items.Clear()
        cbarray(sender.tabindex - 1).Items.Add("IQC")

        cbarray(sender.tabindex - 1).Items.Add("CP1")
        cbarray(sender.tabindex - 1).Items.Add("CP2")
        cbarray(sender.tabindex - 1).Items.Add("CP3")
        cbarray(sender.tabindex - 1).Items.Add("CP4")
        cbarray(sender.tabindex - 1).Items.Add("CP5")
        cbarray(sender.tabindex - 1).Items.Add("CP6")
        cbarray(sender.tabindex - 1).Items.Add("CP7")
        cbarray(sender.tabindex - 1).Items.Add("CP8")
        cbarray(sender.tabindex - 1).Items.Add("CP9")

        cbarray(sender.tabindex - 1).Items.Add("BAKE1")
        cbarray(sender.tabindex - 1).Items.Add("BAKE2")
        cbarray(sender.tabindex - 1).Items.Add("BAKE3")
        cbarray(sender.tabindex - 1).Items.Add("BAKE4")

        cbarray(sender.tabindex - 1).Items.Add("CP1DT")
        cbarray(sender.tabindex - 1).Items.Add("CP2DT")
        cbarray(sender.tabindex - 1).Items.Add("CP3DT")
        cbarray(sender.tabindex - 1).Items.Add("CP4DT")
        cbarray(sender.tabindex - 1).Items.Add("CP5DT")
        cbarray(sender.tabindex - 1).Items.Add("CP6DT")
        cbarray(sender.tabindex - 1).Items.Add("CP7DT")
        cbarray(sender.tabindex - 1).Items.Add("CP8DT")
        cbarray(sender.tabindex - 1).Items.Add("CP9DT")

        cbarray(sender.tabindex - 1).Items.Add("WIPFS")
        cbarray(sender.tabindex - 1).Items.Add("FQC")
        cbarray(sender.tabindex - 1).Items.Add("PACK")
        cbarray(sender.tabindex - 1).Items.Add("SHIP")


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub





    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim ID As String
        Dim mysql As String
        Dim mydataset As New DataSet

        If Flow_Operation_Mode = "NEW" Or Flow_Operation_Mode = "COPY" Then


            '插入新的ECN前，先检查是否存在可用的ECN，ECN每个流程只能有一个处于可用状态
            If combo_type.Text = "ECN" Then

                mysql = "select * from Flow where InternalProduct='" & myProduct.InternalProduct & "'AND ENABLE='TRUE' AND Type='ECN'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)

                myadapter.Fill(mydataset, "Flow")

                If mydataset.Tables("Flow").Rows.Count > 0 Then
                    MsgBox("存在生效中的ECN流程，请作废后再重新设定！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

            End If


            '往数据库插入

            If combo_type.Text = "ECN" Then
                ID = "FE"
            ElseIf combo_type.Text = "SEN" Then
                ID = "FS"
            End If

            ID = ID & Format(Now(), "yyyyMMddHHmmss")

            mysql = "INSERT INTO Flow (Customer,InternalProduct,Type,ID,ilot,clot,Enable,CreateTime,Creater,step01,step02,step03,step04,step05,step06,step07,step08,step09,step10,step11,step12,step13,step14,step15,step16,step17,step18,step19,step20) VALUES ( '" &
                myProduct.Customer & "','" & myProduct.InternalProduct & "','" & combo_type.Text & "','" & ID & "','" & txt_ilot.Text & "','" & txt_clot.Text & "','TRUE','" & Now & "','" & UserID & "','" & cb01.Text & "','" &
                cb02.Text & "','" & cb03.Text & "','" & cb04.Text & "','" & cb05.Text & "','" & cb06.Text & "','" & cb07.Text & "','" & cb08.Text & "','" & cb09.Text & "','" & cb10.Text & "','" & cb11.Text & "','" & cb12.Text & "','" & cb13.Text & "','" & cb14.Text & "','" & cb15.Text & "','" & cb16.Text & "','" & cb17.Text & "','" & cb18.Text & "','" & cb19.Text & "','" & cb20.Text & "')"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("存储成功！", vbOKOnly + vbInformation)

            Call frmProduct.DataGridView_Product_Click("", e)


        ElseIf Flow_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE Flow SET ilot= '" & txt_ilot.Text & "', clot='" & txt_clot.Text & "',step01= '" & cb01.Text & "',step02= '" & cb02.Text & "',step03= '" & cb03.Text & "',step04= '" & cb04.Text & "',step05= '" & cb05.Text & "',step06= '" & cb06.Text & "',step07= '" & cb07.Text &
                "',step08= '" & cb08.Text & "',step09= '" & cb09.Text & "',step10= '" & cb10.Text & "',step11= '" & cb11.Text & "',step12= '" & cb12.Text & "',step13= '" & cb13.Text & "',step14= '" & cb14.Text & "',step15= '" & cb15.Text & "',step16= '" & cb16.Text &
               "',step17= '" & cb17.Text & "',step18= '" & cb18.Text & "',step19= '" & cb19.Text & "',step20= '" & cb20.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID & "' WHERE ID= '" & txt_flowid.Text & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            MsgBox("修改成功!", vbOKOnly + vbInformation)

            Call frmProduct.DataGridView_Product_Click("", e)

        End If


        Me.Close()


    End Sub



End Class