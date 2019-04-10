<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShippingSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShippingSet))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_BoxQTY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_shipmethod = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ShipOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_senderphone = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_senderop = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_senderaddress = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_sender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_reciverphone = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_reciveraddress = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_reciverop = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_reciver = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DGV_lot = New System.Windows.Forms.DataGridView()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txt_outerboxid = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_GW = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_NW = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_height = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_slot = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txt_grossdie = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_gooddie = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_yield = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.combo_ilot = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.combo_express = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ShippingExpressNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.txt_sopath = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.rtb_remark = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.DGV_lot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_BoxQTY)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.combo_shipmethod)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.combo_cust)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_ShipOrder)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1223, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "出货单信息"
        '
        'txt_BoxQTY
        '
        Me.txt_BoxQTY.Location = New System.Drawing.Point(885, 61)
        Me.txt_BoxQTY.Name = "txt_BoxQTY"
        Me.txt_BoxQTY.Size = New System.Drawing.Size(169, 21)
        Me.txt_BoxQTY.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(823, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "总箱数:"
        '
        'combo_shipmethod
        '
        Me.combo_shipmethod.FormattingEnabled = True
        Me.combo_shipmethod.Location = New System.Drawing.Point(622, 61)
        Me.combo_shipmethod.Name = "combo_shipmethod"
        Me.combo_shipmethod.Size = New System.Drawing.Size(167, 20)
        Me.combo_shipmethod.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(556, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "出货方式:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(356, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(170, 21)
        Me.DateTimePicker1.TabIndex = 31
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(94, 21)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(167, 20)
        Me.combo_cust.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(294, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "出货日期:"
        '
        'txt_ShipOrder
        '
        Me.txt_ShipOrder.Enabled = False
        Me.txt_ShipOrder.Location = New System.Drawing.Point(93, 58)
        Me.txt_ShipOrder.Name = "txt_ShipOrder"
        Me.txt_ShipOrder.ReadOnly = True
        Me.txt_ShipOrder.Size = New System.Drawing.Size(169, 21)
        Me.txt_ShipOrder.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "出货单号:"
        '
        'txt_cust
        '
        Me.txt_cust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cust.Enabled = False
        Me.txt_cust.ForeColor = System.Drawing.Color.Blue
        Me.txt_cust.Location = New System.Drawing.Point(283, 23)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(294, 14)
        Me.txt_cust.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "客户名称:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_senderphone)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txt_senderop)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_senderaddress)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_sender)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1223, 102)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "发货方信息"
        '
        'txt_senderphone
        '
        Me.txt_senderphone.Location = New System.Drawing.Point(435, 64)
        Me.txt_senderphone.Name = "txt_senderphone"
        Me.txt_senderphone.Size = New System.Drawing.Size(169, 21)
        Me.txt_senderphone.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(373, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "电话:"
        '
        'txt_senderop
        '
        Me.txt_senderop.Location = New System.Drawing.Point(89, 64)
        Me.txt_senderop.Name = "txt_senderop"
        Me.txt_senderop.Size = New System.Drawing.Size(253, 21)
        Me.txt_senderop.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(27, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "联系人:"
        '
        'txt_senderaddress
        '
        Me.txt_senderaddress.Location = New System.Drawing.Point(435, 25)
        Me.txt_senderaddress.Name = "txt_senderaddress"
        Me.txt_senderaddress.Size = New System.Drawing.Size(757, 21)
        Me.txt_senderaddress.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(373, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "公司地址:"
        '
        'txt_sender
        '
        Me.txt_sender.Location = New System.Drawing.Point(89, 25)
        Me.txt_sender.Name = "txt_sender"
        Me.txt_sender.ReadOnly = True
        Me.txt_sender.Size = New System.Drawing.Size(253, 21)
        Me.txt_sender.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "公司名称:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_reciverphone)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_reciveraddress)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_reciverop)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_reciver)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1223, 112)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "收货方信息"
        '
        'txt_reciverphone
        '
        Me.txt_reciverphone.Location = New System.Drawing.Point(435, 73)
        Me.txt_reciverphone.Name = "txt_reciverphone"
        Me.txt_reciverphone.Size = New System.Drawing.Size(169, 21)
        Me.txt_reciverphone.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(373, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 12)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "电话:"
        '
        'txt_reciveraddress
        '
        Me.txt_reciveraddress.Location = New System.Drawing.Point(435, 34)
        Me.txt_reciveraddress.Name = "txt_reciveraddress"
        Me.txt_reciveraddress.Size = New System.Drawing.Size(757, 21)
        Me.txt_reciveraddress.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(373, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "公司地址:"
        '
        'txt_reciverop
        '
        Me.txt_reciverop.Location = New System.Drawing.Point(89, 70)
        Me.txt_reciverop.Name = "txt_reciverop"
        Me.txt_reciverop.Size = New System.Drawing.Size(250, 21)
        Me.txt_reciverop.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 12)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "联系人:"
        '
        'txt_reciver
        '
        Me.txt_reciver.Location = New System.Drawing.Point(89, 31)
        Me.txt_reciver.Name = "txt_reciver"
        Me.txt_reciver.Size = New System.Drawing.Size(250, 21)
        Me.txt_reciver.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(27, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 12)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "公司名称:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Controls.Add(Me.GroupBox8)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 318)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1223, 308)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "货批信息"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DGV_lot)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(3, 110)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1217, 195)
        Me.GroupBox9.TabIndex = 69
        Me.GroupBox9.TabStop = False
        '
        'DGV_lot
        '
        Me.DGV_lot.AllowUserToAddRows = False
        Me.DGV_lot.AllowUserToDeleteRows = False
        Me.DGV_lot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_lot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_lot.Location = New System.Drawing.Point(3, 17)
        Me.DGV_lot.Name = "DGV_lot"
        Me.DGV_lot.RowHeadersVisible = False
        Me.DGV_lot.RowTemplate.Height = 23
        Me.DGV_lot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_lot.Size = New System.Drawing.Size(1211, 175)
        Me.DGV_lot.TabIndex = 1
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.GroupBox7)
        Me.GroupBox8.Controls.Add(Me.txt_slot)
        Me.GroupBox8.Controls.Add(Me.Label28)
        Me.GroupBox8.Controls.Add(Me.txt_grossdie)
        Me.GroupBox8.Controls.Add(Me.Label27)
        Me.GroupBox8.Controls.Add(Me.txt_gooddie)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Controls.Add(Me.txt_yield)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.combo_ilot)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.btn_del)
        Me.GroupBox8.Controls.Add(Me.btn_add)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1217, 93)
        Me.GroupBox8.TabIndex = 68
        Me.GroupBox8.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txt_outerboxid)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.txt_GW)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.txt_NW)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.txt_height)
        Me.GroupBox7.Controls.Add(Me.Label23)
        Me.GroupBox7.Controls.Add(Me.txt_width)
        Me.GroupBox7.Controls.Add(Me.Label22)
        Me.GroupBox7.Controls.Add(Me.txt_length)
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Location = New System.Drawing.Point(690, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(399, 93)
        Me.GroupBox7.TabIndex = 92
        Me.GroupBox7.TabStop = False
        '
        'txt_outerboxid
        '
        Me.txt_outerboxid.ForeColor = System.Drawing.Color.Blue
        Me.txt_outerboxid.Location = New System.Drawing.Point(47, 22)
        Me.txt_outerboxid.Name = "txt_outerboxid"
        Me.txt_outerboxid.Size = New System.Drawing.Size(76, 21)
        Me.txt_outerboxid.TabIndex = 95
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 12)
        Me.Label20.TabIndex = 94
        Me.Label20.Text = "箱号:"
        '
        'txt_GW
        '
        Me.txt_GW.ForeColor = System.Drawing.Color.Blue
        Me.txt_GW.Location = New System.Drawing.Point(311, 22)
        Me.txt_GW.Name = "txt_GW"
        Me.txt_GW.Size = New System.Drawing.Size(76, 21)
        Me.txt_GW.TabIndex = 93
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(270, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 12)
        Me.Label19.TabIndex = 92
        Me.Label19.Text = "毛重:"
        '
        'txt_NW
        '
        Me.txt_NW.ForeColor = System.Drawing.Color.Blue
        Me.txt_NW.Location = New System.Drawing.Point(171, 22)
        Me.txt_NW.Name = "txt_NW"
        Me.txt_NW.Size = New System.Drawing.Size(76, 21)
        Me.txt_NW.TabIndex = 91
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(130, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 12)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "净重:"
        '
        'txt_height
        '
        Me.txt_height.ForeColor = System.Drawing.Color.Blue
        Me.txt_height.Location = New System.Drawing.Point(312, 56)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Size = New System.Drawing.Size(75, 21)
        Me.txt_height.TabIndex = 89
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(276, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(23, 12)
        Me.Label23.TabIndex = 88
        Me.Label23.Text = "高:"
        '
        'txt_width
        '
        Me.txt_width.ForeColor = System.Drawing.Color.Blue
        Me.txt_width.Location = New System.Drawing.Point(171, 56)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(76, 21)
        Me.txt_width.TabIndex = 87
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(142, 61)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(23, 12)
        Me.Label22.TabIndex = 86
        Me.Label22.Text = "宽:"
        '
        'txt_length
        '
        Me.txt_length.ForeColor = System.Drawing.Color.Blue
        Me.txt_length.Location = New System.Drawing.Point(47, 56)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(76, 21)
        Me.txt_length.TabIndex = 85
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(18, 61)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 12)
        Me.Label21.TabIndex = 84
        Me.Label21.Text = "长:"
        '
        'txt_slot
        '
        Me.txt_slot.ForeColor = System.Drawing.Color.Blue
        Me.txt_slot.Location = New System.Drawing.Point(74, 56)
        Me.txt_slot.Name = "txt_slot"
        Me.txt_slot.ReadOnly = True
        Me.txt_slot.Size = New System.Drawing.Size(152, 21)
        Me.txt_slot.TabIndex = 91
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 59)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 12)
        Me.Label28.TabIndex = 90
        Me.Label28.Text = "出货批号:"
        '
        'txt_grossdie
        '
        Me.txt_grossdie.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_grossdie.ForeColor = System.Drawing.Color.Red
        Me.txt_grossdie.Location = New System.Drawing.Point(583, 22)
        Me.txt_grossdie.Name = "txt_grossdie"
        Me.txt_grossdie.Size = New System.Drawing.Size(76, 21)
        Me.txt_grossdie.TabIndex = 89
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(518, 25)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 12)
        Me.Label27.TabIndex = 88
        Me.Label27.Text = "GrossDie:"
        '
        'txt_gooddie
        '
        Me.txt_gooddie.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_gooddie.ForeColor = System.Drawing.Color.Red
        Me.txt_gooddie.Location = New System.Drawing.Point(436, 22)
        Me.txt_gooddie.Name = "txt_gooddie"
        Me.txt_gooddie.Size = New System.Drawing.Size(76, 21)
        Me.txt_gooddie.TabIndex = 87
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(386, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 12)
        Me.Label26.TabIndex = 86
        Me.Label26.Text = "GoodDie:"
        '
        'txt_yield
        '
        Me.txt_yield.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_yield.ForeColor = System.Drawing.Color.Red
        Me.txt_yield.Location = New System.Drawing.Point(296, 22)
        Me.txt_yield.Name = "txt_yield"
        Me.txt_yield.Size = New System.Drawing.Size(76, 21)
        Me.txt_yield.TabIndex = 85
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(249, 25)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 12)
        Me.Label24.TabIndex = 84
        Me.Label24.Text = "Yield:"
        '
        'combo_ilot
        '
        Me.combo_ilot.FormattingEnabled = True
        Me.combo_ilot.Location = New System.Drawing.Point(74, 22)
        Me.combo_ilot.Name = "combo_ilot"
        Me.combo_ilot.Size = New System.Drawing.Size(152, 20)
        Me.combo_ilot.TabIndex = 71
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 12)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "生产批号:"
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_del.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_del.FlatAppearance.BorderSize = 2
        Me.btn_del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_del.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Blue
        Me.btn_del.Image = Global.CPS.My.Resources.Resources.del2
        Me.btn_del.Location = New System.Drawing.Point(1108, 53)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(90, 32)
        Me.btn_del.TabIndex = 69
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.btn_add.FlatAppearance.BorderSize = 2
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_add.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.Blue
        Me.btn_add.Image = Global.CPS.My.Resources.Resources.add
        Me.btn_add.Location = New System.Drawing.Point(1108, 15)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(90, 32)
        Me.btn_add.TabIndex = 68
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.combo_express)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_ShippingExpressNo)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 626)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1223, 68)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "物流信息"
        '
        'combo_express
        '
        Me.combo_express.FormattingEnabled = True
        Me.combo_express.Location = New System.Drawing.Point(92, 25)
        Me.combo_express.Name = "combo_express"
        Me.combo_express.Size = New System.Drawing.Size(170, 20)
        Me.combo_express.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "物流公司:"
        '
        'txt_ShippingExpressNo
        '
        Me.txt_ShippingExpressNo.Location = New System.Drawing.Point(359, 25)
        Me.txt_ShippingExpressNo.Name = "txt_ShippingExpressNo"
        Me.txt_ShippingExpressNo.Size = New System.Drawing.Size(169, 21)
        Me.txt_ShippingExpressNo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(297, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "物流单号:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btn_download)
        Me.GroupBox6.Controls.Add(Me.btn_upload)
        Me.GroupBox6.Controls.Add(Me.txt_sopath)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.rtb_remark)
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.Location = New System.Drawing.Point(0, 694)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1223, 139)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "备注及附件"
        '
        'btn_download
        '
        Me.btn_download.AutoSize = True
        Me.btn_download.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_download.FlatAppearance.BorderSize = 0
        Me.btn_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_download.Image = CType(resources.GetObject("btn_download.Image"), System.Drawing.Image)
        Me.btn_download.Location = New System.Drawing.Point(1041, 87)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(39, 42)
        Me.btn_download.TabIndex = 65
        Me.btn_download.UseVisualStyleBackColor = False
        '
        'btn_upload
        '
        Me.btn_upload.AutoSize = True
        Me.btn_upload.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_upload.FlatAppearance.BorderSize = 0
        Me.btn_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload.Image = CType(resources.GetObject("btn_upload.Image"), System.Drawing.Image)
        Me.btn_upload.Location = New System.Drawing.Point(996, 87)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 64
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'txt_sopath
        '
        Me.txt_sopath.Location = New System.Drawing.Point(93, 102)
        Me.txt_sopath.Name = "txt_sopath"
        Me.txt_sopath.Size = New System.Drawing.Size(899, 21)
        Me.txt_sopath.TabIndex = 63
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(27, 102)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 12)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "附件上传:"
        '
        'rtb_remark
        '
        Me.rtb_remark.Location = New System.Drawing.Point(92, 25)
        Me.rtb_remark.Name = "rtb_remark"
        Me.rtb_remark.Size = New System.Drawing.Size(900, 55)
        Me.rtb_remark.TabIndex = 10
        Me.rtb_remark.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(27, 42)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 12)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "出货备注:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(693, 852)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(230, 852)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 7
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'frmShippingSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 874)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmShippingSet"
        Me.Text = "frmShippingSet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.DGV_lot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_ShipOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents combo_express As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ShippingExpressNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_BoxQTY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_shipmethod As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_senderphone As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_senderop As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_senderaddress As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_sender As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents rtb_remark As RichTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents txt_sopath As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents DGV_lot As DataGridView
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents txt_reciverphone As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_reciveraddress As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_reciverop As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_reciver As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_grossdie As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_gooddie As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_yield As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents combo_ilot As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txt_outerboxid As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_GW As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_NW As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_height As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_width As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_length As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_slot As TextBox
    Friend WithEvents Label28 As Label
End Class
