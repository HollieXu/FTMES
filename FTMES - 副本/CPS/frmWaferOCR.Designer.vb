<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaferOCR
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_flot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_hhgrace = New System.Windows.Forms.RadioButton()
        Me.rb_hj = New System.Windows.Forms.RadioButton()
        Me.rb_smic = New System.Windows.Forms.RadioButton()
        Me.rb_tsmc = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.combo_preview = New System.Windows.Forms.Button()
        Me.btn_query = New System.Windows.Forms.Button()
        Me.RTB_waferocr = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_flot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_ilot)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(792, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "晶圆厂批号 （Fab Lot #)"
        '
        'txt_flot
        '
        Me.txt_flot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_flot.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_flot.ForeColor = System.Drawing.Color.Blue
        Me.txt_flot.Location = New System.Drawing.Point(297, 93)
        Me.txt_flot.Name = "txt_flot"
        Me.txt_flot.Size = New System.Drawing.Size(248, 27)
        Me.txt_flot.TabIndex = 2
        Me.txt_flot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "生产批号 （Internal Lot #)"
        '
        'txt_ilot
        '
        Me.txt_ilot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ilot.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ilot.ForeColor = System.Drawing.Color.Blue
        Me.txt_ilot.Location = New System.Drawing.Point(297, 36)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.Size = New System.Drawing.Size(248, 27)
        Me.txt_ilot.TabIndex = 0
        Me.txt_ilot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_hhgrace)
        Me.GroupBox2.Controls.Add(Me.rb_hj)
        Me.GroupBox2.Controls.Add(Me.rb_smic)
        Me.GroupBox2.Controls.Add(Me.rb_tsmc)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 163)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(792, 95)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rb_hhgrace
        '
        Me.rb_hhgrace.AutoSize = True
        Me.rb_hhgrace.Location = New System.Drawing.Point(537, 20)
        Me.rb_hhgrace.Name = "rb_hhgrace"
        Me.rb_hhgrace.Size = New System.Drawing.Size(65, 16)
        Me.rb_hhgrace.TabIndex = 6
        Me.rb_hhgrace.TabStop = True
        Me.rb_hhgrace.Text = "HHGRACE"
        Me.rb_hhgrace.UseVisualStyleBackColor = True
        '
        'rb_hj
        '
        Me.rb_hj.AutoSize = True
        Me.rb_hj.Location = New System.Drawing.Point(455, 20)
        Me.rb_hj.Name = "rb_hj"
        Me.rb_hj.Size = New System.Drawing.Size(35, 16)
        Me.rb_hj.TabIndex = 5
        Me.rb_hj.TabStop = True
        Me.rb_hj.Text = "HJ"
        Me.rb_hj.UseVisualStyleBackColor = True
        '
        'rb_smic
        '
        Me.rb_smic.AutoSize = True
        Me.rb_smic.Location = New System.Drawing.Point(371, 20)
        Me.rb_smic.Name = "rb_smic"
        Me.rb_smic.Size = New System.Drawing.Size(47, 16)
        Me.rb_smic.TabIndex = 4
        Me.rb_smic.TabStop = True
        Me.rb_smic.Text = "SMIC"
        Me.rb_smic.UseVisualStyleBackColor = True
        '
        'rb_tsmc
        '
        Me.rb_tsmc.AutoSize = True
        Me.rb_tsmc.Location = New System.Drawing.Point(297, 20)
        Me.rb_tsmc.Name = "rb_tsmc"
        Me.rb_tsmc.Size = New System.Drawing.Size(47, 16)
        Me.rb_tsmc.TabIndex = 3
        Me.rb_tsmc.TabStop = True
        Me.rb_tsmc.Text = "TSMC"
        Me.rb_tsmc.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(180, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "晶圆厂商 （Fab Format)"
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(601, 741)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 41
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'combo_preview
        '
        Me.combo_preview.Image = Global.CPS.My.Resources.Resources.djly
        Me.combo_preview.Location = New System.Drawing.Point(328, 741)
        Me.combo_preview.Name = "combo_preview"
        Me.combo_preview.Size = New System.Drawing.Size(90, 32)
        Me.combo_preview.TabIndex = 42
        Me.combo_preview.UseVisualStyleBackColor = True
        '
        'btn_query
        '
        Me.btn_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_query.Location = New System.Drawing.Point(70, 741)
        Me.btn_query.Name = "btn_query"
        Me.btn_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_query.TabIndex = 43
        Me.btn_query.UseVisualStyleBackColor = True
        '
        'RTB_waferocr
        '
        Me.RTB_waferocr.Dock = System.Windows.Forms.DockStyle.Top
        Me.RTB_waferocr.Font = New System.Drawing.Font("Calibri", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTB_waferocr.ForeColor = System.Drawing.Color.MediumBlue
        Me.RTB_waferocr.Location = New System.Drawing.Point(0, 258)
        Me.RTB_waferocr.Name = "RTB_waferocr"
        Me.RTB_waferocr.Size = New System.Drawing.Size(792, 462)
        Me.RTB_waferocr.TabIndex = 44
        Me.RTB_waferocr.Text = ""
        '
        'frmWaferOCR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 798)
        Me.Controls.Add(Me.RTB_waferocr)
        Me.Controls.Add(Me.combo_preview)
        Me.Controls.Add(Me.btn_query)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmWaferOCR"
        Me.Text = "frmWaferOCR"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rb_hhgrace As RadioButton
    Friend WithEvents rb_hj As RadioButton
    Friend WithEvents rb_smic As RadioButton
    Friend WithEvents rb_tsmc As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_flot As TextBox
    Friend WithEvents combo_preview As Button
    Friend WithEvents btn_query As Button
    Friend WithEvents RTB_waferocr As RichTextBox
End Class
