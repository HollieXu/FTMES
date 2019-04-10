Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = mydefaultcolor

        'combo_server.Items.Add("FTMES")
        'combo_server.Items.Add("FTMES-TEST")
        'combo_server.Items.Add("FTMES-LOCAL")
        combo_server.Text = "FTMES-LOCAL"

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        '定义命令串，用于存放各种数据查询和数据更新命令
        Dim mysql As String

        '定义内存数据库--数据集对象，用于存放各个sub中的Select命令生成的多种数据表
        Dim mydataset As New DataSet

        '定义数据库访问连接

        If combo_server.Text = "" Then combo_server.Text = "FTMES01"
        Select Case combo_server.Text

            Case "FTMES"  '服务器正式区

                myconn = New SqlConnection("Data Source=10.10.31.99;Initial Catalog=FTMES;Persist Security Info=True;User ID=FTMES01;Password=abc123!")
                mydefaultcolor = MyColors("2")

            Case "FTMES-TEST"  '服务器测试区

                myconn = New SqlConnection("Data Source=10.10.31.99;Initial Catalog=FTMES-TEST;Persist Security Info=True;User ID=FTMES01-TEST;Password=abc123!")
                mydefaultcolor = MyColors("4")

            Case "FTMES-LOCAL"   ' 本地测试区
                myconn = New SqlConnection("Data Source=HOLLIE;Initial Catalog=FTMES;Persist Security Info=True;User ID=FTMES01;Password=abc123!")
                mydefaultcolor = MyColors("4")

            Case Else
                MsgBox("未设定的Server，请联系IT确认！", vbOKOnly + vbExclamation)
                Exit Sub

        End Select

        mysql = "select * from Employee where ID='" & txt_user.Text & "' and password='" & txt_pwd.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            MsgBox("User ID or Password not correct !", vbOKOnly + vbExclamation)
            txt_user.Text = ""
            txt_pwd.Text = ""

        Else

            UserID = txt_user.Text
            UserName = mydataset.Tables("Employee").Rows(0).Item("cname")
            UserPosition = mydataset.Tables("Employee").Rows(0).Item("position")
            UserGroup = CInt(mydataset.Tables("Employee").Rows(0).Item("Grp"))

            frmCPSMain.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub btn_Exit_Click(sender As Object, e As EventArgs) Handles btn_Exit.Click
        Me.Close()
    End Sub
End Class
