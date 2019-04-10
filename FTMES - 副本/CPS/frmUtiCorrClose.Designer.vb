<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtiCorrClose
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_diffqty = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_testqty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rb_fail = New System.Windows.Forms.RadioButton()
        Me.rb_pass = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtb_remark = New System.Windows.Forms.RichTextBox()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_diffqty)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_testqty)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.rb_fail)
        Me.GroupBox2.Controls.Add(Me.rb_pass)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 191)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Corr Result 结果"
        '
        'txt_diffqty
        '
        Me.txt_diffqty.Location = New System.Drawing.Point(187, 136)
        Me.txt_diffqty.Name = "txt_diffqty"
        Me.txt_diffqty.Size = New System.Drawing.Size(187, 21)
        Me.txt_diffqty.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 12)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Diff QTY 差异颗数"
        '
        'txt_testqty
        '
        Me.txt_testqty.Location = New System.Drawing.Point(187, 90)
        Me.txt_testqty.Name = "txt_testqty"
        Me.txt_testqty.Size = New System.Drawing.Size(187, 21)
        Me.txt_testqty.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Test QTY 测试颗数"
        '
        'rb_fail
        '
        Me.rb_fail.AutoSize = True
        Me.rb_fail.Location = New System.Drawing.Point(255, 41)
        Me.rb_fail.Name = "rb_fail"
        Me.rb_fail.Size = New System.Drawing.Size(47, 16)
        Me.rb_fail.TabIndex = 3
        Me.rb_fail.TabStop = True
        Me.rb_fail.Text = "FAIL"
        Me.rb_fail.UseVisualStyleBackColor = True
        '
        'rb_pass
        '
        Me.rb_pass.AutoSize = True
        Me.rb_pass.Location = New System.Drawing.Point(55, 41)
        Me.rb_pass.Name = "rb_pass"
        Me.rb_pass.Size = New System.Drawing.Size(47, 16)
        Me.rb_pass.TabIndex = 2
        Me.rb_pass.TabStop = True
        Me.rb_pass.Text = "PASS"
        Me.rb_pass.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtb_remark)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 191)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(756, 209)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Special Waive Remark 特别允收说明:"
        '
        'rtb_remark
        '
        Me.rtb_remark.Location = New System.Drawing.Point(55, 20)
        Me.rtb_remark.Name = "rtb_remark"
        Me.rtb_remark.Size = New System.Drawing.Size(622, 174)
        Me.rtb_remark.TabIndex = 0
        Me.rtb_remark.Text = ""
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(184, 661)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 30
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cancel.Location = New System.Drawing.Point(432, 661)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_cancel.TabIndex = 31
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frmUtiCorrClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 722)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUtiCorrClose"
        Me.Text = "frmUtiCorrClose"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_diffqty As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_testqty As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rb_fail As RadioButton
    Friend WithEvents rb_pass As RadioButton
    Friend WithEvents rtb_remark As RichTextBox
End Class
