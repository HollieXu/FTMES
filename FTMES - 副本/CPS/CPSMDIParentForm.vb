Imports System.Windows.Forms

Public Class CPSMDIParentForm

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewWindowToolStripMenuItem.Click
        ' 创建此子窗体的一个新实例。
        Dim ChildForm As New System.Windows.Forms.Form
        ' 在显示该窗体前使其成为此 MDI 窗体的子窗体。
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "窗口 " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: 在此处添加打开文件的代码。
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: 在此处添加代码，将窗体的当前内容保存到一个文件中。
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' 使用 My.Computer.Clipboard 将选择的文本或图像插入剪贴板
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        '使用 My.Computer.Clipboard.GetText() 或 My.Computer.Clipboard.GetData 从剪贴板检索信息。
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' 关闭此父窗体的所有子窗体。
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub RECIPT1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECIPT1ToolStripMenuItem.Click

    End Sub

    Private Sub CPSMDIParentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub



    Private Sub PRODUCTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTToolStripMenuItem.Click

    End Sub

    Private Sub WIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WIPToolStripMenuItem.Click
        Dim frmWIP As New WIPForm
        CheckForm(frmWIP, "WIPForm")
        frmWIP.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PRODUCTToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PRODUCTToolStripMenuItem1.Click
        Dim frmProductSetting As New ProductSettingForm
        '  frmProductSetting.MdiParent = Me
        '    frmProductSetting.Show()
        CheckForm(frmProductSetting, "ProductSettingForm")
        frmProductSetting.WindowState = FormWindowState.Maximized
    End Sub









    '*****************************************************************************  
    '*过程名称：CheckForm  
    '*参数说明：MDIChildForm——需检测的窗体；MDIChildFormName ——检测窗体的名字  
    '*功能说明：首先检测是否有MDI子窗体，如果没有，则创该MDI子窗体的窗体实例  
    '*                    如果有，则检测当中有没有其窗体实例，有则激活；没有则创建其窗体实例  
    '*****************************************************************************  
    Private Sub CheckForm(ByVal MDIChildForm As Form, ByVal MDIChildFormName As String)
        If Me.MdiChildren.Length < 1 Then
            '如果没有任何一个MDI子窗体，则创该MDI子窗体的窗体实例  
            ShowForm(MDIChildForm)
            Exit Sub
        Else
            Dim x As Integer
            Dim frmyn As Boolean
            For x = 0 To (Me.MdiChildren.Length) - 1
                Dim tempChild As Form = CType(Me.MdiChildren(x), Form)
                If tempChild.Name = MDIChildFormName Then
                    frmyn = True
                    '检测到有该MDI子窗体，设为TRUE 并退出循环  
                    Exit For
                Else
                    frmyn = False
                End If
            Next
            If frmyn = False Then
                '在打开的窗体中没检测到则新建  
                ShowForm(MDIChildForm)
            Else
                '在打开的窗体中检测到则激活  
                Dim MDIChildFrm As Form = CType(Me.MdiChildren(x), Form)
                MDIChildFrm.Activate()  '使子窗体激活  
                MDIChildFrm.WindowState = FormWindowState.Maximized
            End If
        End If
    End Sub

    '**************************************************  
    '*过程名称：ShowForm  
    '*参数说明：MDIChildForm ——需创建实例的窗体  
    '*功能说明：创建窗体实例  
    '**************************************************  
    Private Sub ShowForm(ByVal MDIChildForm As Form)
        Dim MDIChildFrm As Form = MDIChildForm
        MDIChildFrm.MdiParent = Me ' 定义MDI子窗体  
        MDIChildFrm.Show() '打开窗体  
    End Sub











End Class



