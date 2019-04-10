<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoldSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHoldSet))
        Me.txt_head = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_currqty = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_cprod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_iprod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_currstep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ERFNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cal = New System.Windows.Forms.Button()
        Me.combo_ERFtype = New System.Windows.Forms.ComboBox()
        Me.DTP_holdtime = New System.Windows.Forms.DateTimePicker()
        Me.NUD_holdqty = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_all = New System.Windows.Forms.Button()
        Me.DGV_waferselect = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RTB_holdreason = New System.Windows.Forms.RichTextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_operator = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTP_informtime = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.rb_informcustomer = New System.Windows.Forms.RadioButton()
        Me.rtb_itestdispose = New System.Windows.Forms.RichTextBox()
        Me.RB_itestrelease = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_owner = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txt_custowner = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rtb_custdispose = New System.Windows.Forms.RichTextBox()
        Me.rb_custother = New System.Windows.Forms.RadioButton()
        Me.rb_custhold = New System.Windows.Forms.RadioButton()
        Me.rb_custrelease = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_closer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cb_close = New System.Windows.Forms.CheckBox()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.txt_attach = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txt_ownergrp = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_holdqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_head
        '
        Me.txt_head.BackColor = System.Drawing.SystemColors.Control
        Me.txt_head.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_head.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_head.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_head.ForeColor = System.Drawing.Color.Red
        Me.txt_head.Location = New System.Drawing.Point(0, 0)
        Me.txt_head.Multiline = True
        Me.txt_head.Name = "txt_head"
        Me.txt_head.ReadOnly = True
        Me.txt_head.Size = New System.Drawing.Size(1065, 67)
        Me.txt_head.TabIndex = 1
        Me.txt_head.TabStop = False
        Me.txt_head.Text = "异常记录单" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exception Record Form"
        Me.txt_head.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_currqty)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_cprod)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_iprod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_currstep)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_clot)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_ilot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ERFNo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1065, 122)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. 基本信息"
        '
        'txt_currqty
        '
        Me.txt_currqty.Location = New System.Drawing.Point(871, 76)
        Me.txt_currqty.Name = "txt_currqty"
        Me.txt_currqty.ReadOnly = True
        Me.txt_currqty.Size = New System.Drawing.Size(169, 21)
        Me.txt_currqty.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(806, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "当前片数:"
        '
        'txt_cprod
        '
        Me.txt_cprod.Location = New System.Drawing.Point(613, 76)
        Me.txt_cprod.Name = "txt_cprod"
        Me.txt_cprod.ReadOnly = True
        Me.txt_cprod.Size = New System.Drawing.Size(169, 21)
        Me.txt_cprod.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(548, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "客户型号:"
        '
        'txt_iprod
        '
        Me.txt_iprod.Location = New System.Drawing.Point(353, 76)
        Me.txt_iprod.Name = "txt_iprod"
        Me.txt_iprod.ReadOnly = True
        Me.txt_iprod.Size = New System.Drawing.Size(169, 21)
        Me.txt_iprod.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(288, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "生产型号:"
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(88, 76)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(169, 21)
        Me.txt_cust.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "客户名称:"
        '
        'txt_currstep
        '
        Me.txt_currstep.Location = New System.Drawing.Point(871, 32)
        Me.txt_currstep.Name = "txt_currstep"
        Me.txt_currstep.ReadOnly = True
        Me.txt_currstep.Size = New System.Drawing.Size(169, 21)
        Me.txt_currstep.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(806, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "当前站别:"
        '
        'txt_clot
        '
        Me.txt_clot.Location = New System.Drawing.Point(613, 32)
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.ReadOnly = True
        Me.txt_clot.Size = New System.Drawing.Size(169, 21)
        Me.txt_clot.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(548, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "客户批号:"
        '
        'txt_ilot
        '
        Me.txt_ilot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ilot.ForeColor = System.Drawing.Color.Blue
        Me.txt_ilot.Location = New System.Drawing.Point(353, 32)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.Size = New System.Drawing.Size(169, 21)
        Me.txt_ilot.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(288, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "生产批号:"
        '
        'txt_ERFNo
        '
        Me.txt_ERFNo.Location = New System.Drawing.Point(88, 32)
        Me.txt_ERFNo.Name = "txt_ERFNo"
        Me.txt_ERFNo.ReadOnly = True
        Me.txt_ERFNo.Size = New System.Drawing.Size(169, 21)
        Me.txt_ERFNo.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "异常单号:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cal)
        Me.GroupBox2.Controls.Add(Me.combo_ERFtype)
        Me.GroupBox2.Controls.Add(Me.DTP_holdtime)
        Me.GroupBox2.Controls.Add(Me.NUD_holdqty)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_all)
        Me.GroupBox2.Controls.Add(Me.DGV_waferselect)
        Me.GroupBox2.Controls.Add(Me.RTB_holdreason)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txt_operator)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 230)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2.异常信息"
        '
        'btn_cal
        '
        Me.btn_cal.AutoSize = True
        Me.btn_cal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cal.BackgroundImage = Global.CPS.My.Resources.Resources.release1
        Me.btn_cal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cal.FlatAppearance.BorderSize = 0
        Me.btn_cal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cal.Location = New System.Drawing.Point(939, 79)
        Me.btn_cal.Name = "btn_cal"
        Me.btn_cal.Size = New System.Drawing.Size(38, 35)
        Me.btn_cal.TabIndex = 65
        Me.btn_cal.UseVisualStyleBackColor = False
        '
        'combo_ERFtype
        '
        Me.combo_ERFtype.ForeColor = System.Drawing.Color.Blue
        Me.combo_ERFtype.FormattingEnabled = True
        Me.combo_ERFtype.Location = New System.Drawing.Point(613, 30)
        Me.combo_ERFtype.Name = "combo_ERFtype"
        Me.combo_ERFtype.Size = New System.Drawing.Size(169, 20)
        Me.combo_ERFtype.TabIndex = 40
        '
        'DTP_holdtime
        '
        Me.DTP_holdtime.Location = New System.Drawing.Point(353, 30)
        Me.DTP_holdtime.Name = "DTP_holdtime"
        Me.DTP_holdtime.Size = New System.Drawing.Size(169, 21)
        Me.DTP_holdtime.TabIndex = 39
        '
        'NUD_holdqty
        '
        Me.NUD_holdqty.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUD_holdqty.ForeColor = System.Drawing.Color.Blue
        Me.NUD_holdqty.Location = New System.Drawing.Point(871, 30)
        Me.NUD_holdqty.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.NUD_holdqty.Name = "NUD_holdqty"
        Me.NUD_holdqty.Size = New System.Drawing.Size(169, 21)
        Me.NUD_holdqty.TabIndex = 38
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "异常片号:"
        '
        'btn_clear
        '
        Me.btn_clear.AutoSize = True
        Me.btn_clear.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_clear.BackgroundImage = CType(resources.GetObject("btn_clear.BackgroundImage"), System.Drawing.Image)
        Me.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_clear.FlatAppearance.BorderSize = 0
        Me.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clear.ForeColor = System.Drawing.Color.Red
        Me.btn_clear.Location = New System.Drawing.Point(871, 96)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(42, 29)
        Me.btn_clear.TabIndex = 36
        Me.btn_clear.Text = "CLS"
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_all
        '
        Me.btn_all.AutoSize = True
        Me.btn_all.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_all.BackgroundImage = CType(resources.GetObject("btn_all.BackgroundImage"), System.Drawing.Image)
        Me.btn_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_all.FlatAppearance.BorderSize = 0
        Me.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_all.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all.ForeColor = System.Drawing.Color.Blue
        Me.btn_all.Location = New System.Drawing.Point(871, 67)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(42, 29)
        Me.btn_all.TabIndex = 35
        Me.btn_all.Text = "All"
        Me.btn_all.UseVisualStyleBackColor = False
        '
        'DGV_waferselect
        '
        Me.DGV_waferselect.AllowUserToAddRows = False
        Me.DGV_waferselect.AllowUserToDeleteRows = False
        Me.DGV_waferselect.AllowUserToResizeColumns = False
        Me.DGV_waferselect.AllowUserToResizeRows = False
        Me.DGV_waferselect.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_waferselect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_waferselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_waferselect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.DataGridViewCheckBoxColumn14, Me.DataGridViewCheckBoxColumn15, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewCheckBoxColumn19, Me.DataGridViewCheckBoxColumn20, Me.DataGridViewCheckBoxColumn21, Me.DataGridViewCheckBoxColumn22, Me.DataGridViewCheckBoxColumn23, Me.DataGridViewCheckBoxColumn24, Me.DataGridViewCheckBoxColumn25, Me.DataGridViewTextBoxColumn1})
        Me.DGV_waferselect.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_waferselect.Location = New System.Drawing.Point(93, 69)
        Me.DGV_waferselect.Name = "DGV_waferselect"
        Me.DGV_waferselect.RowHeadersWidth = 10
        Me.DGV_waferselect.RowTemplate.Height = 23
        Me.DGV_waferselect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_waferselect.Size = New System.Drawing.Size(772, 56)
        Me.DGV_waferselect.TabIndex = 34
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "1"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 30
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "2"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 30
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = "3"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 30
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.HeaderText = "4"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 30
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.HeaderText = "5"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 30
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.HeaderText = "6"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 30
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.HeaderText = "7"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.Width = 30
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.HeaderText = "8"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 30
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.HeaderText = "9"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.Width = 30
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.HeaderText = "10"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        Me.DataGridViewCheckBoxColumn10.Width = 30
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.HeaderText = "11"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.Width = 30
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.HeaderText = "12"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        Me.DataGridViewCheckBoxColumn12.Width = 30
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.HeaderText = "13"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        Me.DataGridViewCheckBoxColumn13.Width = 30
        '
        'DataGridViewCheckBoxColumn14
        '
        Me.DataGridViewCheckBoxColumn14.HeaderText = "14"
        Me.DataGridViewCheckBoxColumn14.Name = "DataGridViewCheckBoxColumn14"
        Me.DataGridViewCheckBoxColumn14.Width = 30
        '
        'DataGridViewCheckBoxColumn15
        '
        Me.DataGridViewCheckBoxColumn15.HeaderText = "15"
        Me.DataGridViewCheckBoxColumn15.Name = "DataGridViewCheckBoxColumn15"
        Me.DataGridViewCheckBoxColumn15.Width = 30
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.HeaderText = "16"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        Me.DataGridViewCheckBoxColumn16.Width = 30
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.HeaderText = "17"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        Me.DataGridViewCheckBoxColumn17.Width = 30
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.HeaderText = "18"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        Me.DataGridViewCheckBoxColumn18.Width = 30
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.HeaderText = "19"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        Me.DataGridViewCheckBoxColumn19.Width = 30
        '
        'DataGridViewCheckBoxColumn20
        '
        Me.DataGridViewCheckBoxColumn20.HeaderText = "20"
        Me.DataGridViewCheckBoxColumn20.Name = "DataGridViewCheckBoxColumn20"
        Me.DataGridViewCheckBoxColumn20.Width = 30
        '
        'DataGridViewCheckBoxColumn21
        '
        Me.DataGridViewCheckBoxColumn21.HeaderText = "21"
        Me.DataGridViewCheckBoxColumn21.Name = "DataGridViewCheckBoxColumn21"
        Me.DataGridViewCheckBoxColumn21.Width = 30
        '
        'DataGridViewCheckBoxColumn22
        '
        Me.DataGridViewCheckBoxColumn22.HeaderText = "22"
        Me.DataGridViewCheckBoxColumn22.Name = "DataGridViewCheckBoxColumn22"
        Me.DataGridViewCheckBoxColumn22.Width = 30
        '
        'DataGridViewCheckBoxColumn23
        '
        Me.DataGridViewCheckBoxColumn23.HeaderText = "23"
        Me.DataGridViewCheckBoxColumn23.Name = "DataGridViewCheckBoxColumn23"
        Me.DataGridViewCheckBoxColumn23.Width = 30
        '
        'DataGridViewCheckBoxColumn24
        '
        Me.DataGridViewCheckBoxColumn24.HeaderText = "24"
        Me.DataGridViewCheckBoxColumn24.Name = "DataGridViewCheckBoxColumn24"
        Me.DataGridViewCheckBoxColumn24.Width = 30
        '
        'DataGridViewCheckBoxColumn25
        '
        Me.DataGridViewCheckBoxColumn25.HeaderText = "25"
        Me.DataGridViewCheckBoxColumn25.Name = "DataGridViewCheckBoxColumn25"
        Me.DataGridViewCheckBoxColumn25.Width = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 10
        '
        'RTB_holdreason
        '
        Me.RTB_holdreason.ForeColor = System.Drawing.Color.Blue
        Me.RTB_holdreason.Location = New System.Drawing.Point(88, 139)
        Me.RTB_holdreason.Name = "RTB_holdreason"
        Me.RTB_holdreason.Size = New System.Drawing.Size(952, 71)
        Me.RTB_holdreason.TabIndex = 33
        Me.RTB_holdreason.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(23, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 12)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "异常原因:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(806, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(59, 12)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "异常片数:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(548, 33)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 12)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "异常类型:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(288, 33)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 12)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "开单时间:"
        '
        'txt_operator
        '
        Me.txt_operator.ForeColor = System.Drawing.Color.Blue
        Me.txt_operator.Location = New System.Drawing.Point(88, 30)
        Me.txt_operator.Name = "txt_operator"
        Me.txt_operator.Size = New System.Drawing.Size(169, 21)
        Me.txt_operator.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 12)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "开单人员:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_ownergrp)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DTP_informtime)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.rb_informcustomer)
        Me.GroupBox3.Controls.Add(Me.rtb_itestdispose)
        Me.GroupBox3.Controls.Add(Me.RB_itestrelease)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_owner)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 419)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1065, 174)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "3.厂内处理"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 139)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 12)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "处置意见:"
        '
        'DTP_informtime
        '
        Me.DTP_informtime.Location = New System.Drawing.Point(353, 60)
        Me.DTP_informtime.Name = "DTP_informtime"
        Me.DTP_informtime.Size = New System.Drawing.Size(169, 21)
        Me.DTP_informtime.TabIndex = 40
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(288, 66)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 12)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "通知时间:"
        '
        'rb_informcustomer
        '
        Me.rb_informcustomer.AutoSize = True
        Me.rb_informcustomer.Location = New System.Drawing.Point(186, 64)
        Me.rb_informcustomer.Name = "rb_informcustomer"
        Me.rb_informcustomer.Size = New System.Drawing.Size(101, 16)
        Me.rb_informcustomer.TabIndex = 35
        Me.rb_informcustomer.Text = "通知客户  -> "
        Me.rb_informcustomer.UseVisualStyleBackColor = True
        '
        'rtb_itestdispose
        '
        Me.rtb_itestdispose.ForeColor = System.Drawing.Color.Blue
        Me.rtb_itestdispose.Location = New System.Drawing.Point(88, 99)
        Me.rtb_itestdispose.Name = "rtb_itestdispose"
        Me.rtb_itestdispose.Size = New System.Drawing.Size(952, 67)
        Me.rtb_itestdispose.TabIndex = 34
        Me.rtb_itestdispose.Text = ""
        '
        'RB_itestrelease
        '
        Me.RB_itestrelease.AutoSize = True
        Me.RB_itestrelease.Checked = True
        Me.RB_itestrelease.Location = New System.Drawing.Point(93, 64)
        Me.RB_itestrelease.Name = "RB_itestrelease"
        Me.RB_itestrelease.Size = New System.Drawing.Size(71, 16)
        Me.RB_itestrelease.TabIndex = 30
        Me.RB_itestrelease.TabStop = True
        Me.RB_itestrelease.Text = "内部解除"
        Me.RB_itestrelease.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(288, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 12)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "处置群组:"
        '
        'txt_owner
        '
        Me.txt_owner.ForeColor = System.Drawing.Color.Blue
        Me.txt_owner.Location = New System.Drawing.Point(88, 20)
        Me.txt_owner.Name = "txt_owner"
        Me.txt_owner.Size = New System.Drawing.Size(169, 21)
        Me.txt_owner.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(23, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 12)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "处置人员:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_custowner)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.rtb_custdispose)
        Me.GroupBox4.Controls.Add(Me.rb_custother)
        Me.GroupBox4.Controls.Add(Me.rb_custhold)
        Me.GroupBox4.Controls.Add(Me.rb_custrelease)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Location = New System.Drawing.Point(0, 593)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1065, 144)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "4.客户处理"
        '
        'txt_custowner
        '
        Me.txt_custowner.ForeColor = System.Drawing.Color.Blue
        Me.txt_custowner.Location = New System.Drawing.Point(88, 26)
        Me.txt_custowner.Name = "txt_custowner"
        Me.txt_custowner.Size = New System.Drawing.Size(169, 21)
        Me.txt_custowner.TabIndex = 44
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(23, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 12)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "处置人员:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 12)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "处置意见:"
        '
        'rtb_custdispose
        '
        Me.rtb_custdispose.ForeColor = System.Drawing.Color.Blue
        Me.rtb_custdispose.Location = New System.Drawing.Point(88, 63)
        Me.rtb_custdispose.Name = "rtb_custdispose"
        Me.rtb_custdispose.Size = New System.Drawing.Size(952, 65)
        Me.rtb_custdispose.TabIndex = 39
        Me.rtb_custdispose.Text = ""
        '
        'rb_custother
        '
        Me.rb_custother.AutoSize = True
        Me.rb_custother.Location = New System.Drawing.Point(539, 27)
        Me.rb_custother.Name = "rb_custother"
        Me.rb_custother.Size = New System.Drawing.Size(83, 16)
        Me.rb_custother.TabIndex = 38
        Me.rb_custother.Text = "Other 其他"
        Me.rb_custother.UseVisualStyleBackColor = True
        '
        'rb_custhold
        '
        Me.rb_custhold.AutoSize = True
        Me.rb_custhold.Location = New System.Drawing.Point(426, 27)
        Me.rb_custhold.Name = "rb_custhold"
        Me.rb_custhold.Size = New System.Drawing.Size(77, 16)
        Me.rb_custhold.TabIndex = 37
        Me.rb_custhold.Text = "继续 Hold"
        Me.rb_custhold.UseVisualStyleBackColor = True
        '
        'rb_custrelease
        '
        Me.rb_custrelease.AutoSize = True
        Me.rb_custrelease.Location = New System.Drawing.Point(305, 27)
        Me.rb_custrelease.Name = "rb_custrelease"
        Me.rb_custrelease.Size = New System.Drawing.Size(95, 16)
        Me.rb_custrelease.TabIndex = 36
        Me.rb_custrelease.Text = "Release 放行"
        Me.rb_custrelease.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_closer)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.cb_close)
        Me.GroupBox5.Controls.Add(Me.btn_download)
        Me.GroupBox5.Controls.Add(Me.btn_upload)
        Me.GroupBox5.Controls.Add(Me.txt_attach)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 737)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1065, 102)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        '
        'txt_closer
        '
        Me.txt_closer.ForeColor = System.Drawing.Color.Blue
        Me.txt_closer.Location = New System.Drawing.Point(226, 59)
        Me.txt_closer.Name = "txt_closer"
        Me.txt_closer.Size = New System.Drawing.Size(169, 21)
        Me.txt_closer.TabIndex = 68
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "结单人员:"
        '
        'cb_close
        '
        Me.cb_close.AutoSize = True
        Me.cb_close.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cb_close.ForeColor = System.Drawing.Color.Red
        Me.cb_close.Location = New System.Drawing.Point(88, 61)
        Me.cb_close.Name = "cb_close"
        Me.cb_close.Size = New System.Drawing.Size(64, 16)
        Me.cb_close.TabIndex = 66
        Me.cb_close.Text = "结单 ,"
        Me.cb_close.UseVisualStyleBackColor = True
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
        Me.btn_download.Location = New System.Drawing.Point(999, 10)
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
        Me.btn_upload.Location = New System.Drawing.Point(954, 10)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 64
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'txt_attach
        '
        Me.txt_attach.ForeColor = System.Drawing.Color.Blue
        Me.txt_attach.Location = New System.Drawing.Point(88, 22)
        Me.txt_attach.Name = "txt_attach"
        Me.txt_attach.Size = New System.Drawing.Size(860, 21)
        Me.txt_attach.TabIndex = 63
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 25)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 12)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "附件上传:"
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(593, 851)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(276, 851)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 7
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_ownergrp
        '
        Me.txt_ownergrp.FormattingEnabled = True
        Me.txt_ownergrp.Location = New System.Drawing.Point(353, 21)
        Me.txt_ownergrp.Name = "txt_ownergrp"
        Me.txt_ownergrp.Size = New System.Drawing.Size(169, 20)
        Me.txt_ownergrp.TabIndex = 42
        '
        'frmHoldSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 908)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_head)
        Me.Name = "frmHoldSet"
        Me.Text = "frmHoldSet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_holdqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_head As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents txt_currqty As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_cprod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_iprod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_currstep As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_clot As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ERFNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents RTB_holdreason As RichTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_operator As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents rb_informcustomer As RadioButton
    Friend WithEvents rtb_itestdispose As RichTextBox
    Friend WithEvents RB_itestrelease As RadioButton
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_owner As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents rtb_custdispose As RichTextBox
    Friend WithEvents rb_custother As RadioButton
    Friend WithEvents rb_custhold As RadioButton
    Friend WithEvents rb_custrelease As RadioButton
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents txt_attach As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents combo_ERFtype As ComboBox
    Friend WithEvents DTP_holdtime As DateTimePicker
    Friend WithEvents NUD_holdqty As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_all As Button
    Friend WithEvents DGV_waferselect As DataGridView
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn20 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn21 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn22 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn23 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn24 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn25 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents DTP_informtime As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_closer As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cb_close As CheckBox
    Friend WithEvents btn_cal As Button
    Friend WithEvents txt_custowner As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txt_ownergrp As ComboBox
End Class
