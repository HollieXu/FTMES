<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEquipset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipset))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Manufacturer = New System.Windows.Forms.TextBox()
        Me.txt_supplier = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtb_config = New System.Windows.Forms.RichTextBox()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_attach = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txt_SN = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NUD_position = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combo_floor = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_nextPMdate = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lbl_PMdate = New System.Windows.Forms.Label()
        Me.txt_liense = New System.Windows.Forms.TextBox()
        Me.lbl_license = New System.Windows.Forms.Label()
        Me.txt_version = New System.Windows.Forms.TextBox()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.lbl_state = New System.Windows.Forms.Label()
        Me.txt_model = New System.Windows.Forms.TextBox()
        Me.lbl_model = New System.Windows.Forms.Label()
        Me.txt_sysno = New System.Windows.Forms.TextBox()
        Me.lbl_sysno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.NUD_position, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Location = New System.Drawing.Point(122, 25)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(295, 20)
        Me.combo_type.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Group"
        '
        'combo_grp
        '
        Me.combo_grp.FormattingEnabled = True
        Me.combo_grp.Location = New System.Drawing.Point(122, 68)
        Me.combo_grp.Name = "combo_grp"
        Me.combo_grp.Size = New System.Drawing.Size(295, 20)
        Me.combo_grp.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(44, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ID"
        '
        'txt_ID
        '
        Me.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ID.Location = New System.Drawing.Point(122, 111)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(295, 21)
        Me.txt_ID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Manufacturer"
        '
        'txt_Manufacturer
        '
        Me.txt_Manufacturer.Location = New System.Drawing.Point(122, 198)
        Me.txt_Manufacturer.Name = "txt_Manufacturer"
        Me.txt_Manufacturer.Size = New System.Drawing.Size(293, 21)
        Me.txt_Manufacturer.TabIndex = 7
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(122, 249)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Size = New System.Drawing.Size(295, 21)
        Me.txt_supplier.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Supplier"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Input Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, 304)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(294, 21)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 431)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 12)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "CONFIG"
        '
        'rtb_config
        '
        Me.rtb_config.Location = New System.Drawing.Point(124, 380)
        Me.rtb_config.Name = "rtb_config"
        Me.rtb_config.Size = New System.Drawing.Size(295, 108)
        Me.rtb_config.TabIndex = 15
        Me.rtb_config.Text = ""
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(122, 651)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 16
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_exit.Location = New System.Drawing.Point(320, 651)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_exit.TabIndex = 17
        Me.btn_exit.UseVisualStyleBackColor = True
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
        Me.btn_download.Location = New System.Drawing.Point(379, 594)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(38, 42)
        Me.btn_download.TabIndex = 65
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
        Me.btn_upload.Location = New System.Drawing.Point(320, 594)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 64
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 573)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 12)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Attachment"
        '
        'txt_attach
        '
        Me.txt_attach.Location = New System.Drawing.Point(124, 527)
        Me.txt_attach.Name = "txt_attach"
        Me.txt_attach.Size = New System.Drawing.Size(295, 58)
        Me.txt_attach.TabIndex = 66
        Me.txt_attach.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txt_SN
        '
        Me.txt_SN.Location = New System.Drawing.Point(124, 155)
        Me.txt_SN.Name = "txt_SN"
        Me.txt_SN.Size = New System.Drawing.Size(293, 21)
        Me.txt_SN.TabIndex = 68
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "SN"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.NUD_position)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.combo_floor)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(466, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(487, 336)
        Me.GroupBox1.TabIndex = 69
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Location"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(45, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(365, 206)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Layout"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(44, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(267, 15)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "T41  ,  T42  ,T43  ,T44  ,T45  ............ T50"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(44, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(267, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "T31  ,  T32  ,T33  ,T34  ,T35  ............ T40"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(44, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(267, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "T21  ,  T22  ,T23  ,T24  ,T25  ............ T30"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(44, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(267, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "T11  ,  T12  ,T13  ,T14  ,T15  ............ T20"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(44, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(267, 15)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "T01  ,  T02  ,T03  ,T04  ,T05  ............ T10"
        '
        'NUD_position
        '
        Me.NUD_position.Location = New System.Drawing.Point(120, 64)
        Me.NUD_position.Maximum = New Decimal(New Integer() {55, 0, 0, 0})
        Me.NUD_position.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NUD_position.Name = "NUD_position"
        Me.NUD_position.Size = New System.Drawing.Size(290, 21)
        Me.NUD_position.TabIndex = 5
        Me.NUD_position.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Position"
        '
        'combo_floor
        '
        Me.combo_floor.FormattingEnabled = True
        Me.combo_floor.Location = New System.Drawing.Point(117, 20)
        Me.combo_floor.Name = "combo_floor"
        Me.combo_floor.Size = New System.Drawing.Size(293, 20)
        Me.combo_floor.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(56, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 12)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Floor"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox3.Controls.Add(Me.lbl_nextPMdate)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox3.Controls.Add(Me.lbl_PMdate)
        Me.GroupBox3.Controls.Add(Me.txt_liense)
        Me.GroupBox3.Controls.Add(Me.lbl_license)
        Me.GroupBox3.Controls.Add(Me.txt_version)
        Me.GroupBox3.Controls.Add(Me.lbl_version)
        Me.GroupBox3.Controls.Add(Me.txt_state)
        Me.GroupBox3.Controls.Add(Me.lbl_state)
        Me.GroupBox3.Controls.Add(Me.txt_model)
        Me.GroupBox3.Controls.Add(Me.lbl_model)
        Me.GroupBox3.Controls.Add(Me.txt_sysno)
        Me.GroupBox3.Controls.Add(Me.lbl_sysno)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 377)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(487, 306)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Handler"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(146, 265)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(264, 21)
        Me.DateTimePicker3.TabIndex = 15
        '
        'lbl_nextPMdate
        '
        Me.lbl_nextPMdate.AutoSize = True
        Me.lbl_nextPMdate.Location = New System.Drawing.Point(26, 271)
        Me.lbl_nextPMdate.Name = "lbl_nextPMdate"
        Me.lbl_nextPMdate.Size = New System.Drawing.Size(101, 12)
        Me.lbl_nextPMdate.TabIndex = 14
        Me.lbl_nextPMdate.Text = "Next PM/CAL date"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(146, 226)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(264, 21)
        Me.DateTimePicker2.TabIndex = 13
        '
        'lbl_PMdate
        '
        Me.lbl_PMdate.AutoSize = True
        Me.lbl_PMdate.Location = New System.Drawing.Point(23, 232)
        Me.lbl_PMdate.Name = "lbl_PMdate"
        Me.lbl_PMdate.Size = New System.Drawing.Size(71, 12)
        Me.lbl_PMdate.TabIndex = 12
        Me.lbl_PMdate.Text = "PM/CAL date"
        '
        'txt_liense
        '
        Me.txt_liense.Location = New System.Drawing.Point(146, 188)
        Me.txt_liense.Name = "txt_liense"
        Me.txt_liense.Size = New System.Drawing.Size(264, 21)
        Me.txt_liense.TabIndex = 9
        '
        'lbl_license
        '
        Me.lbl_license.AutoSize = True
        Me.lbl_license.Location = New System.Drawing.Point(41, 197)
        Me.lbl_license.Name = "lbl_license"
        Me.lbl_license.Size = New System.Drawing.Size(47, 12)
        Me.lbl_license.TabIndex = 8
        Me.lbl_license.Text = "License"
        '
        'txt_version
        '
        Me.txt_version.Location = New System.Drawing.Point(146, 150)
        Me.txt_version.Name = "txt_version"
        Me.txt_version.Size = New System.Drawing.Size(264, 21)
        Me.txt_version.TabIndex = 7
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(41, 159)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(47, 12)
        Me.lbl_version.TabIndex = 6
        Me.lbl_version.Text = "Version"
        '
        'txt_state
        '
        Me.txt_state.Location = New System.Drawing.Point(146, 112)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(264, 21)
        Me.txt_state.TabIndex = 5
        '
        'lbl_state
        '
        Me.lbl_state.AutoSize = True
        Me.lbl_state.Location = New System.Drawing.Point(41, 121)
        Me.lbl_state.Name = "lbl_state"
        Me.lbl_state.Size = New System.Drawing.Size(35, 12)
        Me.lbl_state.TabIndex = 4
        Me.lbl_state.Text = "State"
        '
        'txt_model
        '
        Me.txt_model.Location = New System.Drawing.Point(146, 70)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(264, 21)
        Me.txt_model.TabIndex = 3
        '
        'lbl_model
        '
        Me.lbl_model.AutoSize = True
        Me.lbl_model.Location = New System.Drawing.Point(41, 79)
        Me.lbl_model.Name = "lbl_model"
        Me.lbl_model.Size = New System.Drawing.Size(35, 12)
        Me.lbl_model.TabIndex = 2
        Me.lbl_model.Text = "Model"
        '
        'txt_sysno
        '
        Me.txt_sysno.Location = New System.Drawing.Point(146, 31)
        Me.txt_sysno.Name = "txt_sysno"
        Me.txt_sysno.Size = New System.Drawing.Size(264, 21)
        Me.txt_sysno.TabIndex = 1
        '
        'lbl_sysno
        '
        Me.lbl_sysno.AutoSize = True
        Me.lbl_sysno.Location = New System.Drawing.Point(17, 40)
        Me.lbl_sysno.Name = "lbl_sysno"
        Me.lbl_sysno.Size = New System.Drawing.Size(59, 12)
        Me.lbl_sysno.TabIndex = 0
        Me.lbl_sysno.Text = "System No"
        '
        'frmEquipset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 738)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_SN)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_attach)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.rtb_config)
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
        Me.Name = "frmEquipset"
        Me.Text = "frmEquipset"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.NUD_position, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Manufacturer As TextBox
    Friend WithEvents txt_supplier As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents rtb_config As RichTextBox
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_attach As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents txt_SN As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NUD_position As NumericUpDown
    Friend WithEvents Label11 As Label
    Friend WithEvents combo_floor As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_liense As TextBox
    Friend WithEvents lbl_license As Label
    Friend WithEvents txt_version As TextBox
    Friend WithEvents lbl_version As Label
    Friend WithEvents txt_state As TextBox
    Friend WithEvents lbl_state As Label
    Friend WithEvents txt_model As TextBox
    Friend WithEvents lbl_model As Label
    Friend WithEvents txt_sysno As TextBox
    Friend WithEvents lbl_sysno As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents lbl_nextPMdate As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents lbl_PMdate As Label
End Class
