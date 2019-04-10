<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssySet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAssySet))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Package = New System.Windows.Forms.Label()
        Me.txt_attach = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.combo_ioside = New System.Windows.Forms.ComboBox()
        Me.combo_owner = New System.Windows.Forms.ComboBox()
        Me.combo_partno = New System.Windows.Forms.ComboBox()
        Me.txt_location = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog2 = New System.Windows.Forms.SaveFileDialog()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.txt_live = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_package = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combo_prod = New System.Windows.Forms.ComboBox()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.rtb_remark = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_supplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Manufacturer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpb_kit = New System.Windows.Forms.GroupBox()
        Me.txt_thick = New System.Windows.Forms.TextBox()
        Me.lbl_thick = New System.Windows.Forms.Label()
        Me.txt_fit = New System.Windows.Forms.TextBox()
        Me.lbl_fitMe = New System.Windows.Forms.Label()
        Me.txt_site = New System.Windows.Forms.TextBox()
        Me.lbl_site = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.grpb_kit.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'Package
        '
        Me.Package.AutoSize = True
        Me.Package.Location = New System.Drawing.Point(63, 552)
        Me.Package.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Package.Name = "Package"
        Me.Package.Size = New System.Drawing.Size(47, 12)
        Me.Package.TabIndex = 105
        Me.Package.Text = "package"
        '
        'txt_attach
        '
        Me.txt_attach.Location = New System.Drawing.Point(134, 650)
        Me.txt_attach.Name = "txt_attach"
        Me.txt_attach.Size = New System.Drawing.Size(713, 21)
        Me.txt_attach.TabIndex = 100
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(51, 653)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 12)
        Me.Label25.TabIndex = 99
        Me.Label25.Text = "Attachment:"
        '
        'combo_ioside
        '
        Me.combo_ioside.FormattingEnabled = True
        Me.combo_ioside.Location = New System.Drawing.Point(134, 320)
        Me.combo_ioside.Name = "combo_ioside"
        Me.combo_ioside.Size = New System.Drawing.Size(211, 20)
        Me.combo_ioside.TabIndex = 98
        '
        'combo_owner
        '
        Me.combo_owner.FormattingEnabled = True
        Me.combo_owner.Location = New System.Drawing.Point(134, 283)
        Me.combo_owner.Name = "combo_owner"
        Me.combo_owner.Size = New System.Drawing.Size(211, 20)
        Me.combo_owner.TabIndex = 97
        '
        'combo_partno
        '
        Me.combo_partno.FormattingEnabled = True
        Me.combo_partno.Location = New System.Drawing.Point(134, 201)
        Me.combo_partno.Name = "combo_partno"
        Me.combo_partno.Size = New System.Drawing.Size(211, 20)
        Me.combo_partno.TabIndex = 96
        '
        'txt_location
        '
        Me.txt_location.Location = New System.Drawing.Point(134, 359)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.Size = New System.Drawing.Size(211, 21)
        Me.txt_location.TabIndex = 94
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 362)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 93
        Me.Label14.Text = "Location"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog1"
        '
        'txt_state
        '
        Me.txt_state.Location = New System.Drawing.Point(134, 511)
        Me.txt_state.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(211, 21)
        Me.txt_state.TabIndex = 104
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(75, 517)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 12)
        Me.Label23.TabIndex = 103
        Me.Label23.Text = "State"
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
        Me.btn_download.Location = New System.Drawing.Point(908, 638)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(39, 42)
        Me.btn_download.TabIndex = 102
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
        Me.btn_upload.Location = New System.Drawing.Point(863, 638)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 101
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'txt_live
        '
        Me.txt_live.Location = New System.Drawing.Point(144, 33)
        Me.txt_live.Name = "txt_live"
        Me.txt_live.Size = New System.Drawing.Size(118, 21)
        Me.txt_live.TabIndex = 63
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(55, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 64
        Me.Label22.Text = "LifeSpan"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 352)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 12)
        Me.Label19.TabIndex = 58
        '
        'txt_package
        '
        Me.txt_package.Location = New System.Drawing.Point(134, 545)
        Me.txt_package.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_package.Name = "txt_package"
        Me.txt_package.Size = New System.Drawing.Size(211, 21)
        Me.txt_package.TabIndex = 106
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_live)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Location = New System.Drawing.Point(381, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 93)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SOCKET"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 12)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "IO Side"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 286)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 12)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "OwnerShip"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(57, 204)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 12)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Part Number"
        '
        'combo_prod
        '
        Me.combo_prod.FormattingEnabled = True
        Me.combo_prod.Location = New System.Drawing.Point(134, 162)
        Me.combo_prod.Name = "combo_prod"
        Me.combo_prod.Size = New System.Drawing.Size(211, 20)
        Me.combo_prod.TabIndex = 89
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(134, 126)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(211, 20)
        Me.combo_cust.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(57, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 12)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "Product"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(57, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 86
        Me.Label9.Text = "Customer"
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(438, 699)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 85
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(208, 699)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 84
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'rtb_remark
        '
        Me.rtb_remark.Location = New System.Drawing.Point(134, 583)
        Me.rtb_remark.Name = "rtb_remark"
        Me.rtb_remark.Size = New System.Drawing.Size(713, 57)
        Me.rtb_remark.TabIndex = 83
        Me.rtb_remark.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 601)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Remark"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 467)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(211, 21)
        Me.DateTimePicker1.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 80
        Me.Label6.Text = "Input Date"
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(134, 432)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(211, 21)
        Me.txt_supplier.TabIndex = 79
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(57, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Supplier"
        '
        'txt_Manufacturer
        '
        Me.txt_Manufacturer.Location = New System.Drawing.Point(134, 393)
        Me.txt_Manufacturer.Name = "txt_Manufacturer"
        Me.txt_Manufacturer.Size = New System.Drawing.Size(211, 21)
        Me.txt_Manufacturer.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Manufacturer"
        '
        'txt_ID
        '
        Me.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ID.Location = New System.Drawing.Point(134, 240)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(211, 21)
        Me.txt_ID.TabIndex = 75
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "ID"
        '
        'combo_grp
        '
        Me.combo_grp.FormattingEnabled = True
        Me.combo_grp.Location = New System.Drawing.Point(134, 87)
        Me.combo_grp.Name = "combo_grp"
        Me.combo_grp.Size = New System.Drawing.Size(211, 20)
        Me.combo_grp.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Group"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Location = New System.Drawing.Point(134, 44)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(211, 20)
        Me.combo_type.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Type"
        '
        'grpb_kit
        '
        Me.grpb_kit.Controls.Add(Me.txt_thick)
        Me.grpb_kit.Controls.Add(Me.lbl_thick)
        Me.grpb_kit.Controls.Add(Me.txt_fit)
        Me.grpb_kit.Controls.Add(Me.lbl_fitMe)
        Me.grpb_kit.Controls.Add(Me.txt_site)
        Me.grpb_kit.Controls.Add(Me.lbl_site)
        Me.grpb_kit.Location = New System.Drawing.Point(388, 180)
        Me.grpb_kit.Name = "grpb_kit"
        Me.grpb_kit.Size = New System.Drawing.Size(459, 200)
        Me.grpb_kit.TabIndex = 107
        Me.grpb_kit.TabStop = False
        Me.grpb_kit.Text = "KIT"
        '
        'txt_thick
        '
        Me.txt_thick.Location = New System.Drawing.Point(144, 126)
        Me.txt_thick.Name = "txt_thick"
        Me.txt_thick.Size = New System.Drawing.Size(118, 21)
        Me.txt_thick.TabIndex = 5
        '
        'lbl_thick
        '
        Me.lbl_thick.AutoSize = True
        Me.lbl_thick.Location = New System.Drawing.Point(67, 135)
        Me.lbl_thick.Name = "lbl_thick"
        Me.lbl_thick.Size = New System.Drawing.Size(35, 12)
        Me.lbl_thick.TabIndex = 4
        Me.lbl_thick.Text = "Thick"
        '
        'txt_fit
        '
        Me.txt_fit.Location = New System.Drawing.Point(144, 79)
        Me.txt_fit.Name = "txt_fit"
        Me.txt_fit.Size = New System.Drawing.Size(118, 21)
        Me.txt_fit.TabIndex = 3
        '
        'lbl_fitMe
        '
        Me.lbl_fitMe.AutoSize = True
        Me.lbl_fitMe.Location = New System.Drawing.Point(55, 88)
        Me.lbl_fitMe.Name = "lbl_fitMe"
        Me.lbl_fitMe.Size = New System.Drawing.Size(53, 12)
        Me.lbl_fitMe.TabIndex = 2
        Me.lbl_fitMe.Text = "适用机型"
        '
        'txt_site
        '
        Me.txt_site.Location = New System.Drawing.Point(144, 38)
        Me.txt_site.Name = "txt_site"
        Me.txt_site.Size = New System.Drawing.Size(118, 21)
        Me.txt_site.TabIndex = 1
        '
        'lbl_site
        '
        Me.lbl_site.AutoSize = True
        Me.lbl_site.Location = New System.Drawing.Point(55, 47)
        Me.lbl_site.Name = "lbl_site"
        Me.lbl_site.Size = New System.Drawing.Size(53, 12)
        Me.lbl_site.TabIndex = 0
        Me.lbl_site.Text = "Site map"
        '
        'frmAssySet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 742)
        Me.Controls.Add(Me.grpb_kit)
        Me.Controls.Add(Me.Package)
        Me.Controls.Add(Me.txt_attach)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.combo_ioside)
        Me.Controls.Add(Me.combo_owner)
        Me.Controls.Add(Me.combo_partno)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_state)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.txt_package)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.combo_prod)
        Me.Controls.Add(Me.combo_cust)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.rtb_remark)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_supplier)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_Manufacturer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.combo_grp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combo_type)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAssySet"
        Me.Text = "frmAssySet"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpb_kit.ResumeLayout(False)
        Me.grpb_kit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Package As Label
    Friend WithEvents txt_attach As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents combo_ioside As ComboBox
    Friend WithEvents combo_owner As ComboBox
    Friend WithEvents combo_partno As ComboBox
    Friend WithEvents txt_location As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents SaveFileDialog2 As SaveFileDialog
    Friend WithEvents txt_state As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents txt_live As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_package As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents combo_prod As ComboBox
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_confirm As Button
    Friend WithEvents rtb_remark As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_supplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Manufacturer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpb_kit As GroupBox
    Friend WithEvents txt_thick As TextBox
    Friend WithEvents lbl_thick As Label
    Friend WithEvents txt_fit As TextBox
    Friend WithEvents lbl_fitMe As Label
    Friend WithEvents txt_site As TextBox
    Friend WithEvents lbl_site As Label
End Class
