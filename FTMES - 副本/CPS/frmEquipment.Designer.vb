<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEquipment
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
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_equipment_enable = New System.Windows.Forms.Button()
        Me.btn_equipment_modify = New System.Windows.Forms.Button()
        Me.btn_equipment_new = New System.Windows.Forms.Button()
        Me.btn_equipment_disable = New System.Windows.Forms.Button()
        Me.btn_equipment_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_equipment = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_equipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.combo_grp)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.combo_type)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 108)
        Me.grpbox_Select.TabIndex = 1
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(380, 42)
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
        Me.lbl_product.Size = New System.Drawing.Size(35, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "Group"
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
        Me.lbl_customer.Size = New System.Drawing.Size(35, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "Typle"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_equipment_enable)
        Me.GroupBox3.Controls.Add(Me.btn_equipment_modify)
        Me.GroupBox3.Controls.Add(Me.btn_equipment_new)
        Me.GroupBox3.Controls.Add(Me.btn_equipment_disable)
        Me.GroupBox3.Controls.Add(Me.btn_equipment_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(939, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        '
        'btn_equipment_enable
        '
        Me.btn_equipment_enable.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_equipment_enable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_equipment_enable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_equipment_enable.Image = Global.CPS.My.Resources.Resources.enable
        Me.btn_equipment_enable.Location = New System.Drawing.Point(4, 250)
        Me.btn_equipment_enable.Name = "btn_equipment_enable"
        Me.btn_equipment_enable.Size = New System.Drawing.Size(90, 32)
        Me.btn_equipment_enable.TabIndex = 6
        Me.btn_equipment_enable.UseVisualStyleBackColor = False
        '
        'btn_equipment_modify
        '
        Me.btn_equipment_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_equipment_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_equipment_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_equipment_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_equipment_modify.Location = New System.Drawing.Point(4, 96)
        Me.btn_equipment_modify.Name = "btn_equipment_modify"
        Me.btn_equipment_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_equipment_modify.TabIndex = 5
        Me.btn_equipment_modify.UseVisualStyleBackColor = False
        '
        'btn_equipment_new
        '
        Me.btn_equipment_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_equipment_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_equipment_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_equipment_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_equipment_new.Location = New System.Drawing.Point(4, 38)
        Me.btn_equipment_new.Name = "btn_equipment_new"
        Me.btn_equipment_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_equipment_new.TabIndex = 4
        Me.btn_equipment_new.UseVisualStyleBackColor = False
        '
        'btn_equipment_disable
        '
        Me.btn_equipment_disable.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_equipment_disable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_equipment_disable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_equipment_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_equipment_disable.Location = New System.Drawing.Point(4, 204)
        Me.btn_equipment_disable.Name = "btn_equipment_disable"
        Me.btn_equipment_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_equipment_disable.TabIndex = 3
        Me.btn_equipment_disable.UseVisualStyleBackColor = False
        '
        'btn_equipment_delete
        '
        Me.btn_equipment_delete.BackColor = System.Drawing.Color.Red
        Me.btn_equipment_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_equipment_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_equipment_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_equipment_delete.Location = New System.Drawing.Point(4, 307)
        Me.btn_equipment_delete.Name = "btn_equipment_delete"
        Me.btn_equipment_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_equipment_delete.TabIndex = 2
        Me.btn_equipment_delete.UseVisualStyleBackColor = False
        Me.btn_equipment_delete.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_equipment)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_equipment
        '
        Me.DGV_equipment.AllowUserToAddRows = False
        Me.DGV_equipment.AllowUserToDeleteRows = False
        Me.DGV_equipment.AllowUserToOrderColumns = True
        Me.DGV_equipment.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_equipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_equipment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_equipment.Location = New System.Drawing.Point(3, 17)
        Me.DGV_equipment.Name = "DGV_equipment"
        Me.DGV_equipment.ReadOnly = True
        Me.DGV_equipment.RowHeadersVisible = False
        Me.DGV_equipment.RowTemplate.Height = 23
        Me.DGV_equipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_equipment.Size = New System.Drawing.Size(919, 481)
        Me.DGV_equipment.TabIndex = 2
        '
        'frmEquipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmEquipment"
        Me.Text = "frmEquipment"
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_equipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents btn_Query As Button
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents lbl_product As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_equipment_disable As Button
    Friend WithEvents btn_equipment_delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_equipment As DataGridView
    Friend WithEvents btn_equipment_modify As Button
    Friend WithEvents btn_equipment_new As Button
    Friend WithEvents btn_equipment_enable As Button
End Class
