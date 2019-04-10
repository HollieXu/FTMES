Module MyChecksum


    ' Wafer OCR Checksum Verify module
    ' Vanni Jiang


    Public Function CheckSumVerify(Fablot As String, WID As String, OCRFormat As String) As String

        Dim DummyOCR As String
        Dim TotalSum As Object
        Dim aa As String, a1 As String, a2 As String
        Dim i As Integer, ModValue As Integer

        CheckSumVerify = ""

        'OCR 格式篩選, DummyOCR CheckSum初始值均為"A0"
        Select Case OCRFormat
            Case "TSMC"
                DummyOCR = Left(Fablot, 6) + "-" + WID + "A0"         ' LLLLLL-SS??
            Case "SMIC"
                DummyOCR = Left(Fablot, 6) + "-" + WID + "-" + "A0"   ' LLLLLL-SS-??
            Case "HJ"
                DummyOCR = Left(Fablot, 5) + WID + "-" + "A0"         ' LLLLL-SS-??
            Case Else
                Exit Function  ' Other formats not defined
        End Select


        '計算總sum值
        For i = Len(DummyOCR) To 1 Step -1
            TotalSum = (Asc(Mid(DummyOCR, i, 1)) - 32) * (8 ^ (Len(DummyOCR) - i)) + TotalSum
        Next


        'CheckSum 計算
        ModValue = MyMod(TotalSum, 59)  ' VB6 原有的Mod函數只支持到Long類型,計算過大的數值時會發生Overflow Error!

        If ModValue = 0 Then
            aa = Right(Byte2Binary(0), 6)
        Else
            aa = Right(Byte2Binary(59 - ModValue), 6)
        End If

        a1 = Chr(Asc("A") + Binary2Val(Mid(aa, 1, 3)))
        a2 = Chr(Asc("0") + Binary2Val(Mid(aa, 4, 3)))

        '獲得完整OCR String
        Select Case OCRFormat
            Case "TSMC"
                CheckSumVerify = Left(Fablot, 6) + "-" + WID + a1 + a2
            Case "SMIC"
                CheckSumVerify = Left(Fablot, 6) + "-" + WID + "-" + a1 + a2
            Case "HJ"
                CheckSumVerify = Left(Fablot, 5) + WID + "-" + a1 + a2
            Case Else
                Exit Function  ' Other formats not defined
        End Select

    End Function


    Public Function MyMod1(mmm As Object, nnn As Object) As Integer

        Do While mmm >= nnn
            mmm = mmm - nnn
        Loop
        MyMod1 = mmm

    End Function


    Public Function MyMod(mmm As Object, nnn As Object) As Integer

        Do While mmm >= nnn

            Select Case mmm

                Case Is > 100000 * nnn
                    mmm = mmm - 100000 * nnn
                Case Is > 10000 * nnn
                    mmm = mmm - 10000 * nnn
                Case Is > 1000 * nnn
                    mmm = mmm - 1000 * nnn
                Case Is > 100 * nnn
                    mmm = mmm - 100 * nnn
                Case Is > 10 * nnn
                    mmm = mmm - 10 * nnn
                Case Else
                    mmm = mmm - nnn
            End Select

        Loop

        MyMod = mmm

    End Function



    Public Function GetByte(SrcArr() As Byte, StartPos As Long, EndPos As Long) As String
        Dim i As Long
        For i = StartPos To EndPos
            GetByte = GetByte + Chr(SrcArr(i))
        Next i
    End Function


    Public Function GetHex(SrcArr() As Byte, StartPos As Long, EndPos As Long) As String
        Dim i As Long
        For i = StartPos To EndPos
            GetHex = GetHex + CStr(SrcArr(i))
        Next i
    End Function


    Public Function GetBinary(SrcArr() As Byte, StartPos As Long, EndPos As Long) As String
        Dim i As Long
        For i = StartPos To EndPos
            GetBinary = GetBinary + Byte2Binary(SrcArr(i))
        Next i
    End Function


    Public Function Byte2Binary(ByVal onebyte As Byte) As String     'Byte  Val To Binary String,1-->"00000001"
        Dim tempdbl As Long

        Do While (onebyte >= 2)
            tempdbl = onebyte Mod 2
            Byte2Binary = CStr(tempdbl) + Byte2Binary
            onebyte = (onebyte - tempdbl) / 2
        Loop
        tempdbl = onebyte Mod 2
        Byte2Binary = CStr(tempdbl) + Byte2Binary
        Do While (Len(Byte2Binary) < 8)
            Byte2Binary = "0" + Byte2Binary
        Loop
    End Function


    Public Function Binary2Val(ByVal Binarystr As String) As Object   'Binary string to decimal
        Dim i As Integer
        Dim tempchar As String
        Dim strlength As Integer
        Dim quan As Object
        quan = 1
        Binary2Val = 0
        strlength = Len(Binarystr)
        For i = 1 To strlength
            tempchar = Mid(Binarystr, strlength - i + 1, 1)
            If (tempchar = "1") Then
                Binary2Val = Binary2Val + quan
                '    Debug.Print i, Binary2Val
            End If
            quan = quan * 2
        Next
    End Function





End Module
