<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIOset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIOset))
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.rtb_config = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_caseID = New System.Windows.Forms.TextBox()
        Me.combo_status = New System.Windows.Forms.ComboBox()
        Me.txt_supplier = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combo_equip = New System.Windows.Forms.ComboBox()
        Me.txt_indate = New System.Windows.Forms.TextBox()
        Me.txt_outdate = New System.Windows.Forms.TextBox()
        Me.txt_attach = New System.Windows.Forms.RichTextBox()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(312, 538)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 35
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(95, 538)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 34
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'rtb_config
        '
        Me.rtb_config.Location = New System.Drawing.Point(128, 327)
        Me.rtb_config.Name = "rtb_config"
        Me.rtb_config.Size = New System.Drawing.Size(295, 107)
        Me.rtb_config.TabIndex = 33
        Me.rtb_config.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 370)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Config"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 12)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "equipment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "出库日期"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "入库日期"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Items.AddRange(New Object() {"IN", "OUT"})
        Me.combo_type.Location = New System.Drawing.Point(130, 62)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(293, 20)
        Me.combo_type.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "CaseID"
        '
        'txt_caseID
        '
        Me.txt_caseID.Location = New System.Drawing.Point(132, 21)
        Me.txt_caseID.Name = "txt_caseID"
        Me.txt_caseID.ReadOnly = True
        Me.txt_caseID.Size = New System.Drawing.Size(290, 21)
        Me.txt_caseID.TabIndex = 36
        '
        'combo_status
        '
        Me.combo_status.FormattingEnabled = True
        Me.combo_status.Items.AddRange(New Object() {"ongoing", "close"})
        Me.combo_status.Location = New System.Drawing.Point(128, 197)
        Me.combo_status.Name = "combo_status"
        Me.combo_status.Size = New System.Drawing.Size(294, 20)
        Me.combo_status.TabIndex = 38
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(128, 283)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(293, 21)
        Me.txt_supplier.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "supplier"
        '
        'combo_equip
        '
        Me.combo_equip.FormattingEnabled = True
        Me.combo_equip.Items.AddRange(New Object() {"tester", "prober", "board", "PIB", "Pogo Tower"})
        Me.combo_equip.Location = New System.Drawing.Point(129, 238)
        Me.combo_equip.Name = "combo_equip"
        Me.combo_equip.Size = New System.Drawing.Size(294, 20)
        Me.combo_equip.TabIndex = 41
        '
        'txt_indate
        '
        Me.txt_indate.Location = New System.Drawing.Point(128, 103)
        Me.txt_indate.Name = "txt_indate"
        Me.txt_indate.Size = New System.Drawing.Size(293, 21)
        Me.txt_indate.TabIndex = 42
        '
        'txt_outdate
        '
        Me.txt_outdate.Location = New System.Drawing.Point(129, 149)
        Me.txt_outdate.Name = "txt_outdate"
        Me.txt_outdate.Size = New System.Drawing.Size(293, 21)
        Me.txt_outdate.TabIndex = 43
        '
        'txt_attach
        '
        Me.txt_attach.Location = New System.Drawing.Point(126, 440)
        Me.txt_attach.Name = "txt_attach"
        Me.txt_attach.Size = New System.Drawing.Size(295, 58)
        Me.txt_attach.TabIndex = 70
        Me.txt_attach.Text = ""
        '
        'btn_download
        '
        Me.btn_download.AutoSize = True
        Me.btn_download.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_download.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_download.FlatAppearance.BorderSize = 0
        Me.btn_download.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen
        Me.btn_download.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_download.Image = CType(resources.GetObject("btn_download.Image"), System.Drawing.Image)
        Me.btn_download.Location = New System.Drawing.Point(472, 445)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(39, 42)
        Me.btn_download.TabIndex = 69
        Me.btn_download.UseVisualStyleBackColor = False
        '
        'btn_upload
        '
        Me.btn_upload.AutoSize = True
        Me.btn_upload.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_upload.FlatAppearance.BorderSize = 0
        Me.btn_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue
        Me.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_upload.Image = CType(resources.GetObject("btn_upload.Image"), System.Drawing.Image)
        Me.btn_upload.Location = New System.Drawing.Point(427, 445)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 68
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(36, 455)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 12)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Attachment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmIOset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 699)
        Me.Controls.Add(Me.txt_attach)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_outdate)
        Me.Controls.Add(Me.txt_indate)
        Me.Controls.Add(Me.combo_equip)
        Me.Controls.Add(Me.txt_supplier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.combo_status)
        Me.Controls.Add(Me.txt_caseID)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.rtb_config)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.combo_type)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmIOset"
        Me.Text = "frmIOset"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents rtb_config As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_caseID As TextBox
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents txt_supplier As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents combo_equip As ComboBox
    Friend WithEvents txt_indate As TextBox
    Friend WithEvents txt_outdate As TextBox
    Friend WithEvents txt_attach As RichTextBox
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
