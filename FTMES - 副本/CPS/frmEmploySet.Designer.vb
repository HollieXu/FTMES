<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmploySet
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_department = New System.Windows.Forms.ComboBox()
        Me.txt_ename = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.txt_position = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Position"
        '
        'combo_department
        '
        Me.combo_department.FormattingEnabled = True
        Me.combo_department.Location = New System.Drawing.Point(135, 173)
        Me.combo_department.Name = "combo_department"
        Me.combo_department.Size = New System.Drawing.Size(291, 20)
        Me.combo_department.TabIndex = 4
        '
        'txt_ename
        '
        Me.txt_ename.Location = New System.Drawing.Point(135, 87)
        Me.txt_ename.Name = "txt_ename"
        Me.txt_ename.Size = New System.Drawing.Size(293, 21)
        Me.txt_ename.TabIndex = 2
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(136, 39)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(293, 21)
        Me.txt_id.TabIndex = 1
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(305, 494)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(81, 494)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 7
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'txt_position
        '
        Me.txt_position.Location = New System.Drawing.Point(135, 214)
        Me.txt_position.Name = "txt_position"
        Me.txt_position.Size = New System.Drawing.Size(293, 21)
        Me.txt_position.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Department"
        '
        'txt_cname
        '
        Me.txt_cname.Location = New System.Drawing.Point(136, 131)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(293, 21)
        Me.txt_cname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Chinese Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "English Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 12)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ID"
        '
        'combo_grp
        '
        Me.combo_grp.FormattingEnabled = True
        Me.combo_grp.Location = New System.Drawing.Point(136, 257)
        Me.combo_grp.Name = "combo_grp"
        Me.combo_grp.Size = New System.Drawing.Size(291, 20)
        Me.combo_grp.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "User Group"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(239, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 12)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "1 : Manager"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(133, 322)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 12)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "5 : Engineer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(239, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 12)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "9 : Operator"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(170, 405)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 12)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "初始密码为 123456"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(134, 289)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 12)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "0 : Admin"
        '
        'frmEmploySet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 708)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.combo_grp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.combo_department)
        Me.Controls.Add(Me.txt_ename)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.txt_position)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_cname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmEmploySet"
        Me.Text = "frmEmploySet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents combo_department As ComboBox
    Friend WithEvents txt_ename As TextBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents txt_position As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_cname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
End Class
