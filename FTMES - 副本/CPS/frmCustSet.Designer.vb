<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustSet
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
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.txt_remark = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_ename = New System.Windows.Forms.TextBox()
        Me.combo_nationity = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_shortchar = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(304, 493)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(88, 493)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 8
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'txt_remark
        '
        Me.txt_remark.Location = New System.Drawing.Point(154, 303)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.Size = New System.Drawing.Size(295, 147)
        Me.txt_remark.TabIndex = 7
        Me.txt_remark.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 360)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "备注说明"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(153, 248)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(293, 21)
        Me.txt_address.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "地区别"
        '
        'txt_cname
        '
        Me.txt_cname.Location = New System.Drawing.Point(153, 153)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(293, 21)
        Me.txt_cname.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "中文名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "English Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "ID"
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(152, 24)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(293, 21)
        Me.txt_id.TabIndex = 1
        '
        'txt_ename
        '
        Me.txt_ename.Location = New System.Drawing.Point(151, 65)
        Me.txt_ename.Name = "txt_ename"
        Me.txt_ename.Size = New System.Drawing.Size(293, 21)
        Me.txt_ename.TabIndex = 2
        '
        'combo_nationity
        '
        Me.combo_nationity.FormattingEnabled = True
        Me.combo_nationity.Location = New System.Drawing.Point(154, 193)
        Me.combo_nationity.Name = "combo_nationity"
        Me.combo_nationity.Size = New System.Drawing.Size(291, 20)
        Me.combo_nationity.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(67, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "地址"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(55, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 12)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "2位简码"
        '
        'txt_shortchar
        '
        Me.txt_shortchar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_shortchar.Location = New System.Drawing.Point(151, 109)
        Me.txt_shortchar.Name = "txt_shortchar"
        Me.txt_shortchar.Size = New System.Drawing.Size(293, 21)
        Me.txt_shortchar.TabIndex = 3
        '
        'frmCustSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 705)
        Me.Controls.Add(Me.txt_shortchar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combo_nationity)
        Me.Controls.Add(Me.txt_ename)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.txt_remark)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_address)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCustSet"
        Me.Text = "frmCustSet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents txt_remark As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_address As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_ename As TextBox
    Friend WithEvents combo_nationity As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_shortchar As TextBox
End Class
