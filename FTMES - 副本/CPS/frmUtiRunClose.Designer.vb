<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUtiRunClose
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
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_tester = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_FormNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_query = New System.Windows.Forms.Button()
        Me.txt_ilot = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_all = New System.Windows.Forms.Button()
        Me.DGV_waferselect = New System.Windows.Forms.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn6 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn7 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn8 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn13 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn17 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn18 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn19 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn20 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn21 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn22 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn23 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn24 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn25 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_testdieqty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_currwafer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_confirm
        '
        Me.btn_confirm.Image = Global.CPS.My.Resources.Resources.OKnew
        Me.btn_confirm.Location = New System.Drawing.Point(194, 644)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(90, 32)
        Me.btn_confirm.TabIndex = 30
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Image = Global.CPS.My.Resources.Resources.EXITnew
        Me.btn_cancel.Location = New System.Drawing.Point(442, 644)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(90, 32)
        Me.btn_cancel.TabIndex = 31
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_tester)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_FormNo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btn_query)
        Me.GroupBox1.Controls.Add(Me.txt_ilot)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(756, 97)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test Record"
        '
        'txt_tester
        '
        Me.txt_tester.Location = New System.Drawing.Point(474, 20)
        Me.txt_tester.Name = "txt_tester"
        Me.txt_tester.ReadOnly = True
        Me.txt_tester.Size = New System.Drawing.Size(204, 21)
        Me.txt_tester.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(373, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 12)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Tester (机台)"
        '
        'txt_FormNo
        '
        Me.txt_FormNo.Location = New System.Drawing.Point(118, 20)
        Me.txt_FormNo.Name = "txt_FormNo"
        Me.txt_FormNo.ReadOnly = True
        Me.txt_FormNo.Size = New System.Drawing.Size(204, 21)
        Me.txt_FormNo.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 12)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Run No.(单号)"
        '
        'btn_query
        '
        Me.btn_query.Location = New System.Drawing.Point(355, 53)
        Me.btn_query.Name = "btn_query"
        Me.btn_query.Size = New System.Drawing.Size(89, 20)
        Me.btn_query.TabIndex = 2
        Me.btn_query.Text = "查询数据"
        Me.btn_query.UseVisualStyleBackColor = True
        '
        'txt_ilot
        '
        Me.txt_ilot.Location = New System.Drawing.Point(118, 53)
        Me.txt_ilot.Name = "txt_ilot"
        Me.txt_ilot.Size = New System.Drawing.Size(204, 21)
        Me.txt_ilot.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "当前批号"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_clear)
        Me.GroupBox2.Controls.Add(Me.btn_all)
        Me.GroupBox2.Controls.Add(Me.DGV_waferselect)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 97)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(756, 200)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Finished Wafer 已完工片数"
        '
        'btn_clear
        '
        Me.btn_clear.BackColor = System.Drawing.Color.HotPink
        Me.btn_clear.Image = Global.CPS.My.Resources.Resources.cls
        Me.btn_clear.Location = New System.Drawing.Point(408, 113)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(90, 32)
        Me.btn_clear.TabIndex = 16
        Me.btn_clear.UseVisualStyleBackColor = False
        '
        'btn_all
        '
        Me.btn_all.BackColor = System.Drawing.Color.HotPink
        Me.btn_all.Image = Global.CPS.My.Resources.Resources.all
        Me.btn_all.Location = New System.Drawing.Point(240, 113)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(90, 32)
        Me.btn_all.TabIndex = 15
        Me.btn_all.UseVisualStyleBackColor = False
        '
        'DGV_waferselect
        '
        Me.DGV_waferselect.AllowUserToAddRows = False
        Me.DGV_waferselect.AllowUserToDeleteRows = False
        Me.DGV_waferselect.AllowUserToResizeColumns = False
        Me.DGV_waferselect.AllowUserToResizeRows = False
        Me.DGV_waferselect.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGV_waferselect.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DGV_waferselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_waferselect.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewCheckBoxColumn6, Me.DataGridViewCheckBoxColumn7, Me.DataGridViewCheckBoxColumn8, Me.DataGridViewCheckBoxColumn9, Me.DataGridViewCheckBoxColumn10, Me.DataGridViewCheckBoxColumn11, Me.DataGridViewCheckBoxColumn12, Me.DataGridViewCheckBoxColumn13, Me.DataGridViewCheckBoxColumn14, Me.DataGridViewCheckBoxColumn15, Me.DataGridViewCheckBoxColumn16, Me.DataGridViewCheckBoxColumn17, Me.DataGridViewCheckBoxColumn18, Me.DataGridViewCheckBoxColumn19, Me.DataGridViewCheckBoxColumn20, Me.DataGridViewCheckBoxColumn21, Me.DataGridViewCheckBoxColumn22, Me.DataGridViewCheckBoxColumn23, Me.DataGridViewCheckBoxColumn24, Me.DataGridViewCheckBoxColumn25, Me.DataGridViewTextBoxColumn1})
        Me.DGV_waferselect.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGV_waferselect.Location = New System.Drawing.Point(42, 52)
        Me.DGV_waferselect.Name = "DGV_waferselect"
        Me.DGV_waferselect.RowHeadersWidth = 10
        Me.DGV_waferselect.RowTemplate.Height = 23
        Me.DGV_waferselect.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DGV_waferselect.Size = New System.Drawing.Size(655, 56)
        Me.DGV_waferselect.TabIndex = 14
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.HeaderText = "1"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn1.Width = 25
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "2"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewCheckBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewCheckBoxColumn2.Width = 25
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.HeaderText = "3"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.Width = 25
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.HeaderText = "4"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        Me.DataGridViewCheckBoxColumn4.Width = 25
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.HeaderText = "5"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        Me.DataGridViewCheckBoxColumn5.Width = 25
        '
        'DataGridViewCheckBoxColumn6
        '
        Me.DataGridViewCheckBoxColumn6.HeaderText = "6"
        Me.DataGridViewCheckBoxColumn6.Name = "DataGridViewCheckBoxColumn6"
        Me.DataGridViewCheckBoxColumn6.Width = 25
        '
        'DataGridViewCheckBoxColumn7
        '
        Me.DataGridViewCheckBoxColumn7.HeaderText = "7"
        Me.DataGridViewCheckBoxColumn7.Name = "DataGridViewCheckBoxColumn7"
        Me.DataGridViewCheckBoxColumn7.Width = 25
        '
        'DataGridViewCheckBoxColumn8
        '
        Me.DataGridViewCheckBoxColumn8.HeaderText = "8"
        Me.DataGridViewCheckBoxColumn8.Name = "DataGridViewCheckBoxColumn8"
        Me.DataGridViewCheckBoxColumn8.Width = 25
        '
        'DataGridViewCheckBoxColumn9
        '
        Me.DataGridViewCheckBoxColumn9.HeaderText = "9"
        Me.DataGridViewCheckBoxColumn9.Name = "DataGridViewCheckBoxColumn9"
        Me.DataGridViewCheckBoxColumn9.Width = 25
        '
        'DataGridViewCheckBoxColumn10
        '
        Me.DataGridViewCheckBoxColumn10.HeaderText = "10"
        Me.DataGridViewCheckBoxColumn10.Name = "DataGridViewCheckBoxColumn10"
        Me.DataGridViewCheckBoxColumn10.Width = 25
        '
        'DataGridViewCheckBoxColumn11
        '
        Me.DataGridViewCheckBoxColumn11.HeaderText = "11"
        Me.DataGridViewCheckBoxColumn11.Name = "DataGridViewCheckBoxColumn11"
        Me.DataGridViewCheckBoxColumn11.Width = 25
        '
        'DataGridViewCheckBoxColumn12
        '
        Me.DataGridViewCheckBoxColumn12.HeaderText = "12"
        Me.DataGridViewCheckBoxColumn12.Name = "DataGridViewCheckBoxColumn12"
        Me.DataGridViewCheckBoxColumn12.Width = 25
        '
        'DataGridViewCheckBoxColumn13
        '
        Me.DataGridViewCheckBoxColumn13.HeaderText = "13"
        Me.DataGridViewCheckBoxColumn13.Name = "DataGridViewCheckBoxColumn13"
        Me.DataGridViewCheckBoxColumn13.Width = 25
        '
        'DataGridViewCheckBoxColumn14
        '
        Me.DataGridViewCheckBoxColumn14.HeaderText = "14"
        Me.DataGridViewCheckBoxColumn14.Name = "DataGridViewCheckBoxColumn14"
        Me.DataGridViewCheckBoxColumn14.Width = 25
        '
        'DataGridViewCheckBoxColumn15
        '
        Me.DataGridViewCheckBoxColumn15.HeaderText = "15"
        Me.DataGridViewCheckBoxColumn15.Name = "DataGridViewCheckBoxColumn15"
        Me.DataGridViewCheckBoxColumn15.Width = 25
        '
        'DataGridViewCheckBoxColumn16
        '
        Me.DataGridViewCheckBoxColumn16.HeaderText = "16"
        Me.DataGridViewCheckBoxColumn16.Name = "DataGridViewCheckBoxColumn16"
        Me.DataGridViewCheckBoxColumn16.Width = 25
        '
        'DataGridViewCheckBoxColumn17
        '
        Me.DataGridViewCheckBoxColumn17.HeaderText = "17"
        Me.DataGridViewCheckBoxColumn17.Name = "DataGridViewCheckBoxColumn17"
        Me.DataGridViewCheckBoxColumn17.Width = 25
        '
        'DataGridViewCheckBoxColumn18
        '
        Me.DataGridViewCheckBoxColumn18.HeaderText = "18"
        Me.DataGridViewCheckBoxColumn18.Name = "DataGridViewCheckBoxColumn18"
        Me.DataGridViewCheckBoxColumn18.Width = 25
        '
        'DataGridViewCheckBoxColumn19
        '
        Me.DataGridViewCheckBoxColumn19.HeaderText = "19"
        Me.DataGridViewCheckBoxColumn19.Name = "DataGridViewCheckBoxColumn19"
        Me.DataGridViewCheckBoxColumn19.Width = 25
        '
        'DataGridViewCheckBoxColumn20
        '
        Me.DataGridViewCheckBoxColumn20.HeaderText = "20"
        Me.DataGridViewCheckBoxColumn20.Name = "DataGridViewCheckBoxColumn20"
        Me.DataGridViewCheckBoxColumn20.Width = 25
        '
        'DataGridViewCheckBoxColumn21
        '
        Me.DataGridViewCheckBoxColumn21.HeaderText = "21"
        Me.DataGridViewCheckBoxColumn21.Name = "DataGridViewCheckBoxColumn21"
        Me.DataGridViewCheckBoxColumn21.Width = 25
        '
        'DataGridViewCheckBoxColumn22
        '
        Me.DataGridViewCheckBoxColumn22.HeaderText = "22"
        Me.DataGridViewCheckBoxColumn22.Name = "DataGridViewCheckBoxColumn22"
        Me.DataGridViewCheckBoxColumn22.Width = 25
        '
        'DataGridViewCheckBoxColumn23
        '
        Me.DataGridViewCheckBoxColumn23.HeaderText = "23"
        Me.DataGridViewCheckBoxColumn23.Name = "DataGridViewCheckBoxColumn23"
        Me.DataGridViewCheckBoxColumn23.Width = 25
        '
        'DataGridViewCheckBoxColumn24
        '
        Me.DataGridViewCheckBoxColumn24.HeaderText = "24"
        Me.DataGridViewCheckBoxColumn24.Name = "DataGridViewCheckBoxColumn24"
        Me.DataGridViewCheckBoxColumn24.Width = 25
        '
        'DataGridViewCheckBoxColumn25
        '
        Me.DataGridViewCheckBoxColumn25.HeaderText = "25"
        Me.DataGridViewCheckBoxColumn25.Name = "DataGridViewCheckBoxColumn25"
        Me.DataGridViewCheckBoxColumn25.Width = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = ""
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_testdieqty)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txt_currwafer)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(756, 121)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Testing Wafer 已完工颗数"
        '
        'txt_testdieqty
        '
        Me.txt_testdieqty.Location = New System.Drawing.Point(453, 43)
        Me.txt_testdieqty.Name = "txt_testdieqty"
        Me.txt_testdieqty.Size = New System.Drawing.Size(221, 21)
        Me.txt_testdieqty.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(375, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "已测颗数"
        '
        'txt_currwafer
        '
        Me.txt_currwafer.Location = New System.Drawing.Point(118, 42)
        Me.txt_currwafer.Name = "txt_currwafer"
        Me.txt_currwafer.Size = New System.Drawing.Size(221, 21)
        Me.txt_currwafer.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "当前片号"
        '
        'frmUtiRunClose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 722)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.btn_cancel)
        Me.Name = "frmUtiRunClose"
        Me.Text = "RUN - 状态转出"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_waferselect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_query As Button
    Friend WithEvents txt_ilot As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_all As Button
    Friend WithEvents DGV_waferselect As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txt_currwafer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn6 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn7 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn8 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn9 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn10 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn11 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn12 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn13 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn16 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn17 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn18 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn19 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn20 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn21 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn22 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn23 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn24 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn25 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_testdieqty As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tester As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_FormNo As TextBox
    Friend WithEvents Label5 As Label
End Class
