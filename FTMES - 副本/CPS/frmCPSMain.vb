Imports System.ComponentModel

Public Class frmCPSMain
    Public iii As Integer



    Private Sub frmCPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "FT MES System | Current Login Server -> " & frmLogin.combo_server.Text & ",  | " & MyVersion & " , iTest Semiconductor all rights reserverd."
        TreeView_CPS.BackColor = mydefaultcolor
        Me.BackColor = mydefaultcolor
        ToolStripStatusLabel1.Text = "Current User :  " & UserID & "  , " & UserName & "  , " & UserPosition
        'ToolStripStatusLabel1.BackColor = mydefaultcolor
        StatusStrip1.BackColor = Color.Black
        ToolStripStatusLabel1.ForeColor = Color.OrangeRed
        ToolStripStatusLabel1.ForeColor = Color.White
    End Sub

    Private Sub frmCPS_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        '4   MsgBox("FormClosed")
    End Sub

    Private Sub frmCPS_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        '2  MsgBox("FormClosing")
    End Sub

    Private Sub frmCPS_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        '5  MsgBox("DIsposed")
        frmLogin.Dispose()
    End Sub

    Private Sub frmCPS_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '3  MsgBox("Closed")
    End Sub

    Private Sub frmCPS_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        '1. MsgBox("Closing")
    End Sub

    Private Sub TreeView_CPS_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView_CPS.AfterSelect

        'TreeView_CPS.ImageList = ImageList_CPS

        If Strings.Left(TreeView_CPS.SelectedNode.Text, 1) = "(" And Strings.Right(TreeView_CPS.SelectedNode.Text, 1) = ")" Then
            MsgBox("此功能模块尚在开发中!", vbOKOnly + vbInformation)
            Exit Sub
        End If

        Select Case TreeView_CPS.SelectedNode.Name

            Case "node_customer"

                frmCust.MdiParent = Me
                frmCust.Parent = SplitContainer1.Panel2
                frmCust.Show()
                'frmCust.FormBorderStyle = FormBorderStyle.None
                frmCust.WindowState = FormWindowState.Maximized


            Case "node_product"

                frmProduct.MdiParent = Me
                frmProduct.Parent = SplitContainer1.Panel2
                frmProduct.Show()
                'frmProduct.FormBorderStyle = FormBorderStyle.None
                frmProduct.WindowState = FormWindowState.Maximized

            Case "node_release"

                frmRlsTable.MdiParent = Me
                frmRlsTable.Parent = SplitContainer1.Panel2
                frmRlsTable.Show()
                frmRlsTable.FormBorderStyle = FormBorderStyle.None
                frmRlsTable.WindowState = FormWindowState.Maximized


            Case "node_equipment"

                frmEquipment.MdiParent = Me
                frmEquipment.Parent = SplitContainer1.Panel2
                frmEquipment.Show()
                'frmEquipment.FormBorderStyle = FormBorderStyle.None
                frmEquipment.WindowState = FormWindowState.Maximized

            Case "node_employee"

                frmEmployee.MdiParent = Me
                frmEmployee.Parent = SplitContainer1.Panel2
                frmEmployee.Show()
                'frmEmployee.FormBorderStyle = FormBorderStyle.None
                frmEmployee.WindowState = FormWindowState.Maximized

            Case "node_changepwd"

                frmPwd.MdiParent = Me
                frmPwd.Parent = SplitContainer1.Panel2
                frmPwd.Show()
                'frmPwd.FormBorderStyle = FormBorderStyle.None
                frmPwd.WindowState = FormWindowState.Maximized

            Case "node_accessory"

                frmAccessory.MdiParent = Me
                frmAccessory.Parent = SplitContainer1.Panel2
                frmAccessory.Show()
                'frmAccessory.FormBorderStyle = FormBorderStyle.None
                frmAccessory.WindowState = FormWindowState.Maximized

            Case "node_io"

                frmIOrecord.MdiParent = Me
                frmIOrecord.Parent = SplitContainer1.Panel2
                frmIOrecord.Show()
                'frmIOrecord.FormBorderStyle = FormBorderStyle.None
                frmIOrecord.WindowState = FormWindowState.Maximized

            Case "node_location"

                frmRealLocation.MdiParent = Me
                frmRealLocation.Parent = SplitContainer1.Panel2
                frmRealLocation.Show()
                'frmRealLocation.FormBorderStyle = FormBorderStyle.None
                frmRealLocation.WindowState = FormWindowState.Maximized


            Case "node_receive"

                frmIncoming.MdiParent = Me
                frmIncoming.Parent = SplitContainer1.Panel2
                frmIncoming.Show()
                'frmIncoming.FormBorderStyle = FormBorderStyle.None
                frmIncoming.WindowState = FormWindowState.Maximized


            Case "node_online"

                frmOnline.MdiParent = Me
                frmOnline.Parent = SplitContainer1.Panel2
                frmOnline.Show()
                'frmOnline.FormBorderStyle = FormBorderStyle.None
                frmOnline.WindowState = FormWindowState.Maximized

            Case "node_offline"

                frmOffline.MdiParent = Me
                frmOffline.Parent = SplitContainer1.Panel2
                frmOffline.Show()
                'frmOffline.FormBorderStyle = FormBorderStyle.None
                frmOffline.WindowState = FormWindowState.Maximized

            Case "node_ship"

                frmShipping.MdiParent = Me
                frmShipping.Parent = SplitContainer1.Panel2
                frmShipping.Show()
                'frmShipping.FormBorderStyle = FormBorderStyle.None
                frmShipping.WindowState = FormWindowState.Maximized

            Case "node_label_mc"

                frmLabel.MdiParent = Me
                frmLabel.Parent = SplitContainer1.Panel2
                frmLabel.Show()
                frmLabel.FormBorderStyle = FormBorderStyle.None
                frmLabel.WindowState = FormWindowState.Maximized

            Case "node_ts"

                frmTSprint.MdiParent = Me
                frmTSprint.Parent = SplitContainer1.Panel2
                frmTSprint.Show()
                frmTSprint.FormBorderStyle = FormBorderStyle.None
                frmTSprint.WindowState = FormWindowState.Maximized

            Case "node_waferocr"

                frmWaferOCR.MdiParent = Me
                frmWaferOCR.Parent = SplitContainer1.Panel2
                frmWaferOCR.Show()
                frmWaferOCR.FormBorderStyle = FormBorderStyle.None
                frmWaferOCR.WindowState = FormWindowState.Maximized


            Case "node_checkIO"

                frmCheckIO.MdiParent = Me
                frmCheckIO.Parent = SplitContainer1.Panel2
                frmCheckIO.Show()
                'frmCheckIO.FormBorderStyle = FormBorderStyle.None
                frmCheckIO.WindowState = FormWindowState.Maximized

            Case "node_prodmonitor"

                frmProdMonitor.MdiParent = Me
                frmProdMonitor.Parent = SplitContainer1.Panel2
                frmProdMonitor.Show()
                frmProdMonitor.FormBorderStyle = FormBorderStyle.None
                frmProdMonitor.WindowState = FormWindowState.Maximized

            Case "node_splitlot"

                frmSplitLot.MdiParent = Me
                frmSplitLot.Parent = SplitContainer1.Panel2
                frmSplitLot.Show()
                frmSplitLot.FormBorderStyle = FormBorderStyle.None
                frmSplitLot.WindowState = FormWindowState.Maximized

            Case "node_hold"

                frmHold.MdiParent = Me
                frmHold.Parent = SplitContainer1.Panel2
                frmHold.Show()
                'frmHold.FormBorderStyle = FormBorderStyle.None
                frmHold.WindowState = FormWindowState.Maximized


            Case "node_wipquery"

                Shell(Application.StartupPath & "\WIPRPT.exe", vbNormalFocus)

                'FileName = Application.StartupPath & "\DemoEXE.exe"
                'System.Diagnostics.Process.Start(FileName)

            Case Else


        End Select

    End Sub



    '此Sub主要用于功能模块权限管控
    '''Private Sub TreeView_CPS_AfterExpand(sender As Object, e As TreeViewEventArgs) Handles TreeView_CPS.AfterExpand
    '''    Select Case TreeView_CPS.SelectedNode.Name
    '''        Case "node_customer"

    '''        Case "node_product"


    '''        Case "node_noaccess"
    '''            TreeView_CPS.SelectedNode.Collapse(True)
    '''            MsgBox("您没有此项目权限!", vbOKOnly + vbExclamation)


    '''        Case Else


    '''    End Select
    '''End Sub

    Private Sub TreeView_CPS_Click(sender As Object, e As EventArgs) Handles TreeView_CPS.Click

        TreeView_CPS.SelectedNode = Nothing

    End Sub

End Class