
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'CP MES system History
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Version    | Programmer    | Date       | Description
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'0.1        |  Vanni Jiang  | 2018/12/04 | New develop CP MES system for iTest Semiconductor;
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.2   |  Vanni Jiang  | 2019/02/18 | Beta 0.2 for 1st time full function test @ test environment    
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.3   |  Vanni Jiang  | 2019/03/10 | 1. Add authority management for SU/MGR/ENG/OP.
'                                        | 2. Add auto Ucase function for ilot.
'                                        | 3. Change to 256*256 icon.
'                                        | 4. Add WaferOCR query and print function.
'                                        | 5. Add Split Lot function.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.31  |  Vanni Jiang  | 2019/03/12 | 1. Add Notice for under develop module which covered by "()";
'                                        | 2. Set child lot to CHECKIN status when spliting lot operation, fix "no check in record issue" when child lot check out.
'''''
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.32  |  Vanni Jiang  | 2019/03/13 | 1. Fix bug reported by Zhongming;
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.40  |  Vanni Jiang  | 2019/03/17 | 1. Add Hold and Release Function;
'                                        | 2. Add Release Control module for tester and probecard;
'                                        | 3. spread max CP step to CP9.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.41  |  Vanni Jiang  | 2019/03/19 | 1. Fix Accessory part number bug;
'Beta 0.42  |  Vanni Jiang  | 2019/03/29 | 1. Fix Split Lot bug, add tostring for DBNUll item.
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'Beta 0.50  |  Vanni Jiang  | 2019/04/02 | 1. Add Utilization Module;
'
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
'
'
'
'
'
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''












Imports System.Data.SqlClient

Module MyComModule









    '##############################################################
    '变量设定区
    '##############################################################





    Public MyVersion As String = " Version Beta 0.1, Build: 2019/04/08"

    Public myconn As SqlConnection

    Public Const COLUMNWIDTH As Integer = 100

    Public UserID As String = "003018000"
    Public UserName As String
    Public UserPosition As String

    Public Enum GROUPTYPE
        SU = 0 '超级权限
        MGR = 1 '管理权限
        ENG = 5 '工程师权限
        OP = 9 '作业员权限
    End Enum

    Public UserGroup As GROUPTYPE

    '实际WIP状态数据库端栏位用了String型，未用Int型，避免查询报表时还需要将int转化为对应的String.
    Public Enum LOTSTATUSTYPE

        RCVDONE = 1 ' 已收货
        RCVHOLD = 102 '暂收货
        RCVING = 101 '收货中
        CHECKIN = 2 ' 待check in
        CHECKOUT = 3 ' 待check out
        SMDONE = 4 ' 已分并批
        HOLD = 5 ' 已Hold
        WAIT = 6 ' 已Wait
        INV = 7 ' 已出货

    End Enum

    Public LotState As LOTSTATUSTYPE


    Public Structure PRODUCTTYPE
        Dim Customer As String
        Dim ProductType As String
        Dim WaferSize As String
        Dim Bund As Boolean
        Dim InternalProduct As String
        Dim CustomerProduct As String
        Dim FabProduct As String
        Dim ShipProduct As String
        Dim RetestFlow As String
        Dim Mark As String
        Dim GDPW As String
        Dim Fabsite As String

    End Structure

    Public myProduct As PRODUCTTYPE

    Public Structure FLOWTYPE

        Dim ID As String
        Dim Type As String
        Dim ilot As String
        Dim clot As String
        Dim step01 As String
        Dim step02 As String
        Dim step03 As String
        Dim step04 As String
        Dim step05 As String
        Dim step06 As String
        Dim step07 As String
        Dim step08 As String
        Dim step09 As String
        Dim step10 As String
        Dim step11 As String
        Dim step12 As String
        Dim step13 As String
        Dim step14 As String
        Dim step15 As String
        Dim step16 As String
        Dim step17 As String
        Dim step18 As String
        Dim step19 As String
        Dim step20 As String

    End Structure

    Public myFlow As FLOWTYPE

    Public Structure EQUIPTYPE
        Dim type As String
        Dim grp As String
        Dim ID As String
        Dim SN As String
        Dim manufacturer As String
        Dim supplier As String
        Dim inputdate As Date
        Dim sysno As String
        Dim model As String
        Dim state As String
        Dim version As String
        Dim license As String
        Dim pmdate As Date
        Dim nextpmdate As Date
        Dim config As String
        Dim attach As String
        Dim floor As String
        Dim position As Integer
        Dim sql As String
    End Structure

    Public myequip As EQUIPTYPE


    Public Structure ASSYTYPE

        Dim type As String
        ' Dim type1 As String
        Dim grp As String
        Dim cust As String
        Dim prod As String
        Dim partno As String
        Dim part As String
        'Dim ids As String
        Dim site As String
        Dim fit As String
        Dim thick As String
        Dim id As String
        Dim owner As String
        Dim ioside As String
        Dim location As String
        Dim manufact As String
        Dim supplier As String
        Dim inputdate As Date
        'Dim inputd As Date
        Dim remark As String
        Dim attach As String
        Dim state As String
        Dim live As String
        Dim package As String

    End Structure

    Public myassy As ASSYTYPE

    Public Structure WIPLOTTYPE
        Dim custid As String
        Dim custeng As String
        Dim custchn As String
        Dim ilot As String
        Dim itestorder As String
        Dim receivingExNo As String
        Dim custorder As String
        Dim custorderseq As String
        Dim orderdate As Date
        Dim requiredate As Date
        Dim receivingdate As Date
        Dim prodtype As String
        Dim priority As String
        Dim bonded As Boolean
        Dim clot As String
        Dim flot As String
        Dim slot As String
        Dim iprod As String
        Dim cprod As String
        Dim fprod As String
        Dim sprod As String
        Dim waferqty As Integer
        Dim currentwaferqty As Integer
        Dim waferlist As String
        Dim dieqty As Long
        Dim location As String
        Dim code As String
        Dim orderfile As String
        Dim remark As String
        Dim CurrentStep As String
        Dim status As String
        Dim flowid As String
        Dim finalgooddie As Long

    End Structure

    Public myincoming As WIPLOTTYPE
    Public mycheckio As WIPLOTTYPE

    Public Structure IOTYPE
        Dim ID As String
        Dim type As String
        Dim INDate As String
        Dim OUTDate As String
        Dim Status As String
        Dim equipment As String
        Dim supplier As String
        Dim config As String
        Dim attach As String

    End Structure

    Public myio As IOTYPE

    Public Structure CUSTTYPE
        Dim id As String
        Dim ename As String
        Dim shortchar As String
        Dim cname As String
        Dim Nationality As String
        Dim address As String
        Dim remark As String
    End Structure

    Public mycust As CUSTTYPE

    Public Structure EMPLTYPE
        Dim id As String
        Dim ename As String
        Dim cname As String
        Dim department As String
        Dim position As String
        Dim Grp As String
    End Structure

    Public myemployee As EMPLTYPE

    Public Structure STEPTYPE
        Dim name As String
        Dim id As String
    End Structure

    Public mystep() As STEPTYPE

    Public Structure PGMTYPE
        Dim Grp As String
        Dim Assy As String
        Dim id As String
        Dim name As String
        Dim Ver As String
    End Structure

    Public mypgm As PGMTYPE

    Public Structure SHIPTYPE
        Dim ShipOrder As String
        Dim Status As String
        Dim ename As String
        Dim cname As String
        Dim shipdate As Date
        Dim shipmethod As String
        Dim boxqty As Integer
        Dim FactoryAddress As String
        Dim FactoryContactPerson As String
        Dim FactoryContactNo As String
        Dim ShipAddress As String
        Dim ShipContactPerson As String
        Dim ShipContactNo As String
        Dim ShipExpress As String
        Dim ShipExpressNo As String
        Dim enable As Boolean
        Dim remark As String
        Dim attach As String
    End Structure

    Public myship As SHIPTYPE

    Public Structure SHIPDETAILTYPE
        Dim ShipOrder As String
        Dim iTestLotNo As String
        Dim iTestProduct As String
        Dim ShipLotNo As String
        Dim ShipProduct As String
        Dim ReceivingWaferQty As String
        Dim CurrentWaferQty As String
        Dim WaferList As String
        Dim Yield As String
        Dim GoodDieQty As String
        Dim GrossDieQty As String
        Dim OuterBoxID As String
        Dim GrossWeight As String
        Dim NetWeight As String
        Dim Length As String
        Dim Width As String
        Dim Height As String
    End Structure

    Public myshipdetail As SHIPDETAILTYPE

    Public Structure ERFHOLDTYPE
        Dim HoldSN As String
        Dim ilot As String
        Dim clot As String
        Dim holdstep As String
        Dim cust As String
        Dim iprod As String
        Dim cprod As String
        Dim currqty As Integer
        Dim holdqty As Integer
        Dim holdwaferlist As String
        Dim holdtime As Date
        Dim holder As String
        Dim holdtype As String
        Dim holdreason As String
        Dim owner As String
        Dim ownerGrp As String
        Dim itestdisposeflag As String
        Dim itestdisposecmd As String
        Dim informtime As Date
        Dim Custowner As String
        Dim custdisposeflag As String
        Dim custdisposecmd As String
        Dim attach As String
        Dim status As String
        Dim closer As String
    End Structure

    Public myholdlot As ERFHOLDTYPE

    Public Structure UTILIZATIONTYPE
        Dim cust As String
        Dim iprod As String
        Dim ilot As String
        Dim clot As String
        Dim iStep As String
        Dim probecard As String
        Dim program As String
        Dim temperature As String
    End Structure




    Public Product_Operation_Mode As String
    Public Flow_Operation_Mode As String
    Public StepDefine_Mode As String
    Public Equipment_Operation_Mode As String
    Public Customer_Operation_Mode As String
    Public Employee_Operation_Mode As String
    Public Accessary_Operation_Mode As String
    Public IO_Operation_Mode As String
    Public Incoming_Operation_Mode As String
    Public Shipping_Operation_Mode As String
    Public Hold_Operation_Mode As String

    Public UtilizationIdx As String  '储存机台 id 信息，在User点击任意一台机台 按钮时赋值
    Public UtilizationFormNo As String '储存机台最新状态之FormNo, 在User进行状态转换时提取及释放，起到传递作用


    Public LabelType As String  ' IN , OUT, HOLD
    Public LabelLot As String

    Public RuncardPrint_Mode As String 'BYENG, BYLOT

    Public mydefaultcolor As Color













    '##############################################################
    '函数设定区
    '##############################################################


    ' 1~3 正式区色调
    ' 4~6 测试区色调
    Public Function MyColors(ByVal s As String) As Color
        Select Case s
            Case "1" : MyColors = Color.AliceBlue
            Case "2" : MyColors = Color.Cornsilk
            Case "3" : MyColors = Color.Honeydew
            Case "4" : MyColors = Color.LightPink
            Case "5" : MyColors = Color.LightGreen
        End Select
    End Function



    Public Function GetCustomerList() As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("Cust").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Cust").Rows(i).Item("ename")
            Next
        End If

        Return temparray

    End Function

    Public Function GetCustCNAME(cust As String) As String

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer where ename='" & cust & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            GetCustCNAME = "QueryFail"
        Else
            GetCustCNAME = mydataset.Tables("Cust").Rows(0).Item("cname")
        End If

    End Function

    Public Function GetProductList(cust As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        If cust = "*" Then
            mysql = "select InternalProduct from Product"
        Else
            mysql = "select InternalProduct from Product where Customer='" & cust & "'"
        End If

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Prod")

        If mydataset.Tables("Prod").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("Prod").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Prod").Rows(i).Item("InternalProduct")
            Next
        End If

        Return temparray

    End Function

    Public Function GetTesterGrp() As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Grp from Equipment where Type='Tester'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("Equipment").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Equipment").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetTesterList(Grp As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT ID from Equipment where Grp ='" & Grp & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("Equipment").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Equipment").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetReleaseTesterList(iprod As String, currstep As String, grp As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select Tester from RLS_TESTER where InternalProduct='" & iprod & "' AND Flow='" & currstep & "' AND Grp='" & grp & "' AND Disable='False'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Equipment")

        If mydataset.Tables("Equipment").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("Equipment").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Equipment").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetAssyPartNo() As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        '  mysql = "select DISTINCT Partnumber from Accessory where Type='ProbeCard'"
        mysql = "select DISTINCT Partnumber from Accessory"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "ASSY")

        If mydataset.Tables("ASSY").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("ASSY").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("ASSY").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetAssyList(Partnumber As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT ID from Accessory where Partnumber ='" & Partnumber & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "ASSY")

        If mydataset.Tables("ASSY").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("ASSY").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("ASSY").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetReleaseAssyList(iprod As String, currstep As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select PartID from RLS_ASSY where InternalProduct='" & iprod & "' AND Flow='" & currstep & "' AND Disable='False'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "ASSY")

        If mydataset.Tables("ASSY").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "QueryFail"
        Else
            For i = 0 To mydataset.Tables("ASSY").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("ASSY").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetUtilizationStatus() As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Status from UtilizationItem"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Status")

        If mydataset.Tables("Status").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "NA"
        Else
            For i = 0 To mydataset.Tables("Status").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Status").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetUtilizationDetail(status As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Detail from UtilizationItem where Status='" & status & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Detail")

        If mydataset.Tables("Detail").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "NA"
        Else
            For i = 0 To mydataset.Tables("Detail").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Detail").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetUtilizationReason(status As String) As String()

        Dim i As Integer
        Dim temparray() As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select DISTINCT Reason from UtilizationReason where Status ='" & status & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Reason")

        If mydataset.Tables("Reason").Rows.Count = 0 Then
            ReDim temparray(1)
            temparray(0) = "NA"
        Else
            For i = 0 To mydataset.Tables("Reason").Rows.Count - 1
                ReDim Preserve temparray(i + 1)
                temparray(i) = mydataset.Tables("Reason").Rows(i).Item(0)
            Next
        End If

        Return temparray

    End Function

    Public Function GetTesterStatus(testid As String) As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from UtilizationTrack where testerid = '" & testid & "' ORDER BY SN DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Track")

        If mydataset.Tables("Track").Rows.Count = 0 Then
            GetTesterStatus = "NA"
        Else
            GetTesterStatus = mydataset.Tables("Track").Rows(0).Item("Status").ToString
        End If
    End Function

    Public Function GetLotStatusByIlot(ilot As String) As WIPLOTTYPE
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from WIPLOT where iTestLotNo ='" & ilot & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            GetLotStatusByIlot.clot = "QUERY FAIL"
        Else
            GetLotStatusByIlot.clot = mydataset.Tables("WIP").Rows(0).Item("CustLotNo")
            GetLotStatusByIlot.CurrentStep = mydataset.Tables("WIP").Rows(0).Item("CurrentStep")
            GetLotStatusByIlot.custeng = mydataset.Tables("WIP").Rows(0).Item("CUSTENG")
            GetLotStatusByIlot.iprod = mydataset.Tables("WIP").Rows(0).Item("iTestProduct")
            GetLotStatusByIlot.currentwaferqty = mydataset.Tables("WIP").Rows(0).Item("CurrentWaferQty")
        End If

    End Function

    Public Function GetCustInfoByEname(ename As String) As CUSTTYPE

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Customer where ename ='" & ename & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Cust")

        If mydataset.Tables("Cust").Rows.Count = 0 Then
            GetCustInfoByEname.cname = "QUERY FAIL"
        Else
            GetCustInfoByEname.id = mydataset.Tables("Cust").Rows(0).Item("ID")
            GetCustInfoByEname.ename = mydataset.Tables("Cust").Rows(0).Item("ename")
            GetCustInfoByEname.shortchar = mydataset.Tables("Cust").Rows(0).Item("shortchar")
            GetCustInfoByEname.cname = mydataset.Tables("Cust").Rows(0).Item("cname")
            GetCustInfoByEname.Nationality = mydataset.Tables("Cust").Rows(0).Item("Nationality")
            GetCustInfoByEname.address = mydataset.Tables("Cust").Rows(0).Item("Address")
            GetCustInfoByEname.remark = mydataset.Tables("Cust").Rows(0).Item("Remark")
        End If

    End Function

    Public Function GetUtiInfoByFormNo(status As String, formNo As String) As UTILIZATIONTYPE
        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case status

            Case "SETUP"

                mysql = "select * from UtiSetupTrack where SN ='" & formNo & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)
                myadapter.Fill(mydataset, "UTI")

                If mydataset.Tables("UTI").Rows.Count = 0 Then
                    'do nothing
                Else
                    GetUtiInfoByFormNo.cust = mydataset.Tables("UTI").Rows(0).Item("cust")
                    GetUtiInfoByFormNo.iprod = mydataset.Tables("UTI").Rows(0).Item("iprod")
                    GetUtiInfoByFormNo.ilot = mydataset.Tables("UTI").Rows(0).Item("iLot")
                    GetUtiInfoByFormNo.iStep = mydataset.Tables("UTI").Rows(0).Item("step")
                    GetUtiInfoByFormNo.probecard = mydataset.Tables("UTI").Rows(0).Item("Probecard")
                    GetUtiInfoByFormNo.program = mydataset.Tables("UTI").Rows(0).Item("Program")
                    GetUtiInfoByFormNo.temperature = mydataset.Tables("UTI").Rows(0).Item("Temp")
                End If

            Case "CORR"

                mysql = "select * from UtiCorrTrack where SN ='" & formNo & "'"

                Dim myadapter As New SqlDataAdapter(mysql, myconn)
                myadapter.Fill(mydataset, "UTI")

                If mydataset.Tables("UTI").Rows.Count = 0 Then
                    'do nothing
                Else

                    GetUtiInfoByFormNo.ilot = mydataset.Tables("UTI").Rows(0).Item("corrlot")
                    GetUtiInfoByFormNo.iStep = mydataset.Tables("UTI").Rows(0).Item("step")
                    GetUtiInfoByFormNo.probecard = mydataset.Tables("UTI").Rows(0).Item("probecard")
                    GetUtiInfoByFormNo.program = mydataset.Tables("UTI").Rows(0).Item("program")

                End If




            Case Else


        End Select


    End Function

    Public Function GetUtiInfoByTester(tester As String) As UTILIZATIONTYPE
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from UtilizationTrack where testerid ='" & tester & "' ORDER BY SN DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "UTI")

        If mydataset.Tables("UTI").Rows.Count = 0 Then
            'do nothing
        Else
            GetUtiInfoByTester.cust = mydataset.Tables("UTI").Rows(0).Item("Cust")
            GetUtiInfoByTester.iprod = mydataset.Tables("UTI").Rows(0).Item("iprod")
            GetUtiInfoByTester.ilot = mydataset.Tables("UTI").Rows(0).Item("iLot")
            GetUtiInfoByTester.clot = mydataset.Tables("UTI").Rows(0).Item("cLot").ToString
            GetUtiInfoByTester.iStep = mydataset.Tables("UTI").Rows(0).Item("step")
            GetUtiInfoByTester.probecard = mydataset.Tables("UTI").Rows(0).Item("ProbeCard")
            GetUtiInfoByTester.program = mydataset.Tables("UTI").Rows(0).Item("Program")
            GetUtiInfoByTester.temperature = mydataset.Tables("UTI").Rows(0).Item("Temperature")

        End If


    End Function


    Public Function SetStatusColor(status As String) As Color

        Select Case status
            Case "RUN", "REWORK"
                SetStatusColor = Color.LimeGreen
            Case "IDLE"
                SetStatusColor = Color.Yellow
            Case "CLEAN", "CORR"
                SetStatusColor = Color.White
            Case "SETUP"
                SetStatusColor = Color.LightSalmon
            Case "PM", "EI", "EO"
                SetStatusColor = Color.Cyan
            Case "DOWN"
                SetStatusColor = Color.Red
            Case "OTHER"
                SetStatusColor = Color.Fuchsia
            Case Else
                SetStatusColor = Color.Silver
        End Select
    End Function



    Public Function GetFlowIDbyLotNo(cust As String, prod As String, lot As String) As String

        Dim i As Integer

        Dim mysql As String
        Dim mydataset As New DataSet

        '优先检查是否存在SEN Flow
        mysql = "select * from Flow where Customer=" & "'" & cust & "' AND InternalProduct=" & "'" & prod & "' AND Type=" & "'SEN' AND ENABLE='TRUE' AND ilot like '%" & lot & "%'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Flow")

        If mydataset.Tables("Flow").Rows.Count = 0 Then
            GetFlowIDbyLotNo = ""
        ElseIf mydataset.Tables("Flow").Rows.Count = 1 Then '找到一笔SEN流程数据
            GetFlowIDbyLotNo = mydataset.Tables("Flow").Rows(i).Item("ID")
            Exit Function
        ElseIf mydataset.Tables("Flow").Rows.Count > 1 Then '找到多笔SEN流程数据
            MsgBox("发现异常:同一批货绑了多笔SEN流程！", vbOKOnly + vbExclamation)
            GetFlowIDbyLotNo = ""
            Exit Function
        End If

        mydataset.Clear()

        'SEN FLOW中查询不到时，再从ECN中查询

        mysql = "select * from Flow where Customer=" & "'" & cust & "' AND InternalProduct=" & "'" & prod & "' AND Type=" & "'ECN' AND ENABLE='TRUE'"

        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)

        myadapter2.Fill(mydataset, "Flow")

        If mydataset.Tables("Flow").Rows.Count = 0 Then
            GetFlowIDbyLotNo = ""
        ElseIf mydataset.Tables("Flow").Rows.Count = 1 Then '找到一笔ECN流程数据
            GetFlowIDbyLotNo = mydataset.Tables("Flow").Rows(i).Item("ID")
            Exit Function
        ElseIf mydataset.Tables("Flow").Rows.Count > 1 Then '找到多笔ECN流程数据
            MsgBox("发现异常:同一型号存在多笔ECN流程！", vbOKOnly + vbExclamation)
            GetFlowIDbyLotNo = ""
            Exit Function
        End If


    End Function

    Public Function GetStepNameArraybyFlowID(cust As String, prod As String, ilot As String, flowid As String) As Boolean

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Flow where ID=" & "'" & flowid & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "Flow")

        If mydataset.Tables("Flow").Rows.Count > 0 Then

            If Len(mydataset.Tables("Flow").Rows(0).Item("step01").ToString) > 0 Then
                ReDim mystep(2)
                mystep(1).name = mydataset.Tables("Flow").Rows(0).Item("step01").ToString
                mystep(1).id = GetRecipeIDbyStepName(cust, prod, mystep(1).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step02").ToString) > 0 Then
                ReDim Preserve mystep(3)
                mystep(2).name = mydataset.Tables("Flow").Rows(0).Item("step02").ToString
                mystep(2).id = GetRecipeIDbyStepName(cust, prod, mystep(2).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step03").ToString) > 0 Then
                ReDim Preserve mystep(4)
                mystep(3).name = mydataset.Tables("Flow").Rows(0).Item("step03").ToString
                mystep(3).id = GetRecipeIDbyStepName(cust, prod, mystep(3).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step04").ToString) > 0 Then
                ReDim Preserve mystep(5)
                mystep(4).name = mydataset.Tables("Flow").Rows(0).Item("step04").ToString
                mystep(4).id = GetRecipeIDbyStepName(cust, prod, mystep(4).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step05").ToString) > 0 Then
                ReDim Preserve mystep(6)
                mystep(5).name = mydataset.Tables("Flow").Rows(0).Item("step05").ToString
                mystep(5).id = GetRecipeIDbyStepName(cust, prod, mystep(5).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step06").ToString) > 0 Then
                ReDim Preserve mystep(7)
                mystep(6).name = mydataset.Tables("Flow").Rows(0).Item("step06").ToString
                mystep(6).id = GetRecipeIDbyStepName(cust, prod, mystep(6).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step07").ToString) > 0 Then
                ReDim Preserve mystep(8)
                mystep(7).name = mydataset.Tables("Flow").Rows(0).Item("step07").ToString
                mystep(7).id = GetRecipeIDbyStepName(cust, prod, mystep(7).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step08").ToString) > 0 Then
                ReDim Preserve mystep(9)
                mystep(8).name = mydataset.Tables("Flow").Rows(0).Item("step08").ToString
                mystep(8).id = GetRecipeIDbyStepName(cust, prod, mystep(8).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step09").ToString) > 0 Then
                ReDim Preserve mystep(10)
                mystep(9).name = mydataset.Tables("Flow").Rows(0).Item("step09").ToString
                mystep(9).id = GetRecipeIDbyStepName(cust, prod, mystep(9).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step10").ToString) > 0 Then
                ReDim Preserve mystep(11)
                mystep(10).name = mydataset.Tables("Flow").Rows(0).Item("step10").ToString
                mystep(10).id = GetRecipeIDbyStepName(cust, prod, mystep(10).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step11").ToString) > 0 Then
                ReDim Preserve mystep(12)
                mystep(11).name = mydataset.Tables("Flow").Rows(0).Item("step11").ToString
                mystep(11).id = GetRecipeIDbyStepName(cust, prod, mystep(11).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step12").ToString) > 0 Then
                ReDim Preserve mystep(13)
                mystep(12).name = mydataset.Tables("Flow").Rows(0).Item("step12").ToString
                mystep(12).id = GetRecipeIDbyStepName(cust, prod, mystep(12).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step13").ToString) > 0 Then
                ReDim Preserve mystep(14)
                mystep(13).name = mydataset.Tables("Flow").Rows(0).Item("step13").ToString
                mystep(13).id = GetRecipeIDbyStepName(cust, prod, mystep(13).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step14").ToString) > 0 Then
                ReDim Preserve mystep(15)
                mystep(14).name = mydataset.Tables("Flow").Rows(0).Item("step14").ToString
                mystep(14).id = GetRecipeIDbyStepName(cust, prod, mystep(14).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step15").ToString) > 0 Then
                ReDim Preserve mystep(16)
                mystep(15).name = mydataset.Tables("Flow").Rows(0).Item("step15").ToString
                mystep(15).id = GetRecipeIDbyStepName(cust, prod, mystep(15).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step16").ToString) > 0 Then
                ReDim Preserve mystep(17)
                mystep(16).name = mydataset.Tables("Flow").Rows(0).Item("step16").ToString
                mystep(16).id = GetRecipeIDbyStepName(cust, prod, mystep(16).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step17").ToString) > 0 Then
                ReDim Preserve mystep(18)
                mystep(17).name = mydataset.Tables("Flow").Rows(0).Item("step17").ToString
                mystep(17).id = GetRecipeIDbyStepName(cust, prod, mystep(17).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step18").ToString) > 0 Then
                ReDim Preserve mystep(19)
                mystep(18).name = mydataset.Tables("Flow").Rows(0).Item("step18").ToString
                mystep(18).id = GetRecipeIDbyStepName(cust, prod, mystep(18).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step19").ToString) > 0 Then
                ReDim Preserve mystep(20)
                mystep(19).name = mydataset.Tables("Flow").Rows(0).Item("step19").ToString
                mystep(19).id = GetRecipeIDbyStepName(cust, prod, mystep(19).name, ilot)
            End If

            If Len(mydataset.Tables("Flow").Rows(0).Item("step20").ToString) > 0 Then
                ReDim Preserve mystep(21)
                mystep(20).name = mydataset.Tables("Flow").Rows(0).Item("step20").ToString
                mystep(20).id = GetRecipeIDbyStepName(cust, prod, mystep(20).name, ilot)
            End If

        End If

        GetStepNameArraybyFlowID = True

    End Function

    Public Function GetRecipeIDbyStepName(cust As String, prod As String, Stepname As String, lot As String) As String
        Dim mysql As String
        Dim mydataset As New DataSet

        Select Case Stepname

            Case "IQC"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_IQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "IQC")

                    If mydataset.Tables("IQC").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔IQC SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("IQC").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("IQC").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("IQC").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_IQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "IQC")
                        If mydataset.Tables("IQC").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("IQC").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_IQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "IQC")
                    If mydataset.Tables("IQC").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("IQC").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case "BAKE1", "BAKE2", "BAKE3", "BAKE4"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_BAKE where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "BAKE")

                    If mydataset.Tables("BAKE").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("BAKE").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("BAKE").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("BAKE").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_BAKE where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "BAKE")
                        If mydataset.Tables("BAKE").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("BAKE").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_BAKE where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "BAKE")
                    If mydataset.Tables("BAKE").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("BAKE").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If


            Case "CP1", "CP2", "CP3", "CP4", "CP5", "CP6", "CP7", "CP8", "CP9"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_CP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "CP")

                    If mydataset.Tables("CP").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("CP").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("CP").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("CP").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_CP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "CP")
                        If mydataset.Tables("CP").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("CP").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_CP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "CP")
                    If mydataset.Tables("CP").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("CP").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case "CP1DT", "CP2DT", "CP3DT", "CP4DT", "CP5DT", "CP6DT", "CP7DT", "CP8DT", "CP9DT"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_CPDT where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "CPDT")

                    If mydataset.Tables("CPDT").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("CPDT").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("CPDT").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("CPDT").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_CPDT where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "CPDT")
                        If mydataset.Tables("CPDT").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("CPDT").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_CPDT where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "CPDT")
                    If mydataset.Tables("CPDT").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("CPDT").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case "WIPFS"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_WIPFS where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "WIPFS")

                    If mydataset.Tables("WIPFS").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("WIPFS").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("WIPFS").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("WIPFS").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_WIPFS where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "WIPFS")
                        If mydataset.Tables("WIPFS").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("WIPFS").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_WIPFS where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "WIPFS")
                    If mydataset.Tables("WIPFS").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("WIPFS").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If


            Case "FQC"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_FQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "FQC")

                    If mydataset.Tables("FQC").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔FQC SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("FQC").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("FQC").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("FQC").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_FQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "FQC")
                        If mydataset.Tables("FQC").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("FQC").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_FQC where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "FQC")
                    If mydataset.Tables("FQC").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("FQC").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case "PACK"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_PACK where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "PACK")

                    If mydataset.Tables("PACK").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("PACK").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("PACK").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("PACK").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_PACK where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "PACK")
                        If mydataset.Tables("PACK").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("PACK").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_PACK where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "PACK")
                    If mydataset.Tables("PACK").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("PACK").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case "SHIP"

                If lot <> "" Then

                    '优先确认SEN是否有设定
                    mysql = "select * from Recipe_SHIP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='SEN' AND ENABLE='TRUE'" & " AND Lot like '%" & lot & "%'"
                    Dim myadapter As New SqlDataAdapter(mysql, myconn)
                    myadapter.Fill(mydataset, "SHIP")

                    If mydataset.Tables("SHIP").Rows.Count > 1 Then 'SEN中找到多批信息

                        MsgBox("发现同一批Lot设定了多笔" & Stepname & " SEN参数且同处于核准状态，请作废多余条，只保留一笔核准状态", vbOKOnly + vbExclamation)
                        Exit Function

                    ElseIf mydataset.Tables("SHIP").Rows.Count = 1 Then 'SEN中找到一批信息
                        GetRecipeIDbyStepName = mydataset.Tables("SHIP").Rows(0).Item("ID").ToString
                        Exit Function

                    ElseIf mydataset.Tables("SHIP").Rows.Count = 0 Then 'SEN中找不到，再从ECN中查找

                        mysql = "select * from Recipe_SHIP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                        Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                        myadapter2.Fill(mydataset, "SHIP")
                        If mydataset.Tables("SHIP").Rows.Count = 1 Then 'ECN中找到此批信息
                            GetRecipeIDbyStepName = mydataset.Tables("SHIP").Rows(0).Item("ID").ToString
                            Exit Function
                        End If

                    End If

                ElseIf lot = "" Then '直接从ECN中取

                    mysql = "select * from Recipe_SHIP where Customer='" & cust & "' AND InternalProduct='" & prod & "'AND FlowName=" & "'" & Stepname & "' AND Type='ECN' AND ENABLE='TRUE'"

                    Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
                    myadapter2.Fill(mydataset, "SHIP")
                    If mydataset.Tables("SHIP").Rows.Count = 1 Then 'ECN中找到此批信息
                        GetRecipeIDbyStepName = mydataset.Tables("SHIP").Rows(0).Item("ID").ToString
                        Exit Function
                    End If

                End If

            Case Else

                GetRecipeIDbyStepName = ""

        End Select


    End Function

    Public Function GetProgramInfobyRecipeID(recipeid As String) As Boolean

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Recipe_CP where ID='" & recipeid & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "program")

        If mydataset.Tables("program").Rows.Count = 0 Then
            mypgm.name = "未获取到程式名"
            mypgm.id = "未获取到程式ID"
            mypgm.Ver = "未获取到程式版本"
            GetProgramInfobyRecipeID = False

            Exit Function
        Else

            mypgm.Assy = mydataset.Tables("program").Rows(0).Item("probecard")
            mypgm.Grp = mydataset.Tables("program").Rows(0).Item("tester")
            mypgm.name = mydataset.Tables("program").Rows(0).Item("pgm")
            mypgm.id = mydataset.Tables("program").Rows(0).Item("pid")
            mypgm.Ver = mydataset.Tables("program").Rows(0).Item("pgmver").ToString

        End If

        GetProgramInfobyRecipeID = True

    End Function

    Public Function SetLotTrackIN(ilot As String, flowid As String, recipeid As String, CurrStep As String, EquipID As String, OP As String) As Boolean
        Dim ErrInfo As String
        Dim mysql As String
        Dim mydataset As New DataSet


        mysql = "INSERT INTO LotTrack (iTestLotNo,FlowID,RecipeID,Step,EquipID,CheckInTime,CheckInOP) VALUES ( '" &
                ilot & "','" & flowid & "','" & recipeid & "','" & CurrStep & "','" & EquipID & "','" & Now & "','" & OP & "')"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrInfo = ex.Message
            MsgBox(ex.Message)
        End Try

        myconn.Close()

        If ErrInfo <> "" Then
            SetLotTrackIN = False
        Else
            SetLotTrackIN = True
        End If

    End Function


    Public Function SetLotTrackOUT(ilot As String, flowid As String, recipeid As String, CurrStep As String, EquipID As String, OP As String) As Boolean
        Dim ErrInfo As String
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim SelectSN As Long

        ' ### 第一步： 找到要添加Check Out 信息的记录行 ###

        '倒序排列LotTrack表中 该批次 + 站别 + FlowID + RecipeID 的记录，理论上最近一条记录就是Check IN 信息
        ' FlowID + RecipeID 删选条件后续可能要去掉，以应对Lot在途时工程资料被PE变更.
        mysql = "select * from LotTrack where iTestLotNo = '" & ilot & "'" & "AND FlowID = '" & flowid & "'" & "AND RecipeID = '" & recipeid & "'" & "AND Step = '" & CurrStep & "'" & " ORDER BY SN DESC"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "WIP")

        If mydataset.Tables("WIP").Rows.Count = 0 Then
            MsgBox("异常发生：找不到该批货CHECK IN记录，请联系相关人员确认!", vbOKOnly + vbExclamation)
            SetLotTrackOUT = False
            Exit Function
        Else

            'For i = 0 To mydataset.Tables("WIP").Rows.Count - 1
            '    Console.WriteLine(mydataset.Tables("WIP").Rows(i).Item("SN").ToString)
            'Next

            SelectSN = mydataset.Tables("WIP").Rows(0).Item("SN")

            If mydataset.Tables("WIP").Rows(0).Item("CheckOutOP").ToString <> "" Then

                MsgBox("异常发生：最近的一笔流程中已经包含CHECKOUT信息，请联系相关人员确认!", vbOKOnly + vbExclamation)
                SetLotTrackOUT = False
                Exit Function

            End If

        End If


        ' ### 第二步： 添加Check Out 信息 ###

        mysql = "UPDATE  LotTrack SET CheckOutTime='" & Now & "',CheckOutOP= '" & OP & "' WHERE SN='" & SelectSN & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrInfo = ex.Message
            MsgBox(ex.Message)
        End Try

        myconn.Close()

        If ErrInfo <> "" Then
            SetLotTrackOUT = False
        Else
            SetLotTrackOUT = True
        End If


    End Function


    Public Function SetWIPLotStatus(ilot As String, currstep As String, CheckFlag As String) As Boolean
        Dim ErrInfo As String
        Dim mysql As String

        mysql = "UPDATE WIPLOT SET CurrentStep='" & currstep & "',Status= '" & CheckFlag & "' " & " WHERE iTestLotNo= '" & ilot & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrInfo = ex.Message
            MsgBox(ex.Message)
        End Try

        myconn.Close()


        If ErrInfo <> "" Then
            SetWIPLotStatus = False
        Else
            SetWIPLotStatus = True
        End If

    End Function


    Public Function SetWIPLotWaferList(ilot As String, waferlist As String, Optional waferqty As Integer = 0) As Boolean
        Dim ErrInfo As String
        Dim mysql As String

        If waferqty = 0 Then
            mysql = "UPDATE WIPLOT SET WaferList='" & waferlist & "' " & " WHERE iTestLotNo= '" & ilot & "'"
        Else
            mysql = "UPDATE WIPLOT SET WaferList='" & waferlist & "',CurrentWaferQty=' " & waferqty & "'" & " WHERE iTestLotNo= '" & ilot & "'"
        End If

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrInfo = ex.Message
            MsgBox(ex.Message)
        End Try

        myconn.Close()


        If ErrInfo <> "" Then
            SetWIPLotWaferList = False
        Else
            SetWIPLotWaferList = True
        End If

    End Function

    Public Function SetLotFinalGoodDie(ilot As String, yield As Double, finalgooddie As Long, grossdie As Long) As Boolean
        Dim ErrInfo As String
        Dim mysql As String

        mysql = "UPDATE WIPLOT SET Yield='" & yield & "',GoodDieQty=' " & finalgooddie & "',GrossDieQty=' " & grossdie & "'" & " WHERE iTestLotNo= '" & ilot & "'"

        Dim mycmd As New SqlClient.SqlCommand(mysql, myconn)
        myconn.Open()

        Try
            mycmd.ExecuteNonQuery()
        Catch ex As Exception
            ErrInfo = ex.Message
            MsgBox(ex.Message)
        End Try

        myconn.Close()


        If ErrInfo <> "" Then
            SetLotFinalGoodDie = False
        Else
            SetLotFinalGoodDie = True
        End If

    End Function


    Public Function InLabel_itest_Print(cust As String, cprod As String, clot As String, iprod As String, ilot As String, wqty As Integer, waferlist As String, Indate As String) As Boolean

        Dim btapp As BarTender.Application '定义bartender
        Dim btformat As BarTender.Format
        Dim btPrintRtn As BarTender.BtPrintResult
        Dim btMsgs As BarTender.Messages = Nothing
        Dim msg As BarTender.Message
        Dim template As String

        template = Application.StartupPath & "\template\InLabel_itest.btw"

        btapp = New BarTender.Application  '加载bartender软件
        btapp.Visible = False

        btformat = btapp.Formats.Open(template, False, "") '加载BTW模板

        btformat.SetNamedSubStringValue("cust", cust)
        btformat.SetNamedSubStringValue("cprod", cprod)
        btformat.SetNamedSubStringValue("clot", clot)
        btformat.SetNamedSubStringValue("iprod", iprod)
        btformat.SetNamedSubStringValue("ilot", ilot)
        btformat.SetNamedSubStringValue("wqty", wqty)
        btformat.SetNamedSubStringValue("waferlist", waferlist)
        btformat.SetNamedSubStringValue("Indate", Indate)

        btformat.IdenticalCopiesOfLabel = 1
        btformat.PrintOut(False, False)


        If (btPrintRtn <> BarTender.BtPrintResult.btSuccess) Then
            InLabel_itest_Print = False '打印失败
            For Each msg In btMsgs
                MessageBox.Show(msg.Message)
            Next msg
        Else
            InLabel_itest_Print = True '打印成功
        End If

        btapp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)

    End Function

    Public Function OutLabel_itest_Print(cust As String, cprod As String, clot As String, fprod As String, flot As String, wqty As Integer, waferlist As String, FinalGoodDie As String, Outdate As String) As Boolean

        Dim btapp As BarTender.Application '定义bartender
        Dim btformat As BarTender.Format
        Dim btPrintRtn As BarTender.BtPrintResult
        Dim btMsgs As BarTender.Messages = Nothing
        Dim msg As BarTender.Message
        Dim template As String

        template = Application.StartupPath & "\template\OutLabel_itest.btw"

        btapp = New BarTender.Application  '加载bartender软件
        btapp.Visible = False

        btformat = btapp.Formats.Open(template, False, "") '加载BTW模板

        btformat.SetNamedSubStringValue("cust", cust)
        btformat.SetNamedSubStringValue("cprod", cprod)
        btformat.SetNamedSubStringValue("clot", clot)
        btformat.SetNamedSubStringValue("fprod", fprod)
        btformat.SetNamedSubStringValue("flot", flot)
        btformat.SetNamedSubStringValue("wqty", wqty)
        btformat.SetNamedSubStringValue("waferlist", waferlist)
        btformat.SetNamedSubStringValue("finalgooddie", FinalGoodDie)
        btformat.SetNamedSubStringValue("Outdate", Outdate)

        btformat.IdenticalCopiesOfLabel = 1
        btformat.PrintOut(False, False)


        If (btPrintRtn <> BarTender.BtPrintResult.btSuccess) Then
            OutLabel_itest_Print = False '打印失败
            For Each msg In btMsgs
                MessageBox.Show(msg.Message)
            Next msg
        Else
            OutLabel_itest_Print = True '打印成功
        End If

        btapp.Quit(BarTender.BtSaveOptions.btDoNotSaveChanges)

    End Function

    '格式: 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25
    Public Function FormatWaferlist1(waferlist As String) As String
        Dim i As Integer

        If Len(waferlist) <> 25 Then
            MsgBox("获取WaferList信息错误!", vbOKOnly, vbExclamation)
            FormatWaferlist1 = "Error"
            Exit Function
        End If

        For i = 1 To 25

            If waferlist.Substring(i - 1, 1) = "1" Then

                FormatWaferlist1 += i & ","

            End If

        Next

        FormatWaferlist1 = FormatWaferlist1.Substring(0, Len(FormatWaferlist1) - 1)

    End Function

    ' waferlist 0100000000000111111110
    ' 格式: #2-23,25
    Public Function FormatWaferlist2(waferlist As String) As String
        Dim i As Integer, firstflag As Boolean

        If Len(waferlist) <> 25 Then
            MsgBox("获取WaferList信息错误!", vbOKOnly, vbExclamation)
            FormatWaferlist2 = "Error"
            Exit Function
        End If

        For i = 1 To 25

            If waferlist.Substring(i - 1, 1) = "1" Then
                If firstflag = False Then
                    FormatWaferlist2 += i & "-"
                    firstflag = True
                Else
                    'do nothing
                End If
            Else
                If firstflag = True Then
                    If CInt(FormatWaferlist2.Substring(Len(FormatWaferlist2) - 2, 1)) < i - 1 Then
                        FormatWaferlist2 += (i - 1) & ","
                    Else
                        FormatWaferlist2 = FormatWaferlist2.Substring(0, Len(FormatWaferlist2) - 1) + ","
                    End If

                    firstflag = False

                Else
                    'donothing

                End If

            End If

        Next

        If Strings.Right(FormatWaferlist2, 1) = "-" Then
            If InStr(FormatWaferlist2, "25") = 0 Then
                FormatWaferlist2 = FormatWaferlist2.Substring(0, Len(FormatWaferlist2)) + "25"
            Else
                FormatWaferlist2 = FormatWaferlist2.Substring(0, Len(FormatWaferlist2) - 1)
            End If

        ElseIf Strings.Right(FormatWaferlist2, 1) = "," Then
            FormatWaferlist2 = FormatWaferlist2.Substring(0, Len(FormatWaferlist2) - 1)
        End If

        FormatWaferlist2 = "#" & FormatWaferlist2
        Console.Write(waferlist & "->" & FormatWaferlist2)

    End Function


    Public Function GetEmployeeNamebyID(id As String) As String

        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Employee where ID='" & id & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            GetEmployeeNamebyID = "查询失败"
        Else
            GetEmployeeNamebyID = mydataset.Tables("Employee").Rows(0).Item("cname")
        End If

    End Function

    Public Function GetEmployeeGrpbyID(id As String) As String
        Dim mysql As String
        Dim mydataset As New DataSet

        mysql = "select * from Employee where ID='" & id & "'"

        Dim myadapter As New SqlDataAdapter(mysql, myconn)

        myadapter.Fill(mydataset, "Employee")

        If mydataset.Tables("Employee").Rows.Count = 0 Then
            GetEmployeeGrpbyID = "查询失败"
        Else
            GetEmployeeGrpbyID = mydataset.Tables("Employee").Rows(0).Item("Department")
        End If
    End Function


    Public Function CloseCurrentStatus(status As String) As Boolean



        Select Case status


            Case "SETUP"

                If frmUtiSetupClose.ShowDialog() = DialogResult.OK Then
                    CloseCurrentStatus = True
                End If

            Case "RUN", "REWORK"

                If frmUtiRunClose.ShowDialog() = DialogResult.OK Then
                    CloseCurrentStatus = True
                End If

            Case "CORR"

                If frmUtiCorrClose.ShowDialog() = DialogResult.OK Then
                    CloseCurrentStatus = True
                End If

            Case "DOWN"

                If frmUtiDownClose.ShowDialog() = DialogResult.OK Then
                    CloseCurrentStatus = True
                End If


            Case Else
                CloseCurrentStatus = True

        End Select


    End Function

    Public Function OpenNextStatus(status As String) As Boolean

        Select Case status


            Case "SETUP"

                If frmUtiSetupOpen.ShowDialog() = DialogResult.OK Then
                    OpenNextStatus = True
                End If


            Case "RUN", "REWORK"

                If frmUtiRunOpen.ShowDialog() = DialogResult.OK Then
                    OpenNextStatus = True
                End If

            Case "CORR"

                If frmUtiCorrOpen.ShowDialog() = DialogResult.OK Then
                    OpenNextStatus = True
                End If


            Case "DOWN"

                If frmUtiDownOpen.ShowDialog() = DialogResult.OK Then
                    OpenNextStatus = True
                End If


            Case Else
                OpenNextStatus = True

        End Select


    End Function









End Module
