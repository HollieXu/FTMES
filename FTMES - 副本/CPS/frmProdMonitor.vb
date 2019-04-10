
Imports System.Data.SqlClient
Imports System.Xml

Public Class frmProdMonitor

    Dim equiparray() As Button
    Dim CurrentFloor As String


    Private Sub frmProdMonitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = mydefaultcolor
        GroupBox1.BackColor = mydefaultcolor
        GroupBox2.BackColor = mydefaultcolor
        Panel1.BackColor = mydefaultcolor
        btn_refresh.BackColor = mydefaultcolor
        CurrentFloor = "F1"
        Call ShowEquip(CurrentFloor)
    End Sub

    Private Sub rb_F1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_F1.CheckedChanged
        If rb_F1.Checked = True Then
            CurrentFloor = "F1"
            Call ShowEquip(CurrentFloor)
        End If
    End Sub

    Private Sub rb_F2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_F2.CheckedChanged
        If rb_F2.Checked = True Then
            CurrentFloor = "F2"
            Call ShowEquip(CurrentFloor)
        End If
    End Sub

    Private Sub rb_F3_CheckedChanged(sender As Object, e As EventArgs) Handles rb_F3.CheckedChanged
        If rb_F3.Checked = True Then
            CurrentFloor = "F3"
            Call ShowEquip(CurrentFloor)
        End If
    End Sub

    Private Function ShowEquip(Floor As String) As Boolean

        Dim i As Integer
        Dim mysql As String
        Dim mydataset As New DataSet
        Dim FloorSelect As String
        Dim testerid As String, position As Integer

        Me.equiparray = New Button() {T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25,
            T26, T27, T28, T29, T30, T31, T32, T33, T34, T35, T36, T37, T38, T39, T40, T41, T42, T43, T44, T45, T46, T47, T48, T49, T50, T51, T52, T53, T54, T55}

        '初始化，全部隐藏
        For i = 0 To UBound(equiparray)
            equiparray(i).BackColor = Color.Silver
            equiparray(i).Visible = False
        Next

        '查询MES DB 机台enable / floor / position，显示机台

        mysql = "select * from Equipment where Floor='" & Floor & "' AND Enable='true'"
        Dim myadapter As New SqlDataAdapter(mysql, myconn)
        myadapter.Fill(mydataset, "equip")

        If mydataset.Tables("equip").Rows.Count > 0 Then
            For i = 0 To mydataset.Tables("equip").Rows.Count - 1
                testerid = mydataset.Tables("equip").Rows(i).Item("ID")
                position = mydataset.Tables("equip").Rows(i).Item("Position")

                equiparray(position - 1).Visible = True
                equiparray(position - 1).Text = testerid
                equiparray(position - 1).BackColor = SetStatusColor(GetTesterStatus(testerid))

            Next
        End If


    End Function

    Private Sub Tester_Click(sender As Object, e As EventArgs) Handles T1.Click, T2.Click, T3.Click, T4.Click, T5.Click, T6.Click, T7.Click, T8.Click, T9.Click, T10.Click,
        T11.Click, T12.Click, T13.Click, T14.Click, T15.Click, T16.Click, T17.Click, T18.Click, T19.Click, T20.Click, T21.Click, T22.Click, T23.Click, T24.Click, T25.Click, T26.Click, T27.Click, T28.Click, T29.Click, T30.Click,
        T31.Click, T32.Click, T33.Click, T34.Click, T35.Click, T36.Click, T37.Click, T38.Click, T39.Click, T40.Click, T41.Click, T42.Click, T43.Click, T44.Click, T45.Click, T46.Click, T47.Click, T48.Click, T49.Click, T50.Click,
        T51.Click, T52.Click, T53.Click, T54.Click, T55.Click

        UtilizationIdx = CType(sender, Button).Text
        frmUtilization.Show()

    End Sub



    Private Sub TB_refresh_Scroll(sender As Object, e As EventArgs) Handles TB_refresh.Scroll
        txt_period.Text = TB_refresh.Value * 60
        Timer1.Interval = txt_period.Text * 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call ShowEquip(CurrentFloor)
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Call ShowEquip(CurrentFloor)
    End Sub

End Class