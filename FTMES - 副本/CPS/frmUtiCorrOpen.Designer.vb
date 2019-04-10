<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtiCorrOpen
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_pgm = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_pc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.combo_corrstep = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.combo_corrwlist = New System.Windows.Forms.ComboBox()
        Me.rb_goldwafer = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_corrlot = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rb_currwafer = New System.Windows.Forms.RadioButton()
        Me.combo_wlist = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_lot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_paper = New System.Windows.Forms.RadioButton()
        Me.rb_system = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_FormNo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cancel.Location = New System.Drawing.Point(432, 662)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_cancel.TabIndex = 37
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_pgm
        '
        Me.txt_pgm.Location = New System.Drawing.Point(150, 58)
        Me.txt_pgm.Name = "txt_pgm"
        Me.txt_pgm.Size = New System.Drawing.Size(568, 21)
        Me.txt_pgm.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Program"
        '
        'txt_pc
        '
        Me.txt_pc.Location = New System.Drawing.Point(150, 22)
        Me.txt_pc.Name = "txt_pc"
        Me.txt_pc.Size = New System.Drawing.Size(187, 21)
        Me.txt_pc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Probe Card "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txt_pgm)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txt_pc)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(0, 468)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(756, 101)
        Me.GroupBox4.TabIndex = 35
        Me.GroupBox4.TabStop = False
        '
        'combo_corrstep
        '
        Me.combo_corrstep.FormattingEnabled = True
        Me.combo_corrstep.Location = New System.Drawing.Point(151, 140)
        Me.combo_corrstep.Name = "combo_corrstep"
        Me.combo_corrstep.Size = New System.Drawing.Size(186, 20)
        Me.combo_corrstep.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Step No. "
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(184, 662)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 36
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'combo_corrwlist
        '
        Me.combo_corrwlist.FormattingEnabled = True
        Me.combo_corrwlist.Location = New System.Drawing.Point(497, 105)
        Me.combo_corrwlist.Name = "combo_corrwlist"
        Me.combo_corrwlist.Size = New System.Drawing.Size(186, 20)
        Me.combo_corrwlist.TabIndex = 7
        '
        'rb_goldwafer
        '
        Me.rb_goldwafer.AutoSize = True
        Me.rb_goldwafer.Location = New System.Drawing.Point(255, 39)
        Me.rb_goldwafer.Name = "rb_goldwafer"
        Me.rb_goldwafer.Size = New System.Drawing.Size(119, 16)
        Me.rb_goldwafer.TabIndex = 1
        Me.rb_goldwafer.TabStop = True
        Me.rb_goldwafer.Text = "依指定片结果判定"
        Me.rb_goldwafer.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_corrstep)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.combo_corrwlist)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_corrlot)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.rb_goldwafer)
        Me.GroupBox3.Controls.Add(Me.rb_currwafer)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 259)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(756, 209)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Correlation Lot (验证批号)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Wafer No. "
        '
        'txt_corrlot
        '
        Me.txt_corrlot.Location = New System.Drawing.Point(150, 102)
        Me.txt_corrlot.Name = "txt_corrlot"
        Me.txt_corrlot.Size = New System.Drawing.Size(187, 21)
        Me.txt_corrlot.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Lot No. "
        '
        'rb_currwafer
        '
        Me.rb_currwafer.AutoSize = True
        Me.rb_currwafer.Checked = True
        Me.rb_currwafer.Location = New System.Drawing.Point(55, 39)
        Me.rb_currwafer.Name = "rb_currwafer"
        Me.rb_currwafer.Size = New System.Drawing.Size(119, 16)
        Me.rb_currwafer.TabIndex = 0
        Me.rb_currwafer.TabStop = True
        Me.rb_currwafer.Text = "依当前片结果判定"
        Me.rb_currwafer.UseVisualStyleBackColor = True
        '
        'combo_wlist
        '
        Me.combo_wlist.FormattingEnabled = True
        Me.combo_wlist.Location = New System.Drawing.Point(497, 48)
        Me.combo_wlist.Name = "combo_wlist"
        Me.combo_wlist.Size = New System.Drawing.Size(186, 20)
        Me.combo_wlist.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(400, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Wafer No. "
        '
        'txt_lot
        '
        Me.txt_lot.Location = New System.Drawing.Point(150, 48)
        Me.txt_lot.Name = "txt_lot"
        Me.txt_lot.Size = New System.Drawing.Size(187, 21)
        Me.txt_lot.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lot No. "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combo_wlist)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_lot)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 133)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prodution Lot (生产批号)"
        '
        'rb_paper
        '
        Me.rb_paper.AutoSize = True
        Me.rb_paper.Location = New System.Drawing.Point(255, 75)
        Me.rb_paper.Name = "rb_paper"
        Me.rb_paper.Size = New System.Drawing.Size(113, 16)
        Me.rb_paper.TabIndex = 1
        Me.rb_paper.TabStop = True
        Me.rb_paper.Text = "Run Card (纸本)"
        Me.rb_paper.UseVisualStyleBackColor = True
        '
        'rb_system
        '
        Me.rb_system.AutoSize = True
        Me.rb_system.Checked = True
        Me.rb_system.Location = New System.Drawing.Point(55, 75)
        Me.rb_system.Name = "rb_system"
        Me.rb_system.Size = New System.Drawing.Size(101, 16)
        Me.rb_system.TabIndex = 0
        Me.rb_system.TabStop = True
        Me.rb_system.Text = "System (系统)"
        Me.rb_system.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_FormNo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.rb_paper)
        Me.GroupBox1.Controls.Add(Me.rb_system)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 126)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Corr 记录方式"
        '
        'txt_FormNo
        '
        Me.txt_FormNo.Location = New System.Drawing.Point(146, 26)
        Me.txt_FormNo.Name = "txt_FormNo"
        Me.txt_FormNo.ReadOnly = True
        Me.txt_FormNo.Size = New System.Drawing.Size(225, 21)
        Me.txt_FormNo.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 12)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Corr No.(单号):"
        '
        'frmUtiCorrOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 722)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUtiCorrOpen"
        Me.Text = "frmUtiCorrOpen"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_pgm As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_pc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents combo_corrstep As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents combo_corrwlist As ComboBox
    Friend WithEvents rb_goldwafer As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_corrlot As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rb_currwafer As RadioButton
    Friend WithEvents combo_wlist As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_lot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_paper As RadioButton
    Friend WithEvents rb_system As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_FormNo As TextBox
    Friend WithEvents Label8 As Label
End Class
