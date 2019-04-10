Imports System.Data.SqlClient

Public Class frmProduct

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click


        '定义命令串，用于存放各种数据查询和数据更新命令
        Dim mysql As String

        '定义内存数据库--数据集对象，用于存放各个sub中的Select命令生成的多种数据表
        Dim mydataset As New DataSet

        DataGridView_Product.DataSource = Nothing
        DataGridView_Flow.DataSource = Nothing

        If ComboBox_Customer.Text = "*" And ComboBox_Product.Text = "*" Then
            mysql = "select * from Product"
        ElseIf ComboBox_Customer.Text = "*" And ComboBox_Product.Text <> "*" Then
            mysql = "select * from Product where InternalProduct=" & "'" & ComboBox_Product.Text & "'"
        ElseIf ComboBox_Customer.Text <> "*" And ComboBox_Product.Text = "*" Then
            mysql = "select * from Product where Customer=" & "'" & ComboBox_Customer.Text & "'"
        ElseIf ComboBox_Customer.Text <> "*" And ComboBox_Product.Text <> "*" Then
            mysql = "select * from Product where Customer='" & ComboBox_Customer.Text & "' and InternalProduct= '" & ComboBox_Product.Text & "'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Product")

        If mydataset.Tables("Product").Rows.Count = 0 Then
            DataGridView_Product.DataSource = Nothing

        Else

            DataGridView_Product.DataSource = mydataset.Tables("Product")

        End If

    End Sub



    Private Sub ComboBox_Customer_DropDown(sender As Object, e As EventArgs) Handles ComboBox_Customer.DropDown

        Dim i As Integer

        '定义命令串，用于存放各种数据查询和数据更新命令
        Dim mysql As String

        '定义内存数据库--数据集对象，用于存放各个sub中的Select命令生成的多种数据表
        Dim mydataset As New DataSet

        mysql = "select ename from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Customer")

        If mydataset.Tables("Customer").Rows.Count = 0 Then
            ComboBox_Customer.Items.Add("Query Customer List Fail !")
        Else

            ComboBox_Customer.Items.Clear()
            ComboBox_Customer.Items.Add("*")
            'List All customer

            For i = 0 To mydataset.Tables("Customer").Rows.Count - 1
                ComboBox_Customer.Items.Add(mydataset.Tables("Customer").Rows(i).Item(0))
            Next


        End If


    End Sub

    Private Sub ComboBox_Product_DropDown(sender As Object, e As EventArgs) Handles ComboBox_Product.DropDown

        Dim i As Integer

        '定义命令串，用于存放各种数据查询和数据更新命令
        Dim mysql As String

        '定义内存数据库--数据集对象，用于存放各个sub中的Select命令生成的多种数据表
        Dim mydataset As New DataSet

        If ComboBox_Customer.Text = "*" Then
            mysql = "select InternalProduct from Product"
        Else
            mysql = "select InternalProduct from Product where Customer=" & "'" & ComboBox_Customer.Text & "'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Product")

        If mydataset.Tables("Product").Rows.Count = 0 Then
            ComboBox_Product.Items.Add("Query Product List Fail !")
        Else

            ComboBox_Product.Items.Clear()
            ComboBox_Product.Items.Add("*")
            'List All customer

            For i = 0 To mydataset.Tables("Product").Rows.Count - 1
                ComboBox_Product.Items.Add(mydataset.Tables("Product").Rows(i).Item(0))
            Next


        End If

    End Sub



    Public Sub DataGridView_Product_Click(sender As Object, e As EventArgs) Handles DataGridView_Product.Click

        myProduct.InternalProduct = DataGridView_Product.SelectedRows(0).Cells("InternalProduct").Value
        myProduct.Customer = DataGridView_Product.SelectedRows(0).Cells("Customer").Value

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Flow where InternalProduct='" & myProduct.InternalProduct & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Flow")

        If mydataset.Tables("Flow").Rows.Count = 0 Then
            DataGridView_Flow.DataSource = Nothing

        Else
            '点击product后，显示出该产品的flow设定
            DataGridView_Flow.DataSource = mydataset.Tables("Flow")

        End If


    End Sub

    Private Sub btn_product_new_Click(sender As Object, e As EventArgs) Handles btn_product_new.Click

        Product_Operation_Mode = "NEW"
        frmProdset.Show()

    End Sub

    Private Sub btn_product_modify_Click(sender As Object, e As EventArgs) Handles btn_product_modify.Click

        Product_Operation_Mode = "MODIFY"
        If DataGridView_Product.Rows.Count = 0 Then Exit Sub


        myProduct.Customer = DataGridView_Product.SelectedRows(0).Cells("Customer").Value
        myProduct.ProductType = DataGridView_Product.SelectedRows(0).Cells("Type").Value
        myProduct.WaferSize = DataGridView_Product.SelectedRows(0).Cells("WaferSize").Value
        myProduct.Bund = DataGridView_Product.SelectedRows(0).Cells("Bund").Value
        myProduct.InternalProduct = DataGridView_Product.SelectedRows(0).Cells("InternalProduct").Value
        myProduct.CustomerProduct = DataGridView_Product.SelectedRows(0).Cells("CustomerProduct").Value
        myProduct.FabProduct = DataGridView_Product.SelectedRows(0).Cells("FabProduct").Value
        myProduct.ShipProduct = DataGridView_Product.SelectedRows(0).Cells("ShipProduct").Value.ToString
        myProduct.RetestFlow = DataGridView_Product.SelectedRows(0).Cells("RetestFlow").Value
        myProduct.GDPW = DataGridView_Product.SelectedRows(0).Cells("GDPW").Value.ToString
        myProduct.Fabsite = DataGridView_Product.SelectedRows(0).Cells("Fabsite").Value.ToString
        myProduct.Mark = DataGridView_Product.SelectedRows(0).Cells("Mark").Value

        frmProdset.Show()

    End Sub

    Private Sub btn_product_delete_Click(sender As Object, e As EventArgs) Handles btn_product_delete.Click

        Dim mysql As String, s As Integer

        If DataGridView_Product.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myProduct.InternalProduct = DataGridView_Product.SelectedRows(0).Cells("InternalProduct").Value

            mysql = "DELETE FROM Product WHERE InternalProduct='" & myProduct.InternalProduct & "'"

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

    Private Sub frmProduct_Load(sender As Object, e As EventArgs) Handles Me.Load
        If UserGroup = GROUPTYPE.SU Then
            btn_product_delete.Visible = True
            btn_flow_delete.Visible = True
        End If

        Select Case UserGroup

            Case GROUPTYPE.SU
                btn_product_delete.Visible = True
                btn_flow_delete.Visible = True
            Case GROUPTYPE.MGR
                btn_product_delete.Enabled = False
                btn_flow_delete.Enabled = False

            Case GROUPTYPE.ENG
                btn_product_delete.Enabled = False
                btn_flow_delete.Enabled = False

                '工程师级别限定PTE工号才有新增/修改/启用/停用 权限
                If Strings.Left(UserID + "0000", 4) <> "0031" Then
                    btn_product_new.Enabled = False
                    btn_product_modify.Enabled = False
                    btn_prod_disable.Enabled = False
                    btn_flow_new.Enabled = False
                    btn_flow_modify.Enabled = False
                    btn_flow_disable.Enabled = False
                    btn_stepdefine.Enabled = False
                    btn_tsprint.Enabled = False
                End If

            Case GROUPTYPE.OP
                btn_product_delete.Enabled = False
                btn_flow_delete.Enabled = False
                btn_product_new.Enabled = False
                btn_product_modify.Enabled = False
                btn_prod_disable.Enabled = False
                btn_flow_new.Enabled = False
                btn_flow_modify.Enabled = False
                btn_flow_disable.Enabled = False
                btn_stepdefine.Enabled = False
                btn_tsprint.Enabled = False

        End Select


        Me.BackColor = mydefaultcolor
        DataGridView_Product.BackgroundColor = mydefaultcolor
        DataGridView_Flow.BackgroundColor = mydefaultcolor

    End Sub



    Private Sub btn_flow_new_Click(sender As Object, e As EventArgs) Handles btn_flow_new.Click
        Flow_Operation_Mode = "NEW"
        frmFlowset.Show()
    End Sub

    Private Sub btn_flow_modify_Click(sender As Object, e As EventArgs) Handles btn_flow_modify.Click

        Flow_Operation_Mode = "MODIFY"
        If DataGridView_Flow.Rows.Count = 0 Then Exit Sub

        myFlow.Type = DataGridView_Flow.SelectedRows(0).Cells("type").Value
        myFlow.ID = DataGridView_Flow.SelectedRows(0).Cells("ID").Value
        myFlow.ilot = DataGridView_Flow.SelectedRows(0).Cells("ilot").Value.ToString
        myFlow.clot = DataGridView_Flow.SelectedRows(0).Cells("clot").Value.ToString
        myFlow.step01 = DataGridView_Flow.SelectedRows(0).Cells("step01").Value.ToString
        myFlow.step02 = DataGridView_Flow.SelectedRows(0).Cells("step02").Value.ToString
        myFlow.step03 = DataGridView_Flow.SelectedRows(0).Cells("step03").Value.ToString
        myFlow.step04 = DataGridView_Flow.SelectedRows(0).Cells("step04").Value.ToString
        myFlow.step05 = DataGridView_Flow.SelectedRows(0).Cells("step05").Value.ToString
        myFlow.step06 = DataGridView_Flow.SelectedRows(0).Cells("step06").Value.ToString
        myFlow.step07 = DataGridView_Flow.SelectedRows(0).Cells("step07").Value.ToString
        myFlow.step08 = DataGridView_Flow.SelectedRows(0).Cells("step08").Value.ToString
        myFlow.step09 = DataGridView_Flow.SelectedRows(0).Cells("step09").Value.ToString
        myFlow.step10 = DataGridView_Flow.SelectedRows(0).Cells("step10").Value.ToString
        myFlow.step11 = DataGridView_Flow.SelectedRows(0).Cells("step11").Value.ToString
        myFlow.step12 = DataGridView_Flow.SelectedRows(0).Cells("step12").Value.ToString
        myFlow.step13 = DataGridView_Flow.SelectedRows(0).Cells("step13").Value.ToString
        myFlow.step14 = DataGridView_Flow.SelectedRows(0).Cells("step14").Value.ToString
        myFlow.step15 = DataGridView_Flow.SelectedRows(0).Cells("step15").Value.ToString
        myFlow.step16 = DataGridView_Flow.SelectedRows(0).Cells("step16").Value.ToString
        myFlow.step17 = DataGridView_Flow.SelectedRows(0).Cells("step17").Value.ToString
        myFlow.step18 = DataGridView_Flow.SelectedRows(0).Cells("step18").Value.ToString
        myFlow.step19 = DataGridView_Flow.SelectedRows(0).Cells("step19").Value.ToString
        myFlow.step20 = DataGridView_Flow.SelectedRows(0).Cells("step20").Value.ToString

        frmFlowset.Show()

    End Sub

    Private Sub btn_prod_disable_Click(sender As Object, e As EventArgs) Handles btn_prod_disable.Click

        If DataGridView_Product.Rows.Count = 0 Then Exit Sub

        myProduct.InternalProduct = DataGridView_Product.SelectedRows(0).Cells("InternalProduct").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该产品吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Product SET ENABLE= '" & False & " ' WHERE InternalProduct= '" & myProduct.InternalProduct & "'"

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

    Private Sub btn_flow_disable_Click(sender As Object, e As EventArgs) Handles btn_flow_disable.Click

        If DataGridView_Flow.Rows.Count = 0 Then Exit Sub

        myFlow.ID = DataGridView_Flow.SelectedRows(0).Cells("ID").Value

        Dim mysql As String, s As Integer

        s = MessageBox.Show("确定要作废该流程吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            mysql = "UPDATE Flow SET ENABLE= '" & False & " ' WHERE ID= '" & myFlow.ID & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            Call DataGridView_Product_Click("", e)

        End If

    End Sub

    Private Sub btn_flow_delete_Click(sender As Object, e As EventArgs) Handles btn_flow_delete.Click

        Dim mysql As String, s As Integer

        If DataGridView_Flow.Rows.Count = 0 Then Exit Sub

        s = MessageBox.Show("确定要从数据库中删除吗，不可恢复！", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        If s = 1 Then

            myFlow.ID = DataGridView_Flow.SelectedRows(0).Cells("ID").Value

            mysql = "DELETE FROM Flow WHERE ID='" & myFlow.ID & "'"

            Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
            myconn.Open()

            Try
                mycmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            myconn.Close()

            '再次呼叫查询按钮，实现删除后的刷新动作
            Call DataGridView_Product_Click("", e)

        End If

    End Sub

    Private Sub btn_stepdefine_Click_1(sender As Object, e As EventArgs) Handles btn_stepdefine.Click
        frmStepset.Show()
    End Sub

    Private Sub btn_tsprint_Click(sender As Object, e As EventArgs) Handles btn_tsprint.Click
        RuncardPrint_Mode = "BYENG"
        frmTSprint.Show()
    End Sub

    Private Sub DataGridView_Product_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Product.CellContentClick

    End Sub
End Class