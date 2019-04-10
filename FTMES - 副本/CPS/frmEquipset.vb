Public Class frmEquipset


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub



    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim mysql As String

        If Equipment_Operation_Mode = "NEW" Then
            If combo_type.Text = "Handler" Then
                mysql = "INSERT INTO Equipment (Type,Grp,ID,SN,Enable,manufacturer,supplier,InputDate,SystemNo,Model,State,Version,License,PMDate,NextPMDate,config,Attachment,Floor,Position,CreateTime,Creater) VALUES ( '" &
                combo_type.Text & "','" & combo_grp.Text & "','" & txt_ID.Text & "','" & txt_SN.Text & "','True','" & txt_Manufacturer.Text & "','" & txt_supplier.Text & "','" & DateTimePicker1.Value & "','" & txt_sysno.Text & "',
                '" & txt_model.Text & "','" & txt_state.Text & "','" & txt_version.Text & "','" & txt_liense.Text & "','" & DateTimePicker2.Value & "','" & DateTimePicker3.Value & "','" & rtb_config.Text & "','" & txt_attach.Text & "','" & combo_floor.Text & "','" & NUD_position.Value & "','" & Now & "','" & UserID & "')"
            Else
                mysql = "INSERT INTO Equipment (Type,Grp,ID,SN,Enable,manufacturer,supplier,InputDate,config,Attachment,Floor,Position,CreateTime,Creater) VALUES ( '" &
                combo_type.Text & "','" & combo_grp.Text & "','" & txt_ID.Text & "','" & txt_SN.Text & "','True','" & txt_Manufacturer.Text & "','" & txt_supplier.Text & "','" & DateTimePicker1.Value & "','" & rtb_config.Text & "','" & txt_attach.Text & "','" & combo_floor.Text & "','" & NUD_position.Value & "','" & Now & "','" & UserID & "')"
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


        ElseIf Equipment_Operation_Mode = "MODIFY" Then

            If combo_type.Text = "Handler" Then
                mysql = "UPDATE  Equipment SET Type= '" & combo_type.Text & "', Grp='" & combo_grp.Text & "', ID='" & txt_ID.Text & "', SN='" & txt_SN.Text & "', manufacturer='" & txt_Manufacturer.Text &
                "', supplier='" & txt_supplier.Text & "', InputDate='" & DateTimePicker1.Value & "',SystemNo='" & txt_sysno.Text & "',Model='" & txt_model.Text & "',State='" & txt_state.Text & "',Version='" & txt_version.Text & "'
                ,License='" & txt_liense.Text & "',PMDate='" & DateTimePicker2.Value & "',NextPMDate='" & DateTimePicker3.Value & "',config='" & rtb_config.Text & "', Attachment='" & txt_attach.Text & "', Floor='" & combo_floor.Text & "', Position='" & NUD_position.Value & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE ID='" & myequip.ID & "'"
            Else
                mysql = "UPDATE  Equipment SET Type= '" & combo_type.Text & "', Grp='" & combo_grp.Text & "', ID='" & txt_ID.Text & "', SN='" & txt_SN.Text & "', manufacturer='" & txt_Manufacturer.Text &
                "', supplier='" & txt_supplier.Text & "', InputDate='" & DateTimePicker1.Value & "', config='" & rtb_config.Text & "', Attachment='" & txt_attach.Text & "', Floor='" & combo_floor.Text & "', Position='" & NUD_position.Value & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE ID='" & myequip.ID & "'"
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

        Call frmEquipment.btn_Query_Click("", e)

    End Sub

    Private Sub frmEquipset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10


        '添加设备类型
        combo_type.Items.Add("Handler")
        combo_type.Items.Add("Scan")
        combo_type.Items.Add("Strapper")
        combo_type.Items.Add("Counter")
        combo_type.Items.Add("Peel force tester")
        combo_type.Items.Add("Oven")
        combo_type.Items.Add("Pack")

        '添加设备群组
        combo_grp.Items.Add("EPSON")
        combo_grp.Items.Add("VITROX")
        combo_grp.Items.Add("strapper")
        combo_grp.Items.Add("EQUALTEK")
        combo_grp.Items.Add("ZAP Technology")
        combo_grp.Items.Add("oven")
        combo_grp.Items.Add("pack")
        'combo_grp.Items.Add("OVEN")
        'combo_grp.Items.Add("PACK")

        combo_floor.Items.Add("F1")
        combo_floor.Items.Add("F2")
        combo_floor.Items.Add("F3")


        If Equipment_Operation_Mode = "MODIFY" Then
            combo_type.Text = myequip.type
            combo_grp.Text = myequip.grp
            txt_ID.Text = myequip.ID
            txt_ID.ReadOnly = True
            txt_SN.Text = myequip.SN
            txt_Manufacturer.Text = myequip.manufacturer
            txt_supplier.Text = myequip.supplier
            rtb_config.Text = myequip.config
            txt_attach.Text = myequip.attach
            combo_floor.Text = myequip.floor
            NUD_position.Value = myequip.position
            DateTimePicker1.Value = myequip.inputdate

            If myequip.type = "Handler" Then
                txt_sysno.Text = myequip.sysno
                txt_model.Text = myequip.model
                txt_state.Text = myequip.state
                txt_version.Text = myequip.version
                txt_liense.Text = myequip.license
                DateTimePicker2.Value = myequip.pmdate
                DateTimePicker3.Value = myequip.nextpmdate
            End If
        End If

        Me.BackColor = mydefaultcolor
        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor


    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim sourcefile As String, destfile As String
        'destfile = "192.168.1.100\public\share\CP\TMT_ASL1000"
        destfile = "\\10.10.31.99\cp_mes\AccessorySet\"
        '权限
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            sourcefile = OpenFileDialog1.FileName

            If InStr(sourcefile, " ") > 0 Then
                MsgBox("文件名包含空格!,请修改后上传", vbOKOnly + vbInformation)
                Exit Sub
            End If

            destfile += Format(Now(), "yyyyMMddHHmmss") + "_" + System.IO.Path.GetFileName(sourcefile)



            '文件复制
            FileCopy(sourcefile, destfile)

            'txt_attach.Text = destfile
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

    Private Sub combo_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_type.SelectedIndexChanged

    End Sub
End Class