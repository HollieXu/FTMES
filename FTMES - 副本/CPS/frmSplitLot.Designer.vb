<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplitLot
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_currstatus = New System.Windows.Forms.TextBox()
        Me.txt_currstep = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_currqty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_wqty = New System.Windows.Forms.TextBox()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.txt_prod = New System.Windows.Forms.TextBox()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.NUD_lots = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DGV_WaferList = New System.Windows.Forms.DataGridView()
        Me.ilot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.waferqty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.w1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.w25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_verify = New System.Windows.Forms.Button()
        Me.btn_splitlot = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_lots, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_WaferList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_currstatus)
        Me.GroupBox1.Controls.Add(Me.txt_currstep)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_currqty)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_wqty)
        Me.GroupBox1.Controls.Add(Me.txt_clot)
        Me.GroupBox1.Controls.Add(Me.txt_ilot)
        Me.GroupBox1.Controls.Add(Me.txt_prod)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1138, 119)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "产品信息"
        '
        'txt_currstatus
        '
        Me.txt_currstatus.Enabled = False
        Me.txt_currstatus.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currstatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currstatus.Location = New System.Drawing.Point(355, 60)
        Me.txt_currstatus.Name = "txt_currstatus"
        Me.txt_currstatus.ReadOnly = True
        Me.txt_currstatus.Size = New System.Drawing.Size(177, 22)
        Me.txt_currstatus.TabIndex = 27
        '
        'txt_currstep
        '
        Me.txt_currstep.Enabled = False
        Me.txt_currstep.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currstep.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currstep.Location = New System.Drawing.Point(87, 60)
        Me.txt_currstep.Name = "txt_currstep"
        Me.txt_currstep.ReadOnly = True
        Me.txt_currstep.Size = New System.Drawing.Size(177, 22)
        Me.txt_currstep.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(284, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "当前状态："
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "当前站别："
        '
        'txt_currqty
        '
        Me.txt_currqty.BackColor = System.Drawing.SystemColors.Control
        Me.txt_currqty.Enabled = False
        Me.txt_currqty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_currqty.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_currqty.Location = New System.Drawing.Point(926, 60)
        Me.txt_currqty.Name = "txt_currqty"
        Me.txt_currqty.ReadOnly = True
        Me.txt_currqty.Size = New System.Drawing.Size(177, 22)
        Me.txt_currqty.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(854, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "当前片数："
        '
        'txt_wqty
        '
        Me.txt_wqty.BackColor = System.Drawing.SystemColors.Control
        Me.txt_wqty.Enabled = False
        Me.txt_wqty.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_wqty.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_wqty.Location = New System.Drawing.Point(640, 60)
        Me.txt_wqty.Name = "txt_wqty"
        Me.txt_wqty.ReadOnly = True
        Me.txt_wqty.Size = New System.Drawing.Size(177, 22)
        Me.txt_wqty.TabIndex = 21
        '
        'txt_clot
        '
        Me.txt_clot.Enabled = False
        Me.txt_clot.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clot.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_clot.Location = New System.Drawing.Point(355, 20)
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.ReadOnly = True
        Me.txt_clot.Size = New System.Drawing.Size(177, 22)
        Me.txt_clot.TabIndex = 20
        '
        'txt_ilot
        '
        Me.txt_ilot.BackColor = System.Drawing.Color.White
        Me.txt_ilot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ilot.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ilot.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_ilot.Location = New System.Drawing.Point(87, 20)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.Size = New System.Drawing.Size(177, 22)
        Me.txt_ilot.TabIndex = 1
        '
        'txt_prod
        '
        Me.txt_prod.Enabled = False
        Me.txt_prod.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_prod.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_prod.Location = New System.Drawing.Point(640, 20)
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.ReadOnly = True
        Me.txt_prod.Size = New System.Drawing.Size(177, 22)
        Me.txt_prod.TabIndex = 18
        '
        'txt_cust
        '
        Me.txt_cust.Enabled = False
        Me.txt_cust.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cust.ForeColor = System.Drawing.Color.DarkBlue
        Me.txt_cust.Location = New System.Drawing.Point(926, 20)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(177, 22)
        Me.txt_cust.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(569, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "进货片数："
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(569, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "产品型号："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "客户批号："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(855, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "客户名称："
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "生产批号："
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_verify)
        Me.GroupBox2.Controls.Add(Me.btn_splitlot)
        Me.GroupBox2.Controls.Add(Me.NUD_lots)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.DGV_WaferList)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 119)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1138, 475)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "分批作业"
        '
        'NUD_lots
        '
        Me.NUD_lots.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.NUD_lots.ForeColor = System.Drawing.Color.Blue
        Me.NUD_lots.Location = New System.Drawing.Point(91, 43)
        Me.NUD_lots.Maximum = New Decimal(New Integer() {24, 0, 0, 0})
        Me.NUD_lots.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NUD_lots.Name = "NUD_lots"
        Me.NUD_lots.Size = New System.Drawing.Size(97, 21)
        Me.NUD_lots.TabIndex = 21
        Me.NUD_lots.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NUD_lots.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "分批数量："
        '
        'DGV_WaferList
        '
        Me.DGV_WaferList.AllowUserToAddRows = False
        Me.DGV_WaferList.AllowUserToDeleteRows = False
        Me.DGV_WaferList.AllowUserToResizeColumns = False
        Me.DGV_WaferList.AllowUserToResizeRows = False
        Me.DGV_WaferList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_WaferList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_WaferList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_WaferList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ilot, Me.waferqty, Me.w1, Me.w2, Me.w3, Me.w4, Me.w5, Me.w6, Me.w7, Me.w8, Me.w9, Me.w10, Me.w11, Me.w12, Me.w13, Me.w14, Me.w15, Me.w16, Me.w17, Me.w18, Me.w19, Me.w20, Me.w21, Me.w22, Me.w23, Me.w24, Me.w25})
        Me.DGV_WaferList.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_WaferList.Location = New System.Drawing.Point(86, 106)
        Me.DGV_WaferList.Name = "DGV_WaferList"
        Me.DGV_WaferList.RowHeadersVisible = False
        Me.DGV_WaferList.RowHeadersWidth = 10
        Me.DGV_WaferList.RowTemplate.Height = 23
        Me.DGV_WaferList.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_WaferList.Size = New System.Drawing.Size(948, 292)
        Me.DGV_WaferList.TabIndex = 11
        '
        'ilot
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        Me.ilot.DefaultCellStyle = DataGridViewCellStyle1
        Me.ilot.HeaderText = "生产批号"
        Me.ilot.Name = "ilot"
        Me.ilot.ReadOnly = True
        Me.ilot.Width = 150
        '
        'waferqty
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red
        Me.waferqty.DefaultCellStyle = DataGridViewCellStyle2
        Me.waferqty.HeaderText = "QTY"
        Me.waferqty.Name = "waferqty"
        Me.waferqty.ReadOnly = True
        Me.waferqty.Width = 40
        '
        'w1
        '
        Me.w1.HeaderText = "1"
        Me.w1.Name = "w1"
        Me.w1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.w1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.w1.Width = 30
        '
        'w2
        '
        Me.w2.HeaderText = "2"
        Me.w2.Name = "w2"
        Me.w2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.w2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.w2.Width = 30
        '
        'w3
        '
        Me.w3.HeaderText = "3"
        Me.w3.Name = "w3"
        Me.w3.Width = 30
        '
        'w4
        '
        Me.w4.HeaderText = "4"
        Me.w4.Name = "w4"
        Me.w4.Width = 30
        '
        'w5
        '
        Me.w5.HeaderText = "5"
        Me.w5.Name = "w5"
        Me.w5.Width = 30
        '
        'w6
        '
        Me.w6.HeaderText = "6"
        Me.w6.Name = "w6"
        Me.w6.Width = 30
        '
        'w7
        '
        Me.w7.HeaderText = "7"
        Me.w7.Name = "w7"
        Me.w7.Width = 30
        '
        'w8
        '
        Me.w8.HeaderText = "8"
        Me.w8.Name = "w8"
        Me.w8.Width = 30
        '
        'w9
        '
        Me.w9.HeaderText = "9"
        Me.w9.Name = "w9"
        Me.w9.Width = 30
        '
        'w10
        '
        Me.w10.HeaderText = "10"
        Me.w10.Name = "w10"
        Me.w10.Width = 30
        '
        'w11
        '
        Me.w11.HeaderText = "11"
        Me.w11.Name = "w11"
        Me.w11.Width = 30
        '
        'w12
        '
        Me.w12.HeaderText = "12"
        Me.w12.Name = "w12"
        Me.w12.Width = 30
        '
        'w13
        '
        Me.w13.HeaderText = "13"
        Me.w13.Name = "w13"
        Me.w13.Width = 30
        '
        'w14
        '
        Me.w14.HeaderText = "14"
        Me.w14.Name = "w14"
        Me.w14.Width = 30
        '
        'w15
        '
        Me.w15.HeaderText = "15"
        Me.w15.Name = "w15"
        Me.w15.Width = 30
        '
        'w16
        '
        Me.w16.HeaderText = "16"
        Me.w16.Name = "w16"
        Me.w16.Width = 30
        '
        'w17
        '
        Me.w17.HeaderText = "17"
        Me.w17.Name = "w17"
        Me.w17.Width = 30
        '
        'w18
        '
        Me.w18.HeaderText = "18"
        Me.w18.Name = "w18"
        Me.w18.Width = 30
        '
        'w19
        '
        Me.w19.HeaderText = "19"
        Me.w19.Name = "w19"
        Me.w19.Width = 30
        '
        'w20
        '
        Me.w20.HeaderText = "20"
        Me.w20.Name = "w20"
        Me.w20.Width = 30
        '
        'w21
        '
        Me.w21.HeaderText = "21"
        Me.w21.Name = "w21"
        Me.w21.Width = 30
        '
        'w22
        '
        Me.w22.HeaderText = "22"
        Me.w22.Name = "w22"
        Me.w22.Width = 30
        '
        'w23
        '
        Me.w23.HeaderText = "23"
        Me.w23.Name = "w23"
        Me.w23.Width = 30
        '
        'w24
        '
        Me.w24.HeaderText = "24"
        Me.w24.Name = "w24"
        Me.w24.Width = 30
        '
        'w25
        '
        Me.w25.HeaderText = "25"
        Me.w25.Name = "w25"
        Me.w25.Width = 30
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(655, 653)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 44
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_ok
        '
        Me.btn_ok.Enabled = False
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(329, 653)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 43
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_verify
        '
        Me.btn_verify.Image = Global.CPS.My.Resources.Resources.zpjy
        Me.btn_verify.Location = New System.Drawing.Point(502, 416)
        Me.btn_verify.Name = "btn_verify"
        Me.btn_verify.Size = New System.Drawing.Size(90, 32)
        Me.btn_verify.TabIndex = 23
        Me.btn_verify.UseVisualStyleBackColor = True
        '
        'btn_splitlot
        '
        Me.btn_splitlot.Image = Global.CPS.My.Resources.Resources.cszp
        Me.btn_splitlot.Location = New System.Drawing.Point(221, 38)
        Me.btn_splitlot.Name = "btn_splitlot"
        Me.btn_splitlot.Size = New System.Drawing.Size(90, 32)
        Me.btn_splitlot.TabIndex = 22
        Me.btn_splitlot.UseVisualStyleBackColor = True
        '
        'frmSplitLot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 747)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSplitLot"
        Me.Text = "frmSplitLot"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_lots, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_WaferList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_wqty As TextBox
    Friend WithEvents txt_clot As TextBox
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents txt_prod As TextBox
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_WaferList As DataGridView
    Friend WithEvents txt_currqty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_currstatus As TextBox
    Friend WithEvents txt_currstep As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NUD_lots As NumericUpDown
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_splitlot As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_ok As Button
    Friend WithEvents ilot As DataGridViewTextBoxColumn
    Friend WithEvents waferqty As DataGridViewTextBoxColumn
    Friend WithEvents w1 As DataGridViewCheckBoxColumn
    Friend WithEvents w2 As DataGridViewCheckBoxColumn
    Friend WithEvents w3 As DataGridViewCheckBoxColumn
    Friend WithEvents w4 As DataGridViewCheckBoxColumn
    Friend WithEvents w5 As DataGridViewCheckBoxColumn
    Friend WithEvents w6 As DataGridViewCheckBoxColumn
    Friend WithEvents w7 As DataGridViewCheckBoxColumn
    Friend WithEvents w8 As DataGridViewCheckBoxColumn
    Friend WithEvents w9 As DataGridViewCheckBoxColumn
    Friend WithEvents w10 As DataGridViewCheckBoxColumn
    Friend WithEvents w11 As DataGridViewCheckBoxColumn
    Friend WithEvents w12 As DataGridViewCheckBoxColumn
    Friend WithEvents w13 As DataGridViewCheckBoxColumn
    Friend WithEvents w14 As DataGridViewCheckBoxColumn
    Friend WithEvents w15 As DataGridViewCheckBoxColumn
    Friend WithEvents w16 As DataGridViewCheckBoxColumn
    Friend WithEvents w17 As DataGridViewCheckBoxColumn
    Friend WithEvents w18 As DataGridViewCheckBoxColumn
    Friend WithEvents w19 As DataGridViewCheckBoxColumn
    Friend WithEvents w20 As DataGridViewCheckBoxColumn
    Friend WithEvents w21 As DataGridViewCheckBoxColumn
    Friend WithEvents w22 As DataGridViewCheckBoxColumn
    Friend WithEvents w23 As DataGridViewCheckBoxColumn
    Friend WithEvents w24 As DataGridViewCheckBoxColumn
    Friend WithEvents w25 As DataGridViewCheckBoxColumn
    Friend WithEvents btn_verify As Button
End Class
