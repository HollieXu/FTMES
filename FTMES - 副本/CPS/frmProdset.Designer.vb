<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProdset
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
        Me.CANCEL = New System.Windows.Forms.Button()
        Me.CONFIRM = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.combo_prod = New System.Windows.Forms.ComboBox()
        Me.combo_wsize = New System.Windows.Forms.ComboBox()
        Me.combo_bund = New System.Windows.Forms.ComboBox()
        Me.txt_iprod = New System.Windows.Forms.TextBox()
        Me.txt_cprod = New System.Windows.Forms.TextBox()
        Me.txt_fprod = New System.Windows.Forms.TextBox()
        Me.txt_retest = New System.Windows.Forms.TextBox()
        Me.txt_mark = New System.Windows.Forms.TextBox()
        Me.txt_gdpw = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_fabsite = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_sprod = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CANCEL
        '
        Me.CANCEL.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.CANCEL.Location = New System.Drawing.Point(314, 571)
        Me.CANCEL.Name = "CANCEL"
        Me.CANCEL.Size = New System.Drawing.Size(90, 32)
        Me.CANCEL.TabIndex = 0
        Me.CANCEL.UseVisualStyleBackColor = True
        '
        'CONFIRM
        '
        Me.CONFIRM.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.CONFIRM.Location = New System.Drawing.Point(85, 571)
        Me.CONFIRM.Name = "CONFIRM"
        Me.CONFIRM.Size = New System.Drawing.Size(90, 32)
        Me.CONFIRM.TabIndex = 1
        Me.CONFIRM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Internal Product"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Customer Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fab Product"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Product Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Wafer Size"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(83, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Bonded Product"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 12)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Retest Flow"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 12)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Mark"
        '
        'combo_cust
        '
        Me.combo_cust.BackColor = System.Drawing.SystemColors.Control
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(200, 20)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(200, 20)
        Me.combo_cust.TabIndex = 11
        '
        'combo_prod
        '
        Me.combo_prod.BackColor = System.Drawing.SystemColors.Control
        Me.combo_prod.FormattingEnabled = True
        Me.combo_prod.Location = New System.Drawing.Point(201, 56)
        Me.combo_prod.Name = "combo_prod"
        Me.combo_prod.Size = New System.Drawing.Size(199, 20)
        Me.combo_prod.TabIndex = 12
        '
        'combo_wsize
        '
        Me.combo_wsize.BackColor = System.Drawing.SystemColors.Control
        Me.combo_wsize.FormattingEnabled = True
        Me.combo_wsize.Location = New System.Drawing.Point(200, 92)
        Me.combo_wsize.Name = "combo_wsize"
        Me.combo_wsize.Size = New System.Drawing.Size(200, 20)
        Me.combo_wsize.TabIndex = 13
        '
        'combo_bund
        '
        Me.combo_bund.BackColor = System.Drawing.SystemColors.Control
        Me.combo_bund.FormattingEnabled = True
        Me.combo_bund.Location = New System.Drawing.Point(201, 123)
        Me.combo_bund.Name = "combo_bund"
        Me.combo_bund.Size = New System.Drawing.Size(199, 20)
        Me.combo_bund.TabIndex = 14
        '
        'txt_iprod
        '
        Me.txt_iprod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_iprod.Location = New System.Drawing.Point(201, 157)
        Me.txt_iprod.Name = "txt_iprod"
        Me.txt_iprod.Size = New System.Drawing.Size(199, 21)
        Me.txt_iprod.TabIndex = 15
        '
        'txt_cprod
        '
        Me.txt_cprod.Location = New System.Drawing.Point(200, 197)
        Me.txt_cprod.Name = "txt_cprod"
        Me.txt_cprod.Size = New System.Drawing.Size(200, 21)
        Me.txt_cprod.TabIndex = 16
        '
        'txt_fprod
        '
        Me.txt_fprod.Location = New System.Drawing.Point(200, 237)
        Me.txt_fprod.Name = "txt_fprod"
        Me.txt_fprod.Size = New System.Drawing.Size(200, 21)
        Me.txt_fprod.TabIndex = 17
        '
        'txt_retest
        '
        Me.txt_retest.Location = New System.Drawing.Point(200, 316)
        Me.txt_retest.Name = "txt_retest"
        Me.txt_retest.Size = New System.Drawing.Size(200, 21)
        Me.txt_retest.TabIndex = 18
        '
        'txt_mark
        '
        Me.txt_mark.Location = New System.Drawing.Point(200, 437)
        Me.txt_mark.Multiline = True
        Me.txt_mark.Name = "txt_mark"
        Me.txt_mark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_mark.Size = New System.Drawing.Size(200, 95)
        Me.txt_mark.TabIndex = 19
        '
        'txt_gdpw
        '
        Me.txt_gdpw.Location = New System.Drawing.Point(200, 354)
        Me.txt_gdpw.Name = "txt_gdpw"
        Me.txt_gdpw.Size = New System.Drawing.Size(200, 21)
        Me.txt_gdpw.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(83, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "GDPW"
        '
        'txt_fabsite
        '
        Me.txt_fabsite.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fabsite.Location = New System.Drawing.Point(200, 392)
        Me.txt_fabsite.Name = "txt_fabsite"
        Me.txt_fabsite.Size = New System.Drawing.Size(200, 21)
        Me.txt_fabsite.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 395)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Fab Site"
        '
        'txt_sprod
        '
        Me.txt_sprod.Location = New System.Drawing.Point(200, 277)
        Me.txt_sprod.Name = "txt_sprod"
        Me.txt_sprod.Size = New System.Drawing.Size(200, 21)
        Me.txt_sprod.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(83, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 12)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Ship Product"
        '
        'frmProdset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 746)
        Me.Controls.Add(Me.txt_sprod)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txt_fabsite)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txt_gdpw)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txt_mark)
        Me.Controls.Add(Me.txt_retest)
        Me.Controls.Add(Me.txt_fprod)
        Me.Controls.Add(Me.txt_cprod)
        Me.Controls.Add(Me.txt_iprod)
        Me.Controls.Add(Me.combo_bund)
        Me.Controls.Add(Me.combo_wsize)
        Me.Controls.Add(Me.combo_prod)
        Me.Controls.Add(Me.combo_cust)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CONFIRM)
        Me.Controls.Add(Me.CANCEL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmProdset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Define"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CANCEL As Button
    Friend WithEvents CONFIRM As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents combo_prod As ComboBox
    Friend WithEvents combo_wsize As ComboBox
    Friend WithEvents combo_bund As ComboBox
    Friend WithEvents txt_iprod As TextBox
    Friend WithEvents txt_cprod As TextBox
    Friend WithEvents txt_fprod As TextBox
    Friend WithEvents txt_retest As TextBox
    Friend WithEvents txt_mark As TextBox
    Friend WithEvents txt_gdpw As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_fabsite As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_sprod As TextBox
    Friend WithEvents Label12 As Label
End Class
