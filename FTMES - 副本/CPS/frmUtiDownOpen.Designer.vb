<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUtiDownOpen
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
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_pgm = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.combo_temp = New System.Windows.Forms.ComboBox()
        Me.txt_wqty = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combo_pib = New System.Windows.Forms.ComboBox()
        Me.combo_pc = New System.Windows.Forms.ComboBox()
        Me.combo_tempchange = New System.Windows.Forms.ComboBox()
        Me.combo_ilot = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_prod = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_clot = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_step = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_tester = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_FormNo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_downXY = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_downwafer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cancel.Location = New System.Drawing.Point(425, 652)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_cancel.TabIndex = 39
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(177, 652)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 38
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_pgm)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.combo_temp)
        Me.GroupBox1.Controls.Add(Me.txt_wqty)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_cust)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.combo_pib)
        Me.GroupBox1.Controls.Add(Me.combo_pc)
        Me.GroupBox1.Controls.Add(Me.combo_tempchange)
        Me.GroupBox1.Controls.Add(Me.combo_ilot)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_prod)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_clot)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_step)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_tester)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_FormNo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 361)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'txt_pgm
        '
        Me.txt_pgm.Location = New System.Drawing.Point(132, 298)
        Me.txt_pgm.Name = "txt_pgm"
        Me.txt_pgm.Size = New System.Drawing.Size(560, 21)
        Me.txt_pgm.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 12)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Program"
        '
        'combo_temp
        '
        Me.combo_temp.FormattingEnabled = True
        Me.combo_temp.Location = New System.Drawing.Point(132, 213)
        Me.combo_temp.Name = "combo_temp"
        Me.combo_temp.Size = New System.Drawing.Size(203, 20)
        Me.combo_temp.TabIndex = 28
        '
        'txt_wqty
        '
        Me.txt_wqty.Location = New System.Drawing.Point(487, 156)
        Me.txt_wqty.Name = "txt_wqty"
        Me.txt_wqty.ReadOnly = True
        Me.txt_wqty.Size = New System.Drawing.Size(204, 21)
        Me.txt_wqty.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(386, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "QTY (片数)"
        '
        'txt_cust
        '
        Me.txt_cust.Location = New System.Drawing.Point(487, 72)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(204, 21)
        Me.txt_cust.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(386, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 12)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Customer(客户)"
        '
        'combo_pib
        '
        Me.combo_pib.FormattingEnabled = True
        Me.combo_pib.Location = New System.Drawing.Point(489, 251)
        Me.combo_pib.Name = "combo_pib"
        Me.combo_pib.Size = New System.Drawing.Size(203, 20)
        Me.combo_pib.TabIndex = 23
        '
        'combo_pc
        '
        Me.combo_pc.FormattingEnabled = True
        Me.combo_pc.Location = New System.Drawing.Point(132, 252)
        Me.combo_pc.Name = "combo_pc"
        Me.combo_pc.Size = New System.Drawing.Size(203, 20)
        Me.combo_pc.TabIndex = 22
        '
        'combo_tempchange
        '
        Me.combo_tempchange.FormattingEnabled = True
        Me.combo_tempchange.Location = New System.Drawing.Point(488, 213)
        Me.combo_tempchange.Name = "combo_tempchange"
        Me.combo_tempchange.Size = New System.Drawing.Size(203, 20)
        Me.combo_tempchange.TabIndex = 21
        '
        'combo_ilot
        '
        Me.combo_ilot.FormattingEnabled = True
        Me.combo_ilot.Location = New System.Drawing.Point(133, 69)
        Me.combo_ilot.Name = "combo_ilot"
        Me.combo_ilot.Size = New System.Drawing.Size(203, 20)
        Me.combo_ilot.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(387, 254)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "PIB"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(31, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 12)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "ProbeCard"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(387, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Temp.Change"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Temp. (温度)"
        '
        'txt_prod
        '
        Me.txt_prod.Location = New System.Drawing.Point(487, 111)
        Me.txt_prod.Name = "txt_prod"
        Me.txt_prod.ReadOnly = True
        Me.txt_prod.Size = New System.Drawing.Size(204, 21)
        Me.txt_prod.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(386, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Product(型号)"
        '
        'txt_clot
        '
        Me.txt_clot.Location = New System.Drawing.Point(133, 111)
        Me.txt_clot.Name = "txt_clot"
        Me.txt_clot.ReadOnly = True
        Me.txt_clot.Size = New System.Drawing.Size(204, 21)
        Me.txt_clot.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cust Lot(客批)"
        '
        'txt_step
        '
        Me.txt_step.Location = New System.Drawing.Point(133, 156)
        Me.txt_step.Name = "txt_step"
        Me.txt_step.ReadOnly = True
        Me.txt_step.Size = New System.Drawing.Size(204, 21)
        Me.txt_step.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "STEP (站别)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Lot No.(批号)"
        '
        'txt_tester
        '
        Me.txt_tester.Location = New System.Drawing.Point(489, 26)
        Me.txt_tester.Name = "txt_tester"
        Me.txt_tester.ReadOnly = True
        Me.txt_tester.Size = New System.Drawing.Size(204, 21)
        Me.txt_tester.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(388, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(83, 12)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Tester (机台)"
        '
        'txt_FormNo
        '
        Me.txt_FormNo.Location = New System.Drawing.Point(133, 26)
        Me.txt_FormNo.Name = "txt_FormNo"
        Me.txt_FormNo.ReadOnly = True
        Me.txt_FormNo.Size = New System.Drawing.Size(204, 21)
        Me.txt_FormNo.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 12)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Down No.(单号)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_downXY)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_downwafer)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 361)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 142)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Abnormity Record 异常填写"
        '
        'txt_downXY
        '
        Me.txt_downXY.Location = New System.Drawing.Point(488, 38)
        Me.txt_downXY.Name = "txt_downXY"
        Me.txt_downXY.Size = New System.Drawing.Size(203, 21)
        Me.txt_downXY.TabIndex = 47
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(386, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "异常坐标"
        '
        'txt_downwafer
        '
        Me.txt_downwafer.Location = New System.Drawing.Point(132, 38)
        Me.txt_downwafer.Name = "txt_downwafer"
        Me.txt_downwafer.Size = New System.Drawing.Size(203, 21)
        Me.txt_downwafer.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "异常片号"
        '
        'frmUtiDownOpen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 722)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_confirm)
        Me.Name = "frmUtiDownOpen"
        Me.Text = "frmUtiDownOpen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_pgm As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents combo_temp As ComboBox
    Friend WithEvents txt_wqty As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents combo_pib As ComboBox
    Friend WithEvents combo_pc As ComboBox
    Friend WithEvents combo_tempchange As ComboBox
    Friend WithEvents combo_ilot As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_prod As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_clot As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_step As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tester As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_FormNo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_downXY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_downwafer As TextBox
    Friend WithEvents Label1 As Label
End Class
