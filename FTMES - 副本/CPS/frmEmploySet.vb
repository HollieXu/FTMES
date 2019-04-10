Public Class frmEmploySet


    Private Sub frmEmploySet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10


        '只可设定比当前群组低级别的权限或者相同权限.
        Select Case UserGroup

            Case GROUPTYPE.SU
                combo_grp.Items.Clear()
                combo_grp.Items.Add("0")
                combo_grp.Items.Add("1")
                combo_grp.Items.Add("5")
                combo_grp.Items.Add("9")

            Case GROUPTYPE.MGR

                combo_grp.Items.Add("5")
                combo_grp.Items.Add("9")


            Case GROUPTYPE.ENG
                combo_grp.Items.Clear()
                combo_grp.Items.Add("9")

            Case GROUPTYPE.OP
                combo_grp.Items.Clear()

        End Select

        '部门添加
        combo_department.Items.Add("产品测试及检验工程部")
        combo_department.Items.Add("设备及配件工程部")
        combo_department.Items.Add("生产及计划部")
        combo_department.Items.Add("测试开发部")
        combo_department.Items.Add("IT系统部")
        combo_department.Items.Add("品质部")


        If Employee_Operation_Mode = "MODIFY" Then


            txt_id.Text = myemployee.id
            txt_ename.Text = myemployee.ename
            txt_cname.Text = myemployee.cname
            combo_department.Text = myemployee.department
            txt_position.Text = myemployee.position
            combo_grp.Text = myemployee.Grp


        End If




    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click




        Dim mysql As String

        If Employee_Operation_Mode = "NEW" Then

            mysql = "INSERT INTO Employee (ID,Password,ename,cname,Department,Grp,Position,CreateTime,Creater) VALUES ( '" &
                txt_id.Text & "','123456','" & txt_ename.Text & "','" & txt_cname.Text & "','" & combo_department.Text & "','" & combo_grp.Text & "','" & txt_position.Text & "','" & Now & "','" & UserID & "')"

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

        ElseIf Employee_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  Employee SET ID= '" & txt_id.Text & "', ename='" & txt_ename.Text & "', cname='" & txt_cname.Text & "', Department='" & combo_department.Text &
                "', Grp='" & combo_grp.Text & "', Position='" & txt_position.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE ID='" & myemployee.id & "'"

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

        Call frmEmployee.btn_Query_Click("", e)


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Me.Close()

    End Sub




End Class