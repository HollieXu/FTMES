Public Class frmCustSet


    Private Sub frmCustSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10
        Dim mycustomer As CUSTTYPE


        '地区设定

        combo_nationity.Items.Add("China")
        combo_nationity.Items.Add("Taiwan")
        combo_nationity.Items.Add("Asia")
        combo_nationity.Items.Add("Europe")
        combo_nationity.Items.Add("America")


        If Customer_Operation_Mode = "MODIFY" Then

            mycustomer = GetCustInfoByEname(mycust.ename)

            txt_id.Text = mycustomer.id
            txt_id.ReadOnly = True

            txt_ename.Text = mycustomer.ename
            txt_shortchar.Text = mycustomer.shortchar
            txt_cname.Text = mycustomer.cname
            combo_nationity.Text = mycustomer.Nationality
            txt_address.Text = mycustomer.address
            txt_remark.Text = mycustomer.remark

        End If
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        '信息正确性校验
        Dim mysql As String
        If Customer_Operation_Mode = "NEW" Then
            If txt_id.Text <> "" Or txt_shortchar.Text <> "" Then

                mysql = "INSERT INTO Customer (ID,ename,shortchar,cname,Nationality,Address,Remark,CreateTime,Creater) VALUES ( '" &
                txt_id.Text & "','" & txt_ename.Text & "','" & txt_shortchar.Text & "','" & txt_cname.Text & "','" & combo_nationity.Text & "','" & txt_address.Text & "','" & txt_remark.Text & "','" & Now & "','" & UserID & "')"

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
            End If
            If txt_id.Text = "" Or txt_shortchar.Text = "" Then
                MessageBox.Show("客户ID 和 2位简码不能为空！")
            End If

        ElseIf Customer_Operation_Mode = "MODIFY" Then

            mysql = "UPDATE  Customer SET ename= '" & txt_ename.Text & "', shortchar='" & txt_shortchar.Text & "', cname='" & txt_cname.Text & "', Nationality='" & combo_nationity.Text & "', Address='" & txt_address.Text &
                "', Remark='" & txt_remark.Text & "', ModifyTime='" & Now & "',Modifier= '" & UserID &
                "' WHERE ID='" & txt_id.Text & "'"

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

        Call frmCust.btn_Query_Click("", e)
    End Sub



End Class