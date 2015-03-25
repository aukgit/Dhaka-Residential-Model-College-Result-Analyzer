Public Class FlashNet

    Public Function XGetFlashMovie_xPosition(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim GetFlashMovie_xPosition As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 0)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFlashMovie_xPosition. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFlashMovie_xPosition = POs
    End Function
    Public Function YGetFlashMovie_yPosition(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 1)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object YGetFlashMovie_yPosition. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        YGetFlashMovie_yPosition = POs
    End Function

    Public Function GetFlashMovie_Height(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 9)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFlashMovie_Height. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFlashMovie_Height = POs
    End Function

    Public Function GetFlashMovie_Width(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 8)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFlashMovie_Width. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFlashMovie_Width = POs
    End Function

    Public Function GetFlashMovie_Alpha(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 6)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFlashMovie_Alpha. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFlashMovie_Alpha = POs
    End Function
    Public Function GetFlashMovie_Visible(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String) As Object
        Dim POs As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, 7)
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object GetFlashMovie_Visible. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        GetFlashMovie_Visible = POs
    End Function

    Public Function SetFlashMovie_Visible(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String, ByVal Numx As String) As Object
        Dim POs As Object
        Dim Hj As String
        Hj = CStr(7)
        fla.TSetProperty(MovieName, CShort(Hj), Str(Val(Numx)))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, CShort(Hj))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SetFlashMovie_Visible. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SetFlashMovie_Visible = POs
    End Function
    Public Function SetFlashMovie_Alpha(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String, ByVal Numx As String) As Object
        Dim POs As Object
        Dim Hj As String
        Hj = CStr(6)
        fla.TSetProperty(MovieName, CShort(Hj), Str(Val(Numx)))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, CShort(Hj))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SetFlashMovie_Alpha. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SetFlashMovie_Alpha = POs
    End Function
    Public Function SetFlashMovie_XPosition(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String, ByVal Numx As String) As Object
        Dim POs As Object
        Dim Hj As String
        Hj = CStr(0)
        fla.TSetProperty(MovieName, CShort(Hj), Str(Val(Numx)))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        POs = fla.TGetProperty(MovieName, CShort(Hj))
        'UPGRADE_WARNING: Couldn't resolve default property of object POs. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SetFlashMovie_XPosition. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        SetFlashMovie_XPosition = POs
    End Function

    Public Function SetFlashMovie_Height(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String, ByRef Strs As String) As Object
        fla.TSetProperty(MovieName, 9, Str(CDbl(Strs)))

    End Function

    Public Function SetFlashMovie_Width(ByRef fla As ShockwaveFlashObjects.ShockwaveFlash, ByVal MovieName As String, ByRef Strs As String) As Object
        fla.TSetProperty(MovieName, 8, Str(CDbl(Strs)))
    End Function

End Class
