Public Class frmIOset


    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub


    Private Sub frmIOset_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10

        If IO_Operation_Mode = "MODIFY" Then
            txt_caseID.Text = myio.ID
            combo_type.Text = myio.type
            txt_indate.Text = myio.INDate
            txt_outdate.Text = myio.OUTDate
            combo_status.Text = myio.Status
            combo_equip.Text = myio.equipment
            txt_supplier.Text = myio.equipment
            rtb_config.Text = myio.config
            txt_attach.Text = myio.attach
        End If

        Me.BackColor = mydefaultcolor
        btn_upload.BackColor = mydefaultcolor
        btn_download.BackColor = mydefaultcolor


    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click



        Dim mysql As String

        If IO_Operation_Mode = "NEW" Then

            mysql = "INSERT INTO IOrecord (CaseID,Type,InDate,OutDate,status,equip,supplier,config,Attachment,CreateTime,Creater) VALUES ( '" &
                Format(Now(), "yyyyMMddHHmmss") & "','" & combo_type.Text & "','" & txt_indate.Text & "','" & txt_outdate.Text & "','" & combo_status.Text & "','" & combo_equip.Text & "','" &
                txt_supplier.Text & "','" & rtb_config.Text & "','" & txt_attach.Text & "','" & Now & "','" & UserID & "')"

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

        ElseIf IO_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  IOrecord SET Type= '" & combo_type.Text & "', Indate='" & txt_indate.Text & "', OutDate='" & txt_outdate.Text & "', status='" & combo_status.Text &
                "', supplier='" & txt_supplier.Text & "', equip='" & combo_equip.Text & "', config='" & rtb_config.Text & "', Attachment='" & txt_attach.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE CaseID='" & myio.ID & "'"

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

        Call frmIOrecord.btn_Query_Click("", e)


    End Sub

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click
        Dim sourcefile As String, destfile As String
        destfile = "\\10.10.31.99\cp_mes\IOSet\"

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


End Class