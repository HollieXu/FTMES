<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLabel
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
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.txt_lotid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_holdlot = New System.Windows.Forms.RadioButton()
        Me.rb_OutLabel = New System.Windows.Forms.RadioButton()
        Me.rb_InLabel = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(148, 134)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 38
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_exit)
        Me.GroupBox2.Controls.Add(Me.btn_ok)
        Me.GroupBox2.Controls.Add(Me.txt_lotid)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 195)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(304, 134)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 39
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'txt_lotid
        '
        Me.txt_lotid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_lotid.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lotid.ForeColor = System.Drawing.Color.Red
        Me.txt_lotid.Location = New System.Drawing.Point(244, 55)
        Me.txt_lotid.Name = "txt_lotid"
        Me.txt_lotid.Size = New System.Drawing.Size(206, 27)
        Me.txt_lotid.TabIndex = 1
        Me.txt_lotid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(90, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "生产批号(LotNo.)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_holdlot)
        Me.GroupBox1.Controls.Add(Me.rb_OutLabel)
        Me.GroupBox1.Controls.Add(Me.rb_InLabel)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(607, 120)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "标签类型(Label Type)"
        '
        'rb_holdlot
        '
        Me.rb_holdlot.AutoSize = True
        Me.rb_holdlot.Enabled = False
        Me.rb_holdlot.Location = New System.Drawing.Point(338, 46)
        Me.rb_holdlot.Name = "rb_holdlot"
        Me.rb_holdlot.Size = New System.Drawing.Size(85, 23)
        Me.rb_holdlot.TabIndex = 2
        Me.rb_holdlot.Text = "Hold Lot"
        Me.rb_holdlot.UseVisualStyleBackColor = True
        '
        'rb_OutLabel
        '
        Me.rb_OutLabel.AutoSize = True
        Me.rb_OutLabel.Location = New System.Drawing.Point(188, 46)
        Me.rb_OutLabel.Name = "rb_OutLabel"
        Me.rb_OutLabel.Size = New System.Drawing.Size(95, 23)
        Me.rb_OutLabel.TabIndex = 1
        Me.rb_OutLabel.Text = "出货标签"
        Me.rb_OutLabel.UseVisualStyleBackColor = True
        '
        'rb_InLabel
        '
        Me.rb_InLabel.AutoSize = True
        Me.rb_InLabel.Checked = True
        Me.rb_InLabel.Location = New System.Drawing.Point(33, 46)
        Me.rb_InLabel.Name = "rb_InLabel"
        Me.rb_InLabel.Size = New System.Drawing.Size(95, 23)
        Me.rb_InLabel.TabIndex = 0
        Me.rb_InLabel.TabStop = True
        Me.rb_InLabel.Text = "进货标签"
        Me.rb_InLabel.UseVisualStyleBackColor = True
        '
        'frmLabel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 335)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLabel"
        Me.Text = "frmLabel"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_ok As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_lotid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_holdlot As RadioButton
    Friend WithEvents rb_OutLabel As RadioButton
    Friend WithEvents rb_InLabel As RadioButton
    Friend WithEvents btn_exit As Button
End Class
