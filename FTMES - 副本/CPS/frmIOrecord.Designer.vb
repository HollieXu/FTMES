<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIOrecord
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_IO_modify = New System.Windows.Forms.Button()
        Me.btn_IO_new = New System.Windows.Forms.Button()
        Me.btn_IO_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_IO = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_IO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_IO_modify)
        Me.GroupBox3.Controls.Add(Me.btn_IO_new)
        Me.GroupBox3.Controls.Add(Me.btn_IO_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(945, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        '
        'btn_IO_modify
        '
        Me.btn_IO_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_IO_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_IO_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_IO_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_IO_modify.Location = New System.Drawing.Point(3, 95)
        Me.btn_IO_modify.Name = "btn_IO_modify"
        Me.btn_IO_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_IO_modify.TabIndex = 5
        Me.btn_IO_modify.UseVisualStyleBackColor = False
        '
        'btn_IO_new
        '
        Me.btn_IO_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_IO_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_IO_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_IO_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_IO_new.Location = New System.Drawing.Point(3, 37)
        Me.btn_IO_new.Name = "btn_IO_new"
        Me.btn_IO_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_IO_new.TabIndex = 4
        Me.btn_IO_new.UseVisualStyleBackColor = False
        '
        'btn_IO_delete
        '
        Me.btn_IO_delete.BackColor = System.Drawing.Color.Red
        Me.btn_IO_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_IO_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_IO_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_IO_delete.Location = New System.Drawing.Point(3, 306)
        Me.btn_IO_delete.Name = "btn_IO_delete"
        Me.btn_IO_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_IO_delete.TabIndex = 2
        Me.btn_IO_delete.UseVisualStyleBackColor = False
        Me.btn_IO_delete.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_IO)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_IO
        '
        Me.DGV_IO.AllowUserToAddRows = False
        Me.DGV_IO.AllowUserToDeleteRows = False
        Me.DGV_IO.AllowUserToOrderColumns = True
        Me.DGV_IO.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_IO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_IO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_IO.Location = New System.Drawing.Point(3, 17)
        Me.DGV_IO.Name = "DGV_IO"
        Me.DGV_IO.ReadOnly = True
        Me.DGV_IO.RowHeadersVisible = False
        Me.DGV_IO.RowTemplate.Height = 23
        Me.DGV_IO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_IO.Size = New System.Drawing.Size(919, 481)
        Me.DGV_IO.TabIndex = 2
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.DateTimePicker2)
        Me.grpbox_Select.Controls.Add(Me.DateTimePicker1)
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 108)
        Me.grpbox_Select.TabIndex = 10
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(128, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(169, 21)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 21)
        Me.DateTimePicker1.TabIndex = 5
        Me.DateTimePicker1.Value = New Date(2018, 1, 23, 8, 42, 0, 0)
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(377, 42)
        Me.btn_Query.Name = "btn_Query"
        Me.btn_Query.Size = New System.Drawing.Size(90, 32)
        Me.btn_Query.TabIndex = 4
        Me.btn_Query.UseVisualStyleBackColor = False
        '
        'lbl_product
        '
        Me.lbl_product.AutoSize = True
        Me.lbl_product.Location = New System.Drawing.Point(30, 58)
        Me.lbl_product.Name = "lbl_product"
        Me.lbl_product.Size = New System.Drawing.Size(53, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "End Date"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(30, 23)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(65, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "Start Date"
        '
        'frmIOrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 695)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmIOrecord"
        Me.Text = "frmIOrecord"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_IO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_IO_modify As Button
    Friend WithEvents btn_IO_new As Button
    Friend WithEvents btn_IO_delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_IO As DataGridView
    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btn_Query As Button
    Friend WithEvents lbl_product As Label
    Friend WithEvents lbl_customer As Label
End Class
