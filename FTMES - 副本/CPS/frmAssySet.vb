Imports System.Data.SqlClient

Public Class frmAssySet


    Private Sub frmAssySet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10


        '配件大类型设定
        combo_type.Items.Add("Load Board")
        combo_type.Items.Add("KIT")
        combo_type.Items.Add("SOCKET")

        '配件实用群组设定
        combo_grp.Items.Add("J750(EX)")
        combo_grp.Items.Add("3380P")
        'combo_grp.Items.Add("DimondX")

        '财产归属设定
        combo_owner.Items.Add("iTest")
        combo_owner.Items.Add("Customer")

        '当前厂内/厂外设定
        combo_ioside.Items.Add("安测")
        combo_ioside.Items.Add("客供")

        '针卡类型设定

        'combo_pc_type.Items.Add("Cantilever")
        'combo_pc_type.Items.Add("Vertical")
        'combo_pc_type.Items.Add("MEMS")

        ''针卡状态设定

        'combo_pc_status.Items.Add("待Release")
        'combo_pc_status.Items.Add("待维修")
        'combo_pc_status.Items.Add("待报废")
        'combo_pc_status.Items.Add("已报废")
        'combo_pc_status.Items.Add("在库可用")


        If Accessary_Operation_Mode = "MODIFY" Then

            combo_type.Text = myassy.type
            combo_grp.Text = myassy.grp
            combo_cust.Text = myassy.cust
            combo_prod.Text = myassy.prod
            combo_partno.Text = myassy.partno
            txt_ID.Text = myassy.id
            txt_package.Text = myassy.package
            txt_state.Text = myassy.state
            'txt_live.Text = myassy.live
            combo_owner.Text = myassy.owner
            combo_ioside.Text = myassy.ioside
            txt_location.Text = myassy.location
            txt_Manufacturer.Text = myassy.manufact
            txt_supplier.Text = myassy.supplier
            DateTimePicker1.Value = myassy.inputdate
            rtb_remark.Text = myassy.remark
            txt_attach.Text = myassy.attach

            If myassy.type = "SOCKET" Then

                txt_live.Text = myassy.live

            ElseIf myassy.type = "KIT" Then

                txt_fit.Text = myassy.fit
                txt_site.Text = myassy.site
                txt_thick.Text = myassy.thick

            End If


        End If


        Me.BackColor = mydefaultcolor

        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub



    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select ename from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Customer")

        If mydataset.Tables("Customer").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Fail !")
        Else
            combo_cust.Items.Clear()
            combo_cust.Items.Add("*")
            'List All customer
            For i = 0 To mydataset.Tables("Customer").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Customer").Rows(i).Item("ename"))
            Next

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



    Private Sub combo_partno_DropDown(sender As Object, e As EventArgs) Handles combo_partno.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet


        mysql = "select DISTINCT Partnumber from Accessory where Type='" & combo_type.Text & "'"


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "accessory")

        If mydataset.Tables("accessory").Rows.Count = 0 Then
            combo_partno.Items.Clear()
            combo_partno.Items.Add("*")
        Else
            combo_partno.Items.Clear()
            combo_partno.Items.Add("*")

            For i = 0 To mydataset.Tables("accessory").Rows.Count - 1
                combo_partno.Items.Add(mydataset.Tables("accessory").Rows(i).Item("Partnumber"))
            Next

        End If

    End Sub


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String

        If Accessary_Operation_Mode = "NEW" Then

            If combo_type.Text = "SOCKET" Then

                mysql = "INSERT INTO Accessory (Type,Grp,Partnumber,ID,Customer,Product,Ownership,IOside,Location,Enable,manufacturer,supplier,InputDate,Package,State,LifeSpan,remark,Attachment,CreateTime,Creater) VALUES ( '" &
                    combo_type.Text & "','" & combo_grp.Text & "','" & combo_partno.Text & "','" & txt_ID.Text & "','" & combo_cust.Text & "','" & combo_prod.Text & "','" & combo_owner.Text & "','" & combo_ioside.Text & "','" & txt_location.Text & "','True','" & txt_Manufacturer.Text & "','" & txt_supplier.Text & "','" & DateTimePicker1.Value & "','" & txt_package.Text & "','" & txt_state.Text & "','" & txt_live.Text & "','" &
                     rtb_remark.Text & "','" & txt_attach.Text & "','" & Now & "','" & UserID & "')"

            ElseIf combo_type.Text = "KIT" Then

                mysql = "INSERT INTO Accessory (Type,Grp,Partnumber,ID,Customer,Product,Ownership,IOside,Location,Enable,manufacturer,supplier,InputDate,Package,State,SiteMap,Fitmachine,Thick,remark,Attachment,CreateTime,Creater) VALUES ( '" &
                    combo_type.Text & "','" & combo_grp.Text & "','" & combo_partno.Text & "','" & txt_ID.Text & "','" & combo_cust.Text & "','" & combo_prod.Text & "','" & combo_owner.Text & "','" & combo_ioside.Text & "','" & txt_location.Text & "','True','" & txt_Manufacturer.Text & "','" & txt_supplier.Text & "','" & DateTimePicker1.Value & "','" & txt_package.Text & "','" & txt_state.Text & "','" & txt_site.Text & "','" & txt_fit.Text & "','" & txt_thick.Text & "','" &
                     rtb_remark.Text & "','" & txt_attach.Text & "','" & Now & "','" & UserID & "')"
            Else

                mysql = "INSERT INTO Accessory (Type,Grp,Partnumber,ID,Customer,Product,Ownership,IOside,Location,Enable,manufacturer,supplier,InputDate,Package,State,remark,Attachment,CreateTime,Creater) VALUES ( '" &
                   combo_type.Text & "','" & combo_grp.Text & "','" & combo_partno.Text & "','" & txt_ID.Text & "','" & combo_cust.Text & "','" & combo_prod.Text & "','" & combo_owner.Text & "','" & combo_ioside.Text & "','" & txt_location.Text & "','True','" & txt_Manufacturer.Text & "','" & txt_supplier.Text & "','" & DateTimePicker1.Value & "','" & txt_package.Text & "','" & txt_state.Text & "','" &
                    rtb_remark.Text & "','" & txt_attach.Text & "','" & Now & "','" & UserID & "')"
                'mysql = "insert into Accessory (Live) values ('" & txt_live.Text & "')"

            End If
            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Me.Close()
            MsgBox("New Define OK !", vbOKOnly + vbInformation)

        ElseIf Accessary_Operation_Mode = "MODIFY" Then
            If combo_type.Text = "SOCKET" Then

                mysql = "UPDATE  Accessory SET Type= '" & combo_type.Text & "', Grp='" & combo_grp.Text & "', Partnumber='" & combo_partno.Text & "', Customer='" & combo_cust.Text & "', Product='" & combo_prod.Text & "', Ownership='" & combo_owner.Text & "', IOside='" & combo_ioside.Text & "', Location='" & txt_location.Text & "', manufacturer='" & txt_Manufacturer.Text &
        "', supplier='" & txt_supplier.Text & "', InputDate='" & DateTimePicker1.Value & "',Package='" & txt_package.Text & "',State='" & txt_state.Text & "',LifeSpan ='" & txt_live.Text & "', remark='" & rtb_remark.Text & "', Attachment='" & txt_attach.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
        "' WHERE ID='" & myassy.id & "'"

            ElseIf combo_type.Text = "KIT" Then

                mysql = "UPDATE  Accessory SET Type= '" & combo_type.Text & "', Grp='" & combo_grp.Text & "', Partnumber='" & combo_partno.Text & "', Customer='" & combo_cust.Text & "', Product='" & combo_prod.Text & "', Ownership='" & combo_owner.Text & "', IOside='" & combo_ioside.Text & "', Location='" & txt_location.Text & "', manufacturer='" & txt_Manufacturer.Text &
       "', supplier='" & txt_supplier.Text & "', InputDate='" & DateTimePicker1.Value & "',Package='" & txt_package.Text & "',State='" & txt_state.Text & "',SiteMap ='" & txt_site.Text & "',Fitmachine='" & txt_fit.Text & "',Thick='" & txt_thick.Text & "', remark='" & rtb_remark.Text & "', Attachment='" & txt_attach.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
       "' WHERE ID='" & myassy.id & "'"

            Else
                mysql = "UPDATE  Accessory SET Type= '" & combo_type.Text & "', Grp='" & combo_grp.Text & "', Partnumber='" & combo_partno.Text & "', Customer='" & combo_cust.Text & "', Product='" & combo_prod.Text & "', Ownership='" & combo_owner.Text & "', IOside='" & combo_ioside.Text & "', Location='" & txt_location.Text & "', manufacturer='" & txt_Manufacturer.Text &
    "', supplier='" & txt_supplier.Text & "', InputDate='" & DateTimePicker1.Value & "',Package='" & txt_package.Text & "',State='" & txt_state.Text & "',remark='" & rtb_remark.Text & "', Attachment='" & txt_attach.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
    "' WHERE ID='" & txt_ID.Text & "'"

            End If

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            Me.Close()
            MsgBox("Modify OK !", vbOKOnly + vbInformation)


        End If

        Call frmAccessory.btn_Query_Click("", e)


    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\AccessorySet\"
        'destfile = "\\1"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            sourcefile = OpenFileDialog1.FileName

            If InStr(sourcefile, " ") > 0 Then
                MsgBox("文件名包含空格!,请修改后上传", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            destfile += Format(Now(), "yyyyMMddHHmmss") + "_" + System.IO.Path.GetFileName(sourcefile)


            '文件复制
            FileCopy(sourcefile, destfile)

            ' txt_attach.Text = destfile
            txt_attach.Text = Replace(destfile, "10.10.31.99", "CPMES-SERVER")

            MsgBox("上传成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If
    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click
        Dim sourcefile As String, destfile As String

        'sourcefile = txt_attach.Text
        sourcefile = Replace(txt_attach.Text, "CPMES-SERVER", "10.10.31.99")

        SaveFileDialog1.FileName = System.IO.Path.GetFileName(sourcefile)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            destfile = SaveFileDialog1.FileName

            FileCopy(sourcefile, destfile)
            MsgBox("下载成功!", vbOKOnly + vbInformation)

        Else
            Exit Sub
        End If

    End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub txt_IQC_pincount_TextChanged(sender As Object, e As EventArgs) Handles txt_live.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub rtb_remark_TextChanged(sender As Object, e As EventArgs) Handles rtb_remark.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txt_supplier_TextChanged(sender As Object, e As EventArgs) Handles txt_supplier.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txt_Manufacturer_TextChanged(sender As Object, e As EventArgs) Handles txt_Manufacturer.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txt_ID_TextChanged(sender As Object, e As EventArgs) Handles txt_ID.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub combo_grp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_grp.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub combo_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_type.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub combo_cust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cust.SelectedIndexChanged

    End Sub

    Private Sub combo_prod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_prod.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub txt_location_TextChanged(sender As Object, e As EventArgs) Handles txt_location.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub combo_partno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_partno.SelectedIndexChanged

    End Sub

    Private Sub combo_owner_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_owner.SelectedIndexChanged

    End Sub

    Private Sub combo_ioside_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ioside.SelectedIndexChanged

    End Sub

    Private Sub txt_attach_TextChanged(sender As Object, e As EventArgs) Handles txt_attach.TextChanged

    End Sub

    Private Sub Label25_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub txt_state_TextChanged(sender As Object, e As EventArgs) Handles txt_state.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub Package_Click(sender As Object, e As EventArgs) Handles Package.Click

    End Sub

    Private Sub txt_package_TextChanged(sender As Object, e As EventArgs) Handles txt_package.TextChanged

    End Sub
End Class