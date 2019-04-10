
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel


Public Class frmWaferOCR

    Dim i As Integer
    Dim iprod As String
    Dim flot As String
    Dim fsite As String



    Private Sub btn_query_Click(sender As Object, e As EventArgs) Handles btn_query.Click

        If txt_flot.Text <> "" Then
            flot = txt_flot.Text
        Else
            MsgBox("Fab Lot 未设定!", vbOKOnly + vbExclamation)
        End If

        If rb_tsmc.Checked = True Then
            fsite = "TSMC"
        ElseIf rb_smic.Checked = True Then
            fsite = "SMIC"
        ElseIf rb_hj.Checked = True Then
            fsite = "HJ"
        ElseIf rb_hhgrace.Checked = True Then
            fsite = "HHGRACE"
        Else
            fsite = ""
        End If

        RTB_waferocr.Text = ""

        For i = 1 To 25
            RTB_waferocr.Text += CheckSumVerify(flot, CStr(Format(i, "00")), fsite) + vbCrLf
        Next

        ' 以下代码用于debug

        '''For i = 1 To 25
        '''    Console.WriteLine(CheckSumVerify("HHN079.2", CStr(Format(i, "00")), "TSMC"))
        '''Next

        '''For i = 1 To 25
        '''    Console.WriteLine(CheckSumVerify("NAKC7.2", CStr(Format(i, "00")), "HJ"))
        '''Next

        '''For i = 1 To 25
        '''    Console.WriteLine(CheckSumVerify("E6E770", CStr(Format(i, "00")), "SMIC"))
        '''Next

    End Sub

    Private Sub combo_preview_Click(sender As Object, e As EventArgs) Handles combo_preview.Click

        Dim i As Integer
        Dim myexcel As New Excel.Application()

        Dim template As String
        Dim blank As String
        Dim desfile As String

        template = Application.StartupPath & "\template\cp_waferocr.xlsx"
        blank = Application.StartupPath & "\template\blank.xlsx"
        desfile = Application.StartupPath & "\tempdata\waferocr.xlsx"

        '复制空白Excel
        FileCopy(blank, desfile)

        Dim mybk1 As Excel.Workbook = myexcel.Workbooks.Open(template)
        Dim mybk2 As Excel.Workbook = myexcel.Workbooks.Open(desfile)

        myexcel.Visible = False
        myexcel.DisplayAlerts = False
        myexcel.AlertBeforeOverwriting = False

        mybk1.Worksheets("WaferOCR").copy(After:=mybk2.Worksheets(1))
        mybk2.Worksheets(mybk2.Worksheets.Count).name = "WaferOCR"

        With mybk2.Worksheets(mybk2.Worksheets.Count)

            .range("D2") = fsite
            .range("D3") = flot

            For i = 1 To 25
                .range("A" & （4 + i）) = i
                .range("D" & （4 + i）) = CheckSumVerify(flot, CStr(Format(i, "00")), fsite)
            Next

        End With


        mybk2.Worksheets(1).delete

        mybk1.Close()
        mybk2.Worksheets("WaferOCR").Activate()
        mybk2.Save()
        myexcel.ActiveSheet.Printout
        myexcel.Workbooks.Close()
        myexcel.Quit()

        '释放进程
        mybk1 = Nothing
        mybk2 = Nothing
        myexcel = Nothing
        System.GC.Collect()

        MsgBox("Print Ok!", vbOKOnly + vbInformation)

    End Sub

    Private Sub frmWaferOCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
    End Sub

    Private Sub txt_ilot_TextChanged(sender As Object, e As EventArgs) Handles txt_ilot.TextChanged

        Dim i As Integer
        Dim mysql As String
        Dim mydataset As New DataSet

        If Len(txt_ilot.Text) = 12 Then

            mysql = "select * from WIPLOT where iTestLotNo='" & txt_ilot.Text & "'"
            Dim myadapter As New SqlDataAdapter(mysql, myconn)
            myadapter.Fill(mydataset, "WIP")

            If mydataset.Tables("WIP").Rows.Count = 0 Then
                MsgBox("批号查询失败,请核对!", vbOKOnly + vbExclamation)
            Else
                iprod = mydataset.Tables("WIP").Rows(i).Item("iTestProduct")
                txt_flot.Text = mydataset.Tables("WIP").Rows(i).Item("CustLotNo")
            End If

            mydataset.Clear()

            mysql = "select * from Product where InternalProduct='" & iprod & "'"
            Dim myadapter2 As New SqlDataAdapter(mysql, myconn)
            myadapter2.Fill(mydataset, "PROD")

            If mydataset.Tables("PROD").Rows.Count = 0 Then
                MsgBox("产品信息查询失败,请核对!", vbOKOnly + vbExclamation)
            Else
                fsite = mydataset.Tables("PROD").Rows(i).Item("Fabsite")
            End If

            mydataset.Clear()

            Select Case UCase(fsite)

                Case "TSMC"

                    rb_tsmc.Checked = True

                    rb_smic.Enabled = False
                    rb_hj.Enabled = False
                    rb_hhgrace.Enabled = False

                Case "SMIC"

                    rb_smic.Checked = True

                    rb_tsmc.Enabled = False
                    rb_hj.Enabled = False
                    rb_hhgrace.Enabled = False


                Case "HJ"

                    rb_hj.Checked = True

                    rb_tsmc.Enabled = False
                    rb_smic.Enabled = False
                    rb_hhgrace.Enabled = False

                Case "HHGRACE"

                    rb_hhgrace.Checked = True

                    rb_tsmc.Enabled = False
                    rb_smic.Enabled = False
                    rb_hj.Enabled = False

                Case Else

            End Select

        Else

            txt_flot.Text = ""
            rb_tsmc.Enabled = True
            rb_smic.Enabled = True
            rb_hj.Enabled = True
            rb_hhgrace.Enabled = True

        End If

    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click

        Me.Close()

    End Sub

End Class