<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProduct
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.ComboBox_Product = New System.Windows.Forms.ComboBox()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.ComboBox_Customer = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_Flow = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView_Product = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_prod_disable = New System.Windows.Forms.Button()
        Me.btn_product_delete = New System.Windows.Forms.Button()
        Me.btn_product_modify = New System.Windows.Forms.Button()
        Me.btn_product_new = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_flow_disable = New System.Windows.Forms.Button()
        Me.btn_flow_delete = New System.Windows.Forms.Button()
        Me.btn_flow_modify = New System.Windows.Forms.Button()
        Me.btn_flow_new = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_stepdefine = New System.Windows.Forms.Button()
        Me.btn_tsprint = New System.Windows.Forms.Button()
        Me.grpbox_Select.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Flow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView_Product, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.ComboBox_Product)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.ComboBox_Customer)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(997, 108)
        Me.grpbox_Select.TabIndex = 0
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(380, 42)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.UseVisualStyleBackColor = False
        '
        'ComboBox_Product
        '
        Me.ComboBox_Product.FormattingEnabled = True
        Me.ComboBox_Product.Location = New System.Drawing.Point(89, 58)
        Me.ComboBox_Product.Name = "ComboBox_Product"
        Me.ComboBox_Product.Size = New System.Drawing.Size(218, 20)
        Me.ComboBox_Product.TabIndex = 3
        Me.ComboBox_Product.Text = "*"
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(30, 58)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(47, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "PRODUCT"
        '
        'ComboBox_Customer
        '
        Me.ComboBox_Customer.FormattingEnabled = True
        Me.ComboBox_Customer.Location = New System.Drawing.Point(89, 20)
        Me.ComboBox_Customer.Name = "ComboBox_Customer"
        Me.ComboBox_Customer.Size = New System.Drawing.Size(218, 20)
        Me.ComboBox_Customer.Sorted = True
        Me.ComboBox_Customer.TabIndex = 1
        Me.ComboBox_Customer.Text = "*"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(30, 23)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(53, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "CUSTOMER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView_Flow)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 471)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(905, 348)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FLOW LIST"
        '
        'DataGridView_Flow
        '
        Me.DataGridView_Flow.AllowUserToAddRows = False
        Me.DataGridView_Flow.AllowUserToDeleteRows = False
        Me.DataGridView_Flow.AllowUserToOrderColumns = True
        Me.DataGridView_Flow.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView_Flow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Flow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Flow.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView_Flow.Name = "DataGridView_Flow"
        Me.DataGridView_Flow.ReadOnly = True
        Me.DataGridView_Flow.RowHeadersVisible = False
        Me.DataGridView_Flow.RowTemplate.Height = 23
        Me.DataGridView_Flow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Flow.Size = New System.Drawing.Size(899, 328)
        Me.DataGridView_Flow.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView_Product)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 124)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(908, 346)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PRODUCT LIST"
        '
        'DataGridView_Product
        '
        Me.DataGridView_Product.AllowUserToAddRows = False
        Me.DataGridView_Product.AllowUserToDeleteRows = False
        Me.DataGridView_Product.AllowUserToOrderColumns = True
        Me.DataGridView_Product.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Product.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView_Product.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView_Product.Name = "DataGridView_Product"
        Me.DataGridView_Product.ReadOnly = True
        Me.DataGridView_Product.RowHeadersVisible = False
        Me.DataGridView_Product.RowTemplate.Height = 23
        Me.DataGridView_Product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_Product.Size = New System.Drawing.Size(902, 326)
        Me.DataGridView_Product.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_prod_disable)
        Me.GroupBox3.Controls.Add(Me.btn_product_delete)
        Me.GroupBox3.Controls.Add(Me.btn_product_modify)
        Me.GroupBox3.Controls.Add(Me.btn_product_new)
        Me.GroupBox3.Location = New System.Drawing.Point(913, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 346)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'btn_prod_disable
        '
        Me.btn_prod_disable.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_prod_disable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_prod_disable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_prod_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_prod_disable.Location = New System.Drawing.Point(3, 203)
        Me.btn_prod_disable.Name = "btn_prod_disable"
        Me.btn_prod_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_prod_disable.TabIndex = 3
        Me.btn_prod_disable.UseVisualStyleBackColor = False
        '
        'btn_product_delete
        '
        Me.btn_product_delete.BackColor = System.Drawing.Color.Red
        Me.btn_product_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_product_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_product_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_product_delete.Location = New System.Drawing.Point(3, 260)
        Me.btn_product_delete.Name = "btn_product_delete"
        Me.btn_product_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_product_delete.TabIndex = 2
        Me.btn_product_delete.UseVisualStyleBackColor = False
        Me.btn_product_delete.Visible = False
        '
        'btn_product_modify
        '
        Me.btn_product_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_product_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_product_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_product_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_product_modify.Location = New System.Drawing.Point(3, 79)
        Me.btn_product_modify.Name = "btn_product_modify"
        Me.btn_product_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_product_modify.TabIndex = 1
        Me.btn_product_modify.UseVisualStyleBackColor = False
        '
        'btn_product_new
        '
        Me.btn_product_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_product_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_product_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_product_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_product_new.Location = New System.Drawing.Point(3, 21)
        Me.btn_product_new.Name = "btn_product_new"
        Me.btn_product_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_product_new.TabIndex = 0
        Me.btn_product_new.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_flow_disable)
        Me.GroupBox4.Controls.Add(Me.btn_flow_delete)
        Me.GroupBox4.Controls.Add(Me.btn_flow_modify)
        Me.GroupBox4.Controls.Add(Me.btn_flow_new)
        Me.GroupBox4.Location = New System.Drawing.Point(913, 471)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(96, 348)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'btn_flow_disable
        '
        Me.btn_flow_disable.BackColor = System.Drawing.SystemColors.Desktop
        Me.btn_flow_disable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_flow_disable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_flow_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_flow_disable.Location = New System.Drawing.Point(3, 163)
        Me.btn_flow_disable.Name = "btn_flow_disable"
        Me.btn_flow_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_flow_disable.TabIndex = 3
        Me.btn_flow_disable.UseVisualStyleBackColor = False
        '
        'btn_flow_delete
        '
        Me.btn_flow_delete.BackColor = System.Drawing.Color.Red
        Me.btn_flow_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_flow_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_flow_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_flow_delete.Location = New System.Drawing.Point(3, 213)
        Me.btn_flow_delete.Name = "btn_flow_delete"
        Me.btn_flow_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_flow_delete.TabIndex = 2
        Me.btn_flow_delete.UseVisualStyleBackColor = False
        Me.btn_flow_delete.Visible = False
        '
        'btn_flow_modify
        '
        Me.btn_flow_modify.BackColor = System.Drawing.SystemColors.Desktop
        Me.btn_flow_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_flow_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_flow_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_flow_modify.Location = New System.Drawing.Point(3, 75)
        Me.btn_flow_modify.Name = "btn_flow_modify"
        Me.btn_flow_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_flow_modify.TabIndex = 1
        Me.btn_flow_modify.UseVisualStyleBackColor = False
        '
        'btn_flow_new
        '
        Me.btn_flow_new.BackColor = System.Drawing.SystemColors.Desktop
        Me.btn_flow_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_flow_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_flow_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_flow_new.Location = New System.Drawing.Point(3, 32)
        Me.btn_flow_new.Name = "btn_flow_new"
        Me.btn_flow_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_flow_new.TabIndex = 0
        Me.btn_flow_new.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_stepdefine)
        Me.GroupBox5.Controls.Add(Me.btn_tsprint)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 825)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(996, 79)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        '
        'btn_stepdefine
        '
        Me.btn_stepdefine.BackColor = System.Drawing.Color.DarkViolet
        Me.btn_stepdefine.BackgroundImage = Global.CPS.My.Resources.Resources.stepdefine1
        Me.btn_stepdefine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_stepdefine.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_stepdefine.FlatAppearance.BorderSize = 5
        Me.btn_stepdefine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_stepdefine.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_stepdefine.ForeColor = System.Drawing.Color.White
        Me.btn_stepdefine.Location = New System.Drawing.Point(57, 20)
        Me.btn_stepdefine.Name = "btn_stepdefine"
        Me.btn_stepdefine.Size = New System.Drawing.Size(408, 48)
        Me.btn_stepdefine.TabIndex = 12
        Me.btn_stepdefine.UseVisualStyleBackColor = False
        '
        'btn_tsprint
        '
        Me.btn_tsprint.BackColor = System.Drawing.Color.SlateBlue
        Me.btn_tsprint.BackgroundImage = Global.CPS.My.Resources.Resources.runcard1
        Me.btn_tsprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_tsprint.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_tsprint.FlatAppearance.BorderSize = 5
        Me.btn_tsprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btn_tsprint.Location = New System.Drawing.Point(531, 20)
        Me.btn_tsprint.Name = "btn_tsprint"
        Me.btn_tsprint.Size = New System.Drawing.Size(391, 48)
        Me.btn_tsprint.TabIndex = 0
        Me.btn_tsprint.UseVisualStyleBackColor = False
        '
        'frmProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1178, 919)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpbox_Select)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmProduct"
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView_Flow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView_Product, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents btn_Query As Button
    Friend WithEvents ComboBox_Product As ComboBox
    Friend WithEvents lbl_product As Label
    Friend WithEvents ComboBox_Customer As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView_Flow As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView_Product As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_product_delete As Button
    Friend WithEvents btn_product_modify As Button
    Friend WithEvents btn_product_new As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btn_flow_disable As Button
    Friend WithEvents btn_flow_delete As Button
    Friend WithEvents btn_flow_modify As Button
    Friend WithEvents btn_flow_new As Button
    Friend WithEvents btn_prod_disable As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_stepdefine As Button
    Friend WithEvents btn_tsprint As Button
End Class
