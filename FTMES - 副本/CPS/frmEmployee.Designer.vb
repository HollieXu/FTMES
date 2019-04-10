<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Me.btn_employee_modify = New System.Windows.Forms.Button()
        Me.btn_employee_new = New System.Windows.Forms.Button()
        Me.btn_employee_delete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV_employee = New System.Windows.Forms.DataGridView()
        Me.grpbox_Select = New System.Windows.Forms.GroupBox()
        Me.combo_department = New System.Windows.Forms.ComboBox()
        Me.btn_Query = New System.Windows.Forms.Button()
        Me.lbl_product = New System.Windows.Forms.Label()
        Me.combo_ID = New System.Windows.Forms.ComboBox()
        Me.lbl_customer = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpbox_Select.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_employee_modify)
        Me.GroupBox3.Controls.Add(Me.btn_employee_new)
        Me.GroupBox3.Controls.Add(Me.btn_employee_delete)
        Me.GroupBox3.Location = New System.Drawing.Point(938, 170)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(96, 501)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        '
        'btn_employee_modify
        '
        Me.btn_employee_modify.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_employee_modify.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_employee_modify.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_employee_modify.Image = Global.CPS.My.Resources.Resources.modify
        Me.btn_employee_modify.Location = New System.Drawing.Point(3, 97)
        Me.btn_employee_modify.Name = "btn_employee_modify"
        Me.btn_employee_modify.Size = New System.Drawing.Size(90, 32)
        Me.btn_employee_modify.TabIndex = 5
        Me.btn_employee_modify.UseVisualStyleBackColor = False
        '
        'btn_employee_new
        '
        Me.btn_employee_new.BackColor = System.Drawing.SystemColors.GrayText
        Me.btn_employee_new.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_employee_new.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_employee_new.Image = Global.CPS.My.Resources.Resources._NEW
        Me.btn_employee_new.Location = New System.Drawing.Point(3, 39)
        Me.btn_employee_new.Name = "btn_employee_new"
        Me.btn_employee_new.Size = New System.Drawing.Size(90, 32)
        Me.btn_employee_new.TabIndex = 4
        Me.btn_employee_new.UseVisualStyleBackColor = False
        '
        'btn_employee_delete
        '
        Me.btn_employee_delete.BackColor = System.Drawing.Color.Red
        Me.btn_employee_delete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btn_employee_delete.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_employee_delete.Image = Global.CPS.My.Resources.Resources.delete
        Me.btn_employee_delete.Location = New System.Drawing.Point(3, 308)
        Me.btn_employee_delete.Name = "btn_employee_delete"
        Me.btn_employee_delete.Size = New System.Drawing.Size(90, 32)
        Me.btn_employee_delete.TabIndex = 2
        Me.btn_employee_delete.UseVisualStyleBackColor = False
        Me.btn_employee_delete.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGV_employee)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(925, 501)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "QUERY LIST"
        '
        'DGV_employee
        '
        Me.DGV_employee.AllowUserToAddRows = False
        Me.DGV_employee.AllowUserToDeleteRows = False
        Me.DGV_employee.AllowUserToOrderColumns = True
        Me.DGV_employee.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_employee.Location = New System.Drawing.Point(3, 17)
        Me.DGV_employee.Name = "DGV_employee"
        Me.DGV_employee.ReadOnly = True
        Me.DGV_employee.RowHeadersVisible = False
        Me.DGV_employee.RowTemplate.Height = 23
        Me.DGV_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_employee.Size = New System.Drawing.Size(919, 481)
        Me.DGV_employee.TabIndex = 2
        '
        'grpbox_Select
        '
        Me.grpbox_Select.Controls.Add(Me.combo_department)
        Me.grpbox_Select.Controls.Add(Me.btn_Query)
        Me.grpbox_Select.Controls.Add(Me.lbl_product)
        Me.grpbox_Select.Controls.Add(Me.combo_ID)
        Me.grpbox_Select.Controls.Add(Me.lbl_customer)
        Me.grpbox_Select.Location = New System.Drawing.Point(10, 10)
        Me.grpbox_Select.Name = "grpbox_Select"
        Me.grpbox_Select.Size = New System.Drawing.Size(1023, 108)
        Me.grpbox_Select.TabIndex = 13
        Me.grpbox_Select.TabStop = False
        Me.grpbox_Select.Text = "Filter"
        '
        'combo_department
        '
        Me.combo_department.FormattingEnabled = True
        Me.combo_department.Location = New System.Drawing.Point(147, 59)
        Me.combo_department.Name = "combo_department"
        Me.combo_department.Size = New System.Drawing.Size(218, 20)
        Me.combo_department.TabIndex = 5
        Me.combo_department.Text = "*"
        '
        'btn_Query
        '
        Me.btn_Query.BackColor = System.Drawing.Color.IndianRed
        Me.btn_Query.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_Query.FlatAppearance.BorderSize = 5
        Me.btn_Query.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Query.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Query.Image = Global.CPS.My.Resources.Resources.query
        Me.btn_Query.Location = New System.Drawing.Point(518, 42)
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
        Me.lbl_product.Size = New System.Drawing.Size(65, 12)
        Me.lbl_product.TabIndex = 2
        Me.lbl_product.Text = "Department"
        '
        'combo_ID
        '
        Me.combo_ID.FormattingEnabled = True
        Me.combo_ID.Location = New System.Drawing.Point(148, 20)
        Me.combo_ID.Name = "combo_ID"
        Me.combo_ID.Size = New System.Drawing.Size(218, 20)
        Me.combo_ID.Sorted = True
        Me.combo_ID.TabIndex = 1
        Me.combo_ID.Text = "*"
        '
        'lbl_customer
        '
        Me.lbl_customer.AutoSize = True
        Me.lbl_customer.Location = New System.Drawing.Point(30, 23)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(17, 12)
        Me.lbl_customer.TabIndex = 0
        Me.lbl_customer.Text = "ID"
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 691)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grpbox_Select)
        Me.Name = "frmEmployee"
        Me.Text = "frmEmployee"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGV_employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpbox_Select.ResumeLayout(False)
        Me.grpbox_Select.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_employee_modify As Button
    Friend WithEvents btn_employee_new As Button
    Friend WithEvents btn_employee_delete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_employee As DataGridView
    Friend WithEvents grpbox_Select As GroupBox
    Friend WithEvents btn_Query As Button
    Friend WithEvents lbl_product As Label
    Friend WithEvents combo_ID As ComboBox
    Friend WithEvents lbl_customer As Label
    Friend WithEvents combo_department As ComboBox
End Class
