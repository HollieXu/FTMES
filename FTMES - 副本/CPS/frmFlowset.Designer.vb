<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFlowset
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cb20 = New System.Windows.Forms.ComboBox()
        Me.cb19 = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cb16 = New System.Windows.Forms.ComboBox()
        Me.cb18 = New System.Windows.Forms.ComboBox()
        Me.cb17 = New System.Windows.Forms.ComboBox()
        Me.cb15 = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.cb12 = New System.Windows.Forms.ComboBox()
        Me.cb14 = New System.Windows.Forms.ComboBox()
        Me.cb13 = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cb11 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cb10 = New System.Windows.Forms.ComboBox()
        Me.cb09 = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cb06 = New System.Windows.Forms.ComboBox()
        Me.cb08 = New System.Windows.Forms.ComboBox()
        Me.cb07 = New System.Windows.Forms.ComboBox()
        Me.cb05 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.cb02 = New System.Windows.Forms.ComboBox()
        Me.cb04 = New System.Windows.Forms.ComboBox()
        Me.cb03 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cb01 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_prod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_flowid = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(291, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_type.Location = New System.Drawing.Point(344, 52)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(175, 20)
        Me.combo_type.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cb20)
        Me.GroupBox1.Controls.Add(Me.cb19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.cb16)
        Me.GroupBox1.Controls.Add(Me.cb18)
        Me.GroupBox1.Controls.Add(Me.cb17)
        Me.GroupBox1.Controls.Add(Me.cb15)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.cb12)
        Me.GroupBox1.Controls.Add(Me.cb14)
        Me.GroupBox1.Controls.Add(Me.cb13)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.cb11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.cb10)
        Me.GroupBox1.Controls.Add(Me.cb09)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cb06)
        Me.GroupBox1.Controls.Add(Me.cb08)
        Me.GroupBox1.Controls.Add(Me.cb07)
        Me.GroupBox1.Controls.Add(Me.cb05)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_confirm)
        Me.GroupBox1.Controls.Add(Me.cb02)
        Me.GroupBox1.Controls.Add(Me.cb04)
        Me.GroupBox1.Controls.Add(Me.cb03)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cb01)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 145)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(505, 570)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flow Diagram"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(159, 462)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(173, 12)
        Me.Label28.TabIndex = 65
        Me.Label28.Text = "请依次填写，中间不可留空STEP"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(268, 416)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 12)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "20"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(268, 378)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(19, 12)
        Me.Label15.TabIndex = 63
        Me.Label15.Text = "19"
        '
        'cb20
        '
        Me.cb20.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb20.FormattingEnabled = True
        Me.cb20.Location = New System.Drawing.Point(291, 414)
        Me.cb20.Name = "cb20"
        Me.cb20.Size = New System.Drawing.Size(144, 20)
        Me.cb20.TabIndex = 20
        '
        'cb19
        '
        Me.cb19.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb19.FormattingEnabled = True
        Me.cb19.Location = New System.Drawing.Point(291, 376)
        Me.cb19.Name = "cb19"
        Me.cb19.Size = New System.Drawing.Size(144, 20)
        Me.cb19.TabIndex = 19
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(268, 337)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(19, 12)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(268, 298)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 12)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "17"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(268, 258)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 12)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "16"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(268, 220)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 12)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "15"
        '
        'cb16
        '
        Me.cb16.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb16.FormattingEnabled = True
        Me.cb16.Location = New System.Drawing.Point(291, 256)
        Me.cb16.Name = "cb16"
        Me.cb16.Size = New System.Drawing.Size(144, 20)
        Me.cb16.TabIndex = 16
        '
        'cb18
        '
        Me.cb18.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb18.FormattingEnabled = True
        Me.cb18.Location = New System.Drawing.Point(291, 335)
        Me.cb18.Name = "cb18"
        Me.cb18.Size = New System.Drawing.Size(144, 20)
        Me.cb18.TabIndex = 18
        '
        'cb17
        '
        Me.cb17.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb17.FormattingEnabled = True
        Me.cb17.Location = New System.Drawing.Point(291, 293)
        Me.cb17.Name = "cb17"
        Me.cb17.Size = New System.Drawing.Size(144, 20)
        Me.cb17.TabIndex = 17
        '
        'cb15
        '
        Me.cb15.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb15.FormattingEnabled = True
        Me.cb15.Location = New System.Drawing.Point(291, 218)
        Me.cb15.Name = "cb15"
        Me.cb15.Size = New System.Drawing.Size(144, 20)
        Me.cb15.TabIndex = 15
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(268, 182)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(19, 12)
        Me.Label22.TabIndex = 52
        Me.Label22.Text = "14"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(268, 143)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(19, 12)
        Me.Label23.TabIndex = 51
        Me.Label23.Text = "13"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(268, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 12)
        Me.Label24.TabIndex = 50
        Me.Label24.Text = "12"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Red
        Me.Label25.Location = New System.Drawing.Point(268, 65)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 12)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "11"
        '
        'cb12
        '
        Me.cb12.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb12.FormattingEnabled = True
        Me.cb12.Location = New System.Drawing.Point(291, 101)
        Me.cb12.Name = "cb12"
        Me.cb12.Size = New System.Drawing.Size(144, 20)
        Me.cb12.TabIndex = 12
        '
        'cb14
        '
        Me.cb14.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb14.FormattingEnabled = True
        Me.cb14.Location = New System.Drawing.Point(291, 180)
        Me.cb14.Name = "cb14"
        Me.cb14.Size = New System.Drawing.Size(144, 20)
        Me.cb14.TabIndex = 14
        '
        'cb13
        '
        Me.cb13.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb13.FormattingEnabled = True
        Me.cb13.Location = New System.Drawing.Point(291, 138)
        Me.cb13.Name = "cb13"
        Me.cb13.Size = New System.Drawing.Size(144, 20)
        Me.cb13.TabIndex = 13
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(342, 31)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(44, 17)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "NAME"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(261, 33)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(36, 17)
        Me.Label27.TabIndex = 44
        Me.Label27.Text = "STEP"
        '
        'cb11
        '
        Me.cb11.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb11.FormattingEnabled = True
        Me.cb11.Location = New System.Drawing.Point(291, 63)
        Me.cb11.Name = "cb11"
        Me.cb11.Size = New System.Drawing.Size(144, 20)
        Me.cb11.TabIndex = 11
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(50, 414)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 12)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "10"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(50, 376)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 12)
        Me.Label17.TabIndex = 41
        Me.Label17.Text = "09"
        '
        'cb10
        '
        Me.cb10.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb10.FormattingEnabled = True
        Me.cb10.Location = New System.Drawing.Point(73, 412)
        Me.cb10.Name = "cb10"
        Me.cb10.Size = New System.Drawing.Size(148, 20)
        Me.cb10.TabIndex = 10
        '
        'cb09
        '
        Me.cb09.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb09.FormattingEnabled = True
        Me.cb09.Location = New System.Drawing.Point(73, 374)
        Me.cb09.Name = "cb09"
        Me.cb09.Size = New System.Drawing.Size(148, 20)
        Me.cb09.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(50, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 12)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "08"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(50, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 12)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "07"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(50, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 12)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "06"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(50, 218)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 12)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "05"
        '
        'cb06
        '
        Me.cb06.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb06.FormattingEnabled = True
        Me.cb06.Location = New System.Drawing.Point(73, 254)
        Me.cb06.Name = "cb06"
        Me.cb06.Size = New System.Drawing.Size(148, 20)
        Me.cb06.TabIndex = 6
        '
        'cb08
        '
        Me.cb08.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb08.FormattingEnabled = True
        Me.cb08.Location = New System.Drawing.Point(73, 333)
        Me.cb08.Name = "cb08"
        Me.cb08.Size = New System.Drawing.Size(148, 20)
        Me.cb08.TabIndex = 8
        '
        'cb07
        '
        Me.cb07.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb07.FormattingEnabled = True
        Me.cb07.Location = New System.Drawing.Point(73, 291)
        Me.cb07.Name = "cb07"
        Me.cb07.Size = New System.Drawing.Size(148, 20)
        Me.cb07.TabIndex = 7
        '
        'cb05
        '
        Me.cb05.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb05.FormattingEnabled = True
        Me.cb05.Location = New System.Drawing.Point(73, 216)
        Me.cb05.Name = "cb05"
        Me.cb05.Size = New System.Drawing.Size(148, 20)
        Me.cb05.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(50, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 12)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "04"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(50, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 12)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "03"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(50, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 12)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "02"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(50, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 12)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "01"
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cancel.Location = New System.Drawing.Point(302, 495)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_cancel.TabIndex = 24
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(82, 495)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 23
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'cb02
        '
        Me.cb02.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb02.FormattingEnabled = True
        Me.cb02.Location = New System.Drawing.Point(73, 99)
        Me.cb02.Name = "cb02"
        Me.cb02.Size = New System.Drawing.Size(148, 20)
        Me.cb02.TabIndex = 2
        '
        'cb04
        '
        Me.cb04.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb04.FormattingEnabled = True
        Me.cb04.Location = New System.Drawing.Point(73, 178)
        Me.cb04.Name = "cb04"
        Me.cb04.Size = New System.Drawing.Size(148, 20)
        Me.cb04.TabIndex = 4
        '
        'cb03
        '
        Me.cb03.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb03.FormattingEnabled = True
        Me.cb03.Location = New System.Drawing.Point(73, 136)
        Me.cb03.Name = "cb03"
        Me.cb03.Size = New System.Drawing.Size(148, 20)
        Me.cb03.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(122, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "NAME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(43, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "STEP"
        '
        'cb01
        '
        Me.cb01.BackColor = System.Drawing.Color.White
        Me.cb01.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb01.FormattingEnabled = True
        Me.cb01.Location = New System.Drawing.Point(73, 61)
        Me.cb01.Name = "cb01"
        Me.cb01.Size = New System.Drawing.Size(148, 20)
        Me.cb01.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product"
        '
        'combo_prod
        '
        Me.combo_prod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.combo_prod.FormattingEnabled = True
        Me.combo_prod.Location = New System.Drawing.Point(344, 20)
        Me.combo_prod.Name = "combo_prod"
        Me.combo_prod.Size = New System.Drawing.Size(175, 20)
        Me.combo_prod.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Customer"
        '
        'combo_cust
        '
        Me.combo_cust.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(95, 20)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(162, 20)
        Me.combo_cust.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(26, 52)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(47, 12)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Flow ID"
        '
        'txt_flowid
        '
        Me.txt_flowid.Location = New System.Drawing.Point(95, 50)
        Me.txt_flowid.Name = "txt_flowid"
        Me.txt_flowid.ReadOnly = True
        Me.txt_flowid.Size = New System.Drawing.Size(161, 21)
        Me.txt_flowid.TabIndex = 11
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(26, 100)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(41, 12)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "i Lot:"
        '
        'txt_ilot
        '
        Me.txt_ilot.Location = New System.Drawing.Point(93, 86)
        Me.txt_ilot.Multiline = True
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ilot.Size = New System.Drawing.Size(155, 47)
        Me.txt_ilot.TabIndex = 13
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(297, 100)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(41, 12)
        Me.Label31.TabIndex = 14
        Me.Label31.Text = "c Lot:"
        '
        'txt_clot
        '
        Me.txt_clot.Location = New System.Drawing.Point(344, 86)
        Me.txt_clot.Multiline = True
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_clot.Size = New System.Drawing.Size(155, 47)
        Me.txt_clot.TabIndex = 15
        '
        'frmFlowset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(572, 785)
        Me.Controls.Add(Me.txt_clot)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txt_ilot)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.txt_flowid)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.combo_type)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.combo_prod)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combo_cust)
        Me.Name = "frmFlowset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FlowOPSForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb01 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb02 As ComboBox
    Friend WithEvents cb04 As ComboBox
    Friend WithEvents cb03 As ComboBox
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cb20 As ComboBox
    Friend WithEvents cb19 As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents cb16 As ComboBox
    Friend WithEvents cb18 As ComboBox
    Friend WithEvents cb17 As ComboBox
    Friend WithEvents cb15 As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents cb12 As ComboBox
    Friend WithEvents cb14 As ComboBox
    Friend WithEvents cb13 As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cb11 As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents cb10 As ComboBox
    Friend WithEvents cb09 As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cb06 As ComboBox
    Friend WithEvents cb08 As ComboBox
    Friend WithEvents cb07 As ComboBox
    Friend WithEvents cb05 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_prod As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_flowid As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_clot As TextBox
End Class
