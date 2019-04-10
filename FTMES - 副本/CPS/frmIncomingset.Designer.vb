<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIncomingset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIncomingset))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_custcode = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.btn_ilot = New System.Windows.Forms.Button()
        Me.txt_custshortchar = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Rbt_N = New System.Windows.Forms.RadioButton()
        Me.Rbt_H = New System.Windows.Forms.RadioButton()
        Me.Rbt_S = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Rbt_bondNo = New System.Windows.Forms.RadioButton()
        Me.Rbt_bondYes = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rbt_CORR = New System.Windows.Forms.RadioButton()
        Me.Rbt_ENG = New System.Windows.Forms.RadioButton()
        Me.Rbt_MP = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_CustOrderSequence = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_CustOrder = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_ReceivingExpressNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_iTestOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.combo_iprod = New System.Windows.Forms.ComboBox()
        Me.txt_dieqty = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_wopath = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.rtb_mark = New System.Windows.Forms.RichTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_waferqty = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_sprod = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_fprod = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_cprod = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_slot = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_flot = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txt_custcode)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.btn_ilot)
        Me.GroupBox1.Controls.Add(Me.txt_custshortchar)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.combo_cust)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_CustOrderSequence)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_CustOrder)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_ReceivingExpressNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_iTestOrder)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1152, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "工单信息"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(391, 97)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(168, 21)
        Me.DateTimePicker2.TabIndex = 38
        '
        'txt_custcode
        '
        Me.txt_custcode.Enabled = False
        Me.txt_custcode.Location = New System.Drawing.Point(701, 20)
        Me.txt_custcode.Name = "txt_custcode"
        Me.txt_custcode.ReadOnly = True
        Me.txt_custcode.Size = New System.Drawing.Size(60, 21)
        Me.txt_custcode.TabIndex = 37
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(636, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(59, 12)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "客户代码:"
        '
        'btn_ilot
        '
        Me.btn_ilot.Image = Global.CPS.My.Resources.Resources.csph
        Me.btn_ilot.Location = New System.Drawing.Point(641, 213)
        Me.btn_ilot.Name = "btn_ilot"
        Me.btn_ilot.Size = New System.Drawing.Size(90, 32)
        Me.btn_ilot.TabIndex = 4
        Me.btn_ilot.UseVisualStyleBackColor = True
        '
        'txt_custshortchar
        '
        Me.txt_custshortchar.Enabled = False
        Me.txt_custshortchar.Location = New System.Drawing.Point(808, 20)
        Me.txt_custshortchar.Name = "txt_custshortchar"
        Me.txt_custshortchar.ReadOnly = True
        Me.txt_custshortchar.Size = New System.Drawing.Size(62, 21)
        Me.txt_custshortchar.TabIndex = 35
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(767, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 12)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "简码:"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(700, 95)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(170, 21)
        Me.DateTimePicker3.TabIndex = 33
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(90, 95)
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
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(453, 141)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 12)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "紧急程度:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Rbt_N)
        Me.GroupBox5.Controls.Add(Me.Rbt_H)
        Me.GroupBox5.Controls.Add(Me.Rbt_S)
        Me.GroupBox5.Location = New System.Drawing.Point(518, 127)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 34)
        Me.GroupBox5.TabIndex = 28
        Me.GroupBox5.TabStop = False
        '
        'Rbt_N
        '
        Me.Rbt_N.AutoSize = True
        Me.Rbt_N.BackColor = System.Drawing.Color.Lime
        Me.Rbt_N.Checked = True
        Me.Rbt_N.Location = New System.Drawing.Point(214, 12)
        Me.Rbt_N.Name = "Rbt_N"
        Me.Rbt_N.Size = New System.Drawing.Size(71, 16)
        Me.Rbt_N.TabIndex = 2
        Me.Rbt_N.TabStop = True
        Me.Rbt_N.Text = "一般件-N"
        Me.Rbt_N.UseVisualStyleBackColor = False
        '
        'Rbt_H
        '
        Me.Rbt_H.AutoSize = True
        Me.Rbt_H.BackColor = System.Drawing.Color.Yellow
        Me.Rbt_H.Location = New System.Drawing.Point(140, 12)
        Me.Rbt_H.Name = "Rbt_H"
        Me.Rbt_H.Size = New System.Drawing.Size(59, 16)
        Me.Rbt_H.TabIndex = 1
        Me.Rbt_H.Text = "急件-H"
        Me.Rbt_H.UseVisualStyleBackColor = False
        '
        'Rbt_S
        '
        Me.Rbt_S.AutoSize = True
        Me.Rbt_S.BackColor = System.Drawing.Color.Red
        Me.Rbt_S.Location = New System.Drawing.Point(50, 12)
        Me.Rbt_S.Name = "Rbt_S"
        Me.Rbt_S.Size = New System.Drawing.Size(71, 16)
        Me.Rbt_S.TabIndex = 0
        Me.Rbt_S.Text = "超急件-S"
        Me.Rbt_S.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(28, 177)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 12)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "保税信息:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rbt_bondNo)
        Me.GroupBox4.Controls.Add(Me.Rbt_bondYes)
        Me.GroupBox4.Location = New System.Drawing.Point(93, 162)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(313, 34)
        Me.GroupBox4.TabIndex = 26
        Me.GroupBox4.TabStop = False
        '
        'Rbt_bondNo
        '
        Me.Rbt_bondNo.AutoSize = True
        Me.Rbt_bondNo.BackColor = System.Drawing.Color.Cyan
        Me.Rbt_bondNo.Checked = True
        Me.Rbt_bondNo.Location = New System.Drawing.Point(120, 11)
        Me.Rbt_bondNo.Name = "Rbt_bondNo"
        Me.Rbt_bondNo.Size = New System.Drawing.Size(35, 16)
        Me.Rbt_bondNo.TabIndex = 1
        Me.Rbt_bondNo.TabStop = True
        Me.Rbt_bondNo.Text = "否"
        Me.Rbt_bondNo.UseVisualStyleBackColor = False
        '
        'Rbt_bondYes
        '
        Me.Rbt_bondYes.AutoSize = True
        Me.Rbt_bondYes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Rbt_bondYes.Location = New System.Drawing.Point(24, 11)
        Me.Rbt_bondYes.Name = "Rbt_bondYes"
        Me.Rbt_bondYes.Size = New System.Drawing.Size(35, 16)
        Me.Rbt_bondYes.TabIndex = 0
        Me.Rbt_bondYes.Text = "是"
        Me.Rbt_bondYes.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 141)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 12)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "产品类型:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rbt_CORR)
        Me.GroupBox3.Controls.Add(Me.Rbt_ENG)
        Me.GroupBox3.Controls.Add(Me.Rbt_MP)
        Me.GroupBox3.Location = New System.Drawing.Point(93, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(313, 34)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'Rbt_CORR
        '
        Me.Rbt_CORR.AutoSize = True
        Me.Rbt_CORR.BackColor = System.Drawing.Color.Yellow
        Me.Rbt_CORR.Location = New System.Drawing.Point(208, 12)
        Me.Rbt_CORR.Name = "Rbt_CORR"
        Me.Rbt_CORR.Size = New System.Drawing.Size(83, 16)
        Me.Rbt_CORR.TabIndex = 2
        Me.Rbt_CORR.Text = "CORR Wafer"
        Me.Rbt_CORR.UseVisualStyleBackColor = False
        '
        'Rbt_ENG
        '
        Me.Rbt_ENG.AutoSize = True
        Me.Rbt_ENG.BackColor = System.Drawing.Color.RoyalBlue
        Me.Rbt_ENG.Location = New System.Drawing.Point(114, 12)
        Me.Rbt_ENG.Name = "Rbt_ENG"
        Me.Rbt_ENG.Size = New System.Drawing.Size(83, 16)
        Me.Rbt_ENG.TabIndex = 1
        Me.Rbt_ENG.Text = "工程品-ENG"
        Me.Rbt_ENG.UseVisualStyleBackColor = False
        '
        'Rbt_MP
        '
        Me.Rbt_MP.AutoSize = True
        Me.Rbt_MP.BackColor = System.Drawing.Color.Lime
        Me.Rbt_MP.Checked = True
        Me.Rbt_MP.Location = New System.Drawing.Point(13, 13)
        Me.Rbt_MP.Name = "Rbt_MP"
        Me.Rbt_MP.Size = New System.Drawing.Size(89, 16)
        Me.Rbt_MP.TabIndex = 0
        Me.Rbt_MP.TabStop = True
        Me.Rbt_MP.Text = "量产品-PROD"
        Me.Rbt_MP.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(636, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "收货日期:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(326, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "需求日期:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "委工日期:"
        '
        'txt_CustOrderSequence
        '
        Me.txt_CustOrderSequence.Location = New System.Drawing.Point(701, 61)
        Me.txt_CustOrderSequence.Name = "txt_CustOrderSequence"
        Me.txt_CustOrderSequence.Size = New System.Drawing.Size(169, 21)
        Me.txt_CustOrderSequence.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(636, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "委工序号:"
        '
        'txt_CustOrder
        '
        Me.txt_CustOrder.Location = New System.Drawing.Point(391, 61)
        Me.txt_CustOrder.Name = "txt_CustOrder"
        Me.txt_CustOrder.Size = New System.Drawing.Size(169, 21)
        Me.txt_CustOrder.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(326, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "委工单号:"
        '
        'txt_ReceivingExpressNo
        '
        Me.txt_ReceivingExpressNo.Location = New System.Drawing.Point(93, 61)
        Me.txt_ReceivingExpressNo.Name = "txt_ReceivingExpressNo"
        Me.txt_ReceivingExpressNo.Size = New System.Drawing.Size(169, 21)
        Me.txt_ReceivingExpressNo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "物流单号:"
        '
        'txt_iTestOrder
        '
        Me.txt_iTestOrder.Enabled = False
        Me.txt_iTestOrder.Location = New System.Drawing.Point(93, 213)
        Me.txt_iTestOrder.Name = "txt_iTestOrder"
        Me.txt_iTestOrder.ReadOnly = True
        Me.txt_iTestOrder.Size = New System.Drawing.Size(169, 21)
        Me.txt_iTestOrder.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "安测单号:"
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
        Me.GroupBox2.Controls.Add(Me.btn_download)
        Me.GroupBox2.Controls.Add(Me.btn_upload)
        Me.GroupBox2.Controls.Add(Me.combo_iprod)
        Me.GroupBox2.Controls.Add(Me.txt_dieqty)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txt_wopath)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.rtb_mark)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txt_code)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txt_waferqty)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txt_sprod)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_fprod)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txt_cprod)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txt_slot)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txt_flot)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txt_clot)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_ilot)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 281)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1150, 335)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "产品信息"
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
        Me.btn_download.Location = New System.Drawing.Point(1040, 166)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(39, 42)
        Me.btn_download.TabIndex = 61
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
        Me.btn_upload.Location = New System.Drawing.Point(995, 166)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 60
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'combo_iprod
        '
        Me.combo_iprod.FormattingEnabled = True
        Me.combo_iprod.Location = New System.Drawing.Point(91, 76)
        Me.combo_iprod.Name = "combo_iprod"
        Me.combo_iprod.Size = New System.Drawing.Size(167, 20)
        Me.combo_iprod.TabIndex = 59
        '
        'txt_dieqty
        '
        Me.txt_dieqty.Location = New System.Drawing.Point(375, 111)
        Me.txt_dieqty.Name = "txt_dieqty"
        Me.txt_dieqty.Size = New System.Drawing.Size(169, 21)
        Me.txt_dieqty.TabIndex = 58
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(311, 114)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 12)
        Me.Label26.TabIndex = 57
        Me.Label26.Text = "DIE颗数:"
        '
        'txt_wopath
        '
        Me.txt_wopath.Location = New System.Drawing.Point(90, 178)
        Me.txt_wopath.Name = "txt_wopath"
        Me.txt_wopath.Size = New System.Drawing.Size(899, 21)
        Me.txt_wopath.TabIndex = 56
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 181)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 12)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "工单上传:"
        '
        'rtb_mark
        '
        Me.rtb_mark.Location = New System.Drawing.Point(91, 219)
        Me.rtb_mark.Name = "rtb_mark"
        Me.rtb_mark.Size = New System.Drawing.Size(968, 98)
        Me.rtb_mark.TabIndex = 54
        Me.rtb_mark.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(26, 253)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(59, 12)
        Me.Label24.TabIndex = 53
        Me.Label24.Text = "信息备注:"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(668, 111)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(169, 21)
        Me.txt_code.TabIndex = 52
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(601, 114)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 12)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "CODE :"
        '
        'txt_waferqty
        '
        Me.txt_waferqty.Location = New System.Drawing.Point(90, 117)
        Me.txt_waferqty.Name = "txt_waferqty"
        Me.txt_waferqty.Size = New System.Drawing.Size(169, 21)
        Me.txt_waferqty.TabIndex = 50
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(26, 120)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 12)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "晶圆片数:"
        '
        'txt_sprod
        '
        Me.txt_sprod.Location = New System.Drawing.Point(950, 76)
        Me.txt_sprod.Name = "txt_sprod"
        Me.txt_sprod.Size = New System.Drawing.Size(169, 21)
        Me.txt_sprod.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(886, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 12)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "出货型号:"
        '
        'txt_fprod
        '
        Me.txt_fprod.Location = New System.Drawing.Point(667, 76)
        Me.txt_fprod.Name = "txt_fprod"
        Me.txt_fprod.Size = New System.Drawing.Size(169, 21)
        Me.txt_fprod.TabIndex = 44
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(595, 79)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 12)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "晶圆厂型号:"
        '
        'txt_cprod
        '
        Me.txt_cprod.Location = New System.Drawing.Point(375, 76)
        Me.txt_cprod.Name = "txt_cprod"
        Me.txt_cprod.Size = New System.Drawing.Size(169, 21)
        Me.txt_cprod.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(311, 79)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 12)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "客户型号:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 12)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "生产型号:"
        '
        'txt_slot
        '
        Me.txt_slot.Location = New System.Drawing.Point(950, 34)
        Me.txt_slot.Name = "txt_slot"
        Me.txt_slot.Size = New System.Drawing.Size(169, 21)
        Me.txt_slot.TabIndex = 38
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(886, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 12)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "出货批号:"
        '
        'txt_flot
        '
        Me.txt_flot.Location = New System.Drawing.Point(667, 34)
        Me.txt_flot.Name = "txt_flot"
        Me.txt_flot.Size = New System.Drawing.Size(169, 21)
        Me.txt_flot.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(595, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 12)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "晶圆厂批号:"
        '
        'txt_clot
        '
        Me.txt_clot.Location = New System.Drawing.Point(375, 34)
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.Size = New System.Drawing.Size(169, 21)
        Me.txt_clot.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(311, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "客户批号:"
        '
        'txt_ilot
        '
        Me.txt_ilot.Enabled = False
        Me.txt_ilot.Location = New System.Drawing.Point(90, 34)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.ReadOnly = True
        Me.txt_ilot.Size = New System.Drawing.Size(169, 21)
        Me.txt_ilot.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 12)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "生产批号:"
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(197, 644)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(652, 644)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmIncomingset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 908)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmIncomingset"
        Me.Text = "收货资料录入"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_CustOrderSequence As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_CustOrder As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_ReceivingExpressNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_iTestOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Rbt_N As RadioButton
    Friend WithEvents Rbt_H As RadioButton
    Friend WithEvents Rbt_S As RadioButton
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Rbt_bondNo As RadioButton
    Friend WithEvents Rbt_bondYes As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Rbt_CORR As RadioButton
    Friend WithEvents Rbt_ENG As RadioButton
    Friend WithEvents Rbt_MP As RadioButton
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents txt_slot As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_flot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_clot As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_wopath As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents rtb_mark As RichTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_waferqty As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_sprod As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_fprod As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_cprod As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents txt_dieqty As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents combo_iprod As ComboBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txt_custshortchar As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents btn_ilot As Button
    Friend WithEvents txt_custcode As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents btn_upload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btn_download As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
