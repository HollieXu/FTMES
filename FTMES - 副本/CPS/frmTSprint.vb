

Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel



Public Class frmTSprint

    Public customer As String
    Public product As String
    Public flowid As String
    Public iLot As String


    Private Sub frmTSprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Left = 10
        Me.Top = 10

        Me.BackColor = mydefaultcolor
        rtb_flowinfo.BackColor = mydefaultcolor
        rtb_rule.BackColor = mydefaultcolor

        '如果是从 工程资料设定界面过来的，则带入 客户 及 产品信息
        If RuncardPrint_Mode = "BYENG" Then
            combo_cust.Text = myProduct.Customer
            combo_iprod.Text = myProduct.InternalProduct
        End If

    End Sub




    Private Sub combo_id_DropDown(sender As Object, e As EventArgs) Handles combo_id.DropDown
        Dim i As Integer

        If combo_type.Text = "" Then Exit Sub


        Dim mysql As String
        Dim mydataset As New DataSet

        If combo_type.Text = "ECN" Then
            mysql = "select * from Flow where Customer=" & "'" & combo_cust.Text & "' AND InternalProduct=" & "'" & combo_iprod.Text & "' AND Type=" & "'ECN' AND ENABLE='TRUE'"
        ElseIf combo_type.Text = "SEN" Then
            mysql = "select * from Flow where Customer=" & "'" & combo_cust.Text & "' AND InternalProduct=" & "'" & combo_iprod.Text & "' AND Type=" & "'SEN' AND ENABLE='TRUE'"
        End If


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Flow")

        If mydataset.Tables("Flow").Rows.Count = 0 Then

        Else

            combo_id.Items.Clear()

            For i = 0 To mydataset.Tables("Flow").Rows.Count - 1
                combo_id.Items.Add(mydataset.Tables("Flow").Rows(i).Item("ID"))
            Next

        End If
    End Sub



    Private Sub combo_lot_DropDown(sender As Object, e As EventArgs) Handles combo_lot.DropDown
        Dim i As Integer
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim str As String, strarray() As String

        If combo_type.Text = "ECN" Then
            combo_lot.Text = ""
            combo_lot.Items.Clear()
            Exit Sub
        End If


        If combo_type.Text = "SEN" Then

            mysql = "select * from Flow where ID=" & "'" & combo_id.Text & "'"
            Dim myadapter As New SqlDataAdapter(mysql, myconn)
            myadapter.Fill(mydataset, "Flow")

            If mydataset.Tables("Flow").Rows.Count = 0 Then
                'do nothing
            Else
                combo_lot.Items.Clear()
                str = mydataset.Tables("Flow").Rows(0).Item("ilot").ToString
                strarray = Split(str, vbCrLf)

                For i = 0 To UBound(strarray)
                    combo_lot.Items.Add(strarray(i))
                Next

            End If

        End If
    End Sub

    Private Sub btn_query_Click(sender As Object, e As EventArgs) Handles btn_query.Click

        Dim i As Integer
        Dim mysql As String
        Dim mydataset As New DataSet


        rtb_flowinfo.Text = ""

        If txt_ilot.Text <> "" Then '直接输入批号查询模式，适用于生产线

            RuncardPrint_Mode = "BYLOT"


            '获取customer & prod 信息
            iLot = txt_ilot.Text
            mysql = "select * from WIPLOT where iTestLotNo=" & "'" & iLot & "'"
            Dim myadapter As New SqlDataAdapter(mysql, myconn)
            myadapter.Fill(mydataset, "WIP")

            If mydataset.Tables("WIP").Rows.Count = 0 Then
                MsgBox("获取客户/产品信息失败!", vbOKOnly + vbExclamation)
                Exit Sub
            Else
                customer = mydataset.Tables("WIP").Rows(0).Item("CUSTENG").ToString
                product = mydataset.Tables("WIP").Rows(0).Item("iTestProduct").ToString
            End If

            'Flow正确性确认
            flowid = GetFlowIDbyLotNo(customer, product, iLot)

            If flowid = "" Then
                MsgBox("查询不到此型号的流程,请联系PTE处理!", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            'Step正确性确认
            Call GetStepNameArraybyFlowID(customer, product, iLot, flowid)

            If UBound(mystep) = 0 Then
                MsgBox("查询不到此型号的具体作业站信息,请联系PTE处理!", vbOKOnly + vbExclamation)
                Exit Sub
            ElseIf UBound(mystep) > 0 Then

                For i = 1 To UBound(mystep) - 1
                    If mystep(i).name = "" Or mystep(i).id = "" Then
                        'MsgBox("作业站设定异常: 站别名->" & mystep(i).name & ",RecipeID->" & mystep(i).id, vbOKOnly + vbExclamation)
                        'Exit Sub
                        rtb_flowinfo.Text += Mid(mystep(i).name & "          ", 1, 10) & ":  " & mystep(i).id & vbCrLf
                    Else
                        rtb_flowinfo.Text += Mid(mystep(i).name & "          ", 1, 10) & ":  " & mystep(i).id & vbCrLf
                    End If
                Next

            End If


        Else

            RuncardPrint_Mode = "BYENG" ' 工程查询模式，适用于条件筛选

            If combo_cust.Text = "" Or combo_iprod.Text = "" Or combo_type.Text = "" Or combo_id.Text = "" Then
                MsgBox("请先设定删选条件！", vbOKOnly + vbExclamation)
                Exit Sub
            End If

            If combo_type.Text = "SEN" And combo_lot.Text = "" Then
                    MsgBox("请先设定SEN Flow的内部批号！", vbOKOnly + vbExclamation)
                    Exit Sub
                End If

                customer = combo_cust.Text
                product = combo_iprod.Text
                iLot = combo_lot.Text
                flowid = combo_id.Text

                Call GetStepNameArraybyFlowID(customer, product, iLot, flowid)

                For i = 1 To UBound(mystep) - 1
                    If mystep(i).name <> "" Then
                        rtb_flowinfo.Text += Mid(mystep(i).name & "          ", 1, 10) & ":  " & mystep(i).id & vbCrLf
                    End If
                Next


            End If



    End Sub



    Private Sub combo_preview_Click(sender As Object, e As EventArgs) Handles combo_preview.Click

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        Dim myexcel As New Excel.Application()

        Dim template As String
        Dim blank As String
        Dim desfile As String

        Dim mapfile() As String, map_idx As Integer, mapattachname As String, Localmap As String, Servermap As String

        On Error GoTo ErrorHandle


        template = Application.StartupPath & "\template\cp_runcard.xlsx"
        blank = Application.StartupPath & "\template\blank.xlsx"
        desfile = Application.StartupPath & "\tempdata\runcard.xlsx"



        '复制空白Excel
        FileCopy(blank, desfile)

        Dim mybk1 As Excel.Workbook = myexcel.Workbooks.Open(template)
        Dim mybk2 As Excel.Workbook = myexcel.Workbooks.Open(desfile)

        myexcel.Visible = False
        myexcel.DisplayAlerts = False
        myexcel.AlertBeforeOverwriting = False
        myexcel.WindowState = Excel.XlWindowState.xlMaximized

        '------------------------------
        '写入BASIC页信息
        '------------------------------
        mybk1.Worksheets("BASIC").copy(After:=mybk2.Worksheets(1))
        mybk2.Worksheets(mybk2.Worksheets.Count).name = "BASIC"

        With mybk2.Worksheets(mybk2.Worksheets.Count)
            .range("Q6") = customer
            .range("Q7") = product

            mysql = "select * from Product where InternalProduct=" & "'" & product & "'"
            Dim myadapter As New SqlDataAdapter(mysql, myconn)
            myadapter.Fill(mydataset, "PROD")

            If mydataset.Tables("PROD").Rows.Count = 0 Then
                MsgBox("获取产品信息失败!", vbOKOnly + vbExclamation)
                GoTo ErrorHandle
            Else
                .range("Q8") = mydataset.Tables("PROD").Rows(0).Item("CustomerProduct").ToString
                .range("Q9") = mydataset.Tables("PROD").Rows(0).Item("FabProduct").ToString
                .range("Q10") = mydataset.Tables("PROD").Rows(0).Item("ShipProduct").ToString
                .range("Q12") = mydataset.Tables("PROD").Rows(0).Item("Type").ToString
                .range("Q13") = mydataset.Tables("PROD").Rows(0).Item("Bund").ToString
                .range("Q14") = mydataset.Tables("PROD").Rows(0).Item("RetestFlow").ToString
                .range("Q15") = mydataset.Tables("PROD").Rows(0).Item("WaferSize").ToString
                .range("Q16") = mydataset.Tables("PROD").Rows(0).Item("GDPW").ToString
                .range("Q17") = "Mapping" '出货方式目前固定为Mapping
            End If

            mydataset.Clear()

            For i = 1 To UBound(mystep) - 1
                .range("A" & （21 + i）) = i
                .range("I" & （21 + i）) = mystep(i).name
            Next


            If RuncardPrint_Mode = "BYLOT" Then
                .range("AV7") = iLot

                mysql = "select * from WIPLOT where iTestLotNo=" & "'" & iLot & "'"
                Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                myadapter2.Fill(mydataset, "WIP")

                If mydataset.Tables("WIP").Rows.Count = 0 Then
                    MsgBox("获取批次信息失败!", vbOKOnly + vbExclamation)
                    GoTo ErrorHandle
                Else
                    .range("AV6") = mydataset.Tables("WIP").Rows(0).Item("Priority").ToString
                    .range("AV8") = mydataset.Tables("WIP").Rows(0).Item("CustLotNo").ToString
                    .range("AV9") = mydataset.Tables("WIP").Rows(0).Item("FabLotNo").ToString
                    .range("AV10") = mydataset.Tables("WIP").Rows(0).Item("ShipLotNo").ToString
                    .range("AV12") = mydataset.Tables("WIP").Rows(0).Item("ProductType").ToString
                    .range("AV13") = mydataset.Tables("WIP").Rows(0).Item("ReceivingWaferQty").ToString
                    .range("AV14") = mydataset.Tables("WIP").Rows(0).Item("CurrentWaferQty").ToString
                    .range("AV15") = mydataset.Tables("WIP").Rows(0).Item("CODE").ToString
                    .range("AV16") = mydataset.Tables("WIP").Rows(0).Item("ReceivingDate").ToString
                    .range("AV17") = Format(Now(), "yyyy/MM/dd HH:mm:ss")
                    .range("Q18") = mydataset.Tables("WIP").Rows(0).Item("iTestOrder").ToString
                    .range("AV18") = mydataset.Tables("WIP").Rows(0).Item("Creater").ToString
                    .range("AV6") = mydataset.Tables("WIP").Rows(0).Item("Priority").ToString
                End If

                mydataset.Clear()

            End If

        End With

        '------------------------------
        '写入WaferOCR页信息, 暂未开发, 逻辑上WaferOCR 是在IQC确定片号后才可产生，但流程卡在物管已经列印. 
        '因此计划单独生成接口按钮由User另行调用
        '------------------------------
        'mybk1.Worksheets("WaferOCR").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
        'mybk2.Worksheets(mybk2.Worksheets.Count).name = "WaferOCR"

        'With mybk2.Worksheets(mybk2.Worksheets.Count)


        'End With


        '-----------------------------
        '写入每个站别信息
        '-----------------------------

        For i = 1 To UBound(mystep) - 1

            Select Case mystep(i).name

                Case "IQC"
                    mybk1.Worksheets("IQC").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name

                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_IQC where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter3 As New SqlDataAdapter(mysql, myconn)
                        myadapter3.Fill(mydataset, "IQC")

                        If mydataset.Tables("IQC").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("A7") = mydataset.Tables("IQC").Rows(0).Item("SamplingPlan").ToString
                            .range("A10") = mydataset.Tables("IQC").Rows(0).Item("InspectionArea").ToString
                            .range("A13") = mydataset.Tables("IQC").Rows(0).Item("Standard").ToString

                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With


                Case "CP1", "CP2", "CP3", "CP4", "CP5", "CP6", "CP7", "CP8", "CP9"
                    mybk1.Worksheets("CP").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name

                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product

                        .range("A2") = Format(i, "000")
                        .range("G2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_CP where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter4 As New SqlDataAdapter(mysql, myconn)
                        myadapter4.Fill(mydataset, "CP")

                        If mydataset.Tables("CP").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("A3") = mydataset.Tables("CP").Rows(0).Item("tester").ToString
                            .range("M3") = mydataset.Tables("CP").Rows(0).Item("pgm").ToString
                            .range("BB3") = mydataset.Tables("CP").Rows(0).Item("pid").ToString
                            .range("AR4") = "PROD" '待添加UI层 Mode
                            .range("G7") = mydataset.Tables("CP").Rows(0).Item("probecard").ToString
                            .range("R7") = mydataset.Tables("CP").Rows(0).Item("pib").ToString
                            .range("AA7") = mydataset.Tables("CP").Rows(0).Item("prober").ToString
                            .range("AG7") = mydataset.Tables("CP").Rows(0).Item("setupfile").ToString
                            .range("AS7") = mydataset.Tables("CP").Rows(0).Item("temp").ToString
                            .range("AV7") = mydataset.Tables("CP").Rows(0).Item("sw").ToString
                            .range("AZ7") = mydataset.Tables("CP").Rows(0).Item("dc").ToString
                            .range("BE7") = mydataset.Tables("CP").Rows(0).Item("od").ToString
                            .range("AS9") = mydataset.Tables("CP").Rows(0).Item("tt").ToString
                            .range("AV9") = mydataset.Tables("CP").Rows(0).Item("sheetmaterial").ToString
                            .range("AZ9") = mydataset.Tables("CP").Rows(0).Item("cleanfreq").ToString
                            .range("BE9") = mydataset.Tables("CP").Rows(0).Item("updown").ToString
                            .range("A11") = mydataset.Tables("CP").Rows(0).Item("testeroperation").ToString
                            .range("AE11") = mydataset.Tables("CP").Rows(0).Item("proberoperation").ToString
                            .range("A14") = mydataset.Tables("CP").Rows(0).Item("holdtiming").ToString
                            .range("A17") = mydataset.Tables("CP").Rows(0).Item("remark").ToString

                            '收集mapshift图片设定文件到数组中，最后再一起显示出来
                            mapattachname = mydataset.Tables("CP").Rows(0).Item("AttachPic").ToString
                            If mapattachname <> "" Then
                                If Strings.Right(mapattachname, 4) = "xlsx" Or Strings.Right(mapattachname, 4) = ".xls" Then
                                    map_idx += 1
                                    ReDim Preserve mapfile(map_idx)
                                    mapfile(map_idx - 1) = mapattachname
                                End If
                            End If

                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With


                Case "BAKE1", "BAKE2", "BAKE3", "BAKE4", "BAKE5", "BAKE6", "BAKE7", "BAKE8", "BAKE9", "BAKE10"
                    mybk1.Worksheets("BAKE").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name


                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_BAKE where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter5 As New SqlDataAdapter(mysql, myconn)
                        myadapter5.Fill(mydataset, "BAKE")

                        If mydataset.Tables("BAKE").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("I4") = mydataset.Tables("BAKE").Rows(0).Item("Recipe").ToString
                            .range("I5") = mydataset.Tables("BAKE").Rows(0).Item("Temperature").ToString
                            .range("I6") = mydataset.Tables("BAKE").Rows(0).Item("Time").ToString
                            .range("AC6") = mydataset.Tables("BAKE").Rows(0).Item("Time") * 60
                            .range("A9") = mydataset.Tables("BAKE").Rows(0).Item("Remark").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With


                Case "CP1DT", "CP2DT", "CP3DT", "CP4DT", "CP5DT", "CP6DT", "CP7DT", "CP8DT", "CP9DT"
                    mybk1.Worksheets("CPDT").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name


                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_CPDT where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter6 As New SqlDataAdapter(mysql, myconn)
                        myadapter6.Fill(mydataset, "CPDT")

                        If mydataset.Tables("CPDT").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("A4") = mydataset.Tables("CPDT").Rows(0).Item("Hold").ToString
                            .range("A6") = mydataset.Tables("CPDT").Rows(0).Item("Operation").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With



                Case "WIPFS"
                    mybk1.Worksheets("WIPFS").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name


                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_WIPFS where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter7 As New SqlDataAdapter(mysql, myconn)
                        myadapter7.Fill(mydataset, "WIPFS")

                        If mydataset.Tables("WIPFS").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("I4") = mydataset.Tables("WIPFS").Rows(0).Item("MappingFlow").ToString
                            .range("A7") = mydataset.Tables("WIPFS").Rows(0).Item("Operation").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With



                Case "FQC"
                    mybk1.Worksheets("FQC").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name


                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_FQC where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter8 As New SqlDataAdapter(mysql, myconn)
                        myadapter8.Fill(mydataset, "FQC")

                        If mydataset.Tables("FQC").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("A4") = mydataset.Tables("FQC").Rows(0).Item("SamplingPlan").ToString
                            .range("A7") = mydataset.Tables("FQC").Rows(0).Item("InspectionArea").ToString
                            .range("A10") = mydataset.Tables("FQC").Rows(0).Item("Standard").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With

                Case "PACK"
                    mybk1.Worksheets("PACK").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name

                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_PACK where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter9 As New SqlDataAdapter(mysql, myconn)
                        myadapter9.Fill(mydataset, "PACK")

                        If mydataset.Tables("PACK").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("I4") = mydataset.Tables("PACK").Rows(0).Item("Recipe").ToString
                            .range("A5") = mydataset.Tables("PACK").Rows(0).Item("Operation").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With



                Case "SHIP"
                    mybk1.Worksheets("SHIP").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                    mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name


                    With mybk2.Worksheets(mybk2.Worksheets.Count)

                        .range("A1") = "产品型号(Product):      " & product
                        .range("A2") = Format(i, "000")
                        .range("I2") = mystep(i).name
                        .range("AL2") = mystep(i).id

                        If Mid(mystep(i).id, 2, 1) = "E" Then
                            .range("AG2") = "ECN"
                        ElseIf Mid(mystep(i).id, 2, 1) = "S" Then
                            .range("AG2") = "SEN"
                        End If

                        mysql = "select * from Recipe_SHIP where ID=" & "'" & mystep(i).id & "'"
                        Dim myadapter10 As New SqlDataAdapter(mysql, myconn)
                        myadapter10.Fill(mydataset, "SHIP")

                        If mydataset.Tables("SHIP").Rows.Count = 0 Then
                            MsgBox("获取站别信息失败!", vbOKOnly + vbExclamation)
                            GoTo ErrorHandle
                        Else
                            .range("A4") = mydataset.Tables("SHIP").Rows(0).Item("Operation").ToString
                        End If

                        mydataset.Clear()

                        If RuncardPrint_Mode = "BYLOT" Then
                            .range("AG1") = "生产批号(Internal Lot#):      " & iLot
                        End If

                    End With


                Case Else

                    MsgBox("流程卡模板中未定义该站别: " & mystep(i).name & " , 流程卡制作不完整!", vbOKOnly + vbExclamation)
                    GoTo ErrorHandle
            End Select


        Next

        '-----------------------------
        '复制ERFRecord表 针测记录表
        '-----------------------------

        mybk1.Worksheets("ERFRecord").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
        mybk2.Worksheets(mybk2.Worksheets.Count).name = "异常记录表"
        With mybk2.Worksheets(mybk2.Worksheets.Count)
            .range("A1") = "产品型号(Product): " & product
            If RuncardPrint_Mode = "BYLOT" Then
                .range("AA1") = "生产批号(Internal Lot#):  " & iLot
            End If
        End With

        For i = 1 To UBound(mystep) - 1
            If Strings.Left(mystep(i).name, 2) = "CP" And Strings.Right(mystep(i).name, 2) <> "DT" Then '筛选出测试站
                mybk1.Worksheets("TestRecord").copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                mybk2.Worksheets(mybk2.Worksheets.Count).name = mystep(i).name & "-针测记录表"
                With mybk2.Worksheets(mybk2.Worksheets.Count)
                    .range("A1") = "产品型号(Product):  " & product
                    .range("A2") = mystep(i).name & "-针测记录表"
                    If RuncardPrint_Mode = "BYLOT" Then
                        .range("AA1") = "生产批号(Internal Lot#):  " & iLot
                    End If

                End With
            End If
        Next

        '-----------------------------
        '复制MapPic表
        '-----------------------------

        If UBound(mapfile) > 0 Then

            For i = 0 To UBound(mapfile) - 1

                Servermap = Replace(mapfile(i), "CPMES-SERVER", "10.10.31.99")

                If Strings.Right(Servermap, 4) = "xlsx" Then
                    Localmap = Application.StartupPath & "\tempdata\map-" & i + 1 & ".xlsx"
                ElseIf Strings.Right(Servermap, 4) = ".xls" Then
                    Localmap = Application.StartupPath & "\tempdata\map-" & i + 1 & ".xls"
                Else
                    Localmap = Application.StartupPath & "\tempdata\map-" & i + 1
                End If

                FileCopy(Servermap, Localmap)

                ''''below for debug
                '''If i = 0 Then
                '''    Localmap = "E:\temppppp\cp1-mappic.xlsx"
                '''Else
                '''    Localmap = "E:\temppppp\cp2-mappic.xlsx"
                '''End If

                Dim mybk3 As Excel.Workbook = myexcel.Workbooks.Open(Localmap)
                myexcel.Visible = False
                mybk3.Worksheets(1).copy(After:=mybk2.Worksheets(mybk2.Worksheets.Count))
                mybk3.Close()
                mybk3 = Nothing

            Next

        End If




ErrorHandle:

        mybk2.Worksheets(1).delete

        mybk1.Close()
        mybk2.Worksheets("BASIC").Activate()
        mybk2.Save()
        myexcel.Visible = True
        myexcel.WindowState = Excel.XlWindowState.xlMaximized

        '不需要直接打印或退出，将控制权交给User.
        'myexcel.ActiveSheet.PrintPreview
        'myexcel.ActiveSheet.Printout
        'myexcel.Workbooks.Close()
        'myexcel.Quit()


    End Sub

    'Below code for debug test
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim appXL As Excel.Application
        Dim wbXl As Excel.Workbook
        Dim shXL As Excel.Worksheet
        Dim raXL As Excel.Range
        ' Start Excel and get Application object.
        appXL = CreateObject("Excel.Application")
        appXL.Visible = True
        ' Add a new workbook.
        wbXl = appXL.Workbooks.Add
        shXL = wbXl.ActiveSheet
        ' Add table headers going cell by cell.
        shXL.Cells(1, 1).Value = "First Name"
        shXL.Cells(1, 2).Value = "Last Name"
        shXL.Cells(1, 3).Value = "Full Name"
        shXL.Cells(1, 4).Value = "Specialization"
        ' Format A1:D1 as bold, vertical alignment = center.
        With shXL.Range("A1", "D1")
            .Font.Bold = True
            .VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        End With
        ' Create an array to set multiple values at once.
        Dim students(5, 2) As String
        students(0, 0) = "Zara"
        students(0, 1) = "Ali"
        students(1, 0) = "Nuha"
        students(1, 1) = "Ali"
        students(2, 0) = "Arilia"
        students(2, 1) = "RamKumar"
        students(3, 0) = "Rita"
        students(3, 1) = "Jones"
        students(4, 0) = "Umme"
        students(4, 1) = "Ayman"
        ' Fill A2:B6 with an array of values (First and Last Names).
        shXL.Range("A2", "B6").Value = students
        ' Fill C2:C6 with a relative formula (=A2 & " " & B2).
        raXL = shXL.Range("C2", "C6")
        raXL.Formula = "=A2 & "" "" & B2"
        ' Fill D2:D6 values.
        With shXL
            .Cells(2, 4).Value = "Biology"
            .Cells(3, 4).Value = "Mathmematics"
            .Cells(4, 4).Value = "Physics"
            .Cells(5, 4).Value = "Mathmematics"
            .Cells(6, 4).Value = "Arabic"
        End With
        ' AutoFit columns A:D.
        raXL = shXL.Range("A1", "D1")
        raXL.EntireColumn.AutoFit()
        ' Make sure Excel is visible and give the user control
        ' of Excel's lifetime.
        appXL.Visible = True
        appXL.UserControl = True
        ' Release object references.
        raXL = Nothing
        shXL = Nothing
        wbXl = Nothing
        appXL.Quit()
        appXL = Nothing
        Exit Sub
Err_Handler:
        MsgBox(Err.Description, vbCritical, "Error: " & Err.Number)


    End Sub

    Private Sub btn_IQC_cancel_Click(sender As Object, e As EventArgs) Handles btn_IQC_cancel.Click
        Me.Close()
    End Sub

    Private Sub combo_cust_DropDown(sender As Object, e As EventArgs) Handles combo_cust.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select ename from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Customer")

        If mydataset.Tables("Customer").Rows.Count = 0 Then
            combo_cust.Items.Add("Query Customer List Fail !")
        Else
            combo_cust.Items.Clear()

            'List All customer
            For i = 0 To mydataset.Tables("Customer").Rows.Count - 1
                combo_cust.Items.Add(mydataset.Tables("Customer").Rows(i).Item("ename"))
            Next

        End If

    End Sub



    Private Sub combo_iprod_DropDown(sender As Object, e As EventArgs) Handles combo_iprod.DropDown
        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select InternalProduct from Product where Customer='" & combo_cust.Text & "'"


        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "product")

        If mydataset.Tables("product").Rows.Count = 0 Then
            combo_iprod.Items.Clear()
        Else
            combo_iprod.Items.Clear()

            For i = 0 To mydataset.Tables("product").Rows.Count - 1
                combo_iprod.Items.Add(mydataset.Tables("product").Rows(i).Item("InternalProduct"))
            Next

        End If
    End Sub

    Private Sub combo_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_type.SelectedIndexChanged
        combo_id.Text = ""
        combo_lot.Text = ""
    End Sub

    Private Sub combo_cust_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_cust.SelectedIndexChanged
        combo_iprod.Text = ""
        combo_type.Text = ""
    End Sub

    Private Sub combo_iprod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_iprod.SelectedIndexChanged
        combo_type.Text = ""
    End Sub


End Class