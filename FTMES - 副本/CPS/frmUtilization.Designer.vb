<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtilization
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUtilization))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_change = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_spread = New System.Windows.Forms.Button()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rb_other = New System.Windows.Forms.RadioButton()
        Me.rb_down = New System.Windows.Forms.RadioButton()
        Me.rb_idle = New System.Windows.Forms.RadioButton()
        Me.rb_eo = New System.Windows.Forms.RadioButton()
        Me.rb_ei = New System.Windows.Forms.RadioButton()
        Me.rb_pm = New System.Windows.Forms.RadioButton()
        Me.rb_rework = New System.Windows.Forms.RadioButton()
        Me.rb_corr = New System.Windows.Forms.RadioButton()
        Me.rb_run = New System.Windows.Forms.RadioButton()
        Me.rb_setup = New System.Windows.Forms.RadioButton()
        Me.rb_clean = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.combo_reason = New System.Windows.Forms.ComboBox()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_op = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Rtb_remark = New System.Windows.Forms.RichTextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.combo_detail = New System.Windows.Forms.ComboBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_exit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(850, 33)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 37
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_change)
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 663)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1084, 99)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btn_change
        '
        Me.btn_change.BackgroundImage = Global.CPS.My.Resources.Resources.change
        Me.btn_change.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_change.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_change.Image = Global.CPS.My.Resources.Resources.change
        Me.btn_change.Location = New System.Drawing.Point(626, 33)
        Me.btn_change.Name = "btn_change"
        Me.btn_change.Size = New System.Drawing.Size(90, 32)
        Me.btn_change.TabIndex = 36
        Me.btn_change.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_spread)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label36)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(516, 663)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Current Status"
        '
        'btn_spread
        '
        Me.btn_spread.AutoSize = True
        Me.btn_spread.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_spread.BackgroundImage = CType(resources.GetObject("btn_spread.BackgroundImage"), System.Drawing.Image)
        Me.btn_spread.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_spread.FlatAppearance.BorderSize = 0
        Me.btn_spread.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_spread.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_spread.Location = New System.Drawing.Point(430, 279)
        Me.btn_spread.Name = "btn_spread"
        Me.btn_spread.Size = New System.Drawing.Size(40, 49)
        Me.btn_spread.TabIndex = 66
        Me.btn_spread.UseVisualStyleBackColor = False
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(36, 112)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(77, 12)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "START TIME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(164, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(164, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(164, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(164, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(164, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "label5"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(36, 332)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 12)
        Me.Label25.TabIndex = 29
        Me.Label25.Text = "TEMPERATURE :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(164, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "label6"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(36, 306)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(59, 12)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "PROGRAM :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(164, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "label7"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(36, 278)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 12)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "PROBE CARD :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(164, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "label8"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(36, 250)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(41, 12)
        Me.Label28.TabIndex = 26
        Me.Label28.Text = "STEP :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(164, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 12)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "label9"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(36, 221)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(53, 12)
        Me.Label29.TabIndex = 25
        Me.Label29.Text = "LOT NO :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(164, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 12)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "label10"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(36, 194)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(59, 12)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "PRODUCT :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(164, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 12)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "label11"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(36, 166)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(65, 12)
        Me.Label31.TabIndex = 23
        Me.Label31.Text = "CUSTOMER :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(164, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 12)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "label12"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(36, 139)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(77, 12)
        Me.Label32.TabIndex = 22
        Me.Label32.Text = "TOTAL TIME :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(36, 85)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 12)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "DETAIL :"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(36, 57)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 12)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "STATUS :"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(36, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(53, 12)
        Me.Label36.TabIndex = 18
        Me.Label36.Text = "TESTER :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.combo_reason)
        Me.GroupBox1.Controls.Add(Me.txt_pwd)
        Me.GroupBox1.Controls.Add(Me.Label42)
        Me.GroupBox1.Controls.Add(Me.txt_op)
        Me.GroupBox1.Controls.Add(Me.Label41)
        Me.GroupBox1.Controls.Add(Me.Rtb_remark)
        Me.GroupBox1.Controls.Add(Me.Label40)
        Me.GroupBox1.Controls.Add(Me.Label38)
        Me.GroupBox1.Controls.Add(Me.combo_detail)
        Me.GroupBox1.Controls.Add(Me.Label37)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(516, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(568, 663)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Status"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rb_other)
        Me.GroupBox4.Controls.Add(Me.rb_down)
        Me.GroupBox4.Controls.Add(Me.rb_idle)
        Me.GroupBox4.Controls.Add(Me.rb_eo)
        Me.GroupBox4.Controls.Add(Me.rb_ei)
        Me.GroupBox4.Controls.Add(Me.rb_pm)
        Me.GroupBox4.Controls.Add(Me.rb_rework)
        Me.GroupBox4.Controls.Add(Me.rb_corr)
        Me.GroupBox4.Controls.Add(Me.rb_run)
        Me.GroupBox4.Controls.Add(Me.rb_setup)
        Me.GroupBox4.Controls.Add(Me.rb_clean)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(61, 60)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(424, 200)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        '
        'rb_other
        '
        Me.rb_other.BackColor = System.Drawing.Color.Fuchsia
        Me.rb_other.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_other.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_other.Location = New System.Drawing.Point(302, 72)
        Me.rb_other.Name = "rb_other"
        Me.rb_other.Size = New System.Drawing.Size(110, 20)
        Me.rb_other.TabIndex = 10
        Me.rb_other.Text = "OTHER(确认)"
        Me.rb_other.UseVisualStyleBackColor = False
        '
        'rb_down
        '
        Me.rb_down.BackColor = System.Drawing.Color.Red
        Me.rb_down.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_down.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_down.Location = New System.Drawing.Point(161, 70)
        Me.rb_down.Name = "rb_down"
        Me.rb_down.Size = New System.Drawing.Size(110, 20)
        Me.rb_down.TabIndex = 9
        Me.rb_down.Text = "DOWN(异常)"
        Me.rb_down.UseVisualStyleBackColor = False
        '
        'rb_idle
        '
        Me.rb_idle.BackColor = System.Drawing.Color.Yellow
        Me.rb_idle.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_idle.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_idle.Location = New System.Drawing.Point(29, 69)
        Me.rb_idle.Name = "rb_idle"
        Me.rb_idle.Size = New System.Drawing.Size(110, 20)
        Me.rb_idle.TabIndex = 8
        Me.rb_idle.Text = "IDLE(闲置)"
        Me.rb_idle.UseVisualStyleBackColor = False
        '
        'rb_eo
        '
        Me.rb_eo.BackColor = System.Drawing.Color.Cyan
        Me.rb_eo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_eo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_eo.Location = New System.Drawing.Point(302, 114)
        Me.rb_eo.Name = "rb_eo"
        Me.rb_eo.Size = New System.Drawing.Size(110, 20)
        Me.rb_eo.TabIndex = 7
        Me.rb_eo.Text = "EO(厂外工程)"
        Me.rb_eo.UseVisualStyleBackColor = False
        '
        'rb_ei
        '
        Me.rb_ei.BackColor = System.Drawing.Color.Cyan
        Me.rb_ei.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_ei.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_ei.Location = New System.Drawing.Point(161, 114)
        Me.rb_ei.Name = "rb_ei"
        Me.rb_ei.Size = New System.Drawing.Size(110, 20)
        Me.rb_ei.TabIndex = 6
        Me.rb_ei.Text = "EI(厂内工程)"
        Me.rb_ei.UseVisualStyleBackColor = False
        '
        'rb_pm
        '
        Me.rb_pm.BackColor = System.Drawing.Color.Cyan
        Me.rb_pm.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_pm.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_pm.Location = New System.Drawing.Point(29, 114)
        Me.rb_pm.Name = "rb_pm"
        Me.rb_pm.Size = New System.Drawing.Size(110, 20)
        Me.rb_pm.TabIndex = 5
        Me.rb_pm.Text = "PM(保养)"
        Me.rb_pm.UseVisualStyleBackColor = False
        '
        'rb_rework
        '
        Me.rb_rework.BackColor = System.Drawing.Color.LimeGreen
        Me.rb_rework.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_rework.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_rework.Location = New System.Drawing.Point(161, 154)
        Me.rb_rework.Name = "rb_rework"
        Me.rb_rework.Size = New System.Drawing.Size(110, 20)
        Me.rb_rework.TabIndex = 4
        Me.rb_rework.Text = "Rework(重工)"
        Me.rb_rework.UseVisualStyleBackColor = False
        '
        'rb_corr
        '
        Me.rb_corr.BackColor = System.Drawing.Color.White
        Me.rb_corr.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_corr.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_corr.Location = New System.Drawing.Point(161, 24)
        Me.rb_corr.Name = "rb_corr"
        Me.rb_corr.Size = New System.Drawing.Size(110, 20)
        Me.rb_corr.TabIndex = 3
        Me.rb_corr.Text = "CORR"
        Me.rb_corr.UseVisualStyleBackColor = False
        '
        'rb_run
        '
        Me.rb_run.BackColor = System.Drawing.Color.LimeGreen
        Me.rb_run.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_run.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_run.Location = New System.Drawing.Point(29, 154)
        Me.rb_run.Name = "rb_run"
        Me.rb_run.Size = New System.Drawing.Size(110, 20)
        Me.rb_run.TabIndex = 2
        Me.rb_run.Text = "RUN(生产)"
        Me.rb_run.UseVisualStyleBackColor = False
        '
        'rb_setup
        '
        Me.rb_setup.BackColor = System.Drawing.Color.LightSalmon
        Me.rb_setup.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_setup.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_setup.Location = New System.Drawing.Point(302, 24)
        Me.rb_setup.Name = "rb_setup"
        Me.rb_setup.Size = New System.Drawing.Size(110, 20)
        Me.rb_setup.TabIndex = 1
        Me.rb_setup.Text = "SETUP"
        Me.rb_setup.UseVisualStyleBackColor = False
        '
        'rb_clean
        '
        Me.rb_clean.BackColor = System.Drawing.Color.White
        Me.rb_clean.Checked = True
        Me.rb_clean.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rb_clean.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.rb_clean.Location = New System.Drawing.Point(29, 24)
        Me.rb_clean.Name = "rb_clean"
        Me.rb_clean.Size = New System.Drawing.Size(110, 20)
        Me.rb_clean.TabIndex = 0
        Me.rb_clean.TabStop = True
        Me.rb_clean.Text = "CLEAN(清针)"
        Me.rb_clean.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(58, 344)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 12)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Reason (原因) :"
        '
        'combo_reason
        '
        Me.combo_reason.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.combo_reason.FormattingEnabled = True
        Me.combo_reason.Location = New System.Drawing.Point(179, 341)
        Me.combo_reason.Name = "combo_reason"
        Me.combo_reason.Size = New System.Drawing.Size(306, 20)
        Me.combo_reason.TabIndex = 31
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(168, 575)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.Size = New System.Drawing.Size(305, 21)
        Me.txt_pwd.TabIndex = 30
        Me.txt_pwd.UseSystemPasswordChar = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(58, 575)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(77, 12)
        Me.Label42.TabIndex = 29
        Me.Label42.Text = "PWD (密码) :"
        '
        'txt_op
        '
        Me.txt_op.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_op.Location = New System.Drawing.Point(168, 536)
        Me.txt_op.Name = "txt_op"
        Me.txt_op.Size = New System.Drawing.Size(305, 21)
        Me.txt_op.TabIndex = 28
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(58, 536)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(95, 12)
        Me.Label41.TabIndex = 27
        Me.Label41.Text = "OP (操作人员) :"
        '
        'Rtb_remark
        '
        Me.Rtb_remark.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Rtb_remark.Location = New System.Drawing.Point(179, 383)
        Me.Rtb_remark.Name = "Rtb_remark"
        Me.Rtb_remark.Size = New System.Drawing.Size(306, 91)
        Me.Rtb_remark.TabIndex = 25
        Me.Rtb_remark.Text = ""
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(58, 393)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(95, 12)
        Me.Label40.TabIndex = 24
        Me.Label40.Text = "Remark (备注) :"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(58, 299)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(95, 12)
        Me.Label38.TabIndex = 21
        Me.Label38.Text = "Detail (细项) :"
        '
        'combo_detail
        '
        Me.combo_detail.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.combo_detail.FormattingEnabled = True
        Me.combo_detail.Location = New System.Drawing.Point(179, 296)
        Me.combo_detail.Name = "combo_detail"
        Me.combo_detail.Size = New System.Drawing.Size(306, 20)
        Me.combo_detail.TabIndex = 20
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(58, 35)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(107, 12)
        Me.Label37.TabIndex = 19
        Me.Label37.Text = "Status (主分类) :"
        '
        'frmUtilization
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 762)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUtilization"
        Me.Text = "frmUtilization"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_change As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents combo_detail As ComboBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txt_op As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Rtb_remark As RichTextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents combo_reason As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents rb_other As RadioButton
    Friend WithEvents rb_down As RadioButton
    Friend WithEvents rb_idle As RadioButton
    Friend WithEvents rb_eo As RadioButton
    Friend WithEvents rb_ei As RadioButton
    Friend WithEvents rb_pm As RadioButton
    Friend WithEvents rb_rework As RadioButton
    Friend WithEvents rb_corr As RadioButton
    Friend WithEvents rb_run As RadioButton
    Friend WithEvents rb_setup As RadioButton
    Friend WithEvents rb_clean As RadioButton
    Friend WithEvents btn_spread As Button
End Class
