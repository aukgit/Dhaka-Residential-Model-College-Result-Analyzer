Imports VB = Microsoft.VisualBasic
'Imports Drmc_DatabaseSoft_by_Auk.AukFunC


Public Module AukMod
    Public Trd As Boolean
    Public Aukm As New AukMath
    Public ComRow As Integer
    Public MainMenu As New Form
    Public I As Integer
    Public Acc As String
    Public DV As New DataGridView
    Public DG As New DataGrid
    Public What As String = "Are you want to "
    'Public Con As String = "Provider=Microsoft.Jet.OleDb.4.0;" _
    '& "Data Source=" & Application.StartupPath & "\auksoft.aukbased;"
    'Public Adp As New OleDb.OleDbDataAdapter
    'Public DSet As New DataSet
    'Public DTab As New DataTable
    'Public DCol As New DataColumn
    'Public Acc As String
    Public DRow, DColumn As Integer
    Public ChgTab As String
    Public Copy1(16) As Object
    Public Copy1x As Boolean
    'Public UpFr As Object
    Public Frm As New Form
    Public VTab As String
    Public ClasT As String
    Public Sec As String
    Public Subject As String
    Public Shift As String
    Public SubPos As Integer

    Public Marks As String
    Public Sign As String
    Public Term As String
    Public Yearx As String
    Public MrkT As Boolean
    Public Ac1Sec As Boolean
    Public SubID As String
    Public MainID As String
    Public UMainID As String
    Public MainFrm As New Form
    Public Declare Function GetWindowLong Lib "user32" Alias "GetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer) As Integer
    Public Declare Function SetWindowLong Lib "user32" Alias "SetWindowLongA" (ByVal hwnd As Integer, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
    Public Declare Function ShowWindow Lib "user32" (ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As String) As Integer
    Public Declare Function ReleaseCapture Lib "user32" () As Integer
    Public Declare Function GetPixel Lib "gdi32" (ByVal hDC As Integer, ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Declare Function SetWindowRgn Lib "user32" (ByVal hwnd As Integer, ByVal hRgn As Integer, ByVal bRedraw As Boolean) As Integer
    Public Declare Function CreateRectRgn Lib "gdi32" (ByVal x1 As Integer, ByVal Y1 As Integer, ByVal x2 As Integer, ByVal Y2 As Integer) As Integer
    Public Declare Function CombineRgn Lib "gdi32" (ByVal hDestRgn As Integer, ByVal hSrcRgn1 As Integer, ByVal hSrcRgn2 As Integer, ByVal nCombineMode As Integer) As Integer
    Public Declare Function DeleteObject Lib "gdi32" (ByVal hObject As Integer) As Integer
    Public AukF As New AukFunC
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    Public Declare Function SetLayeredWindowAttributes Lib "user32" (ByVal hwnd As Integer, ByVal crKey As Integer, ByVal bAlpha As Byte, ByVal dwFlags As Integer) As Integer
    Public WGeT As String
    Public Sups As String
    Public Cmd As String
    Public xF As String
    Public Res As Boolean
    Public WGD As String
    Public WGH As String
    Public WXY As String
    Public CKPlace As String
    Public MaxStr As String
    'Public SupS As String
    Public StPos As String
    Public EndPos As String
    Public Const GWL_EXSTYLE As Short = (-20)
    Public Const WS_EX_LAYERED As Integer = &H80000
    Public Const LWA_ALPHA As Short = &H2S

    'Public Sql As String

    Public Const SW_HIDE As Short = 0
    Public Const SW_SHOW As Short = 5

    Public Const WS_EX_TOOLWINDOW As Integer = &H80
    Public Function GetPersentise(ByVal NumberConvertsToPersent As String, ByVal TotalValue As String)
        GetPersentise = ((Val(NumberConvertsToPersent)) * 100) / Val(TotalValue)
        WGeT = GetPersentise
        'MsgBox(Val(NumberConvertsToPersent), , "Con")



    End Function
    Public Function SetNumber(ByVal SetPersentiseX As String, ByVal TotalValue As String)
        SetNumber = ((Val(SetPersentiseX)) * 100) / Val(TotalValue)

        WGeT = SetNumber




    End Function

    Public Function ConvertAndSentsConvetrs(ByVal SelfNumber As String, ByVal Total As String, ByVal Convert As String)
        SelfNumber = Val(SelfNumber)
        'MsgBox(SelfNumber, , "se")
        Total = Val(Total)
        Convert = Val(Convert)
        cg = GetPersentise(SelfNumber, Total)
        'MsgBox(cg)
        cf = Val((Convert * cg) / 100)

        ConvertAndSentsConvetrs = cf
        'MsgBox(Val(ConvertAndSentsConvetrs), , "converts")
        WGeT = ConvertAndSentsConvetrs

    End Function




    Public Function Cbc_pl(ByRef WP As String) As String
        Cbc_pl = RStr2(WP, ")", "UppI", True)
        Cbc_pl = RStr2(WP, "(", "ThRwZ", True)
    End Function

    Public Function Ebx3(ByVal Exp As Exception)
        vgb = "(ExecptionMessage : " & Exp.Message & ")"
        vgb2 = "(ExecptionSource : " & Exp.Source & ")"

        fg = vgb & vbNewLine _
         & vgb2

        MsgBox(fg, MsgBoxStyle.Critical, "AukSoftware's (0171-1334201)")


    End Function
    Public Function Ebx3(ByVal Exp As Exception, ByVal ErrNum As String, ByVal ErrDes As String)
        vgb = "(Error Number : " & """" & ErrNum & """)" & vbNewLine _
               & "(ExecptionMessage : " & Exp.Message & ")"
        vgb2 = "(Error Description : " & ErrDes & ")" & vbNewLine _
                 & "(ExecptionSource : " & Exp.Source & ")"

        fg = vgb & vbNewLine _
         & vgb2

        MsgBox(fg, MsgBoxStyle.Critical, "AukSoftware's (0171-1334201)")


    End Function
    Public Function Ebx(ByVal ErrN As String, ByVal ErrD As String)
        vgb = "(Error Number : " & """" & ErrN & """):" & vbNewLine _
                                                   & ErrD
        gb2 = "Error Source : " & Err.Source
        cfew = vgb & vbNewLine _
         & gb2
        MsgBox(cfew, MsgBoxStyle.Critical, "You have done a greate mistake(Auksoftware's)Contact With Alim (01711334201,0193-500863)")



    End Function
   
    Public Function xT(ByVal text As TextBox) As Boolean
        If Trim(text.Text) = "" Then
            xT = True
        Else
            xT = False
        End If
    End Function
    Public Function Epx()
        Ebx(Err.Number, Err.Description)
    End Function
    Public Function Epx2()
        Ebx(Err.Number, Err.Description, Err.Description)
    End Function
    Public Function Epx2(ByVal Tit As String)
        Ebx(Err.Number, Err.Description, Tit)
    End Function
    Public Function Ebx(ByVal ErrN As String, ByVal ErrD As String, ByVal Tit As String)
        vgb = "(Error Number : " & """" & ErrN & """):" & vbNewLine _
                                                   & ErrD
        MsgBox(vgb, MsgBoxStyle.Critical, Tit)



    End Function
    Public Function Cbc_pl_back(ByRef WP As String) As String
        Cbc_pl_back = RStr2(WP, "ThRwZ", "(", True)
        Cbc_pl_back = RStr2(WP, "UppI", ")", True)
    End Function
    Public Function Sav(ByRef Which As System.Windows.Forms.TextBox, ByRef TextFileName As String) As String
        FileOpen(1, TextFileName, OpenMode.Output)
        PrintLine(1, Which.Text)
        FileClose(1)
        Which.Text = Mid(Which.Text, 1, Len(Which.Text) - 1)
    End Function


    Public Function RStr(ByRef Which As System.Windows.Forms.TextBox, ByVal WhatF As String, ByRef WhatRep As String, ByRef MatchCase As Boolean) As String
        Dim mx As String
        If MatchCase = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which.Text, WhatF, WhatRep)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RStr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which.Text = mx
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which.Text, WhatF, WhatRep, 1, -1, CompareMethod.Text)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object RStr. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which.Text = mx
        End If
    End Function
    Public Function RStr2(ByVal Which As String, ByVal WhatF As String, ByVal WhatRep As String, ByRef MatchCase As Boolean) As String
        Dim mx As String
        If MatchCase = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which, WhatF, WhatRep)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr2 = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which = mx
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            mx = Replace(Which, WhatF, WhatRep, 1, -1, CompareMethod.Text)
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            RStr2 = mx
            'UPGRADE_WARNING: Couldn't resolve default property of object mx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Which = mx
        End If

    End Function
    Public Function xo(ByVal Max As String) As String
        'Dim m As String
        'Dim a As String
        On Error Resume Next
        For a = 1 To Len(Max)
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            m = Mid(Max, a, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Mid(Max, a, 1) = Chr(Asc(m) + 5)
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object xo. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xo = Max
    End Function

    Public Function xo_back(ByVal Max As String) As String
        'Dim m As String
        'Dim a As String
        On Error Resume Next
        For a = 1 To Len(Max)
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            m = Mid(Max, a, 1)
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object a. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Mid(Max, a, 1) = Chr(Asc(m) - 5)
        Next
        'UPGRADE_WARNING: Couldn't resolve default property of object xo_back. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        xo_back = Max
    End Function
    Public Function Findx(ByVal FndTxt As String, ByVal WhatFind As String, ByVal StartPos As String, ByRef MatchCase As Boolean) As Boolean
        Dim fg As String
        'MsgBox WhatFind

        If MatchCase = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            fg = InStr(CShort(StartPos), FndTxt, WhatFind)
            'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If fg = 0 Then
                Res = False
            Else
                Res = True
                'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                StPos = fg
                'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                EndPos = CStr(Val(fg) + Len(WhatFind))
            End If
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            fg = InStr(CShort(StartPos), FndTxt, WhatFind, CompareMethod.Text)
            'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If fg = 0 Then
                Res = False
            Else
                Res = True
                'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                StPos = fg
                'UPGRADE_WARNING: Couldn't resolve default property of object fg. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                EndPos = CStr(Val(fg) + Len(WhatFind))
            End If
        End If
        Findx = Res

    End Function

    Public Function AutoFind(ByVal ftxt As String, ByVal What As String, ByVal StartPos As String, ByVal Enp As Boolean, ByRef MatchCase As Boolean) As String
        Dim cx As String
        On Error Resume Next
        Findx(ftxt, What, StartPos, MatchCase)
        'MsgBox Res

        If Res = True Then
            If Mid(ftxt, CInt(EndPos), 1) = "(" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object cx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                cx = InStr(CShort(EndPos), ftxt, ")")
                'UPGRADE_WARNING: Couldn't resolve default property of object cx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If cx > 0 Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object cx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    WGeT = Mid(ftxt, CDbl(EndPos) * 1 + 1, cx - (CDbl(EndPos) * 1 + 1))
                Else
                    WGeT = Mid(ftxt, CDbl(EndPos) * 1 + 1)
                End If

            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object cx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                cx = InStr(CShort(EndPos), ftxt, ")")
                WGeT = ""
                AutoFind = WGeT
                AutoFind(ftxt, What, cx, Enp, MatchCase)
            End If
        ElseIf Res = False Then
            WGeT = ""
            AutoFind = WGeT
            Exit Function

        End If

        If Enp = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Cbc_pl_back(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WGeT = Cbc_pl_back(WGeT)
            'UPGRADE_WARNING: Couldn't resolve default property of object xo_back(). Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WGeT = xo_back(WGeT)
        End If

        AutoFind = WGeT
    End Function


End Module
