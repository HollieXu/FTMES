<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessory
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_accessory_enable = New System.Windows.Forms.Button()
        Me.btn_accessory_modify = New System.Windows.Forms.Button()
        Me.btn_assessory_new = New System.Windows.Forms.Button()
        Me.btn_accessory_disable = New System.Windows.Forms.Button()
        Me.btn_accessory_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Accessory = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Accessory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_accessory_enable)
        Me.GroupBox3.Controls.Add(Me.btn_accessory_modify)
        Me.GroupBox3.Controls.Add(Me.btn_assessory_new)
        Me.GroupBox3.Controls.Add(Me.btn_accessory_disable)
        Me.GroupBox3.Controls.Add(Me.btn_accessory_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(936, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'btn_accessory_enable
        '
        Me.btn_accessory_enable.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_accessory_enable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_accessory_enable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_accessory_enable.Image = Global.CPS.My.Resources.Resources.enable
        Me.btn_accessory_enable.Location = New System.Drawing.Point(3, 250)
        Me.btn_accessory_enable.Name = "btn_accessory_enable"
        Me.btn_accessory_enable.Size = New System.Drawing.Size(90, 32)
        Me.btn_accessory_enable.TabIndex = 6
        Me.btn_accessory_enable.UseVisualStyleBackColor = False
        '
        'btn_accessory_modify
        '
        Me.btn_accessory_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_accessory_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_accessory_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_accessory_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_accessory_modify.Location = New System.Drawing.Point(3, 96)
        Me.btn_accessory_modify.Name = "btn_accessory_modify"
        Me.btn_accessory_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_accessory_modify.TabIndex = 5
        Me.btn_accessory_modify.UseVisualStyleBackColor = False
        '
        'btn_assessory_new
        '
        Me.btn_assessory_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_assessory_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_assessory_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_assessory_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_assessory_new.Location = New System.Drawing.Point(2, 38)
        Me.btn_assessory_new.Name = "btn_assessory_new"
        Me.btn_assessory_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_assessory_new.TabIndex = 4
        Me.btn_assessory_new.UseVisualStyleBackColor = False
        '
        'btn_accessory_disable
        '
        Me.btn_accessory_disable.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_accessory_disable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_accessory_disable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_accessory_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_accessory_disable.Location = New System.Drawing.Point(3, 204)
        Me.btn_accessory_disable.Name = "btn_accessory_disable"
        Me.btn_accessory_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_accessory_disable.TabIndex = 3
        Me.btn_accessory_disable.UseVisualStyleBackColor = False
        '
        'btn_accessory_delete
        '
        Me.btn_accessory_delete.BackColor = System.Drawing.Color.Red
        Me.btn_accessory_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_accessory_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_accessory_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_accessory_delete.Location = New System.Drawing.Point(3, 307)
        Me.btn_accessory_delete.Name = "btn_accessory_delete"
        Me.btn_accessory_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_accessory_delete.TabIndex = 2
        Me.btn_accessory_delete.UseVisualStyleBackColor = False
        Me.btn_accessory_delete.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Accessory)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_Accessory
        '
        Me.DGV_Accessory.AllowUserToAddRows = False
        Me.DGV_Accessory.AllowUserToDeleteRows = False
        Me.DGV_Accessory.AllowUserToOrderColumns = True
        Me.DGV_Accessory.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Accessory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Accessory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Accessory.Location = New System.Drawing.Point(3, 17)
        Me.DGV_Accessory.Name = "DGV_Accessory"
        Me.DGV_Accessory.ReadOnly = True
        Me.DGV_Accessory.RowHeadersVisible = False
        Me.DGV_Accessory.RowTemplate.Height = 23
        Me.DGV_Accessory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Accessory.Size = New System.Drawing.Size(919, 481)
        Me.DGV_Accessory.TabIndex = 2
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.combo_cust)
        Me.grpbox_Select.Controls.Add(Me.Label1)
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.combo_grp)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.combo_type)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 149)
        Me.grpbox_Select.TabIndex = 10
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(89, 100)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(218, 20)
        Me.combo_cust.TabIndex = 6
        Me.combo_cust.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Customer"
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(397, 53)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.UseVisualStyleBackColor = False
        '
        'combo_grp
        '
        Me.combo_grp.FormattingEnabled = True
        Me.combo_grp.Location = New System.Drawing.Point(89, 58)
        Me.combo_grp.Name = "combo_grp"
        Me.combo_grp.Size = New System.Drawing.Size(218, 20)
        Me.combo_grp.TabIndex = 3
        Me.combo_grp.Text = "*"
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(30, 58)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(53, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "Platform"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Location = New System.Drawing.Point(89, 20)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(218, 20)
        Me.combo_type.Sorted = True
        Me.combo_type.TabIndex = 1
        Me.combo_type.Text = "*"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(30, 23)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(29, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "Type"
        '
        'frmAccessory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 692)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmAccessory"
        Me.Text = "frmAccessary"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Accessory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_accessory_enable As Button
    Friend WithEvents btn_accessory_modify As Button
    Friend WithEvents btn_assessory_new As Button
    Friend WithEvents btn_accessory_disable As Button
    Friend WithEvents btn_accessory_delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_Accessory As DataGridView
    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Query As Button
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents lbl_product As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents lbl_customer As Label
End Class
