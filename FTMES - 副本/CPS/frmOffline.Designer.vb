<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffline
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_transfer = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_offline = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.combo_clot = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_ilot = New System.Windows.Forms.ComboBox()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_offline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(311, 710)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(299, 12)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "只有状态为 SHIP 待CHECK IN 的批次会出现在派工表里" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_transfer)
        Me.GroupBox3.Location = New System.Drawing.Point(940, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'btn_transfer
        '
        Me.btn_transfer.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_transfer.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_transfer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_transfer.Image = Global.CPS.My.Resources.Resources.xxrk
        Me.btn_transfer.Location = New System.Drawing.Point(3, 40)
        Me.btn_transfer.Name = "btn_transfer"
        Me.btn_transfer.Size = New System.Drawing.Size(90, 32)
        Me.btn_transfer.TabIndex = 6
        Me.btn_transfer.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_offline)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_offline
        '
        Me.DGV_offline.AllowUserToAddRows = False
        Me.DGV_offline.AllowUserToDeleteRows = False
        Me.DGV_offline.AllowUserToOrderColumns = True
        Me.DGV_offline.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_offline.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_offline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_offline.Location = New System.Drawing.Point(3, 17)
        Me.DGV_offline.Name = "DGV_offline"
        Me.DGV_offline.ReadOnly = True
        Me.DGV_offline.RowHeadersVisible = False
        Me.DGV_offline.RowTemplate.Height = 23
        Me.DGV_offline.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_offline.Size = New System.Drawing.Size(919, 481)
        Me.DGV_offline.TabIndex = 2
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.combo_clot)
        Me.grpbox_Select.Controls.Add(Me.Label2)
        Me.grpbox_Select.Controls.Add(Me.combo_ilot)
        Me.grpbox_Select.Controls.Add(Me.txt_cust)
        Me.grpbox_Select.Controls.Add(Me.combo_cust)
        Me.grpbox_Select.Controls.Add(Me.Label1)
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.combo_type)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 149)
        Me.grpbox_Select.TabIndex = 20
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'combo_clot
        '
        Me.combo_clot.FormattingEnabled = True
        Me.combo_clot.Location = New System.Drawing.Point(415, 95)
        Me.combo_clot.Name = "combo_clot"
        Me.combo_clot.Size = New System.Drawing.Size(218, 20)
        Me.combo_clot.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "客户批号"
        '
        'combo_ilot
        '
        Me.combo_ilot.FormattingEnabled = True
        Me.combo_ilot.Location = New System.Drawing.Point(80, 95)
        Me.combo_ilot.Name = "combo_ilot"
        Me.combo_ilot.Size = New System.Drawing.Size(218, 20)
        Me.combo_ilot.TabIndex = 8
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
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(818, 53)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.UseVisualStyleBackColor = False
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(21, 98)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(53, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "生产批号"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Items.AddRange(New Object() {"*", "CORR", "ENG", "PROD"})
        Me.combo_type.Location = New System.Drawing.Point(80, 58)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(218, 20)
        Me.combo_type.Sorted = True
        Me.combo_type.TabIndex = 1
        Me.combo_type.Text = "*"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(21, 61)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(53, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "产品类型"
        '
        'frmOffline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 805)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmOffline"
        Me.Text = "frmOffline"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_offline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_transfer As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_offline As DataGridView
    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents combo_clot As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_ilot As ComboBox
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_Query As Button
    Friend WithEvents lbl_product As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents lbl_customer As Label
End Class
