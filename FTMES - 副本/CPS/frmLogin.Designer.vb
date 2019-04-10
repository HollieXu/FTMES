<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.lbl_pwd = New System.Windows.Forms.Label()
        Me.txt_pwd = New System.Windows.Forms.TextBox()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_server = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.Location = New System.Drawing.Point(59, 46)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(83, 20)
        Me.lbl_user.TabIndex = 1
        Me.lbl_user.Text = "USER ID"
        '
        'txt_user
        '
        Me.txt_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_user.Location = New System.Drawing.Point(160, 46)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(233, 26)
        Me.txt_user.TabIndex = 2
        '
        'lbl_pwd
        '
        Me.lbl_pwd.AutoSize = True
        Me.lbl_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pwd.Location = New System.Drawing.Point(50, 102)
        Me.lbl_pwd.Name = "lbl_pwd"
        Me.lbl_pwd.Size = New System.Drawing.Size(111, 20)
        Me.lbl_pwd.TabIndex = 3
        Me.lbl_pwd.Text = "PASSWORD"
        '
        'txt_pwd
        '
        Me.txt_pwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pwd.Location = New System.Drawing.Point(160, 102)
        Me.txt_pwd.Name = "txt_pwd"
        Me.txt_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_pwd.Size = New System.Drawing.Size(233, 26)
        Me.txt_pwd.TabIndex = 4
        '
        'btn_confirm
        '
        Me.btn_confirm.BackColor = System.Drawing.Color.Azure
        Me.btn_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_confirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_confirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.Crimson
        Me.btn_confirm.Image = CType(resources.GetObject("btn_confirm.Image"), System.Drawing.Image)
        Me.btn_confirm.Location = New System.Drawing.Point(78, 220)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(106, 36)
        Me.btn_confirm.TabIndex = 6
        Me.btn_confirm.UseVisualStyleBackColor = False
        '
        'btn_Exit
        '
        Me.btn_Exit.BackColor = System.Drawing.Color.Azure
        Me.btn_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Exit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Exit.ForeColor = System.Drawing.Color.Crimson
        Me.btn_Exit.Image = CType(resources.GetObject("btn_Exit.Image"), System.Drawing.Image)
        Me.btn_Exit.Location = New System.Drawing.Point(256, 220)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(105, 36)
        Me.btn_Exit.TabIndex = 7
        Me.btn_Exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "SERVER"
        '
        'combo_server
        '
        Me.combo_server.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.combo_server.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.combo_server.ForeColor = System.Drawing.Color.SaddleBrown
        Me.combo_server.FormattingEnabled = True
        Me.combo_server.Location = New System.Drawing.Point(160, 163)
        Me.combo_server.Name = "combo_server"
        Me.combo_server.Size = New System.Drawing.Size(233, 20)
        Me.combo_server.TabIndex = 9
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(464, 294)
        Me.Controls.Add(Me.combo_server)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.txt_pwd)
        Me.Controls.Add(Me.lbl_pwd)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.lbl_user)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome to use FTMES system"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_user As Label
    Friend WithEvents txt_user As TextBox
    Friend WithEvents lbl_pwd As Label
    Friend WithEvents txt_pwd As TextBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_Exit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_server As ComboBox
End Class
