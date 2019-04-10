<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPwd
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_oldpwd = New System.Windows.Forms.TextBox()
        Me.txt_newpwd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Old Password :"
        '
        'txt_oldpwd
        '
        Me.txt_oldpwd.Location = New System.Drawing.Point(202, 33)
        Me.txt_oldpwd.Name = "txt_oldpwd"
        Me.txt_oldpwd.Size = New System.Drawing.Size(213, 21)
        Me.txt_oldpwd.TabIndex = 1
        Me.txt_oldpwd.UseSystemPasswordChar = True
        '
        'txt_newpwd
        '
        Me.txt_newpwd.Location = New System.Drawing.Point(202, 79)
        Me.txt_newpwd.Name = "txt_newpwd"
        Me.txt_newpwd.Size = New System.Drawing.Size(213, 21)
        Me.txt_newpwd.TabIndex = 3
        Me.txt_newpwd.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "New Password :"
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.MistyRose
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(112, 142)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 4
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(290, 142)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 44
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frmPwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 218)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.txt_newpwd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_oldpwd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_oldpwd As TextBox
    Friend WithEvents txt_newpwd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_exit As Button
End Class
