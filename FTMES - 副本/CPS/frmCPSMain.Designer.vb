<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCPSMain
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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CUSTOMER", 2, 2)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("客户维护", 30, 30, New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EMPLOYEE", 25, 25)
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PASSWORD", 89, 89)
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("用户信息", 5, 5, New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PRODUCT", 4, 4)
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RELEASE", 92, 92)
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("工程资料", 7, 7, New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7})
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("EQUIPMENT", 40, 40)
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ACCESSORY", 38, 38)
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("IO Record", 91, 91)
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(PM)", 11, 11)
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("设备管理", New System.Windows.Forms.TreeNode() {TreeNode9, TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("实时库位", 48, 48)
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("库位管理", 49, 49, New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("标签列印", 100, 100)
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("流程卡列印", 68, 68)
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("WaferOCR列印", 72, 72)
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("标签|流程卡", 94, 94, New System.Windows.Forms.TreeNode() {TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("收货", 52, 52)
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("派工", 51, 51)
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("完工", 70, 70)
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("出货", 47, 47)
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("物管作业", 55, 55, New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode23})
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("过站", 56, 56)
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("分批", 60, 60)
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(并批)", 59, 59)
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("产线作业", 69, 69, New System.Windows.Forms.TreeNode() {TreeNode25, TreeNode26, TreeNode27})
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("现场监控", 75, 75)
        Dim TreeNode30 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("HOLD", 85, 85)
        Dim TreeNode31 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(WAIT)", 84, 84)
        Dim TreeNode32 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(FutureHold)", 108, 108)
        Dim TreeNode33 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(FutureWait)", 107, 107)
        Dim TreeNode34 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(重工)", 106, 106)
        Dim TreeNode35 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("(跳站)")
        Dim TreeNode36 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("异常处置", 78, 78, New System.Windows.Forms.TreeNode() {TreeNode30, TreeNode31, TreeNode32, TreeNode33, TreeNode34, TreeNode35})
        Dim TreeNode37 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Cy")
        Dim TreeNode38 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("WIP报表", New System.Windows.Forms.TreeNode() {TreeNode37})
        Dim TreeNode39 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Magic工具箱", 112, 112, New System.Windows.Forms.TreeNode() {TreeNode38})
        Dim TreeNode40 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("XH1")
        Dim TreeNode41 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("XH", New System.Windows.Forms.TreeNode() {TreeNode40})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCPSMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView_CPS = New System.Windows.Forms.TreeView()
        Me.ImageList_CPS = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView_CPS)
        Me.SplitContainer1.Panel1.Controls.Add(Me.StatusStrip1)
        Me.SplitContainer1.Panel1MinSize = 0
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.CPS.My.Resources.Resources.cpmes01
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SplitContainer1.Panel2MinSize = 0
        Me.SplitContainer1.Size = New System.Drawing.Size(1081, 738)
        Me.SplitContainer1.SplitterDistance = 241
        Me.SplitContainer1.SplitterWidth = 2
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView_CPS
        '
        Me.TreeView_CPS.BackColor = System.Drawing.SystemColors.Control
        Me.TreeView_CPS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView_CPS.HotTracking = True
        Me.TreeView_CPS.ImageIndex = 0
        Me.TreeView_CPS.ImageList = Me.ImageList_CPS
        Me.TreeView_CPS.LineColor = System.Drawing.Color.Maroon
        Me.TreeView_CPS.Location = New System.Drawing.Point(0, 0)
        Me.TreeView_CPS.Name = "TreeView_CPS"
        TreeNode1.ForeColor = System.Drawing.Color.Black
        TreeNode1.ImageIndex = 2
        TreeNode1.Name = "node_customer"
        TreeNode1.SelectedImageIndex = 2
        TreeNode1.Text = "CUSTOMER"
        TreeNode2.ForeColor = System.Drawing.Color.Black
        TreeNode2.ImageIndex = 30
        TreeNode2.Name = "节点1"
        TreeNode2.SelectedImageIndex = 30
        TreeNode2.Text = "客户维护"
        TreeNode3.ImageIndex = 25
        TreeNode3.Name = "node_employee"
        TreeNode3.SelectedImageIndex = 25
        TreeNode3.Text = "EMPLOYEE"
        TreeNode4.ImageIndex = 89
        TreeNode4.Name = "node_changepwd"
        TreeNode4.SelectedImageIndex = 89
        TreeNode4.Text = "PASSWORD"
        TreeNode5.ImageIndex = 5
        TreeNode5.Name = "节点2"
        TreeNode5.SelectedImageIndex = 5
        TreeNode5.Text = "用户信息"
        TreeNode6.ImageIndex = 4
        TreeNode6.Name = "node_product"
        TreeNode6.SelectedImageIndex = 4
        TreeNode6.Text = "PRODUCT"
        TreeNode7.ImageIndex = 92
        TreeNode7.Name = "node_release"
        TreeNode7.SelectedImageIndex = 92
        TreeNode7.Text = "RELEASE"
        TreeNode8.ImageIndex = 7
        TreeNode8.Name = "节点1"
        TreeNode8.SelectedImageIndex = 7
        TreeNode8.Text = "工程资料"
        TreeNode9.ImageIndex = 40
        TreeNode9.Name = "node_equipment"
        TreeNode9.SelectedImageIndex = 40
        TreeNode9.Text = "EQUIPMENT"
        TreeNode10.ImageIndex = 38
        TreeNode10.Name = "node_accessory"
        TreeNode10.SelectedImageIndex = 38
        TreeNode10.Text = "ACCESSORY"
        TreeNode11.ImageIndex = 91
        TreeNode11.Name = "node_io"
        TreeNode11.SelectedImageIndex = 91
        TreeNode11.Text = "IO Record"
        TreeNode12.ImageIndex = 11
        TreeNode12.Name = "节点1"
        TreeNode12.SelectedImageIndex = 11
        TreeNode12.Text = "(PM)"
        TreeNode13.ImageKey = "eqq.png"
        TreeNode13.Name = "节点0"
        TreeNode13.SelectedImageIndex = 98
        TreeNode13.Text = "设备管理"
        TreeNode14.ImageIndex = 48
        TreeNode14.Name = "node_location"
        TreeNode14.SelectedImageIndex = 48
        TreeNode14.Text = "实时库位"
        TreeNode15.ImageIndex = 49
        TreeNode15.Name = "节点7"
        TreeNode15.SelectedImageIndex = 49
        TreeNode15.Text = "库位管理"
        TreeNode16.ImageIndex = 100
        TreeNode16.Name = "node_label_mc"
        TreeNode16.SelectedImageIndex = 100
        TreeNode16.Text = "标签列印"
        TreeNode16.ToolTipText = "进出货标签制作"
        TreeNode17.ImageIndex = 68
        TreeNode17.Name = "node_ts"
        TreeNode17.SelectedImageIndex = 68
        TreeNode17.Text = "流程卡列印"
        TreeNode18.ImageIndex = 72
        TreeNode18.Name = "node_waferocr"
        TreeNode18.SelectedImageIndex = 72
        TreeNode18.Text = "WaferOCR列印"
        TreeNode19.ImageIndex = 94
        TreeNode19.Name = "节点0"
        TreeNode19.SelectedImageIndex = 94
        TreeNode19.Text = "标签|流程卡"
        TreeNode20.ImageIndex = 52
        TreeNode20.Name = "node_receive"
        TreeNode20.SelectedImageIndex = 52
        TreeNode20.Text = "收货"
        TreeNode20.ToolTipText = "晶圆收货作业"
        TreeNode21.ImageIndex = 51
        TreeNode21.Name = "node_online"
        TreeNode21.SelectedImageIndex = 51
        TreeNode21.Text = "派工"
        TreeNode21.ToolTipText = "晶圆下线作业"
        TreeNode22.ImageIndex = 70
        TreeNode22.Name = "node_offline"
        TreeNode22.SelectedImageIndex = 70
        TreeNode22.Text = "完工"
        TreeNode22.ToolTipText = "晶圆完工返回库房"
        TreeNode23.ImageIndex = 47
        TreeNode23.Name = "node_ship"
        TreeNode23.SelectedImageIndex = 47
        TreeNode23.Text = "出货"
        TreeNode23.ToolTipText = "晶圆出货作业"
        TreeNode24.ImageIndex = 55
        TreeNode24.Name = "节点0"
        TreeNode24.SelectedImageIndex = 55
        TreeNode24.Text = "物管作业"
        TreeNode25.ImageIndex = 56
        TreeNode25.Name = "node_checkIO"
        TreeNode25.SelectedImageIndex = 56
        TreeNode25.Text = "过站"
        TreeNode25.ToolTipText = "进站Check In & 出站Check Out"
        TreeNode26.ImageIndex = 60
        TreeNode26.Name = "node_splitlot"
        TreeNode26.SelectedImageIndex = 60
        TreeNode26.Text = "分批"
        TreeNode27.ImageIndex = 59
        TreeNode27.Name = "节点0"
        TreeNode27.SelectedImageIndex = 59
        TreeNode27.Text = "(并批)"
        TreeNode28.ImageIndex = 69
        TreeNode28.Name = "节点3"
        TreeNode28.SelectedImageIndex = 69
        TreeNode28.Text = "产线作业"
        TreeNode29.ImageIndex = 75
        TreeNode29.Name = "node_prodmonitor"
        TreeNode29.SelectedImageIndex = 75
        TreeNode29.Text = "现场监控"
        TreeNode30.ImageIndex = 85
        TreeNode30.Name = "node_hold"
        TreeNode30.SelectedImageIndex = 85
        TreeNode30.Text = "HOLD"
        TreeNode31.ImageIndex = 84
        TreeNode31.Name = "节点1"
        TreeNode31.SelectedImageIndex = 84
        TreeNode31.Text = "(WAIT)"
        TreeNode32.ImageIndex = 108
        TreeNode32.Name = "节点5"
        TreeNode32.SelectedImageIndex = 108
        TreeNode32.Text = "(FutureHold)"
        TreeNode33.ImageIndex = 107
        TreeNode33.Name = "节点6"
        TreeNode33.SelectedImageIndex = 107
        TreeNode33.Text = "(FutureWait)"
        TreeNode34.ImageIndex = 106
        TreeNode34.Name = "节点1"
        TreeNode34.SelectedImageIndex = 106
        TreeNode34.Text = "(重工)"
        TreeNode35.ImageIndex = 105
        TreeNode35.Name = "节点2"
        TreeNode35.SelectedImageKey = "jump.png"
        TreeNode35.Text = "(跳站)"
        TreeNode36.ImageIndex = 78
        TreeNode36.Name = "节点0"
        TreeNode36.SelectedImageIndex = 78
        TreeNode36.Text = "异常处置"
        TreeNode37.Name = "节点0"
        TreeNode37.Text = "Cy"
        TreeNode38.Name = "node_wipquery"
        TreeNode38.Text = "WIP报表"
        TreeNode39.ImageIndex = 112
        TreeNode39.Name = "节点0"
        TreeNode39.SelectedImageIndex = 112
        TreeNode39.Text = "Magic工具箱"
        TreeNode40.Name = "节点2"
        TreeNode40.Text = "XH1"
        TreeNode41.Name = "节点1"
        TreeNode41.Text = "XH"
        Me.TreeView_CPS.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode5, TreeNode8, TreeNode13, TreeNode15, TreeNode19, TreeNode24, TreeNode28, TreeNode29, TreeNode36, TreeNode39, TreeNode41})
        Me.TreeView_CPS.SelectedImageIndex = 0
        Me.TreeView_CPS.ShowNodeToolTips = True
        Me.TreeView_CPS.Size = New System.Drawing.Size(239, 714)
        Me.TreeView_CPS.TabIndex = 0
        '
        'ImageList_CPS
        '
        Me.ImageList_CPS.ImageStream = CType(resources.GetObject("ImageList_CPS.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_CPS.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_CPS.Images.SetKeyName(0, "1.ico")
        Me.ImageList_CPS.Images.SetKeyName(1, "2.ico")
        Me.ImageList_CPS.Images.SetKeyName(2, "3.ico")
        Me.ImageList_CPS.Images.SetKeyName(3, "4.ico")
        Me.ImageList_CPS.Images.SetKeyName(4, "5.ico")
        Me.ImageList_CPS.Images.SetKeyName(5, "6.ico")
        Me.ImageList_CPS.Images.SetKeyName(6, "7.ico")
        Me.ImageList_CPS.Images.SetKeyName(7, "8.ico")
        Me.ImageList_CPS.Images.SetKeyName(8, "9.ico")
        Me.ImageList_CPS.Images.SetKeyName(9, "10.ico")
        Me.ImageList_CPS.Images.SetKeyName(10, "11.ico")
        Me.ImageList_CPS.Images.SetKeyName(11, "12.ico")
        Me.ImageList_CPS.Images.SetKeyName(12, "13.ico")
        Me.ImageList_CPS.Images.SetKeyName(13, "14.ico")
        Me.ImageList_CPS.Images.SetKeyName(14, "15.ico")
        Me.ImageList_CPS.Images.SetKeyName(15, "16.ico")
        Me.ImageList_CPS.Images.SetKeyName(16, "17.ico")
        Me.ImageList_CPS.Images.SetKeyName(17, "18.ico")
        Me.ImageList_CPS.Images.SetKeyName(18, "19.ico")
        Me.ImageList_CPS.Images.SetKeyName(19, "20.ico")
        Me.ImageList_CPS.Images.SetKeyName(20, "21.ico")
        Me.ImageList_CPS.Images.SetKeyName(21, "22.ico")
        Me.ImageList_CPS.Images.SetKeyName(22, "23.ico")
        Me.ImageList_CPS.Images.SetKeyName(23, "24.ico")
        Me.ImageList_CPS.Images.SetKeyName(24, "25.ico")
        Me.ImageList_CPS.Images.SetKeyName(25, "26.ico")
        Me.ImageList_CPS.Images.SetKeyName(26, "27.ico")
        Me.ImageList_CPS.Images.SetKeyName(27, "28.ico")
        Me.ImageList_CPS.Images.SetKeyName(28, "29.ico")
        Me.ImageList_CPS.Images.SetKeyName(29, "30.ico")
        Me.ImageList_CPS.Images.SetKeyName(30, "31.ico")
        Me.ImageList_CPS.Images.SetKeyName(31, "32.ico")
        Me.ImageList_CPS.Images.SetKeyName(32, "33.ico")
        Me.ImageList_CPS.Images.SetKeyName(33, "34.ico")
        Me.ImageList_CPS.Images.SetKeyName(34, "35.ico")
        Me.ImageList_CPS.Images.SetKeyName(35, "36.ico")
        Me.ImageList_CPS.Images.SetKeyName(36, "37.ico")
        Me.ImageList_CPS.Images.SetKeyName(37, "38.ico")
        Me.ImageList_CPS.Images.SetKeyName(38, "39.ico")
        Me.ImageList_CPS.Images.SetKeyName(39, "40.ico")
        Me.ImageList_CPS.Images.SetKeyName(40, "41.ico")
        Me.ImageList_CPS.Images.SetKeyName(41, "42.ico")
        Me.ImageList_CPS.Images.SetKeyName(42, "43.ico")
        Me.ImageList_CPS.Images.SetKeyName(43, "44.ico")
        Me.ImageList_CPS.Images.SetKeyName(44, "45.ico")
        Me.ImageList_CPS.Images.SetKeyName(45, "46.ico")
        Me.ImageList_CPS.Images.SetKeyName(46, "47.ico")
        Me.ImageList_CPS.Images.SetKeyName(47, "101.ico")
        Me.ImageList_CPS.Images.SetKeyName(48, "102.ico")
        Me.ImageList_CPS.Images.SetKeyName(49, "103.ico")
        Me.ImageList_CPS.Images.SetKeyName(50, "104.ico")
        Me.ImageList_CPS.Images.SetKeyName(51, "105.ico")
        Me.ImageList_CPS.Images.SetKeyName(52, "106.ico")
        Me.ImageList_CPS.Images.SetKeyName(53, "107.ico")
        Me.ImageList_CPS.Images.SetKeyName(54, "108.ico")
        Me.ImageList_CPS.Images.SetKeyName(55, "112.ico")
        Me.ImageList_CPS.Images.SetKeyName(56, "113.ico")
        Me.ImageList_CPS.Images.SetKeyName(57, "114.ico")
        Me.ImageList_CPS.Images.SetKeyName(58, "115.ico")
        Me.ImageList_CPS.Images.SetKeyName(59, "merge.png")
        Me.ImageList_CPS.Images.SetKeyName(60, "split.png")
        Me.ImageList_CPS.Images.SetKeyName(61, "ts.png")
        Me.ImageList_CPS.Images.SetKeyName(62, "prod.png")
        Me.ImageList_CPS.Images.SetKeyName(63, "ts2.png")
        Me.ImageList_CPS.Images.SetKeyName(64, "ocr.png")
        Me.ImageList_CPS.Images.SetKeyName(65, "label.png")
        Me.ImageList_CPS.Images.SetKeyName(66, "ts.png")
        Me.ImageList_CPS.Images.SetKeyName(67, "waferoc.png")
        Me.ImageList_CPS.Images.SetKeyName(68, "ts3.png")
        Me.ImageList_CPS.Images.SetKeyName(69, "prodline.png")
        Me.ImageList_CPS.Images.SetKeyName(70, "pack.png")
        Me.ImageList_CPS.Images.SetKeyName(71, "waf.png")
        Me.ImageList_CPS.Images.SetKeyName(72, "ocr.png")
        Me.ImageList_CPS.Images.SetKeyName(73, "yellow.jpg")
        Me.ImageList_CPS.Images.SetKeyName(74, "eye4.png")
        Me.ImageList_CPS.Images.SetKeyName(75, "eye3.png")
        Me.ImageList_CPS.Images.SetKeyName(76, "eye2.png")
        Me.ImageList_CPS.Images.SetKeyName(77, "eye.png")
        Me.ImageList_CPS.Images.SetKeyName(78, "erflight2.png")
        Me.ImageList_CPS.Images.SetKeyName(79, "erflight.png")
        Me.ImageList_CPS.Images.SetKeyName(80, "greenlight.png")
        Me.ImageList_CPS.Images.SetKeyName(81, "redlight.png")
        Me.ImageList_CPS.Images.SetKeyName(82, "release.png")
        Me.ImageList_CPS.Images.SetKeyName(83, "etf12.png")
        Me.ImageList_CPS.Images.SetKeyName(84, "wait.png")
        Me.ImageList_CPS.Images.SetKeyName(85, "hold.png")
        Me.ImageList_CPS.Images.SetKeyName(86, "ERF3.png")
        Me.ImageList_CPS.Images.SetKeyName(87, "ERF2.png")
        Me.ImageList_CPS.Images.SetKeyName(88, "ERF.png")
        Me.ImageList_CPS.Images.SetKeyName(89, "yaosit.png")
        Me.ImageList_CPS.Images.SetKeyName(90, "key2.png")
        Me.ImageList_CPS.Images.SetKeyName(91, "io1.png")
        Me.ImageList_CPS.Images.SetKeyName(92, "rel2.png")
        Me.ImageList_CPS.Images.SetKeyName(93, "rel.png")
        Me.ImageList_CPS.Images.SetKeyName(94, "iocrd.png")
        Me.ImageList_CPS.Images.SetKeyName(95, "iorrd.png")
        Me.ImageList_CPS.Images.SetKeyName(96, "eq.png")
        Me.ImageList_CPS.Images.SetKeyName(97, "eqt.png")
        Me.ImageList_CPS.Images.SetKeyName(98, "eqq.png")
        Me.ImageList_CPS.Images.SetKeyName(99, "eq.png")
        Me.ImageList_CPS.Images.SetKeyName(100, "bart.png")
        Me.ImageList_CPS.Images.SetKeyName(101, "pause2.png")
        Me.ImageList_CPS.Images.SetKeyName(102, "pause.png")
        Me.ImageList_CPS.Images.SetKeyName(103, "wait2.png")
        Me.ImageList_CPS.Images.SetKeyName(104, "wait.ico")
        Me.ImageList_CPS.Images.SetKeyName(105, "jump.png")
        Me.ImageList_CPS.Images.SetKeyName(106, "rework.png")
        Me.ImageList_CPS.Images.SetKeyName(107, "pau4.png")
        Me.ImageList_CPS.Images.SetKeyName(108, "pau3.png")
        Me.ImageList_CPS.Images.SetKeyName(109, "box.png")
        Me.ImageList_CPS.Images.SetKeyName(110, "box3.png")
        Me.ImageList_CPS.Images.SetKeyName(111, "lab.png")
        Me.ImageList_CPS.Images.SetKeyName(112, "box1.png")
        Me.ImageList_CPS.Images.SetKeyName(113, "eye5.png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 714)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(239, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(74, 17)
        Me.ToolStripStatusLabel1.Text = "Vanni Jiang"
        '
        'frmCPSMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 738)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmCPSMain"
        Me.Text = "frmCPS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TreeView_CPS As TreeView
    Friend WithEvents ImageList_CPS As ImageList
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
End Class
