<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductDefForm
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
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.DGV_ProductDef = New System.Windows.Forms.DataGridView()
        CType(Me.DGV_ProductDef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_confirm
        '
        Me.btn_confirm.Location = New System.Drawing.Point(279, 152)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(146, 34)
        Me.btn_confirm.TabIndex = 1
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(520, 154)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(137, 31)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'DGV_ProductDef
        '
        Me.DGV_ProductDef.AllowUserToAddRows = False
        Me.DGV_ProductDef.AllowUserToDeleteRows = False
        Me.DGV_ProductDef.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DGV_ProductDef.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ProductDef.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DGV_ProductDef.Location = New System.Drawing.Point(2, 2)
        Me.DGV_ProductDef.Name = "DGV_ProductDef"
        Me.DGV_ProductDef.RowHeadersVisible = False
        Me.DGV_ProductDef.RowTemplate.Height = 23
        Me.DGV_ProductDef.Size = New System.Drawing.Size(956, 119)
        Me.DGV_ProductDef.TabIndex = 3
        '
        'ProductDefForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(958, 216)
        Me.Controls.Add(Me.DGV_ProductDef)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_confirm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "ProductDefForm"
        Me.Text = "ProductDefForm"
        CType(Me.DGV_ProductDef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents DGV_ProductDef As DataGridView
End Class
