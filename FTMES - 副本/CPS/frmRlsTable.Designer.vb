<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRlsTable
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
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.combo_flow = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cust = New System.Windows.Forms.TextBox()
        Me.combo_cust = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_prod = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LB_tester = New System.Windows.Forms.ListBox()
        Me.btn_tester_query = New System.Windows.Forms.Button()
        Me.btn_tester_exit = New System.Windows.Forms.Button()
        Me.btn_tester_ok = New System.Windows.Forms.Button()
        Me.DGV_tester = New System.Windows.Forms.DataGridView()
        Me.testerid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.disable = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DisableReason = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.combo_grp = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_assy_del = New System.Windows.Forms.Button()
        Me.btn_assy_new = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_Assy = New System.Windows.Forms.ListBox()
        Me.btn_assy_query = New System.Windows.Forms.Button()
        Me.DGV_Assy = New System.Windows.Forms.DataGridView()
        Me.combo_part = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_assy_exit = New System.Windows.Forms.Button()
        Me.btn_assy_ok = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpbox_Select.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGV_tester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_Assy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.combo_flow)
        Me.grpbox_Select.Controls.Add(Me.Label4)
        Me.grpbox_Select.Controls.Add(Me.txt_cust)
        Me.grpbox_Select.Controls.Add(Me.combo_cust)
        Me.grpbox_Select.Controls.Add(Me.Label1)
        Me.grpbox_Select.Controls.Add(Me.combo_prod)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 149)
        Me.grpbox_Select.TabIndex = 17
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'combo_flow
        '
        Me.combo_flow.FormattingEnabled = True
        Me.combo_flow.Location = New System.Drawing.Point(415, 58)
        Me.combo_flow.Name = "combo_flow"
        Me.combo_flow.Size = New System.Drawing.Size(218, 20)
        Me.combo_flow.Sorted = True
        Me.combo_flow.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "站别"
        '
        'txt_cust
        '
        Me.txt_cust.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_cust.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cust.Enabled = False
        Me.txt_cust.ForeColor = System.Drawing.Color.Blue
        Me.txt_cust.Location = New System.Drawing.Point(328, 26)
        Me.txt_cust.Name = "txt_cust"
        Me.txt_cust.ReadOnly = True
        Me.txt_cust.Size = New System.Drawing.Size(305, 14)
        Me.txt_cust.TabIndex = 7
        '
        'combo_cust
        '
        Me.combo_cust.FormattingEnabled = True
        Me.combo_cust.Location = New System.Drawing.Point(80, 23)
        Me.combo_cust.Name = "combo_cust"
        Me.combo_cust.Size = New System.Drawing.Size(218, 20)
        Me.combo_cust.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "客户名称"
        '
        'combo_prod
        '
        Me.combo_prod.FormattingEnabled = True
        Me.combo_prod.Location = New System.Drawing.Point(80, 58)
        Me.combo_prod.Name = "combo_prod"
        Me.combo_prod.Size = New System.Drawing.Size(218, 20)
        Me.combo_prod.Sorted = True
        Me.combo_prod.TabIndex = 1
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(21, 61)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(53, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "产品型号"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 18)
        Me.TabControl1.Location = New System.Drawing.Point(10, 180)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1023, 534)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 50
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.btn_del)
        Me.TabPage1.Controls.Add(Me.btn_new)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.LB_tester)
        Me.TabPage1.Controls.Add(Me.btn_tester_query)
        Me.TabPage1.Controls.Add(Me.btn_tester_exit)
        Me.TabPage1.Controls.Add(Me.btn_tester_ok)
        Me.TabPage1.Controls.Add(Me.DGV_tester)
        Me.TabPage1.Controls.Add(Me.combo_grp)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1015, 508)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "机台设定"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "已选列表"
        '
        'btn_del
        '
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_del.Image = Global.CPS.My.Resources.Resources.arrow_back
        Me.btn_del.Location = New System.Drawing.Point(255, 306)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(73, 30)
        Me.btn_del.TabIndex = 61
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_new.Image = Global.CPS.My.Resources.Resources.arrow_forward
        Me.btn_new.Location = New System.Drawing.Point(255, 199)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(73, 29)
        Me.btn_new.TabIndex = 60
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(72, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "可选列表"
        '
        'LB_tester
        '
        Me.LB_tester.FormattingEnabled = True
        Me.LB_tester.ItemHeight = 12
        Me.LB_tester.Location = New System.Drawing.Point(74, 119)
        Me.LB_tester.Name = "LB_tester"
        Me.LB_tester.Size = New System.Drawing.Size(171, 292)
        Me.LB_tester.TabIndex = 58
        '
        'btn_tester_query
        '
        Me.btn_tester_query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_tester_query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_tester_query.FlatAppearance.BorderSize = 5
        Me.btn_tester_query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tester_query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_tester_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_tester_query.Location = New System.Drawing.Point(276, 28)
        Me.btn_tester_query.Name = "btn_tester_query"
        Me.btn_tester_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_tester_query.TabIndex = 57
        Me.btn_tester_query.UseVisualStyleBackColor = False
        '
        'btn_tester_exit
        '
        Me.btn_tester_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_tester_exit.Location = New System.Drawing.Point(640, 454)
        Me.btn_tester_exit.Name = "btn_tester_exit"
        Me.btn_tester_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_tester_exit.TabIndex = 56
        Me.btn_tester_exit.UseVisualStyleBackColor = True
        '
        'btn_tester_ok
        '
        Me.btn_tester_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_tester_ok.Location = New System.Drawing.Point(276, 454)
        Me.btn_tester_ok.Name = "btn_tester_ok"
        Me.btn_tester_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_tester_ok.TabIndex = 51
        Me.btn_tester_ok.UseVisualStyleBackColor = True
        '
        'DGV_tester
        '
        Me.DGV_tester.AllowUserToAddRows = False
        Me.DGV_tester.AllowUserToDeleteRows = False
        Me.DGV_tester.AllowUserToOrderColumns = True
        Me.DGV_tester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_tester.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.testerid, Me.disable, Me.DisableReason})
        Me.DGV_tester.Location = New System.Drawing.Point(342, 119)
        Me.DGV_tester.Name = "DGV_tester"
        Me.DGV_tester.RowHeadersVisible = False
        Me.DGV_tester.RowTemplate.Height = 23
        Me.DGV_tester.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_tester.Size = New System.Drawing.Size(653, 292)
        Me.DGV_tester.TabIndex = 50
        '
        'testerid
        '
        Me.testerid.HeaderText = "机台"
        Me.testerid.Name = "testerid"
        Me.testerid.Width = 150
        '
        'disable
        '
        Me.disable.HeaderText = "停用"
        Me.disable.Name = "disable"
        '
        'DisableReason
        '
        Me.DisableReason.HeaderText = "停用原因"
        Me.DisableReason.Name = "DisableReason"
        Me.DisableReason.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DisableReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DisableReason.Width = 300
        '
        'combo_grp
        '
        Me.combo_grp.FormattingEnabled = True
        Me.combo_grp.Location = New System.Drawing.Point(74, 35)
        Me.combo_grp.Name = "combo_grp"
        Me.combo_grp.Size = New System.Drawing.Size(171, 20)
        Me.combo_grp.Sorted = True
        Me.combo_grp.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "测试平台"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.btn_assy_del)
        Me.TabPage2.Controls.Add(Me.btn_assy_new)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.LB_Assy)
        Me.TabPage2.Controls.Add(Me.btn_assy_query)
        Me.TabPage2.Controls.Add(Me.DGV_Assy)
        Me.TabPage2.Controls.Add(Me.combo_part)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.btn_assy_exit)
        Me.TabPage2.Controls.Add(Me.btn_assy_ok)
        Me.TabPage2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1015, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "配件设定"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(340, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "已选列表"
        '
        'btn_assy_del
        '
        Me.btn_assy_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_assy_del.Image = Global.CPS.My.Resources.Resources.arrow_back
        Me.btn_assy_del.Location = New System.Drawing.Point(255, 306)
        Me.btn_assy_del.Name = "btn_assy_del"
        Me.btn_assy_del.Size = New System.Drawing.Size(73, 30)
        Me.btn_assy_del.TabIndex = 70
        Me.btn_assy_del.UseVisualStyleBackColor = True
        '
        'btn_assy_new
        '
        Me.btn_assy_new.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_assy_new.Image = Global.CPS.My.Resources.Resources.arrow_forward
        Me.btn_assy_new.Location = New System.Drawing.Point(255, 199)
        Me.btn_assy_new.Name = "btn_assy_new"
        Me.btn_assy_new.Size = New System.Drawing.Size(73, 29)
        Me.btn_assy_new.TabIndex = 69
        Me.btn_assy_new.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(72, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 12)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "可选列表"
        '
        'LB_Assy
        '
        Me.LB_Assy.FormattingEnabled = True
        Me.LB_Assy.ItemHeight = 12
        Me.LB_Assy.Location = New System.Drawing.Point(74, 119)
        Me.LB_Assy.Name = "LB_Assy"
        Me.LB_Assy.Size = New System.Drawing.Size(171, 292)
        Me.LB_Assy.TabIndex = 67
        '
        'btn_assy_query
        '
        Me.btn_assy_query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_assy_query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_assy_query.FlatAppearance.BorderSize = 5
        Me.btn_assy_query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_assy_query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_assy_query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_assy_query.Location = New System.Drawing.Point(276, 28)
        Me.btn_assy_query.Name = "btn_assy_query"
        Me.btn_assy_query.Size = New System.Drawing.Size(90, 32)
        Me.btn_assy_query.TabIndex = 66
        Me.btn_assy_query.UseVisualStyleBackColor = False
        '
        'DGV_Assy
        '
        Me.DGV_Assy.AllowUserToAddRows = False
        Me.DGV_Assy.AllowUserToDeleteRows = False
        Me.DGV_Assy.AllowUserToOrderColumns = True
        Me.DGV_Assy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Assy.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DGV_Assy.Location = New System.Drawing.Point(342, 119)
        Me.DGV_Assy.Name = "DGV_Assy"
        Me.DGV_Assy.RowHeadersVisible = False
        Me.DGV_Assy.RowTemplate.Height = 23
        Me.DGV_Assy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Assy.Size = New System.Drawing.Size(653, 292)
        Me.DGV_Assy.TabIndex = 65
        '
        'combo_part
        '
        Me.combo_part.FormattingEnabled = True
        Me.combo_part.Location = New System.Drawing.Point(74, 35)
        Me.combo_part.Name = "combo_part"
        Me.combo_part.Size = New System.Drawing.Size(171, 20)
        Me.combo_part.Sorted = True
        Me.combo_part.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 12)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "配件料号"
        '
        'btn_assy_exit
        '
        Me.btn_assy_exit.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_assy_exit.Location = New System.Drawing.Point(625, 454)
        Me.btn_assy_exit.Name = "btn_assy_exit"
        Me.btn_assy_exit.Size = New System.Drawing.Size(90, 32)
        Me.btn_assy_exit.TabIndex = 55
        Me.btn_assy_exit.UseVisualStyleBackColor = True
        '
        'btn_assy_ok
        '
        Me.btn_assy_ok.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_assy_ok.Location = New System.Drawing.Point(276, 454)
        Me.btn_assy_ok.Name = "btn_assy_ok"
        Me.btn_assy_ok.Size = New System.Drawing.Size(90, 32)
        Me.btn_assy_ok.TabIndex = 54
        Me.btn_assy_ok.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "配件"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "停用"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "停用原因"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'frmRlsTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 789)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmRlsTable"
        Me.Text = "frmRlsTable"
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DGV_tester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_Assy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents txt_cust As TextBox
    Friend WithEvents combo_cust As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_prod As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btn_tester_ok As Button
    Friend WithEvents DGV_tester As DataGridView
    Friend WithEvents combo_grp As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_assy_ok As Button
    Friend WithEvents combo_flow As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_tester_exit As Button
    Friend WithEvents btn_assy_exit As Button
    Friend WithEvents btn_tester_query As Button
    Friend WithEvents LB_tester As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_new As Button
    Friend WithEvents testerid As DataGridViewTextBoxColumn
    Friend WithEvents disable As DataGridViewCheckBoxColumn
    Friend WithEvents DisableReason As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_assy_del As Button
    Friend WithEvents btn_assy_new As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_Assy As ListBox
    Friend WithEvents btn_assy_query As Button
    Friend WithEvents DGV_Assy As DataGridView
    Friend WithEvents combo_part As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
