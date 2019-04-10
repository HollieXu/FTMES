<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShipping
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
        Me.btn_labelprint = New System.Windows.Forms.Button()
        Me.btn_shipform = New System.Windows.Forms.Button()
        Me.btn_shipping_disable = New System.Windows.Forms.Button()
        Me.btn_shipping_confirm = New System.Windows.Forms.Button()
        Me.btn_shipping_modify = New System.Windows.Forms.Button()
        Me.btn_shipping_new = New System.Windows.Forms.Button()
        Me.btn_shipping_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_Shipping = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.combo_shipstatus = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_clot = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_ilot = New System.Windows.Forms.ComboBox()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Shipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_labelprint)
        Me.GroupBox3.Controls.Add(Me.btn_shipform)
        Me.GroupBox3.Controls.Add(Me.btn_shipping_disable)
        Me.GroupBox3.Controls.Add(Me.btn_shipping_confirm)
        Me.GroupBox3.Controls.Add(Me.btn_shipping_modify)
        Me.GroupBox3.Controls.Add(Me.btn_shipping_new)
        Me.GroupBox3.Controls.Add(Me.btn_shipping_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(941, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        '
        'btn_labelprint
        '
        Me.btn_labelprint.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_labelprint.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_labelprint.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_labelprint.Image = Global.CPS.My.Resources.Resources.outlabel1
        Me.btn_labelprint.Location = New System.Drawing.Point(2, 211)
        Me.btn_labelprint.Name = "btn_labelprint"
        Me.btn_labelprint.Size = New System.Drawing.Size(90, 32)
        Me.btn_labelprint.TabIndex = 9
        Me.btn_labelprint.UseVisualStyleBackColor = False
        '
        'btn_shipform
        '
        Me.btn_shipform.BackColor = System.Drawing.Color.Lime
        Me.btn_shipform.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipform.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipform.Image = Global.CPS.My.Resources.Resources.shipform1
        Me.btn_shipform.Location = New System.Drawing.Point(3, 270)
        Me.btn_shipform.Name = "btn_shipform"
        Me.btn_shipform.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipform.TabIndex = 8
        Me.btn_shipform.UseVisualStyleBackColor = False
        '
        'btn_shipping_disable
        '
        Me.btn_shipping_disable.BackColor = System.Drawing.Color.LightCoral
        Me.btn_shipping_disable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipping_disable.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipping_disable.Image = Global.CPS.My.Resources.Resources.zksh
        Me.btn_shipping_disable.Location = New System.Drawing.Point(3, 345)
        Me.btn_shipping_disable.Name = "btn_shipping_disable"
        Me.btn_shipping_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipping_disable.TabIndex = 7
        Me.btn_shipping_disable.UseVisualStyleBackColor = False
        '
        'btn_shipping_confirm
        '
        Me.btn_shipping_confirm.BackColor = System.Drawing.Color.Lime
        Me.btn_shipping_confirm.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipping_confirm.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipping_confirm.Image = Global.CPS.My.Resources.Resources.chxz
        Me.btn_shipping_confirm.Location = New System.Drawing.Point(2, 396)
        Me.btn_shipping_confirm.Name = "btn_shipping_confirm"
        Me.btn_shipping_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipping_confirm.TabIndex = 6
        Me.btn_shipping_confirm.UseVisualStyleBackColor = False
        '
        'btn_shipping_modify
        '
        Me.btn_shipping_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_shipping_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipping_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipping_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_shipping_modify.Location = New System.Drawing.Point(3, 87)
        Me.btn_shipping_modify.Name = "btn_shipping_modify"
        Me.btn_shipping_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipping_modify.TabIndex = 5
        Me.btn_shipping_modify.UseVisualStyleBackColor = False
        '
        'btn_shipping_new
        '
        Me.btn_shipping_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_shipping_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipping_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipping_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_shipping_new.Location = New System.Drawing.Point(3, 38)
        Me.btn_shipping_new.Name = "btn_shipping_new"
        Me.btn_shipping_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipping_new.TabIndex = 4
        Me.btn_shipping_new.UseVisualStyleBackColor = False
        '
        'btn_shipping_delete
        '
        Me.btn_shipping_delete.BackColor = System.Drawing.Color.Red
        Me.btn_shipping_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_shipping_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_shipping_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_shipping_delete.Location = New System.Drawing.Point(2, 449)
        Me.btn_shipping_delete.Name = "btn_shipping_delete"
        Me.btn_shipping_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_shipping_delete.TabIndex = 2
        Me.btn_shipping_delete.UseVisualStyleBackColor = False
        Me.btn_shipping_delete.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_Shipping)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_Shipping
        '
        Me.DGV_Shipping.AllowUserToAddRows = False
        Me.DGV_Shipping.AllowUserToDeleteRows = False
        Me.DGV_Shipping.AllowUserToOrderColumns = True
        Me.DGV_Shipping.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_Shipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Shipping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_Shipping.Location = New System.Drawing.Point(3, 17)
        Me.DGV_Shipping.Name = "DGV_Shipping"
        Me.DGV_Shipping.ReadOnly = True
        Me.DGV_Shipping.RowHeadersVisible = False
        Me.DGV_Shipping.RowTemplate.Height = 23
        Me.DGV_Shipping.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Shipping.Size = New System.Drawing.Size(919, 481)
        Me.DGV_Shipping.TabIndex = 2
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.combo_shipstatus)
        Me.grpbox_Select.Controls.Add(Me.Label4)
        Me.grpbox_Select.Controls.Add(Me.combo_clot)
        Me.grpbox_Select.Controls.Add(Me.Label2)
        Me.grpbox_Select.Controls.Add(Me.combo_ilot)
        Me.grpbox_Select.Controls.Add(Me.txt_cust)
        Me.grpbox_Select.Controls.Add(Me.combo_cust)
        Me.grpbox_Select.Controls.Add(Me.Label1)
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 149)
        Me.grpbox_Select.TabIndex = 21
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'combo_shipstatus
        '
        Me.combo_shipstatus.FormattingEnabled = True
        Me.combo_shipstatus.Location = New System.Drawing.Point(80, 94)
        Me.combo_shipstatus.Name = "combo_shipstatus"
        Me.combo_shipstatus.Size = New System.Drawing.Size(218, 20)
        Me.combo_shipstatus.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "单据状态"
        '
        'combo_clot
        '
        Me.combo_clot.FormattingEnabled = True
        Me.combo_clot.Location = New System.Drawing.Point(415, 58)
        Me.combo_clot.Name = "combo_clot"
        Me.combo_clot.Size = New System.Drawing.Size(218, 20)
        Me.combo_clot.TabIndex = 10
        Me.combo_clot.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "出货批号"
        Me.Label2.Visible = False
        '
        'combo_ilot
        '
        Me.combo_ilot.FormattingEnabled = True
        Me.combo_ilot.Location = New System.Drawing.Point(80, 58)
        Me.combo_ilot.Name = "combo_ilot"
        Me.combo_ilot.Size = New System.Drawing.Size(218, 20)
        Me.combo_ilot.TabIndex = 8
        Me.combo_ilot.Visible = False
        '
        'txt_cust
        '
        Me.txt_cust.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_cust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cust.Enabled = False
        Me.txt_cust.ForeColor = System.Drawing.Color.Blue
        Me.txt_cust.Location = New System.Drawing.Point(328, 26)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(305, 14)
        Me.txt_cust.TabIndex = 7
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(80, 23)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(218, 20)
        Me.combo_cust.TabIndex = 6
        Me.combo_cust.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "客户名称"
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Query.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(821, 58)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.UseVisualStyleBackColor = False
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(21, 61)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(53, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "生产批号"
        Me.lbl_product.Visible = False
        '
        'frmShipping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 774)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmShipping"
        Me.Text = "frmShipping"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_Shipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_shipping_disable As Button
    Friend WithEvents btn_shipping_confirm As Button
    Friend WithEvents btn_shipping_modify As Button
    Friend WithEvents btn_shipping_new As Button
    Friend WithEvents btn_shipping_delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_Shipping As DataGridView
    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents combo_clot As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_ilot As ComboBox
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Query As Button
    Friend WithEvents lbl_product As Label
    Friend WithEvents combo_shipstatus As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_shipform As Button
    Friend WithEvents btn_labelprint As Button
End Class
