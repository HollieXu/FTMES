<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRealLocation
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
        Me.rb_accessory = New System.Windows.Forms.RadioButton()
        Me.rb_wafer = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_accessory)
        Me.GroupBox1.Controls.Add(Me.rb_wafer)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(692, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "物件类别"
        '
        'rb_accessory
        '
        Me.rb_accessory.AutoSize = True
        Me.rb_accessory.Location = New System.Drawing.Point(188, 46)
        Me.rb_accessory.Name = "rb_accessory"
        Me.rb_accessory.Size = New System.Drawing.Size(111, 20)
        Me.rb_accessory.TabIndex = 1
        Me.rb_accessory.Text = "针卡及配件"
        Me.rb_accessory.UseVisualStyleBackColor = True
        '
        'rb_wafer
        '
        Me.rb_wafer.AutoSize = True
        Me.rb_wafer.Checked = True
        Me.rb_wafer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_wafer.Location = New System.Drawing.Point(33, 46)
        Me.rb_wafer.Name = "rb_wafer"
        Me.rb_wafer.Size = New System.Drawing.Size(68, 23)
        Me.rb_wafer.TabIndex = 0
        Me.rb_wafer.TabStop = True
        Me.rb_wafer.Text = "Wafer"
        Me.rb_wafer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_location)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_id)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(692, 300)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'txt_location
        '
        Me.txt_location.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_location.ForeColor = System.Drawing.Color.Red
        Me.txt_location.Location = New System.Drawing.Point(210, 166)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(270, 26)
        Me.txt_location.TabIndex = 3
        Me.txt_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(110, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "最新库位:"
        '
        'txt_id
        '
        Me.txt_id.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_id.ForeColor = System.Drawing.Color.Red
        Me.txt_id.Location = New System.Drawing.Point(210, 62)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(270, 26)
        Me.txt_id.TabIndex = 1
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(110, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "批号/编号:"
        '
        'btn_ok
        '
        Me.btn_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ok.Location = New System.Drawing.Point(178, 492)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_ok.TabIndex = 35
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(353, 492)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 45
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frmRealLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 618)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmRealLocation"
        Me.Text = "frmRealLocation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb_accessory As RadioButton
    Friend WithEvents rb_wafer As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ok As Button
    Friend WithEvents btn_exit As Button
End Class
