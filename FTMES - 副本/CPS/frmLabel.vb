Imports System.Data.SqlClient

Public Class frmLabel


    Private Sub frmLabel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = mydefaultcolor

        Select Case LabelType
            Case "IN"
                rb_InLabel.Checked = True
                rb_OutLabel.Visible = False
                rb_holdlot.Visible = False
                txt_lotid.Text = LabelLot
            Case "OUT"
                rb_OutLabel.Checked = True
                rb_InLabel.Visible = False
                rb_holdlot.Visible = False
                txt_lotid.Text = LabelLot
            Case "HOLD"
                rb_holdlot.Checked = True
                rb_OutLabel.Visible = False
                rb_InLabel.Visible = False
            Case Else

        End Select

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        Dim mylot As WIPLOTTYPE
        Dim waferliststr As String
        Dim mysql As String
        Dim mydataset As New DataSet

        If txt_lotid.Text = "" Then
            MsgBox("请先输入生产批号!", vbOKOnly + vbInformation)
            Exit Sub
        End If


        '获取WIPINFO主表信息
        mysql = "select * from WIPLOT where iTestLotNo='" & txt_lotid.Text & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            MsgBox("Query Lot Info Fail !", vbOKOnly + vbExclamation)
            Exit Sub
        Else
            mylot.custeng = mydataset.Tables("WIP").Rows(0).Item("CUSTENG")
            mylot.cprod = mydataset.Tables("WIP").Rows(0).Item("CustProduct")
            mylot.clot = mydataset.Tables("WIP").Rows(0).Item("CustLotNo")
            mylot.iprod = mydataset.Tables("WIP").Rows(0).Item("iTestProduct")
            mylot.ilot = mydataset.Tables("WIP").Rows(0).Item("iTestLotNo")
            mylot.waferqty = mydataset.Tables("WIP").Rows(0).Item("CurrentWaferQty")
            mylot.waferlist = mydataset.Tables("WIP").Rows(0).Item("WaferList").ToString
            mylot.fprod = mydataset.Tables("WIP").Rows(0).Item("FabProduct")
            mylot.flot = mydataset.Tables("WIP").Rows(0).Item("FabLotNo")

            If mydataset.Tables("WIP").Rows(0).Item("GoodDieQty").ToString = "" Then
                mylot.finalgooddie = 0
            Else
                mylot.finalgooddie = mydataset.Tables("WIP").Rows(0).Item("GoodDieQty")
            End If

        End If

        waferliststr = FormatWaferlist2(mylot.waferlist)


        '列印进货标签
        If rb_InLabel.Checked = True Then
            If InLabel_itest_Print(mylot.custeng, mylot.cprod, mylot.clot, mylot.iprod, mylot.ilot, mylot.waferqty, waferliststr, Format(Now(), "yyyy-MM-dd")) = True Then
                MsgBox("打印成功!", vbOKOnly + vbInformation)
            Else
                MsgBox("打印失败!", vbOKOnly + vbExclamation)
            End If
        End If

        '列印出货标签
        If rb_OutLabel.Checked = True Then
            If OutLabel_itest_Print(mylot.custeng, mylot.cprod, mylot.clot, mylot.fprod, mylot.flot, mylot.waferqty, waferliststr, CStr(mylot.finalgooddie), Format(Now(), "yyyy-MM-dd")) = True Then
                MsgBox("打印成功!", vbOKOnly + vbInformation)
            Else
                MsgBox("打印失败!", vbOKOnly + vbExclamation)
            End If
        End If

        If rb_holdlot.Checked = True Then
            MsgBox("还未开发")
        End If

    End Sub

    Private Sub frmLabel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        LabelType = ""
        LabelLot = ""
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        LabelType = ""
        LabelLot = ""
        Me.Close()
    End Sub
End Class