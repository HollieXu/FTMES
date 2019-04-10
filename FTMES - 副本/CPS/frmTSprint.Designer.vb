<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTSprint
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtb_flowinfo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtb_rule = New System.Windows.Forms.RichTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.combo_iprod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_type = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.combo_id = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combo_lot = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_IQC_cancel = New System.Windows.Forms.Button()
        Me.btn_query = New System.Windows.Forms.Button()
        Me.combo_preview = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1172, 646)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtb_flowinfo)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(562, 383)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(607, 260)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        '
        'rtb_flowinfo
        '
        Me.rtb_flowinfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtb_flowinfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_flowinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_flowinfo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_flowinfo.ForeColor = System.Drawing.Color.Blue
        Me.rtb_flowinfo.Location = New System.Drawing.Point(3, 17)
        Me.rtb_flowinfo.Name = "rtb_flowinfo"
        Me.rtb_flowinfo.Size = New System.Drawing.Size(601, 240)
        Me.rtb_flowinfo.TabIndex = 19
        Me.rtb_flowinfo.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rtb_rule)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 383)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 260)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        '
        'rtb_rule
        '
        Me.rtb_rule.BackColor = System.Drawing.SystemColors.Control
        Me.rtb_rule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtb_rule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtb_rule.ForeColor = System.Drawing.Color.Crimson
        Me.rtb_rule.Location = New System.Drawing.Point(3, 17)
        Me.rtb_rule.Name = "rtb_rule"
        Me.rtb_rule.Size = New System.Drawing.Size(553, 240)
        Me.rtb_rule.TabIndex = 0
        Me.rtb_rule.Text = "规则说明：" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "1. ECN流程 + ECN站别，选择ECN Type + FlowID 后查询；" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "2. ECN流程 + SEN站别，选择ECN Type + F" &
    "lowID, 再输入内部批号后查询 ；" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "3. SEN流程， 选择 SEN Type + FlowID + 内部批号后查询; 系统会自动优先选择SEN站别." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txt_ilot)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(3, 204)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1166, 179)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "批号查询(优先)"
        '
        'txt_ilot
        '
        Me.txt_ilot.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ilot.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txt_ilot.ForeColor = System.Drawing.Color.Blue
        Me.txt_ilot.Location = New System.Drawing.Point(445, 69)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.Size = New System.Drawing.Size(308, 26)
        Me.txt_ilot.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(335, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "生产批号:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.combo_iprod)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.combo_type)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.combo_cust)
        Me.GroupBox4.Controls.Add(Me.combo_id)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.combo_lot)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Location = New System.Drawing.Point(3, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1166, 187)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "筛选查询"
        '
        'combo_iprod
        '
        Me.combo_iprod.FormattingEnabled = True
        Me.combo_iprod.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_iprod.Location = New System.Drawing.Point(528, 39)
        Me.combo_iprod.Name = "combo_iprod"
        Me.combo_iprod.Size = New System.Drawing.Size(178, 20)
        Me.combo_iprod.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(102, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Type :"
        '
        'combo_type
        '
        Me.combo_type.FormattingEnabled = True
        Me.combo_type.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_type.Location = New System.Drawing.Point(173, 78)
        Me.combo_type.Name = "combo_type"
        Me.combo_type.Size = New System.Drawing.Size(178, 20)
        Me.combo_type.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(438, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 12)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Product :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(443, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Flow ID :"
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Items.AddRange(New Object() {"ECN", "SEN"})
        Me.combo_cust.Location = New System.Drawing.Point(173, 39)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(178, 20)
        Me.combo_cust.TabIndex = 20
        '
        'combo_id
        '
        Me.combo_id.FormattingEnabled = True
        Me.combo_id.Location = New System.Drawing.Point(528, 78)
        Me.combo_id.Name = "combo_id"
        Me.combo_id.Size = New System.Drawing.Size(178, 20)
        Me.combo_id.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Customer :"
        '
        'combo_lot
        '
        Me.combo_lot.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.combo_lot.ForeColor = System.Drawing.Color.Red
        Me.combo_lot.FormattingEnabled = True
        Me.combo_lot.Location = New System.Drawing.Point(829, 78)
        Me.combo_lot.Name = "combo_lot"
        Me.combo_lot.Size = New System.Drawing.Size(178, 24)
        Me.combo_lot.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(769, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Lot :"
        '
        'btn_IQC_cancel
        '
        Me.btn_IQC_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_IQC_cancel.Location = New System.Drawing.Point(818, 692)
        Me.btn_IQC_cancel.Name = "btn_IQC_cancel"
        Me.btn_IQC_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_IQC_cancel.TabIndex = 43
        Me.btn_IQC_cancel.UseVisualStyleBackColor = True
        '
        'btn_query
        '
        Me.btn_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_query.Location = New System.Drawing.Point(264, 692)
        Me.btn_query.Name = "btn_query"
        Me.btn_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_query.TabIndex = 17
        Me.btn_query.UseVisualStyleBackColor = True
        '
        'combo_preview
        '
        Me.combo_preview.Image = Global.CPS.My.Resources.Resources.djly
        Me.combo_preview.Location = New System.Drawing.Point(546, 692)
        Me.combo_preview.Name = "combo_preview"
        Me.combo_preview.Size = New System.Drawing.Size(90, 32)
        Me.combo_preview.TabIndex = 16
        Me.combo_preview.UseVisualStyleBackColor = True
        '
        'frmTSprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 779)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_IQC_cancel)
        Me.Controls.Add(Me.combo_preview)
        Me.Controls.Add(Me.btn_query)
        Me.Name = "frmTSprint"
        Me.Text = "frmTSprint"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_query As Button
    Friend WithEvents combo_preview As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_lot As ComboBox
    Friend WithEvents combo_id As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents combo_type As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_iprod As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_IQC_cancel As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rtb_flowinfo As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtb_rule As RichTextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox4 As GroupBox
End Class
