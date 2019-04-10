Imports System.Data.SqlClient

Public Class frmCheckIO

    Private Sub frmCheckIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
        DGV_checkio.BackgroundColor = mydefaultcolor
        txt_cust.BackColor = mydefaultcolor
    End Sub

    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown


        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Fail !")

        Else

            combo_cust.Items.Clear()
            combo_cust.Items.Add("*")
            For i = 0 To mydataset.Tables("Cust").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Cust").Rows(i).Item("ename"))
            Next

        End If

    End Sub

    Private Sub combo_cust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cust.SelectedIndexChanged

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_cust.Text <> "*" Then

            mysql = "select * from Customer where ename='" & combo_cust.Text & "'"

            Dim myadapter As New SqlDataAdapter(mysql, myconn)

            myadapter.Fill(mydataset, "Cust")

            If mydataset.Tables("Cust").Rows.Count = 0 Then
                txt_cust.Text = ""

            Else
                txt_cust.Text = mydataset.Tables("Cust").Rows(i).Item("cname")
            End If

        End If

    End Sub



    Private Sub combo_step_DropDown(sender As Object, e As EventArgs) Handles combo_step.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT CurrentStep from WIPLOT"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then

        Else

            combo_step.Items.Clear()
            combo_step.Items.Add("*")

            '排除掉 收货站 RCV 以及 出货站 INV
            For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
                If mydataset.Tables("WIP").Rows(i).Item("CurrentStep") <> "RCV" And mydataset.Tables("WIP").Rows(i).Item("CurrentStep") <> "INV" Then
                    combo_step.Items.Add(mydataset.Tables("WIP").Rows(i).Item("CurrentStep"))
                End If
            Next

        End If

    End Sub



    Private Sub combo_status_DropDown(sender As Object, e As EventArgs) Handles combo_status.DropDown

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Status from WIPLOT"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then

        Else

            combo_status.Items.Clear()
            combo_status.Items.Add("*")

            '只留下CHECKIN 和 CHECKOUT 两种状态，表示在途的货批
            For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
                If mydataset.Tables("WIP").Rows(i).Item("Status") = "CHECKIN" Or mydataset.Tables("WIP").Rows(i).Item("Status") = "CHECKOUT" Then
                    combo_status.Items.Add(mydataset.Tables("WIP").Rows(i).Item("Status"))
                End If
            Next

        End If


    End Sub

    Public Sub btn_Query_Click(sender As Object, e As EventArgs) Handles btn_Query.Click
        Dim mysql As String
        Dim mydataset As New DataSet

        DGV_checkio.DataSource = Nothing

        If combo_cust.Text = "" Then
            MsgBox("Please select Customer first!", vbOKOnly + vbExclamation)
            Exit Sub
        End If

        Select Case combo_cust.Text

            ' select * from WIPLOT where Status not in ('RCVING','SMDONE')

            Case "*"

                If combo_step.Text = "*" Then
                    If combo_status.Text = "*" Then
                        mysql = "select * from WIPLOT where Status NOT IN ('INV','SMDONE')"
                    Else
                        mysql = "select * from WIPLOT where Status='" & combo_status.Text & "'"
                    End If
                Else
                    If combo_status.Text = "*" Then
                        mysql = "select * from WIPLOT where CurrentStep = '" & combo_step.Text & "' AND Status NOT IN ('INV','SMDONE')"
                    Else
                        mysql = "select * from WIPLOT where CurrentStep = '" & combo_step.Text & "' AND Status='" & combo_status.Text & "'"
                    End If
                End If


            Case Else '选择指定客户时

                If combo_step.Text = "*" Then
                    If combo_status.Text = "*" Then
                        mysql = "select * from WIPLOT where CUSTENG='" & combo_cust.Text & "' AND Status NOT IN ('INV','SMDONE')"
                    Else
                        mysql = "select * from WIPLOT where CUSTENG='" & combo_cust.Text & "' AND Status='" & combo_status.Text & "'"
                    End If
                Else
                    If combo_status.Text = "*" Then
                        mysql = "select * from WIPLOT where CUSTENG='" & combo_cust.Text & "' AND  CurrentStep = '" & combo_step.Text & "' AND Status NOT IN ('INV','SMDONE')"
                    Else
                        mysql = "select * from WIPLOT where CUSTENG='" & combo_cust.Text & "' AND  CurrentStep = '" & combo_step.Text & "' AND Status='" & combo_status.Text & "'"
                    End If
                End If

        End Select


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            DGV_checkio.DataSource = Nothing

        Else
            DGV_checkio.DataSource = mydataset.Tables("WIP")
        End If

    End Sub

    Private Sub btn_checkio_Click(sender As Object, e As EventArgs) Handles btn_checkio.Click

        Dim mysql As String, s As Integer

        Dim i As Integer
        Dim CheckInForm As Form, CheckOutForm As Form

        If DGV_checkio.Rows.Count = 0 Then Exit Sub

        mycheckio.custeng = DGV_checkio.SelectedRows(0).Cells("CUSTENG").Value.ToString
        mycheckio.iprod = DGV_checkio.SelectedRows(0).Cells("iTestProduct").Value.ToString
        mycheckio.ilot = DGV_checkio.SelectedRows(0).Cells("iTestLotNo").Value.ToString
        mycheckio.clot = DGV_checkio.SelectedRows(0).Cells("CustLotNo").Value.ToString
        mycheckio.CurrentStep = DGV_checkio.SelectedRows(0).Cells("CurrentStep").Value.ToString
        mycheckio.status = DGV_checkio.SelectedRows(0).Cells("Status").Value.ToString
        mycheckio.waferqty = DGV_checkio.SelectedRows(0).Cells("CurrentWaferQty").Value.ToString
        mycheckio.waferlist = DGV_checkio.SelectedRows(0).Cells("WaferList").Value.ToString

        'Flow正确性确认
        mycheckio.flowid = GetFlowIDbyLotNo(mycheckio.custeng, mycheckio.iprod, mycheckio.ilot)

        If mycheckio.flowid = "" Then
            MsgBox("查询不到此型号的流程，无法派工，请联系PTE处理!", vbOKOnly + vbExclamation)
            Exit Sub
        End If


        'Step正确性确认
        Call GetStepNameArraybyFlowID(mycheckio.custeng, mycheckio.iprod, mycheckio.ilot, mycheckio.flowid)

        If UBound(mystep) = 0 Then
            MsgBox("查询不到此型号的具体作业站信息，无法派工，请联系PTE处理!", vbOKOnly + vbExclamation)
            Exit Sub

        ElseIf UBound(mystep) > 0 Then
            For i = 1 To UBound(mystep) - 1
                If mystep(i).name = "" Or mystep(i).id = "" Then
                    MsgBox("作业站设定异常: 站别名->" & mystep(i).name & ",RecipeID->" & mystep(i).id, vbOKOnly + vbExclamation)
                    Exit Sub
                End If
            Next

        End If


        If mycheckio.status = "CHECKIN" Then

            Select Case mycheckio.CurrentStep
                Case ""
                    MsgBox("当前站别名为空，无法进站，请联系有关人员确认!", vbOKOnly + vbExclamation)
                    Exit Sub
                Case "IQC"
                    CheckInForm = frmCheckInQC
                Case "CP1", "CP2", "CP3", "CP4", "CP5", "CP6", "CP7", "CP8", "CP9"
                    CheckInForm = frmCheckInCP
                Case "SHIP"
                    MsgBox("当前站别已到SHIP，产线作业无法进站，请通知物管进行<完工>确认!", vbOKOnly + vbExclamation)
                    Exit Sub
                Case Else 'FQC 站别 CheckIn 也调用Basic Form
                    CheckInForm = frmCheckInBasic
            End Select

            CheckInForm.Show()


        ElseIf mycheckio.status = "CHECKOUT" Then

            Select Case mycheckio.CurrentStep
                Case ""
                    MsgBox("当前站别名为空，无法出站，请联系有关人员确认!", vbOKOnly + vbExclamation)
                    Exit Sub
                Case "IQC", "FQC" 'FQC CheckOut 时调用QC Form
                    CheckOutForm = frmCheckOutQC
                Case "CP1", "CP2", "CP3", "CP4", "CP5", "CP6", "CP7", "CP8", "CP9"
                    CheckOutForm = frmCheckOutCP
                Case "SHIP"
                    MsgBox("当前站别已到SHIP，产线作业无法出站，请通知物管进行<出货>作业!", vbOKOnly + vbExclamation)
                    Exit Sub
                Case Else
                    CheckOutForm = frmCheckOutBasic
            End Select


            CheckOutForm.Show()

        Else

            MsgBox("该批次状态不为CheckIN/OUT,无法作业!", vbOKOnly + vbInformation)

        End If



    End Sub

End Class