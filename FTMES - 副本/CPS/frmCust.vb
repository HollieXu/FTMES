Imports System.Data.SqlClient

Public Class frmCust



    Private Sub combo_ename_DropDown(sender As Object, e As EventArgs) Handles combo_ename.DropDown

        Dim custarray() As String
        custarray = GetCustomerList()

        combo_ename.Items.Clear()
        combo_ename.Items.Add("*")
        For i = 0 To UBound(custarray) - 1
            combo_ename.Items.Add(custarray(i))
        Next

    End Sub

    Private Sub combo_ename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_ename.SelectedIndexChanged

        If combo_ename.Text <> "*" Then
            txt_cname.Text = GetCustCNAME(combo_ename.Text)
        End If

    End Sub

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_cust.DataSource = Nothing

        If combo_ename.Text = "*" Then
            mysql = "select * from Customer"
        ElseIf combo_ename.Text <> "*" Then
            mysql = "select * from Customer where ename='" & combo_ename.Text & "'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            DGV_cust.DataSource = Nothing

        Else
            DGV_cust.DataSource = mydataset.Tables("Cust")
        End If

    End Sub


    Private Sub frmCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_cust_delete.Visible = True

            Case GROUPTYPE.MGR
                btn_cust_delete.Enabled = False

            Case GROUPTYPE.ENG
                btn_cust_delete.Enabled = False

                '工程师级别限定PP工号才有新增/修改权限
                If Strings.Left(UserID + "0000", 4) <> "0033" Then
                    btn_cust_new.Enabled = False
                    btn_cust_modify.Enabled = False
                    btn_cust_delete.Enabled = False
                End If

            Case GROUPTYPE.OP
                btn_cust_new.Enabled = False
                btn_cust_modify.Enabled = False
                btn_cust_delete.Enabled = False
        End Select


        Me.BackColor = mydefaultcolor
        DGV_cust.BackgroundColor = mydefaultcolor
        txt_cname.BackColor = mydefaultcolor


    End Sub

    Private Sub btn_cust_new_Click(sender As Object, e As EventArgs) Handles btn_cust_new.Click
        Customer_Operation_Mode = "NEW"
        frmCustSet.Show()
    End Sub

    Private Sub btn_cust_modify_Click(sender As Object, e As EventArgs) Handles btn_cust_modify.Click

        Customer_Operation_Mode = "MODIFY"


        If DGV_cust.Rows.Count = 0 Then Exit Sub

        mycust.ename = DGV_cust.SelectedRows(0).Cells("ename").Value.ToString

        frmCustSet.Show()

    End Sub

    Private Sub btn_cust_delete_Click(sender As Object, e As EventArgs) Handles btn_cust_delete.Click
        Dim mysql As String, s As Integer

        If DGV_cust.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mycust.id = DGV_cust.SelectedRows(0).Cells("ID").Value

            mysql = "DELETE FROM Customer WHERE ID='" & mycust.id & "'"

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


End Class