Imports System.Data.SqlClient

Public Class frmEmployee


    Private Sub combo_ID_DropDown(sender As Object, e As EventArgs) Handles combo_ID.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select ID from Employee"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            combo_ID.Items.Add("Query Employee List Fail !")
        Else

            combo_ID.Items.Clear()
            combo_ID.Items.Add("*")

            For i = 0 To mydataset.Tables("Employee").Rows.Count - 1
                combo_ID.Items.Add(mydataset.Tables("Employee").Rows(i).Item(0))
            Next


        End If

    End Sub



    Private Sub combo_department_DropDown(sender As Object, e As EventArgs) Handles combo_department.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Department from Employee"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            combo_department.Items.Add("Query Employee List Fail !")
        Else

            combo_department.Items.Clear()
            combo_department.Items.Add("*")

            For i = 0 To mydataset.Tables("Employee").Rows.Count - 1
                combo_department.Items.Add(mydataset.Tables("Employee").Rows(i).Item(0))
            Next


        End If

    End Sub

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click

        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_employee.DataSource = Nothing

        If combo_ID.Text = "*" And combo_department.Text = "*" Then
            mysql = "select ID as 工号,ename as EnglishName,cname as 中文名,Department as 部门,Position as 职位,Grp as 权限群组 from Employee "
        ElseIf combo_ID.Text = "*" And combo_department.Text <> "*" Then
            mysql = "select ID as 工号,ename as EnglishName,cname as 中文名,Department as 部门,Position as 职位,Grp as 权限群组 from Employee where Department='" & combo_department.Text & "'"
        ElseIf combo_ID.Text <> "*" And combo_department.Text = "*" Then
            mysql = "select ID as 工号,ename as EnglishName,cname as 中文名,Department as 部门,Position as 职位,Grp as 权限群组 from Employee where ID='" & combo_ID.Text & "'"
        ElseIf combo_ID.Text <> "*" And combo_department.Text <> "*" Then
            mysql = "select ID as 工号,ename as EnglishName,cname as 中文名,Department as 部门,Position as 职位,Grp as 权限群组 from Employee where ID='" & combo_ID.Text & "' AND Department='" & combo_department.Text & "'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            DGV_employee.DataSource = Nothing

        Else
            DGV_employee.DataSource = mydataset.Tables("Employee")
        End If

    End Sub

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_employee_delete.Visible = True

            Case GROUPTYPE.MGR, GROUPTYPE.ENG

                btn_employee_delete.Enabled = False

            Case GROUPTYPE.OP

                btn_employee_new.Enabled = False
                btn_employee_modify.Enabled = False
                btn_employee_delete.Enabled = False

        End Select


        Me.BackColor = mydefaultcolor
        DGV_employee.BackgroundColor = mydefaultcolor
    End Sub

    Private Sub btn_employee_new_Click(sender As Object, e As EventArgs) Handles btn_employee_new.Click

        Employee_Operation_Mode = "NEW"
        frmEmploySet.Show()

    End Sub

    Private Sub btn_employee_modify_Click(sender As Object, e As EventArgs) Handles btn_employee_modify.Click

        Employee_Operation_Mode = "MODIFY"

        If DGV_employee.Rows.Count = 0 Then Exit Sub

        myemployee.id = DGV_employee.Item(0, DGV_employee.CurrentCell.RowIndex).Value
        myemployee.ename = DGV_employee.Item(1, DGV_employee.CurrentCell.RowIndex).Value
        myemployee.cname = DGV_employee.Item(2, DGV_employee.CurrentCell.RowIndex).Value
        myemployee.department = DGV_employee.Item(3, DGV_employee.CurrentCell.RowIndex).Value
        myemployee.position = DGV_employee.Item(4, DGV_employee.CurrentCell.RowIndex).Value
        myemployee.Grp = DGV_employee.Item(5, DGV_employee.CurrentCell.RowIndex).Value

        'myemployee.id = DGV_employee.SelectedRows(0).Cells("ID").Value.ToString
        'myemployee.ename = DGV_employee.SelectedRows(0).Cells("ename").Value.ToString
        'myemployee.cname = DGV_employee.SelectedRows(0).Cells("cname").Value.ToString
        'myemployee.department = DGV_employee.SelectedRows(0).Cells("Department").Value.ToString
        'myemployee.position = DGV_employee.SelectedRows(0).Cells("Position").Value.ToString
        'myemployee.Grp = DGV_employee.SelectedRows(0).Cells("Grp").Value


        frmEmploySet.Show()

    End Sub

    Private Sub btn_employee_delete_Click(sender As Object, e As EventArgs) Handles btn_employee_delete.Click

        Dim mysql As String, s As Integer

        If DGV_employee.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myemployee.id = DGV_employee.Item(0, DGV_employee.CurrentCell.RowIndex).Value

            mysql = "DELETE FROM Employee WHERE ID='" & myemployee.id & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()


            '再次呼叫查询按钮，实现删除后的刷新动作
            Call btn_Query_Click("", e)

        End If


    End Sub



End Class