Imports System.Data.SqlClient

Public Class frmPwd


    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim mysql As String， mysql2 As String
        Dim mydataset As New DataSet
        Dim oldpwd As String
        Dim newpwd As String

        mysql = "select password from Employee where ID='" & UserID & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            MsgBox("Query password fail !", vbOKOnly + vbExclamation)

            txt_newpwd.Text = ""
            txt_oldpwd.Text = ""

            Exit Sub
        Else
            oldpwd = mydataset.Tables("Employee").Rows(0).Item("password")
        End If

        If oldpwd = txt_oldpwd.Text Then


            mysql2 = "UPDATE  Employee SET password= '" & txt_newpwd.Text & "' WHERE ID='" & UserID & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql2, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()
            'Me.Close()
            MsgBox("Modify OK !", vbOKOnly + vbInformation)

            txt_newpwd.Text = ""
            txt_oldpwd.Text = ""

        Else

            MsgBox("Incorrect old password", vbOKOnly + vbExclamation)

            txt_newpwd.Text = ""
            txt_oldpwd.Text = ""

            Exit Sub

        End If


    End Sub

    Private Sub frmPwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class