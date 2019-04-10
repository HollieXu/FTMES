Imports System.Data.SqlClient

Public Class ProductDefForm

    Public DGV_Product_column_number As Integer


    Private Sub ProductDefForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        '定义命令串，用于存放各种数据查询和数据更新命令
        Dim mysql As String

        '定义内存数据库--数据集对象，用于存放各个sub中的Select命令生成的多种数据表
        Dim mydataset As New DataSet

        Dim Combo_Bund As New DataGridViewComboBoxColumn
        Dim Combo_WaferSize As New DataGridViewComboBoxColumn
        Dim Combo_ProdType As New DataGridViewComboBoxColumn
        Dim Combo_Customer As New DataGridViewComboBoxColumn




        DGV_ProductDef.Columns.Add("1", "Internal Product")
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        DGV_ProductDef.Rows.Add(1) '必须先有列，才可以增加行

        DGV_ProductDef.Columns.Add("1", "Customer Product")
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        DGV_ProductDef.Columns.Add("1", "Fab Product")
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        DGV_ProductDef.Columns.Add("1", "Retest Flow")
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        DGV_ProductDef.Columns.Add("1", "Mark")
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = (COLUMNWIDTH * 2)

        Combo_Bund.Name = "Bund"
        Combo_Bund.HeaderText = "保税品"
        Combo_Bund.Items.Add("Y")
        Combo_Bund.Items.Add("N")
        DGV_ProductDef.Columns.Insert(0, Combo_Bund)
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        Combo_WaferSize.Name = "WaferSize"
        Combo_WaferSize.HeaderText = "WaferSize"
        Combo_WaferSize.Items.Add("6 inch")
        Combo_WaferSize.Items.Add("8 inch")
        Combo_WaferSize.Items.Add("12 inch")
        DGV_ProductDef.Columns.Insert(0, Combo_WaferSize)
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        Combo_ProdType.Name = "Product Type"
        Combo_ProdType.HeaderText = "产品类型"
        Combo_ProdType.Items.Add("SOC")
        Combo_ProdType.Items.Add("CIS")
        Combo_ProdType.Items.Add("MEMORY")
        DGV_ProductDef.Columns.Insert(0, Combo_ProdType)
        DGV_Product_column_number += 1
        DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        Combo_Customer.Name = "CUSTOMER"
        Combo_Customer.HeaderText = "CUSTOMER"

        mysql = "select NAME from Customer"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Customer")

        If mydataset.Tables("Customer").Rows.Count = 0 Then
            MsgBox("Query Customer List Fail !")
        Else
            ''List All customer
            For i As Integer = 0 To mydataset.Tables("Customer").Rows.Count - 1
                Combo_Customer.Items.Add(mydataset.Tables("Customer").Rows(i).Item(0))
            Next

            DGV_ProductDef.Columns.Insert(0, Combo_Customer)
            DGV_Product_column_number += 1
            DGV_ProductDef.Columns(DGV_Product_column_number - 1).Width = COLUMNWIDTH

        End If


        '如果是修改模式，先进行赋值
        If Product_Operation_Mode = "MODIFY" Then

            DGV_ProductDef.Item(0, 0).Value = myProduct.Customer
            DGV_ProductDef.Item(1, 0).Value = myProduct.ProductType
            DGV_ProductDef.Item(2, 0).Value = myProduct.WaferSize
            'DGV_ProductDef.Item(3, 0).Value = myProduct.Bund
            DGV_ProductDef.Item(3, 0).Value = ProductSettingForm.DataGridView_Product.Item(3, ProductSettingForm.DataGridView_Product.CurrentCell.RowIndex).Value
            DGV_ProductDef.Item(4, 0).Value = myProduct.InternalProduct
            DGV_ProductDef.Item(5, 0).Value = myProduct.CustomerProduct
            DGV_ProductDef.Item(6, 0).Value = myProduct.FabProduct
            DGV_ProductDef.Item(7, 0).Value = myProduct.RetestFlow
            DGV_ProductDef.Item(8, 0).Value = myProduct.Mark

        End If

    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        Dim j As Integer

        '如果Mark栏位为空，插入*号
        If DGV_ProductDef.Item(DGV_Product_column_number - 1, 0).Value = "" Then DGV_ProductDef.Item(DGV_Product_column_number - 1, 0).Value = "*"



        '正确性查检
        For i As Integer = 0 To DGV_Product_column_number - 1

            If DGV_ProductDef.Item(i, 0).Value.ToString() = "" Then
                DGV_ProductDef.Item(i, 0).Style.BackColor = Color.Red
                MsgBox("Information is not Enough!")
                Exit Sub
            Else
                DGV_ProductDef.Item(i, 0).Style.BackColor = Color.Green
            End If

        Next




        If Product_Operation_Mode = "NEW" Then

            '插入DB
            Dim mysql As String = "SELECT * FROM Product"
            Dim myadapter As New SqlDataAdapter(mysql, myconn)

            Dim mydataset As New DataSet
            myadapter.Fill(mydataset, "Product")

            Dim mydatarow As DataRow = mydataset.Tables("Product").NewRow

            For j = 0 To DGV_Product_column_number - 1
                mydatarow(j) = DGV_ProductDef.Item(j, 0).Value
            Next

            mydatarow(j) = Format(Now(), "yyyy/MM/dd HH:mm:ss")
            mydatarow(j + 1) = UserID

            mydataset.Tables("Product").Rows.Add(mydatarow)
            Dim cm As SqlCommandBuilder = New SqlCommandBuilder(myadapter)
            myadapter.Update(mydataset, "Product")

            Me.Close()

        ElseIf Product_Operation_Mode = "MODIFY" Then
            '更新DB



        End If

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        'Console.WriteLine(DataGridView_ProductDef.CurrentCell.Value)
        'Console.WriteLine(DataGridView_ProductDef.CurrentCell.ColumnIndex)
        'Console.WriteLine(DataGridView_ProductDef.CurrentCell.RowIndex)

        'DataGridView_ProductDef.CurrentCell = DataGridView_ProductDef(0, 0)

        'Console.WriteLine(DataGridView_ProductDef.CurrentCell.Value)

        Me.Close()

    End Sub



End Class