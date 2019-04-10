<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStepset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStepset))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.IQC = New System.Windows.Forms.TabPage()
        Me.grp_IQC_para = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_IQC_cancel = New System.Windows.Forms.Button()
        Me.btn_IQC_confirm = New System.Windows.Forms.Button()
        Me.txt_IQC_lot = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.combo_IQC_type = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_IQC_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_IQC_WI = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_IQC_InspectionArea = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_IQC_SamplePlan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.combo_IQC_query = New System.Windows.Forms.ComboBox()
        Me.btn_IQC_Query = New System.Windows.Forms.Button()
        Me.btn_IQC_delete = New System.Windows.Forms.Button()
        Me.btn_IQC_disable = New System.Windows.Forms.Button()
        Me.btn_iqc_copy = New System.Windows.Forms.Button()
        Me.btn_IQC_modify = New System.Windows.Forms.Button()
        Me.btn_IQC_new = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV_IQC = New System.Windows.Forms.DataGridView()
        Me.CPs = New System.Windows.Forms.TabPage()
        Me.grp_CP_para = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btn_download = New System.Windows.Forms.Button()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.txt_attachpic = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txt_cp_proberoperation = New System.Windows.Forms.TextBox()
        Me.txt_cp_remark = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txt_cp_holdtiming = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_cp_testeroperation = New System.Windows.Forms.TextBox()
        Me.txt_cp_updown = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txt_cp_cleanfreq = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.combo_cp_sheetmaterial = New System.Windows.Forms.ComboBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.combo_cp_cleanmethod = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_cp_od = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_cp_dc = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_cp_setupfile = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.combo_cp_prober = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_cp_temp = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txt_cp_pib = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_cp_probecard = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_cp_pgm = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cp_pid = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cp_tt = New System.Windows.Forms.TextBox()
        Me.txt_cp_sw = New System.Windows.Forms.TextBox()
        Me.txt_cp_OS = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.combo_cp_tester = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.combo_cp_flow = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_cp_exit = New System.Windows.Forms.Button()
        Me.btn_cp_confirm = New System.Windows.Forms.Button()
        Me.txt_cp_lot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_cp_type = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cp_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.combo_cp_flowquery = New System.Windows.Forms.ComboBox()
        Me.combo_cp_enable = New System.Windows.Forms.ComboBox()
        Me.btn_CP_Query = New System.Windows.Forms.Button()
        Me.btn_CP_delete = New System.Windows.Forms.Button()
        Me.btn_CP_disable = New System.Windows.Forms.Button()
        Me.btn_CP_copy = New System.Windows.Forms.Button()
        Me.btn_CP_modify = New System.Windows.Forms.Button()
        Me.btn_CP_new = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DGV_CP = New System.Windows.Forms.DataGridView()
        Me.BAKEs = New System.Windows.Forms.TabPage()
        Me.grp_bake_para = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_bake_time = New System.Windows.Forms.TextBox()
        Me.combo_bake_recipe = New System.Windows.Forms.ComboBox()
        Me.combo_BAKE_flow = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btn_bake_exit = New System.Windows.Forms.Button()
        Me.btn_bake_confirm = New System.Windows.Forms.Button()
        Me.txt_BAKE_lot = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.combo_BAKE_type = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txt_BAKE_id = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_bake_remark = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txt_bake_temp = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.combo_bake_flowquery = New System.Windows.Forms.ComboBox()
        Me.combo_BAKE_query = New System.Windows.Forms.ComboBox()
        Me.btn_BAKE_Query = New System.Windows.Forms.Button()
        Me.btn_BAKE_delete = New System.Windows.Forms.Button()
        Me.btn_BAKE_disable = New System.Windows.Forms.Button()
        Me.btn_BAKE_copy = New System.Windows.Forms.Button()
        Me.btn_BAKE_modify = New System.Windows.Forms.Button()
        Me.btn_BAKE_new = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DGV_BAKE = New System.Windows.Forms.DataGridView()
        Me.CPsDT = New System.Windows.Forms.TabPage()
        Me.grp_cpdt_para = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txt_cpdt_operation = New System.Windows.Forms.TextBox()
        Me.combo_cpdt_flow = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.txt_cpdt_exit = New System.Windows.Forms.Button()
        Me.txt_cpdt_confirm = New System.Windows.Forms.Button()
        Me.txt_cpdt_lot = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.combo_cpdt_type = New System.Windows.Forms.ComboBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.txt_cpdt_id = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txt_cpdt_hold = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.combo_cpdt_flowquery = New System.Windows.Forms.ComboBox()
        Me.combo_cpdt_query = New System.Windows.Forms.ComboBox()
        Me.btn_cpdt_Query = New System.Windows.Forms.Button()
        Me.btn_cpdt_delete = New System.Windows.Forms.Button()
        Me.btn_cpdt_disable = New System.Windows.Forms.Button()
        Me.btn_cpdt_copy = New System.Windows.Forms.Button()
        Me.btn_cpdt_modify = New System.Windows.Forms.Button()
        Me.btn_cpdt_new = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DGV_CPDT = New System.Windows.Forms.DataGridView()
        Me.WIPFS = New System.Windows.Forms.TabPage()
        Me.grp_wipfs_para = New System.Windows.Forms.GroupBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.combo_mappingflow = New System.Windows.Forms.ComboBox()
        Me.btn_wipfs_exit = New System.Windows.Forms.Button()
        Me.btn_wipfs_confirm = New System.Windows.Forms.Button()
        Me.txt_wipfs_lot = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.combo_wipfs_type = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.txt_wipfs_id = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_wipfs_operation = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.combo_wipfs_query = New System.Windows.Forms.ComboBox()
        Me.btn_wipfs_Query = New System.Windows.Forms.Button()
        Me.btn_wipfs_delete = New System.Windows.Forms.Button()
        Me.btn_wipfs_disable = New System.Windows.Forms.Button()
        Me.btn_wipfs_copy = New System.Windows.Forms.Button()
        Me.btn_wipfs_modify = New System.Windows.Forms.Button()
        Me.btn_wipfs_new = New System.Windows.Forms.Button()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.DGV_WIPFS = New System.Windows.Forms.DataGridView()
        Me.FQC = New System.Windows.Forms.TabPage()
        Me.grp_FQC_para = New System.Windows.Forms.GroupBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txt_FQC_Probemark = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btn_FQC_exit = New System.Windows.Forms.Button()
        Me.btn_FQC_confirm = New System.Windows.Forms.Button()
        Me.txt_FQC_lot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.combo_FQC_type = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_FQC_ID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_FQC_WI = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_FQC_InspectionArea = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_FQC_SamplePlan = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.combo_FQC_query = New System.Windows.Forms.ComboBox()
        Me.btn_FQC_query = New System.Windows.Forms.Button()
        Me.btn_FQC_delete = New System.Windows.Forms.Button()
        Me.btn_FQC_disable = New System.Windows.Forms.Button()
        Me.btn_FQC_copy = New System.Windows.Forms.Button()
        Me.btn_FQC_modify = New System.Windows.Forms.Button()
        Me.btn_FQC_new = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DGV_FQC = New System.Windows.Forms.DataGridView()
        Me.PACK = New System.Windows.Forms.TabPage()
        Me.grp_pack_para = New System.Windows.Forms.GroupBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.txt_pack_recipe = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.btn_pack_exit = New System.Windows.Forms.Button()
        Me.btn_pack_confirm = New System.Windows.Forms.Button()
        Me.txt_pack_lot = New System.Windows.Forms.TextBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.combo_pack_type = New System.Windows.Forms.ComboBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.txt_pack_id = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_pack_operation = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.combo_pack_query = New System.Windows.Forms.ComboBox()
        Me.btn_pack_query = New System.Windows.Forms.Button()
        Me.btn_pack_delete = New System.Windows.Forms.Button()
        Me.btn_pack_disable = New System.Windows.Forms.Button()
        Me.btn_pack_copy = New System.Windows.Forms.Button()
        Me.btn_pack_modify = New System.Windows.Forms.Button()
        Me.btn_pack_new = New System.Windows.Forms.Button()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.DGV_PACK = New System.Windows.Forms.DataGridView()
        Me.SHIP = New System.Windows.Forms.TabPage()
        Me.grp_ship_para = New System.Windows.Forms.GroupBox()
        Me.btn_ship_exit = New System.Windows.Forms.Button()
        Me.btn_ship_confirm = New System.Windows.Forms.Button()
        Me.txt_ship_lot = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.combo_ship_type = New System.Windows.Forms.ComboBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txt_ship_id = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txt_ship_operation = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.combo_ship_query = New System.Windows.Forms.ComboBox()
        Me.btn_ship_query = New System.Windows.Forms.Button()
        Me.btn_ship_delete = New System.Windows.Forms.Button()
        Me.btn_ship_disable = New System.Windows.Forms.Button()
        Me.btn_ship_copy = New System.Windows.Forms.Button()
        Me.btn_ship_modify = New System.Windows.Forms.Button()
        Me.btn_ship_new = New System.Windows.Forms.Button()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.DGV_SHIP = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.IQC.SuspendLayout()
        Me.grp_IQC_para.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_IQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CPs.SuspendLayout()
        Me.grp_CP_para.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_CP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BAKEs.SuspendLayout()
        Me.grp_bake_para.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DGV_BAKE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CPsDT.SuspendLayout()
        Me.grp_cpdt_para.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DGV_CPDT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WIPFS.SuspendLayout()
        Me.grp_wipfs_para.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DGV_WIPFS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FQC.SuspendLayout()
        Me.grp_FQC_para.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DGV_FQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PACK.SuspendLayout()
        Me.grp_pack_para.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.DGV_PACK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SHIP.SuspendLayout()
        Me.grp_ship_para.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        CType(Me.DGV_SHIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.IQC)
        Me.TabControl1.Controls.Add(Me.CPs)
        Me.TabControl1.Controls.Add(Me.BAKEs)
        Me.TabControl1.Controls.Add(Me.CPsDT)
        Me.TabControl1.Controls.Add(Me.WIPFS)
        Me.TabControl1.Controls.Add(Me.FQC)
        Me.TabControl1.Controls.Add(Me.PACK)
        Me.TabControl1.Controls.Add(Me.SHIP)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.ItemSize = New System.Drawing.Size(100, 20)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1223, 960)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 7
        '
        'IQC
        '
        Me.IQC.BackColor = System.Drawing.Color.Transparent
        Me.IQC.Controls.Add(Me.grp_IQC_para)
        Me.IQC.Controls.Add(Me.GroupBox3)
        Me.IQC.Controls.Add(Me.GroupBox1)
        Me.IQC.Location = New System.Drawing.Point(4, 24)
        Me.IQC.Name = "IQC"
        Me.IQC.Padding = New System.Windows.Forms.Padding(3)
        Me.IQC.Size = New System.Drawing.Size(1215, 932)
        Me.IQC.TabIndex = 0
        Me.IQC.Text = "IQC"
        '
        'grp_IQC_para
        '
        Me.grp_IQC_para.Controls.Add(Me.Panel2)
        Me.grp_IQC_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_IQC_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_IQC_para.Name = "grp_IQC_para"
        Me.grp_IQC_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_IQC_para.TabIndex = 18
        Me.grp_IQC_para.TabStop = False
        Me.grp_IQC_para.Text = "Parameters"
        Me.grp_IQC_para.Visible = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btn_IQC_cancel)
        Me.Panel2.Controls.Add(Me.btn_IQC_confirm)
        Me.Panel2.Controls.Add(Me.txt_IQC_lot)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.combo_IQC_type)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txt_IQC_id)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txt_IQC_WI)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txt_IQC_InspectionArea)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txt_IQC_SamplePlan)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1203, 636)
        Me.Panel2.TabIndex = 29
        '
        'btn_IQC_cancel
        '
        Me.btn_IQC_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_IQC_cancel.Location = New System.Drawing.Point(494, 514)
        Me.btn_IQC_cancel.Name = "btn_IQC_cancel"
        Me.btn_IQC_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_cancel.TabIndex = 42
        Me.btn_IQC_cancel.UseVisualStyleBackColor = True
        '
        'btn_IQC_confirm
        '
        Me.btn_IQC_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_IQC_confirm.Location = New System.Drawing.Point(168, 514)
        Me.btn_IQC_confirm.Name = "btn_IQC_confirm"
        Me.btn_IQC_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_confirm.TabIndex = 41
        Me.btn_IQC_confirm.UseVisualStyleBackColor = True
        '
        'txt_IQC_lot
        '
        Me.txt_IQC_lot.Location = New System.Drawing.Point(427, 21)
        Me.txt_IQC_lot.Multiline = True
        Me.txt_IQC_lot.Name = "txt_IQC_lot"
        Me.txt_IQC_lot.ReadOnly = True
        Me.txt_IQC_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_IQC_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_IQC_lot.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(383, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 12)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "LOT :"
        '
        'combo_IQC_type
        '
        Me.combo_IQC_type.FormattingEnabled = True
        Me.combo_IQC_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_IQC_type.Location = New System.Drawing.Point(143, 55)
        Me.combo_IQC_type.Name = "combo_IQC_type"
        Me.combo_IQC_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_IQC_type.TabIndex = 38
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 12)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Recipe Type:"
        '
        'txt_IQC_id
        '
        Me.txt_IQC_id.ForeColor = System.Drawing.Color.Red
        Me.txt_IQC_id.Location = New System.Drawing.Point(143, 23)
        Me.txt_IQC_id.Name = "txt_IQC_id"
        Me.txt_IQC_id.ReadOnly = True
        Me.txt_IQC_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_IQC_id.TabIndex = 36
        Me.txt_IQC_id.Text = "R"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Recipe ID:"
        '
        'txt_IQC_WI
        '
        Me.txt_IQC_WI.Location = New System.Drawing.Point(50, 381)
        Me.txt_IQC_WI.Multiline = True
        Me.txt_IQC_WI.Name = "txt_IQC_WI"
        Me.txt_IQC_WI.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_IQC_WI.Size = New System.Drawing.Size(716, 82)
        Me.txt_IQC_WI.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(46, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 12)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "3. WorkInstruction 作业规范"
        '
        'txt_IQC_InspectionArea
        '
        Me.txt_IQC_InspectionArea.Location = New System.Drawing.Point(50, 257)
        Me.txt_IQC_InspectionArea.Multiline = True
        Me.txt_IQC_InspectionArea.Name = "txt_IQC_InspectionArea"
        Me.txt_IQC_InspectionArea.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_IQC_InspectionArea.Size = New System.Drawing.Size(716, 82)
        Me.txt_IQC_InspectionArea.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 12)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "2. IQC Inspection Area 检验区域"
        '
        'txt_IQC_SamplePlan
        '
        Me.txt_IQC_SamplePlan.Location = New System.Drawing.Point(50, 132)
        Me.txt_IQC_SamplePlan.Multiline = True
        Me.txt_IQC_SamplePlan.Name = "txt_IQC_SamplePlan"
        Me.txt_IQC_SamplePlan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_IQC_SamplePlan.Size = New System.Drawing.Size(716, 82)
        Me.txt_IQC_SamplePlan.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 12)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "1. IQC Sampling Plan 抽样计划"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combo_IQC_query)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_Query)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_delete)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_disable)
        Me.GroupBox3.Controls.Add(Me.btn_iqc_copy)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_modify)
        Me.GroupBox3.Controls.Add(Me.btn_IQC_new)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        '
        'combo_IQC_query
        '
        Me.combo_IQC_query.FormattingEnabled = True
        Me.combo_IQC_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_IQC_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_IQC_query.Name = "combo_IQC_query"
        Me.combo_IQC_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_IQC_query.TabIndex = 6
        Me.combo_IQC_query.Text = "ENABLE"
        '
        'btn_IQC_Query
        '
        Me.btn_IQC_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_IQC_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_IQC_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_IQC_Query.Name = "btn_IQC_Query"
        Me.btn_IQC_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_Query.TabIndex = 5
        Me.btn_IQC_Query.UseVisualStyleBackColor = False
        '
        'btn_IQC_delete
        '
        Me.btn_IQC_delete.BackColor = System.Drawing.Color.Red
        Me.btn_IQC_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_IQC_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_IQC_delete.Name = "btn_IQC_delete"
        Me.btn_IQC_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_delete.TabIndex = 4
        Me.btn_IQC_delete.UseVisualStyleBackColor = False
        Me.btn_IQC_delete.Visible = False
        '
        'btn_IQC_disable
        '
        Me.btn_IQC_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_IQC_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_IQC_disable.Name = "btn_IQC_disable"
        Me.btn_IQC_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_disable.TabIndex = 3
        Me.btn_IQC_disable.UseVisualStyleBackColor = False
        '
        'btn_iqc_copy
        '
        Me.btn_iqc_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_iqc_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_iqc_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_iqc_copy.Name = "btn_iqc_copy"
        Me.btn_iqc_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_iqc_copy.TabIndex = 2
        Me.btn_iqc_copy.UseVisualStyleBackColor = False
        '
        'btn_IQC_modify
        '
        Me.btn_IQC_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_IQC_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_IQC_modify.Name = "btn_IQC_modify"
        Me.btn_IQC_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_modify.TabIndex = 1
        Me.btn_IQC_modify.UseVisualStyleBackColor = False
        '
        'btn_IQC_new
        '
        Me.btn_IQC_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_IQC_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_IQC_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_IQC_new.Name = "btn_IQC_new"
        Me.btn_IQC_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_new.TabIndex = 0
        Me.btn_IQC_new.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DGV_IQC)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'DGV_IQC
        '
        Me.DGV_IQC.AllowUserToAddRows = False
        Me.DGV_IQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_IQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_IQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_IQC.Location = New System.Drawing.Point(3, 17)
        Me.DGV_IQC.Name = "DGV_IQC"
        Me.DGV_IQC.ReadOnly = True
        Me.DGV_IQC.RowHeadersVisible = False
        Me.DGV_IQC.RowTemplate.Height = 23
        Me.DGV_IQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_IQC.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_IQC.TabIndex = 0
        '
        'CPs
        '
        Me.CPs.BackColor = System.Drawing.Color.Transparent
        Me.CPs.Controls.Add(Me.grp_CP_para)
        Me.CPs.Controls.Add(Me.GroupBox5)
        Me.CPs.Controls.Add(Me.GroupBox4)
        Me.CPs.Location = New System.Drawing.Point(4, 24)
        Me.CPs.Name = "CPs"
        Me.CPs.Padding = New System.Windows.Forms.Padding(3)
        Me.CPs.Size = New System.Drawing.Size(1215, 932)
        Me.CPs.TabIndex = 1
        Me.CPs.Text = "CPs"
        '
        'grp_CP_para
        '
        Me.grp_CP_para.Controls.Add(Me.Panel3)
        Me.grp_CP_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_CP_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_CP_para.Name = "grp_CP_para"
        Me.grp_CP_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_CP_para.TabIndex = 21
        Me.grp_CP_para.TabStop = False
        Me.grp_CP_para.Text = "Parameters"
        Me.grp_CP_para.Visible = False
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.btn_download)
        Me.Panel3.Controls.Add(Me.btn_upload)
        Me.Panel3.Controls.Add(Me.txt_attachpic)
        Me.Panel3.Controls.Add(Me.Label67)
        Me.Panel3.Controls.Add(Me.txt_cp_proberoperation)
        Me.Panel3.Controls.Add(Me.txt_cp_remark)
        Me.Panel3.Controls.Add(Me.Label38)
        Me.Panel3.Controls.Add(Me.txt_cp_holdtiming)
        Me.Panel3.Controls.Add(Me.Label37)
        Me.Panel3.Controls.Add(Me.Label36)
        Me.Panel3.Controls.Add(Me.Label35)
        Me.Panel3.Controls.Add(Me.txt_cp_testeroperation)
        Me.Panel3.Controls.Add(Me.txt_cp_updown)
        Me.Panel3.Controls.Add(Me.Label34)
        Me.Panel3.Controls.Add(Me.txt_cp_cleanfreq)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.combo_cp_sheetmaterial)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Controls.Add(Me.combo_cp_cleanmethod)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.txt_cp_od)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.txt_cp_dc)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.txt_cp_setupfile)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.combo_cp_prober)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.txt_cp_temp)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.txt_cp_pib)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.txt_cp_probecard)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.txt_cp_pgm)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Controls.Add(Me.txt_cp_pid)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.txt_cp_tt)
        Me.Panel3.Controls.Add(Me.txt_cp_sw)
        Me.Panel3.Controls.Add(Me.txt_cp_OS)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.combo_cp_tester)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.combo_cp_flow)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.btn_cp_exit)
        Me.Panel3.Controls.Add(Me.btn_cp_confirm)
        Me.Panel3.Controls.Add(Me.txt_cp_lot)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.combo_cp_type)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txt_cp_id)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1203, 636)
        Me.Panel3.TabIndex = 79
        '
        'Panel6
        '
        Me.Panel6.Location = New System.Drawing.Point(487, 604)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(51, 69)
        Me.Panel6.TabIndex = 135
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
        Me.btn_download.Location = New System.Drawing.Point(939, 547)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(39, 42)
        Me.btn_download.TabIndex = 134
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
        Me.btn_upload.Location = New System.Drawing.Point(894, 547)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(39, 42)
        Me.btn_upload.TabIndex = 133
        Me.btn_upload.UseVisualStyleBackColor = False
        '
        'txt_attachpic
        '
        Me.txt_attachpic.Location = New System.Drawing.Point(129, 559)
        Me.txt_attachpic.Name = "txt_attachpic"
        Me.txt_attachpic.Size = New System.Drawing.Size(759, 21)
        Me.txt_attachpic.TabIndex = 132
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(51, 562)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(65, 12)
        Me.Label67.TabIndex = 131
        Me.Label67.Text = "特殊点图片"
        '
        'txt_cp_proberoperation
        '
        Me.txt_cp_proberoperation.Location = New System.Drawing.Point(539, 265)
        Me.txt_cp_proberoperation.Multiline = True
        Me.txt_cp_proberoperation.Name = "txt_cp_proberoperation"
        Me.txt_cp_proberoperation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cp_proberoperation.Size = New System.Drawing.Size(458, 157)
        Me.txt_cp_proberoperation.TabIndex = 130
        '
        'txt_cp_remark
        '
        Me.txt_cp_remark.Location = New System.Drawing.Point(539, 455)
        Me.txt_cp_remark.Multiline = True
        Me.txt_cp_remark.Name = "txt_cp_remark"
        Me.txt_cp_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cp_remark.Size = New System.Drawing.Size(458, 89)
        Me.txt_cp_remark.TabIndex = 129
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(541, 440)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(47, 12)
        Me.Label38.TabIndex = 128
        Me.Label38.Text = "Remark:"
        '
        'txt_cp_holdtiming
        '
        Me.txt_cp_holdtiming.Location = New System.Drawing.Point(41, 455)
        Me.txt_cp_holdtiming.Multiline = True
        Me.txt_cp_holdtiming.Name = "txt_cp_holdtiming"
        Me.txt_cp_holdtiming.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cp_holdtiming.Size = New System.Drawing.Size(458, 89)
        Me.txt_cp_holdtiming.TabIndex = 127
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(51, 440)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(83, 12)
        Me.Label37.TabIndex = 126
        Me.Label37.Text = "Hold Timings:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(541, 250)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(113, 12)
        Me.Label36.TabIndex = 125
        Me.Label36.Text = "Prober Operations:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(52, 250)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(113, 12)
        Me.Label35.TabIndex = 124
        Me.Label35.Text = "Tester Operations:"
        '
        'txt_cp_testeroperation
        '
        Me.txt_cp_testeroperation.Location = New System.Drawing.Point(41, 265)
        Me.txt_cp_testeroperation.Multiline = True
        Me.txt_cp_testeroperation.Name = "txt_cp_testeroperation"
        Me.txt_cp_testeroperation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cp_testeroperation.Size = New System.Drawing.Size(458, 157)
        Me.txt_cp_testeroperation.TabIndex = 123
        '
        'txt_cp_updown
        '
        Me.txt_cp_updown.Location = New System.Drawing.Point(869, 193)
        Me.txt_cp_updown.Name = "txt_cp_updown"
        Me.txt_cp_updown.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_updown.TabIndex = 122
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(780, 199)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(77, 12)
        Me.Label34.TabIndex = 121
        Me.Label34.Text = "Clean Times:"
        '
        'txt_cp_cleanfreq
        '
        Me.txt_cp_cleanfreq.Location = New System.Drawing.Point(640, 193)
        Me.txt_cp_cleanfreq.Name = "txt_cp_cleanfreq"
        Me.txt_cp_cleanfreq.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_cleanfreq.TabIndex = 120
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(541, 199)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(71, 12)
        Me.Label33.TabIndex = 119
        Me.Label33.Text = "Clean Freq:"
        '
        'combo_cp_sheetmaterial
        '
        Me.combo_cp_sheetmaterial.FormattingEnabled = True
        Me.combo_cp_sheetmaterial.Items.AddRange(New Object() {"3M-266", "ITS-PL99"})
        Me.combo_cp_sheetmaterial.Location = New System.Drawing.Point(390, 196)
        Me.combo_cp_sheetmaterial.Name = "combo_cp_sheetmaterial"
        Me.combo_cp_sheetmaterial.Size = New System.Drawing.Size(121, 20)
        Me.combo_cp_sheetmaterial.TabIndex = 118
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(294, 199)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(95, 12)
        Me.Label32.TabIndex = 117
        Me.Label32.Text = "Clean Material:"
        '
        'combo_cp_cleanmethod
        '
        Me.combo_cp_cleanmethod.FormattingEnabled = True
        Me.combo_cp_cleanmethod.Items.AddRange(New Object() {"Clean Unit", "Clean Wafer"})
        Me.combo_cp_cleanmethod.Location = New System.Drawing.Point(147, 196)
        Me.combo_cp_cleanmethod.Name = "combo_cp_cleanmethod"
        Me.combo_cp_cleanmethod.Size = New System.Drawing.Size(121, 20)
        Me.combo_cp_cleanmethod.TabIndex = 116
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(51, 196)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(83, 12)
        Me.Label31.TabIndex = 115
        Me.Label31.Text = "Clean Method:"
        '
        'txt_cp_od
        '
        Me.txt_cp_od.Location = New System.Drawing.Point(939, 161)
        Me.txt_cp_od.Name = "txt_cp_od"
        Me.txt_cp_od.Size = New System.Drawing.Size(58, 21)
        Me.txt_cp_od.TabIndex = 114
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(904, 165)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 12)
        Me.Label30.TabIndex = 113
        Me.Label30.Text = "OD :"
        '
        'txt_cp_dc
        '
        Me.txt_cp_dc.Location = New System.Drawing.Point(815, 161)
        Me.txt_cp_dc.Name = "txt_cp_dc"
        Me.txt_cp_dc.Size = New System.Drawing.Size(58, 21)
        Me.txt_cp_dc.TabIndex = 112
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(780, 164)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(29, 12)
        Me.Label29.TabIndex = 111
        Me.Label29.Text = "DC :"
        '
        'txt_cp_setupfile
        '
        Me.txt_cp_setupfile.Location = New System.Drawing.Point(390, 161)
        Me.txt_cp_setupfile.Name = "txt_cp_setupfile"
        Me.txt_cp_setupfile.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_setupfile.TabIndex = 110
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(312, 165)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 12)
        Me.Label28.TabIndex = 109
        Me.Label28.Text = "Setup File :"
        '
        'combo_cp_prober
        '
        Me.combo_cp_prober.FormattingEnabled = True
        Me.combo_cp_prober.Items.AddRange(New Object() {"TSK", "TEL", "OPUS"})
        Me.combo_cp_prober.Location = New System.Drawing.Point(147, 162)
        Me.combo_cp_prober.Name = "combo_cp_prober"
        Me.combo_cp_prober.Size = New System.Drawing.Size(121, 20)
        Me.combo_cp_prober.TabIndex = 108
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(52, 165)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 12)
        Me.Label27.TabIndex = 107
        Me.Label27.Text = "Prober :"
        '
        'txt_cp_temp
        '
        Me.txt_cp_temp.Location = New System.Drawing.Point(640, 161)
        Me.txt_cp_temp.Name = "txt_cp_temp"
        Me.txt_cp_temp.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_temp.TabIndex = 106
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(541, 165)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(83, 12)
        Me.Label26.TabIndex = 105
        Me.Label26.Text = "Temperature :"
        '
        'txt_cp_pib
        '
        Me.txt_cp_pib.Location = New System.Drawing.Point(390, 127)
        Me.txt_cp_pib.Name = "txt_cp_pib"
        Me.txt_cp_pib.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_pib.TabIndex = 104
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(344, 130)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(35, 12)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = "PIB :"
        '
        'txt_cp_probecard
        '
        Me.txt_cp_probecard.Location = New System.Drawing.Point(147, 127)
        Me.txt_cp_probecard.Name = "txt_cp_probecard"
        Me.txt_cp_probecard.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_probecard.TabIndex = 102
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(51, 136)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 12)
        Me.Label24.TabIndex = 101
        Me.Label24.Text = "ProbeCard :"
        '
        'txt_cp_pgm
        '
        Me.txt_cp_pgm.Location = New System.Drawing.Point(389, 96)
        Me.txt_cp_pgm.Name = "txt_cp_pgm"
        Me.txt_cp_pgm.Size = New System.Drawing.Size(608, 21)
        Me.txt_cp_pgm.TabIndex = 100
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(312, 99)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 12)
        Me.Label23.TabIndex = 99
        Me.Label23.Text = "PGM NAME ："
        '
        'txt_cp_pid
        '
        Me.txt_cp_pid.Location = New System.Drawing.Point(147, 96)
        Me.txt_cp_pid.Name = "txt_cp_pid"
        Me.txt_cp_pid.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_pid.TabIndex = 98
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(52, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 12)
        Me.Label22.TabIndex = 97
        Me.Label22.Text = "PGM ID :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(774, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 12)
        Me.Label21.TabIndex = 96
        Me.Label21.Text = "Test Time :"
        '
        'txt_cp_tt
        '
        Me.txt_cp_tt.Location = New System.Drawing.Point(863, 71)
        Me.txt_cp_tt.Name = "txt_cp_tt"
        Me.txt_cp_tt.Size = New System.Drawing.Size(134, 21)
        Me.txt_cp_tt.TabIndex = 95
        '
        'txt_cp_sw
        '
        Me.txt_cp_sw.Location = New System.Drawing.Point(628, 68)
        Me.txt_cp_sw.Name = "txt_cp_sw"
        Me.txt_cp_sw.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_sw.TabIndex = 94
        '
        'txt_cp_OS
        '
        Me.txt_cp_OS.Location = New System.Drawing.Point(390, 67)
        Me.txt_cp_OS.Name = "txt_cp_OS"
        Me.txt_cp_OS.Size = New System.Drawing.Size(121, 21)
        Me.txt_cp_OS.TabIndex = 93
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(554, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(53, 12)
        Me.Label20.TabIndex = 92
        Me.Label20.Text = "SW Ver :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(355, 73)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(29, 12)
        Me.Label18.TabIndex = 91
        Me.Label18.Text = "OS :"
        '
        'combo_cp_tester
        '
        Me.combo_cp_tester.FormattingEnabled = True
        Me.combo_cp_tester.Items.AddRange(New Object() {"J750", "J750EX", "J750EXHD", "3380P", "DiamondX"})
        Me.combo_cp_tester.Location = New System.Drawing.Point(147, 65)
        Me.combo_cp_tester.Name = "combo_cp_tester"
        Me.combo_cp_tester.Size = New System.Drawing.Size(121, 20)
        Me.combo_cp_tester.TabIndex = 90
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(52, 68)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "Tester :"
        '
        'combo_cp_flow
        '
        Me.combo_cp_flow.FormattingEnabled = True
        Me.combo_cp_flow.Location = New System.Drawing.Point(427, 17)
        Me.combo_cp_flow.Name = "combo_cp_flow"
        Me.combo_cp_flow.Size = New System.Drawing.Size(100, 20)
        Me.combo_cp_flow.TabIndex = 88
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(380, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 87
        Me.Label16.Text = "Flow :"
        '
        'btn_cp_exit
        '
        Me.btn_cp_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cp_exit.Location = New System.Drawing.Point(593, 593)
        Me.btn_cp_exit.Name = "btn_cp_exit"
        Me.btn_cp_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_cp_exit.TabIndex = 86
        Me.btn_cp_exit.UseVisualStyleBackColor = True
        '
        'btn_cp_confirm
        '
        Me.btn_cp_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_cp_confirm.Location = New System.Drawing.Point(282, 593)
        Me.btn_cp_confirm.Name = "btn_cp_confirm"
        Me.btn_cp_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_cp_confirm.TabIndex = 85
        Me.btn_cp_confirm.UseVisualStyleBackColor = True
        '
        'txt_cp_lot
        '
        Me.txt_cp_lot.Location = New System.Drawing.Point(833, 8)
        Me.txt_cp_lot.Multiline = True
        Me.txt_cp_lot.Name = "txt_cp_lot"
        Me.txt_cp_lot.ReadOnly = True
        Me.txt_cp_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_cp_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_cp_lot.TabIndex = 84
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(792, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "LOT :"
        '
        'combo_cp_type
        '
        Me.combo_cp_type.FormattingEnabled = True
        Me.combo_cp_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_cp_type.Location = New System.Drawing.Point(650, 17)
        Me.combo_cp_type.Name = "combo_cp_type"
        Me.combo_cp_type.Size = New System.Drawing.Size(100, 20)
        Me.combo_cp_type.TabIndex = 82
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Type:"
        '
        'txt_cp_id
        '
        Me.txt_cp_id.ForeColor = System.Drawing.Color.Red
        Me.txt_cp_id.Location = New System.Drawing.Point(122, 17)
        Me.txt_cp_id.Name = "txt_cp_id"
        Me.txt_cp_id.ReadOnly = True
        Me.txt_cp_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_cp_id.TabIndex = 80
        Me.txt_cp_id.Text = "R"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Recipe ID:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.combo_cp_flowquery)
        Me.GroupBox5.Controls.Add(Me.combo_cp_enable)
        Me.GroupBox5.Controls.Add(Me.btn_CP_Query)
        Me.GroupBox5.Controls.Add(Me.btn_CP_delete)
        Me.GroupBox5.Controls.Add(Me.btn_CP_disable)
        Me.GroupBox5.Controls.Add(Me.btn_CP_copy)
        Me.GroupBox5.Controls.Add(Me.btn_CP_modify)
        Me.GroupBox5.Controls.Add(Me.btn_CP_new)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox5.TabIndex = 20
        Me.GroupBox5.TabStop = False
        '
        'combo_cp_flowquery
        '
        Me.combo_cp_flowquery.FormattingEnabled = True
        Me.combo_cp_flowquery.Location = New System.Drawing.Point(140, 32)
        Me.combo_cp_flowquery.Name = "combo_cp_flowquery"
        Me.combo_cp_flowquery.Size = New System.Drawing.Size(80, 20)
        Me.combo_cp_flowquery.TabIndex = 7
        Me.combo_cp_flowquery.Text = "ALL"
        '
        'combo_cp_enable
        '
        Me.combo_cp_enable.FormattingEnabled = True
        Me.combo_cp_enable.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_cp_enable.Location = New System.Drawing.Point(20, 32)
        Me.combo_cp_enable.Name = "combo_cp_enable"
        Me.combo_cp_enable.Size = New System.Drawing.Size(80, 20)
        Me.combo_cp_enable.TabIndex = 6
        Me.combo_cp_enable.Text = "ENABLE"
        '
        'btn_CP_Query
        '
        Me.btn_CP_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CP_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_CP_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_CP_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_CP_Query.Name = "btn_CP_Query"
        Me.btn_CP_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_Query.TabIndex = 5
        Me.btn_CP_Query.UseVisualStyleBackColor = False
        '
        'btn_CP_delete
        '
        Me.btn_CP_delete.BackColor = System.Drawing.Color.Red
        Me.btn_CP_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_CP_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_CP_delete.Name = "btn_CP_delete"
        Me.btn_CP_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_delete.TabIndex = 4
        Me.btn_CP_delete.UseVisualStyleBackColor = False
        Me.btn_CP_delete.Visible = False
        '
        'btn_CP_disable
        '
        Me.btn_CP_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CP_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_CP_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_CP_disable.Name = "btn_CP_disable"
        Me.btn_CP_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_disable.TabIndex = 3
        Me.btn_CP_disable.UseVisualStyleBackColor = False
        '
        'btn_CP_copy
        '
        Me.btn_CP_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CP_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_CP_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_CP_copy.Name = "btn_CP_copy"
        Me.btn_CP_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_copy.TabIndex = 2
        Me.btn_CP_copy.UseVisualStyleBackColor = False
        '
        'btn_CP_modify
        '
        Me.btn_CP_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CP_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_CP_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_CP_modify.Name = "btn_CP_modify"
        Me.btn_CP_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_modify.TabIndex = 1
        Me.btn_CP_modify.UseVisualStyleBackColor = False
        '
        'btn_CP_new
        '
        Me.btn_CP_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_CP_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_CP_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_CP_new.Name = "btn_CP_new"
        Me.btn_CP_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_CP_new.TabIndex = 0
        Me.btn_CP_new.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DGV_CP)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'DGV_CP
        '
        Me.DGV_CP.AllowUserToAddRows = False
        Me.DGV_CP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_CP.Location = New System.Drawing.Point(3, 17)
        Me.DGV_CP.Name = "DGV_CP"
        Me.DGV_CP.ReadOnly = True
        Me.DGV_CP.RowHeadersVisible = False
        Me.DGV_CP.RowTemplate.Height = 23
        Me.DGV_CP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_CP.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_CP.TabIndex = 0
        '
        'BAKEs
        '
        Me.BAKEs.Controls.Add(Me.grp_bake_para)
        Me.BAKEs.Controls.Add(Me.GroupBox9)
        Me.BAKEs.Controls.Add(Me.GroupBox6)
        Me.BAKEs.Location = New System.Drawing.Point(4, 24)
        Me.BAKEs.Name = "BAKEs"
        Me.BAKEs.Padding = New System.Windows.Forms.Padding(3)
        Me.BAKEs.Size = New System.Drawing.Size(1215, 932)
        Me.BAKEs.TabIndex = 4
        Me.BAKEs.Text = "BAKEs"
        Me.BAKEs.UseVisualStyleBackColor = True
        '
        'grp_bake_para
        '
        Me.grp_bake_para.Controls.Add(Me.Panel4)
        Me.grp_bake_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_bake_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_bake_para.Name = "grp_bake_para"
        Me.grp_bake_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_bake_para.TabIndex = 21
        Me.grp_bake_para.TabStop = False
        Me.grp_bake_para.Text = "Parameters"
        Me.grp_bake_para.Visible = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.Label66)
        Me.Panel4.Controls.Add(Me.Label46)
        Me.Panel4.Controls.Add(Me.txt_bake_time)
        Me.Panel4.Controls.Add(Me.combo_bake_recipe)
        Me.Panel4.Controls.Add(Me.combo_BAKE_flow)
        Me.Panel4.Controls.Add(Me.Label45)
        Me.Panel4.Controls.Add(Me.btn_bake_exit)
        Me.Panel4.Controls.Add(Me.btn_bake_confirm)
        Me.Panel4.Controls.Add(Me.txt_BAKE_lot)
        Me.Panel4.Controls.Add(Me.Label39)
        Me.Panel4.Controls.Add(Me.combo_BAKE_type)
        Me.Panel4.Controls.Add(Me.Label40)
        Me.Panel4.Controls.Add(Me.txt_BAKE_id)
        Me.Panel4.Controls.Add(Me.Label41)
        Me.Panel4.Controls.Add(Me.txt_bake_remark)
        Me.Panel4.Controls.Add(Me.Label42)
        Me.Panel4.Controls.Add(Me.txt_bake_temp)
        Me.Panel4.Controls.Add(Me.Label43)
        Me.Panel4.Controls.Add(Me.Label44)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1203, 636)
        Me.Panel4.TabIndex = 37
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(264, 200)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(29, 12)
        Me.Label66.TabIndex = 55
        Me.Label66.Text = "Hour"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(52, 236)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(113, 12)
        Me.Label46.TabIndex = 54
        Me.Label46.Text = "4. 注意事项 Remark"
        '
        'txt_bake_time
        '
        Me.txt_bake_time.Location = New System.Drawing.Point(174, 197)
        Me.txt_bake_time.Multiline = True
        Me.txt_bake_time.Name = "txt_bake_time"
        Me.txt_bake_time.Size = New System.Drawing.Size(84, 22)
        Me.txt_bake_time.TabIndex = 53
        '
        'combo_bake_recipe
        '
        Me.combo_bake_recipe.FormattingEnabled = True
        Me.combo_bake_recipe.Items.AddRange(New Object() {"1", "3"})
        Me.combo_bake_recipe.Location = New System.Drawing.Point(174, 115)
        Me.combo_bake_recipe.Name = "combo_bake_recipe"
        Me.combo_bake_recipe.Size = New System.Drawing.Size(84, 20)
        Me.combo_bake_recipe.TabIndex = 52
        '
        'combo_BAKE_flow
        '
        Me.combo_BAKE_flow.FormattingEnabled = True
        Me.combo_BAKE_flow.Items.AddRange(New Object() {"BAKE1", "BAKE2", "BAKE3", "BAKE4"})
        Me.combo_BAKE_flow.Location = New System.Drawing.Point(394, 34)
        Me.combo_BAKE_flow.Name = "combo_BAKE_flow"
        Me.combo_BAKE_flow.Size = New System.Drawing.Size(100, 20)
        Me.combo_BAKE_flow.TabIndex = 51
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(347, 37)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(41, 12)
        Me.Label45.TabIndex = 50
        Me.Label45.Text = "Flow :"
        '
        'btn_bake_exit
        '
        Me.btn_bake_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_bake_exit.Location = New System.Drawing.Point(497, 500)
        Me.btn_bake_exit.Name = "btn_bake_exit"
        Me.btn_bake_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_bake_exit.TabIndex = 49
        Me.btn_bake_exit.UseVisualStyleBackColor = True
        '
        'btn_bake_confirm
        '
        Me.btn_bake_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_bake_confirm.Location = New System.Drawing.Point(121, 500)
        Me.btn_bake_confirm.Name = "btn_bake_confirm"
        Me.btn_bake_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_bake_confirm.TabIndex = 48
        Me.btn_bake_confirm.UseVisualStyleBackColor = True
        '
        'txt_BAKE_lot
        '
        Me.txt_BAKE_lot.Location = New System.Drawing.Point(601, 33)
        Me.txt_BAKE_lot.Multiline = True
        Me.txt_BAKE_lot.Name = "txt_BAKE_lot"
        Me.txt_BAKE_lot.ReadOnly = True
        Me.txt_BAKE_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_BAKE_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_BAKE_lot.TabIndex = 47
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(557, 38)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(35, 12)
        Me.Label39.TabIndex = 46
        Me.Label39.Text = "LOT :"
        '
        'combo_BAKE_type
        '
        Me.combo_BAKE_type.FormattingEnabled = True
        Me.combo_BAKE_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_BAKE_type.Location = New System.Drawing.Point(145, 65)
        Me.combo_BAKE_type.Name = "combo_BAKE_type"
        Me.combo_BAKE_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_BAKE_type.TabIndex = 45
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(52, 65)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 12)
        Me.Label40.TabIndex = 44
        Me.Label40.Text = "Recipe Type:"
        '
        'txt_BAKE_id
        '
        Me.txt_BAKE_id.ForeColor = System.Drawing.Color.Red
        Me.txt_BAKE_id.Location = New System.Drawing.Point(145, 33)
        Me.txt_BAKE_id.Name = "txt_BAKE_id"
        Me.txt_BAKE_id.ReadOnly = True
        Me.txt_BAKE_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_BAKE_id.TabIndex = 43
        Me.txt_BAKE_id.Text = "R"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(64, 38)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(65, 12)
        Me.Label41.TabIndex = 42
        Me.Label41.Text = "Recipe ID:"
        '
        'txt_bake_remark
        '
        Me.txt_bake_remark.Location = New System.Drawing.Point(54, 281)
        Me.txt_bake_remark.Multiline = True
        Me.txt_bake_remark.Name = "txt_bake_remark"
        Me.txt_bake_remark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_bake_remark.Size = New System.Drawing.Size(716, 82)
        Me.txt_bake_remark.TabIndex = 41
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(52, 200)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(101, 12)
        Me.Label42.TabIndex = 40
        Me.Label42.Text = "3. 烘烤时间 Time"
        '
        'txt_bake_temp
        '
        Me.txt_bake_temp.Location = New System.Drawing.Point(174, 156)
        Me.txt_bake_temp.Multiline = True
        Me.txt_bake_temp.Name = "txt_bake_temp"
        Me.txt_bake_temp.Size = New System.Drawing.Size(84, 24)
        Me.txt_bake_temp.TabIndex = 39
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(52, 159)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(101, 12)
        Me.Label43.TabIndex = 38
        Me.Label43.Text = "2. 烘烤温度 Temp"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(50, 118)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(107, 12)
        Me.Label44.TabIndex = 37
        Me.Label44.Text = "1.烘烤配方 Recipe"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.combo_bake_flowquery)
        Me.GroupBox9.Controls.Add(Me.combo_BAKE_query)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_Query)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_delete)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_disable)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_copy)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_modify)
        Me.GroupBox9.Controls.Add(Me.btn_BAKE_new)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox9.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox9.TabIndex = 20
        Me.GroupBox9.TabStop = False
        '
        'combo_bake_flowquery
        '
        Me.combo_bake_flowquery.FormattingEnabled = True
        Me.combo_bake_flowquery.Items.AddRange(New Object() {"ALL", "BAKE1", "BAKE2", "BAKE3", "BAKE4"})
        Me.combo_bake_flowquery.Location = New System.Drawing.Point(140, 32)
        Me.combo_bake_flowquery.Name = "combo_bake_flowquery"
        Me.combo_bake_flowquery.Size = New System.Drawing.Size(80, 20)
        Me.combo_bake_flowquery.TabIndex = 7
        Me.combo_bake_flowquery.Text = "ALL"
        '
        'combo_BAKE_query
        '
        Me.combo_BAKE_query.FormattingEnabled = True
        Me.combo_BAKE_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_BAKE_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_BAKE_query.Name = "combo_BAKE_query"
        Me.combo_BAKE_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_BAKE_query.TabIndex = 6
        Me.combo_BAKE_query.Text = "ENABLE"
        '
        'btn_BAKE_Query
        '
        Me.btn_BAKE_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_BAKE_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_BAKE_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_BAKE_Query.Name = "btn_BAKE_Query"
        Me.btn_BAKE_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_Query.TabIndex = 5
        Me.btn_BAKE_Query.UseVisualStyleBackColor = False
        '
        'btn_BAKE_delete
        '
        Me.btn_BAKE_delete.BackColor = System.Drawing.Color.Red
        Me.btn_BAKE_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_BAKE_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_BAKE_delete.Name = "btn_BAKE_delete"
        Me.btn_BAKE_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_delete.TabIndex = 4
        Me.btn_BAKE_delete.UseVisualStyleBackColor = False
        Me.btn_BAKE_delete.Visible = False
        '
        'btn_BAKE_disable
        '
        Me.btn_BAKE_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_BAKE_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_BAKE_disable.Name = "btn_BAKE_disable"
        Me.btn_BAKE_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_disable.TabIndex = 3
        Me.btn_BAKE_disable.UseVisualStyleBackColor = False
        '
        'btn_BAKE_copy
        '
        Me.btn_BAKE_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_BAKE_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_BAKE_copy.Name = "btn_BAKE_copy"
        Me.btn_BAKE_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_copy.TabIndex = 2
        Me.btn_BAKE_copy.UseVisualStyleBackColor = False
        '
        'btn_BAKE_modify
        '
        Me.btn_BAKE_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_BAKE_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_BAKE_modify.Name = "btn_BAKE_modify"
        Me.btn_BAKE_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_modify.TabIndex = 1
        Me.btn_BAKE_modify.UseVisualStyleBackColor = False
        '
        'btn_BAKE_new
        '
        Me.btn_BAKE_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_BAKE_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_BAKE_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_BAKE_new.Name = "btn_BAKE_new"
        Me.btn_BAKE_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_BAKE_new.TabIndex = 0
        Me.btn_BAKE_new.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DGV_BAKE)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox6.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        '
        'DGV_BAKE
        '
        Me.DGV_BAKE.AllowUserToAddRows = False
        Me.DGV_BAKE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_BAKE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_BAKE.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_BAKE.Location = New System.Drawing.Point(3, 17)
        Me.DGV_BAKE.Name = "DGV_BAKE"
        Me.DGV_BAKE.ReadOnly = True
        Me.DGV_BAKE.RowHeadersVisible = False
        Me.DGV_BAKE.RowTemplate.Height = 23
        Me.DGV_BAKE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_BAKE.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_BAKE.TabIndex = 0
        '
        'CPsDT
        '
        Me.CPsDT.Controls.Add(Me.grp_cpdt_para)
        Me.CPsDT.Controls.Add(Me.GroupBox11)
        Me.CPsDT.Controls.Add(Me.GroupBox10)
        Me.CPsDT.Location = New System.Drawing.Point(4, 24)
        Me.CPsDT.Name = "CPsDT"
        Me.CPsDT.Padding = New System.Windows.Forms.Padding(3)
        Me.CPsDT.Size = New System.Drawing.Size(1215, 932)
        Me.CPsDT.TabIndex = 5
        Me.CPsDT.Text = "CPsDT"
        Me.CPsDT.UseVisualStyleBackColor = True
        '
        'grp_cpdt_para
        '
        Me.grp_cpdt_para.Controls.Add(Me.Panel5)
        Me.grp_cpdt_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_cpdt_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_cpdt_para.Name = "grp_cpdt_para"
        Me.grp_cpdt_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_cpdt_para.TabIndex = 24
        Me.grp_cpdt_para.TabStop = False
        Me.grp_cpdt_para.Text = "Parameters"
        Me.grp_cpdt_para.Visible = False
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Controls.Add(Me.txt_cpdt_operation)
        Me.Panel5.Controls.Add(Me.combo_cpdt_flow)
        Me.Panel5.Controls.Add(Me.Label48)
        Me.Panel5.Controls.Add(Me.txt_cpdt_exit)
        Me.Panel5.Controls.Add(Me.txt_cpdt_confirm)
        Me.Panel5.Controls.Add(Me.txt_cpdt_lot)
        Me.Panel5.Controls.Add(Me.Label49)
        Me.Panel5.Controls.Add(Me.combo_cpdt_type)
        Me.Panel5.Controls.Add(Me.Label50)
        Me.Panel5.Controls.Add(Me.txt_cpdt_id)
        Me.Panel5.Controls.Add(Me.Label51)
        Me.Panel5.Controls.Add(Me.txt_cpdt_hold)
        Me.Panel5.Controls.Add(Me.Label53)
        Me.Panel5.Controls.Add(Me.Label54)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 17)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1203, 636)
        Me.Panel5.TabIndex = 34
        '
        'txt_cpdt_operation
        '
        Me.txt_cpdt_operation.Location = New System.Drawing.Point(61, 310)
        Me.txt_cpdt_operation.Multiline = True
        Me.txt_cpdt_operation.Name = "txt_cpdt_operation"
        Me.txt_cpdt_operation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cpdt_operation.Size = New System.Drawing.Size(716, 82)
        Me.txt_cpdt_operation.TabIndex = 47
        '
        'combo_cpdt_flow
        '
        Me.combo_cpdt_flow.FormattingEnabled = True
        Me.combo_cpdt_flow.Location = New System.Drawing.Point(375, 30)
        Me.combo_cpdt_flow.Name = "combo_cpdt_flow"
        Me.combo_cpdt_flow.Size = New System.Drawing.Size(100, 20)
        Me.combo_cpdt_flow.TabIndex = 46
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(328, 33)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 12)
        Me.Label48.TabIndex = 45
        Me.Label48.Text = "Flow :"
        '
        'txt_cpdt_exit
        '
        Me.txt_cpdt_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.txt_cpdt_exit.Location = New System.Drawing.Point(478, 496)
        Me.txt_cpdt_exit.Name = "txt_cpdt_exit"
        Me.txt_cpdt_exit.Size = New System.Drawing.Size(90, 32)
        Me.txt_cpdt_exit.TabIndex = 44
        Me.txt_cpdt_exit.UseVisualStyleBackColor = True
        '
        'txt_cpdt_confirm
        '
        Me.txt_cpdt_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.txt_cpdt_confirm.Location = New System.Drawing.Point(102, 496)
        Me.txt_cpdt_confirm.Name = "txt_cpdt_confirm"
        Me.txt_cpdt_confirm.Size = New System.Drawing.Size(90, 32)
        Me.txt_cpdt_confirm.TabIndex = 43
        Me.txt_cpdt_confirm.UseVisualStyleBackColor = True
        '
        'txt_cpdt_lot
        '
        Me.txt_cpdt_lot.Location = New System.Drawing.Point(582, 29)
        Me.txt_cpdt_lot.Multiline = True
        Me.txt_cpdt_lot.Name = "txt_cpdt_lot"
        Me.txt_cpdt_lot.ReadOnly = True
        Me.txt_cpdt_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_cpdt_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_cpdt_lot.TabIndex = 42
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(538, 34)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(35, 12)
        Me.Label49.TabIndex = 41
        Me.Label49.Text = "LOT :"
        '
        'combo_cpdt_type
        '
        Me.combo_cpdt_type.FormattingEnabled = True
        Me.combo_cpdt_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_cpdt_type.Location = New System.Drawing.Point(126, 61)
        Me.combo_cpdt_type.Name = "combo_cpdt_type"
        Me.combo_cpdt_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_cpdt_type.TabIndex = 40
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(33, 61)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(77, 12)
        Me.Label50.TabIndex = 39
        Me.Label50.Text = "Recipe Type:"
        '
        'txt_cpdt_id
        '
        Me.txt_cpdt_id.ForeColor = System.Drawing.Color.Red
        Me.txt_cpdt_id.Location = New System.Drawing.Point(126, 29)
        Me.txt_cpdt_id.Name = "txt_cpdt_id"
        Me.txt_cpdt_id.ReadOnly = True
        Me.txt_cpdt_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_cpdt_id.TabIndex = 38
        Me.txt_cpdt_id.Text = "R"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(45, 34)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(65, 12)
        Me.Label51.TabIndex = 37
        Me.Label51.Text = "Recipe ID:"
        '
        'txt_cpdt_hold
        '
        Me.txt_cpdt_hold.Location = New System.Drawing.Point(61, 145)
        Me.txt_cpdt_hold.Multiline = True
        Me.txt_cpdt_hold.Name = "txt_cpdt_hold"
        Me.txt_cpdt_hold.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_cpdt_hold.Size = New System.Drawing.Size(716, 82)
        Me.txt_cpdt_hold.TabIndex = 36
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(31, 265)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(71, 12)
        Me.Label53.TabIndex = 35
        Me.Label53.Text = "2. 作业事项"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(31, 114)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(107, 12)
        Me.Label54.TabIndex = 34
        Me.Label54.Text = "1.Hold Criteria :"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.combo_cpdt_flowquery)
        Me.GroupBox11.Controls.Add(Me.combo_cpdt_query)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_Query)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_delete)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_disable)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_copy)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_modify)
        Me.GroupBox11.Controls.Add(Me.btn_cpdt_new)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox11.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox11.TabIndex = 23
        Me.GroupBox11.TabStop = False
        '
        'combo_cpdt_flowquery
        '
        Me.combo_cpdt_flowquery.FormattingEnabled = True
        Me.combo_cpdt_flowquery.Location = New System.Drawing.Point(140, 32)
        Me.combo_cpdt_flowquery.Name = "combo_cpdt_flowquery"
        Me.combo_cpdt_flowquery.Size = New System.Drawing.Size(80, 20)
        Me.combo_cpdt_flowquery.TabIndex = 7
        Me.combo_cpdt_flowquery.Text = "ALL"
        '
        'combo_cpdt_query
        '
        Me.combo_cpdt_query.FormattingEnabled = True
        Me.combo_cpdt_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_cpdt_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_cpdt_query.Name = "combo_cpdt_query"
        Me.combo_cpdt_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_cpdt_query.TabIndex = 6
        Me.combo_cpdt_query.Text = "ENABLE"
        '
        'btn_cpdt_Query
        '
        Me.btn_cpdt_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cpdt_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_cpdt_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_cpdt_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_cpdt_Query.Name = "btn_cpdt_Query"
        Me.btn_cpdt_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_Query.TabIndex = 5
        Me.btn_cpdt_Query.UseVisualStyleBackColor = False
        '
        'btn_cpdt_delete
        '
        Me.btn_cpdt_delete.BackColor = System.Drawing.Color.Red
        Me.btn_cpdt_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_cpdt_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_cpdt_delete.Name = "btn_cpdt_delete"
        Me.btn_cpdt_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_delete.TabIndex = 4
        Me.btn_cpdt_delete.UseVisualStyleBackColor = False
        Me.btn_cpdt_delete.Visible = False
        '
        'btn_cpdt_disable
        '
        Me.btn_cpdt_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cpdt_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_cpdt_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_cpdt_disable.Name = "btn_cpdt_disable"
        Me.btn_cpdt_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_disable.TabIndex = 3
        Me.btn_cpdt_disable.UseVisualStyleBackColor = False
        '
        'btn_cpdt_copy
        '
        Me.btn_cpdt_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cpdt_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_cpdt_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_cpdt_copy.Name = "btn_cpdt_copy"
        Me.btn_cpdt_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_copy.TabIndex = 2
        Me.btn_cpdt_copy.UseVisualStyleBackColor = False
        '
        'btn_cpdt_modify
        '
        Me.btn_cpdt_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cpdt_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_cpdt_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_cpdt_modify.Name = "btn_cpdt_modify"
        Me.btn_cpdt_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_modify.TabIndex = 1
        Me.btn_cpdt_modify.UseVisualStyleBackColor = False
        '
        'btn_cpdt_new
        '
        Me.btn_cpdt_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cpdt_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_cpdt_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_cpdt_new.Name = "btn_cpdt_new"
        Me.btn_cpdt_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_cpdt_new.TabIndex = 0
        Me.btn_cpdt_new.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DGV_CPDT)
        Me.GroupBox10.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox10.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox10.TabIndex = 20
        Me.GroupBox10.TabStop = False
        '
        'DGV_CPDT
        '
        Me.DGV_CPDT.AllowUserToAddRows = False
        Me.DGV_CPDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_CPDT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CPDT.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_CPDT.Location = New System.Drawing.Point(3, 17)
        Me.DGV_CPDT.Name = "DGV_CPDT"
        Me.DGV_CPDT.ReadOnly = True
        Me.DGV_CPDT.RowHeadersVisible = False
        Me.DGV_CPDT.RowTemplate.Height = 23
        Me.DGV_CPDT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_CPDT.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_CPDT.TabIndex = 0
        '
        'WIPFS
        '
        Me.WIPFS.Controls.Add(Me.grp_wipfs_para)
        Me.WIPFS.Controls.Add(Me.GroupBox13)
        Me.WIPFS.Controls.Add(Me.GroupBox12)
        Me.WIPFS.Location = New System.Drawing.Point(4, 24)
        Me.WIPFS.Name = "WIPFS"
        Me.WIPFS.Padding = New System.Windows.Forms.Padding(3)
        Me.WIPFS.Size = New System.Drawing.Size(1215, 932)
        Me.WIPFS.TabIndex = 6
        Me.WIPFS.Text = "WIPFS"
        Me.WIPFS.UseVisualStyleBackColor = True
        '
        'grp_wipfs_para
        '
        Me.grp_wipfs_para.Controls.Add(Me.Panel7)
        Me.grp_wipfs_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_wipfs_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_wipfs_para.Name = "grp_wipfs_para"
        Me.grp_wipfs_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_wipfs_para.TabIndex = 21
        Me.grp_wipfs_para.TabStop = False
        Me.grp_wipfs_para.Text = "Parameters"
        Me.grp_wipfs_para.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.combo_mappingflow)
        Me.Panel7.Controls.Add(Me.btn_wipfs_exit)
        Me.Panel7.Controls.Add(Me.btn_wipfs_confirm)
        Me.Panel7.Controls.Add(Me.txt_wipfs_lot)
        Me.Panel7.Controls.Add(Me.Label47)
        Me.Panel7.Controls.Add(Me.combo_wipfs_type)
        Me.Panel7.Controls.Add(Me.Label52)
        Me.Panel7.Controls.Add(Me.txt_wipfs_id)
        Me.Panel7.Controls.Add(Me.Label55)
        Me.Panel7.Controls.Add(Me.txt_wipfs_operation)
        Me.Panel7.Controls.Add(Me.Label57)
        Me.Panel7.Controls.Add(Me.Label58)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(3, 17)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1203, 636)
        Me.Panel7.TabIndex = 30
        '
        'combo_mappingflow
        '
        Me.combo_mappingflow.FormattingEnabled = True
        Me.combo_mappingflow.Items.AddRange(New Object() {"CP1", "CP2", "CP3", "CP4", "MERGE"})
        Me.combo_mappingflow.Location = New System.Drawing.Point(139, 151)
        Me.combo_mappingflow.Name = "combo_mappingflow"
        Me.combo_mappingflow.Size = New System.Drawing.Size(162, 20)
        Me.combo_mappingflow.TabIndex = 41
        '
        'btn_wipfs_exit
        '
        Me.btn_wipfs_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_wipfs_exit.Location = New System.Drawing.Point(491, 494)
        Me.btn_wipfs_exit.Name = "btn_wipfs_exit"
        Me.btn_wipfs_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_exit.TabIndex = 40
        Me.btn_wipfs_exit.UseVisualStyleBackColor = True
        '
        'btn_wipfs_confirm
        '
        Me.btn_wipfs_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_wipfs_confirm.Location = New System.Drawing.Point(115, 494)
        Me.btn_wipfs_confirm.Name = "btn_wipfs_confirm"
        Me.btn_wipfs_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_confirm.TabIndex = 39
        Me.btn_wipfs_confirm.UseVisualStyleBackColor = True
        '
        'txt_wipfs_lot
        '
        Me.txt_wipfs_lot.Location = New System.Drawing.Point(423, 25)
        Me.txt_wipfs_lot.Multiline = True
        Me.txt_wipfs_lot.Name = "txt_wipfs_lot"
        Me.txt_wipfs_lot.ReadOnly = True
        Me.txt_wipfs_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_wipfs_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_wipfs_lot.TabIndex = 38
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(379, 30)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(35, 12)
        Me.Label47.TabIndex = 37
        Me.Label47.Text = "LOT :"
        '
        'combo_wipfs_type
        '
        Me.combo_wipfs_type.FormattingEnabled = True
        Me.combo_wipfs_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_wipfs_type.Location = New System.Drawing.Point(139, 59)
        Me.combo_wipfs_type.Name = "combo_wipfs_type"
        Me.combo_wipfs_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_wipfs_type.TabIndex = 36
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(46, 59)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(77, 12)
        Me.Label52.TabIndex = 35
        Me.Label52.Text = "Recipe Type:"
        '
        'txt_wipfs_id
        '
        Me.txt_wipfs_id.ForeColor = System.Drawing.Color.Red
        Me.txt_wipfs_id.Location = New System.Drawing.Point(139, 27)
        Me.txt_wipfs_id.Name = "txt_wipfs_id"
        Me.txt_wipfs_id.ReadOnly = True
        Me.txt_wipfs_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_wipfs_id.TabIndex = 34
        Me.txt_wipfs_id.Text = "R"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(58, 32)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(65, 12)
        Me.Label55.TabIndex = 33
        Me.Label55.Text = "Recipe ID:"
        '
        'txt_wipfs_operation
        '
        Me.txt_wipfs_operation.Location = New System.Drawing.Point(46, 261)
        Me.txt_wipfs_operation.Multiline = True
        Me.txt_wipfs_operation.Name = "txt_wipfs_operation"
        Me.txt_wipfs_operation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_wipfs_operation.Size = New System.Drawing.Size(716, 82)
        Me.txt_wipfs_operation.TabIndex = 32
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(44, 236)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(89, 12)
        Me.Label57.TabIndex = 31
        Me.Label57.Text = "2. Operation :"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(44, 112)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(107, 12)
        Me.Label58.TabIndex = 30
        Me.Label58.Text = "1. Mapping Flow :"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.combo_wipfs_query)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_Query)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_delete)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_disable)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_copy)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_modify)
        Me.GroupBox13.Controls.Add(Me.btn_wipfs_new)
        Me.GroupBox13.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox13.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox13.TabIndex = 20
        Me.GroupBox13.TabStop = False
        '
        'combo_wipfs_query
        '
        Me.combo_wipfs_query.FormattingEnabled = True
        Me.combo_wipfs_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_wipfs_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_wipfs_query.Name = "combo_wipfs_query"
        Me.combo_wipfs_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_wipfs_query.TabIndex = 6
        Me.combo_wipfs_query.Text = "ENABLE"
        '
        'btn_wipfs_Query
        '
        Me.btn_wipfs_Query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_wipfs_Query.ForeColor = System.Drawing.Color.Black
        Me.btn_wipfs_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_wipfs_Query.Location = New System.Drawing.Point(330, 20)
        Me.btn_wipfs_Query.Name = "btn_wipfs_Query"
        Me.btn_wipfs_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_Query.TabIndex = 5
        Me.btn_wipfs_Query.UseVisualStyleBackColor = False
        '
        'btn_wipfs_delete
        '
        Me.btn_wipfs_delete.BackColor = System.Drawing.Color.Red
        Me.btn_wipfs_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_wipfs_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_wipfs_delete.Name = "btn_wipfs_delete"
        Me.btn_wipfs_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_delete.TabIndex = 4
        Me.btn_wipfs_delete.UseVisualStyleBackColor = False
        Me.btn_wipfs_delete.Visible = False
        '
        'btn_wipfs_disable
        '
        Me.btn_wipfs_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_wipfs_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_wipfs_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_wipfs_disable.Name = "btn_wipfs_disable"
        Me.btn_wipfs_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_disable.TabIndex = 3
        Me.btn_wipfs_disable.UseVisualStyleBackColor = False
        '
        'btn_wipfs_copy
        '
        Me.btn_wipfs_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_wipfs_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_wipfs_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_wipfs_copy.Name = "btn_wipfs_copy"
        Me.btn_wipfs_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_copy.TabIndex = 2
        Me.btn_wipfs_copy.UseVisualStyleBackColor = False
        '
        'btn_wipfs_modify
        '
        Me.btn_wipfs_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_wipfs_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_wipfs_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_wipfs_modify.Name = "btn_wipfs_modify"
        Me.btn_wipfs_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_modify.TabIndex = 1
        Me.btn_wipfs_modify.UseVisualStyleBackColor = False
        '
        'btn_wipfs_new
        '
        Me.btn_wipfs_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_wipfs_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_wipfs_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_wipfs_new.Name = "btn_wipfs_new"
        Me.btn_wipfs_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_wipfs_new.TabIndex = 0
        Me.btn_wipfs_new.UseVisualStyleBackColor = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.DGV_WIPFS)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox12.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox12.TabIndex = 17
        Me.GroupBox12.TabStop = False
        '
        'DGV_WIPFS
        '
        Me.DGV_WIPFS.AllowUserToAddRows = False
        Me.DGV_WIPFS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_WIPFS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_WIPFS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_WIPFS.Location = New System.Drawing.Point(3, 17)
        Me.DGV_WIPFS.Name = "DGV_WIPFS"
        Me.DGV_WIPFS.ReadOnly = True
        Me.DGV_WIPFS.RowHeadersVisible = False
        Me.DGV_WIPFS.RowTemplate.Height = 23
        Me.DGV_WIPFS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_WIPFS.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_WIPFS.TabIndex = 0
        '
        'FQC
        '
        Me.FQC.Controls.Add(Me.grp_FQC_para)
        Me.FQC.Controls.Add(Me.GroupBox8)
        Me.FQC.Controls.Add(Me.GroupBox7)
        Me.FQC.Location = New System.Drawing.Point(4, 24)
        Me.FQC.Name = "FQC"
        Me.FQC.Padding = New System.Windows.Forms.Padding(3)
        Me.FQC.Size = New System.Drawing.Size(1215, 932)
        Me.FQC.TabIndex = 2
        Me.FQC.Text = "FQC"
        Me.FQC.UseVisualStyleBackColor = True
        '
        'grp_FQC_para
        '
        Me.grp_FQC_para.Controls.Add(Me.Panel8)
        Me.grp_FQC_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_FQC_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_FQC_para.Name = "grp_FQC_para"
        Me.grp_FQC_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_FQC_para.TabIndex = 21
        Me.grp_FQC_para.TabStop = False
        Me.grp_FQC_para.Text = "Parameters"
        Me.grp_FQC_para.Visible = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txt_FQC_Probemark)
        Me.Panel8.Controls.Add(Me.Label19)
        Me.Panel8.Controls.Add(Me.btn_FQC_exit)
        Me.Panel8.Controls.Add(Me.btn_FQC_confirm)
        Me.Panel8.Controls.Add(Me.txt_FQC_lot)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.combo_FQC_type)
        Me.Panel8.Controls.Add(Me.Label8)
        Me.Panel8.Controls.Add(Me.txt_FQC_ID)
        Me.Panel8.Controls.Add(Me.Label9)
        Me.Panel8.Controls.Add(Me.txt_FQC_WI)
        Me.Panel8.Controls.Add(Me.Label13)
        Me.Panel8.Controls.Add(Me.txt_FQC_InspectionArea)
        Me.Panel8.Controls.Add(Me.Label14)
        Me.Panel8.Controls.Add(Me.txt_FQC_SamplePlan)
        Me.Panel8.Controls.Add(Me.Label15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(3, 17)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1203, 636)
        Me.Panel8.TabIndex = 31
        '
        'txt_FQC_Probemark
        '
        Me.txt_FQC_Probemark.Location = New System.Drawing.Point(61, 364)
        Me.txt_FQC_Probemark.Multiline = True
        Me.txt_FQC_Probemark.Name = "txt_FQC_Probemark"
        Me.txt_FQC_Probemark.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_Probemark.Size = New System.Drawing.Size(716, 49)
        Me.txt_FQC_Probemark.TabIndex = 46
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(59, 337)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(137, 12)
        Me.Label19.TabIndex = 45
        Me.Label19.Text = "3. Probe Mark 针痕限制"
        '
        'btn_FQC_exit
        '
        Me.btn_FQC_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_FQC_exit.Location = New System.Drawing.Point(494, 556)
        Me.btn_FQC_exit.Name = "btn_FQC_exit"
        Me.btn_FQC_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_exit.TabIndex = 44
        Me.btn_FQC_exit.UseVisualStyleBackColor = True
        '
        'btn_FQC_confirm
        '
        Me.btn_FQC_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_FQC_confirm.Location = New System.Drawing.Point(191, 556)
        Me.btn_FQC_confirm.Name = "btn_FQC_confirm"
        Me.btn_FQC_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_confirm.TabIndex = 43
        Me.btn_FQC_confirm.UseVisualStyleBackColor = True
        '
        'txt_FQC_lot
        '
        Me.txt_FQC_lot.Location = New System.Drawing.Point(436, 23)
        Me.txt_FQC_lot.Multiline = True
        Me.txt_FQC_lot.Name = "txt_FQC_lot"
        Me.txt_FQC_lot.ReadOnly = True
        Me.txt_FQC_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_FQC_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_FQC_lot.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(392, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 12)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "LOT :"
        '
        'combo_FQC_type
        '
        Me.combo_FQC_type.FormattingEnabled = True
        Me.combo_FQC_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_FQC_type.Location = New System.Drawing.Point(152, 57)
        Me.combo_FQC_type.Name = "combo_FQC_type"
        Me.combo_FQC_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_FQC_type.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Recipe Type:"
        '
        'txt_FQC_ID
        '
        Me.txt_FQC_ID.ForeColor = System.Drawing.Color.Red
        Me.txt_FQC_ID.Location = New System.Drawing.Point(152, 25)
        Me.txt_FQC_ID.Name = "txt_FQC_ID"
        Me.txt_FQC_ID.ReadOnly = True
        Me.txt_FQC_ID.Size = New System.Drawing.Size(162, 21)
        Me.txt_FQC_ID.TabIndex = 38
        Me.txt_FQC_ID.Text = "R"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(71, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 12)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Recipe ID:"
        '
        'txt_FQC_WI
        '
        Me.txt_FQC_WI.Location = New System.Drawing.Point(59, 457)
        Me.txt_FQC_WI.Multiline = True
        Me.txt_FQC_WI.Name = "txt_FQC_WI"
        Me.txt_FQC_WI.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_WI.Size = New System.Drawing.Size(716, 69)
        Me.txt_FQC_WI.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(57, 433)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(167, 12)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "4. WorkInstruction 作业规范"
        '
        'txt_FQC_InspectionArea
        '
        Me.txt_FQC_InspectionArea.Location = New System.Drawing.Point(59, 259)
        Me.txt_FQC_InspectionArea.Multiline = True
        Me.txt_FQC_InspectionArea.Name = "txt_FQC_InspectionArea"
        Me.txt_FQC_InspectionArea.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_InspectionArea.Size = New System.Drawing.Size(716, 61)
        Me.txt_FQC_InspectionArea.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(57, 234)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(191, 12)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "2. FQC Inspection Area 检验区域"
        '
        'txt_FQC_SamplePlan
        '
        Me.txt_FQC_SamplePlan.Location = New System.Drawing.Point(59, 134)
        Me.txt_FQC_SamplePlan.Multiline = True
        Me.txt_FQC_SamplePlan.Name = "txt_FQC_SamplePlan"
        Me.txt_FQC_SamplePlan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_FQC_SamplePlan.Size = New System.Drawing.Size(716, 72)
        Me.txt_FQC_SamplePlan.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(57, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(179, 12)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "1. FQC Sampling Plan 抽样计划"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.combo_FQC_query)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_query)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_delete)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_disable)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_copy)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_modify)
        Me.GroupBox8.Controls.Add(Me.btn_FQC_new)
        Me.GroupBox8.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox8.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox8.TabIndex = 20
        Me.GroupBox8.TabStop = False
        '
        'combo_FQC_query
        '
        Me.combo_FQC_query.FormattingEnabled = True
        Me.combo_FQC_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_FQC_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_FQC_query.Name = "combo_FQC_query"
        Me.combo_FQC_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_FQC_query.TabIndex = 6
        Me.combo_FQC_query.Text = "ENABLE"
        '
        'btn_FQC_query
        '
        Me.btn_FQC_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_query.ForeColor = System.Drawing.Color.Black
        Me.btn_FQC_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_FQC_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_FQC_query.Name = "btn_FQC_query"
        Me.btn_FQC_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_query.TabIndex = 5
        Me.btn_FQC_query.UseVisualStyleBackColor = False
        '
        'btn_FQC_delete
        '
        Me.btn_FQC_delete.BackColor = System.Drawing.Color.Red
        Me.btn_FQC_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_FQC_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_FQC_delete.Name = "btn_FQC_delete"
        Me.btn_FQC_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_delete.TabIndex = 4
        Me.btn_FQC_delete.UseVisualStyleBackColor = False
        Me.btn_FQC_delete.Visible = False
        '
        'btn_FQC_disable
        '
        Me.btn_FQC_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_FQC_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_FQC_disable.Name = "btn_FQC_disable"
        Me.btn_FQC_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_disable.TabIndex = 3
        Me.btn_FQC_disable.UseVisualStyleBackColor = False
        '
        'btn_FQC_copy
        '
        Me.btn_FQC_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_FQC_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_FQC_copy.Name = "btn_FQC_copy"
        Me.btn_FQC_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_copy.TabIndex = 2
        Me.btn_FQC_copy.UseVisualStyleBackColor = False
        '
        'btn_FQC_modify
        '
        Me.btn_FQC_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_FQC_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_FQC_modify.Name = "btn_FQC_modify"
        Me.btn_FQC_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_modify.TabIndex = 1
        Me.btn_FQC_modify.UseVisualStyleBackColor = False
        '
        'btn_FQC_new
        '
        Me.btn_FQC_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_FQC_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_FQC_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_FQC_new.Name = "btn_FQC_new"
        Me.btn_FQC_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_FQC_new.TabIndex = 0
        Me.btn_FQC_new.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DGV_FQC)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox7.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox7.TabIndex = 17
        Me.GroupBox7.TabStop = False
        '
        'DGV_FQC
        '
        Me.DGV_FQC.AllowUserToAddRows = False
        Me.DGV_FQC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_FQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_FQC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_FQC.Location = New System.Drawing.Point(3, 17)
        Me.DGV_FQC.Name = "DGV_FQC"
        Me.DGV_FQC.ReadOnly = True
        Me.DGV_FQC.RowHeadersVisible = False
        Me.DGV_FQC.RowTemplate.Height = 23
        Me.DGV_FQC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_FQC.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_FQC.TabIndex = 0
        '
        'PACK
        '
        Me.PACK.Controls.Add(Me.grp_pack_para)
        Me.PACK.Controls.Add(Me.GroupBox15)
        Me.PACK.Controls.Add(Me.GroupBox14)
        Me.PACK.Location = New System.Drawing.Point(4, 24)
        Me.PACK.Name = "PACK"
        Me.PACK.Padding = New System.Windows.Forms.Padding(3)
        Me.PACK.Size = New System.Drawing.Size(1215, 932)
        Me.PACK.TabIndex = 3
        Me.PACK.Text = "PACK"
        Me.PACK.UseVisualStyleBackColor = True
        '
        'grp_pack_para
        '
        Me.grp_pack_para.Controls.Add(Me.Panel9)
        Me.grp_pack_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_pack_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_pack_para.Name = "grp_pack_para"
        Me.grp_pack_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_pack_para.TabIndex = 24
        Me.grp_pack_para.TabStop = False
        Me.grp_pack_para.Text = "Parameters"
        Me.grp_pack_para.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txt_pack_recipe)
        Me.Panel9.Controls.Add(Me.Label68)
        Me.Panel9.Controls.Add(Me.btn_pack_exit)
        Me.Panel9.Controls.Add(Me.btn_pack_confirm)
        Me.Panel9.Controls.Add(Me.txt_pack_lot)
        Me.Panel9.Controls.Add(Me.Label56)
        Me.Panel9.Controls.Add(Me.combo_pack_type)
        Me.Panel9.Controls.Add(Me.Label59)
        Me.Panel9.Controls.Add(Me.txt_pack_id)
        Me.Panel9.Controls.Add(Me.Label60)
        Me.Panel9.Controls.Add(Me.txt_pack_operation)
        Me.Panel9.Controls.Add(Me.Label62)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(3, 17)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1203, 636)
        Me.Panel9.TabIndex = 29
        '
        'txt_pack_recipe
        '
        Me.txt_pack_recipe.Location = New System.Drawing.Point(67, 168)
        Me.txt_pack_recipe.Name = "txt_pack_recipe"
        Me.txt_pack_recipe.Size = New System.Drawing.Size(709, 21)
        Me.txt_pack_recipe.TabIndex = 54
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(56, 144)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(71, 12)
        Me.Label68.TabIndex = 53
        Me.Label68.Text = "1. Recipe :"
        '
        'btn_pack_exit
        '
        Me.btn_pack_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_pack_exit.Location = New System.Drawing.Point(503, 513)
        Me.btn_pack_exit.Name = "btn_pack_exit"
        Me.btn_pack_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_exit.TabIndex = 38
        Me.btn_pack_exit.UseVisualStyleBackColor = True
        '
        'btn_pack_confirm
        '
        Me.btn_pack_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_pack_confirm.Location = New System.Drawing.Point(127, 513)
        Me.btn_pack_confirm.Name = "btn_pack_confirm"
        Me.btn_pack_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_confirm.TabIndex = 37
        Me.btn_pack_confirm.UseVisualStyleBackColor = True
        '
        'txt_pack_lot
        '
        Me.txt_pack_lot.Location = New System.Drawing.Point(435, 44)
        Me.txt_pack_lot.Multiline = True
        Me.txt_pack_lot.Name = "txt_pack_lot"
        Me.txt_pack_lot.ReadOnly = True
        Me.txt_pack_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_pack_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_pack_lot.TabIndex = 36
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(391, 49)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(35, 12)
        Me.Label56.TabIndex = 35
        Me.Label56.Text = "LOT :"
        '
        'combo_pack_type
        '
        Me.combo_pack_type.FormattingEnabled = True
        Me.combo_pack_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_pack_type.Location = New System.Drawing.Point(151, 78)
        Me.combo_pack_type.Name = "combo_pack_type"
        Me.combo_pack_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_pack_type.TabIndex = 34
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(58, 78)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(77, 12)
        Me.Label59.TabIndex = 33
        Me.Label59.Text = "Recipe Type:"
        '
        'txt_pack_id
        '
        Me.txt_pack_id.ForeColor = System.Drawing.Color.Red
        Me.txt_pack_id.Location = New System.Drawing.Point(151, 46)
        Me.txt_pack_id.Name = "txt_pack_id"
        Me.txt_pack_id.ReadOnly = True
        Me.txt_pack_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_pack_id.TabIndex = 32
        Me.txt_pack_id.Text = "R"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(70, 51)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(65, 12)
        Me.Label60.TabIndex = 31
        Me.Label60.Text = "Recipe ID:"
        '
        'txt_pack_operation
        '
        Me.txt_pack_operation.Location = New System.Drawing.Point(60, 241)
        Me.txt_pack_operation.Multiline = True
        Me.txt_pack_operation.Name = "txt_pack_operation"
        Me.txt_pack_operation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_pack_operation.Size = New System.Drawing.Size(716, 82)
        Me.txt_pack_operation.TabIndex = 30
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(56, 203)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(89, 12)
        Me.Label62.TabIndex = 29
        Me.Label62.Text = "2. Operation :"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.combo_pack_query)
        Me.GroupBox15.Controls.Add(Me.btn_pack_query)
        Me.GroupBox15.Controls.Add(Me.btn_pack_delete)
        Me.GroupBox15.Controls.Add(Me.btn_pack_disable)
        Me.GroupBox15.Controls.Add(Me.btn_pack_copy)
        Me.GroupBox15.Controls.Add(Me.btn_pack_modify)
        Me.GroupBox15.Controls.Add(Me.btn_pack_new)
        Me.GroupBox15.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox15.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox15.TabIndex = 23
        Me.GroupBox15.TabStop = False
        '
        'combo_pack_query
        '
        Me.combo_pack_query.FormattingEnabled = True
        Me.combo_pack_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_pack_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_pack_query.Name = "combo_pack_query"
        Me.combo_pack_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_pack_query.TabIndex = 6
        Me.combo_pack_query.Text = "ENABLE"
        '
        'btn_pack_query
        '
        Me.btn_pack_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_query.ForeColor = System.Drawing.Color.Black
        Me.btn_pack_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_pack_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_pack_query.Name = "btn_pack_query"
        Me.btn_pack_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_query.TabIndex = 5
        Me.btn_pack_query.UseVisualStyleBackColor = False
        '
        'btn_pack_delete
        '
        Me.btn_pack_delete.BackColor = System.Drawing.Color.Red
        Me.btn_pack_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_pack_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_pack_delete.Name = "btn_pack_delete"
        Me.btn_pack_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_delete.TabIndex = 4
        Me.btn_pack_delete.UseVisualStyleBackColor = False
        Me.btn_pack_delete.Visible = False
        '
        'btn_pack_disable
        '
        Me.btn_pack_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_pack_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_pack_disable.Name = "btn_pack_disable"
        Me.btn_pack_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_disable.TabIndex = 3
        Me.btn_pack_disable.UseVisualStyleBackColor = False
        '
        'btn_pack_copy
        '
        Me.btn_pack_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_pack_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_pack_copy.Name = "btn_pack_copy"
        Me.btn_pack_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_copy.TabIndex = 2
        Me.btn_pack_copy.UseVisualStyleBackColor = False
        '
        'btn_pack_modify
        '
        Me.btn_pack_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_pack_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_pack_modify.Name = "btn_pack_modify"
        Me.btn_pack_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_modify.TabIndex = 1
        Me.btn_pack_modify.UseVisualStyleBackColor = False
        '
        'btn_pack_new
        '
        Me.btn_pack_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_pack_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_pack_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_pack_new.Name = "btn_pack_new"
        Me.btn_pack_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_pack_new.TabIndex = 0
        Me.btn_pack_new.UseVisualStyleBackColor = False
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.DGV_PACK)
        Me.GroupBox14.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox14.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox14.TabIndex = 20
        Me.GroupBox14.TabStop = False
        '
        'DGV_PACK
        '
        Me.DGV_PACK.AllowUserToAddRows = False
        Me.DGV_PACK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_PACK.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_PACK.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_PACK.Location = New System.Drawing.Point(3, 17)
        Me.DGV_PACK.Name = "DGV_PACK"
        Me.DGV_PACK.ReadOnly = True
        Me.DGV_PACK.RowHeadersVisible = False
        Me.DGV_PACK.RowTemplate.Height = 23
        Me.DGV_PACK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_PACK.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_PACK.TabIndex = 0
        '
        'SHIP
        '
        Me.SHIP.Controls.Add(Me.grp_ship_para)
        Me.SHIP.Controls.Add(Me.GroupBox17)
        Me.SHIP.Controls.Add(Me.GroupBox16)
        Me.SHIP.Location = New System.Drawing.Point(4, 24)
        Me.SHIP.Name = "SHIP"
        Me.SHIP.Padding = New System.Windows.Forms.Padding(3)
        Me.SHIP.Size = New System.Drawing.Size(1215, 932)
        Me.SHIP.TabIndex = 7
        Me.SHIP.Text = "SHIP"
        Me.SHIP.UseVisualStyleBackColor = True
        '
        'grp_ship_para
        '
        Me.grp_ship_para.Controls.Add(Me.btn_ship_exit)
        Me.grp_ship_para.Controls.Add(Me.btn_ship_confirm)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_lot)
        Me.grp_ship_para.Controls.Add(Me.Label61)
        Me.grp_ship_para.Controls.Add(Me.combo_ship_type)
        Me.grp_ship_para.Controls.Add(Me.Label63)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_id)
        Me.grp_ship_para.Controls.Add(Me.Label64)
        Me.grp_ship_para.Controls.Add(Me.txt_ship_operation)
        Me.grp_ship_para.Controls.Add(Me.Label65)
        Me.grp_ship_para.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grp_ship_para.Location = New System.Drawing.Point(3, 273)
        Me.grp_ship_para.Name = "grp_ship_para"
        Me.grp_ship_para.Size = New System.Drawing.Size(1209, 656)
        Me.grp_ship_para.TabIndex = 27
        Me.grp_ship_para.TabStop = False
        Me.grp_ship_para.Text = "Parameters"
        Me.grp_ship_para.Visible = False
        '
        'btn_ship_exit
        '
        Me.btn_ship_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_ship_exit.Location = New System.Drawing.Point(481, 496)
        Me.btn_ship_exit.Name = "btn_ship_exit"
        Me.btn_ship_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_exit.TabIndex = 28
        Me.btn_ship_exit.UseVisualStyleBackColor = True
        '
        'btn_ship_confirm
        '
        Me.btn_ship_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_ship_confirm.Location = New System.Drawing.Point(105, 496)
        Me.btn_ship_confirm.Name = "btn_ship_confirm"
        Me.btn_ship_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_confirm.TabIndex = 27
        Me.btn_ship_confirm.UseVisualStyleBackColor = True
        '
        'txt_ship_lot
        '
        Me.txt_ship_lot.Location = New System.Drawing.Point(413, 27)
        Me.txt_ship_lot.Multiline = True
        Me.txt_ship_lot.Name = "txt_ship_lot"
        Me.txt_ship_lot.ReadOnly = True
        Me.txt_ship_lot.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_ship_lot.Size = New System.Drawing.Size(195, 54)
        Me.txt_ship_lot.TabIndex = 26
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(369, 32)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(35, 12)
        Me.Label61.TabIndex = 25
        Me.Label61.Text = "LOT :"
        '
        'combo_ship_type
        '
        Me.combo_ship_type.FormattingEnabled = True
        Me.combo_ship_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_ship_type.Location = New System.Drawing.Point(129, 61)
        Me.combo_ship_type.Name = "combo_ship_type"
        Me.combo_ship_type.Size = New System.Drawing.Size(162, 20)
        Me.combo_ship_type.TabIndex = 24
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(36, 61)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(77, 12)
        Me.Label63.TabIndex = 23
        Me.Label63.Text = "Recipe Type:"
        '
        'txt_ship_id
        '
        Me.txt_ship_id.ForeColor = System.Drawing.Color.Red
        Me.txt_ship_id.Location = New System.Drawing.Point(129, 29)
        Me.txt_ship_id.Name = "txt_ship_id"
        Me.txt_ship_id.ReadOnly = True
        Me.txt_ship_id.Size = New System.Drawing.Size(162, 21)
        Me.txt_ship_id.TabIndex = 22
        Me.txt_ship_id.Text = "R"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(48, 34)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(65, 12)
        Me.Label64.TabIndex = 21
        Me.Label64.Text = "Recipe ID:"
        '
        'txt_ship_operation
        '
        Me.txt_ship_operation.Location = New System.Drawing.Point(38, 152)
        Me.txt_ship_operation.Multiline = True
        Me.txt_ship_operation.Name = "txt_ship_operation"
        Me.txt_ship_operation.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_ship_operation.Size = New System.Drawing.Size(716, 82)
        Me.txt_ship_operation.TabIndex = 18
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(34, 114)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(89, 12)
        Me.Label65.TabIndex = 15
        Me.Label65.Text = "1. Operation :"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.combo_ship_query)
        Me.GroupBox17.Controls.Add(Me.btn_ship_query)
        Me.GroupBox17.Controls.Add(Me.btn_ship_delete)
        Me.GroupBox17.Controls.Add(Me.btn_ship_disable)
        Me.GroupBox17.Controls.Add(Me.btn_ship_copy)
        Me.GroupBox17.Controls.Add(Me.btn_ship_modify)
        Me.GroupBox17.Controls.Add(Me.btn_ship_new)
        Me.GroupBox17.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox17.Location = New System.Drawing.Point(3, 203)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(1209, 70)
        Me.GroupBox17.TabIndex = 26
        Me.GroupBox17.TabStop = False
        '
        'combo_ship_query
        '
        Me.combo_ship_query.FormattingEnabled = True
        Me.combo_ship_query.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.combo_ship_query.Location = New System.Drawing.Point(20, 32)
        Me.combo_ship_query.Name = "combo_ship_query"
        Me.combo_ship_query.Size = New System.Drawing.Size(80, 20)
        Me.combo_ship_query.TabIndex = 6
        Me.combo_ship_query.Text = "ENABLE"
        '
        'btn_ship_query
        '
        Me.btn_ship_query.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_query.ForeColor = System.Drawing.Color.Black
        Me.btn_ship_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_ship_query.Location = New System.Drawing.Point(330, 20)
        Me.btn_ship_query.Name = "btn_ship_query"
        Me.btn_ship_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_query.TabIndex = 5
        Me.btn_ship_query.UseVisualStyleBackColor = False
        '
        'btn_ship_delete
        '
        Me.btn_ship_delete.BackColor = System.Drawing.Color.Red
        Me.btn_ship_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_ship_delete.Location = New System.Drawing.Point(960, 20)
        Me.btn_ship_delete.Name = "btn_ship_delete"
        Me.btn_ship_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_delete.TabIndex = 4
        Me.btn_ship_delete.UseVisualStyleBackColor = False
        Me.btn_ship_delete.Visible = False
        '
        'btn_ship_disable
        '
        Me.btn_ship_disable.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_disable.Image = Global.CPS.My.Resources.Resources.disable
        Me.btn_ship_disable.Location = New System.Drawing.Point(830, 20)
        Me.btn_ship_disable.Name = "btn_ship_disable"
        Me.btn_ship_disable.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_disable.TabIndex = 3
        Me.btn_ship_disable.UseVisualStyleBackColor = False
        '
        'btn_ship_copy
        '
        Me.btn_ship_copy.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_copy.Image = Global.CPS.My.Resources.Resources.copy
        Me.btn_ship_copy.Location = New System.Drawing.Point(700, 20)
        Me.btn_ship_copy.Name = "btn_ship_copy"
        Me.btn_ship_copy.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_copy.TabIndex = 2
        Me.btn_ship_copy.UseVisualStyleBackColor = False
        '
        'btn_ship_modify
        '
        Me.btn_ship_modify.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_modify.Image = Global.CPS.My.Resources.Resources.read
        Me.btn_ship_modify.Location = New System.Drawing.Point(570, 20)
        Me.btn_ship_modify.Name = "btn_ship_modify"
        Me.btn_ship_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_modify.TabIndex = 1
        Me.btn_ship_modify.UseVisualStyleBackColor = False
        '
        'btn_ship_new
        '
        Me.btn_ship_new.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ship_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_ship_new.Location = New System.Drawing.Point(450, 20)
        Me.btn_ship_new.Name = "btn_ship_new"
        Me.btn_ship_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_ship_new.TabIndex = 0
        Me.btn_ship_new.UseVisualStyleBackColor = False
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.DGV_SHIP)
        Me.GroupBox16.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox16.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(1209, 200)
        Me.GroupBox16.TabIndex = 23
        Me.GroupBox16.TabStop = False
        '
        'DGV_SHIP
        '
        Me.DGV_SHIP.AllowUserToAddRows = False
        Me.DGV_SHIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_SHIP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_SHIP.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_SHIP.Location = New System.Drawing.Point(3, 17)
        Me.DGV_SHIP.Name = "DGV_SHIP"
        Me.DGV_SHIP.ReadOnly = True
        Me.DGV_SHIP.RowHeadersVisible = False
        Me.DGV_SHIP.RowTemplate.Height = 23
        Me.DGV_SHIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_SHIP.Size = New System.Drawing.Size(1203, 180)
        Me.DGV_SHIP.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(3, 17)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1069, 205)
        Me.DataGridView1.TabIndex = 0
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(336, 23)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 37)
        Me.Button6.TabIndex = 0
        Me.Button6.Text = "NEW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(486, 23)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 37)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "MODIFY"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(635, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 37)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "COPY"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(780, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 37)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "DISABLE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(932, 23)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "DELETE"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(214, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "QUERY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ALL", "ENABLE"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(62, 20)
        Me.ComboBox1.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 610)
        Me.Panel1.TabIndex = 0
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(69, -67)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(477, 572)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(656, 16)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(502, 572)
        Me.RichTextBox2.TabIndex = 1
        Me.RichTextBox2.Text = ""
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(119, 548)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(259, 188)
        Me.RichTextBox3.TabIndex = 2
        Me.RichTextBox3.Text = ""
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(602, 840)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 49)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'frmStepset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 960)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmStepset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StepDefineForm"
        Me.TabControl1.ResumeLayout(False)
        Me.IQC.ResumeLayout(False)
        Me.grp_IQC_para.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DGV_IQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CPs.ResumeLayout(False)
        Me.grp_CP_para.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV_CP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BAKEs.ResumeLayout(False)
        Me.grp_bake_para.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DGV_BAKE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CPsDT.ResumeLayout(False)
        Me.grp_cpdt_para.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DGV_CPDT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WIPFS.ResumeLayout(False)
        Me.grp_wipfs_para.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DGV_WIPFS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FQC.ResumeLayout(False)
        Me.grp_FQC_para.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.DGV_FQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PACK.ResumeLayout(False)
        Me.grp_pack_para.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.DGV_PACK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SHIP.ResumeLayout(False)
        Me.grp_ship_para.ResumeLayout(False)
        Me.grp_ship_para.PerformLayout()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        CType(Me.DGV_SHIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents CPs As TabPage
    Friend WithEvents FQC As TabPage
    Friend WithEvents IQC As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PACK As TabPage
    Friend WithEvents DGV_IQC As DataGridView
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DGV_FQC As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGV_CP As DataGridView
    Friend WithEvents BAKEs As TabPage
    Friend WithEvents CPsDT As TabPage
    Friend WithEvents WIPFS As TabPage
    Friend WithEvents SHIP As TabPage
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DGV_BAKE As DataGridView
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents DGV_CPDT As DataGridView
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents DGV_WIPFS As DataGridView
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents DGV_PACK As DataGridView
    Friend WithEvents GroupBox16 As GroupBox
    Friend WithEvents DGV_SHIP As DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents grp_IQC_para As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents combo_IQC_query As ComboBox
    Friend WithEvents btn_IQC_Query As Button
    Friend WithEvents btn_IQC_delete As Button
    Friend WithEvents btn_IQC_disable As Button
    Friend WithEvents btn_iqc_copy As Button
    Friend WithEvents btn_IQC_modify As Button
    Friend WithEvents btn_IQC_new As Button
    Friend WithEvents btn_IQC_cancel As Button
    Friend WithEvents btn_IQC_confirm As Button
    Friend WithEvents txt_IQC_lot As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents combo_IQC_type As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_IQC_id As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_IQC_WI As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_IQC_InspectionArea As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_IQC_SamplePlan As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents combo_cp_flowquery As ComboBox
    Friend WithEvents combo_cp_enable As ComboBox
    Friend WithEvents btn_CP_Query As Button
    Friend WithEvents btn_CP_delete As Button
    Friend WithEvents btn_CP_disable As Button
    Friend WithEvents btn_CP_copy As Button
    Friend WithEvents btn_CP_modify As Button
    Friend WithEvents btn_CP_new As Button
    Friend WithEvents grp_CP_para As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_download As Button
    Friend WithEvents btn_upload As Button
    Friend WithEvents txt_attachpic As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents txt_cp_proberoperation As TextBox
    Friend WithEvents txt_cp_remark As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txt_cp_holdtiming As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_cp_testeroperation As TextBox
    Friend WithEvents txt_cp_updown As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_cp_cleanfreq As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents combo_cp_sheetmaterial As ComboBox
    Friend WithEvents Label32 As Label
    Friend WithEvents combo_cp_cleanmethod As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_cp_od As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_cp_dc As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_cp_setupfile As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents combo_cp_prober As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_cp_temp As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents txt_cp_pib As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_cp_probecard As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_cp_pgm As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_cp_pid As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cp_tt As TextBox
    Friend WithEvents txt_cp_sw As TextBox
    Friend WithEvents txt_cp_OS As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents combo_cp_tester As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents combo_cp_flow As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btn_cp_exit As Button
    Friend WithEvents btn_cp_confirm As Button
    Friend WithEvents txt_cp_lot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_cp_type As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cp_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grp_bake_para As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label66 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents txt_bake_time As TextBox
    Friend WithEvents combo_bake_recipe As ComboBox
    Friend WithEvents combo_BAKE_flow As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents btn_bake_exit As Button
    Friend WithEvents btn_bake_confirm As Button
    Friend WithEvents txt_BAKE_lot As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents combo_BAKE_type As ComboBox
    Friend WithEvents Label40 As Label
    Friend WithEvents txt_BAKE_id As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents txt_bake_remark As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents txt_bake_temp As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents combo_bake_flowquery As ComboBox
    Friend WithEvents combo_BAKE_query As ComboBox
    Friend WithEvents btn_BAKE_Query As Button
    Friend WithEvents btn_BAKE_delete As Button
    Friend WithEvents btn_BAKE_disable As Button
    Friend WithEvents btn_BAKE_copy As Button
    Friend WithEvents btn_BAKE_modify As Button
    Friend WithEvents btn_BAKE_new As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents RichTextBox3 As RichTextBox
    Friend WithEvents Button7 As Button
    Friend WithEvents grp_cpdt_para As GroupBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txt_cpdt_operation As TextBox
    Friend WithEvents combo_cpdt_flow As ComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents txt_cpdt_exit As Button
    Friend WithEvents txt_cpdt_confirm As Button
    Friend WithEvents txt_cpdt_lot As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents combo_cpdt_type As ComboBox
    Friend WithEvents Label50 As Label
    Friend WithEvents txt_cpdt_id As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents txt_cpdt_hold As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents combo_cpdt_flowquery As ComboBox
    Friend WithEvents combo_cpdt_query As ComboBox
    Friend WithEvents btn_cpdt_Query As Button
    Friend WithEvents btn_cpdt_delete As Button
    Friend WithEvents btn_cpdt_disable As Button
    Friend WithEvents btn_cpdt_copy As Button
    Friend WithEvents btn_cpdt_modify As Button
    Friend WithEvents btn_cpdt_new As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents grp_wipfs_para As GroupBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents combo_mappingflow As ComboBox
    Friend WithEvents btn_wipfs_exit As Button
    Friend WithEvents btn_wipfs_confirm As Button
    Friend WithEvents txt_wipfs_lot As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents combo_wipfs_type As ComboBox
    Friend WithEvents Label52 As Label
    Friend WithEvents txt_wipfs_id As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txt_wipfs_operation As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents combo_wipfs_query As ComboBox
    Friend WithEvents btn_wipfs_Query As Button
    Friend WithEvents btn_wipfs_delete As Button
    Friend WithEvents btn_wipfs_disable As Button
    Friend WithEvents btn_wipfs_copy As Button
    Friend WithEvents btn_wipfs_modify As Button
    Friend WithEvents btn_wipfs_new As Button
    Friend WithEvents grp_FQC_para As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txt_FQC_Probemark As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btn_FQC_exit As Button
    Friend WithEvents btn_FQC_confirm As Button
    Friend WithEvents txt_FQC_lot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents combo_FQC_type As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_FQC_ID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_FQC_WI As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_FQC_InspectionArea As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_FQC_SamplePlan As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents combo_FQC_query As ComboBox
    Friend WithEvents btn_FQC_query As Button
    Friend WithEvents btn_FQC_delete As Button
    Friend WithEvents btn_FQC_disable As Button
    Friend WithEvents btn_FQC_copy As Button
    Friend WithEvents btn_FQC_modify As Button
    Friend WithEvents btn_FQC_new As Button
    Friend WithEvents grp_pack_para As GroupBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_pack_exit As Button
    Friend WithEvents btn_pack_confirm As Button
    Friend WithEvents txt_pack_lot As TextBox
    Friend WithEvents Label56 As Label
    Friend WithEvents combo_pack_type As ComboBox
    Friend WithEvents Label59 As Label
    Friend WithEvents txt_pack_id As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txt_pack_operation As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents GroupBox15 As GroupBox
    Friend WithEvents combo_pack_query As ComboBox
    Friend WithEvents btn_pack_query As Button
    Friend WithEvents btn_pack_delete As Button
    Friend WithEvents btn_pack_disable As Button
    Friend WithEvents btn_pack_copy As Button
    Friend WithEvents btn_pack_modify As Button
    Friend WithEvents btn_pack_new As Button
    Friend WithEvents grp_ship_para As GroupBox
    Friend WithEvents btn_ship_exit As Button
    Friend WithEvents btn_ship_confirm As Button
    Friend WithEvents txt_ship_lot As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents combo_ship_type As ComboBox
    Friend WithEvents Label63 As Label
    Friend WithEvents txt_ship_id As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents txt_ship_operation As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents GroupBox17 As GroupBox
    Friend WithEvents combo_ship_query As ComboBox
    Friend WithEvents btn_ship_query As Button
    Friend WithEvents btn_ship_delete As Button
    Friend WithEvents btn_ship_disable As Button
    Friend WithEvents btn_ship_copy As Button
    Friend WithEvents btn_ship_modify As Button
    Friend WithEvents btn_ship_new As Button
    Friend WithEvents txt_pack_recipe As TextBox
    Friend WithEvents Label68 As Label
End Class
